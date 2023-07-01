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
    public partial class LoseScreenDivision : Form
    {
        public LoseScreenDivision()
        {
            InitializeComponent();
            SoundPlayer loseMusic = new SoundPlayer(Resources.Lose_Melody);
            loseMusic.Play(); // Play lose music
        }

        private void retryButton_Click(object sender, EventArgs e)
        {
            Division4 myform = new Division4();
            myform.ShowDialog(); // load division 4
            Close(); // Close form
        } 

        private void quitButton_Click(object sender, EventArgs e) // When quit button is pressed
        {
            SoundPlayer loseMusic = new SoundPlayer(Resources.Lose_Melody); 
            loseMusic.Stop(); // stop playing lose music
            
            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home); // here WindowsFormsApplication1 is the namespace and Connect is the audio file name
            homeMusic.Play(); // play home music

            Close(); // close form
        } 

        private void LoseScreenDivision_Load(object sender, EventArgs e) // When lose screen is loaded set width and height of rom to screen width and height
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
