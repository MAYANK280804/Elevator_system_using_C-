using System;
using System.Windows.Forms;

namespace Lift
{
    class Up_Down
    {
        DbConnector dbs = new DbConnector();// database page call


        public void MoveUp(PictureBox inside, Timer uptimer, Timer firstOpenTimer, PictureBox Indisplay, PictureBox updisplay, PictureBox downdisplay, int y_up, Button buttonopen, Button buttonclose)// shaft moving up
        {

            if (inside.Top > y_up)
            {
                inside.Top -= 1;
            }
            else
            {
                uptimer.Enabled = false; //timer call

                buttonopen.Enabled = true;
                buttonclose.Enabled = true;
                firstOpenTimer.Start();//timer call
                Indisplay.Image = Lift.Properties.Resources._1;//image display on screen

                updisplay.Image = Lift.Properties.Resources._1;//image display on screen

                downdisplay.Image = Lift.Properties.Resources._1;//image display on screen

                dbs.Insertdata("Lift shaft is going up");//Action message insertion on database
            }
        }

        public void MoveDown(PictureBox inside, Timer downtimer, Timer groundOpenTimer, PictureBox Indisplay, PictureBox updisplay, PictureBox downdisplay, int y_down, Button buttonopen, Button buttonclose)//shaft moving down
        {
            // using if else
            if (inside.Top < y_down)
            {
            
                inside.Top += 1;
            }

            else if (inside.Top == y_down)
            {
                downtimer.Enabled = false;//timer call

                buttonopen.Enabled = true;
                buttonclose.Enabled = true;

                groundOpenTimer.Start();// timer call

                Indisplay.Image = Lift.Properties.Resources._0;//image display on screen 


               updisplay.Image = Lift.Properties.Resources._0;//image display on screen

               downdisplay.Image = Lift.Properties.Resources._0;//image display on screen
                dbs.Insertdata("Lift shaft is coming down");//Action message insertion on database
            }
        }
    }
}
