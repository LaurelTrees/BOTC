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
    public partial class Level4Story : Form
    {
        int continueCount = 0;
        public Level4Story()
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

                dialogueBox.Text = "Bruh.";
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
                dialogueBox.Text = "Muahahaha I am the last boss you must defeat!";
                continueCount++;
            }

            else if (continueCount == 2)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Show();
                characterName.Hide();
                dialogueBox.Text = "...What's your name and what kind of maths is it this time?";
                continueCount++;
            }

            else if (continueCount == 3)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Hide();
                characterName.Show();
                dialogueBox.Text = "I am Mr Boran, and there is no way can you defeat division! MUAHAHAHAHAHA";
                characterName.Text = "Mr Boran";
                continueCount++;
            }

            else if (continueCount == 4)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Show();
                characterName.Hide();
                dialogueBox.Text = "*sigh*";
                continueCount++;
            }

            else if (continueCount == 5)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Hide();
                characterName.Show();
                dialogueBox.Text = "?";
                continueCount++;
            }

            else if (continueCount == 6)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Show();
                characterName.Hide();
                dialogueBox.Text = "I guess I’m never getting out of this game, am I?";
                continueCount++;
            }

            else if (continueCount == 7)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                dialogueBox.Text = "Hmm... Legend of Maths: Breath of the Calculator has a nice ring to it";
                continueCount++;
            }

            else if (continueCount == 8)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                dialogueBox.Text = "I think I'll just stay here";
                continueCount++;
            }

            else if (continueCount == 9)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Hide();
                characterName.Show();
                dialogueBox.Text = "Wait, this wasn't supposed to happen";
                continueCount++;
            }

            else if (continueCount == 10)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                dialogueBox.Text = "You're supposed to keep resisting the world of maths!";
                continueCount++;
            }

            else if (continueCount == 11)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Show();
                characterName.Hide();
                dialogueBox.Text = "I accept my fate, Mr Boran. Now, let's math it out!";
                continueCount++;
            }


            else if (continueCount == 12) // if continue count is 12 stop dialogue music and load division form
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();

                Division4 myform = new Division4();
                myform.ShowDialog();
                Close();
            }
        }

        private void Level4Story_Load(object sender, EventArgs e) // when form is loaded set width and height to screen width and height
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
