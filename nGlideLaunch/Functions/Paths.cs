﻿using System;
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
    }
}
