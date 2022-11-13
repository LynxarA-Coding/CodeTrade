namespace CodeTrade
{
    partial class Dashboard
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
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnlMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnSettings = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnLogs = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDeliveries = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnDashboard = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnToggleMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMenuToggle = new System.Windows.Forms.PictureBox();
            this.menuTransition = new Guna.UI2.WinForms.Guna2Transition();
            this.pnlPage = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlMenu.SuspendLayout();
            this.btnToggleMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuToggle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.pnlMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.pnlMenu.BorderRadius = 15;
            this.pnlMenu.Controls.Add(this.lblCopyright);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnLogs);
            this.pnlMenu.Controls.Add(this.btnDeliveries);
            this.pnlMenu.Controls.Add(this.btnDashboard);
            this.pnlMenu.Controls.Add(this.btnToggleMenu);
            this.menuTransition.SetDecoration(this.pnlMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.ShadowDecoration.Parent = this.pnlMenu;
            this.pnlMenu.Size = new System.Drawing.Size(195, 544);
            this.pnlMenu.TabIndex = 0;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.menuTransition.SetDecoration(this.lblCopyright, Guna.UI2.AnimatorNS.DecorationType.None);
            this.lblCopyright.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.Location = new System.Drawing.Point(5, 499);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(98, 39);
            this.lblCopyright.TabIndex = 0;
            this.lblCopyright.Text = "by LynxarA @2022 \r\nDiscord: LynX#6969\r\nCODEGAMING Corp";
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Transparent;
            this.btnSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.btnSettings.BorderRadius = 5;
            this.btnSettings.BorderThickness = 2;
            this.btnSettings.CheckedState.Parent = this.btnSettings;
            this.btnSettings.CustomImages.Parent = this.btnSettings;
            this.menuTransition.SetDecoration(this.btnSettings, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnSettings.FillColor = System.Drawing.Color.Transparent;
            this.btnSettings.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.HoverState.Parent = this.btnSettings;
            this.btnSettings.Location = new System.Drawing.Point(3, 159);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.ShadowDecoration.Parent = this.btnSettings;
            this.btnSettings.Size = new System.Drawing.Size(152, 46);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "НАСТРОЙКИ";
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnLogs
            // 
            this.btnLogs.BackColor = System.Drawing.Color.Transparent;
            this.btnLogs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.btnLogs.BorderRadius = 5;
            this.btnLogs.BorderThickness = 2;
            this.btnLogs.CheckedState.Parent = this.btnLogs;
            this.btnLogs.CustomImages.Parent = this.btnLogs;
            this.menuTransition.SetDecoration(this.btnLogs, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnLogs.FillColor = System.Drawing.Color.Transparent;
            this.btnLogs.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.ForeColor = System.Drawing.Color.Black;
            this.btnLogs.HoverState.Parent = this.btnLogs;
            this.btnLogs.Location = new System.Drawing.Point(3, 107);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.ShadowDecoration.Parent = this.btnLogs;
            this.btnLogs.Size = new System.Drawing.Size(152, 46);
            this.btnLogs.TabIndex = 1;
            this.btnLogs.Text = "ЛОГИ";
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnDeliveries
            // 
            this.btnDeliveries.BackColor = System.Drawing.Color.Transparent;
            this.btnDeliveries.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.btnDeliveries.BorderRadius = 5;
            this.btnDeliveries.BorderThickness = 2;
            this.btnDeliveries.CheckedState.Parent = this.btnDeliveries;
            this.btnDeliveries.CustomImages.Parent = this.btnDeliveries;
            this.menuTransition.SetDecoration(this.btnDeliveries, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDeliveries.FillColor = System.Drawing.Color.Transparent;
            this.btnDeliveries.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeliveries.ForeColor = System.Drawing.Color.Black;
            this.btnDeliveries.HoverState.Parent = this.btnDeliveries;
            this.btnDeliveries.Location = new System.Drawing.Point(3, 55);
            this.btnDeliveries.Name = "btnDeliveries";
            this.btnDeliveries.ShadowDecoration.Parent = this.btnDeliveries;
            this.btnDeliveries.Size = new System.Drawing.Size(152, 46);
            this.btnDeliveries.TabIndex = 1;
            this.btnDeliveries.Text = "ДОСТАВКИ";
            this.btnDeliveries.Click += new System.EventHandler(this.btnDeliveries_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.btnDashboard.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.btnDashboard.BorderRadius = 5;
            this.btnDashboard.BorderThickness = 2;
            this.btnDashboard.CheckedState.Parent = this.btnDashboard;
            this.btnDashboard.CustomImages.Parent = this.btnDashboard;
            this.menuTransition.SetDecoration(this.btnDashboard, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnDashboard.FillColor = System.Drawing.Color.Transparent;
            this.btnDashboard.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.HoverState.Parent = this.btnDashboard;
            this.btnDashboard.Location = new System.Drawing.Point(3, 3);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.ShadowDecoration.Parent = this.btnDashboard;
            this.btnDashboard.Size = new System.Drawing.Size(152, 46);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "ПАНЕЛЬ";
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnToggleMenu
            // 
            this.btnToggleMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnToggleMenu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.btnToggleMenu.BorderRadius = 15;
            this.btnToggleMenu.BorderThickness = 3;
            this.btnToggleMenu.Controls.Add(this.btnMenuToggle);
            this.menuTransition.SetDecoration(this.btnToggleMenu, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnToggleMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnToggleMenu.Location = new System.Drawing.Point(155, 0);
            this.btnToggleMenu.Name = "btnToggleMenu";
            this.btnToggleMenu.ShadowDecoration.Parent = this.btnToggleMenu;
            this.btnToggleMenu.Size = new System.Drawing.Size(40, 544);
            this.btnToggleMenu.TabIndex = 0;
            this.btnToggleMenu.Click += new System.EventHandler(this.btnToggleMenu_Click);
            // 
            // btnMenuToggle
            // 
            this.menuTransition.SetDecoration(this.btnMenuToggle, Guna.UI2.AnimatorNS.DecorationType.None);
            this.btnMenuToggle.Image = global::CodeTrade.Properties.Resources.left_arrow;
            this.btnMenuToggle.Location = new System.Drawing.Point(5, 231);
            this.btnMenuToggle.Name = "btnMenuToggle";
            this.btnMenuToggle.Size = new System.Drawing.Size(30, 30);
            this.btnMenuToggle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMenuToggle.TabIndex = 0;
            this.btnMenuToggle.TabStop = false;
            this.btnMenuToggle.Click += new System.EventHandler(this.btnToggleMenu_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.menuTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.menuTransition.DefaultAnimation = animation2;
            // 
            // pnlPage
            // 
            this.pnlPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.menuTransition.SetDecoration(this.pnlPage, Guna.UI2.AnimatorNS.DecorationType.None);
            this.pnlPage.Location = new System.Drawing.Point(48, 7);
            this.pnlPage.Name = "pnlPage";
            this.pnlPage.ShadowDecoration.Parent = this.pnlPage;
            this.pnlPage.Size = new System.Drawing.Size(898, 529);
            this.pnlPage.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(950, 544);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlPage);
            this.menuTransition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.btnToggleMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenuToggle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlMenu;
        private Guna.UI2.WinForms.Guna2Panel btnToggleMenu;
        private Guna.UI2.WinForms.Guna2Transition menuTransition;
        private System.Windows.Forms.PictureBox btnMenuToggle;
        private Guna.UI2.WinForms.Guna2TileButton btnDashboard;
        private Guna.UI2.WinForms.Guna2TileButton btnLogs;
        private Guna.UI2.WinForms.Guna2TileButton btnSettings;
        private Guna.UI2.WinForms.Guna2Panel pnlPage;
        private Guna.UI2.WinForms.Guna2TileButton btnDeliveries;
        private System.Windows.Forms.Label lblCopyright;
    }
}