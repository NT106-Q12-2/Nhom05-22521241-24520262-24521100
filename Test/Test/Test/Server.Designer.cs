namespace Test
{
    partial class Server
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
            rtb_log = new RichTextBox();
            btn_start = new Button();
            lb_status = new Label();
            lb_entertable = new Label();
            tb_table = new TextBox();
            btn_charge = new Button();
            label1 = new Label();
            tb_amount = new TextBox();
            dgv_thongke = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_thongke).BeginInit();
            SuspendLayout();
            // 
            // rtb_log
            // 
            rtb_log.Font = new Font("Cascadia Code SemiBold", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rtb_log.Location = new Point(43, 439);
            rtb_log.Name = "rtb_log";
            rtb_log.ReadOnly = true;
            rtb_log.Size = new Size(995, 265);
            rtb_log.TabIndex = 0;
            rtb_log.Text = "";
            // 
            // btn_start
            // 
            btn_start.Font = new Font("Cascadia Code SemiBold", 10.125F, FontStyle.Bold);
            btn_start.Location = new Point(43, 29);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(280, 82);
            btn_start.TabIndex = 1;
            btn_start.Text = "START";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // lb_status
            // 
            lb_status.AutoSize = true;
            lb_status.Font = new Font("Cascadia Code SemiBold", 10.125F, FontStyle.Bold);
            lb_status.Location = new Point(401, 53);
            lb_status.Name = "lb_status";
            lb_status.Size = new Size(111, 35);
            lb_status.TabIndex = 2;
            lb_status.Text = "status";
            // 
            // lb_entertable
            // 
            lb_entertable.AutoSize = true;
            lb_entertable.Font = new Font("Cascadia Code SemiBold", 10.125F, FontStyle.Bold);
            lb_entertable.Location = new Point(1131, 133);
            lb_entertable.Name = "lb_entertable";
            lb_entertable.Size = new Size(191, 35);
            lb_entertable.TabIndex = 3;
            lb_entertable.Text = "Enter table";
            // 
            // tb_table
            // 
            tb_table.Font = new Font("Cascadia Code SemiBold", 10.125F, FontStyle.Bold);
            tb_table.Location = new Point(1131, 178);
            tb_table.Name = "tb_table";
            tb_table.Size = new Size(200, 39);
            tb_table.TabIndex = 4;
            // 
            // btn_charge
            // 
            btn_charge.Font = new Font("Cascadia Code SemiBold", 10.125F, FontStyle.Bold);
            btn_charge.Location = new Point(1131, 251);
            btn_charge.Name = "btn_charge";
            btn_charge.Size = new Size(200, 51);
            btn_charge.TabIndex = 5;
            btn_charge.Text = "CHARGE";
            btn_charge.UseVisualStyleBackColor = true;
            btn_charge.Click += btn_charge_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code SemiBold", 10.125F, FontStyle.Bold);
            label1.Location = new Point(1131, 335);
            label1.Name = "label1";
            label1.Size = new Size(111, 35);
            label1.TabIndex = 6;
            label1.Text = "Amount";
            // 
            // tb_amount
            // 
            tb_amount.Font = new Font("Cascadia Code SemiBold", 10.125F, FontStyle.Bold);
            tb_amount.Location = new Point(1131, 370);
            tb_amount.Name = "tb_amount";
            tb_amount.Size = new Size(200, 39);
            tb_amount.TabIndex = 7;
            // 
            // dgv_thongke
            // 
            dgv_thongke.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_thongke.Location = new Point(43, 133);
            dgv_thongke.Name = "dgv_thongke";
            dgv_thongke.RowHeadersWidth = 82;
            dgv_thongke.Size = new Size(995, 300);
            dgv_thongke.TabIndex = 8;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1402, 740);
            Controls.Add(dgv_thongke);
            Controls.Add(tb_amount);
            Controls.Add(label1);
            Controls.Add(btn_charge);
            Controls.Add(tb_table);
            Controls.Add(lb_entertable);
            Controls.Add(lb_status);
            Controls.Add(btn_start);
            Controls.Add(rtb_log);
            Name = "Server";
            Text = "Server";
            Load += Server_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_thongke).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_log;
        private Button btn_start;
        private Label lb_status;
        private Label lb_entertable;
        private TextBox tb_table;
        private Button btn_charge;
        private Label label1;
        private TextBox tb_amount;
        private DataGridView dgv_thongke;
    }
}