﻿namespace JobTracker
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtJD = new System.Windows.Forms.TextBox();
            this.txtCoNm = new System.Windows.Forms.TextBox();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.txtCodetestDescr = new System.Windows.Forms.TextBox();
            this.dtIV1 = new System.Windows.Forms.DateTimePicker();
            this.dtIV2 = new System.Windows.Forms.DateTimePicker();
            this.dtIV3 = new System.Windows.Forms.DateTimePicker();
            this.rbCodeTestPF = new System.Windows.Forms.RadioButton();
            this.dtResult = new System.Windows.Forms.DateTimePicker();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.lstST = new System.Windows.Forms.ListBox();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newtrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keywordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label14 = new System.Windows.Forms.Label();
            this.txtYesNoDescr = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.lstRole = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analyzeToolStripMenuItem,
            this.applicationsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.resumeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1687, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 214);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Link";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Date Interview2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 357);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Code Test Descr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 428);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Code Test Result";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 464);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Date Result";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 178);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Zip";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(562, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "ST";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 107);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Co Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 178);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "City";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 250);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Date Interview1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 321);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 17);
            this.label13.TabIndex = 13;
            this.label13.Text = "Date Interview3";
            // 
            // txtJD
            // 
            this.txtJD.Location = new System.Drawing.Point(157, 65);
            this.txtJD.Name = "txtJD";
            this.txtJD.Size = new System.Drawing.Size(387, 23);
            this.txtJD.TabIndex = 0;
            // 
            // txtCoNm
            // 
            this.txtCoNm.Location = new System.Drawing.Point(157, 101);
            this.txtCoNm.Name = "txtCoNm";
            this.txtCoNm.Size = new System.Drawing.Size(387, 23);
            this.txtCoNm.TabIndex = 1;
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(157, 137);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(387, 23);
            this.txtAddr.TabIndex = 2;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(157, 172);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(387, 23);
            this.txtCity.TabIndex = 3;
            // 
            // txtLink
            // 
            this.txtLink.Location = new System.Drawing.Point(157, 208);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(387, 23);
            this.txtLink.TabIndex = 7;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(157, 422);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(387, 23);
            this.txtResult.TabIndex = 13;
            // 
            // txtCodetestDescr
            // 
            this.txtCodetestDescr.Location = new System.Drawing.Point(157, 351);
            this.txtCodetestDescr.Name = "txtCodetestDescr";
            this.txtCodetestDescr.Size = new System.Drawing.Size(387, 23);
            this.txtCodetestDescr.TabIndex = 11;
            // 
            // dtIV1
            // 
            this.dtIV1.Location = new System.Drawing.Point(157, 245);
            this.dtIV1.Name = "dtIV1";
            this.dtIV1.Size = new System.Drawing.Size(247, 23);
            this.dtIV1.TabIndex = 8;
            // 
            // dtIV2
            // 
            this.dtIV2.Location = new System.Drawing.Point(157, 280);
            this.dtIV2.Name = "dtIV2";
            this.dtIV2.Size = new System.Drawing.Size(247, 23);
            this.dtIV2.TabIndex = 9;
            // 
            // dtIV3
            // 
            this.dtIV3.Location = new System.Drawing.Point(157, 315);
            this.dtIV3.Name = "dtIV3";
            this.dtIV3.Size = new System.Drawing.Size(247, 23);
            this.dtIV3.TabIndex = 10;
            // 
            // rbCodeTestPF
            // 
            this.rbCodeTestPF.AutoSize = true;
            this.rbCodeTestPF.Location = new System.Drawing.Point(20, 389);
            this.rbCodeTestPF.Name = "rbCodeTestPF";
            this.rbCodeTestPF.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbCodeTestPF.Size = new System.Drawing.Size(153, 21);
            this.rbCodeTestPF.TabIndex = 12;
            this.rbCodeTestPF.TabStop = true;
            this.rbCodeTestPF.Text = "Coding Test Passed";
            this.rbCodeTestPF.UseVisualStyleBackColor = true;
            // 
            // dtResult
            // 
            this.dtResult.Location = new System.Drawing.Point(157, 458);
            this.dtResult.Name = "dtResult";
            this.dtResult.Size = new System.Drawing.Size(247, 23);
            this.dtResult.TabIndex = 14;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(725, 172);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(86, 23);
            this.txtZip.TabIndex = 6;
            // 
            // lstST
            // 
            this.lstST.FormattingEnabled = true;
            this.lstST.ItemHeight = 16;
            this.lstST.Items.AddRange(new object[] {
            "AZ",
            "AR",
            "CA",
            "CO",
            "HI",
            "ID",
            "KY",
            "NJ",
            "NM",
            "NV",
            "NY",
            "OR",
            "WA"});
            this.lstST.Location = new System.Drawing.Point(595, 175);
            this.lstST.Name = "lstST";
            this.lstST.Size = new System.Drawing.Size(57, 20);
            this.lstST.TabIndex = 5;
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // analyzeToolStripMenuItem
            // 
            this.analyzeToolStripMenuItem.Name = "analyzeToolStripMenuItem";
            this.analyzeToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.analyzeToolStripMenuItem.Text = "Analyze";
            // 
            // resumeToolStripMenuItem
            // 
            this.resumeToolStripMenuItem.Name = "resumeToolStripMenuItem";
            this.resumeToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.resumeToolStripMenuItem.Text = "Resume";
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newtrackToolStripMenuItem,
            this.keywordsToolStripMenuItem});
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // newtrackToolStripMenuItem
            // 
            this.newtrackToolStripMenuItem.Name = "newtrackToolStripMenuItem";
            this.newtrackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newtrackToolStripMenuItem.Text = "New (track)";
            // 
            // keywordsToolStripMenuItem
            // 
            this.keywordsToolStripMenuItem.Name = "keywordsToolStripMenuItem";
            this.keywordsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.keywordsToolStripMenuItem.Text = "Keywords";
            this.keywordsToolStripMenuItem.Click += new System.EventHandler(this.keywordsToolStripMenuItem_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(722, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(202, 17);
            this.label14.TabIndex = 31;
            this.label14.Text = "Key Words for This Application";
            // 
            // txtYesNoDescr
            // 
            this.txtYesNoDescr.Location = new System.Drawing.Point(157, 496);
            this.txtYesNoDescr.Name = "txtYesNoDescr";
            this.txtYesNoDescr.Size = new System.Drawing.Size(387, 23);
            this.txtYesNoDescr.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 502);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 17);
            this.label15.TabIndex = 32;
            this.label15.Text = "Application Result";
            // 
            // btnCommit
            // 
            this.btnCommit.Location = new System.Drawing.Point(752, 496);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(75, 23);
            this.btnCommit.TabIndex = 16;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = true;
            this.btnCommit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(921, 495);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 540);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 17);
            this.label16.TabIndex = 34;
            this.label16.Text = "Job Role";
            // 
            // lstRole
            // 
            this.lstRole.FormattingEnabled = true;
            this.lstRole.ItemHeight = 16;
            this.lstRole.Items.AddRange(new object[] {
            "Application Support",
            "Firmware Engienering",
            "Help Desk",
            "IT Manager",
            "Manager",
            "Network Admin",
            "Server Admin",
            "Software Engineering"});
            this.lstRole.Location = new System.Drawing.Point(157, 537);
            this.lstRole.Name = "lstRole";
            this.lstRole.Size = new System.Drawing.Size(153, 20);
            this.lstRole.TabIndex = 35;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1687, 726);
            this.Controls.Add(this.lstRole);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.txtYesNoDescr);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lstST);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.dtResult);
            this.Controls.Add(this.rbCodeTestPF);
            this.Controls.Add(this.dtIV3);
            this.Controls.Add(this.dtIV2);
            this.Controls.Add(this.dtIV1);
            this.Controls.Add(this.txtCodetestDescr);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.txtCoNm);
            this.Controls.Add(this.txtJD);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "anyone ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtJD;
        private System.Windows.Forms.TextBox txtCoNm;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtCodetestDescr;
        private System.Windows.Forms.DateTimePicker dtIV1;
        private System.Windows.Forms.DateTimePicker dtIV2;
        private System.Windows.Forms.DateTimePicker dtIV3;
        private System.Windows.Forms.RadioButton rbCodeTestPF;
        private System.Windows.Forms.DateTimePicker dtResult;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.ListBox lstST;
        private System.Windows.Forms.ToolStripMenuItem analyzeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newtrackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keywordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumeToolStripMenuItem;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtYesNoDescr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ListBox lstRole;
    }
}

