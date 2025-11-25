namespace LAB4_Bai7
{
    partial class frmLogin
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
            btnRegister = new Button();
            label3 = new Label();
            txtResult = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Cascadia Code", 10.8F);
            btnRegister.ForeColor = Color.FromArgb(64, 0, 0);
            btnRegister.Location = new Point(508, 189);
            btnRegister.Margin = new Padding(3, 2, 3, 2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(155, 24);
            btnRegister.TabIndex = 47;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 10.8F);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(137, 235);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 46;
            label3.Text = "Kết quả";
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Cascadia Code", 10.8F);
            txtResult.ForeColor = Color.FromArgb(64, 0, 0);
            txtResult.Location = new Point(137, 270);
            txtResult.Margin = new Padding(3, 2, 3, 2);
            txtResult.Name = "txtResult";
            txtResult.ReadOnly = true;
            txtResult.Size = new Size(436, 24);
            txtResult.TabIndex = 45;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 10.8F);
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(137, 189);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 44;
            label7.Text = "Password";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 10.8F);
            label8.ForeColor = Color.FromArgb(64, 0, 0);
            label8.Location = new Point(137, 144);
            label8.Name = "label8";
            label8.Size = new Size(81, 20);
            label8.TabIndex = 43;
            label8.Text = "Username";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Cascadia Code", 10.8F);
            btnLogin.ForeColor = Color.FromArgb(64, 0, 0);
            btnLogin.Location = new Point(508, 144);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(155, 24);
            btnLogin.TabIndex = 42;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Cascadia Code", 10.8F);
            txtPassword.ForeColor = Color.FromArgb(64, 0, 0);
            txtPassword.Location = new Point(226, 186);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(253, 24);
            txtPassword.TabIndex = 41;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Cascadia Code", 10.8F);
            txtUsername.ForeColor = Color.FromArgb(64, 0, 0);
            txtUsername.Location = new Point(226, 142);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(253, 24);
            txtUsername.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 15F);
            label5.ForeColor = Color.FromArgb(64, 0, 0);
            label5.Location = new Point(287, 61);
            label5.Name = "label5";
            label5.Size = new Size(192, 27);
            label5.TabIndex = 48;
            label5.Text = "HÔM NAY ĂN GÌ ?";
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(txtResult);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRegister;
        private Label label3;
        private TextBox txtResult;
        private Label label7;
        private Label label8;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label5;
    }
}