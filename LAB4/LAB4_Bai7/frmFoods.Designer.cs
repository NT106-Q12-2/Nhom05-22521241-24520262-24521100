namespace LAB4_Bai7
{
    partial class frmFoods
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvFoods = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCreatedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRandomMy = new System.Windows.Forms.Button();
            this.btnRandomAll = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnLoadMy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoadAll = new System.Windows.Forms.Button();
            this.txtFoodName = new System.Windows.Forms.TextBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFoods
            // 
            this.dgvFoods.AllowUserToAddRows = false;
            this.dgvFoods.AllowUserToDeleteRows = false;
            this.dgvFoods.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoods.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colName,
            this.colUsername,
            this.colCreatedAt,
            this.colDelete});
            this.dgvFoods.Location = new System.Drawing.Point(156, 125);
            this.dgvFoods.Name = "dgvFoods";
            this.dgvFoods.ReadOnly = true;
            this.dgvFoods.RowHeadersVisible = false;
            this.dgvFoods.Size = new System.Drawing.Size(503, 198);
            this.dgvFoods.TabIndex = 45;
            this.dgvFoods.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFoods_CellClick);
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            this.colSTT.ReadOnly = true;
            this.colSTT.Width = 50;
            // 
            // colName
            // 
            this.colName.HeaderText = "Tên món ăn";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 180;
            // 
            // colUsername
            // 
            this.colUsername.HeaderText = "Người tạo";
            this.colUsername.Name = "colUsername";
            this.colUsername.ReadOnly = true;
            this.colUsername.Width = 120;
            // 
            // colCreatedAt
            // 
            this.colCreatedAt.HeaderText = "Ngày tạo";
            this.colCreatedAt.Name = "colCreatedAt";
            this.colCreatedAt.ReadOnly = true;
            this.colCreatedAt.Width = 100;
            // 
            // colDelete
            // 
            this.colDelete.HeaderText = "";
            this.colDelete.Name = "colDelete";
            this.colDelete.ReadOnly = true;
            this.colDelete.Width = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(322, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 27);
            this.label5.TabIndex = 39;
            this.label5.Text = "HÔM NAY ĂN GÌ ?";
            // 
            // btnRandomMy
            // 
            this.btnRandomMy.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.btnRandomMy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRandomMy.Location = new System.Drawing.Point(480, 391);
            this.btnRandomMy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandomMy.Name = "btnRandomMy";
            this.btnRandomMy.Size = new System.Drawing.Size(142, 36);
            this.btnRandomMy.TabIndex = 38;
            this.btnRandomMy.Text = "Gợi ý của tôi";
            this.btnRandomMy.UseVisualStyleBackColor = true;
            this.btnRandomMy.Click += new System.EventHandler(this.btnRandomMy_Click);
            // 
            // btnRandomAll
            // 
            this.btnRandomAll.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.btnRandomAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRandomAll.Location = new System.Drawing.Point(229, 391);
            this.btnRandomAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRandomAll.Name = "btnRandomAll";
            this.btnRandomAll.Size = new System.Drawing.Size(133, 36);
            this.btnRandomAll.TabIndex = 37;
            this.btnRandomAll.Text = "Gợi ý tất cả";
            this.btnRandomAll.UseVisualStyleBackColor = true;
            this.btnRandomAll.Click += new System.EventHandler(this.btnRandomAll_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.btnNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNext.Location = new System.Drawing.Point(525, 337);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(119, 24);
            this.btnNext.TabIndex = 36;
            this.btnNext.Text = "Trang sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.btnPrev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPrev.Location = new System.Drawing.Point(377, 337);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(119, 24);
            this.btnPrev.TabIndex = 35;
            this.btnPrev.Text = "Trang trước";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdd.Location = new System.Drawing.Point(559, 95);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 24);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnLoadMy
            // 
            this.btnLoadMy.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.btnLoadMy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoadMy.Location = new System.Drawing.Point(293, 59);
            this.btnLoadMy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadMy.Name = "btnLoadMy";
            this.btnLoadMy.Size = new System.Drawing.Size(119, 24);
            this.btnLoadMy.TabIndex = 33;
            this.btnLoadMy.Text = "Xem của tôi";
            this.btnLoadMy.UseVisualStyleBackColor = true;
            this.btnLoadMy.Click += new System.EventHandler(this.btnLoadMy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(156, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Tên món ăn";
            // 
            // btnLoadAll
            // 
            this.btnLoadAll.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.btnLoadAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLoadAll.Location = new System.Drawing.Point(156, 59);
            this.btnLoadAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoadAll.Name = "btnLoadAll";
            this.btnLoadAll.Size = new System.Drawing.Size(119, 24);
            this.btnLoadAll.TabIndex = 31;
            this.btnLoadAll.Text = "Xem tất cả";
            this.btnLoadAll.UseVisualStyleBackColor = true;
            this.btnLoadAll.Click += new System.EventHandler(this.btnLoadAll_Click);
            // 
            // txtFoodName
            // 
            this.txtFoodName.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.txtFoodName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtFoodName.Location = new System.Drawing.Point(261, 96);
            this.txtFoodName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFoodName.Name = "txtFoodName";
            this.txtFoodName.Size = new System.Drawing.Size(253, 24);
            this.txtFoodName.TabIndex = 30;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblWelcome.Location = new System.Drawing.Point(435, 59);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 20);
            this.lblWelcome.TabIndex = 41;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.Location = new System.Drawing.Point(672, 28);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(114, 24);
            this.btnLogout.TabIndex = 42;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(165, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Trang :";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Cascadia Code", 10.8F);
            this.lblPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPage.Location = new System.Drawing.Point(243, 341);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(63, 20);
            this.lblPage.TabIndex = 44;
            this.lblPage.Text = "Trang 1";
            // 
            // frmFoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRandomMy);
            this.Controls.Add(this.btnRandomAll);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnLoadMy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLoadAll);
            this.Controls.Add(this.txtFoodName);
            this.Controls.Add(this.dgvFoods);
            this.Name = "frmFoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hôm nay ăn gì? - NT106 Lab 4";
            this.Load += new System.EventHandler(this.frmFoods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoods)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFoods;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCreatedAt;
        private System.Windows.Forms.DataGridViewButtonColumn colDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRandomMy;
        private System.Windows.Forms.Button btnRandomAll;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnLoadMy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadAll;
        private System.Windows.Forms.TextBox txtFoodName;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPage;
    }
}
