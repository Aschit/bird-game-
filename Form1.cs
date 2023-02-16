using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quiz_game
{
    public partial class floppybird : Form
    {

        int speed = 4; // it is the speed which is defined by an integer//.
        int gravity = 5; // it depicts the gravity of the ball//
        int score = 0; //default score defined by zero value //.
        // variable ends and codding starts..//

        public floppybird()
        {
            InitializeComponent();
        }

        private void Top_Click(object sender, EventArgs e)
        {

        }

        private void gametimerevent(object sender, EventArgs e)
        {
            //
            bird.Top += gravity;// i have link the bird picture. to speed the gravity .//
            Bottom.Left -= speed;//link the bottom to left position coz it will speed to left//
            Top.Left -= speed;//the same is happening with the top pipe, reduce the value of pipe speed integer from the left position of the pipe using the -= sign//
            scoretext.Text = score.ToString();// it will show the current speed on the label//
            // if the bottom pipes location is -50 then we will reset it back to 300 and add 1 to the score//
            if (Bottom.Left< -50)


            {
                Bottom.Left = 400;
                score++;
            }
            if(Top.Left<-80)
            {
                // if the top pipe location is -280 then we will reset the pipe back to the 1050 and add 1 to the score
                Top.Left = 900;
                score++;

                // the if statement below is checking if the pipe hit the ground, pipes or if the player has left the screen from the top
                // the two pipe symbols stand for OR inside of an if statement so we can have multiple conditions inside of this if statement because its all going to do the same thing


            }
            if (bird.Bounds.IntersectsWith(Bottom.Bounds) ||
            bird.Bounds.IntersectsWith(Top.Bounds) ||
            bird.Bounds.IntersectsWith(Ground.Bounds) // bird.Top < -25;
                )
            {
                // if any of the conditions are met from above then we will run the end game function
                endgame();

            }
            if (score>5)
            {
                speed = 40;
            }
                

        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {
            // i have used as the game key when it is pressed the game begins!//
            if (e.KeyCode==Keys.Space)
            {
                // if the speed is pressed the gravity is set to -15//
                gravity = -15;

            }

        }

        private void gamekeyUp(object sender, KeyEventArgs e)
        { 
            // i have used as the game key when it is pressed the game begins!//
            if(e.KeyCode==Keys.Space)
            {
                // if space is pressed the gravity will be 15 //
                gravity = 15;
            }
            
            

        }
        private void endgame()
        {
            // it is the game end function//

            gametimer.Stop();  // to stop the timer function
            scoretext.Text += "Game over"; // time over appears//



        }

        private void floppybird_Load(object sender, EventArgs e)
        {

        }
    }
}
