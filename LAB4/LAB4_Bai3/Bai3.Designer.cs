namespace LAB4_Bai3
{
    partial class Bai3
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
            btn_reload = new Button();
            btn_load = new Button();
            btn_downfiles = new Button();
            btn_downresources = new Button();
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            SuspendLayout();
            // 
            // txtb_url
            // 
            txtb_url.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold);
            txtb_url.ForeColor = Color.FromArgb(64, 0, 0);
            txtb_url.Location = new Point(112, 14);
            txtb_url.Name = "txtb_url";
            txtb_url.Size = new Size(557, 27);
            txtb_url.TabIndex = 0;
            // 
            // btn_reload
            // 
            btn_reload.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold);
            btn_reload.ForeColor = Color.FromArgb(64, 0, 0);
            btn_reload.Location = new Point(675, 13);
            btn_reload.Name = "btn_reload";
            btn_reload.Size = new Size(94, 74);
            btn_reload.TabIndex = 1;
            btn_reload.Text = "Reload";
            btn_reload.UseVisualStyleBackColor = true;
            btn_reload.Click += btn_reload_Click;
            // 
            // btn_load
            // 
            btn_load.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold);
            btn_load.ForeColor = Color.FromArgb(64, 0, 0);
            btn_load.Location = new Point(12, 12);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(94, 74);
            btn_load.TabIndex = 2;
            btn_load.Text = "Load";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // btn_downfiles
            // 
            btn_downfiles.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold);
            btn_downfiles.ForeColor = Color.FromArgb(64, 0, 0);
            btn_downfiles.Location = new Point(360, 47);
            btn_downfiles.Name = "btn_downfiles";
            btn_downfiles.Size = new Size(140, 40);
            btn_downfiles.TabIndex = 3;
            btn_downfiles.Text = "Down Files";
            btn_downfiles.UseVisualStyleBackColor = true;
            btn_downfiles.Click += btn_downfiles_Click;
            // 
            // btn_downresources
            // 
            btn_downresources.Font = new Font("Cascadia Code SemiBold", 10.2F, FontStyle.Bold);
            btn_downresources.ForeColor = Color.FromArgb(64, 0, 0);
            btn_downresources.Location = new Point(506, 47);
            btn_downresources.Name = "btn_downresources";
            btn_downresources.Size = new Size(163, 40);
            btn_downresources.TabIndex = 4;
            btn_downresources.Text = "Down Resources";
            btn_downresources.UseVisualStyleBackColor = true;
            btn_downresources.Click += btn_downresources_Click;
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Location = new Point(12, 93);
            webView.Name = "webView";
            webView.Size = new Size(757, 346);
            webView.TabIndex = 5;
            webView.ZoomFactor = 1D;
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(784, 472);
            Controls.Add(webView);
            Controls.Add(btn_downresources);
            Controls.Add(btn_downfiles);
            Controls.Add(btn_load);
            Controls.Add(btn_reload);
            Controls.Add(txtb_url);
            Name = "Bai3";
            Text = "BAI3";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtb_url;
        private Button btn_reload;
        private Button btn_load;
        private Button btn_downfiles;
        private Button btn_downresources;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
    }
}
