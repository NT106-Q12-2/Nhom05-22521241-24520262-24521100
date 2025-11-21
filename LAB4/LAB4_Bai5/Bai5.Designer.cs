namespace LAB4_Bai5
{
    partial class Bai5
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
            txtb_url = new TextBox();
            txtb_username = new TextBox();
            txtb_password = new TextBox();
            btn_login = new Button();
            rtb_content = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtb_url
            // 
            txtb_url.Font = new Font("Cascadia Code", 10.8F);
            txtb_url.ForeColor = Color.FromArgb(64, 0, 0);
            txtb_url.Location = new Point(143, 12);
            txtb_url.Name = "txtb_url";
            txtb_url.Size = new Size(499, 28);
            txtb_url.TabIndex = 0;
            // 
            // txtb_username
            // 
            txtb_username.Font = new Font("Cascadia Code", 10.8F);
            txtb_username.ForeColor = Color.FromArgb(64, 0, 0);
            txtb_username.Location = new Point(143, 76);
            txtb_username.Name = "txtb_username";
            txtb_username.Size = new Size(289, 28);
            txtb_username.TabIndex = 1;
            // 
            // txtb_password
            // 
            txtb_password.Font = new Font("Cascadia Code", 10.8F);
            txtb_password.ForeColor = Color.FromArgb(64, 0, 0);
            txtb_password.Location = new Point(143, 135);
            txtb_password.Name = "txtb_password";
            txtb_password.Size = new Size(289, 28);
            txtb_password.TabIndex = 2;
            // 
            // btn_login
            // 
            btn_login.Font = new Font("Cascadia Code", 10.8F);
            btn_login.ForeColor = Color.FromArgb(64, 0, 0);
            btn_login.Location = new Point(465, 76);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(177, 86);
            btn_login.TabIndex = 3;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // rtb_content
            // 
            rtb_content.Font = new Font("Cascadia Code", 10.8F);
            rtb_content.ForeColor = Color.FromArgb(64, 0, 0);
            rtb_content.Location = new Point(41, 178);
            rtb_content.Name = "rtb_content";
            rtb_content.Size = new Size(601, 242);
            rtb_content.TabIndex = 4;
            rtb_content.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 10.8F);
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(41, 15);
            label1.Name = "label1";
            label1.Size = new Size(43, 24);
            label1.TabIndex = 5;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 10.8F);
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(41, 79);
            label2.Name = "label2";
            label2.Size = new Size(98, 24);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 10.8F);
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(41, 138);
            label3.Name = "label3";
            label3.Size = new Size(98, 24);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(698, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtb_content);
            Controls.Add(btn_login);
            Controls.Add(txtb_password);
            Controls.Add(txtb_username);
            Controls.Add(txtb_url);
            Name = "Bai5";
            Text = "BAI5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtb_url;
        private TextBox txtb_username;
        private TextBox txtb_password;
        private Button btn_login;
        private RichTextBox rtb_content;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
