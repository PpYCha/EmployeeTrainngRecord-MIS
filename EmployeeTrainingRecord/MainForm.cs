using EmployeeTrainingRecord.AddForm;
using EmployeeTrainingRecord.Models;
using EmployeeTrainingRecord.Reports;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeTrainingRecord
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        private void manageEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void manageTrainingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddTraining addTraining = new AddTraining();
            addTraining.Show();
        }

        private void manageDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartment addDepartment = new AddDepartment();
            addDepartment.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchEmployee();
        }

        private void searchEmployee()
        {
            using (EtrContext ctx = new EtrContext())
            {
                //dataGridView_EmployeeList.DataSource = ctx.TrainingParticipants.Where(x => x.FirstName.Contains(textBox1.Text) ||
                //x.LastName.Contains(textBox1.Text)).ToList();
                dataGridView_EmployeeList.DataSource = ctx.TrainingParticipants.Where(x => String.Concat(x.FirstName, " ", x.LastName).Contains(textBox1.Text)).ToList();
            };
            LoadDepartmentCell();

        }

        private void addEmployeeTrainingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployeeTraining addEmployeeTraining = new AddEmployeeTraining();
            addEmployeeTraining.Show();
        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEmployee addEmployee = new AddEmployee();
            addEmployee.Show();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_EmployeeList11.SelectedRows.Count > 0)
            {




                ViewTrainingAttended viewTrainingAttended = new ViewTrainingAttended();
                viewTrainingAttended.viewEmployeeId = dataGridView_EmployeeList11.SelectedRows[0];
                viewTrainingAttended.Show();
            }
        }

        private void LoadDepartmentCell()
        {
            //using (EtrContext ctx = new EtrContext())
            //{
            //    foreach (DataGridViewRow row in dataGridView_EmployeeList.Row)
            //    {
            //        if (row.Cells[6].Value.ToString() != null)
            //        {
            //            int tempDpnId = Int32.Parse(row.Cells[6].Value.ToString());

            //            //var dpnNameQuery = from d1 in ctx.DepartmentOfficeNames
            //            //                   where d1.DpnId == tempDpnId
            //            //                   select (d1.DepartmentName).ToList();

            //            var name = ctx.DepartmentOfficeNames.Where(x => x.DpnId == tempDpnId).Select(x => x.DepartmentName).SingleOrDefault();

            //            row.Cells[7].Value = name.ToString();


            //        }
            //    }
            //}

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();

            if (loginForm.DialogResult == DialogResult.OK)
            {


                //button1.Visible = false;
            }
            else if (loginForm.LoginAsClerk == true)
            {
                manageTrainingToolStripMenuItem.Visible = false;

            }
            else
            {
                this.Close();
            }


        }

        private void dataGridView_EmployeeList_Click(object sender, EventArgs e)
        {
            using (EtrContext ctx = new EtrContext())
            {
                int tempId = Int32.Parse(dataGridView_EmployeeList11.SelectedRows[0].Cells[0].Value.ToString());



                var result = from f in ctx.TrainingParticipantsAttendeds

                             join d in ctx.TrainingInfo

                             on f.TrainingId equals d.TrainingId into empDept

                             from ed in empDept.DefaultIfEmpty()
                             where f.TrainingParticpantId == tempId
                             select new

                             {

                                 ed.TrainingName,
                                 ed.DateConducted,


                             };




                dataGridView1.DataSource = result.ToList();
                //dataGridView1.Columns[0].HeaderCell.Value = "Training";


            };


        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void byEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrainingAttendedReport trainingAttendedReport = new TrainingAttendedReport();
            trainingAttendedReport.Show();
        }

        private void manageUSerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUSer addUSer = new AddUSer();
            addUSer.Show();
        }
    }
}
