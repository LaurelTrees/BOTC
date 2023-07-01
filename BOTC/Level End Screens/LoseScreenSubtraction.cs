using BOTC.Levels;
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
    public partial class LoseScreenSubtraction : Form
    {
        public LoseScreenSubtraction()
        {
            InitializeComponent();
            SoundPlayer loseMusic = new SoundPlayer(Resources.Lose_Melody); 
            loseMusic.Play(); // play lose music
        }

        private void retryButton_Click(object sender, EventArgs e) // When retry button is pressed load subtraction form
        {
            Subtraction2 myform = new Subtraction2();
            myform.ShowDialog();
            Close();
        }

        private void quitButton_Click(object sender, EventArgs e) // when quit button is pressed stop playing music, play home music and close form
        {
            SoundPlayer loseMusic = new SoundPlayer(Resources.Lose_Melody); 
            loseMusic.Stop();

            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home); 
            homeMusic.Play();

            Close();
        }

        private void LoseScreenSubtraction_Load(object sender, EventArgs e) // when form is loaded set form hwidth and height to screen width and height
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
