using DoomLaunch;
using System;

namespace nGlideConfig
{
    internal class Forms
    {
        // The various dialogs.
        public static Form_MainDialog MainDialog = null;
        public static Form_OkayDialog OkayDialog = null;

        public static void Populate()
        {
            // Tracks the current loop item.
            string CurrentItem;

            // Video Backend
            for (int i = 0 ; i < 3; i++) 
            {
                // Use the loop item to get the combobox item.
                CurrentItem = Translate.VideoBackend(i.ToString());

                // Add the item to the combobox.
                Forms.MainDialog.Combo_Backend.Items.Add(CurrentItem);
            }
            // Screen Resolution
            for (int i = 0 ; i < 29; i++) 
            {
                // Use the loop item to get the combobox item.
                CurrentItem = Translate.Resolution(i.ToString());

                // Add the item to the combobox.
                Forms.MainDialog.Combo_Resolution.Items.Add(CurrentItem);
            }
            // Aspect Ratio
            for (int i = 0 ; i < 4; i++) 
            {
                // Use the loop item to get the combobox item.
                CurrentItem = Translate.AspectRatio(i.ToString());

                // Add the item to the combobox.
                Forms.MainDialog.Combo_Aspect.Items.Add(CurrentItem);
            }
            // Refresh Rate
            for (int i = 0 ; i < 11; i++) 
            {
                // Use the loop item to get the combobox item.
                CurrentItem = Translate.RefreshRate(i.ToString());

                // Add the item to the combobox.
                Forms.MainDialog.Combo_Refresh.Items.Add(CurrentItem);
            }
            // VSync
            for (int i = 0 ; i < 2; i++) 
            {
                // Use the loop item to get the combobox item.
                CurrentItem = Translate.VerticalSync(i.ToString());

                // Add the item to the combobox.
                Forms.MainDialog.Combo_Vsync.Items.Add(CurrentItem);
            }
            // Gamma Correction
            for (int i = 0 ; i < 11; i++) 
            {
                // Use the loop item to get the combobox item.
                CurrentItem = Translate.GammaCorrection(i.ToString());

                // Add the item to the combobox.
                Forms.MainDialog.Combo_Gamma.Items.Add(CurrentItem);
            }
            // Splash Screen Logo
            for (int i = 0 ; i < 2; i++) 
            {
                // Use the loop item to get the combobox item.
                CurrentItem = Translate.SplashScreen(i.ToString());

                // Add the item to the combobox.
                Forms.MainDialog.Combo_Splash.Items.Add(CurrentItem);
            }
            // After populating, select the values imported from the INI.
            Forms.Refresh();
        }
        public static void Refresh()
        {
            // Update using the values set in the INI file.
            Forms.MainDialog.Combo_Backend.SelectedIndex = Convert.ToInt32(nGlideIni.NGLIDE_BACKEND);
            Forms.MainDialog.Combo_Resolution.SelectedIndex = Convert.ToInt32(nGlideIni.NGLIDE_RESOLUTION);
            Forms.MainDialog.Combo_Aspect.SelectedIndex = Convert.ToInt32(nGlideIni.NGLIDE_ASPECT);
            Forms.MainDialog.Combo_Refresh.SelectedIndex = Convert.ToInt32(nGlideIni.NGLIDE_REFRESH);
            Forms.MainDialog.Combo_Vsync.SelectedIndex = Convert.ToInt32(nGlideIni.NGLIDE_VSYNC);
            Forms.MainDialog.Combo_Gamma.SelectedIndex = Convert.ToInt32(nGlideIni.NGLIDE_GAMMA);
            Forms.MainDialog.Combo_Splash.SelectedIndex = Convert.ToInt32(nGlideIni.NGLIDE_SPLASH);
            Forms.MainDialog.TextBox_Executable.Text = nGlideIni.NGLIDE_EXECUTABLE;
        }
    }
}
