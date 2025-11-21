namespace LAB4
{
    partial class Bai1
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
            btn_get = new Button();
            rtb_content = new RichTextBox();
            SuspendLayout();
            // 
            // txtb_url
            // 
            txtb_url.Font = new Font("Cascadia Code", 10.2F);
            txtb_url.ForeColor = Color.FromArgb(64, 0, 0);
            txtb_url.Location = new Point(12, 12);
            txtb_url.Name = "txtb_url";
            txtb_url.Size = new Size(636, 27);
            txtb_url.TabIndex = 0;
            // 
            // btn_get
            // 
            btn_get.Font = new Font("Cascadia Code", 10.2F);
            btn_get.ForeColor = Color.FromArgb(64, 0, 0);
            btn_get.Location = new Point(654, 12);
            btn_get.Name = "btn_get";
            btn_get.Size = new Size(94, 29);
            btn_get.TabIndex = 1;
            btn_get.Text = "Get";
            btn_get.UseVisualStyleBackColor = true;
            btn_get.Click += btn_get_Click;
            // 
            // rtb_content
            // 
            rtb_content.Font = new Font("Cascadia Code", 10.2F);
            rtb_content.ForeColor = Color.FromArgb(64, 0, 0);
            rtb_content.Location = new Point(12, 45);
            rtb_content.Name = "rtb_content";
            rtb_content.Size = new Size(736, 393);
            rtb_content.TabIndex = 2;
            rtb_content.Text = "";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(762, 450);
            Controls.Add(rtb_content);
            Controls.Add(btn_get);
            Controls.Add(txtb_url);
            Name = "Bai1";
            Text = "BAI1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtb_url;
        private Button btn_get;
        private RichTextBox rtb_content;
    }
}
