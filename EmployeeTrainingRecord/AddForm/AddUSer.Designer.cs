namespace EmployeeTrainingRecord.AddForm
{
    partial class AddUSer
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
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.bt_SaveUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(178, 56);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(188, 27);
            this.tb_Username.TabIndex = 0;
            // 
            // tb_Password
            // 
            this.tb_Password.Location = new System.Drawing.Point(178, 110);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.Size = new System.Drawing.Size(188, 27);
            this.tb_Password.TabIndex = 1;
            // 
            // bt_SaveUser
            // 
            this.bt_SaveUser.Location = new System.Drawing.Point(109, 197);
            this.bt_SaveUser.Name = "bt_SaveUser";
            this.bt_SaveUser.Size = new System.Drawing.Size(143, 55);
            this.bt_SaveUser.TabIndex = 2;
            this.bt_SaveUser.Text = "Save";
            this.bt_SaveUser.UseVisualStyleBackColor = true;
            this.bt_SaveUser.Click += new System.EventHandler(this.bt_SaveUser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // AddUSer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 379);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_SaveUser);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AddUSer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddUSer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button bt_SaveUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}