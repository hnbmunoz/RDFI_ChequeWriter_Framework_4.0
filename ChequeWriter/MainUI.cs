using ChequeWriter.BusinessLogic;
using ChequeWriter.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChequeWriter
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }
        DataTable Maindt = new DataTable();
        ChqWriter chqwrite = new ChqWriter();//Main Business Logic of Cheque Writer        
        ChequeDto chqPrintModel = new ChequeDto();

        bool print = true;
        string Payee = "";
        int date_X, date_Y, paccount_X, paccount_Y, payee_X, payee_Y, amount_X, amount_Y, words_X, words_Y;
        string bankpolicy = "default";


        #region ToMakeFormDraggable
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public void MovableFunction(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        private void MainUI_MouseDown(object sender, MouseEventArgs e)
        {
            MovableFunction(e);
        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MovableFunction(e);
        }
        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            MovableFunction(e);
        }
        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            MovableFunction(e);
        }

        #endregion

        #region Coordinates for Cheque Template
        private void defaultChqTemplate()
        {
            date_X = 600;           
            date_Y = 30;

            paccount_X = 40;            
            paccount_Y = 37;

            payee_X = 130;
            payee_Y = 63;

            amount_X = 630;
            amount_Y = 65;

            words_X = 130;
            words_Y = 90;
        }

        private void bdoChqTemplate()
        {
            date_X = 573;
            date_Y = 29;

            paccount_X = 40;
            paccount_Y = 45;

            payee_X = 150;
            payee_Y = 65;

            amount_X = 600;
            amount_Y = 65;

            words_X = 150;
            words_Y = 91;
        }
        private void penbankChqTemplate()
        {
            date_X = 570;
            date_Y = 30;

            paccount_X = 40;
            paccount_Y = 45;

            payee_X = 150;
            payee_Y = 65;

            amount_X = 600;
            amount_Y = 65;

            words_X = 150;
            words_Y = 91;
        }
        #endregion

        #region Sample Parameters
        // 2176545 054  40,633.93
        // 2176544 054  95,000.00
        // 2176546 054  17,338.00 5
        // 1115178 051  5,000,000.00
        // 1580497 052  331,176.78
        #endregion

        private void qryForCheque(string ChkNumber)
        {
            chqPrintModel = chqwrite.getChequeData(drpdowncompany.SelectedValue.ToString(), ChkNumber, bankpolicy);

            if (chqPrintModel.chequePayee != null)
            {

                if (print == true)
                {
                    this.Width = 332;
                    hidQueryDate.Visible = false;
                    hidQueryAmount.Visible = false;
                    hidQueryWords.Visible = false;
                    hidQueryPayee.Visible = false;

                    printDialog1.Document = printDocument1;
                    if (printDialog1.ShowDialog() == DialogResult.OK)
                    {
                        printDocument1.Print();
                    }
                }
                else
                {
                    hidQueryAmount.Text = "Amount : " + chqPrintModel.chequeAmount;// Proper
                    hidQueryWords.Text = chqPrintModel.chequeAmountWords;
                    hidQueryPayee.Text = "Payee : " + chqPrintModel.chequePayee;
                    hidQueryDate.Text = "Date : " + chqPrintModel.chequeDate;

                    this.Width = 834;
                    hidQueryDate.Visible = true;
                    hidQueryAmount.Visible = true;
                    hidQueryWords.Visible = true;
                    hidQueryPayee.Visible = true;

                }

            }
            else
            {
                MessageBox.Show("No Data Found");

                this.Width = 332;
                hidQueryDate.Visible = false;
                hidQueryAmount.Visible = false;
                hidQueryWords.Visible = false;
                hidQueryPayee.Visible = false;
            }
        }


        private void getCompanyNamebyCode(string CompCode)
        {
            if (CompCode == "System.Data.DataRowView")
            {
                return;
            }
            label5.Text = chqwrite.getCompanyNamebyCode(CompCode);
        }

        private void LoadComboBox()
        {
            //Default was set to 051  because of on load function 
            Maindt = chqwrite.getComboBox("051");
            if (Maindt.Rows.Count > 0)
            {
                drpdowncompany.DataSource = Maindt;
                drpdowncompany.DisplayMember = "name";
                drpdowncompany.ValueMember = "name";
            }
            getCompanyNamebyCode("051");
        }


        private void MainUI_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            rbtnDefault.Checked = true;
            hidQueryDate.Visible = false;
            hidQueryAmount.Visible = false;
            hidQueryWords.Visible = false;
            hidQueryPayee.Visible = false;            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (rbtnDefault.Checked == true)
            {
                defaultChqTemplate();
            }
            if (rbtnBDO.Checked == true)
            {
                bdoChqTemplate();
            }
            if (rbtnPenBank.Checked == true)
            {
                penbankChqTemplate();
            }

            e.Graphics.DrawString(chqPrintModel.chequeDate, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, new Point(date_X, date_Y));
            e.Graphics.DrawString(Payee, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, new Point(paccount_X, paccount_Y));
            e.Graphics.DrawString(chqPrintModel.chequePayee, new Font("Tahoma", 8, FontStyle.Bold), Brushes.Black, new Point(payee_X, payee_Y));
            e.Graphics.DrawString(chqPrintModel.chequeAmount, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, new Point(amount_X, amount_Y));
            e.Graphics.DrawString(chqPrintModel.chequeAmountWords, new Font("Tahoma", 8, FontStyle.Regular), Brushes.Black, new Point(words_X, words_Y));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void drpdowncompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            getCompanyNamebyCode(drpdowncompany.SelectedValue.ToString());
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                Payee = "For Payee's Account";
            }
            else
            {
                Payee = "";
            }
        }
        private void rbtnDefault_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDefault.Checked == true)
            {
                bankpolicy = "default";
            }
        }

        private void rbtnBDO_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnBDO.Checked == true)
            {
                bankpolicy = "bdo";
            }
        }

        private void rbtnPenBank_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPenBank.Checked == true)
            {
                bankpolicy = "penbank";
            }
        }
        private void btnPrintChq_Click(object sender, EventArgs e)
        {
            print = true;
            qryForCheque(txtChkNum.Text);
        }

        private void btnQueryChk_Click(object sender, EventArgs e)
        {
            print = false;
            qryForCheque(txtChkNum.Text);
        }

    }
}
