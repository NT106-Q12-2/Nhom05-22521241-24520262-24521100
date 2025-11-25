namespace LAB4_Bai6
{
    partial class Bai6
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            btn_login = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            txtb_url = new TextBox();
            lblResult = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 10.8F);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(127, 103);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10.8F);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(127, 58);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 14;
            label2.Text = "Username";
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Cascadia Code", 10.8F);
            btn_login.ForeColor = Color.FromArgb(64, 0, 0);
            btn_login.Location = new Point(498, 56);
            btn_login.Margin = new Padding(3, 2, 3, 2);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(155, 64);
            btn_login.TabIndex = 11;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Cascadia Code", 10.8F);
            txtPassword.ForeColor = Color.FromArgb(64, 0, 0);
            txtPassword.Location = new Point(216, 100);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(253, 24);
            txtPassword.TabIndex = 10;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Cascadia Code", 10.8F);
            txtUsername.ForeColor = Color.FromArgb(64, 0, 0);
            txtUsername.Location = new Point(216, 56);
            txtUsername.Margin = new Padding(3, 2, 3, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(253, 24);
            txtUsername.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10.8F);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(127, 10);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 13;
            label1.Text = "URL";
            // 
            // txtb_url
            // 
            txtb_url.Font = new Font("Cascadia Code", 10.8F);
            txtb_url.ForeColor = Color.FromArgb(64, 0, 0);
            txtb_url.Location = new Point(216, 8);
            txtb_url.Margin = new Padding(3, 2, 3, 2);
            txtb_url.Name = "txtb_url";
            txtb_url.Size = new Size(437, 24);
            txtb_url.TabIndex = 8;
            txtb_url.Text = "https://nt106.uitiot.vn/api/v1/user/me";
            // 
            // lblResult
            // 
            lblResult.Font = new Font("Cascadia Code", 10.8F);
            lblResult.ForeColor = Color.FromArgb(64, 0, 0);
            lblResult.Location = new Point(127, 126);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(526, 291);
            lblResult.TabIndex = 16;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtb_url);
            Name = "Bai6";
            Text = "Form1";
            Load += Bai6_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Button btn_login;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label1;
        private TextBox txtb_url;
        private Label lblResult;
    }
}
