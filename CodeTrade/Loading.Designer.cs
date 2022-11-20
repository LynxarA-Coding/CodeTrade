namespace CodeTrade
{
    partial class Loading
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
            this.components = new System.ComponentModel.Container();
            this.pBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.loadTimer = new System.Windows.Forms.Timer(this.components);
            this.lblLoading = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersionOutdated = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pBar
            // 
            this.pBar.BorderRadius = 14;
            this.pBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.pBar.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pBar.Location = new System.Drawing.Point(50, 250);
            this.pBar.Name = "pBar";
            this.pBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pBar.ShadowDecoration.Parent = this.pBar;
            this.pBar.Size = new System.Drawing.Size(853, 59);
            this.pBar.TabIndex = 0;
            this.pBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // loadTimer
            // 
            this.loadTimer.Interval = 20;
            this.loadTimer.Tick += new System.EventHandler(this.loadTimer_Tick);
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.lblLoading.Location = new System.Drawing.Point(385, 205);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(176, 42);
            this.lblLoading.TabIndex = 1;
            this.lblLoading.Text = "Загрузка...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CodeTrade.Properties.Resources.Logotype_CODGMING;
            this.pictureBox1.Location = new System.Drawing.Point(249, 393);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(454, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblVersionOutdated
            // 
            this.lblVersionOutdated.AutoSize = true;
            this.lblVersionOutdated.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersionOutdated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.lblVersionOutdated.Location = new System.Drawing.Point(385, 260);
            this.lblVersionOutdated.Name = "lblVersionOutdated";
            this.lblVersionOutdated.Size = new System.Drawing.Size(86, 42);
            this.lblVersionOutdated.TabIndex = 1;
            this.lblVersionOutdated.Text = "TEST";
            // 
            // Loading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(4)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(950, 544);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblVersionOutdated);
            this.Controls.Add(this.lblLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading";
            this.Text = "Loading";
            this.Load += new System.EventHandler(this.Loading_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar pBar;
        private System.Windows.Forms.Timer loadTimer;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersionOutdated;
    }
}