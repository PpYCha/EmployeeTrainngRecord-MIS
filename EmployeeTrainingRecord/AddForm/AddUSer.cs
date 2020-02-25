using EmployeeTrainingRecord.Models;
using System;
using System.Windows.Forms;

namespace EmployeeTrainingRecord.AddForm
{
    public partial class AddUSer : Form
    {
        public AddUSer()
        {
            InitializeComponent();
        }

        private void bt_SaveUser_Click(object sender, EventArgs e)
        {
            using (EtrContext ctx = new EtrContext())
            {
                var user = new UserAccount()
                {
                    Username = tb_Username.Text,
                    UserPassword = tb_Password.Text,
                };
                ctx.UserAccounts.Add(user);
                ctx.SaveChanges();

            }
        }
    }
}
