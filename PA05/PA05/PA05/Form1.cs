using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace PA05
{
    public partial class Form1 : Form
    {
        //public variables to get user input across forms
        public int snooze1 = 20;
        public string remDate;
        public string remTime;
        public int check = 0;


        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            this.snooze.Enabled = false;
            this.stopAlarm.Enabled = false;
        }

        /// <summary>
        /// Timer function: used to display to current date and time at the top of the home form.
        /// Also used to active the animation, play reminder sound, and show reminder details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //setting the date/time labels to current date/time by using the DateTime object w/ ToString
            dateLabel.Text = DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString();
            timeLabel.Text = DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" + DateTime.Now.Second.ToString("00");

            //if the reminder date and reminder time equal the current date/time, play the sound and play the gif
            //the class variable x is used to make sure it only loops once, as the timer ticks every millisecond and produces errors
            if (remDate == dateLabel.Text && remTime == timeLabel.Text && Class1.x == 0)
            {
                Play2();
                Class1.x = 1;
                this.pictureBox1.Enabled = true;
            }
        }

        /// <summary>
        /// Set Alarm Button: used set the alarm label to the user's specified time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setAlarm_Click(object sender, EventArgs e)
        {
            if (check == 1)
            {
                this.hoursSet.Enabled = true;
                this.minutesSet.Enabled = true;
                this.secondsSet.Enabled = true;
                setAlarm.Text = "Set Alarm";
                check = 0;
            }
            else
            {
                alarmLabel.Text = hoursSet.Value.ToString("00") + ":" + minutesSet.Value.ToString("00") + ":" + secondsSet.Value.ToString("00");
                timer2.Start();
                this.hoursSet.Enabled = false;
                this.minutesSet.Enabled = false;
                this.secondsSet.Enabled = false;
                setAlarm.Text = "Cancel Alarm";
                check = 1;
            }
            
        }

        /// <summary>
        /// Plays the main alarm sound: reads in the .wav file and plays it
        /// </summary>
        private void Play()
        {
            string soundfile = @"C:\Users\benja\Desktop\PA05 (1)\PA05\PA05\Alien_AlarmDrum-KevanGC-893953959.wav";
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Play();
        }

        /// <summary>
        /// Plays the reminder sound: reads in the .wav file and plays it
        /// </summary>
        private void Play2()
        {
            string soundfile = @"C:\Users\benja\Desktop\PA05 (1)\PA05\PA05\chord.wav";
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Play();
        }

        /// <summary>
        /// Stops the main alarm sound
        /// </summary>
        private void Stop()
        {
            string soundfile = @"C:\Users\benja\Desktop\PA05 (1)\PA05\PA05\Alien_AlarmDrum-KevanGC-893953959.wav";
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Stop();
        }

        /// <summary>
        /// Timer used to play the alarm sound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            //if the alarm time and current time are equal, play the sound, and enable the snooze, stop
            //disables the set alarm button
            if (timeLabel.Text == alarmLabel.Text)
            {
                Play();
                this.setAlarm.Enabled = false;
                this.snooze.Enabled = true;
                this.stopAlarm.Enabled = true;
            }
        }

        /// <summary>
        /// Stops the alarm sound
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stopAlarm_Click(object sender, EventArgs e)
        {
            //stops timer2, stops the sounds, enables the tickers to change the alarm time and set alarm
            //disables the stop alarm button
            timer2.Stop();
            Stop();
            this.hoursSet.Enabled = true;
            this.minutesSet.Enabled = true;
            this.secondsSet.Enabled = true;
            this.setAlarm.Enabled = true;
            this.stopAlarm.Enabled = false;
            setAlarm.Text = "Set Alarm";
            check = 0;

        }
        
        /// <summary>
        /// Increments the alarm(snooze) by a number of seconds(default 20, ccan be changed)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void snooze_Click(object sender, EventArgs e)
        {
            //gets the time 
            int min, sec, h;
            h = DateTime.Now.Hour;
            min = DateTime.Now.Minute;
            sec = DateTime.Now.Second;

            //add the snooze interval to the time from click
            sec += snooze1;

            //loop to make sure the time is incremented correctly 
            if (sec > 59)
            {
                min++;
                sec = sec - 60;
                if (min > 59)
                {
                    h++;
                    min = min - 60;
                    if (h > 23)
                    {
                        h = 1;
                    }
                }       
            }

            //reset the alarm label to reflect the changes, stop the sound, and reset buttons
            alarmLabel.Text = h.ToString("00") + ":" + min.ToString("00") + ":" + sec.ToString("00");
            Stop();
            this.snooze.Enabled = false;
            this.setAlarm.Enabled = true;
            this.stopAlarm.Enabled = false;
        }

        /// <summary>
        /// Opens a new for where the user can change the snooze time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setSnooze_Click(object sender, EventArgs e)
        {
            //opens new form
            Form2 f = new Form2(this);
            f.ShowDialog();
        }

        /// <summary>
        /// Opens the appointment book form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void show_Click(object sender, EventArgs e)
        {
            //opens new form
            Form3 ff = new Form3(this);
            ff.ShowDialog();
        }

        /// <summary>
        /// Changes the pictureBox.Enable back to false to stop the gif from moving
        /// Also opens a new form to display the appointment details
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //opens new form and stops animation
            this.pictureBox1.Enabled = false;
            Form5 f = new Form5();
            f.ShowDialog();
        }

        /// <summary>
        /// Help button to display directions to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*****Welcome*****\n\n\n\n"
                + "Click 'Show' to view, create, edit, or delete any appoinments. Here, you can also set reminders for these appoitnemnts."
                + " If your reminder date/time arrive, you will hear a short sound and the picture will be moving. Click the picture to stop the animation and view your reminder.\n\n"
                + "You can set an alarm time using the tickers on the left side of the form, and clicking 'Set Alarm'.\n\n"
                + "You can change the length of the snooze timer(measured in seconds) by clicking 'Set Snooze'.\n\n"
                + "Click 'Stop Alarm' to stop the alarm without a snooze timer.\n\n"
                + "Click 'Snooze' to have the alarm repeat at the set time(20 seconds default snooze time).");
        }
    }
}
