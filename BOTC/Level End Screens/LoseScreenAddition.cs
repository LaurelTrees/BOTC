using BOTC.Properties;
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

namespace BOTC
{
    public partial class LoseScreenAddition : Form
    {
        public LoseScreenAddition()
        {
            InitializeComponent();
            SoundPlayer loseMusic = new SoundPlayer(Resources.Lose_Melody);
            loseMusic.Play(); // Play lose music
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            Addition1 myform = new Addition1();
            myform.ShowDialog(); // Open addition 1
            Close(); // Close form
        }

        private void quitButton_Click(object sender, EventArgs e) // When quit button is pressed
        { 
            SoundPlayer loseMusic = new SoundPlayer(Resources.Lose_Melody);
            loseMusic.Stop(); // Stop playing lose music

            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home); 
            homeMusic.Play(); // Play home music

            Close(); // Close form
        }

        private void LoseScreenAddition_Load(object sender, EventArgs e) // When lose screen is loaded
        {
            int w = Screen.PrimaryScreen.Bounds.Width; // Set int w to screen width
            int h = Screen.PrimaryScreen.Bounds.Height; // Set int h to screen height
            this.Location = new Point(0, 0); // Set screen loaction
            this.Size = new Size(w, h); // Set screen dimensions to w and h
        }
    }
}
