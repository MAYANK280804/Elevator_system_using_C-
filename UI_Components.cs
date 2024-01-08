using System;
using System.Windows.Forms;


namespace Lift
{
    class UI_Components
    {

        DbConnector dbs = new DbConnector();// database page call


        public void DownClose(PictureBox downleft, PictureBox downright, Timer groundCloseTimer, Timer uptimer, Button Sbutton)
        {

            if (downleft.Left <= 77 && downright.Left >= 161)
            {
                downleft.Left += 1;
                downright.Left -= 1;
            }
            else
            {
                groundCloseTimer.Stop();
                Sbutton.Enabled = true;
                dbs.Insertdata("Door closing at ground floor");//activity message insertion in database

            }
        }

        public void UpClose(PictureBox upleft, PictureBox upright, Timer firstCloseTimer, Timer downtimer, Button Fbutton)
        {
            if (upleft.Left <= 77 && upright.Left >= 161)
            {
                upleft.Left += 1;
                upright.Left -= 1;
            }
            else
            {
                firstCloseTimer.Stop();
                Fbutton.Enabled = true;
                dbs.Insertdata("Door closing at first floor");//activity message insertion in database
            }
        }

        public void UpOpen(PictureBox upleft, PictureBox upright, Timer firstOpenTimer, Timer timeauto, Button Fbutton, Button Sbutton, Button buttonS, Button buttonF)
        {
            if (upleft.Left >= 3 && upright.Left <= 230)
            {
                upleft.Left -= 1;
                upright.Left += 1;
            }
            else
            {
                Fbutton.Enabled = false;
                Sbutton.Enabled = false;
                buttonS.Enabled = false;
                buttonF.Enabled = false;
                firstOpenTimer.Stop();
                timeauto.Start();
                dbs.Insertdata("Door opening at first floor");//activity message insertion in database
            }
        }

        public void DownOpen(PictureBox downleft, PictureBox downright, Timer groundOpenTimer, Timer timeauto, Button Fbutton, Button Sbutton, Button buttonS, Button buttonF)
        {
            if (downleft.Left >= 3 && downright.Left <= 230)
            {
                downleft.Left -= 1;
                downright.Left += 1;
            }
            else
            {
                Sbutton.Enabled = false;
                Fbutton.Enabled = false;
                buttonF.Enabled = false;
                buttonS.Enabled = false;
                groundOpenTimer.Stop();
                timeauto.Start();
                dbs.Insertdata("Door opening at ground floor");//activity message insertion in database
            }
        }
    }
}
