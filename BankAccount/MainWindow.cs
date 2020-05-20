using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {


            InitializeComponent();
            Form1 frm1 = new Form1();
            int i = frm1.Index;
            textBoxAccountName.Text = Form1.user[i].UserName;
            textBoxBalance.Text = Form1.user[i].balance.ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAccountName_TextChanged(object sender, EventArgs e)
        {




        }

        private void textBoxBalance_TextChanged(object sender, EventArgs e)
        {


        }

        private void buttonDeposit_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            int i = frm1.Index;
            if (textBoxDeposit.Text != "")
            {
                int deposit = Int32.Parse(textBoxDeposit.Text);
                Form1.user[i].balance += deposit;
                textBoxBalance.Text = Form1.user[i].balance.ToString();
            }
        }

        private void buttonWithdraw_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            int i = frm1.Index;
            if (textBoxDeposit.Text != "")
            {
                int withdraw = Int32.Parse(textBoxDeposit.Text);

                if (Form1.user[i].balance >= withdraw)
                {                  
                    Form1.user[i].balance -= withdraw;
                    textBoxBalance.Text = Form1.user[i].balance.ToString();
                }
                else
                    MessageBox.Show("Not enough money");
            }
        }

        private void buttonTransfer_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            int i = frm1.Index;

            int transferAmount = Int32.Parse(textBoxTransferNumber.Text);

            if (Form1.user[i].balance >= transferAmount)
            {
                for (int b = 0; b < Form1.user.Length; b++)
                {

                    if (Form1.user[b] != null)
                    {
                        if (Form1.user[b].UserName == textBoxTransferUser.Text) // null error , not all array elements
                        {
                            Form1.user[i].balance -= transferAmount;
                            Form1.user[b].balance += transferAmount;
                            textBoxBalance.Text = Form1.user[i].balance.ToString();
                        }
                    }
                }
            }
            else           
                MessageBox.Show("Not enough money");            
            
            }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

