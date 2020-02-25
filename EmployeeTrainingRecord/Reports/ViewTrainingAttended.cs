using EmployeeTrainingRecord.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EmployeeTrainingRecord.Reports
{
    public partial class ViewTrainingAttended : Form
    {
        public ViewTrainingAttended()
        {
            InitializeComponent();
        }

        public DataGridViewRow viewEmployeeId;

        private void ViewTrainingAttended_Load(object sender, EventArgs e)
        {
            using (EtrContext ctx = new EtrContext())
            {

                int tempId = Int32.Parse(viewEmployeeId.Cells[0].Value.ToString());

                textBox_FName.Text = viewEmployeeId.Cells[1].Value.ToString();
                textBox_MName.Text = viewEmployeeId.Cells[2].Value.ToString();
                textBox_LastName.Text = viewEmployeeId.Cells[3].Value.ToString();
                textBox_EName.Text = viewEmployeeId.Cells[4].Value.ToString();

                int tempDiD = Int32.Parse(viewEmployeeId.Cells[6].Value.ToString());
                var name = ctx.DepartmentOfficeNames.Where(x => x.DpnId == tempDiD).Select(x => x.DepartmentName).SingleOrDefault();
                tb_Department.Text = name.ToString();



                var result = from f in ctx.TrainingParticipantsAttendeds

                             join d in ctx.TrainingInfo

                             on f.TrainingId equals d.TrainingId into empDept

                             from ed in empDept.DefaultIfEmpty()
                             where f.TrainingParticpantId == tempId
                             select new

                             {

                                 ed.TrainingName,


                             };




                dataGridView_LoadTrainings.DataSource = result.ToList();
                dataGridView_LoadTrainings.Columns[0].HeaderCell.Value = "Training";


            };
        }
    }
}
