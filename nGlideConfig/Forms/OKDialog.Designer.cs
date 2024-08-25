namespace DoomLaunch
{
    partial class Form_OkayDialog
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

      #region #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_OkayDialog));
            this.Button_OK = new System.Windows.Forms.Button();
            this.Label_Message = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Button_OK
            // 
            this.Button_OK.Location = new System.Drawing.Point(110, 60);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(80, 28);
            this.Button_OK.TabIndex = 0;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Label_Message
            // 
            this.Label_Message.Location = new System.Drawing.Point(12, 9);
            this.Label_Message.Name = "Label_Message";
            this.Label_Message.Size = new System.Drawing.Size(280, 40);
            this.Label_Message.TabIndex = 1;
            // 
            // Form_OkayDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 96);
            this.Controls.Add(this.Label_Message);
            this.Controls.Add(this.Button_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_OkayDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OKDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Label Label_Message;
    }
}