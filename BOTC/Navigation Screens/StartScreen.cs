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
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home); 
            homeMusic.Play(); // Play home music
        }

        private void StartScreen_Load(object sender, EventArgs e) // when form is loaded set width and height to screen width and height
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
        private void button1_Click(object sender, EventArgs e) // when button is pressed load level select and stop music
        {
            SoundPlayer homeMusic = new SoundPlayer(Resources.SoundTrack2_home); 
            homeMusic.Stop();

            LevelSelect myform = new LevelSelect();
            myform.ShowDialog();
        }
    }
}
