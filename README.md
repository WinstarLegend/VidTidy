# VidTidy
VidTidy is a Windows Forms Application for quickly sorting video, media, and other files. This project is made my me in my free time, so updates may be irregular, infrequent and/or nonexistent. Requires .Net 4.7.8 and VLC media player with the included activeX plugin installed.

# Features
- Play media files to be sorted in an embeded VLC window.
- Rename and move files.
- Add frequently used folders to a list to allow for faster sorting
- Remember seen files to prevent a sorted file from reapearing
- Save lists of frequently used folders for quick sorting.
- Save lists of seen files to resume sorting later.

# Planned Features
- Metadata editing
- VidTidy Currently depends on the VLC activeX plugin. I plan to replace this with a proper libVLC player, but that will require me to make my own controls, which will take time.
# Usage
To use VidTidy, start by using the Open Files button in the top left corner of the application, then selecting the folder containing the files which you wish to sort.
Doing so will queue all the files to be sorted, add that folder to the "Move to:" list, and begin media playback if the first file to be sorted is a file playable in VLC media player
The file's full path will become visible underneath the media player.

To rename and/or move the file, type the new name of the file into the text box in the lower right corner, and select a folder from the "Move to:" list. 
If you do not wish to move the file, don't select a folder on that list. To uncheck the selected item, hit the "Uncheck" button below the list.
If you do not wish to rename the file, simply do not enter new text into the renaming textbox.

If you do wish to leave the file unmoved and unrenamed, simply hit the next video button below the media player.

After moving or skipping a file, the next file will be brought up, until all files have been seen.

To save the list of reviewed files, click the "Save Seen Files'' button. Doing so will open a dialog to save the files that have been reviewed in the current session.
Loading this file with the "Load Seen Files" button before using the "Open Files" button in a new session will allow you to continue where you left off.

Similarly, the "Save Folders" and "Load Folders" buttons allow you to save your current list of folders for next time.

Both the reviewed files and saved folders lists are in plain text, so do not use this program in contexts where file or directory names are sensitive information.

# Build
VidTidy is built using Visual Studio 2019. To build open the solution in Visual Studio and build. A copy of VLC and the included activeX plugin must be installed on the build machine.

