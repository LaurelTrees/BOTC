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
    public partial class Level2Story : Form
    {
        int continueCount = 0;
        public Level2Story()
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

                dialogueBox.Text = "I can’t believe I'm stuck in a maths game!";
                continueCount++;
            }

            else if (continueCount == 1)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                soloLing.Hide();
                lingName.Hide();
                characterName.Show();
                dialogueBox.Text = "I can help you with that!";
                continueCount++;
            }

            else if (continueCount == 2)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Show();
                characterName.Hide();
                dialogueBox.Text = "Huh? Who are you? How can I trust you?";
                continueCount++;
            }

            else if (continueCount == 3)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed);
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Hide();
                characterName.Show();
                dialogueBox.Text = "I'm Lauren and I'm here to help you!";
                characterName.Text = "Lauren";
                continueCount++;
            }

            else if (continueCount == 4)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed);
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Show();
                characterName.Hide();
                dialogueBox.Text = "Then how do I get out of here?";
                continueCount++;
            }

            else if (continueCount == 5)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed);
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Hide();
                characterName.Show();
                dialogueBox.Text = "In order to leave you must win all 4 math battles";
                continueCount++;
            }

            else if (continueCount == 6)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                dialogueBox.Text = "...or else it's game over";
                continueCount++;
            }

            else if (continueCount == 7)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Show();
                characterName.Hide();
                dialogueBox.Text = "Oh no, not you too-";
                continueCount++;
            }

            else if (continueCount == 8)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Hide();
                characterName.Show();
                dialogueBox.Text = "Hope you've been learning your subtraction! Let's math it out!";
                continueCount++;
            }

            else if (continueCount == 9) // if continue count is 9 stop dialogue music and load subtraction form
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();

                Subtraction2 myform = new Subtraction2();
                myform.ShowDialog();
                Close();
            }
        }

        private void Level2Story_Load(object sender, EventArgs e) // when form is loaded set width and height to screen width and height
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
