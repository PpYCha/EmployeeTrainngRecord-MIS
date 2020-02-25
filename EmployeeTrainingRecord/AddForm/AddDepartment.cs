using EmployeeTrainingRecord.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeTrainingRecord.AddForm
{
    public partial class AddDepartment : Form
    {
        public AddDepartment()
        {
            InitializeComponent();
        }

        private DataGridViewRow tempDpnId;

        private void button1_Click(object sender, EventArgs e)
        {
            saveDepartment();
        }

        private void saveDepartment()
        {
            try
            {
                using (EtrContext ctx = new EtrContext())
                {
                    if (ctx.DepartmentOfficeNames.Any(x => x.DepartmentName == tb_DepartmentName.Text))
                    {
                        MessageBox.Show("Department Name Already Exist");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(tb_DepartmentName.Text))
                        {
                            MessageBox.Show("Please enter Department Name");
                        }
                        else
                        {
                            if (dataGridView_DepartmentList.SelectedRows.Count > 0)
                            {
                                int temDpnId = Int32.Parse(dataGridView_DepartmentList.SelectedRows[0].Cells[0].Value.ToString());
                                var updateDepartName = ctx.DepartmentOfficeNames.SingleOrDefault(x => x.DpnId == temDpnId);
                                {
                                    updateDepartName.DepartmentName = tb_DepartmentName.Text;
                                }
                                ctx.SaveChanges();
                                DialogResult result = MessageBox.Show("Do you want to continue?", "Update Successfully", MessageBoxButtons.YesNo);

                                if (result == DialogResult.Yes)
                                {


                                    LoadDepartmentList();
                                    dataGridView_DepartmentList.Rows[0].Selected = false;
                                    tb_DepartmentName.Clear();
                                }
                                else
                                {
                                    this.Close();
                                }
                            }
                            else
                            {


                                var departmentOffice = new DepartmentOfficeName()
                                {
                                    DepartmentName = tb_DepartmentName.Text,
                                };
                                ctx.DepartmentOfficeNames.Add(departmentOffice);
                                ctx.SaveChanges();
                                DialogResult result = MessageBox.Show("Do you want to continue?", "Save Successfully", MessageBoxButtons.YesNo);

                                if (result == DialogResult.Yes)
                                {
                                    tb_DepartmentName.Clear();


                                    LoadDepartmentList();
                                    dataGridView_DepartmentList.Rows[0].Selected = false;
                                }
                                else
                                {
                                    this.Close();
                                }
                            }
                        }

                    }

                };
            }
            catch (Exception)
            {

                MessageBox.Show("Please Contact Admin");
            }
        }

        private void AddDepartment_Load(object sender, EventArgs e)
        {
            LoadDepartmentList();
        }

        private void LoadDepartmentList()
        {
            using (var ctx = new EtrContext())
            {
                departmentOfficeNameBindingSource.DataSource = ctx.DepartmentOfficeNames.ToList();
            };
            dataGridView_DepartmentList.Rows[0].Selected = false;
        }

        private void dataGridView_DepartmentList_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_DepartmentList.SelectedRows.Count > 0)
            {
                tempDpnId = dataGridView_DepartmentList.SelectedRows[0];
                tb_DepartmentName.Text = dataGridView_DepartmentList.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            using (EtrContext ctx = new EtrContext())
            {
                dataGridView_DepartmentList.DataSource = ctx.DepartmentOfficeNames.Where(x => x.DepartmentName.Contains(tb_Search.Text)).ToList();

                LoadDepartmentList();
            }
        }
    }
}
