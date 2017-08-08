using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobTracker
{
    public partial class frmKeyWords : Form
    {
        public frmKeyWords()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //-- CLEAR the choices and text boxes
            lstRole1.Text = "none";
            lstRole2.Text = "none";
            lstRole3.Text = "none";
            lstRole4.Text = "none";
            lstRole5.Text = "none";
            lstRole6.Text = "none";
            lstRole7.Text = "none";
            lstRole8.Text = "none";
            lstRole9.Text = "none";
            lstRole10.Text = "none";
            //-- clear the text boxes
            txtKW1.Text = "";
            txtKW2.Text = "";
            txtKW3.Text = "";
            txtKW4.Text = "";
            txtKW5.Text = "";
            txtKW6.Text = "";
            txtKW7.Text = "";
            txtKW8.Text = "";
            txtKW9.Text = "";
            txtKW10.Text = "";
        }
    }
}
