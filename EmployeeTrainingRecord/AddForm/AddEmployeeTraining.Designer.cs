namespace EmployeeTrainingRecord.AddForm
{
    partial class AddEmployeeTraining
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
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.cb_Training = new System.Windows.Forms.ComboBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.trainingParticipantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.trainingInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_EmployeeList = new System.Windows.Forms.DataGridView();
            this.trainingParticpantIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpnIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.trainingParticipantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeList)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(38, 31);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(189, 27);
            this.tb_Search.TabIndex = 1;
            // 
            // bt_Search
            // 
            this.bt_Search.Location = new System.Drawing.Point(294, 22);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(250, 44);
            this.bt_Search.TabIndex = 2;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = true;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // cb_Training
            // 
            this.cb_Training.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Training.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb_Training.FormattingEnabled = true;
            this.cb_Training.Location = new System.Drawing.Point(12, 350);
            this.cb_Training.Name = "cb_Training";
            this.cb_Training.Size = new System.Drawing.Size(328, 29);
            this.cb_Training.TabIndex = 3;
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(595, 350);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(150, 56);
            this.bt_Save.TabIndex = 4;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // trainingParticipantsBindingSource
            // 
            this.trainingParticipantsBindingSource.DataSource = typeof(EmployeeTrainingRecord.Models.TrainingParticipants);
            // 
            // trainingInfoBindingSource
            // 
            this.trainingInfoBindingSource.DataSource = typeof(EmployeeTrainingRecord.Models.TrainingInfo);
            // 
            // dataGridView_EmployeeList
            // 
            this.dataGridView_EmployeeList.AutoGenerateColumns = false;
            this.dataGridView_EmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmployeeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainingParticpantIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.extNameDataGridViewTextBoxColumn,
            this.dpnIdDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView_EmployeeList.DataSource = this.trainingParticipantsBindingSource;
            this.dataGridView_EmployeeList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_EmployeeList.Location = new System.Drawing.Point(38, 84);
            this.dataGridView_EmployeeList.Name = "dataGridView_EmployeeList";
            this.dataGridView_EmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_EmployeeList.Size = new System.Drawing.Size(1163, 207);
            this.dataGridView_EmployeeList.TabIndex = 15;
            // 
            // trainingParticpantIdDataGridViewTextBoxColumn
            // 
            this.trainingParticpantIdDataGridViewTextBoxColumn.DataPropertyName = "TrainingParticpantId";
            this.trainingParticpantIdDataGridViewTextBoxColumn.HeaderText = "TrainingParticpantId";
            this.trainingParticpantIdDataGridViewTextBoxColumn.Name = "trainingParticpantIdDataGridViewTextBoxColumn";
            this.trainingParticpantIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // extNameDataGridViewTextBoxColumn
            // 
            this.extNameDataGridViewTextBoxColumn.DataPropertyName = "ExtName";
            this.extNameDataGridViewTextBoxColumn.HeaderText = "ExtName";
            this.extNameDataGridViewTextBoxColumn.Name = "extNameDataGridViewTextBoxColumn";
            // 
            // dpnIdDataGridViewTextBoxColumn
            // 
            this.dpnIdDataGridViewTextBoxColumn.DataPropertyName = "DpnId";
            this.dpnIdDataGridViewTextBoxColumn.HeaderText = "DpnId";
            this.dpnIdDataGridViewTextBoxColumn.Name = "dpnIdDataGridViewTextBoxColumn";
            this.dpnIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Department";
            this.Column1.Name = "Column1";
            // 
            // AddEmployeeTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 416);
            this.Controls.Add(this.dataGridView_EmployeeList);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.cb_Training);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tb_Search);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEmployeeTraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployeeTraining";
            this.Load += new System.EventHandler(this.AddEmployeeTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trainingParticipantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button bt_Search;
        private System.Windows.Forms.ComboBox cb_Training;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.BindingSource trainingParticipantsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource trainingInfoBindingSource;
        private System.Windows.Forms.DataGridView dataGridView_EmployeeList;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingParticpantIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpnIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}