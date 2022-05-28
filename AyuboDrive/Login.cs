using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            if (usernameTbox.Text.Trim() != "" && passwordTbox.Text.Trim() != "") {

                if (usernameTbox.Text == "admin" && passwordTbox.Text == "admin123") {
                    MainMenu mm = new MainMenu();
                    mm.Visible = true;
                    this.Hide();
                }

                else {
                    MessageBox.Show("Wrong Username or Password!");
                }
            }

            else {
                MessageBox.Show("Please fill all details!");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            usernameTbox.ResetText();
            passwordTbox.ResetText();
        }
    }
}
