using EmployeeTrainingRecord.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeTrainingRecord
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public bool LoginAsGuest = false;
        public bool LoginAsClerk = false;

        private void bt_Login_Click(object sender, EventArgs e)
        {
            ValidateUser();
        }

        private void ValidateUser()
        {
            using (EtrContext ctx = new EtrContext())
            {
                var user = ctx.UserAccounts.Where(u => u.Username.Equals(tb_Username.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.UserPassword != tb_UserPassword.Text)
                    {
                        MessageBox.Show("Invalid Password.");
                    }


                    else
                    {

                        DialogResult = DialogResult.OK;

                        this.Close();
                        this.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("No (" + tb_Username.Text + ") user found");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            LoginAsClerk = true;
            LoginAsGuest = true;
        }
    }
}
