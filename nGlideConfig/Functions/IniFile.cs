using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

// Credits to Danny Beckett at stackoverflow.
// https://stackoverflow.com/questions/217902/reading-writing-an-ini-file

namespace nGlideConfig
{
    public partial class IniFile
    {
        string Path;
        string EXE = Assembly.GetExecutingAssembly().GetName().Name;

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

        [DllImport("kernel32", CharSet = CharSet.Unicode)]
        static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

        public IniFile(string IniPath = null)
        {
            Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
        }
        // I modified the "Read" method to include the ability to parse the data from any comments made after the value.
        public string Read(string Key, string Section = null)
        {
            // Read the value in the INI.
            var RetVal = new StringBuilder(255);
            GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);

            // Convert the value to a string.
            string RetValStr = RetVal.ToString();

            // Check to see if the INI file has comments.
            if (RetValStr.Contains("//"))
            {
                // Split the string on the comment characters.
                string[] RetValSplit = RetValStr.Split(new string[] { "//" }, StringSplitOptions.None);

                // Keep the first half which should be the value only.
                RetValStr = RetValSplit[0].TrimEnd();
            }
            // Return whatever the value is now.
            return RetValStr;
        }
        public void Write(string Key, string Value, string Section = null)
        {
            WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
        }
        public void DeleteKey(string Key, string Section = null)
        {
            Write(Key, null, Section ?? EXE);
        }
        public void DeleteSection(string Section = null)
        {
            Write(null, null, Section ?? EXE);
        }
        public bool KeyExists(string Key, string Section = null)
        {
            return Read(Key, Section).Length > 0;
        }
    }
}