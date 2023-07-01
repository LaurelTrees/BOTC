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
    public partial class WinScreen : Form
    {
        public WinScreen()
        {
            InitializeComponent();

            SoundPlayer winMusic = new SoundPlayer(Resources.Jingle_Win_Sound); 
            winMusic.Play(); // play win music

            timeBox.Text = "Time: " + Program.timeTaken.ToString() + " seconds"; // Display time taken
            ErrorBox.Text = "Lives Lost: " + Program.livesLost.ToString(); // Display lives lost

            int errorPoints = Program.livesLost * 100;
            int timePoints = Program.timeTaken * 10;
            int finalScore = 1000 - timePoints - errorPoints; // calculate total score by subtracting time*10 and lives lost*100 from 1000
            
            scoreBox.Text = "Total Score: " + finalScore.ToString(); // DIsplay final score
        }

        private void continueButton_Click(object sender, EventArgs e) // When continue button is pressed stop playing win music, start playing home music and close form
        {
            SoundPlayer winMusic = new SoundPlayer(Resources.Jingle_Win_Sound); 
            winMusic.Stop();

            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home); 
            homeMusic.Play();

            Close();
        }

        private void WinScreen_Load(object sender, EventArgs e) // when form loads set form width and height to screen width and height
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
