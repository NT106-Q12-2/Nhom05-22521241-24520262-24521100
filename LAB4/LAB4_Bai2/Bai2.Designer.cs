namespace LAB4_Bai2
{
    partial class Bai2
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
            rtb_content = new RichTextBox();
            btn_dowload = new Button();
            txtb_url = new TextBox();
            txtb_filepath = new TextBox();
            SuspendLayout();
            // 
            // rtb_content
            // 
            rtb_content.Location = new Point(12, 78);
            rtb_content.Name = "rtb_content";
            rtb_content.Size = new Size(754, 393);
            rtb_content.TabIndex = 5;
            rtb_content.Text = "";
            // 
            // btn_dowload
            // 
            btn_dowload.Location = new Point(657, 12);
            btn_dowload.Name = "btn_dowload";
            btn_dowload.Size = new Size(109, 27);
            btn_dowload.TabIndex = 4;
            btn_dowload.Text = "Download";
            btn_dowload.UseVisualStyleBackColor = true;
            btn_dowload.Click += btn_dowload_Click;
            // 
            // txtb_url
            // 
            txtb_url.Location = new Point(12, 12);
            txtb_url.Name = "txtb_url";
            txtb_url.Size = new Size(613, 27);
            txtb_url.TabIndex = 3;
            // 
            // txtb_filepath
            // 
            txtb_filepath.Location = new Point(12, 45);
            txtb_filepath.Name = "txtb_filepath";
            txtb_filepath.Size = new Size(613, 27);
            txtb_filepath.TabIndex = 6;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 495);
            Controls.Add(txtb_filepath);
            Controls.Add(rtb_content);
            Controls.Add(btn_dowload);
            Controls.Add(txtb_url);
            Name = "Bai2";
            Text = "BAI2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtb_content;
        private Button btn_dowload;
        private TextBox txtb_url;
        private TextBox txtb_filepath;
    }
}
