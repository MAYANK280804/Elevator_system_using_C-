using System;
using System.Windows.Forms;

namespace Lift
{
    class Timer_Automation
    {
        DbConnector dbs = new DbConnector();// database page call


        public void Time(PictureBox inside, Timer timerautodown, Timer timerautoup, Button buttonS, Button buttonF, Button Sbutton, Button Fbutton, int y_up, int y_down)
        {
            if (inside.Top > y_up)
            {
                timerautodown.Start(); //timer
                buttonS.Enabled = false;
                buttonF.Enabled = false;
                Fbutton.Enabled = false;
                Sbutton.Enabled = false;
            }
            else if (inside.Top < y_down)
            {
                timerautoup.Start();//timer
                buttonF.Enabled = false;
                buttonS.Enabled = false;
                Sbutton.Enabled = false;
                Fbutton.Enabled = false;
            }
        }

        public void TimeUp(PictureBox upleft, PictureBox upright, Timer timerautoup, Timer timeauto, Button buttonF, Button buttonS, Button Fbutton)
        {
            //using if else statement
            if (upleft.Left <= 77 && upright.Left >= 161)
            {

                upleft.Left += 1;
                
                upright.Left -= 1;
            }

            else
            {
                timerautoup.Stop();
                timeauto.Stop();
                buttonF.Enabled = true;
                buttonS.Enabled = true;
                Fbutton.Enabled = true;
                dbs.Insertdata("Door closing at first floor");//activity message insertion in database
            }
        }

        public void TimeDown(PictureBox downleft, PictureBox downright, Timer timerautodown, Timer timeauto, Button buttonF, Button buttonS, Button Sbutton)
        {
            //using if else statement 
            if (downleft.Left <= 77 && downright.Left >= 161)
            {

                downleft.Left += 1;
                
                downright.Left -= 1;
            }

            else
            {
                timerautodown.Stop();
                timeauto.Stop();
                buttonS.Enabled = true;
                buttonF.Enabled = true;
                Sbutton.Enabled = true;
                dbs.Insertdata("Door closing at first floor");// activity message insertion in databse 
            }
        }
    }
}

