namespace LAB5_Bai2
{
    partial class Bai2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(97, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(392, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Recent :";
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(955, 48);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(286, 130);
            this.btn_login.TabIndex = 6;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(103, 343);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1138, 312);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(398, 48);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(454, 39);
            this.tb_email.TabIndex = 8;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(398, 139);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(454, 39);
            this.tb_password.TabIndex = 9;
            // 
            // Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1431, 715);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Bai2";
            this.Text = "BAI 2";
            this.Load += new System.EventHandler(this.Bai2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
    }
}

