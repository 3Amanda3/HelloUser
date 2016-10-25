using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**

 *

 * Amanda Schepp 

 * Mr.Hardman 

 * Lab 2, Hello user

 *October 13 

 *
 */


namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdoButton_CheckedChanged(object sender, EventArgs e)
        {
         
        }

        private void rdoButton_CheckedChanged_1(object sender, EventArgs e)
        {
           
        }

        private void btReveal_Click(object sender, EventArgs e)
        {
            lblResult.Text = "You are " + txtName.Text;
        }

        private void rdbEnglish_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Hello! "+txtName.Text;
        }

        private void rdbFrench_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Salut! " +txtName.Text;
        }

        private void rdbSpanish_CheckedChanged(object sender, EventArgs e)
        {
            lblResult.Text = "Hola! " +txtName.Text;
        }

        private void lblResult_Click(object sender, EventArgs e)
        {
           
         


        }

        private void btnAgeDisplay_Click(object sender, EventArgs e)
        {
            double Age = Convert.ToDouble(txtAge.Text);
            double Year = 365.25;

            double Days = (Age*Year);
            lblDisplayDays.Text = "You were " + Days + " days old on your" +Age+ "th birthday!";

        }
    }
}
