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
    public partial class Multiplication3 : Form
    {

        int errorCount = 0; // set an error count to 0
        int scoreCount = 0; // set a score count to 0
        int timerCount = 0; // set timer count to 0
        public Multiplication3()
        {
            InitializeComponent();

            SoundPlayer battleMusic = new SoundPlayer(Resources.SoundTrack_1); 
            battleMusic.Play(); // play battle music

            timer1.Enabled = true; // enable timer
            Random rnd = new Random();
            int randomInt1 = rnd.Next(1, 13); // Generate random number
            int randomInt2 = rnd.Next(1, 13); // Generate another random number
            randomNumber1.Text = randomInt1.ToString(); // Display random number
            randomNumber2.Text = randomInt2.ToString(); // Display second random number
        }

        

        private void timer1_Tick(object sender, EventArgs e) // every time timer ticks add to timer count
        {
            timerCount++;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button1.Text; // When button 1 is pressed append "1" to answer box
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button2.Text; // When button 2 is pressed append "2" to answer box
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button3.Text; // When button 3 is pressed append "3" to answer box
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button4.Text; // When button 4 is pressed append "4" to answer box
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button5.Text; // When button 5 is pressed append "5" to answer box
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button6.Text; // When button 6 is pressed append "6" to answer box
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button7.Text; // When button 7 is pressed append "7" to answer box
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button8.Text; // When button 8 is pressed append "8" to answer box
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button9.Text; // When button 9 is pressed append "9" to answer box
        }

        private void button0_Click_1(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button0.Text; // When button 0 is pressed append "0" to answer box
        }

        private void buttonClear_Click_1(object sender, EventArgs e)
        {
            answerBox.Text = ""; // When clear button is pressed make the asnwer box blank
        }

        private void buttonEnter_Click_1(object sender, EventArgs e)
        {
            int Number1 = Int32.Parse(randomNumber1.Text); // set a variable to the text in randomnumber 1 box (use parse to turn it into an integer)
            int Number2 = Int32.Parse(randomNumber2.Text); // set a variable to the text in randomnumber 2 box (use parse to turn it into an integer)
            int Answer = Number1 * Number2; // Calculate answer by multiplying both numbers
            string realAnswer = Answer.ToString(); // Create variable to convert answer to string

            if (answerBox.Text == realAnswer) // If the text input by user is equal to the calculated answer, generate two new numbers and add to score
            {
                answerCheck.Text = "Nice Job!";
                answerBox.Text = "";

                if (scoreCount < 4)
                {
                    Random rnd = new Random(); //generate numbers
                    int randomInt1 = rnd.Next(1, 11);
                    int randomInt2 = rnd.Next(1, 11);
                    randomNumber1.Text = randomInt1.ToString();
                    randomNumber2.Text = randomInt2.ToString();
                    scoreCount++; // add to score
                    scoreBox.Text = "Score: " + scoreCount.ToString();
                }

                else // else stats to program and go to win screen
                {

                    SoundPlayer battleMusic = new SoundPlayer(Resources.SoundTrack_1); // stop battle music
                    battleMusic.Stop();

                    scoreCount++;
                    scoreBox.Text = "Score: " + scoreCount.ToString();
                    Program.myScore = scoreCount;
                    Program.timeTaken = timerCount;
                    Program.livesLost = errorCount;
                    answerCheck.Text = "Level Complete";
                    WinScreen myform = new WinScreen(); //Load win screen
                    myform.ShowDialog();
                    Close(); // close form
                }
            }

            else if (answerBox.Text != realAnswer) // If answer is wrong lose a life and add to error count
            {
                scoreCount--;
                scoreBox.Text = "Score: " + scoreCount.ToString();

                if (errorCount == 0) // If the user has made no errors
                {
                    ling3Lives.Hide();
                    answerBox.Text = "";
                    answerCheck.Text = "Try Again";
                    errorCount++;
                }

                else if (errorCount == 1)
                {
                    ling2Lives.Hide();
                    answerBox.Text = "";
                    answerCheck.Text = "Try Again";
                    errorCount++;
                }

                else if (errorCount == 2) // go to lose screen
                {
                    ling1Lives.Hide();
                    answerBox.Text = "";
                    answerCheck.Text = "Game Over"; // Once player has made 3 errors and lost 3 lives the game is over
                    LoseScreenAddition myform = new LoseScreenAddition();
                    myform.ShowDialog(); // load lose screen
                    Close();
                }
            }
        }

        private void Multiplication3_Load(object sender, EventArgs e) // when form is loaded set width and height to screen width and height
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
