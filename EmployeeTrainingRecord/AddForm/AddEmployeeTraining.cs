using EmployeeTrainingRecord.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeTrainingRecord.AddForm
{
    public partial class AddEmployeeTraining : Form
    {
        public AddEmployeeTraining()
        {
            InitializeComponent();
        }

        private DataGridViewRow employeeId;

        private void bt_Search_Click(object sender, EventArgs e)
        {
            SearchEmployee();
            fillTraining();

        }

        private void SearchEmployee()
        {
            using (EtrContext ctx = new EtrContext())
            {
                dataGridView_EmployeeList.DataSource = ctx.TrainingParticipants.Where(x => x.FirstName.Contains(tb_Search.Text) ||
                x.LastName.Contains(tb_Search.Text)).ToList();
                LoadDepartmentCell();
            };
        }

        private void LoadDepartmentCell()
        {
            using (EtrContext ctx = new EtrContext())
            {
                foreach (DataGridViewRow row in dataGridView_EmployeeList.Rows)
                {
                    if (row.Cells[5].Value.ToString() != null)
                    {
                        int tempDpnId = Int32.Parse(row.Cells[5].Value.ToString());

                        //var dpnNameQuery = from d1 in ctx.DepartmentOfficeNames
                        //                   where d1.DpnId == tempDpnId
                        //                   select (d1.DepartmentName).ToList();

                        var name = ctx.DepartmentOfficeNames.Where(x => x.DpnId == tempDpnId).Select(x => x.DepartmentName).SingleOrDefault();

                        row.Cells[6].Value = name.ToString();


                    }
                }
            }

        }

        private void AddEmployeeTraining_Load(object sender, EventArgs e)
        {

        }

        private void fillTraining()
        {
            using (var ctx = new EtrContext())
            {
                var trainingList = ctx.TrainingInfo.ToList();
                if (trainingList.Count > 0)
                {
                    cb_Training.DataSource = trainingList;
                    cb_Training.DisplayMember = "TrainingName";
                    cb_Training.ValueMember = "TrainingId";


                }
            }
        }

        private void dataGridView_EmployeeList_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_EmployeeList.SelectedRows.Count > 0)
            {
                employeeId = dataGridView_EmployeeList.SelectedRows[0];
            }
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {

            int userId = Int32.Parse(dataGridView_EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
            int tempTraiingId = Int32.Parse(cb_Training.GetItemText(cb_Training.SelectedValue));
            using (var ctx = new EtrContext())
            {
                if (ctx.TrainingParticipantsAttendeds.Any(x => x.TrainingParticpantId == userId && x.TrainingId == tempTraiingId))
                {
                    MessageBox.Show("Traning already done");
                    cb_Training.SelectedIndex = -1;
                }
                else
                {

                    var tpa = new TrainingParticipantsAttended()
                    {
                        TrainingParticpantId = userId,
                        TrainingId = Int32.Parse(cb_Training.GetItemText(cb_Training.SelectedValue))

                    };

                    ctx.TrainingParticipantsAttendeds.Add(tpa);
                    ctx.SaveChanges();
                    DialogResult result = MessageBox.Show("Do you want to continue?", "Save Successfully", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {

                        cb_Training.SelectedIndex = -1;


                    }
                    else
                    {
                        this.Close();
                    }
                }
            };
        }
    }
}
