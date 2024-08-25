using DoomLaunch;
using System;
using System.Windows.Forms;

namespace nGlideConfig
{
    internal static class Initialization
    {
        [STAThread]
        static void Main()
        {
            // Enable visual styles.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create the main window form.
            Forms.MainDialog = new Form_MainDialog();
            Forms.OkayDialog = new Form_OkayDialog();

            // Read INI file and set common variables.
            Config.SetApplicationValues();

            // Show the main dialog.
            Forms.MainDialog.ShowDialog();

            // Write the values before closing out.
            nGlideIni.WriteValues();
        }
    }
}
