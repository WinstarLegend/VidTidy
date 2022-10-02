using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static IEnumerator<string> files;                         //an enumerator for our found file paths
        public static List<string> folders = new List<string>();         //list of folders added to recent folders 
        public static List<string> reviewedPaths = new List<string>();   //list of reviewed files full paths(next'd or move'd)
        public static Point buttonlocation = new Point(0, 0);            //accumulator for point offset for recent video list


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void axVLCPlugin21_Enter(object sender, EventArgs e)
        {

        }

        private void buttonOpenFiles_Click(object sender, EventArgs e)
        {
            OpenFiles();

        }

        private void buttonNextVideo_Click(object sender, EventArgs e)
        {
            //Return if no files selected yet
            if (files == null)
            {
                MessageBox.Show("Open Files First");
                return;
            }

            reviewedPaths.Add(files.Current);
            //Attempt to play
            LoadNextFile();
        }


        private void buttonAddFolder_Click(object sender, EventArgs e)
        {
            AddFolders();
        }

        private void buttonMove_click(object sender, EventArgs e)
        {
            MoveFile();

        }


        private void buttonUncheck_Click(object sender, EventArgs e)
        {
            uncheckAll();
        }


        private void buttonOpenLocation_Click(object sender, EventArgs e)
        {
            if(files == null) { return; }
            Process.Start("explorer.exe", @Path.GetDirectoryName(files.Current));
        }
        private void buttonSaveFolders_Click(object sender, EventArgs e)
        {
            SaveFolders();

        }
        private void buttonLoadFolders_Click(object sender, EventArgs e)
        {
            LoadFolders();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DeleteFile();
        }
        private void buttonSaveSeen_Click(object sender, EventArgs e)
        {
            SaveSeen();
        }
        private void buttonLoadSeen_Click(object sender, EventArgs e)
        {
            LoadSeen();
        }
        private void labelRecentFolders_Click(object sender, EventArgs e)
        {

        }
        private void textBoxFileName_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBoxFileName_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxFileName.SelectionStart = 0;
            textBoxFileName.SelectionLength = textBoxFileName.Text.Length - Path.GetExtension(textBoxFileName.Text).Length;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you Really want to close?\nUnsaved Folders list and video progress will be lost", "Exit", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void MoveFile()
        {
            var currentFullPath = files.Current;
            //var currentName = Path.GetFileName(currentFullPath);
            var currentPath = Path.GetDirectoryName(currentFullPath);
            var newName = textBoxFileName.Text;
            var newPath = currentPath;

            if (!CheckValidFileName(newName))
            {
                MessageBox.Show("File name Invalid");
                return;
            }

            if (VLCPlugin.playlist.isPlaying) { VLCPlugin.playlist.stop(); }
            VLCPlugin.playlist.removeItem(VLCPlugin.playlist.currentItem);

            foreach (RadioButton r in panelRecentFolders.Controls)
            {
                if (r.Checked)
                    newPath = r.Text;
            }

            var newFullPath = newPath + "\\" + newName;


            if (!File.Exists(currentFullPath))
            {
                using (FileStream fs = File.Create(currentFullPath)){}
            }

            if (File.Exists(newFullPath))
            {
                DialogResult dialogResult = MessageBox.Show("File Name already exists, continue?", "File exists", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No) { return; }
                else if (dialogResult == DialogResult.Yes)
                {
                    File.Delete(newFullPath);
                }
            }
            try
            {
                File.Move(currentFullPath, (newFullPath));
                Console.WriteLine("{0} was moved to {1}.", currentFullPath, (newFullPath));
            }
            catch (Exception l)
            {
                Console.WriteLine("File move failed: {0}", l.ToString());
            }
            reviewedPaths.Add(newFullPath);
            LoadNextFile();
        }
        private void OpenFiles()
        {
            //I hate the folder browser dialog, its outta here unless I learn of a problem with CommonOpenFileDialog
            //FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            //if(folderBrowserDialog.ShowDialog() == DialogResult.OK)

            CommonOpenFileDialog commonFileDialog = new CommonOpenFileDialog();
            commonFileDialog.IsFolderPicker = true;
            if (commonFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var folderName = commonFileDialog.FileName;
                if (!folders.Contains(folderName))
                {
                    addToFolderList(folderName);
                }
                VLCPlugin.playlist.stop();
                VLCPlugin.playlist.clear();
                //Here we use the selected path to create an enumerable object that contains all files and files in subdirectories...
                //var enumerable = Directory.EnumerateFiles(folderBrowserDialog.SelectedPath, "*", SearchOption.AllDirectories);
                var enumerable = Directory.EnumerateFiles(commonFileDialog.FileName, "*", SearchOption.AllDirectories);
                //then we turn it into an enumerator...
                files = enumerable.GetEnumerator();
                // and load up the first file and attempt to play it
                LoadNextFile();

            }
        }
        private void DeleteFile()
        {
            DialogResult dialogResult = MessageBox.Show("Do you really want to delete this file", "Delete File", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            else if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    VLCPlugin.playlist.stop();
                    File.Delete(files.Current);
                }
                catch (Exception l)
                {
                    Console.WriteLine("Error deleting file {0} :{1}", files.Current, l.ToString());
                }
                LoadNextFile();
            }
        }
        private void AddFolders()
        {
            CommonOpenFileDialog commonOpenFileDialog = new CommonOpenFileDialog();
            commonOpenFileDialog.IsFolderPicker = true;
            if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                var foldername = commonOpenFileDialog.FileName;
                if (folders.Contains(foldername))
                {
                    MessageBox.Show("Folder already exists in list");
                }
                else
                {
                    addToFolderList(foldername);
                }
            }
        }
        private void LoadFolders()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] readfolders = File.ReadAllLines(openFileDialog.FileName);

                    foreach (string s in readfolders)
                    {
                        if (folders == null || !folders.Contains(s))
                        {
                            addToFolderList(s);
                        }
                    }
                }
                catch (Exception l)
                {
                    Console.WriteLine("Folder list load fail: {0}", l.ToString());
                }
            }
        }
        private void SaveFolders()
        {
            if (folders.Count == 0)
            {
                MessageBox.Show("No folders to save!");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "SavedFolders.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (TextWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (RadioButton r in panelRecentFolders.Controls)
                        {
                            writer.WriteLine(r.Text);
                        }
                    }
                }
                catch (Exception l)
                {
                    Console.WriteLine("Folders write failed:{0}", l.ToString());
                }
                reviewedPaths.Add(saveFileDialog.FileName);

            }
        }


        private bool CheckValidFileName(string filename)
        {
            var badChars = Path.GetInvalidFileNameChars();
            return !filename.Any(badChars.Contains);
        }

        private static void SaveSeen()
        {
            if (reviewedPaths.Count == 0)
            {
                MessageBox.Show("No seen files to save!");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Seen Files.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (TextWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (string s in reviewedPaths)
                        {
                            writer.WriteLine(s);
                        }
                    }
                    reviewedPaths.Add(saveFileDialog.FileName);
                }
                catch (Exception l)
                {
                    Console.WriteLine("Seen files write failed:{0}", l.ToString());
                }
            }
        }

        private static void LoadSeen()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] readFiles = File.ReadAllLines(openFileDialog.FileName);

                    foreach (string s in readFiles)
                    {
                        reviewedPaths.Add(s);
                    }
                }
                catch (Exception l)
                {
                    Console.WriteLine("Seen Files load fail: {0}", l.ToString());
                }
            }
        }

        private void uncheckAll()
        {
            foreach (RadioButton r in panelRecentFolders.Controls)
            {
                r.Checked = false;
            }
        }

        private void addToFolderList(string foldername)
        {
            folders.Add(foldername);
            RadioButton rb = new RadioButton();
            rb.Text = foldername;
            buttonlocation.Y += rb.Height;
            rb.Location = buttonlocation;
            rb.AutoSize = true;
            panelRecentFolders.Controls.Add(rb);
        }
        private void LoadNextFile()
        {
            var foundfile = false;
            while(files.MoveNext())
            {
                if (!reviewedPaths.Contains(files.Current))
                {
                    foundfile = true;
                    break;
                }
            }
            if (foundfile)
            {
                VLCPlugin.playlist.stop();
                VLCPlugin.playlist.removeItem(VLCPlugin.playlist.currentItem);

                //play that next video
                var filePath = files.Current;
                var fileName = Path.GetFileName(filePath);
                VLCPlugin.playlist.add(new Uri(filePath).AbsoluteUri);
                VLCPlugin.playlist.play();
                labelVideoName.Text = filePath;
                textBoxFileName.Text = fileName;
            }
            else
            {
                MessageBox.Show("No more files");
            }
        }
    }
}
