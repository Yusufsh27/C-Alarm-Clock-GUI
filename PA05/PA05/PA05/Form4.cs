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
    
    public partial class Form4 : Form
    {
        Form3 OriginalForm;

        public Form4(Form3 incomingForm)
        {
            OriginalForm = incomingForm;
            InitializeComponent();
        }

        /// <summary>
        /// Get the user input for the reminder and share it across the forms so it can be used in the Home form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setBtn_Click(object sender, EventArgs e)
        {
            OriginalForm.remdate1 = monthCalendar1.SelectionRange.Start.ToShortDateString();
            OriginalForm.remtime1 = hoursSet.Value.ToString("00") + ":" + minutesSet.Value.ToString("00") + ":" + secondsSet.Value.ToString("00");
            Class1.x = 0;
            Close();
        }
    }
}
