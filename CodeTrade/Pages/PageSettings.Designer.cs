namespace CodeTrade.Pages
{
    partial class PageSettings
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
            this.btnDeleteData = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblDeleteData = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteData
            // 
            this.btnDeleteData.BorderRadius = 6;
            this.btnDeleteData.BorderThickness = 2;
            this.btnDeleteData.CheckedState.Parent = this.btnDeleteData;
            this.btnDeleteData.CustomImages.Parent = this.btnDeleteData;
            this.btnDeleteData.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnDeleteData.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteData.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteData.HoverState.Parent = this.btnDeleteData;
            this.btnDeleteData.Location = new System.Drawing.Point(471, 459);
            this.btnDeleteData.Name = "btnDeleteData";
            this.btnDeleteData.ShadowDecoration.Parent = this.btnDeleteData;
            this.btnDeleteData.Size = new System.Drawing.Size(415, 43);
            this.btnDeleteData.TabIndex = 4;
            this.btnDeleteData.Text = "УДАЛИТЬ ДАННЫЕ";
            this.btnDeleteData.Click += new System.EventHandler(this.btnDeleteData_Click);
            // 
            // lblDeleteData
            // 
            this.lblDeleteData.AutoSize = true;
            this.lblDeleteData.Location = new System.Drawing.Point(468, 505);
            this.lblDeleteData.Name = "lblDeleteData";
            this.lblDeleteData.Size = new System.Drawing.Size(419, 13);
            this.lblDeleteData.TabIndex = 5;
            this.lblDeleteData.Text = "Удаляет все логированные маршруты за всё время (невозможно восстановить)";
            // 
            // PageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(898, 529);
            this.Controls.Add(this.lblDeleteData);
            this.Controls.Add(this.btnDeleteData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageSettings";
            this.Text = "PageSettings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton btnDeleteData;
        private System.Windows.Forms.Label lblDeleteData;
    }
}