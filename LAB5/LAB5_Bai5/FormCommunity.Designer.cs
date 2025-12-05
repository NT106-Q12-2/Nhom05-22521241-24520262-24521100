namespace LAB5_Bai5
{
    partial class FormCommunity
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
            this.ptb_hinhanhmonan = new System.Windows.Forms.PictureBox();
            this.rtb_thongtinmonan = new System.Windows.Forms.RichTextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_duongdanhinhanh = new System.Windows.Forms.TextBox();
            this.tb_monan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptb_hinhanhdonggop = new System.Windows.Forms.PictureBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_donggop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hinhanhmonan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hinhanhdonggop)).BeginInit();
            this.SuspendLayout();
            // 
            // ptb_hinhanhmonan
            // 
            this.ptb_hinhanhmonan.Location = new System.Drawing.Point(811, 588);
            this.ptb_hinhanhmonan.Name = "ptb_hinhanhmonan";
            this.ptb_hinhanhmonan.Size = new System.Drawing.Size(544, 299);
            this.ptb_hinhanhmonan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_hinhanhmonan.TabIndex = 64;
            this.ptb_hinhanhmonan.TabStop = false;
            // 
            // rtb_thongtinmonan
            // 
            this.rtb_thongtinmonan.Location = new System.Drawing.Point(74, 708);
            this.rtb_thongtinmonan.Name = "rtb_thongtinmonan";
            this.rtb_thongtinmonan.Size = new System.Drawing.Size(722, 179);
            this.rtb_thongtinmonan.TabIndex = 63;
            this.rtb_thongtinmonan.Text = "";
            // 
            // btn_browse
            // 
            this.btn_browse.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_browse.Location = new System.Drawing.Point(662, 373);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(77, 42);
            this.btn_browse.TabIndex = 62;
            this.btn_browse.Text = "...";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(262, 119);
            this.tb_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_password.Name = "tb_password";
            this.tb_password.ReadOnly = true;
            this.tb_password.Size = new System.Drawing.Size(451, 41);
            this.tb_password.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 39);
            this.label4.TabIndex = 60;
            this.label4.Text = "Password :";
            // 
            // tb_duongdanhinhanh
            // 
            this.tb_duongdanhinhanh.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_duongdanhinhanh.Location = new System.Drawing.Point(321, 373);
            this.tb_duongdanhinhanh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_duongdanhinhanh.Name = "tb_duongdanhinhanh";
            this.tb_duongdanhinhanh.Size = new System.Drawing.Size(334, 41);
            this.tb_duongdanhinhanh.TabIndex = 59;
            // 
            // tb_monan
            // 
            this.tb_monan.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_monan.Location = new System.Drawing.Point(321, 286);
            this.tb_monan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_monan.Name = "tb_monan";
            this.tb_monan.Size = new System.Drawing.Size(418, 41);
            this.tb_monan.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 376);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 39);
            this.label3.TabIndex = 57;
            this.label3.Text = "Hình ảnh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 39);
            this.label2.TabIndex = 56;
            this.label2.Text = "Tên món ăn :";
            // 
            // ptb_hinhanhdonggop
            // 
            this.ptb_hinhanhdonggop.Location = new System.Drawing.Point(769, 76);
            this.ptb_hinhanhdonggop.Name = "ptb_hinhanhdonggop";
            this.ptb_hinhanhdonggop.Size = new System.Drawing.Size(586, 428);
            this.ptb_hinhanhdonggop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_hinhanhdonggop.TabIndex = 55;
            this.ptb_hinhanhdonggop.TabStop = false;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(211, 76);
            this.tb_email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_email.Name = "tb_email";
            this.tb_email.ReadOnly = true;
            this.tb_email.Size = new System.Drawing.Size(502, 41);
            this.tb_email.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 39);
            this.label1.TabIndex = 53;
            this.label1.Text = "Email :";
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(74, 609);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(322, 71);
            this.btn_timkiem.TabIndex = 52;
            this.btn_timkiem.Text = "Tìm kiếm món ăn";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_donggop
            // 
            this.btn_donggop.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_donggop.Location = new System.Drawing.Point(321, 443);
            this.btn_donggop.Name = "btn_donggop";
            this.btn_donggop.Size = new System.Drawing.Size(310, 73);
            this.btn_donggop.TabIndex = 51;
            this.btn_donggop.Text = "Đóng góp món ăn";
            this.btn_donggop.UseVisualStyleBackColor = true;
            this.btn_donggop.Click += new System.EventHandler(this.btn_donggop_Click);
            // 
            // FormCommunity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 962);
            this.Controls.Add(this.ptb_hinhanhmonan);
            this.Controls.Add(this.rtb_thongtinmonan);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_duongdanhinhanh);
            this.Controls.Add(this.tb_monan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ptb_hinhanhdonggop);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.btn_donggop);
            this.Name = "FormCommunity";
            this.Text = "COMMUNITY";
            this.Load += new System.EventHandler(this.FormCommunity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hinhanhmonan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_hinhanhdonggop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptb_hinhanhmonan;
        private System.Windows.Forms.RichTextBox rtb_thongtinmonan;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_duongdanhinhanh;
        private System.Windows.Forms.TextBox tb_monan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptb_hinhanhdonggop;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_donggop;
    }
}