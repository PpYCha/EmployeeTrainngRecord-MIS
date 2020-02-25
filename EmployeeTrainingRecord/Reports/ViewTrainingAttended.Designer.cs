namespace EmployeeTrainingRecord.Reports
{
    partial class ViewTrainingAttended
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
            this.dataGridView_LoadTrainings = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_EName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_MName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.tb_Department = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoadTrainings)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_LoadTrainings
            // 
            this.dataGridView_LoadTrainings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_LoadTrainings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_LoadTrainings.Location = new System.Drawing.Point(34, 237);
            this.dataGridView_LoadTrainings.Name = "dataGridView_LoadTrainings";
            this.dataGridView_LoadTrainings.Size = new System.Drawing.Size(965, 233);
            this.dataGridView_LoadTrainings.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Department:";
            // 
            // textBox_EName
            // 
            this.textBox_EName.Location = new System.Drawing.Point(301, 177);
            this.textBox_EName.Name = "textBox_EName";
            this.textBox_EName.Size = new System.Drawing.Size(268, 27);
            this.textBox_EName.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Extension Name:";
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(301, 144);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(268, 27);
            this.textBox_LastName.TabIndex = 19;
            // 
            // textBox_MName
            // 
            this.textBox_MName.Location = new System.Drawing.Point(301, 111);
            this.textBox_MName.Name = "textBox_MName";
            this.textBox_MName.Size = new System.Drawing.Size(268, 27);
            this.textBox_MName.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Middle Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "First Name:";
            // 
            // textBox_FName
            // 
            this.textBox_FName.Location = new System.Drawing.Point(301, 78);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.Size = new System.Drawing.Size(268, 27);
            this.textBox_FName.TabIndex = 14;
            // 
            // tb_Department
            // 
            this.tb_Department.Location = new System.Drawing.Point(301, 27);
            this.tb_Department.Name = "tb_Department";
            this.tb_Department.Size = new System.Drawing.Size(268, 27);
            this.tb_Department.TabIndex = 23;
            // 
            // ViewTrainingAttended
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 507);
            this.Controls.Add(this.tb_Department);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_EName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_MName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_FName);
            this.Controls.Add(this.dataGridView_LoadTrainings);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ViewTrainingAttended";
            this.Text = "ViewTrainingAttended";
            this.Load += new System.EventHandler(this.ViewTrainingAttended_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_LoadTrainings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_LoadTrainings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_EName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_MName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.TextBox tb_Department;
    }
}