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
    public partial class LoseScreenMultiplication : Form
    {
        public LoseScreenMultiplication()
        {
            InitializeComponent();
            SoundPlayer loseMusic = new SoundPlayer(Resources.Lose_Melody); 
            loseMusic.Play(); // play lose music
        }

        private void retryButton_Click(object sender, EventArgs e) // when retry button is pressed load multiplication form
        {
            Multiplication3 myform = new Multiplication3();
            myform.ShowDialog();
            Close();
        }

        private void quitButton_Click(object sender, EventArgs e) // when quit button is pressed stop playing lose music, start playing home music then close form
        {
            InitializeComponent();
            SoundPlayer loseMusic = new SoundPlayer(Resources.Lose_Melody); 
            loseMusic.Stop();

            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home); 
            homeMusic.Play();

            Close();
        }

        private void LoseScreenMultiplication_Load(object sender, EventArgs e) // when form loads set form width and height to screen width and height
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
