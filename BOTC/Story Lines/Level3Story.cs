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
    public partial class Level3Story : Form
    {
        int continueCount = 0;
        public Level3Story()
        {
            InitializeComponent();
            characterName.Hide();
        }

        private void buttonContinue_Click(object sender, EventArgs e) // Every time continue button is clicked change the dialogue and name tag and play dialogue music
        {
            if (continueCount == 0)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Play();

                dialogueBox.Text = "Why is everyone in this world trying to fight me!?";
                continueCount++;
            }

            else if (continueCount == 1)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                soloLing.Hide();
                dialogueBox.Text = "...";
                continueCount++;
            }

            else if (continueCount == 2)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                dialogueBox.Text = "It's you again! And that Leena person too!";
                continueCount++;
            }

            else if (continueCount == 3)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingLaurenLeena.Hide();
                lingName.Hide();
                characterName.Show();
                dialogueBox.Text = "Hello~";
                characterName.Text = "Leena";
                continueCount++;
            }

            else if (continueCount == 4)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingLaurenLeena.Show();
                lingName.Show();
                characterName.Hide();
                dialogueBox.Text = "You... You were in cahoots with her the whole time?!";
                continueCount++;
            }

            else if (continueCount == 5)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Hide();
                characterName.Show();
                dialogueBox.Text = "Yup! We both worked very hard on this world";
                characterName.Text = "Lauren";
                continueCount++;
            }

            else if (continueCount == 6)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Show();
                characterName.Hide();
                dialogueBox.Text = "You betrayed me!";
                continueCount++;
            }

            else if (continueCount == 7)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingLaurenLeena.Hide();
                lingName.Hide();
                characterName.Show();
                dialogueBox.Text = "I guess there's only one way to solve this... to multiply your problems!";
                characterName.Text = "Leena";
                continueCount++;
            }

            else if (continueCount == 8)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed);
                dialogueMusic.Stop();
                dialogueMusic.Play();

                dialogueBox.Text = "Let's math it out!";
                characterName.Text = "Both";
                continueCount++;
            }

            else if (continueCount == 9) // if continue count is 9 stop dialogue music and load multiplication form
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();

                Multiplication3 myform = new Multiplication3();
                myform.ShowDialog();
                Close();
            }
        }

        private void Level3Story_Load(object sender, EventArgs e) // when form is loaded set width and height to screen width and height
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
