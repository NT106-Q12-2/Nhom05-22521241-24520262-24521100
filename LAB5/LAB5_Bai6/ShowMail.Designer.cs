namespace LAB5_Bai6
{
    partial class ShowMail
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
            this.lb_from = new System.Windows.Forms.Label();
            this.lb_to = new System.Windows.Forms.Label();
            this.lb_subject = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // lb_from
            // 
            this.lb_from.AutoSize = true;
            this.lb_from.Location = new System.Drawing.Point(12, 24);
            this.lb_from.Name = "lb_from";
            this.lb_from.Size = new System.Drawing.Size(56, 18);
            this.lb_from.TabIndex = 0;
            this.lb_from.Text = "From: ";
            // 
            // lb_to
            // 
            this.lb_to.AutoSize = true;
            this.lb_to.Location = new System.Drawing.Point(12, 62);
            this.lb_to.Name = "lb_to";
            this.lb_to.Size = new System.Drawing.Size(40, 18);
            this.lb_to.TabIndex = 1;
            this.lb_to.Text = "To: ";
            // 
            // lb_subject
            // 
            this.lb_subject.AutoSize = true;
            this.lb_subject.Font = new System.Drawing.Font("Cascadia Code SemiBold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lb_subject.Location = new System.Drawing.Point(11, 103);
            this.lb_subject.Name = "lb_subject";
            this.lb_subject.Size = new System.Drawing.Size(73, 21);
            this.lb_subject.TabIndex = 2;
            this.lb_subject.Text = "Subject";
            // 
            // webBrowser
            // 
            this.webBrowser.Location = new System.Drawing.Point(12, 145);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Size = new System.Drawing.Size(1114, 481);
            this.webBrowser.TabIndex = 3;
            // 
            // ShowMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 638);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.lb_subject);
            this.Controls.Add(this.lb_to);
            this.Controls.Add(this.lb_from);
            this.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ShowMail";
            this.Text = "ShowMail";
            this.Load += new System.EventHandler(this.ShowMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_from;
        private System.Windows.Forms.Label lb_to;
        private System.Windows.Forms.Label lb_subject;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}