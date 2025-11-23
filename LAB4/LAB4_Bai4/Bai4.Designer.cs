namespace LAB4_Bai4
{
    partial class Bai4
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
            Pb_process = new ProgressBar();
            label1 = new Label();
            fLP_main = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // Pb_process
            // 
            Pb_process.Location = new Point(14, 573);
            Pb_process.Margin = new Padding(5, 6, 5, 6);
            Pb_process.Name = "Pb_process";
            Pb_process.Size = new Size(1169, 43);
            Pb_process.TabIndex = 0;
            Pb_process.Click += Pb_process_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 28);
            label1.TabIndex = 2;
            label1.Text = "Phim đang chiếu";
            // 
            // fLP_main
            // 
            fLP_main.AutoScroll = true;
            fLP_main.Location = new Point(14, 43);
            fLP_main.Name = "fLP_main";
            fLP_main.Size = new Size(1171, 521);
            fLP_main.TabIndex = 3;
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1197, 631);
            Controls.Add(label1);
            Controls.Add(Pb_process);
            Controls.Add(fLP_main);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Bai4";
            Text = "Bai4";
            Load += Bai4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar Pb_process;
        private Label label1;
        private FlowLayoutPanel fLP_main;
    }
}
