using EmployeeTrainingRecord.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeTrainingRecord.AddForm
{
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        public DataGridViewRow tempEployeId;

        private void button_Save_Click(object sender, EventArgs e)
        {
            SaveEmployee();
        }

        private void SaveEmployee()
        {
            try
            {
                using (EtrContext ctx = new EtrContext())
                {
                    if (ctx.TrainingParticipants.Any(x => x.FirstName == textBox_FName.Text && x.MiddleName == textBox_MName.Text && x.LastName == textBox_LastName.Text))
                    {
                        MessageBox.Show("Employee Already Exist");

                    }
                    else
                    {

                        if (dataGridView_EmployeeList.SelectedRows.Count > 0)
                        {
                            if (String.IsNullOrEmpty(textBox_FName.Text) && String.IsNullOrEmpty(textBox_LastName.Text) || cb_Department.SelectedIndex != -1)
                            {

                                int tempUd = Int32.Parse(dataGridView_EmployeeList.SelectedRows[0].Cells[0].Value.ToString());
                                var updateTrainne = ctx.TrainingParticipants.SingleOrDefault(x => x.TrainingParticpantId == tempUd);

                                {
                                    //TrainingParticpantId = Int32.Parse(dataGridView_EmployeeList.SelectedRows[0].Cells[7].Value.ToString()),
                                    updateTrainne.FirstName = textBox_FName.Text;
                                    updateTrainne.MiddleName = textBox_MName.Text;
                                    updateTrainne.LastName = textBox_LastName.Text;
                                    updateTrainne.ExtName = textBox_EName.Text;
                                    updateTrainne.DpnId = Int32.Parse(cb_Department.GetItemText(cb_Department.SelectedValue));

                                };

                                //ctx.TrainingParticipants.Add(updateTrainne);
                                //ctx.Entry(updateTrainne).Property(x => x.FirstName).IsModified = true;
                                ctx.SaveChanges();
                                DeselectList();

                                DialogResult result = MessageBox.Show("Do you want to continue?", "Update Successfully", MessageBoxButtons.YesNo);

                                if (result == DialogResult.Yes)
                                {
                                    this.TraverseControlsAndSetTextEmpty(this);
                                    cb_Department.SelectedIndex = -1;

                                    LoadEmployeeList();
                                    DeselectList();
                                }
                                else
                                {
                                    this.Close();
                                }


                            }
                            else
                            {
                                MessageBox.Show("Please filled all the requred fields");
                            }
                        }
                        else
                        {
                            if (textBox_FName.Text == " " && String.IsNullOrEmpty(textBox_LastName.Text) || cb_Department.SelectedIndex != -1)
                            {

                                var trainee = new TrainingParticipants()
                                {
                                    FirstName = textBox_FName.Text,
                                    MiddleName = textBox_MName.Text,
                                    LastName = textBox_LastName.Text,
                                    ExtName = textBox_EName.Text,

                                    DpnId = Int32.Parse(cb_Department.GetItemText(cb_Department.SelectedValue)),
                                    //TrainingName = cb_Training.GetItemText(cb_Training.SelectedItem)
                                };
                                ctx.TrainingParticipants.Add(trainee);
                                ctx.SaveChanges();
                                DialogResult result = MessageBox.Show("Do you want to continue?", "Save Successfully", MessageBoxButtons.YesNo);

                                if (result == DialogResult.Yes)
                                {
                                    this.TraverseControlsAndSetTextEmpty(this);
                                    cb_Department.SelectedIndex = -1;

                                    LoadEmployeeList();
                                    DeselectList();
                                }
                                else
                                {
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please filled all the requred fields");
                            }
                        }

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please contact Admin");

            }

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {

            fillDepartment();

            LoadEmployeeList();
            DeselectList();


        }

        private void DeselectList()
        {
            dataGridView_EmployeeList.Rows[0].Selected = false;
            this.TraverseControlsAndSetTextEmpty(this);
        }

        private void TraverseControlsAndSetTextEmpty(Control control)
        {
            foreach (Control c in control.Controls)
            {
                var box = c as TextBox;
                if (box != null)
                {
                    box.Text = string.Empty;
                }

                this.TraverseControlsAndSetTextEmpty(c);
            }
        }

        private void LoadEmployeeList()
        {
            using (var ctx = new EtrContext())
            {

                dataGridView_EmployeeList.DataSource = ctx.TrainingParticipants.ToList();

                LoadDepartmentCell();
            }
        }

        private void LoadDepartmentCell()
        {
            using (var ctx = new EtrContext())
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

        //private void fillTraining()
        //{
        //    using (var ctx = new EtrContext())
        //    {
        //        var trainingList = ctx.TrainingInfo.ToList();
        //        if (trainingList.Count > 0)
        //        {
        //            cb_Training.DataSource = trainingList;
        //            cb_Training.DisplayMember = "TrainingName";
        //            cb_Training.ValueMember = "TrainingId";


        //        }
        //    }
        //}

        private void fillDepartment()
        {
            using (var ctx = new EtrContext())
            {
                var departmentList = ctx.DepartmentOfficeNames.ToList();
                if (departmentList.Count > 0)
                {
                    cb_Department.DataSource = departmentList;
                    cb_Department.DisplayMember = "DepartmentName";
                    cb_Department.ValueMember = "DpnId";
                    cb_Department.SelectedIndex = -1;
                }
            };


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            using (EtrContext ctx = new EtrContext())
            {
                dataGridView_EmployeeList.DataSource = ctx.TrainingParticipants.Where(x => x.FirstName.Contains(textBox1.Text) || x.LastName.Contains(textBox1.Text)).ToList();

                LoadDepartmentCell();
            }
        }

        private void dataGridView_EmployeeList_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_EmployeeList.SelectedRows.Count > 0)
            {

                tempEployeId = dataGridView_EmployeeList.SelectedRows[0];
                textBox_FName.Text = dataGridView_EmployeeList.SelectedRows[0].Cells[1].Value.ToString();
                textBox_MName.Text = dataGridView_EmployeeList.SelectedRows[0].Cells[2].Value.ToString();
                textBox_LastName.Text = dataGridView_EmployeeList.SelectedRows[0].Cells[3].Value.ToString();
                textBox_EName.Text = dataGridView_EmployeeList.SelectedRows[0].Cells[4].Value.ToString();
                cb_Department.SelectedIndex = Int32.Parse(dataGridView_EmployeeList.SelectedRows[0].Cells[5].Value.ToString()) - 1;
            }
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            DeselectList();
        }
    }
}
