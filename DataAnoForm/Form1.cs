using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAnoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime datan = dateTimePicker1.Value;
            TimeSpan dias = (DateTime.Today).Subtract(datan);               //Peguei a dia e não a data, porque
                                                                            //a data de aniversário é o dia em 
                                                                            //que nascemos
            double diastotal = dias.Days+2;
            label1.Text = Math.Floor(diastotal / 365.2425).ToString();
        }
    }
}
