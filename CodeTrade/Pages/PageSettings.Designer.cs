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
            this.cbLanguage = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
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
            // cbLanguage
            // 
            this.cbLanguage.BackColor = System.Drawing.Color.Transparent;
            this.cbLanguage.BorderColor = System.Drawing.Color.Black;
            this.cbLanguage.BorderRadius = 6;
            this.cbLanguage.BorderThickness = 3;
            this.cbLanguage.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLanguage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cbLanguage.FocusedColor = System.Drawing.Color.Empty;
            this.cbLanguage.FocusedState.Parent = this.cbLanguage;
            this.cbLanguage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLanguage.ForeColor = System.Drawing.Color.Black;
            this.cbLanguage.FormattingEnabled = true;
            this.cbLanguage.HoverState.Parent = this.cbLanguage;
            this.cbLanguage.ItemHeight = 30;
            this.cbLanguage.Items.AddRange(new object[] {
            "English",
            "Русский"});
            this.cbLanguage.ItemsAppearance.Parent = this.cbLanguage;
            this.cbLanguage.Location = new System.Drawing.Point(471, 341);
            this.cbLanguage.Name = "cbLanguage";
            this.cbLanguage.ShadowDecoration.Parent = this.cbLanguage;
            this.cbLanguage.Size = new System.Drawing.Size(415, 36);
            this.cbLanguage.StartIndex = 1;
            this.cbLanguage.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbLanguage.TabIndex = 6;
            this.cbLanguage.SelectedIndexChanged += new System.EventHandler(this.cbLanguage_SelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.AutoSize = true;
            this.lblLanguage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanguage.Location = new System.Drawing.Point(467, 316);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(48, 19);
            this.lblLanguage.TabIndex = 7;
            this.lblLanguage.Text = "Язык:";
            // 
            // PageSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(898, 529);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cbLanguage);
            this.Controls.Add(this.lblDeleteData);
            this.Controls.Add(this.btnDeleteData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageSettings";
            this.Text = "PageSettings";
            this.Load += new System.EventHandler(this.PageSettings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TileButton btnDeleteData;
        private System.Windows.Forms.Label lblDeleteData;
        private Guna.UI2.WinForms.Guna2ComboBox cbLanguage;
        private System.Windows.Forms.Label lblLanguage;
    }
}