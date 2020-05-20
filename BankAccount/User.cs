using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankAccount
{
   public class User
    {

        private String userName, password;

        public String UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        public String Password 
        {
            get { return password; }
            set { password = value;}
        }

        public int balance;
      
       public User()
        {
             userName = "default";
             password = "default";
             balance = 0;
        }
    }

    
    

}
