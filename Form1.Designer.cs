namespace Simple_Downloader_V3
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.comboBoxLaunchers = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnCancel = new NMSModToggler.Resources.AdvancedButton();
            this.btnDownload = new NMSModToggler.Resources.AdvancedButton();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Black;
            this.progressBar.Location = new System.Drawing.Point(215, 341);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(384, 33);
            this.progressBar.TabIndex = 2;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Location = new System.Drawing.Point(248, 307);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(152, 31);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Awaiting...";
            // 
            // comboBoxLaunchers
            // 
            this.comboBoxLaunchers.FormattingEnabled = true;
            this.comboBoxLaunchers.Location = new System.Drawing.Point(302, 279);
            this.comboBoxLaunchers.Name = "comboBoxLaunchers";
            this.comboBoxLaunchers.Size = new System.Drawing.Size(204, 21);
            this.comboBoxLaunchers.TabIndex = 5;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(250, 256);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(312, 20);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Select the launcher you want to download:";
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.White;
            this.btnCancel.BorderRadius = 20;
            this.btnCancel.BorderSize = 2;
            this.btnCancel.ButtonColor1 = System.Drawing.Color.Red;
            this.btnCancel.ButtonColor2 = System.Drawing.Color.Maroon;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Liberation Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancel.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancel.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancel.Icon = null;
            this.btnCancel.IconSize = 20;
            this.btnCancel.IconSpacing = 5;
            this.btnCancel.Location = new System.Drawing.Point(430, 380);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PressedColor1 = System.Drawing.Color.Crimson;
            this.btnCancel.PressedColor2 = System.Drawing.Color.Salmon;
            this.btnCancel.Size = new System.Drawing.Size(169, 49);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.BorderColor = System.Drawing.Color.White;
            this.btnDownload.BorderRadius = 20;
            this.btnDownload.BorderSize = 2;
            this.btnDownload.ButtonColor1 = System.Drawing.Color.Red;
            this.btnDownload.ButtonColor2 = System.Drawing.Color.Maroon;
            this.btnDownload.FlatAppearance.BorderSize = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("Liberation Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnDownload.HoverColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDownload.HoverColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDownload.Icon = null;
            this.btnDownload.IconSize = 20;
            this.btnDownload.IconSpacing = 5;
            this.btnDownload.Location = new System.Drawing.Point(215, 380);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.PressedColor1 = System.Drawing.Color.Crimson;
            this.btnDownload.PressedColor2 = System.Drawing.Color.Salmon;
            this.btnDownload.Size = new System.Drawing.Size(169, 49);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.TextColor = System.Drawing.Color.Black;
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Simple_Downloader_V3.Properties.Resources.thumbnail;
            this.ClientSize = new System.Drawing.Size(818, 490);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.comboBoxLaunchers);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnDownload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Simple Downloader V3 by CEZEY";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private NMSModToggler.Resources.AdvancedButton btnDownload;
        private System.Windows.Forms.ProgressBar progressBar;
        private NMSModToggler.Resources.AdvancedButton btnCancel;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox comboBoxLaunchers;
        private System.Windows.Forms.Label lblInfo;
    }
}

