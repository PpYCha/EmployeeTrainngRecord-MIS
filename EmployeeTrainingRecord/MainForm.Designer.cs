namespace EmployeeTrainingRecord
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeTrainingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTrainingToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDepartmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUSerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.byEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView_EmployeeList11 = new System.Windows.Forms.DataGridView();
            this.trainingParticpantIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpnIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingParticipantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateConductedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trainingInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_EmployeeList = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTrainingParticpantId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiddleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExtName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrainingParticipantsAttendeds = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDpnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDepartmentOfficeNames = new DevExpress.XtraGrid.Columns.GridColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeList11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingParticipantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTrainingToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1271, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageTrainingToolStripMenuItem
            // 
            this.manageTrainingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageEmployeeToolStripMenuItem,
            this.manageTrainingToolStripMenuItem1,
            this.manageDepartmentToolStripMenuItem,
            this.manageUSerToolStripMenuItem});
            this.manageTrainingToolStripMenuItem.Name = "manageTrainingToolStripMenuItem";
            this.manageTrainingToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageTrainingToolStripMenuItem.Text = "Manage";
            // 
            // manageEmployeeToolStripMenuItem
            // 
            this.manageEmployeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.addEmployeeTrainingToolStripMenuItem});
            this.manageEmployeeToolStripMenuItem.Name = "manageEmployeeToolStripMenuItem";
            this.manageEmployeeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manageEmployeeToolStripMenuItem.Text = "Manage Employee";
            this.manageEmployeeToolStripMenuItem.Click += new System.EventHandler(this.manageEmployeeToolStripMenuItem_Click);
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // addEmployeeTrainingToolStripMenuItem
            // 
            this.addEmployeeTrainingToolStripMenuItem.Name = "addEmployeeTrainingToolStripMenuItem";
            this.addEmployeeTrainingToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.addEmployeeTrainingToolStripMenuItem.Text = "AddEmployeeTraining";
            this.addEmployeeTrainingToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeTrainingToolStripMenuItem_Click);
            // 
            // manageTrainingToolStripMenuItem1
            // 
            this.manageTrainingToolStripMenuItem1.Name = "manageTrainingToolStripMenuItem1";
            this.manageTrainingToolStripMenuItem1.Size = new System.Drawing.Size(183, 22);
            this.manageTrainingToolStripMenuItem1.Text = "Manage Training";
            this.manageTrainingToolStripMenuItem1.Click += new System.EventHandler(this.manageTrainingToolStripMenuItem1_Click);
            // 
            // manageDepartmentToolStripMenuItem
            // 
            this.manageDepartmentToolStripMenuItem.Name = "manageDepartmentToolStripMenuItem";
            this.manageDepartmentToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manageDepartmentToolStripMenuItem.Text = "Manage Department";
            this.manageDepartmentToolStripMenuItem.Click += new System.EventHandler(this.manageDepartmentToolStripMenuItem_Click);
            // 
            // manageUSerToolStripMenuItem
            // 
            this.manageUSerToolStripMenuItem.Name = "manageUSerToolStripMenuItem";
            this.manageUSerToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.manageUSerToolStripMenuItem.Text = "Manage USer";
            this.manageUSerToolStripMenuItem.Click += new System.EventHandler(this.manageUSerToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.byEmployeesToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            this.reportsToolStripMenuItem.Click += new System.EventHandler(this.reportsToolStripMenuItem_Click);
            // 
            // byEmployeesToolStripMenuItem
            // 
            this.byEmployeesToolStripMenuItem.Name = "byEmployeesToolStripMenuItem";
            this.byEmployeesToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.byEmployeesToolStripMenuItem.Text = "By Employees";
            this.byEmployeesToolStripMenuItem.Click += new System.EventHandler(this.byEmployeesToolStripMenuItem_Click);
            // 
            // dataGridView_EmployeeList11
            // 
            this.dataGridView_EmployeeList11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_EmployeeList11.AutoGenerateColumns = false;
            this.dataGridView_EmployeeList11.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_EmployeeList11.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_EmployeeList11.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.trainingParticpantIdDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.extNameDataGridViewTextBoxColumn,
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn,
            this.dpnIdDataGridViewTextBoxColumn,
            this.Column1});
            this.dataGridView_EmployeeList11.DataSource = this.trainingParticipantsBindingSource;
            this.dataGridView_EmployeeList11.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView_EmployeeList11.Location = new System.Drawing.Point(0, 143);
            this.dataGridView_EmployeeList11.Name = "dataGridView_EmployeeList11";
            this.dataGridView_EmployeeList11.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_EmployeeList11.Size = new System.Drawing.Size(719, 313);
            this.dataGridView_EmployeeList11.TabIndex = 1;
            this.dataGridView_EmployeeList11.Click += new System.EventHandler(this.dataGridView_EmployeeList_Click);
            this.dataGridView_EmployeeList11.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
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
            // trainingParticipantsAttendedsDataGridViewTextBoxColumn
            // 
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn.DataPropertyName = "TrainingParticipantsAttendeds";
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn.HeaderText = "TrainingParticipantsAttendeds";
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn.Name = "trainingParticipantsAttendedsDataGridViewTextBoxColumn";
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn.ReadOnly = true;
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn.Visible = false;
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
            this.Column1.HeaderText = "Deparment";
            this.Column1.Name = "Column1";
            // 
            // trainingParticipantsBindingSource
            // 
            this.trainingParticipantsBindingSource.DataSource = typeof(EmployeeTrainingRecord.Models.TrainingParticipants);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 27);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.trainingIdDataGridViewTextBoxColumn,
            this.trainingNameDataGridViewTextBoxColumn,
            this.dateConductedDataGridViewTextBoxColumn,
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.trainingInfoBindingSource;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(1124, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(135, 313);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Traning";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
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
            // trainingParticipantsAttendedsDataGridViewTextBoxColumn1
            // 
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn1.DataPropertyName = "TrainingParticipantsAttendeds";
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn1.HeaderText = "TrainingParticipantsAttendeds";
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn1.Name = "trainingParticipantsAttendedsDataGridViewTextBoxColumn1";
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn1.ReadOnly = true;
            this.trainingParticipantsAttendedsDataGridViewTextBoxColumn1.Visible = false;
            // 
            // trainingInfoBindingSource
            // 
            this.trainingInfoBindingSource.DataSource = typeof(EmployeeTrainingRecord.Models.TrainingInfo);
            // 
            // dataGridView_EmployeeList
            // 
            this.dataGridView_EmployeeList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_EmployeeList.DataSource = this.trainingParticipantsBindingSource;
            this.dataGridView_EmployeeList.Location = new System.Drawing.Point(725, 143);
            this.dataGridView_EmployeeList.MainView = this.gridView1;
            this.dataGridView_EmployeeList.Name = "dataGridView_EmployeeList";
            this.dataGridView_EmployeeList.Size = new System.Drawing.Size(393, 313);
            this.dataGridView_EmployeeList.TabIndex = 7;
            this.dataGridView_EmployeeList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTrainingParticpantId,
            this.colFirstName,
            this.colMiddleName,
            this.colLastName,
            this.colExtName,
            this.colTrainingParticipantsAttendeds,
            this.colDpnId,
            this.colDepartmentOfficeNames});
            this.gridView1.GridControl = this.dataGridView_EmployeeList;
            this.gridView1.Name = "gridView1";
            // 
            // colTrainingParticpantId
            // 
            this.colTrainingParticpantId.FieldName = "TrainingParticpantId";
            this.colTrainingParticpantId.Name = "colTrainingParticpantId";
            // 
            // colFirstName
            // 
            this.colFirstName.FieldName = "FirstName";
            this.colFirstName.Name = "colFirstName";
            this.colFirstName.Visible = true;
            this.colFirstName.VisibleIndex = 0;
            // 
            // colMiddleName
            // 
            this.colMiddleName.FieldName = "MiddleName";
            this.colMiddleName.Name = "colMiddleName";
            this.colMiddleName.Visible = true;
            this.colMiddleName.VisibleIndex = 1;
            // 
            // colLastName
            // 
            this.colLastName.FieldName = "LastName";
            this.colLastName.Name = "colLastName";
            this.colLastName.Visible = true;
            this.colLastName.VisibleIndex = 2;
            // 
            // colExtName
            // 
            this.colExtName.FieldName = "ExtName";
            this.colExtName.Name = "colExtName";
            this.colExtName.Visible = true;
            this.colExtName.VisibleIndex = 3;
            // 
            // colTrainingParticipantsAttendeds
            // 
            this.colTrainingParticipantsAttendeds.FieldName = "TrainingParticipantsAttendeds";
            this.colTrainingParticipantsAttendeds.Name = "colTrainingParticipantsAttendeds";
            this.colTrainingParticipantsAttendeds.OptionsColumn.ReadOnly = true;
            // 
            // colDpnId
            // 
            this.colDpnId.FieldName = "DpnId";
            this.colDpnId.Name = "colDpnId";
            // 
            // colDepartmentOfficeNames
            // 
            this.colDepartmentOfficeNames.FieldName = "DepartmentOfficeNames";
            this.colDepartmentOfficeNames.Name = "colDepartmentOfficeNames";
            this.colDepartmentOfficeNames.Visible = true;
            this.colDepartmentOfficeNames.VisibleIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 479);
            this.Controls.Add(this.dataGridView_EmployeeList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_EmployeeList11);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeList11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingParticipantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trainingInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_EmployeeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageTrainingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTrainingToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageDepartmentToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView_EmployeeList11;
        private System.Windows.Forms.BindingSource trainingParticipantsBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeTrainingToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingParticpantIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn extNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingParticipantsAttendedsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpnIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource trainingInfoBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateConductedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trainingParticipantsAttendedsDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem byEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUSerToolStripMenuItem;
        private DevExpress.XtraGrid.GridControl dataGridView_EmployeeList;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colTrainingParticpantId;
        private DevExpress.XtraGrid.Columns.GridColumn colFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colMiddleName;
        private DevExpress.XtraGrid.Columns.GridColumn colLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colExtName;
        private DevExpress.XtraGrid.Columns.GridColumn colTrainingParticipantsAttendeds;
        private DevExpress.XtraGrid.Columns.GridColumn colDpnId;
        private DevExpress.XtraGrid.Columns.GridColumn colDepartmentOfficeNames;
    }
}

