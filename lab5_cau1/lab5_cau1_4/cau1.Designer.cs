namespace lab5_cau1_4
{
    partial class cau1
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
            txtFrom = new TextBox();
            txtTo = new TextBox();
            txtSubject = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rtbBody = new RichTextBox();
            label4 = new Label();
            btnSend = new Button();
            SuspendLayout();
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(184, 26);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(361, 23);
            txtFrom.TabIndex = 0;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(184, 67);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(361, 23);
            txtTo.TabIndex = 1;
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(184, 115);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(501, 23);
            txtSubject.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(80, 28);
            label1.Name = "label1";
            label1.Size = new Size(54, 21);
            label1.TabIndex = 3;
            label1.Text = "From :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(80, 69);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 4;
            label2.Text = "To :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(80, 117);
            label3.Name = "label3";
            label3.Size = new Size(68, 21);
            label3.TabIndex = 5;
            label3.Text = "Subject :";
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(184, 169);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(501, 242);
            rtbBody.TabIndex = 6;
            rtbBody.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(80, 169);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 7;
            label4.Text = "Body :";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(584, 26);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(101, 64);
            btnSend.TabIndex = 8;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // cau1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSend);
            Controls.Add(label4);
            Controls.Add(rtbBody);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtSubject);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Name = "cau1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFrom;
        private TextBox txtTo;
        private TextBox txtSubject;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox rtbBody;
        private Label label4;
        private Button btnSend;
    }
}
