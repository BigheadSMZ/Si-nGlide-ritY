using System.IO;
using System.Reflection;

namespace nGlideConfig
{
    internal class Config
    {
        // Values used across the application.
        public static string AppPath = "";
        public static string BaseFolder = "";

        public static void SetApplicationValues()
        {
            // Get the folder this app is in.
            Config.AppPath = Assembly.GetExecutingAssembly().Location;
            Config.BaseFolder = Path.GetDirectoryName(Config.AppPath);

            // Initialize the INI file.
            nGlideIni.Init();


        }
    }
}
