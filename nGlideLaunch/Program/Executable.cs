using System;
using System.Diagnostics;

namespace nGlideConfig
{
    internal class Executable
    {
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
        }
    }
}
