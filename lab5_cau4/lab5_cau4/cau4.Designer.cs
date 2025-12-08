namespace lab5_cau4
{
    partial class Form1
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
            this.grpMovieInfo = new System.Windows.Forms.GroupBox();
            this.btnSelectPoster = new System.Windows.Forms.Button();
            this.picPoster = new System.Windows.Forms.PictureBox();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.grpTicketInfo = new System.Windows.Forms.GroupBox();
            this.txtSlogan = new System.Windows.Forms.TextBox();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.numSeatNumber = new System.Windows.Forms.NumericUpDown();
            this.lblSeatNumber = new System.Windows.Forms.Label();
            this.btnBookTicket = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpMovieInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).BeginInit();
            this.grpCustomerInfo.SuspendLayout();
            this.grpTicketInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMovieInfo
            // 
            this.grpMovieInfo.Controls.Add(this.btnSelectPoster);
            this.grpMovieInfo.Controls.Add(this.picPoster);
            this.grpMovieInfo.Controls.Add(this.txtMovieName);
            this.grpMovieInfo.Controls.Add(this.lblMovieName);
            this.grpMovieInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpMovieInfo.Location = new System.Drawing.Point(20, 20);
            this.grpMovieInfo.Name = "grpMovieInfo";
            this.grpMovieInfo.Size = new System.Drawing.Size(350, 320);
            this.grpMovieInfo.TabIndex = 0;
            this.grpMovieInfo.TabStop = false;
            this.grpMovieInfo.Text = "Thông tin phim";
            // 
            // btnSelectPoster
            // 
            this.btnSelectPoster.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSelectPoster.Location = new System.Drawing.Point(20, 270);
            this.btnSelectPoster.Name = "btnSelectPoster";
            this.btnSelectPoster.Size = new System.Drawing.Size(310, 35);
            this.btnSelectPoster.TabIndex = 3;
            this.btnSelectPoster.Text = "Chọn Poster";
            this.btnSelectPoster.UseVisualStyleBackColor = true;
            this.btnSelectPoster.Click += new System.EventHandler(this.btnSelectPoster_Click);
            // 
            // picPoster
            // 
            this.picPoster.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPoster.Location = new System.Drawing.Point(20, 90);
            this.picPoster.Name = "picPoster";
            this.picPoster.Size = new System.Drawing.Size(310, 170);
            this.picPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPoster.TabIndex = 2;
            this.picPoster.TabStop = false;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMovieName.Location = new System.Drawing.Point(20, 55);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(310, 27);
            this.txtMovieName.TabIndex = 1;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMovieName.Location = new System.Drawing.Point(20, 30);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(74, 20);
            this.lblMovieName.TabIndex = 0;
            this.lblMovieName.Text = "Tên phim:";
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.txtEmail);
            this.grpCustomerInfo.Controls.Add(this.lblEmail);
            this.grpCustomerInfo.Controls.Add(this.txtCustomerName);
            this.grpCustomerInfo.Controls.Add(this.lblCustomerName);
            this.grpCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpCustomerInfo.Location = new System.Drawing.Point(390, 20);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(380, 150);
            this.grpCustomerInfo.TabIndex = 1;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Thông tin khách hàng";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(20, 105);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 27);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmail.Location = new System.Drawing.Point(20, 80);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(49, 20);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCustomerName.Location = new System.Drawing.Point(20, 50);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(340, 27);
            this.txtCustomerName.TabIndex = 1;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCustomerName.Location = new System.Drawing.Point(20, 25);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(61, 20);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Họ tên:";
            // 
            // grpTicketInfo
            // 
            this.grpTicketInfo.Controls.Add(this.txtSlogan);
            this.grpTicketInfo.Controls.Add(this.lblSlogan);
            this.grpTicketInfo.Controls.Add(this.numSeatNumber);
            this.grpTicketInfo.Controls.Add(this.lblSeatNumber);
            this.grpTicketInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpTicketInfo.Location = new System.Drawing.Point(390, 190);
            this.grpTicketInfo.Name = "grpTicketInfo";
            this.grpTicketInfo.Size = new System.Drawing.Size(380, 150);
            this.grpTicketInfo.TabIndex = 2;
            this.grpTicketInfo.TabStop = false;
            this.grpTicketInfo.Text = "Thông tin vé";
            // 
            // txtSlogan
            // 
            this.txtSlogan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSlogan.Location = new System.Drawing.Point(20, 105);
            this.txtSlogan.Name = "txtSlogan";
            this.txtSlogan.Size = new System.Drawing.Size(340, 27);
            this.txtSlogan.TabIndex = 3;
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSlogan.Location = new System.Drawing.Point(20, 80);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(125, 20);
            this.lblSlogan.TabIndex = 2;
            this.lblSlogan.Text = "Slogan/Câu chúc:";
            // 
            // numSeatNumber
            // 
            this.numSeatNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numSeatNumber.Location = new System.Drawing.Point(20, 50);
            this.numSeatNumber.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSeatNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSeatNumber.Name = "numSeatNumber";
            this.numSeatNumber.Size = new System.Drawing.Size(150, 27);
            this.numSeatNumber.TabIndex = 1;
            this.numSeatNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblSeatNumber
            // 
            this.lblSeatNumber.AutoSize = true;
            this.lblSeatNumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSeatNumber.Location = new System.Drawing.Point(20, 25);
            this.lblSeatNumber.Name = "lblSeatNumber";
            this.lblSeatNumber.Size = new System.Drawing.Size(60, 20);
            this.lblSeatNumber.TabIndex = 0;
            this.lblSeatNumber.Text = "Số ghế:";
            // 
            // btnBookTicket
            // 
            this.btnBookTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btnBookTicket.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnBookTicket.ForeColor = System.Drawing.Color.White;
            this.btnBookTicket.Location = new System.Drawing.Point(390, 360);
            this.btnBookTicket.Name = "btnBookTicket";
            this.btnBookTicket.Size = new System.Drawing.Size(180, 45);
            this.btnBookTicket.TabIndex = 3;
            this.btnBookTicket.Text = "Đặt vé";
            this.btnBookTicket.UseVisualStyleBackColor = false;
            this.btnBookTicket.Click += new System.EventHandler(this.btnBookTicket_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(117)))), ((int)(((byte)(125)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(590, 360);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(180, 45);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 430);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBookTicket);
            this.Controls.Add(this.grpTicketInfo);
            this.Controls.Add(this.grpCustomerInfo);
            this.Controls.Add(this.grpMovieInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống quản lý phòng vé";
            this.grpMovieInfo.ResumeLayout(false);
            this.grpMovieInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPoster)).EndInit();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpTicketInfo.ResumeLayout(false);
            this.grpTicketInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSeatNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpMovieInfo;
        private System.Windows.Forms.Button btnSelectPoster;
        private System.Windows.Forms.PictureBox picPoster;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.GroupBox grpTicketInfo;
        private System.Windows.Forms.TextBox txtSlogan;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.NumericUpDown numSeatNumber;
        private System.Windows.Forms.Label lblSeatNumber;
        private System.Windows.Forms.Button btnBookTicket;
        private System.Windows.Forms.Button btnReset;
    }
}
