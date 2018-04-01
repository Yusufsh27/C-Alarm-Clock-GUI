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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();

            //uses the index of the selected appointment to access and show the correct appointment
            textBox1.Text = Class1.date[Class1.index1];
            textBox2.Text = Class1.time[Class1.index1];
            textBox3.Text = Class1.notes[Class1.index1];
        }
    }
}
