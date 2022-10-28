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
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chart1.ForeColor = System.Drawing.Color.White;
            this.chart1.Location = new System.Drawing.Point(3, 12);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(488, 495);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "cartesianChart1";
            // 
            // dataSet
            // 
            this.dataSet.AutoScroll = true;
            this.dataSet.Location = new System.Drawing.Point(501, 24);
            this.dataSet.Name = "dataSet";
            this.dataSet.Size = new System.Drawing.Size(373, 463);
            this.dataSet.TabIndex = 1;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(497, 2);
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
            this.lblTotal.Location = new System.Drawing.Point(497, 507);
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
            this.lblTotalTemp.Location = new System.Drawing.Point(497, 489);
            this.lblTotalTemp.Name = "lblTotalTemp";
            this.lblTotalTemp.Size = new System.Drawing.Size(245, 19);
            this.lblTotalTemp.TabIndex = 2;
            this.lblTotalTemp.Text = "Промежуточная прибыль: 0 aUEC";
            // 
            // PageDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(898, 529);
            this.Controls.Add(this.lblTotalTemp);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.dataSet);
            this.Controls.Add(this.chart1);
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
    }
}