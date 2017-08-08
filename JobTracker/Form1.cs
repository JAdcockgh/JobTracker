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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //-- quitting itime

            Application.Exit();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //-- 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //-- CLEAR the fields
            txtJD.Text = "";
            txtCoNm.Text = "";
            txtAddr.Text = "";
            txtCity.Text = "";
            lstST.Text = "WA";
            txtZip.Text = "";
            txtLink.Text = "";
            txtCodetestDescr.Text="";
            dtIV1.Text = "";
            dtIV2.Text = "";
            dtIV3.Text = "";
            dtResult.Text = "";
            rbCodeTestPF.Checked = false;
            txtResult.Text = "";
            txtYesNoDescr.Text = "";

        }

        private void keywordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKeyWords frmkw = new frmKeyWords();
            frmkw.ShowDialog();
        }
    }
}
