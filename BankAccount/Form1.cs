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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public static int index = 0;

        public int Index
            {
            get{ return index ;}
            set{ index = value; }
            }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
        // add property for index 

            
            for (index = 0; index < user.Length; index++) 
            {
                if (user[index]!= null)
                { if (user[index].UserName == textBoxLogin.Text && user[index].Password == textBoxPassword.Text) 
                    {
                        MainWindow mainWindow = new MainWindow();
                      // this.Hide();
                        mainWindow.Show();
                        return;
                    } 
                }               
            }
            MessageBox.Show("wrong account details");




        }

        
        const int ARRAY_SIZE = 200;
        public static User[] user = new User[ARRAY_SIZE]; 
        int numberOfUsers = 0;
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            //fix it
            
            
            user[numberOfUsers] = new User();
            user[numberOfUsers].UserName = textBoxLogin.Text;      
            user[numberOfUsers].Password = textBoxPassword.Text;
            numberOfUsers++;
        }
    }
}
