namespace EmployeeTrainingRecord.AddForm
{
    partial class AddTraining
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
            this.tb_TrainingName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_DateOccured = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dataGridView_LoadTrainingList = new System.Windows.Forms.DataGridView();
            this.trainingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateConductedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_Search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoadTrainingList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_TrainingName
            // 
            this.tb_TrainingName.Location = new System.Drawing.Point(305, 85);
            this.tb_TrainingName.Margin = new System.Windows.Forms.Padding(5);
            this.tb_TrainingName.Name = "tb_TrainingName";
            this.tb_TrainingName.Size = new System.Drawing.Size(164, 27);
            this.tb_TrainingName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Training Name:";
            // 
            // dateTimePicker_DateOccured
            // 
            this.dateTimePicker_DateOccured.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_DateOccured.Location = new System.Drawing.Point(305, 136);
            this.dateTimePicker_DateOccured.Name = "dateTimePicker_DateOccured";
            this.dateTimePicker_DateOccured.Size = new System.Drawing.Size(164, 27);
            this.dateTimePicker_DateOccured.TabIndex = 3;
            this.dateTimePicker_DateOccured.Value = new System.DateTime(2020, 1, 11, 19, 11, 8, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date Occured:";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(195, 227);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(274, 66);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dataGridView_LoadTrainingList
            // 
            this.dataGridView_LoadTrainingList.AutoGenerateColumns = false;
            this.dataGridView_LoadTrainingList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LoadTrainingList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoadTrainingList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainingIdDataGridViewTextBoxColumn,
            this.trainingNameDataGridViewTextBoxColumn,
            this.dateConductedDataGridViewTextBoxColumn,
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn});
            this.dataGridView_LoadTrainingList.DataSource = this.trainingInfoBindingSource;
            this.dataGridView_LoadTrainingList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_LoadTrainingList.Location = new System.Drawing.Point(538, 205);
            this.dataGridView_LoadTrainingList.Name = "dataGridView_LoadTrainingList";
            this.dataGridView_LoadTrainingList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_LoadTrainingList.Size = new System.Drawing.Size(683, 273);
            this.dataGridView_LoadTrainingList.TabIndex = 6;
            this.dataGridView_LoadTrainingList.DoubleClick += new System.EventHandler(this.dataGridView_LoadTrainingList_DoubleClick);
            // 
            // trainingIdDataGridViewTextBoxColumn
            // 
            this.trainingIdDataGridViewTextBoxColumn.DataPropertyName = "TrainingId";
            this.trainingIdDataGridViewTextBoxColumn.HeaderText = "TrainingId";
            this.trainingIdDataGridViewTextBoxColumn.Name = "trainingIdDataGridViewTextBoxColumn";
            this.trainingIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // trainingNameDataGridViewTextBoxColumn
            // 
            this.trainingNameDataGridViewTextBoxColumn.DataPropertyName = "TrainingName";
            this.trainingNameDataGridViewTextBoxColumn.HeaderText = "TrainingName";
            this.trainingNameDataGridViewTextBoxColumn.Name = "trainingNameDataGridViewTextBoxColumn";
            // 
            // dateConductedDataGridViewTextBoxColumn
            // 
            this.dateConductedDataGridViewTextBoxColumn.DataPropertyName = "DateConducted";
            this.dateConductedDataGridViewTextBoxColumn.HeaderText = "DateConducted";
            this.dateConductedDataGridViewTextBoxColumn.Name = "dateConductedDataGridViewTextBoxColumn";
            // 
            // trainingParticipantsAttendedsDataGridViewTextBoxColumn
            // 
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn.DataPropertyName = "TrainingParticipantsAttendeds";
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn.HeaderText = "TrainingParticipantsAttendeds";
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn.Name = "trainingParticipantsAttendedsDataGridViewTextBoxColumn";
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn.ReadOnly = true;
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn.Visible = false;
            // 
            // trainingInfoBindingSource
            // 
            this.trainingInfoBindingSource.DataSource = typeof(EmployeeTrainingRecord.Models.TrainingInfo);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(538, 85);
            this.tb_Search.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(164, 27);
            this.tb_Search.TabIndex = 7;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // AddTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 505);
            this.Controls.Add(this.tb_Search);
            this.Controls.Add(this.dataGridView_LoadTrainingList);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker_DateOccured);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_TrainingName);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddTraining";
            this.Text = "AddTraining";
            this.Load += new System.EventHandler(this.AddTraining_Load);
            this.Click += new System.EventHandler(this.AddTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoadTrainingList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_TrainingName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_DateOccured;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DataGridView dataGridView_LoadTrainingList;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateConductedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingParticipantsAttendedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource trainingInfoBindingSource;
    }
}