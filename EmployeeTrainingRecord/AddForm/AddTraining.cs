using EmployeeTrainingRecord.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeTrainingRecord.AddForm
{
    public partial class AddTraining : Form
    {
        public AddTraining()
        {
            InitializeComponent();
        }
        private DataGridViewRow tempTrainingId;
        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveTraining();
        }

        private void SaveTraining()
        {
            try
            {
                using (EtrContext ctx = new EtrContext())
                {
                    if (ctx.TrainingInfo.Any(x => x.TrainingName == tb_TrainingName.Text && x.DateConducted.Value == dateTimePicker_DateOccured.Value))
                    {
                        MessageBox.Show("Training  Already Exist");
                    }
                    else
                    {
                        if (String.IsNullOrEmpty(tb_TrainingName.Text))
                        {
                            MessageBox.Show("Please enter Training ");
                        }
                        else
                        {
                            if (dataGridView_LoadTrainingList.SelectedRows.Count > 0)
                            {
                                int tempTrainingId = Int32.Parse(dataGridView_LoadTrainingList.SelectedRows[0].Cells[0].Value.ToString());
                                var updateTraiing = ctx.TrainingInfo.SingleOrDefault(x => x.TrainingId == tempTrainingId);
                                {
                                    updateTraiing.TrainingName = tb_TrainingName.Text;
                                    updateTraiing.DateConducted = dateTimePicker_DateOccured.Value.Date;
                                }
                                ctx.SaveChanges();
                                DialogResult result = MessageBox.Show("Do you want to continue?", "Update Successfully", MessageBoxButtons.YesNo);

                                if (result == DialogResult.Yes)
                                {


                                    LoadTrainingList();
                                    tb_TrainingName.Clear();
                                    dataGridView_LoadTrainingList.Rows[0].Selected = false;


                                }
                                else
                                {
                                    this.Close();
                                }
                            }
                            else
                            {


                                var trainingName = new TrainingInfo()
                                {
                                    TrainingName = tb_TrainingName.Text,
                                    DateConducted = dateTimePicker_DateOccured.Value.Date,
                                };
                                ctx.TrainingInfo.Add(trainingName);
                                ctx.SaveChanges();
                                DialogResult result = MessageBox.Show("Do you want to continue?", "Save Successfully", MessageBoxButtons.YesNo);

                                if (result == DialogResult.Yes)
                                {
                                    tb_TrainingName.Clear();


                                    LoadTrainingList();
                                    dataGridView_LoadTrainingList.Rows[0].Selected = false;
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

        private void LoadTrainingList()
        {
            using (var ctx = new EtrContext())
            {
                trainingInfoBindingSource.DataSource = ctx.TrainingInfo.ToList();
            };
            dataGridView_LoadTrainingList.Rows[0].Selected = false;
        }

        private void AddTraining_Load(object sender, EventArgs e)
        {
            LoadTrainingList();
        }

        private void dataGridView_LoadTrainingList_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView_LoadTrainingList.SelectedRows.Count > 0)
            {

                tempTrainingId = dataGridView_LoadTrainingList.SelectedRows[0];
                tb_TrainingName.Text = dataGridView_LoadTrainingList.SelectedRows[0].Cells[1].Value.ToString();

            }
        }

        private void AddTraining_Click(object sender, EventArgs e)
        {
            LoadTrainingList();
        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            using (EtrContext ctx = new EtrContext())
            {
                dataGridView_LoadTrainingList.DataSource = ctx.TrainingInfo.Where(x => x.TrainingName.Contains(tb_Search.Text)).ToList();

                LoadTrainingList();
            }
        }
    }
}