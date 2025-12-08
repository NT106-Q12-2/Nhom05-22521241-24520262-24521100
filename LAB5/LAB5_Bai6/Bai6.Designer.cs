namespace LAB5_Bai6
{
    partial class Bai6
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_f5 = new System.Windows.Forms.Button();
            this.btn_sendmail = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nUD_smtp = new System.Windows.Forms.NumericUpDown();
            this.nUD_iamp = new System.Windows.Forms.NumericUpDown();
            this.tb_smtp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_iamp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_smtp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_iamp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_logout);
            this.groupBox1.Controls.Add(this.btn_f5);
            this.groupBox1.Controls.Add(this.btn_sendmail);
            this.groupBox1.Controls.Add(this.btn_login);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.tb_email);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 148);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập";
            // 
            // btn_logout
            // 
            this.btn_logout.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_logout.Location = new System.Drawing.Point(336, 108);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(133, 34);
            this.btn_logout.TabIndex = 25;
            this.btn_logout.Text = "Đăng xuất";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_f5
            // 
            this.btn_f5.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_f5.Location = new System.Drawing.Point(172, 108);
            this.btn_f5.Name = "btn_f5";
            this.btn_f5.Size = new System.Drawing.Size(133, 34);
            this.btn_f5.TabIndex = 24;
            this.btn_f5.Text = "Refresh";
            this.btn_f5.UseVisualStyleBackColor = true;
            this.btn_f5.Click += new System.EventHandler(this.btn_f5_Click);
            // 
            // btn_sendmail
            // 
            this.btn_sendmail.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btn_sendmail.Location = new System.Drawing.Point(11, 108);
            this.btn_sendmail.Name = "btn_sendmail";
            this.btn_sendmail.Size = new System.Drawing.Size(133, 34);
            this.btn_sendmail.TabIndex = 23;
            this.btn_sendmail.Text = "Gửi mail";
            this.btn_sendmail.UseVisualStyleBackColor = true;
            this.btn_sendmail.Click += new System.EventHandler(this.btn_sendmail_Click);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(336, 36);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(142, 65);
            this.btn_login.TabIndex = 22;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(92, 80);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(240, 23);
            this.tb_password.TabIndex = 21;
            this.tb_password.Text = "jppk yeoi wdov yecl";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(92, 33);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(240, 23);
            this.tb_email.TabIndex = 20;
            this.tb_email.Text = "han820400@gmail.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Email:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nUD_smtp);
            this.groupBox2.Controls.Add(this.nUD_iamp);
            this.groupBox2.Controls.Add(this.tb_smtp);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tb_iamp);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(501, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 148);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cài đặt";
            // 
            // nUD_smtp
            // 
            this.nUD_smtp.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nUD_smtp.Location = new System.Drawing.Point(384, 83);
            this.nUD_smtp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUD_smtp.Name = "nUD_smtp";
            this.nUD_smtp.Size = new System.Drawing.Size(201, 23);
            this.nUD_smtp.TabIndex = 32;
            this.nUD_smtp.Value = new decimal(new int[] {
            465,
            0,
            0,
            0});
            // 
            // nUD_iamp
            // 
            this.nUD_iamp.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.nUD_iamp.Location = new System.Drawing.Point(64, 84);
            this.nUD_iamp.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUD_iamp.Name = "nUD_iamp";
            this.nUD_iamp.Size = new System.Drawing.Size(201, 23);
            this.nUD_iamp.TabIndex = 31;
            this.nUD_iamp.Value = new decimal(new int[] {
            993,
            0,
            0,
            0});
            // 
            // tb_smtp
            // 
            this.tb_smtp.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_smtp.Location = new System.Drawing.Point(384, 36);
            this.tb_smtp.Margin = new System.Windows.Forms.Padding(2);
            this.tb_smtp.Name = "tb_smtp";
            this.tb_smtp.Size = new System.Drawing.Size(201, 23);
            this.tb_smtp.TabIndex = 29;
            this.tb_smtp.Text = "smtp.gmail.com";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(326, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "SMTP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 83);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 28;
            this.label6.Text = "Port";
            // 
            // tb_iamp
            // 
            this.tb_iamp.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_iamp.Location = new System.Drawing.Point(64, 36);
            this.tb_iamp.Margin = new System.Windows.Forms.Padding(2);
            this.tb_iamp.Name = "tb_iamp";
            this.tb_iamp.Size = new System.Drawing.Size(201, 23);
            this.tb_iamp.TabIndex = 25;
            this.tb_iamp.Text = "imap.gmail.com";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "IAMP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Port";
            // 
            // listView
            // 
            this.listView.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(12, 165);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1116, 460);
            this.listView.TabIndex = 16;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 636);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Bai6";
            this.Text = "BAI 6";
            this.Load += new System.EventHandler(this.Bai6_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_smtp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_iamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_smtp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_iamp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button btn_f5;
        private System.Windows.Forms.Button btn_sendmail;
        private System.Windows.Forms.NumericUpDown nUD_smtp;
        private System.Windows.Forms.NumericUpDown nUD_iamp;
        private System.Windows.Forms.Button btn_logout;
    }
}

