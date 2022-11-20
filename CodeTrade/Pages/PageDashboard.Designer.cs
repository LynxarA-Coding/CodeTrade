namespace CodeTrade.Pages
{
    partial class PageDashboard
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
            this.chart1 = new LiveCharts.WinForms.CartesianChart();
            this.dataSet = new System.Windows.Forms.FlowLayoutPanel();
            this.lblData = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalTemp = new System.Windows.Forms.Label();
            this.cbRouteCount = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tbIdChoice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblChartLoading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.ForeColor = System.Drawing.Color.White;
            this.chart1.Location = new System.Drawing.Point(12, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(479, 509);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "cartesianChart1";
            // 
            // dataSet
            // 
            this.dataSet.AutoScroll = true;
            this.dataSet.Location = new System.Drawing.Point(501, 82);
            this.dataSet.Name = "dataSet";
            this.dataSet.Size = new System.Drawing.Size(373, 420);
            this.dataSet.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(497, 60);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(189, 19);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Последние 5 Маршрутов:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(497, 505);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(198, 19);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Конечная прибыль: 0 aUEC";
            // 
            // lblTotalTemp
            // 
            this.lblTotalTemp.AutoSize = true;
            this.lblTotalTemp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTemp.ForeColor = System.Drawing.Color.Red;
            this.lblTotalTemp.Location = new System.Drawing.Point(497, 0);
            this.lblTotalTemp.Name = "lblTotalTemp";
            this.lblTotalTemp.Size = new System.Drawing.Size(245, 19);
            this.lblTotalTemp.TabIndex = 2;
            this.lblTotalTemp.Text = "Промежуточная прибыль: 0 aUEC";
            // 
            // cbRouteCount
            // 
            this.cbRouteCount.BackColor = System.Drawing.Color.Transparent;
            this.cbRouteCount.BorderColor = System.Drawing.Color.Black;
            this.cbRouteCount.BorderRadius = 6;
            this.cbRouteCount.BorderThickness = 2;
            this.cbRouteCount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRouteCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRouteCount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cbRouteCount.FocusedColor = System.Drawing.Color.Empty;
            this.cbRouteCount.FocusedState.Parent = this.cbRouteCount;
            this.cbRouteCount.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRouteCount.ForeColor = System.Drawing.Color.Black;
            this.cbRouteCount.FormattingEnabled = true;
            this.cbRouteCount.HoverState.Parent = this.cbRouteCount;
            this.cbRouteCount.ItemHeight = 30;
            this.cbRouteCount.Items.AddRange(new object[] {
            "Показать ВСЕ",
            "Показать по ID",
            "Показать: 1",
            "Показать: 2",
            "Показать: 3",
            "Показать: 4",
            "Показать: 5"});
            this.cbRouteCount.ItemsAppearance.Parent = this.cbRouteCount;
            this.cbRouteCount.Location = new System.Drawing.Point(501, 21);
            this.cbRouteCount.Name = "cbRouteCount";
            this.cbRouteCount.ShadowDecoration.Parent = this.cbRouteCount;
            this.cbRouteCount.Size = new System.Drawing.Size(232, 36);
            this.cbRouteCount.StartIndex = 2;
            this.cbRouteCount.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbRouteCount.TabIndex = 3;
            this.cbRouteCount.SelectedIndexChanged += new System.EventHandler(this.cbRouteCount_SelectedIndexChanged);
            // 
            // tbIdChoice
            // 
            this.tbIdChoice.BorderColor = System.Drawing.Color.Black;
            this.tbIdChoice.BorderRadius = 6;
            this.tbIdChoice.BorderThickness = 2;
            this.tbIdChoice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbIdChoice.DefaultText = "";
            this.tbIdChoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbIdChoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbIdChoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIdChoice.DisabledState.Parent = this.tbIdChoice;
            this.tbIdChoice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbIdChoice.Enabled = false;
            this.tbIdChoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbIdChoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbIdChoice.FocusedState.Parent = this.tbIdChoice;
            this.tbIdChoice.ForeColor = System.Drawing.Color.Black;
            this.tbIdChoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbIdChoice.HoverState.Parent = this.tbIdChoice;
            this.tbIdChoice.Location = new System.Drawing.Point(739, 21);
            this.tbIdChoice.Name = "tbIdChoice";
            this.tbIdChoice.PasswordChar = '\0';
            this.tbIdChoice.PlaceholderText = "ID";
            this.tbIdChoice.SelectedText = "";
            this.tbIdChoice.ShadowDecoration.Parent = this.tbIdChoice;
            this.tbIdChoice.Size = new System.Drawing.Size(135, 36);
            this.tbIdChoice.TabIndex = 4;
            this.tbIdChoice.Visible = false;
            this.tbIdChoice.TextChanged += new System.EventHandler(this.tbIdChoice_TextChanged);
            // 
            // lblChartLoading
            // 
            this.lblChartLoading.AutoSize = true;
            this.lblChartLoading.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChartLoading.Location = new System.Drawing.Point(136, 237);
            this.lblChartLoading.Name = "lblChartLoading";
            this.lblChartLoading.Size = new System.Drawing.Size(245, 26);
            this.lblChartLoading.TabIndex = 2;
            this.lblChartLoading.Text = "Последние 5 Маршрутов:";
            // 
            // PageDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(898, 529);
            this.Controls.Add(this.tbIdChoice);
            this.Controls.Add(this.cbRouteCount);
            this.Controls.Add(this.lblTotalTemp);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dataSet);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lblChartLoading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageDashboard";
            this.Text = "PageDashboard";
            this.Load += new System.EventHandler(this.PageDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LiveCharts.WinForms.CartesianChart chart1;
        private System.Windows.Forms.FlowLayoutPanel dataSet;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalTemp;
        private Guna.UI2.WinForms.Guna2ComboBox cbRouteCount;
        private Guna.UI2.WinForms.Guna2TextBox tbIdChoice;
        private System.Windows.Forms.Label lblChartLoading;
    }
}