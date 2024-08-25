using System;
using System.Diagnostics;

namespace nGlideConfig
{
    internal class Executable
    {
        public static void Set(string Input)
        {
            // Make sure a value has been set.
            if (Input == "")
            {
                // The user most likely cancelled selection so just do nothing.
                return;
            }
            // Make sure the path exists.
            if (!(Paths.Test(Input))) 
            {
                // The user most likely entered a path that doesn't exist in the textbox so show an error.
                string Message = "The path to the executable does not exist.";
                Forms.OkayDialog.Show("nGlide Config Error", Message, 240, 14, 48, 26, 10);
                Forms.MainDialog.TextBox_Executable.Text = nGlideIni.NGLIDE_EXECUTABLE ;
                return;
            }
            // If it passed the tests set the variable.
            nGlideIni.NGLIDE_EXECUTABLE = Input;

            // Update the textbox.
            Forms.MainDialog.TextBox_Executable.Text = Input;
        }
        public static void Launch()
        {
            // Make sure the executable exists before trying to launch.
            if (Paths.Test(nGlideIni.NGLIDE_EXECUTABLE)) 
            {
                // My FileItem class is perfect for extracting properties.
                FileItem Executable = new FileItem(nGlideIni.NGLIDE_EXECUTABLE);

                // The file exists and is an executable.
                if ((Executable.Exists) & (Executable.Extension == ".exe"))
                {
                    // Set the nGlide environment variables.
                    Environment.SetEnvironmentVariable("NGLIDE_BACKEND",    nGlideIni.NGLIDE_BACKEND);
                    Environment.SetEnvironmentVariable("NGLIDE_RESOLUTION", nGlideIni.NGLIDE_RESOLUTION);
                    Environment.SetEnvironmentVariable("NGLIDE_ASPECT",     nGlideIni.NGLIDE_ASPECT);
                    Environment.SetEnvironmentVariable("NGLIDE_REFRESH",    nGlideIni.NGLIDE_REFRESH);
                    Environment.SetEnvironmentVariable("NGLIDE_VSYNC",      nGlideIni.NGLIDE_VSYNC);
                    Environment.SetEnvironmentVariable("NGLIDE_GAMMA",      nGlideIni.NGLIDE_GAMMA);
                    Environment.SetEnvironmentVariable("NGLIDE_SPLASH",     nGlideIni.NGLIDE_SPLASH);

                    // Set the primary display to the secondary monitor.
                    Process GameProcess = new Process();
                    GameProcess.StartInfo.WorkingDirectory = Executable.DirectoryName;
                    GameProcess.StartInfo.FileName = Executable.FullName;
                    GameProcess.StartInfo.Arguments = "";
                    GameProcess.StartInfo.UseShellExecute = false;
                    GameProcess.StartInfo.RedirectStandardOutput = false;
                    GameProcess.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                    GameProcess.Start();
                }
            }
            // If somehow an invalid path is currently set.
            else
            {
                // Who knows how we got here but show an error message.
                string Message = "The path to the executable does not exist.";
                Forms.OkayDialog.Show("nGlide Config Error", Message, 240, 14, 48, 26, 10);
                Forms.MainDialog.TextBox_Executable.Text = nGlideIni.NGLIDE_EXECUTABLE ;
                return;
            }
        }
    }
}
