using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lift
{
    public partial class Elev_Lift : Form
    {
        //Database page call up to link both pages
        DbConnector database = new DbConnector();

        //UI components movement page link
        UI_Components d = new UI_Components();

        // Doors movement link 
        Up_Down ud = new Up_Down();

        // Auto mode link
        Timer_Automation a = new Timer_Automation();
        public Elev_Lift()
        {
            InitializeComponent();

        }


        //declaring variable
        int y_up = 54;
        int y_down = 284;


        private void button1_Click_1(object sender, EventArgs e)// calling shaft to first floor
        {
            callbtn1.Enabled = false;
            GoGround.Enabled = false;
            Gofirst.Enabled = false;
            callbtn2.Enabled = false;
            dooropen.Enabled = false;
            doorclose.Enabled = false;
            uptimer.Enabled = true;
            timeauto.Stop();
            Indisplay.Image = Lift.Properties.Resources.going_up;
            firstfloordisplay.Image = Lift.Properties.Resources.going_up;
            groundfloordisplay.Image = Lift.Properties.Resources.going_up;
        }

        private void firstOpenTimer_Tick_1(object sender, EventArgs e)// timer
        {
            d.UpOpen(upleft, upright, firstOpenTimer, timeauto, GoGround, Gofirst, callbtn2, callbtn1);
        }

        private void buttong_Click_1(object sender, EventArgs e)//calling lift shaft to ground floor
        {
            callbtn2.Enabled = false;
            GoGround.Enabled = false;
            Gofirst.Enabled = false;
            callbtn1.Enabled = false;
            dooropen.Enabled = false;
            doorclose.Enabled = false;
            downtimer.Enabled = true;
            Indisplay.Image = Lift.Properties.Resources.going_down;
            firstfloordisplay.Image = Lift.Properties.Resources.going_down;
            groundfloordisplay.Image = Lift.Properties.Resources.going_down;
        }

        private void buttoni1_Click_1(object sender, EventArgs e)// going to first floor
        {
            callbtn1.Enabled = false;
            GoGround.Enabled = false;
            callbtn2.Enabled = false;
            Gofirst.Enabled = false;
            dooropen.Enabled = false;
            doorclose.Enabled = false;
            groundCloseTimer.Start();
            uptimer.Start();
            Indisplay.Image = Lift.Properties.Resources.going_up;
            firstfloordisplay.Image = Lift.Properties.Resources.going_up;
            groundfloordisplay.Image = Lift.Properties.Resources.going_up;
        }

        private void uptimer_Tick_1(object sender, EventArgs e)//timer
        {
            ud.MoveUp(inside, uptimer, firstOpenTimer, Indisplay, firstfloordisplay, groundfloordisplay, y_up, dooropen, doorclose);
        }

        private void buttonig_Click_1(object sender, EventArgs e)// going to ground floor
        {
            callbtn1.Enabled = false;
            callbtn2.Enabled = false;
            Gofirst.Enabled = false;
            GoGround.Enabled = false;
            dooropen.Enabled = false;
            doorclose.Enabled = false;
            firstCloseTimer.Start();
            downtimer.Start();
            timeauto.Stop();
            Indisplay.Image = Lift.Properties.Resources.going_down;
            firstfloordisplay.Image = Lift.Properties.Resources.going_down;
            groundfloordisplay.Image = Lift.Properties.Resources.going_down;
        }

        private void downtimer_Tick_1(object sender, EventArgs e)//timer 
        {
            ud.MoveDown(inside, downtimer, groundOpenTimer, Indisplay, firstfloordisplay, groundfloordisplay, y_down, dooropen, doorclose);
        }

        private void groundOpenTimer_Tick_1(object sender, EventArgs e)//timer
        {
            d.DownOpen(downleft, downright, groundOpenTimer, timeauto, GoGround, Gofirst, callbtn2, callbtn1);
        }

        private void groundCloseTimer_Tick_1(object sender, EventArgs e)//timer
        {
            d.DownClose(downleft, downright, groundCloseTimer, uptimer, Gofirst);
        }

        private void firstCloseTimer_Tick_1(object sender, EventArgs e)//timer
        {
            d.UpClose(upleft, upright, firstCloseTimer, downtimer, GoGround);
        }

        private void timerauto_Tick_1(object sender, EventArgs e)//timer
        {
            a.Time(inside, timerautodown, timerautoup, callbtn2, callbtn1, Gofirst, GoGround, y_up, y_down);
        }

        private void timerautoup_Tick(object sender, EventArgs e)//timer
        {
          a.TimeUp(upleft, upright, timerautoup, timeauto, callbtn1, callbtn2, GoGround);
        }

        private void timerautodown_Tick(object sender, EventArgs e)//timer
        {
         a.TimeDown(downleft, downright, timerautodown, timeauto, callbtn1, callbtn2, Gofirst);
        }

        private void btnView_Click(object sender, EventArgs e)//data view
        {
            TaskLog.Items.Clear();
            DataSet ds = database.View();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                TaskLog.Items.Add(row["DateAndTime"].ToString() + "\t\t" + row["Activity".ToString()]);
            }
        }

        private void buttonopen_Click(object sender, EventArgs e)//opening of doors
        {
            if(inside.Top==y_up)
            {
                firstOpenTimer.Start();
                callbtn2.Enabled = false;
                callbtn1.Enabled = false;
                GoGround.Enabled = false;
                Gofirst.Enabled = false;
            }
            else
            {
                groundOpenTimer.Start();
                callbtn2.Enabled = false;
                callbtn1.Enabled = false;
                GoGround.Enabled = false;
                Gofirst.Enabled = false;
            }
        }

        private void buttonclose_Click(object sender, EventArgs e)//closing of doors
        {
            if (inside.Top == y_up)
            {
                firstCloseTimer.Start();
                callbtn2.Enabled = false;
                callbtn1.Enabled = false;
                GoGround.Enabled = false;
                Gofirst.Enabled = false;
            }
            else
            {
                groundCloseTimer.Start();
                callbtn2.Enabled = false;
                callbtn1.Enabled = false;
                GoGround.Enabled = false;
                Gofirst.Enabled = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
