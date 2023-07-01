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
    public partial class Level1Story : Form
    {
        int continueCount = 0;
        public Level1Story()
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

                dialogueBox.Text = "Where am I???";
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
                dialogueBox.Text = "You are in the world of 'Legend of Maths: Breath of the Calculator!'";
                continueCount++;
            }

            else if (continueCount == 2)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Show();
                characterName.Hide();
                dialogueBox.Text = "What!? Who even are you?";
                continueCount++;
            }

            else if (continueCount == 3)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Hide();
                characterName.Show();
                dialogueBox.Text = "My name is Leena, and I am one of the creators of this world";
                characterName.Text = "Leena";
                continueCount++;
            }

            else if (continueCount == 4)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                dialogueBox.Text = "You are currently in the world of maths, Ling";
                continueCount++;
            }

            else if (continueCount == 5)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Show();
                characterName.Hide();
                dialogueBox.Text = "Nonsense! My name is L*nk, not Ling, and I'm not in the world of maths!";
                continueCount++;
            }

            else if (continueCount == 6)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                lingName.Hide();
                characterName.Show();
                dialogueBox.Text = "I'm not lying to you, and I'll prove it";
                continueCount++;
            }

            else if (continueCount == 7)
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();
                dialogueMusic.Play();

                dialogueBox.Text = "Let's math it out! Addition style!";
                continueCount++;
            }

            else if (continueCount == 8) // if continue count is 8 stop dialogue music and load addition form
            {
                SoundPlayer dialogueMusic = new SoundPlayer(Resources.DialogueSound_fixed); 
                dialogueMusic.Stop();

                Addition1 myform = new Addition1();
                myform.ShowDialog();
                Close();
            }
        }

        private void Level1Story_Load(object sender, EventArgs e) // when form is loaded set width and height to screen width and height
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
