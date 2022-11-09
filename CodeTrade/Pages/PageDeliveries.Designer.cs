namespace CodeTrade.Pages
{
    partial class PageDeliveries
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
            this.tbCargoName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnFinish = new Guna.UI2.WinForms.Guna2TileButton();
            this.pnlCargo = new System.Windows.Forms.FlowLayoutPanel();
            this.lblCargoTitle = new System.Windows.Forms.Label();
            this.btnAddCargo = new Guna.UI2.WinForms.Guna2TileButton();
            this.tbCargoPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCargoCurrency = new System.Windows.Forms.Label();
            this.pnlDivider1 = new System.Windows.Forms.Panel();
            this.pnlDivider2 = new System.Windows.Forms.Panel();
            this.lblBuyTotal = new System.Windows.Forms.Label();
            this.lblSellTotal = new System.Windows.Forms.Label();
            this.lblFullTotal = new System.Windows.Forms.Label();
            this.pnlDivider3 = new System.Windows.Forms.Panel();
            this.tbBuyPlace = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbSellPlace = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlStats = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlStats.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbCargoName
            // 
            this.tbCargoName.BorderColor = System.Drawing.Color.Black;
            this.tbCargoName.BorderRadius = 6;
            this.tbCargoName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCargoName.DefaultText = "";
            this.tbCargoName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCargoName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCargoName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCargoName.DisabledState.Parent = this.tbCargoName;
            this.tbCargoName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCargoName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbCargoName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCargoName.FocusedState.Parent = this.tbCargoName;
            this.tbCargoName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCargoName.ForeColor = System.Drawing.Color.Black;
            this.tbCargoName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCargoName.HoverState.Parent = this.tbCargoName;
            this.tbCargoName.Location = new System.Drawing.Point(12, 38);
            this.tbCargoName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbCargoName.Name = "tbCargoName";
            this.tbCargoName.PasswordChar = '\0';
            this.tbCargoName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbCargoName.PlaceholderText = "Введите название товара";
            this.tbCargoName.SelectedText = "";
            this.tbCargoName.ShadowDecoration.Parent = this.tbCargoName;
            this.tbCargoName.Size = new System.Drawing.Size(380, 43);
            this.tbCargoName.TabIndex = 2;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(12, 16);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(133, 19);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Название Товара:";
            // 
            // btnFinish
            // 
            this.btnFinish.BorderRadius = 6;
            this.btnFinish.BorderThickness = 2;
            this.btnFinish.CheckedState.Parent = this.btnFinish;
            this.btnFinish.CustomImages.Parent = this.btnFinish;
            this.btnFinish.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnFinish.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.ForeColor = System.Drawing.Color.Black;
            this.btnFinish.HoverState.Parent = this.btnFinish;
            this.btnFinish.Location = new System.Drawing.Point(9, 474);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.ShadowDecoration.Parent = this.btnFinish;
            this.btnFinish.Size = new System.Drawing.Size(436, 43);
            this.btnFinish.TabIndex = 3;
            this.btnFinish.Text = "ЗАВЕРШИТЬ ПОЕЗДКУ";
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // pnlCargo
            // 
            this.pnlCargo.AutoScroll = true;
            this.pnlCargo.Location = new System.Drawing.Point(457, 31);
            this.pnlCargo.Name = "pnlCargo";
            this.pnlCargo.Size = new System.Drawing.Size(415, 486);
            this.pnlCargo.TabIndex = 4;
            // 
            // lblCargoTitle
            // 
            this.lblCargoTitle.AutoSize = true;
            this.lblCargoTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoTitle.Location = new System.Drawing.Point(453, 9);
            this.lblCargoTitle.Name = "lblCargoTitle";
            this.lblCargoTitle.Size = new System.Drawing.Size(138, 19);
            this.lblCargoTitle.TabIndex = 1;
            this.lblCargoTitle.Text = "Товар на корабле:";
            // 
            // btnAddCargo
            // 
            this.btnAddCargo.BorderRadius = 6;
            this.btnAddCargo.BorderThickness = 2;
            this.btnAddCargo.CheckedState.Parent = this.btnAddCargo;
            this.btnAddCargo.CustomImages.Parent = this.btnAddCargo;
            this.btnAddCargo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnAddCargo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCargo.ForeColor = System.Drawing.Color.Black;
            this.btnAddCargo.HoverState.Parent = this.btnAddCargo;
            this.btnAddCargo.Location = new System.Drawing.Point(12, 142);
            this.btnAddCargo.Name = "btnAddCargo";
            this.btnAddCargo.ShadowDecoration.Parent = this.btnAddCargo;
            this.btnAddCargo.Size = new System.Drawing.Size(433, 43);
            this.btnAddCargo.TabIndex = 3;
            this.btnAddCargo.Text = "ДОБАВИТЬ ТОВАР НА КОРАБЛЬ";
            this.btnAddCargo.Click += new System.EventHandler(this.btnAddCargo_Click);
            // 
            // tbCargoPrice
            // 
            this.tbCargoPrice.BorderColor = System.Drawing.Color.Black;
            this.tbCargoPrice.BorderRadius = 6;
            this.tbCargoPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCargoPrice.DefaultText = "";
            this.tbCargoPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCargoPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCargoPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCargoPrice.DisabledState.Parent = this.tbCargoPrice;
            this.tbCargoPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCargoPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbCargoPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCargoPrice.FocusedState.Parent = this.tbCargoPrice;
            this.tbCargoPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCargoPrice.ForeColor = System.Drawing.Color.Black;
            this.tbCargoPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCargoPrice.HoverState.Parent = this.tbCargoPrice;
            this.tbCargoPrice.Location = new System.Drawing.Point(12, 91);
            this.tbCargoPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbCargoPrice.Name = "tbCargoPrice";
            this.tbCargoPrice.PasswordChar = '\0';
            this.tbCargoPrice.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbCargoPrice.PlaceholderText = "Введите цену товара";
            this.tbCargoPrice.SelectedText = "";
            this.tbCargoPrice.ShadowDecoration.Parent = this.tbCargoPrice;
            this.tbCargoPrice.Size = new System.Drawing.Size(380, 43);
            this.tbCargoPrice.TabIndex = 2;
            this.tbCargoPrice.TextChanged += new System.EventHandler(this.tbCargoPrice_TextChanged);
            // 
            // lblCargoCurrency
            // 
            this.lblCargoCurrency.AutoSize = true;
            this.lblCargoCurrency.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargoCurrency.Location = new System.Drawing.Point(393, 103);
            this.lblCargoCurrency.Name = "lblCargoCurrency";
            this.lblCargoCurrency.Size = new System.Drawing.Size(43, 19);
            this.lblCargoCurrency.TabIndex = 1;
            this.lblCargoCurrency.Text = "aUEC";
            // 
            // pnlDivider1
            // 
            this.pnlDivider1.BackColor = System.Drawing.Color.Black;
            this.pnlDivider1.Location = new System.Drawing.Point(14, 191);
            this.pnlDivider1.Name = "pnlDivider1";
            this.pnlDivider1.Size = new System.Drawing.Size(436, 5);
            this.pnlDivider1.TabIndex = 5;
            // 
            // pnlDivider2
            // 
            this.pnlDivider2.BackColor = System.Drawing.Color.Black;
            this.pnlDivider2.Location = new System.Drawing.Point(448, 31);
            this.pnlDivider2.Name = "pnlDivider2";
            this.pnlDivider2.Size = new System.Drawing.Size(5, 486);
            this.pnlDivider2.TabIndex = 6;
            // 
            // lblBuyTotal
            // 
            this.lblBuyTotal.AutoSize = true;
            this.lblBuyTotal.BackColor = System.Drawing.Color.Tomato;
            this.lblBuyTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyTotal.Location = new System.Drawing.Point(13, 24);
            this.lblBuyTotal.Name = "lblBuyTotal";
            this.lblBuyTotal.Size = new System.Drawing.Size(170, 19);
            this.lblBuyTotal.TabIndex = 1;
            this.lblBuyTotal.Text = "Сумма закупки: 0 aUEC";
            // 
            // lblSellTotal
            // 
            this.lblSellTotal.AutoSize = true;
            this.lblSellTotal.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.lblSellTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellTotal.Location = new System.Drawing.Point(13, 47);
            this.lblSellTotal.Name = "lblSellTotal";
            this.lblSellTotal.Size = new System.Drawing.Size(178, 19);
            this.lblSellTotal.TabIndex = 1;
            this.lblSellTotal.Text = "Сумма продажи: 0 aUEC";
            // 
            // lblFullTotal
            // 
            this.lblFullTotal.AutoSize = true;
            this.lblFullTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblFullTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullTotal.Location = new System.Drawing.Point(11, 80);
            this.lblFullTotal.Name = "lblFullTotal";
            this.lblFullTotal.Size = new System.Drawing.Size(184, 19);
            this.lblFullTotal.TabIndex = 1;
            this.lblFullTotal.Text = "Итого за поездку: 0 aUEC";
            // 
            // pnlDivider3
            // 
            this.pnlDivider3.BackColor = System.Drawing.Color.Black;
            this.pnlDivider3.Location = new System.Drawing.Point(14, 357);
            this.pnlDivider3.Name = "pnlDivider3";
            this.pnlDivider3.Size = new System.Drawing.Size(436, 5);
            this.pnlDivider3.TabIndex = 5;
            // 
            // tbBuyPlace
            // 
            this.tbBuyPlace.BorderColor = System.Drawing.Color.Black;
            this.tbBuyPlace.BorderRadius = 6;
            this.tbBuyPlace.BorderThickness = 2;
            this.tbBuyPlace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBuyPlace.DefaultText = "";
            this.tbBuyPlace.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBuyPlace.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBuyPlace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBuyPlace.DisabledState.Parent = this.tbBuyPlace;
            this.tbBuyPlace.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBuyPlace.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbBuyPlace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBuyPlace.FocusedState.Parent = this.tbBuyPlace;
            this.tbBuyPlace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyPlace.ForeColor = System.Drawing.Color.Black;
            this.tbBuyPlace.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbBuyPlace.HoverState.Parent = this.tbBuyPlace;
            this.tbBuyPlace.Location = new System.Drawing.Point(9, 370);
            this.tbBuyPlace.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbBuyPlace.Name = "tbBuyPlace";
            this.tbBuyPlace.PasswordChar = '\0';
            this.tbBuyPlace.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbBuyPlace.PlaceholderText = "Введите место покупки товара";
            this.tbBuyPlace.SelectedText = "";
            this.tbBuyPlace.ShadowDecoration.Parent = this.tbBuyPlace;
            this.tbBuyPlace.Size = new System.Drawing.Size(436, 43);
            this.tbBuyPlace.TabIndex = 2;
            this.tbBuyPlace.TextChanged += new System.EventHandler(this.tbBuyPlace_TextChanged);
            // 
            // tbSellPlace
            // 
            this.tbSellPlace.BorderColor = System.Drawing.Color.Black;
            this.tbSellPlace.BorderRadius = 6;
            this.tbSellPlace.BorderThickness = 2;
            this.tbSellPlace.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSellPlace.DefaultText = "";
            this.tbSellPlace.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSellPlace.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSellPlace.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSellPlace.DisabledState.Parent = this.tbSellPlace;
            this.tbSellPlace.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSellPlace.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbSellPlace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSellPlace.FocusedState.Parent = this.tbSellPlace;
            this.tbSellPlace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellPlace.ForeColor = System.Drawing.Color.Black;
            this.tbSellPlace.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSellPlace.HoverState.Parent = this.tbSellPlace;
            this.tbSellPlace.Location = new System.Drawing.Point(9, 423);
            this.tbSellPlace.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbSellPlace.Name = "tbSellPlace";
            this.tbSellPlace.PasswordChar = '\0';
            this.tbSellPlace.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbSellPlace.PlaceholderText = "Введите место продажи товара";
            this.tbSellPlace.SelectedText = "";
            this.tbSellPlace.ShadowDecoration.Parent = this.tbSellPlace;
            this.tbSellPlace.Size = new System.Drawing.Size(436, 43);
            this.tbSellPlace.TabIndex = 2;
            this.tbSellPlace.TextChanged += new System.EventHandler(this.tbSellPlace_TextChanged);
            // 
            // pnlStats
            // 
            this.pnlStats.BorderColor = System.Drawing.Color.Black;
            this.pnlStats.BorderRadius = 6;
            this.pnlStats.BorderThickness = 5;
            this.pnlStats.Controls.Add(this.lblSellTotal);
            this.pnlStats.Controls.Add(this.lblBuyTotal);
            this.pnlStats.Controls.Add(this.lblFullTotal);
            this.pnlStats.Location = new System.Drawing.Point(12, 215);
            this.pnlStats.Name = "pnlStats";
            this.pnlStats.ShadowDecoration.Parent = this.pnlStats;
            this.pnlStats.Size = new System.Drawing.Size(433, 124);
            this.pnlStats.TabIndex = 7;
            // 
            // PageDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(898, 529);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.pnlDivider2);
            this.Controls.Add(this.pnlDivider3);
            this.Controls.Add(this.pnlDivider1);
            this.Controls.Add(this.pnlCargo);
            this.Controls.Add(this.btnAddCargo);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.tbCargoPrice);
            this.Controls.Add(this.tbSellPlace);
            this.Controls.Add(this.tbBuyPlace);
            this.Controls.Add(this.tbCargoName);
            this.Controls.Add(this.lblCargoTitle);
            this.Controls.Add(this.lblCargoCurrency);
            this.Controls.Add(this.lblCargo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageDeliveries";
            this.Text = "PageDeliveries";
            this.Load += new System.EventHandler(this.PageDeliveries_Load);
            this.pnlStats.ResumeLayout(false);
            this.pnlStats.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox tbCargoName;
        private System.Windows.Forms.Label lblCargo;
        private Guna.UI2.WinForms.Guna2TileButton btnFinish;
        private System.Windows.Forms.FlowLayoutPanel pnlCargo;
        private System.Windows.Forms.Label lblCargoTitle;
        private Guna.UI2.WinForms.Guna2TileButton btnAddCargo;
        private Guna.UI2.WinForms.Guna2TextBox tbCargoPrice;
        private System.Windows.Forms.Label lblCargoCurrency;
        private System.Windows.Forms.Panel pnlDivider1;
        private System.Windows.Forms.Panel pnlDivider2;
        private System.Windows.Forms.Label lblBuyTotal;
        private System.Windows.Forms.Label lblSellTotal;
        private System.Windows.Forms.Label lblFullTotal;
        private System.Windows.Forms.Panel pnlDivider3;
        private Guna.UI2.WinForms.Guna2TextBox tbBuyPlace;
        private Guna.UI2.WinForms.Guna2TextBox tbSellPlace;
        private Guna.UI2.WinForms.Guna2Panel pnlStats;
    }
}