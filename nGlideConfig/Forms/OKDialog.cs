using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoomLaunch
{
    public partial class Form_OkayDialog : Form
    {
        public Form_OkayDialog()
        {
            InitializeComponent();
        }
        private void Button_OK_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void TimerTick(object sender, EventArgs e)
        {
            // Get the timer that called this method.
            Timer OKTimer = sender as Timer;

            // Hide the dialog after the timer expires.
            this.Hide();

            // Stop the timer so it doesn't repeat infinitely.
            OKTimer.Stop();
        }
        public void Show(string Title, string Message, int SizeX, int SizeY, int OffsetX, int OffsetY, int TimeOut=0)
        {
            // Set the title of the window.
            this.Text = Title;

            // Set the message to display.
            this.Label_Message.Text = Message;
            this.Label_Message.Size = new Size(SizeX,SizeY);
            this.Label_Message.Location = new Point(OffsetX,OffsetY);

            // Always play the beep. 
            SystemSounds.Beep.Play();

            // Check to see if the dialog has a timer attached.
            if (TimeOut > 0)
            {
                // Create a new timer that will expire every second.
                Timer OKTimer = new Timer();
                OKTimer.Interval = (TimeOut * 1000);
                OKTimer.Tick += new EventHandler(this.TimerTick);
                OKTimer.Start();
            }
            // Let the user know what's up.
            this.ShowDialog();

            // Reset the size of the label.
            this.Label_Message.Size = new Size(280,40);
        }
    }
}
