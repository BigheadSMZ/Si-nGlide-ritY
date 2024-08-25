using System.Collections.Generic;
using System.IO;

namespace nGlideConfig
{
    internal class nGlideIni
    {
        // nGlide INI
        public static string  Path;
        public static IniFile Ini;

        // nGlide Values
        public static string NGLIDE_BACKEND;
        public static string NGLIDE_RESOLUTION;
        public static string NGLIDE_ASPECT;
        public static string NGLIDE_REFRESH;
        public static string NGLIDE_VSYNC;
        public static string NGLIDE_GAMMA;
        public static string NGLIDE_SPLASH;
        public static string NGLIDE_EXECUTABLE;

        public static void Init()
        {
            // Set the path to the INI.
            nGlideIni.Path = Config.BaseFolder + "\\nGlideConfig.ini";

            // See if the path doesn't exist.
            if (!(Paths.Test(nGlideIni.Path)))
            {
                // If it doesn't exist, create a new INI.
                nGlideIni.Create();
            }
            // Load the INI into the program.
            nGlideIni.Ini = new IniFile(nGlideIni.Path);

            // Load the INI file values.
            nGlideIni.LoadValues();
        }
        public static void Create()
        {
            // Create a list to add the lines.
            List<string> IniLines = new List<string>{};

            // Add the lines to the INI file.
            IniLines.Add("[Settings]");
            IniLines.Add("NGLIDE_BACKEND=0");
            IniLines.Add("NGLIDE_RESOLUTION=0");
            IniLines.Add("NGLIDE_ASPECT=0");
            IniLines.Add("NGLIDE_REFRESH=0");
            IniLines.Add("NGLIDE_VSYNC=1");
            IniLines.Add("NGLIDE_GAMMA=5");
            IniLines.Add("NGLIDE_SPLASH=1");
            IniLines.Add("NGLIDE_EXECUTABLE=");

            // Write the new INI file to disk.
            File.WriteAllLines(nGlideIni.Path, IniLines);
        }
        public static void SetDefaults()
        {
            // Restore all values to default values.
            nGlideIni.NGLIDE_BACKEND    = "0";
            nGlideIni.NGLIDE_RESOLUTION = "0";
            nGlideIni.NGLIDE_ASPECT     = "0";
            nGlideIni.NGLIDE_REFRESH    = "0";
            nGlideIni.NGLIDE_VSYNC      = "1";
            nGlideIni.NGLIDE_GAMMA      = "5";
            nGlideIni.NGLIDE_SPLASH     = "1";
            nGlideIni.NGLIDE_EXECUTABLE = "";
        }
        public static void LoadValues()
        {
            // Load the settings into the application.
            nGlideIni.NGLIDE_BACKEND    = nGlideIni.Ini.Read("NGLIDE_BACKEND",    "Settings");
            nGlideIni.NGLIDE_RESOLUTION = nGlideIni.Ini.Read("NGLIDE_RESOLUTION", "Settings");
            nGlideIni.NGLIDE_ASPECT     = nGlideIni.Ini.Read("NGLIDE_ASPECT",     "Settings");
            nGlideIni.NGLIDE_REFRESH    = nGlideIni.Ini.Read("NGLIDE_REFRESH",    "Settings");
            nGlideIni.NGLIDE_VSYNC      = nGlideIni.Ini.Read("NGLIDE_VSYNC",      "Settings");
            nGlideIni.NGLIDE_GAMMA      = nGlideIni.Ini.Read("NGLIDE_GAMMA",      "Settings");
            nGlideIni.NGLIDE_SPLASH     = nGlideIni.Ini.Read("NGLIDE_SPLASH",     "Settings");
            nGlideIni.NGLIDE_EXECUTABLE = nGlideIni.Ini.Read("NGLIDE_EXECUTABLE", "Settings");
        }
        public static void WriteValues()
        {
            nGlideIni.Ini.Write("NGLIDE_BACKEND",    nGlideIni.NGLIDE_BACKEND,    "Settings");
            nGlideIni.Ini.Write("NGLIDE_RESOLUTION", nGlideIni.NGLIDE_RESOLUTION, "Settings");
            nGlideIni.Ini.Write("NGLIDE_ASPECT",     nGlideIni.NGLIDE_ASPECT,     "Settings");
            nGlideIni.Ini.Write("NGLIDE_REFRESH",    nGlideIni.NGLIDE_REFRESH,    "Settings");
            nGlideIni.Ini.Write("NGLIDE_VSYNC",      nGlideIni.NGLIDE_VSYNC,      "Settings");
            nGlideIni.Ini.Write("NGLIDE_GAMMA",      nGlideIni.NGLIDE_GAMMA,      "Settings");
            nGlideIni.Ini.Write("NGLIDE_SPLASH",     nGlideIni.NGLIDE_SPLASH,     "Settings");
            nGlideIni.Ini.Write("NGLIDE_EXECUTABLE", nGlideIni.NGLIDE_EXECUTABLE, "Settings");
        }
    }
}
