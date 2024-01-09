using Course_İntro.Abstracts;
using Course_İntro.Models.Constants;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_İntro
{
    public partial class LoginView : Form, IAuth
    {
      
        public bool IsAuth { get;  set; } = false;

        public LoginView()
        {
            InitializeComponent();
        }


        private void button_Login_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox_Username.Text))
            {
                MessageBox.Show("Enter username");
                return;
            }
            if (string.IsNullOrEmpty(textBox_Password.Text))
            {
                MessageBox.Show("Enter Password");
                return;
            }

            string username = textBox_Username.Text;



            if (LoginInformation.USERNAMES_PASSWORDS.TryGetValue(username, out string correctPassword))
            {
                string password = textBox_Password.Text;
                if (password.Equals(correctPassword))
                {
                    //solution 1
                    //IsAuth= true;
                    //this.Close();

                    ////solution 2
                    this.Hide();
                    MainView mainView = new MainView();
                    mainView.Show();
                    mainView.FormClosed += MainView_FormClosed;
                    



                }
                else
                {
                    MessageBox.Show("incorrect");
                    return;
                }

            }
            else
            {
                MessageBox.Show("User does not exist");
                return;
            }                    
        }

        private void MainView_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
