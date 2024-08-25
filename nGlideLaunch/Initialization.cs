using nGlideConfig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nGlideLaunch
{
    internal class Initialization
    {
        static void Main(string[] args)
        {
            // Read INI file and set common variables.
            Config.SetApplicationValues();

            // Launch the executable from the INI file.
            Executable.Launch();
        }
    }
}
