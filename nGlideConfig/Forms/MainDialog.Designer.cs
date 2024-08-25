namespace nGlideConfig
{
    partial class Form_MainDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MainDialog));
            this.Group_Options = new System.Windows.Forms.GroupBox();
            this.Label_Backend = new System.Windows.Forms.Label();
            this.Combo_Backend = new System.Windows.Forms.ComboBox();
            this.Combo_Resolution = new System.Windows.Forms.ComboBox();
            this.Label_Resolution = new System.Windows.Forms.Label();
            this.Combo_Aspect = new System.Windows.Forms.ComboBox();
            this.Label_Aspect = new System.Windows.Forms.Label();
            this.Combo_Refresh = new System.Windows.Forms.ComboBox();
            this.Label_Refresh = new System.Windows.Forms.Label();
            this.Combo_Vsync = new System.Windows.Forms.ComboBox();
            this.Label_Vsync = new System.Windows.Forms.Label();
            this.Combo_Gamma = new System.Windows.Forms.ComboBox();
            this.Label_Gamma = new System.Windows.Forms.Label();
            this.Combo_Splash = new System.Windows.Forms.ComboBox();
            this.Label_Splash = new System.Windows.Forms.Label();
            this.Group_Executable = new System.Windows.Forms.GroupBox();
            this.TextBox_Executable = new System.Windows.Forms.TextBox();
            this.Button_Executable = new System.Windows.Forms.Button();
            this.Button_Launch = new System.Windows.Forms.Button();
            this.Button_Save = new System.Windows.Forms.Button();
            this.Button_Defaults = new System.Windows.Forms.Button();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Group_Options.SuspendLayout();
            this.Group_Executable.SuspendLayout();
            this.SuspendLayout();
            // 
            // Group_Options
            // 
            this.Group_Options.Controls.Add(this.Combo_Splash);
            this.Group_Options.Controls.Add(this.Label_Splash);
            this.Group_Options.Controls.Add(this.Combo_Gamma);
            this.Group_Options.Controls.Add(this.Label_Gamma);
            this.Group_Options.Controls.Add(this.Combo_Vsync);
            this.Group_Options.Controls.Add(this.Label_Vsync);
            this.Group_Options.Controls.Add(this.Combo_Refresh);
            this.Group_Options.Controls.Add(this.Label_Refresh);
            this.Group_Options.Controls.Add(this.Combo_Aspect);
            this.Group_Options.Controls.Add(this.Label_Aspect);
            this.Group_Options.Controls.Add(this.Combo_Resolution);
            this.Group_Options.Controls.Add(this.Label_Resolution);
            this.Group_Options.Controls.Add(this.Combo_Backend);
            this.Group_Options.Controls.Add(this.Label_Backend);
            this.Group_Options.Location = new System.Drawing.Point(12, 6);
            this.Group_Options.Name = "Group_Options";
            this.Group_Options.Size = new System.Drawing.Size(360, 216);
            this.Group_Options.TabIndex = 0;
            this.Group_Options.TabStop = false;
            this.Group_Options.Text = "Options";
            // 
            // Label_Backend
            // 
            this.Label_Backend.AutoSize = true;
            this.Label_Backend.Location = new System.Drawing.Point(10, 23);
            this.Label_Backend.Name = "Label_Backend";
            this.Label_Backend.Size = new System.Drawing.Size(83, 13);
            this.Label_Backend.TabIndex = 0;
            this.Label_Backend.Text = "Video Backend:";
            // 
            // Combo_Backend
            // 
            this.Combo_Backend.FormattingEnabled = true;
            this.Combo_Backend.Location = new System.Drawing.Point(177, 20);
            this.Combo_Backend.Name = "Combo_Backend";
            this.Combo_Backend.Size = new System.Drawing.Size(168, 21);
            this.Combo_Backend.TabIndex = 1;
            this.Combo_Backend.SelectedIndexChanged += new System.EventHandler(this.Combo_Backend_SelectedIndexChanged);
            // 
            // Combo_Resolution
            // 
            this.Combo_Resolution.FormattingEnabled = true;
            this.Combo_Resolution.Location = new System.Drawing.Point(177, 47);
            this.Combo_Resolution.Name = "Combo_Resolution";
            this.Combo_Resolution.Size = new System.Drawing.Size(168, 21);
            this.Combo_Resolution.TabIndex = 3;
            this.Combo_Resolution.SelectedIndexChanged += new System.EventHandler(this.Combo_Resolution_SelectedIndexChanged);
            // 
            // Label_Resolution
            // 
            this.Label_Resolution.AutoSize = true;
            this.Label_Resolution.Location = new System.Drawing.Point(10, 50);
            this.Label_Resolution.Name = "Label_Resolution";
            this.Label_Resolution.Size = new System.Drawing.Size(97, 13);
            this.Label_Resolution.TabIndex = 2;
            this.Label_Resolution.Text = "Screen Resolution:";
            // 
            // Combo_Aspect
            // 
            this.Combo_Aspect.FormattingEnabled = true;
            this.Combo_Aspect.Location = new System.Drawing.Point(177, 74);
            this.Combo_Aspect.Name = "Combo_Aspect";
            this.Combo_Aspect.Size = new System.Drawing.Size(168, 21);
            this.Combo_Aspect.TabIndex = 5;
            this.Combo_Aspect.SelectedIndexChanged += new System.EventHandler(this.Combo_Aspect_SelectedIndexChanged);
            // 
            // Label_Aspect
            // 
            this.Label_Aspect.AutoSize = true;
            this.Label_Aspect.Location = new System.Drawing.Point(10, 77);
            this.Label_Aspect.Name = "Label_Aspect";
            this.Label_Aspect.Size = new System.Drawing.Size(71, 13);
            this.Label_Aspect.TabIndex = 4;
            this.Label_Aspect.Text = "Apsect Ratio:";
            // 
            // Combo_Refresh
            // 
            this.Combo_Refresh.FormattingEnabled = true;
            this.Combo_Refresh.Location = new System.Drawing.Point(177, 101);
            this.Combo_Refresh.Name = "Combo_Refresh";
            this.Combo_Refresh.Size = new System.Drawing.Size(168, 21);
            this.Combo_Refresh.TabIndex = 7;
            this.Combo_Refresh.SelectedIndexChanged += new System.EventHandler(this.Combo_Refresh_SelectedIndexChanged);
            // 
            // Label_Refresh
            // 
            this.Label_Refresh.AutoSize = true;
            this.Label_Refresh.Location = new System.Drawing.Point(10, 104);
            this.Label_Refresh.Name = "Label_Refresh";
            this.Label_Refresh.Size = new System.Drawing.Size(73, 13);
            this.Label_Refresh.TabIndex = 6;
            this.Label_Refresh.Text = "Refresh Rate:";
            // 
            // Combo_Vsync
            // 
            this.Combo_Vsync.FormattingEnabled = true;
            this.Combo_Vsync.Location = new System.Drawing.Point(177, 128);
            this.Combo_Vsync.Name = "Combo_Vsync";
            this.Combo_Vsync.Size = new System.Drawing.Size(168, 21);
            this.Combo_Vsync.TabIndex = 9;
            this.Combo_Vsync.SelectedIndexChanged += new System.EventHandler(this.Combo_Vsync_SelectedIndexChanged);
            // 
            // Label_Vsync
            // 
            this.Label_Vsync.AutoSize = true;
            this.Label_Vsync.Location = new System.Drawing.Point(10, 131);
            this.Label_Vsync.Name = "Label_Vsync";
            this.Label_Vsync.Size = new System.Drawing.Size(72, 13);
            this.Label_Vsync.TabIndex = 8;
            this.Label_Vsync.Text = "Vertical Sync:";
            // 
            // Combo_Gamma
            // 
            this.Combo_Gamma.FormattingEnabled = true;
            this.Combo_Gamma.Location = new System.Drawing.Point(177, 155);
            this.Combo_Gamma.Name = "Combo_Gamma";
            this.Combo_Gamma.Size = new System.Drawing.Size(168, 21);
            this.Combo_Gamma.TabIndex = 11;
            this.Combo_Gamma.SelectedIndexChanged += new System.EventHandler(this.Combo_Gamma_SelectedIndexChanged);
            // 
            // Label_Gamma
            // 
            this.Label_Gamma.AutoSize = true;
            this.Label_Gamma.Location = new System.Drawing.Point(10, 158);
            this.Label_Gamma.Name = "Label_Gamma";
            this.Label_Gamma.Size = new System.Drawing.Size(97, 13);
            this.Label_Gamma.TabIndex = 10;
            this.Label_Gamma.Text = "Gamma Correction:";
            // 
            // Combo_Splash
            // 
            this.Combo_Splash.FormattingEnabled = true;
            this.Combo_Splash.Location = new System.Drawing.Point(177, 182);
            this.Combo_Splash.Name = "Combo_Splash";
            this.Combo_Splash.Size = new System.Drawing.Size(168, 21);
            this.Combo_Splash.TabIndex = 13;
            this.Combo_Splash.SelectedIndexChanged += new System.EventHandler(this.Combo_Splash_SelectedIndexChanged);
            // 
            // Label_Splash
            // 
            this.Label_Splash.AutoSize = true;
            this.Label_Splash.Location = new System.Drawing.Point(10, 185);
            this.Label_Splash.Name = "Label_Splash";
            this.Label_Splash.Size = new System.Drawing.Size(109, 13);
            this.Label_Splash.TabIndex = 12;
            this.Label_Splash.Text = "3DFX Splash Screen:";
            // 
            // Group_Executable
            // 
            this.Group_Executable.Controls.Add(this.Button_Executable);
            this.Group_Executable.Controls.Add(this.TextBox_Executable);
            this.Group_Executable.Location = new System.Drawing.Point(12, 232);
            this.Group_Executable.Name = "Group_Executable";
            this.Group_Executable.Size = new System.Drawing.Size(360, 55);
            this.Group_Executable.TabIndex = 1;
            this.Group_Executable.TabStop = false;
            this.Group_Executable.Text = "Executable";
            // 
            // TextBox_Executable
            // 
            this.TextBox_Executable.Location = new System.Drawing.Point(13, 22);
            this.TextBox_Executable.Name = "TextBox_Executable";
            this.TextBox_Executable.Size = new System.Drawing.Size(300, 20);
            this.TextBox_Executable.TabIndex = 0;
            this.TextBox_Executable.Leave += new System.EventHandler(this.TextBox_Executable_Leave);
            // 
            // Button_Executable
            // 
            this.Button_Executable.Location = new System.Drawing.Point(319, 20);
            this.Button_Executable.Name = "Button_Executable";
            this.Button_Executable.Size = new System.Drawing.Size(26, 24);
            this.Button_Executable.TabIndex = 1;
            this.Button_Executable.Text = "...";
            this.Button_Executable.UseVisualStyleBackColor = true;
            this.Button_Executable.Click += new System.EventHandler(this.Button_Executable_Click);
            // 
            // Button_Launch
            // 
            this.Button_Launch.Location = new System.Drawing.Point(11, 293);
            this.Button_Launch.Name = "Button_Launch";
            this.Button_Launch.Size = new System.Drawing.Size(88, 28);
            this.Button_Launch.TabIndex = 2;
            this.Button_Launch.Text = "Launch";
            this.Button_Launch.UseVisualStyleBackColor = true;
            this.Button_Launch.Click += new System.EventHandler(this.Button_Launch_Click);
            // 
            // Button_Save
            // 
            this.Button_Save.Location = new System.Drawing.Point(102, 293);
            this.Button_Save.Name = "Button_Save";
            this.Button_Save.Size = new System.Drawing.Size(88, 28);
            this.Button_Save.TabIndex = 3;
            this.Button_Save.Text = "Save";
            this.Button_Save.UseVisualStyleBackColor = true;
            this.Button_Save.Click += new System.EventHandler(this.Button_Save_Click);
            // 
            // Button_Defaults
            // 
            this.Button_Defaults.Location = new System.Drawing.Point(193, 293);
            this.Button_Defaults.Name = "Button_Defaults";
            this.Button_Defaults.Size = new System.Drawing.Size(88, 28);
            this.Button_Defaults.TabIndex = 4;
            this.Button_Defaults.Text = "Defaults";
            this.Button_Defaults.UseVisualStyleBackColor = true;
            this.Button_Defaults.Click += new System.EventHandler(this.Button_Defaults_Click);
            // 
            // Button_Exit
            // 
            this.Button_Exit.Location = new System.Drawing.Point(284, 293);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(89, 28);
            this.Button_Exit.TabIndex = 5;
            this.Button_Exit.Text = "Exit";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Form_MainDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 328);
            this.Controls.Add(this.Button_Exit);
            this.Controls.Add(this.Button_Defaults);
            this.Controls.Add(this.Button_Save);
            this.Controls.Add(this.Button_Launch);
            this.Controls.Add(this.Group_Executable);
            this.Controls.Add(this.Group_Options);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_MainDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "nGlide Local Configurator v1.0";
            this.Group_Options.ResumeLayout(false);
            this.Group_Options.PerformLayout();
            this.Group_Executable.ResumeLayout(false);
            this.Group_Executable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Group_Options;
        private System.Windows.Forms.Label Label_Backend;
        private System.Windows.Forms.Label Label_Resolution;
        private System.Windows.Forms.Label Label_Splash;
        private System.Windows.Forms.Label Label_Gamma;
        private System.Windows.Forms.Label Label_Vsync;
        private System.Windows.Forms.Label Label_Refresh;
        private System.Windows.Forms.Label Label_Aspect;
        private System.Windows.Forms.GroupBox Group_Executable;
        private System.Windows.Forms.Button Button_Launch;
        private System.Windows.Forms.Button Button_Save;
        private System.Windows.Forms.Button Button_Defaults;
        private System.Windows.Forms.Button Button_Exit;
        public System.Windows.Forms.ComboBox Combo_Backend;
        public System.Windows.Forms.ComboBox Combo_Resolution;
        public System.Windows.Forms.ComboBox Combo_Splash;
        public System.Windows.Forms.ComboBox Combo_Gamma;
        public System.Windows.Forms.ComboBox Combo_Vsync;
        public System.Windows.Forms.ComboBox Combo_Refresh;
        public System.Windows.Forms.ComboBox Combo_Aspect;
        public System.Windows.Forms.Button Button_Executable;
        public System.Windows.Forms.TextBox TextBox_Executable;
    }
}

