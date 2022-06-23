
namespace ChequeWriter
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.drpdowncompany = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtChkNum = new System.Windows.Forms.TextBox();
            this.btnQueryChk = new System.Windows.Forms.Button();
            this.btnPrintChq = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.hidQueryDate = new System.Windows.Forms.Label();
            this.rbtnDefault = new System.Windows.Forms.RadioButton();
            this.rbtnBDO = new System.Windows.Forms.RadioButton();
            this.rbtnPenBank = new System.Windows.Forms.RadioButton();
            this.hidQueryAmount = new System.Windows.Forms.Label();
            this.hidQueryWords = new System.Windows.Forms.Label();
            this.hidQueryPayee = new System.Windows.Forms.Label();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.X);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 33);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(370, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 33);
            this.button1.TabIndex = 3;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // X
            // 
            this.X.BackColor = System.Drawing.Color.Red;
            this.X.Dock = System.Windows.Forms.DockStyle.Right;
            this.X.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.X.ForeColor = System.Drawing.Color.White;
            this.X.Location = new System.Drawing.Point(406, 0);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(36, 33);
            this.X.TabIndex = 2;
            this.X.Text = "X";
            this.X.UseVisualStyleBackColor = false;
            this.X.Click += new System.EventHandler(this.X_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            this.label5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label5_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Cheque Writer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label4_MouseDown);
            // 
            // drpdowncompany
            // 
            this.drpdowncompany.FormattingEnabled = true;
            this.drpdowncompany.Location = new System.Drawing.Point(91, 44);
            this.drpdowncompany.Name = "drpdowncompany";
            this.drpdowncompany.Size = new System.Drawing.Size(121, 24);
            this.drpdowncompany.TabIndex = 2;
            this.drpdowncompany.SelectedIndexChanged += new System.EventHandler(this.drpdowncompany_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Company";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cheque #";
            // 
            // txtChkNum
            // 
            this.txtChkNum.Location = new System.Drawing.Point(91, 92);
            this.txtChkNum.Name = "txtChkNum";
            this.txtChkNum.Size = new System.Drawing.Size(125, 22);
            this.txtChkNum.TabIndex = 5;
            // 
            // btnQueryChk
            // 
            this.btnQueryChk.BackColor = System.Drawing.Color.Green;
            this.btnQueryChk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQueryChk.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueryChk.ForeColor = System.Drawing.Color.White;
            this.btnQueryChk.Location = new System.Drawing.Point(161, 160);
            this.btnQueryChk.Name = "btnQueryChk";
            this.btnQueryChk.Size = new System.Drawing.Size(112, 39);
            this.btnQueryChk.TabIndex = 6;
            this.btnQueryChk.Text = "Query";
            this.btnQueryChk.UseVisualStyleBackColor = false;
            this.btnQueryChk.Click += new System.EventHandler(this.btnQueryChk_Click);
            // 
            // btnPrintChq
            // 
            this.btnPrintChq.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnPrintChq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintChq.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintChq.ForeColor = System.Drawing.Color.White;
            this.btnPrintChq.Location = new System.Drawing.Point(21, 160);
            this.btnPrintChq.Name = "btnPrintChq";
            this.btnPrintChq.Size = new System.Drawing.Size(112, 39);
            this.btnPrintChq.TabIndex = 7;
            this.btnPrintChq.Text = "Print";
            this.btnPrintChq.UseVisualStyleBackColor = false;
            this.btnPrintChq.Click += new System.EventHandler(this.btnPrintChq_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(21, 125);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "For Payee Account";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // hidQueryDate
            // 
            this.hidQueryDate.AutoSize = true;
            this.hidQueryDate.Location = new System.Drawing.Point(355, 54);
            this.hidQueryDate.Name = "hidQueryDate";
            this.hidQueryDate.Size = new System.Drawing.Size(96, 17);
            this.hidQueryDate.TabIndex = 9;
            this.hidQueryDate.Text = "hidQueryDate";
            // 
            // rbtnDefault
            // 
            this.rbtnDefault.AutoSize = true;
            this.rbtnDefault.Location = new System.Drawing.Point(248, 44);
            this.rbtnDefault.Name = "rbtnDefault";
            this.rbtnDefault.Size = new System.Drawing.Size(74, 21);
            this.rbtnDefault.TabIndex = 10;
            this.rbtnDefault.TabStop = true;
            this.rbtnDefault.Text = "Default";
            this.rbtnDefault.UseVisualStyleBackColor = true;
            this.rbtnDefault.CheckedChanged += new System.EventHandler(this.rbtnDefault_CheckedChanged);
            // 
            // rbtnBDO
            // 
            this.rbtnBDO.AutoSize = true;
            this.rbtnBDO.Location = new System.Drawing.Point(248, 71);
            this.rbtnBDO.Name = "rbtnBDO";
            this.rbtnBDO.Size = new System.Drawing.Size(59, 21);
            this.rbtnBDO.TabIndex = 11;
            this.rbtnBDO.TabStop = true;
            this.rbtnBDO.Text = "BDO";
            this.rbtnBDO.UseVisualStyleBackColor = true;
            this.rbtnBDO.CheckedChanged += new System.EventHandler(this.rbtnBDO_CheckedChanged);
            // 
            // rbtnPenBank
            // 
            this.rbtnPenBank.AutoSize = true;
            this.rbtnPenBank.Location = new System.Drawing.Point(248, 98);
            this.rbtnPenBank.Name = "rbtnPenBank";
            this.rbtnPenBank.Size = new System.Drawing.Size(86, 21);
            this.rbtnPenBank.TabIndex = 12;
            this.rbtnPenBank.TabStop = true;
            this.rbtnPenBank.Text = "PenBank";
            this.rbtnPenBank.UseVisualStyleBackColor = true;
            this.rbtnPenBank.CheckedChanged += new System.EventHandler(this.rbtnPenBank_CheckedChanged);
            // 
            // hidQueryAmount
            // 
            this.hidQueryAmount.AutoSize = true;
            this.hidQueryAmount.Location = new System.Drawing.Point(355, 78);
            this.hidQueryAmount.Name = "hidQueryAmount";
            this.hidQueryAmount.Size = new System.Drawing.Size(114, 17);
            this.hidQueryAmount.TabIndex = 13;
            this.hidQueryAmount.Text = "hidQueryAmount";
            // 
            // hidQueryWords
            // 
            this.hidQueryWords.AutoSize = true;
            this.hidQueryWords.Location = new System.Drawing.Point(355, 102);
            this.hidQueryWords.Name = "hidQueryWords";
            this.hidQueryWords.Size = new System.Drawing.Size(107, 17);
            this.hidQueryWords.TabIndex = 14;
            this.hidQueryWords.Text = "hidQueryWords";
            // 
            // hidQueryPayee
            // 
            this.hidQueryPayee.AutoSize = true;
            this.hidQueryPayee.Location = new System.Drawing.Point(355, 124);
            this.hidQueryPayee.Name = "hidQueryPayee";
            this.hidQueryPayee.Size = new System.Drawing.Size(106, 17);
            this.hidQueryPayee.TabIndex = 15;
            this.hidQueryPayee.Text = "hidQueryPayee";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // MainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 209);
            this.Controls.Add(this.hidQueryPayee);
            this.Controls.Add(this.hidQueryWords);
            this.Controls.Add(this.hidQueryAmount);
            this.Controls.Add(this.rbtnPenBank);
            this.Controls.Add(this.rbtnBDO);
            this.Controls.Add(this.rbtnDefault);
            this.Controls.Add(this.hidQueryDate);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnPrintChq);
            this.Controls.Add(this.btnQueryChk);
            this.Controls.Add(this.txtChkNum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.drpdowncompany);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainUI";
            this.Text = "Cheque Writer";
            this.Load += new System.EventHandler(this.MainUI_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainUI_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button X;
        private System.Windows.Forms.ComboBox drpdowncompany;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChkNum;
        private System.Windows.Forms.Button btnQueryChk;
        private System.Windows.Forms.Button btnPrintChq;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label hidQueryDate;
        private System.Windows.Forms.RadioButton rbtnDefault;
        private System.Windows.Forms.RadioButton rbtnBDO;
        private System.Windows.Forms.RadioButton rbtnPenBank;
        private System.Windows.Forms.Label hidQueryAmount;
        private System.Windows.Forms.Label hidQueryWords;
        private System.Windows.Forms.Label hidQueryPayee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}