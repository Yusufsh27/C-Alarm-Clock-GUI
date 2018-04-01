using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA05
{
    public partial class Form3 : Form
    {
        public string remdate1;
        public string remtime1;
        public int check = 0;


        Form1 OriginalForm;
        public Form3(Form1 incomingForm)
        {
            OriginalForm = incomingForm;
            InitializeComponent();

            //prints all the existing appointment data to the boxes
            for (int i = 0; i < Class1.time.Count; i++)
            {
                memoLB.Items.Add(Class1.notes[i]);
                timeLB.Items.Add(Class1.time[i]);
                dateLB.Items.Add(Class1.date[i]);
            }

            //fill the tickers with the current time
            hoursSet.Value = DateTime.Now.Hour;
            minutesSet.Value = DateTime.Now.Minute;
            secondsSet.Value = DateTime.Now.Second;


        }

        /// <summary>
        /// creates a multi line text box so you can add a very long memo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Set the Multiline property to true.
            MemoOrg.Multiline = true;

            // Add vertical scroll bars to the TextBox control.
            MemoOrg.ScrollBars = ScrollBars.Vertical;

            
            char[] tmp1 = MemoOrg.Text.ToCharArray();
            for (int z = 0; z < tmp1.Length; z++)
            {
                    if (char.IsUpper(tmp1[z]))
                    {
                        MessageBox.Show("IT is upper");
                    }
            }

        }

        /// <summary>
        /// Add Appointment, Date, Time, Memo to the list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // I created a public check variables that sees if the user has selected to edit or simply add an appointment
            // if the user selects just Add Appointment it will go here.
            if (check == 0)
            {
                // adds the value of the selected day in the calender into the list box
                dateLB.Items.Add(monthCalendar1.SelectionRange.Start.ToShortDateString() + "\n");
                
                // adds the value of the selected time into the list box
                timeLB.Items.Add(hoursSet.Value.ToString("00") + ":" + minutesSet.Value.ToString("00") + ":" + secondsSet.Value.ToString("00") + "\n");

                // adds the phrase the user enters into the memo box into the list box
                memoLB.Items.Add(MemoOrg.Text + "\n");

                // Then it puts all these values into a global array that way once this form is closed we can reopen it and put the save information
                // back into the correct listbox.
                Class1.date.Add(monthCalendar1.SelectionRange.Start.ToShortDateString() + "\n");
                Class1.time.Add(hoursSet.Value.ToString("00") + ":" + minutesSet.Value.ToString("00") + ":" + secondsSet.Value.ToString("00") + "\n");
                Class1.notes.Add(MemoOrg.Text);

                // This Simply Clears the Memo box and sets the time back to the current time for the next appointment.
                MemoOrg.Clear();
                hoursSet.Value = DateTime.Now.Hour;
                minutesSet.Value = DateTime.Now.Minute;
                secondsSet.Value = DateTime.Now.Second;
            }
            // now if edit was clicked prior to this check is set as 1 and the following occurs.
            else if (check == 1)
            {
                // the text for the buttom changes to Add Appointment
                AddAP.Text = "Add Appointment";
                
                // Al the information that is edditd no goes back into the correct position in the extra array.
                Class1.date[Class1.index1] = (monthCalendar1.SelectionRange.Start.ToShortDateString() + "\n");
                Class1.time[Class1.index1] = (hoursSet.Value.ToString("00") + ":" + minutesSet.Value.ToString("00") + ":" + secondsSet.Value.ToString("00") + "\n");
                Class1.notes[Class1.index1] = (MemoOrg.Text);

                // It clears the current list boxxes
                dateLB.Items.Clear();
                timeLB.Items.Clear();
                memoLB.Items.Clear();

                // Reputs the new array back into the listbox having the eddited appointment.
                for (int i = 0; i < Class1.time.Count; i++)
                {
                    memoLB.Items.Add(Class1.notes[i]);
                    timeLB.Items.Add(Class1.time[i]);
                    dateLB.Items.Add(Class1.date[i]);
                }

                // This simply rests the Calender, Time and Memo box to clear.
                MemoOrg.Clear();
                hoursSet.Value = DateTime.Now.Hour;
                minutesSet.Value = DateTime.Now.Minute;
                secondsSet.Value = DateTime.Now.Second;
                DateTime example = Convert.ToDateTime(DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + DateTime.Now.Year.ToString());
                monthCalendar1.SetDate(example);

                // Sets check back to zero.
                check = 0;
            }
        }

        /// <summary>
        /// Delete the selected appointment from the list.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delBtn_Click(object sender, EventArgs e)
        {
            // creates an index variable
            int index;

            // Trys the following commands and if all of them work good otherwise pops open a message box.
            try
            {
                // Gets the selcted index, postion of the selected appointment in the message box.
                index = dateLB.SelectedIndex;

                // removes that index from Date,Time,Memo
                dateLB.Items.RemoveAt(index);
                timeLB.Items.RemoveAt(index);
                memoLB.Items.RemoveAt(index);

                //Also removes it from the extra array.
                Class1.date.RemoveAt(index);
                Class1.time.RemoveAt(index);
                Class1.notes.RemoveAt(index);
            }
            catch
            {
                // pops open a message box saying that a appontment must be selected
                MessageBox.Show("Please select an appoinment by clicking the date box.");
            }
        }

        /// <summary>
        /// Reminder tp set a reminder for an appointment, at any day or time prior to the event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            // Trys the following commands otherwise and if fails pops open a message box.
            try
            {
                // Sets the the global variable index1 to the selected index in the Data List Box
                Class1.index1 = dateLB.SelectedIndex;

                // If there is no index selected throw an execption
                if (Class1.index1 < 0)
                    throw new Exception("Please select an appointment");

                // otheriwse if there is open up form 4 where you can set a reminder.
                // also you are passing form4 all of the variables from this form.
                Form4 f = new Form4(this);

                //opening the form and setting variables.
                f.ShowDialog();
                OriginalForm.remDate = remdate1;
                OriginalForm.remTime = remtime1;
            }
            catch
            {
                // if no appointment is selected this message box apppears.
                MessageBox.Show("Please select an appointment for the reminder.");
            }
        }

        /// <summary>
        /// Edit Button used to edit the current appointments.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editBtn_Click(object sender, EventArgs e)
        {
            // Sets a global variable for the index.
            Class1.index1 = dateLB.SelectedIndex;

            // trys the following commands otherwise gives pops a message box showing the issue.
            try
            {
                // converts the date back into calender date time and puts it back into the calender
                DateTime example = Convert.ToDateTime(Class1.date[Class1.index1]);
                monthCalendar1.SetDate(example);

                // Puts the index mmemo back into the memobox.
                MemoOrg.Text = Class1.notes[Class1.index1];

                // puts the hours minutes and seconds back into the scroll.
                hoursSet.Value = DateTime.Parse(Class1.time[Class1.index1]).Hour;
                minutesSet.Value = DateTime.Parse(Class1.time[Class1.index1]).Minute;
                secondsSet.Value = DateTime.Parse(Class1.time[Class1.index1]).Second;

                // changes the name of the appap textbox to change appointment.
                AddAP.Text = "Change Appointment";
                check = 1;
            }
            catch
            {
                // pops open the message box.
                MessageBox.Show("Please Select an appointment to edit");

                // changes the addap text back to add appointment.
                AddAP.Text = "Add Appointment";
            }

        }

        /// <summary>
        /// Help button to help user use the appointment features
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void help2Btn_Click(object sender, EventArgs e)
        {
            // Sets up the help buttom message.
            MessageBox.Show("First, choose any date using the calendar. Next, enter any text into the memo box"
                + " Then use the tickers to set your appointment time. Click 'Add Appoinment' to save it.\n\n"
                + "To EDIT or DELETE an appointment, you first need to select it by click in the DATE box. Then, just click 'Edit' or 'Delete'.\n\n"
                + "To set a reminder, first select an appointment by clicking it in the DATE box. Then click 'Set Reminder'.");
        }
    }
}
