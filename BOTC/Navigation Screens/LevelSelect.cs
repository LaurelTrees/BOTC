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
    public partial class LevelSelect : Form
    {
        public LevelSelect()
        {
            InitializeComponent();
            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home); 
            homeMusic.Play(); //play home music
        }

        private void button1_Click(object sender, EventArgs e) // when level 1 is clicked stop home music and load level 1 story
        {
            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home);
            homeMusic.Stop();

            Level1Story myform = new Level1Story();
            myform.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e) // when level 2 is clicked stop home music and load level 2 story
        {
            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home);
            homeMusic.Stop();

            Level2Story myform = new Level2Story();
            myform.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e) // when level 3 is clicked stop home music and load level 3 story
        {
            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home); 
            homeMusic.Stop();

            Level3Story myform = new Level3Story();
            myform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e) // when level 4 is clicked stop home music and load level 4 story
        {
            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home);
            homeMusic.Stop();

            Level4Story myform = new Level4Story();
            myform.ShowDialog();
        }

        private void homeButton_Click(object sender, EventArgs e) // when home button is clicked play home music and close form
        {
            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home);
            homeMusic.Play();
            Close();
        }

        private void LevelSelect_Load(object sender, EventArgs e) // when form is loaded set width and height to screen width and height
        {
        
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        
        }
    }
}
