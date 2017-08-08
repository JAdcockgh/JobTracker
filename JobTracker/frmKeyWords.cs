using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;


namespace JobTracker
{
    public partial class frmKeyWords : Form
    {   //-- CONSTANTS
        const int ROLE = 0;
        const int KW = 1;
        //--public static string[,] kwList = new string[200, 2];

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

        private void btnClose_Click(object sender, EventArgs e)
        {
            string line = "";
            int ndx = 0;

            //-- write the array back to the file
            System.IO.StreamWriter  file = new System.IO.StreamWriter("C:\\Users\\sds admin\\Source\\Repos\\JobTracker\\JobTracker\\JobTracker\\KeyWords.txt");
            while ((Variables.kwList[ndx, 0] != null) & (ndx < 200))
                {
                file.WriteLine(Variables.kwList[ndx,ROLE]+"," + Variables.kwList[ndx,KW]);
                ndx++;
            }
            //-- close the file
            file.Close();

            //-- close the form
            this.Close();
        }

        private void frmKeyWords_Load(object sender, EventArgs e)
        {
            int ndx = 0;
            int pos = 0;
            string s1, s2, s3 = "";

            string line;

            System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\sds admin\\Source\\Repos\\JobTracker\\JobTracker\\JobTracker\\KeyWords.txt");
            while ((line = file.ReadLine()) != null & (ndx < 200))
            {//-- loop till we get to the end of the file or 200 items
                //-- pull the role, stuff into ndx, 0
                pos = line.IndexOf(",");
                Variables.kwList[ndx, ROLE] = line.Substring(0, pos);

                //-- pull the keyword, stuff into ndx, 1
                Variables.kwList[ndx, KW] = line.Substring(pos + 1);

                //-- bump it
                ndx++;
            }
            //-- done processing input - close the file
            file.Close();
            if (ndx == 0)
                //-- key word file is empty
                lblempty.Visible = true;
            else
            {
                lblempty.Visible = false;

                //-- bubble sort the list according to Roles
                for (int i = 0; i < ndx - 1; i++)
                {//-- outer loop
                    s1 = Variables.kwList[i, ROLE];
                    for (int j = i + 1; j < ndx; j++)
                    {//-- inner loop
                        s2 = Variables.kwList[j, ROLE];

                        if (string.Compare(s1, s2) > 0)
                        {//-- list is out of order - SWAP roles
                            s3 = s1;
                            s1 = s2;
                            s2 = s3;
                            Variables.kwList[i, ROLE] = s1;
                            Variables.kwList[j, ROLE] = s2;
                            //-- SWAP key words
                            s3 = Variables.kwList[i, KW];
                            Variables.kwList[i, KW] = Variables.kwList[j, KW];
                            Variables.kwList[j, KW] = s3;
                        }
                    }
                }
            }
        }
    }
}
