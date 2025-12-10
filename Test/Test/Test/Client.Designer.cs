namespace Test
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
            btn_connect = new Button();
            lb_sv = new Label();
            dataGridView1 = new DataGridView();
            nud_table = new NumericUpDown();
            btn_order = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nud_table).BeginInit();
            SuspendLayout();
            // 
            // btn_connect
            // 
            btn_connect.Location = new Point(97, 64);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(126, 45);
            btn_connect.TabIndex = 0;
            btn_connect.Text = "Connect";
            btn_connect.UseVisualStyleBackColor = true;
            btn_connect.Click += btn_connect_Click;
            // 
            // lb_sv
            // 
            lb_sv.AutoSize = true;
            lb_sv.Location = new Point(313, 74);
            lb_sv.Name = "lb_sv";
            lb_sv.Size = new Size(175, 35);
            lb_sv.TabIndex = 1;
            lb_sv.Text = "Disconnect";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(97, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(700, 231);
            dataGridView1.TabIndex = 2;
            // 
            // nud_table
            // 
            nud_table.Location = new Point(131, 385);
            nud_table.Name = "nud_table";
            nud_table.Size = new Size(120, 39);
            nud_table.TabIndex = 3;
            // 
            // btn_order
            // 
            btn_order.Location = new Point(671, 385);
            btn_order.Name = "btn_order";
            btn_order.Size = new Size(126, 45);
            btn_order.TabIndex = 4;
            btn_order.Text = "Order";
            btn_order.UseVisualStyleBackColor = true;
            btn_order.Click += btn_order_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 510);
            Controls.Add(btn_order);
            Controls.Add(nud_table);
            Controls.Add(dataGridView1);
            Controls.Add(lb_sv);
            Controls.Add(btn_connect);
            Font = new Font("Cascadia Code SemiBold", 10.125F, FontStyle.Bold | FontStyle.Italic);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nud_table).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_connect;
        private Label lb_sv;
        private DataGridView dataGridView1;
        private NumericUpDown nud_table;
        private Button btn_order;
    }
}
