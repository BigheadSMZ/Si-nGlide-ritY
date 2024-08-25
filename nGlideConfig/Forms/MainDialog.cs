using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nGlideConfig
{
    public partial class Form_MainDialog : Form
    {
        public Form_MainDialog()
        {
            InitializeComponent();
        }
        private void Combo_Backend_SelectedIndexChanged(object sender, EventArgs e)
        {
            nGlideIni.NGLIDE_BACKEND = this.Combo_Backend.SelectedIndex.ToString();
        }
        private void Combo_Resolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            nGlideIni.NGLIDE_RESOLUTION = this.Combo_Resolution.SelectedIndex.ToString();
        }
        private void Combo_Aspect_SelectedIndexChanged(object sender, EventArgs e)
        {
            nGlideIni.NGLIDE_ASPECT = this.Combo_Aspect.SelectedIndex.ToString();
        }
        private void Combo_Refresh_SelectedIndexChanged(object sender, EventArgs e)
        {
            nGlideIni.NGLIDE_REFRESH = this.Combo_Refresh.SelectedIndex.ToString();
        }
        private void Combo_Vsync_SelectedIndexChanged(object sender, EventArgs e)
        {
            nGlideIni.NGLIDE_VSYNC = this.Combo_Vsync.SelectedIndex.ToString();
        }
        private void Combo_Gamma_SelectedIndexChanged(object sender, EventArgs e)
        {
            nGlideIni.NGLIDE_GAMMA = this.Combo_Gamma.SelectedIndex.ToString();
        }
        private void Combo_Splash_SelectedIndexChanged(object sender, EventArgs e)
        {
            nGlideIni.NGLIDE_SPLASH = this.Combo_Splash.SelectedIndex.ToString();
        }
        private void TextBox_Executable_Leave(object sender, EventArgs e)
        {
            // Attempt to update the executable.
            Executable.Set(this.TextBox_Executable.Text);
        }
        private void Button_Executable_Click(object sender, EventArgs e)
        {
            // Create a new openfile dialog.
            OpenFileDialog FileDialog = new OpenFileDialog();
            FileDialog.InitialDirectory = Config.BaseFolder;
            FileDialog.Filter = "Game Executables | *.exe";
            FileDialog.ShowDialog();

            // Attempt to update the executable.
            Executable.Set(FileDialog.FileName);
        }
        private void Button_Launch_Click(object sender, EventArgs e)
        {
            // Attempt to launc the game.
            Executable.Launch();
        }
        private void Button_Save_Click(object sender, EventArgs e)
        {
            // Save the INI values.
            nGlideIni.WriteValues();
        }
        private void Button_Defaults_Click(object sender, EventArgs e)
        {
            // Set the default values.
            nGlideIni.SetDefaults();

            // Refresh the values on the GUI.
            Forms.Refresh();
        }
        private void Button_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
