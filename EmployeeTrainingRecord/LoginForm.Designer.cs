namespace EmployeeTrainingRecord
{
    partial class LoginForm
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
            this.tb_UserPassword = new System.Windows.Forms.TextBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_Username
            // 
            this.tb_Username.Location = new System.Drawing.Point(191, 49);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(5);
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.PasswordChar = '*';
            this.tb_Username.Size = new System.Drawing.Size(233, 27);
            this.tb_Username.TabIndex = 0;
            // 
            // tb_UserPassword
            // 
            this.tb_UserPassword.Location = new System.Drawing.Point(191, 104);
            this.tb_UserPassword.Margin = new System.Windows.Forms.Padding(5);
            this.tb_UserPassword.Name = "tb_UserPassword";
            this.tb_UserPassword.PasswordChar = '*';
            this.tb_UserPassword.Size = new System.Drawing.Size(233, 27);
            this.tb_UserPassword.TabIndex = 1;
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(48, 180);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(233, 57);
            this.bt_Login.TabIndex = 2;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login as Clerk";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 304);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.tb_UserPassword);
            this.Controls.Add(this.tb_Username);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_UserPassword;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button button1;
    }
}