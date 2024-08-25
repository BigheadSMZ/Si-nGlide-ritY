using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace nGlideConfig
{
    public class Paths
    {
       /*===================================================================================================================================
        * GENERAL PATH FUNCTIONS
        *===================================================================================================================================
        * Checks if a path exists. Avoids use of using it directly which can generate an error if the tested path is null. If the
        * paramaeter "IsDirectory" is set, the method will only ever return true if the InputPath is a folder.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static bool Test(string InputPath, bool IsDirectory=false)
        {
            // If the path is empty then it does not exist.
            if (InputPath == "" || InputPath == null) { return false; };

            // Attempt to pull attributes from the file/folder.
            try { FileAttributes Dummy = File.GetAttributes(InputPath); }

            // If the path doesn't exist catch the exception.
            catch (Exception x)
            {
                // All of this crap has popped up depending on the input paramter so catch it all.
                if (x is DirectoryNotFoundException || x is FileNotFoundException || x is ArgumentException) { return false; }            
            }
            // The above should already catch most paths or files that don't exist. But any paths or files that make it past
            // the exception, get the type that they are (path or file) then use the respective method to test if they exist.*/
            FileAttributes attr = File.GetAttributes(InputPath);

            // If it's a directory, check for that specific attribute.
            if (attr.HasFlag(FileAttributes.Directory))
            {
                return Directory.Exists(InputPath);
            }
            // If it's a file, check to see if only folder types will pass.
            else if (!IsDirectory)
            {
                return File.Exists(InputPath);
            }
            // If file checks were blocked, then we end up here so return false.
            return false;
        }
       /*===================================================================================================================================
        * Creates a folder if it does not already exist. Returns the parameter so it can be set to a variable when called.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static string Create(string InputPath, bool NoReturn=false)
        {
            // If the path is empty then it does not exist.
            if (InputPath == "" || InputPath == null) { return ""; };

            // Check to see if the path does not exist.
            if (!Paths.Test(InputPath))
            {
                // Create the path.
                Directory.CreateDirectory(InputPath);
            }
            // Return the path that was created.
            return InputPath;
        }
       /*===================================================================================================================================
        * Renames a folder using Directory.Move() since C# does not have its own rename option.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static void Rename(string Source, string Destination, bool Overwrite = false)
        {
            // Check to see if the file is to be overwritten.
            if (Overwrite && Paths.Test(Destination,true))
            {
                // Remove the file before trying to rename.
                Paths.Remove(Destination);
            }
            // Now rename the file using "move".
            Directory.Move(Source, Destination);
        }
       /*===================================================================================================================================
        * Removes a file or folder if it exists.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static void Remove(string InputPath)
        {
            // If the path is empty then it does not exist.
            if (InputPath == "" || InputPath == null) { return; };

            // Check to see if the path exists.
            if (Paths.Test(InputPath))
            {
                // Files and folders each have their own removal method.
                FileAttributes attr = File.GetAttributes(InputPath);

                // A true/false switch will make for some shorter/cleaner code.
                bool IsFolder = ((attr & FileAttributes.Directory) == FileAttributes.Directory);

                // Choose the appropriate method.
                switch(IsFolder)
                {
                    case true:  { Directory.Delete(InputPath,true); break; }
                    case false: { File.Delete(InputPath); break; }
                }
            }
        }
       /*===================================================================================================================================
        * Cleans out all items from a folder without actually removing the folder itself.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static void Clear(string InputPath)
        {
            // If the path is empty then it does not exist.
            if (InputPath == "" || InputPath == null) { return; };

            // Check to see if the path exists.
            if (Paths.Test(InputPath))
            {
                // Remove all files and folders from the input folder.
                foreach (string LoopFile in Enumerate.GetFiles(InputPath,Recurse:true))   { Paths.Remove(LoopFile); }
                foreach (string LoopFile in Enumerate.GetFolders(InputPath,Recurse:true)) { Paths.Remove(LoopFile); }
            }
        }
       /*===================================================================================================================================
        * If a path is valid, opens the directory in Windows file explorer.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static void OpenFileExplorer(string InputPath)
        {
            // Check to see if the path exists.
            if (Paths.Test(InputPath))
            {
                // Open the path in file explorer.
                Process.Start(InputPath);
            }
        }
       /*===================================================================================================================================
        * Takes a path (usually from a textbox) and gets the location of the file/folder to use as a start path for when selecting a file.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static string GetFileStartPath(string StartPath)
        {
            // See if the path provided exists.
            if (StartPath != "")
            {
                // Test to see if the path is a folder.
                if (Paths.Test(StartPath,true))
                {
                    // If the input is a folder, then just return that.
                    return StartPath;
                }
                // If it failed the folder test, then test if it exists as a file.
                else if (Paths.Test(StartPath))
                {
                    // Get the file that has been fed to the function.
                    FileItem StartItem = new FileItem(StartPath);

                    // If the input is a file, get the path the file is in.
                    return StartItem.DirectoryName;
                }
            }
            // If all else fails, start in the app path.
            return Config.BaseFolder;
        }
       /*===================================================================================================================================
        * Takes a path, checks to see if it has a backslash at the end of it, and if it does, remove it.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static string TruncateSlash(string Path)
        {
            // Get the length of the path minus the last character.
            int PathLength = Path.Length - 1;

            // Don't allow a final backslash in the path since it will be added manually.
            if (Path.Substring(PathLength, 1) == "\\")
            {
                // If a slash was found, keep everything but the slash.
                Path = Path.Substring(0, Path.Length - 1);
            }
            // If the path does not have a backslash, just return the path.
            return Path;
        }
       /*===================================================================================================================================
        * SPECIALIZED PATH FUNCTIONS
       /*===================================================================================================================================
        * Gets all hard drives available and exports them to a string array.
        *---------------------------------------------------------------------------------------------------------------------------------*/
        public static string[] GetDrives()
        {
            // Create a list that is easier to add elements to it.
            List<string> DriveList = new List<string>{};

            // Loop through all available drive letters.
            foreach (DriveInfo Drive in DriveInfo.GetDrives())
            {
                // Make sure it's a hard drive.
                if (Drive.DriveType.ToString() == "Fixed")
                {
                    // Add the drive to the list.
                    DriveList.Add(Drive.ToString());
                }
            }
            // Return the list as a string array.
            return Strings.ListToArray(DriveList);
        }
    }
}
