namespace Lift
{
    partial class Elev_Lift
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TaskLog = new System.Windows.Forms.ListBox();
            this.btnload = new System.Windows.Forms.Button();
            this.uptimer = new System.Windows.Forms.Timer(this.components);
            this.downtimer = new System.Windows.Forms.Timer(this.components);
            this.firstOpenTimer = new System.Windows.Forms.Timer(this.components);
            this.groundOpenTimer = new System.Windows.Forms.Timer(this.components);
            this.groundCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.firstCloseTimer = new System.Windows.Forms.Timer(this.components);
            this.timeauto = new System.Windows.Forms.Timer(this.components);
            this.timerautoup = new System.Windows.Forms.Timer(this.components);
            this.timerautodown = new System.Windows.Forms.Timer(this.components);
            this.doorclose = new System.Windows.Forms.Button();
            this.dooropen = new System.Windows.Forms.Button();
            this.Indisplay = new System.Windows.Forms.PictureBox();
            this.groundfloordisplay = new System.Windows.Forms.PictureBox();
            this.firstfloordisplay = new System.Windows.Forms.PictureBox();
            this.GoGround = new System.Windows.Forms.Button();
            this.Gofirst = new System.Windows.Forms.Button();
            this.callbtn1 = new System.Windows.Forms.Button();
            this.callbtn2 = new System.Windows.Forms.Button();
            this.upright = new System.Windows.Forms.PictureBox();
            this.upleft = new System.Windows.Forms.PictureBox();
            this.downleft = new System.Windows.Forms.PictureBox();
            this.downright = new System.Windows.Forms.PictureBox();
            this.inside = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Indisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundfloordisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstfloordisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downleft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.downright)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inside)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskLog
            // 
            this.TaskLog.BackColor = System.Drawing.SystemColors.Info;
            this.TaskLog.FormattingEnabled = true;
            this.TaskLog.ItemHeight = 16;
            this.TaskLog.Items.AddRange(new object[] {
            "Data"});
            this.TaskLog.Location = new System.Drawing.Point(792, 54);
            this.TaskLog.Margin = new System.Windows.Forms.Padding(4);
            this.TaskLog.Name = "TaskLog";
            this.TaskLog.Size = new System.Drawing.Size(503, 580);
            this.TaskLog.TabIndex = 19;
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.SystemColors.Info;
            this.btnload.Location = new System.Drawing.Point(37, 165);
            this.btnload.Margin = new System.Windows.Forms.Padding(4);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(219, 30);
            this.btnload.TabIndex = 22;
            this.btnload.Text = "Get Activity Data";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnView_Click);
            // 
            // uptimer
            // 
            this.uptimer.Interval = 5;
            this.uptimer.Tick += new System.EventHandler(this.uptimer_Tick_1);
            // 
            // downtimer
            // 
            this.downtimer.Interval = 5;
            this.downtimer.Tick += new System.EventHandler(this.downtimer_Tick_1);
            // 
            // firstOpenTimer
            // 
            this.firstOpenTimer.Interval = 25;
            this.firstOpenTimer.Tick += new System.EventHandler(this.firstOpenTimer_Tick_1);
            // 
            // groundOpenTimer
            // 
            this.groundOpenTimer.Interval = 25;
            this.groundOpenTimer.Tick += new System.EventHandler(this.groundOpenTimer_Tick_1);
            // 
            // groundCloseTimer
            // 
            this.groundCloseTimer.Interval = 25;
            this.groundCloseTimer.Tick += new System.EventHandler(this.groundCloseTimer_Tick_1);
            // 
            // firstCloseTimer
            // 
            this.firstCloseTimer.Interval = 25;
            this.firstCloseTimer.Tick += new System.EventHandler(this.firstCloseTimer_Tick_1);
            // 
            // timeauto
            // 
            this.timeauto.Interval = 5000;
            this.timeauto.Tick += new System.EventHandler(this.timerauto_Tick_1);
            // 
            // timerautoup
            // 
            this.timerautoup.Interval = 25;
            this.timerautoup.Tick += new System.EventHandler(this.timerautoup_Tick);
            // 
            // timerautodown
            // 
            this.timerautodown.Interval = 25;
            this.timerautodown.Tick += new System.EventHandler(this.timerautodown_Tick);
            // 
            // doorclose
            // 
            this.doorclose.BackgroundImage = global::Lift.Properties.Resources.close_the_door_sign_icon_control_in_elevator_vector_2881090;
            this.doorclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.doorclose.Location = new System.Drawing.Point(100, 25);
            this.doorclose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.doorclose.Name = "doorclose";
            this.doorclose.Size = new System.Drawing.Size(64, 57);
            this.doorclose.TabIndex = 27;
            this.doorclose.UseVisualStyleBackColor = true;
            this.doorclose.Click += new System.EventHandler(this.buttonclose_Click);
            // 
            // dooropen
            // 
            this.dooropen.BackgroundImage = global::Lift.Properties.Resources.stickers_open_the_door_sign_icon_control_in_the_elevator_jpg;
            this.dooropen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dooropen.Location = new System.Drawing.Point(19, 25);
            this.dooropen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dooropen.Name = "dooropen";
            this.dooropen.Size = new System.Drawing.Size(64, 57);
            this.dooropen.TabIndex = 26;
            this.dooropen.UseVisualStyleBackColor = true;
            this.dooropen.Click += new System.EventHandler(this.buttonopen_Click);
            // 
            // Indisplay
            // 
            this.Indisplay.BackColor = System.Drawing.Color.DarkRed;
            this.Indisplay.Image = global::Lift.Properties.Resources._1;
            this.Indisplay.Location = new System.Drawing.Point(171, 25);
            this.Indisplay.Margin = new System.Windows.Forms.Padding(4);
            this.Indisplay.Name = "Indisplay";
            this.Indisplay.Size = new System.Drawing.Size(117, 122);
            this.Indisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Indisplay.TabIndex = 25;
            this.Indisplay.TabStop = false;
            // 
            // groundfloordisplay
            // 
            this.groundfloordisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groundfloordisplay.Image = global::Lift.Properties.Resources._1;
            this.groundfloordisplay.Location = new System.Drawing.Point(264, 302);
            this.groundfloordisplay.Margin = new System.Windows.Forms.Padding(4);
            this.groundfloordisplay.Name = "groundfloordisplay";
            this.groundfloordisplay.Size = new System.Drawing.Size(45, 38);
            this.groundfloordisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.groundfloordisplay.TabIndex = 24;
            this.groundfloordisplay.TabStop = false;
            // 
            // firstfloordisplay
            // 
            this.firstfloordisplay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstfloordisplay.Image = global::Lift.Properties.Resources._1;
            this.firstfloordisplay.Location = new System.Drawing.Point(267, 23);
            this.firstfloordisplay.Margin = new System.Windows.Forms.Padding(4);
            this.firstfloordisplay.Name = "firstfloordisplay";
            this.firstfloordisplay.Size = new System.Drawing.Size(43, 38);
            this.firstfloordisplay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.firstfloordisplay.TabIndex = 23;
            this.firstfloordisplay.TabStop = false;
            // 
            // GoGround
            // 
            this.GoGround.BackgroundImage = global::Lift.Properties.Resources._619u0aeeAUL__AC_UF350_350_QL80_;
            this.GoGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GoGround.Location = new System.Drawing.Point(16, 86);
            this.GoGround.Margin = new System.Windows.Forms.Padding(4);
            this.GoGround.Name = "GoGround";
            this.GoGround.Size = new System.Drawing.Size(68, 60);
            this.GoGround.TabIndex = 18;
            this.GoGround.UseVisualStyleBackColor = true;
            this.GoGround.Click += new System.EventHandler(this.buttonig_Click_1);
            // 
            // Gofirst
            // 
            this.Gofirst.BackgroundImage = global::Lift.Properties.Resources._61qw5utoMuL__AC_UF350_350_QL80_;
            this.Gofirst.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Gofirst.Location = new System.Drawing.Point(96, 87);
            this.Gofirst.Margin = new System.Windows.Forms.Padding(4);
            this.Gofirst.Name = "Gofirst";
            this.Gofirst.Size = new System.Drawing.Size(68, 60);
            this.Gofirst.TabIndex = 17;
            this.Gofirst.UseVisualStyleBackColor = true;
            this.Gofirst.Click += new System.EventHandler(this.buttoni1_Click_1);
            // 
            // callbtn1
            // 
            this.callbtn1.BackgroundImage = global::Lift.Properties.Resources._55008;
            this.callbtn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.callbtn1.Location = new System.Drawing.Point(16, 404);
            this.callbtn1.Margin = new System.Windows.Forms.Padding(4);
            this.callbtn1.Name = "callbtn1";
            this.callbtn1.Size = new System.Drawing.Size(68, 59);
            this.callbtn1.TabIndex = 11;
            this.callbtn1.UseVisualStyleBackColor = true;
            this.callbtn1.Click += new System.EventHandler(this.buttong_Click_1);
            // 
            // callbtn2
            // 
            this.callbtn2.BackgroundImage = global::Lift.Properties.Resources._1896719_200;
            this.callbtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.callbtn2.Location = new System.Drawing.Point(16, 122);
            this.callbtn2.Margin = new System.Windows.Forms.Padding(4);
            this.callbtn2.Name = "callbtn2";
            this.callbtn2.Size = new System.Drawing.Size(68, 59);
            this.callbtn2.TabIndex = 10;
            this.callbtn2.UseVisualStyleBackColor = true;
            this.callbtn2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // upright
            // 
            this.upright.BackgroundImage = global::Lift.Properties.Resources.Screenshot_2023_11_03_100509;
            this.upright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upright.Location = new System.Drawing.Point(213, 66);
            this.upright.Margin = new System.Windows.Forms.Padding(4);
            this.upright.Name = "upright";
            this.upright.Size = new System.Drawing.Size(112, 224);
            this.upright.TabIndex = 13;
            this.upright.TabStop = false;
            // 
            // upleft
            // 
            this.upleft.BackgroundImage = global::Lift.Properties.Resources.Screenshot_2023_11_03_100351;
            this.upleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upleft.Location = new System.Drawing.Point(103, 66);
            this.upleft.Margin = new System.Windows.Forms.Padding(4);
            this.upleft.Name = "upleft";
            this.upleft.Size = new System.Drawing.Size(112, 224);
            this.upleft.TabIndex = 12;
            this.upleft.TabStop = false;
            // 
            // downleft
            // 
            this.downleft.BackgroundImage = global::Lift.Properties.Resources.Screenshot_2023_11_03_1003511;
            this.downleft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downleft.Location = new System.Drawing.Point(101, 348);
            this.downleft.Margin = new System.Windows.Forms.Padding(4);
            this.downleft.Name = "downleft";
            this.downleft.Size = new System.Drawing.Size(112, 224);
            this.downleft.TabIndex = 14;
            this.downleft.TabStop = false;
            // 
            // downright
            // 
            this.downright.BackgroundImage = global::Lift.Properties.Resources.Screenshot_2023_11_03_100509;
            this.downright.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.downright.Location = new System.Drawing.Point(213, 348);
            this.downright.Margin = new System.Windows.Forms.Padding(4);
            this.downright.Name = "downright";
            this.downright.Size = new System.Drawing.Size(112, 224);
            this.downright.TabIndex = 15;
            this.downright.TabStop = false;
            // 
            // inside
            // 
            this.inside.BackgroundImage = global::Lift.Properties.Resources.Screenshot_2023_11_03_101135;
            this.inside.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inside.Location = new System.Drawing.Point(103, 66);
            this.inside.Margin = new System.Windows.Forms.Padding(4);
            this.inside.Name = "inside";
            this.inside.Size = new System.Drawing.Size(221, 224);
            this.inside.TabIndex = 7;
            this.inside.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::Lift.Properties.Resources.bg;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(792, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(501, 57);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(285, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Action";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "Date and Time";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::Lift.Properties.Resources.bg;
            this.groupBox2.Controls.Add(this.Gofirst);
            this.groupBox2.Controls.Add(this.doorclose);
            this.groupBox2.Controls.Add(this.btnload);
            this.groupBox2.Controls.Add(this.dooropen);
            this.groupBox2.Controls.Add(this.GoGround);
            this.groupBox2.Controls.Add(this.Indisplay);
            this.groupBox2.Location = new System.Drawing.Point(396, 423);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(397, 210);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Lift.Properties.Resources.bg;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(317, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 529);
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Lift.Properties.Resources.bg;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(1, 54);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(103, 529);
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Lift.Properties.Resources.bg;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(396, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(397, 666);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(115, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 34);
            this.label3.TabIndex = 33;
            this.label3.Text = "First Floor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 27);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ground Floor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(485, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 34);
            this.label5.TabIndex = 35;
            this.label5.Text = "Control Panel";
            // 
            // Elev_Lift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lift.Properties.Resources.bg;
            this.ClientSize = new System.Drawing.Size(1295, 670);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.callbtn1);
            this.Controls.Add(this.callbtn2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groundfloordisplay);
            this.Controls.Add(this.firstfloordisplay);
            this.Controls.Add(this.TaskLog);
            this.Controls.Add(this.upright);
            this.Controls.Add(this.upleft);
            this.Controls.Add(this.downleft);
            this.Controls.Add(this.downright);
            this.Controls.Add(this.inside);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Elev_Lift";
            this.Text = "Elevator_Lift";
            ((System.ComponentModel.ISupportInitialize)(this.Indisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groundfloordisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstfloordisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downleft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.downright)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inside)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox inside;
        private System.Windows.Forms.Button callbtn2;
        private System.Windows.Forms.Button callbtn1;
        private System.Windows.Forms.PictureBox upleft;
        private System.Windows.Forms.PictureBox upright;
        private System.Windows.Forms.PictureBox downleft;
        private System.Windows.Forms.PictureBox downright;
        private System.Windows.Forms.Button Gofirst;
        private System.Windows.Forms.Button GoGround;
        private System.Windows.Forms.ListBox TaskLog;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.Timer uptimer;
        private System.Windows.Forms.Timer downtimer;
        private System.Windows.Forms.Timer firstOpenTimer;
        private System.Windows.Forms.Timer groundOpenTimer;
        private System.Windows.Forms.Timer groundCloseTimer;
        private System.Windows.Forms.Timer firstCloseTimer;
        private System.Windows.Forms.Timer timeauto;
        private System.Windows.Forms.Timer timerautoup;
        private System.Windows.Forms.Timer timerautodown;
        private System.Windows.Forms.PictureBox firstfloordisplay;
        private System.Windows.Forms.PictureBox groundfloordisplay;
        private System.Windows.Forms.PictureBox Indisplay;
        private System.Windows.Forms.Button dooropen;
        private System.Windows.Forms.Button doorclose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

