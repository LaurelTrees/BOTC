using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using BOTC.Properties;

namespace BOTC
{
    public partial class Addition1 : Form
    {

        int errorCount = 0; // set an error count to 0
        int scoreCount = 0; // set a score count to 0
        int timerCount = 0; // set a timer count to 0

        public Addition1()
        {
            InitializeComponent();

            SoundPlayer battleMusic = new SoundPlayer(Resources.SoundTrack_1); 
            battleMusic.Play(); // Play battle music

            timer1.Enabled = true; // enable timer
            Random rnd = new Random(); 
            int randomInt1 = rnd.Next(1, 11); // Generate random number
            int randomInt2 = rnd.Next(1, 11); // Generate another random number
            randomNumber1.Text = randomInt1.ToString(); // Display random number
            randomNumber2.Text = randomInt2.ToString(); // Display second random number

        }
        
        // Appending calculator buttons to the answer area (basically typing your answer)
        private void button1_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button1.Text; // When button 1 is pressed append "1" to answer box
        }

        private void button2_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button2.Text; // When button 2 is pressed append "2" to answer box
        }

        private void button3_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button3.Text; // When button 3 is pressed append "3" to answer box
        }

        private void button4_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button4.Text; // When button 4 is pressed append "4" to answer box
        }

        private void button5_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button5.Text; // When button 5 is pressed append "5" to answer box
        }

        private void button6_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button6.Text; // When button 6 is pressed append "6" to answer box
        }

        private void button7_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button7.Text; // When button 7 is pressed append "7" to answer box
        }

        private void button8_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button8.Text; // When button 8 is pressed append "8" to answer box
        }

        private void button9_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button9.Text; // When button 9 is pressed append "9" to answer box
        }

        private void button0_Click(object sender, EventArgs e)
        {
            answerBox.Text = answerBox.Text + button0.Text; // When button 0 is pressed append "0" to answer box
        }
       
        // Clear answer
        private void buttonClear_Click(object sender, EventArgs e)
        {
            answerBox.Text = ""; // When clear button is pressed make the snwer box blank
        }

        private void buttonEnter_Click(object sender, EventArgs e) // When enter button is pressed
        {
            int Number1 = Int32.Parse(randomNumber1.Text); // set a variable to the text in randomnumber 1 box (use parse to turn it into an integer)
            int Number2 = Int32.Parse(randomNumber2.Text); // set a variable to the text in randomnumber 2 box (use parse to turn it into an integer)
            int Answer = Number1 + Number2; // Calculate answer by adding both numbers
            string realAnswer = Answer.ToString(); // Create variable to convert answer to string

            if (answerBox.Text == realAnswer) // If the text input by user is equal to the calculated answer
            {
                answerCheck.Text = "Nice Job!";
                answerBox.Text = "";
                
                if (scoreCount < 4) // if user score is less than 4, generate two new random numbers
                {
                    Random rnd = new Random();
                    int randomInt1 = rnd.Next(1, 11);
                    int randomInt2 = rnd.Next(1, 11);
                    randomNumber1.Text = randomInt1.ToString();
                    randomNumber2.Text = randomInt2.ToString();
                    scoreCount++; // add to score count
                    scoreBox.Text = "Score: " + scoreCount.ToString();
                }

                else // Else stop music, send score time and lives lost to program and load win screen
                {
                    SoundPlayer battleMusic = new SoundPlayer(Resources.SoundTrack_1); 
                    battleMusic.Stop();

                    scoreCount++;
                    scoreBox.Text = "Score: " + scoreCount.ToString();
                    Program.myScore = scoreCount;
                    Program.timeTaken = timerCount;
                    Program.livesLost = errorCount;
                    answerCheck.Text = "Level Complete";
                    WinScreen myform = new WinScreen();
                    myform.ShowDialog();// load win screen
                    Close(); //close form
                }
            }

            else if (answerBox.Text != realAnswer) // If answer is wrong
            {
                scoreCount--;
                scoreBox.Text = "Score: " + scoreCount.ToString();

                if (errorCount == 0) // If the user has made no errors
                {
                    ling3Lives.Hide(); // lose a life
                    answerBox.Text = "";
                    answerCheck.Text = "Try Again";
                    errorCount++; //add to error count
                }

                else if (errorCount == 1) // if error count is 1 do the same thing
                {
                    ling2Lives.Hide();
                    answerBox.Text = "";
                    answerCheck.Text = "Try Again";
                    errorCount++;
                }

                else if (errorCount == 2) // if error count is 2 go to lose screen
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

        private void timer1_Tick(object sender, EventArgs e) // when timer ticks add to timer count
        {
            timerCount++;
        }

        private void Addition1_Load_1(object sender, EventArgs e) // when form load set form width and height to screen width and height
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(w, h);
        }
    }
}
