using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_2._1
    //Gcina Thando Goba Student Number: 29628784
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputbox.Text = infotxt1.Text;
        }

        private void name_age_btn_Click(object sender, EventArgs e)
        {
            outputbox.Text = infotxt1.Text + " is " + infotxt2.Text + " years old ";
        }

        private void name_standard_btn_Click(object sender, EventArgs e)
        {
            outputbox.Text = infotxt1.Text + " is in Standard " + infotxt3.Text; 
        }

        private void name_school_btn_Click(object sender, EventArgs e)
        {
            outputbox.Text = infotxt1.Text + " goes to " + infotxt4.Text + ", School";
        }

        private void name_age_standard_btn_Click(object sender, EventArgs e)
        {
            outputbox.Text = infotxt1.Text + " ," + infotxt2.Text +  " years" + " , standard " + infotxt3.Text;
        }

        private void name_age_standard_school_btn_Click(object sender, EventArgs e)
        {
            outputbox.Text = infotxt1.Text  + " , " + infotxt2.Text + " years, Standard " +  infotxt3.Text  + ", from " + infotxt4.Text; 
        }

        private void infotxt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
