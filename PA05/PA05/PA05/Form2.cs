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
    public partial class Form2 : Form
    {
        Form1 OrginalForm;
        public Form2(Form1 incomingFrom)
        {
            //used to be able to share variables across forms
            OrginalForm = incomingFrom;
            InitializeComponent();
            snoozeTime.Value = OrginalForm.snooze1;
        }

        /// <summary>
        /// Sets the snooze time using the tickers, defaulted at 20 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void setBtn_Click(object sender, EventArgs e)
        {
            //Shares the data with the other forms, and closes the current form
            OrginalForm.snooze1 = (int)snoozeTime.Value;
            this.Close();
        }
    }
}
