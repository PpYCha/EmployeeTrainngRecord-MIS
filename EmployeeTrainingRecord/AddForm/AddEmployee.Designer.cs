namespace EmployeeTrainingRecord.AddForm
{
    partial class AddEmployee
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
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_MName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_EName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_Department = new System.Windows.Forms.ComboBox();
            this.dataGridView_EmployeeList = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingParticpantIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpnIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingParticipantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingParticipantsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_FName
            // 
            this.textBox_FName.Location = new System.Drawing.Point(174, 83);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.Size = new System.Drawing.Size(268, 27);
            this.textBox_FName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Middle Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name:";
            // 
            // textBox_MName
            // 
            this.textBox_MName.Location = new System.Drawing.Point(174, 116);
            this.textBox_MName.Name = "textBox_MName";
            this.textBox_MName.Size = new System.Drawing.Size(268, 27);
            this.textBox_MName.TabIndex = 4;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(174, 149);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(268, 27);
            this.textBox_LastName.TabIndex = 5;
            // 
            // textBox_EName
            // 
            this.textBox_EName.Location = new System.Drawing.Point(174, 182);
            this.textBox_EName.Name = "textBox_EName";
            this.textBox_EName.Size = new System.Drawing.Size(268, 27);
            this.textBox_EName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Extension Name:";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(174, 234);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(163, 59);
            this.button_Save.TabIndex = 8;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Department:";
            // 
            // cb_Department
            // 
            this.cb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Department.FormattingEnabled = true;
            this.cb_Department.Location = new System.Drawing.Point(174, 30);
            this.cb_Department.Name = "cb_Department";
            this.cb_Department.Size = new System.Drawing.Size(268, 29);
            this.cb_Department.TabIndex = 13;
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
            this.dataGridView_EmployeeList.Location = new System.Drawing.Point(460, 91);
            this.dataGridView_EmployeeList.Name = "dataGridView_EmployeeList";
            this.dataGridView_EmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_EmployeeList.Size = new System.Drawing.Size(777, 351);
            this.dataGridView_EmployeeList.TabIndex = 14;
            this.dataGridView_EmployeeList.DoubleClick += new System.EventHandler(this.dataGridView_EmployeeList_DoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(678, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 27);
            this.textBox1.TabIndex = 15;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Department";
            this.Column1.Name = "Column1";
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
            // trainingParticipantsBindingSource
            // 
            this.trainingParticipantsBindingSource.DataSource = typeof(EmployeeTrainingRecord.Models.TrainingParticipants);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(481, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Search:";
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 551);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView_EmployeeList);
            this.Controls.Add(this.cb_Department);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.textBox_EName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_MName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_FName);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AddEmployee";
            this.Text = "AddEmployee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            this.Click += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingParticipantsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_MName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_EName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_Department;
        private System.Windows.Forms.DataGridView dataGridView_EmployeeList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource trainingParticipantsBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingParticpantIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpnIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label5;
    }
}