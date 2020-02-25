namespace EmployeeTrainingRecord.AddForm
{
    partial class AddDepartment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_DepartmentName = new System.Windows.Forms.TextBox();
            this.dataGridView_DepartmentList = new System.Windows.Forms.DataGridView();
            this.dpnIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingParticipantsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentOfficeNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DepartmentList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentOfficeNameBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(222, 171);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(160, 83);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department Name:";
            // 
            // tb_DepartmentName
            // 
            this.tb_DepartmentName.Location = new System.Drawing.Point(222, 58);
            this.tb_DepartmentName.Name = "tb_DepartmentName";
            this.tb_DepartmentName.Size = new System.Drawing.Size(243, 27);
            this.tb_DepartmentName.TabIndex = 2;
            // 
            // dataGridView_DepartmentList
            // 
            this.dataGridView_DepartmentList.AutoGenerateColumns = false;
            this.dataGridView_DepartmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_DepartmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_DepartmentList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dpnIdDataGridViewTextBoxColumn,
            this.departmentNameDataGridViewTextBoxColumn,
            this.trainingParticipantsDataGridViewTextBoxColumn});
            this.dataGridView_DepartmentList.DataSource = this.departmentOfficeNameBindingSource;
            this.dataGridView_DepartmentList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_DepartmentList.Location = new System.Drawing.Point(516, 125);
            this.dataGridView_DepartmentList.Name = "dataGridView_DepartmentList";
            this.dataGridView_DepartmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_DepartmentList.Size = new System.Drawing.Size(690, 306);
            this.dataGridView_DepartmentList.TabIndex = 3;
            this.dataGridView_DepartmentList.DoubleClick += new System.EventHandler(this.dataGridView_DepartmentList_DoubleClick);
            // 
            // dpnIdDataGridViewTextBoxColumn
            // 
            this.dpnIdDataGridViewTextBoxColumn.DataPropertyName = "DpnId";
            this.dpnIdDataGridViewTextBoxColumn.HeaderText = "DpnId";
            this.dpnIdDataGridViewTextBoxColumn.Name = "dpnIdDataGridViewTextBoxColumn";
            this.dpnIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.dpnIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentNameDataGridViewTextBoxColumn
            // 
            this.departmentNameDataGridViewTextBoxColumn.DataPropertyName = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.HeaderText = "DepartmentName";
            this.departmentNameDataGridViewTextBoxColumn.Name = "departmentNameDataGridViewTextBoxColumn";
            // 
            // trainingParticipantsDataGridViewTextBoxColumn
            // 
            this.trainingParticipantsDataGridViewTextBoxColumn.DataPropertyName = "TrainingParticipants";
            this.trainingParticipantsDataGridViewTextBoxColumn.HeaderText = "TrainingParticipants";
            this.trainingParticipantsDataGridViewTextBoxColumn.Name = "trainingParticipantsDataGridViewTextBoxColumn";
            this.trainingParticipantsDataGridViewTextBoxColumn.ReadOnly = true;
            this.trainingParticipantsDataGridViewTextBoxColumn.Visible = false;
            // 
            // departmentOfficeNameBindingSource
            // 
            this.departmentOfficeNameBindingSource.DataSource = typeof(EmployeeTrainingRecord.Models.DepartmentOfficeName);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(516, 62);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(243, 27);
            this.tb_Search.TabIndex = 4;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // AddDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 496);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dataGridView_DepartmentList);
            this.Controls.Add(this.tb_DepartmentName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Save);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddDepartment";
            this.Load += new System.EventHandler(this.AddDepartment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_DepartmentList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentOfficeNameBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_DepartmentName;
        private System.Windows.Forms.DataGridView dataGridView_DepartmentList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpnIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingParticipantsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource departmentOfficeNameBindingSource;
        private System.Windows.Forms.TextBox tb_Search;
    }
}