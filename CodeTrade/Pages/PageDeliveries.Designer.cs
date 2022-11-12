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
            this.cbCargoName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblBuyPlace = new System.Windows.Forms.Label();
            this.lblSellPlace = new System.Windows.Forms.Label();
            this.pnlStats.SuspendLayout();
            this.SuspendLayout();
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
            this.btnFinish.TabIndex = 6;
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
            this.tbCargoPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbCargoPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCargoPrice.DisabledState.Parent = this.tbCargoPrice;
            this.tbCargoPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCargoPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbCargoPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbCargoPrice.FocusedState.Parent = this.tbCargoPrice;
            this.tbCargoPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCargoPrice.ForeColor = System.Drawing.Color.Black;
            this.tbCargoPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
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
            this.pnlDivider1.Location = new System.Drawing.Point(14, 199);
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
            this.pnlDivider3.Location = new System.Drawing.Point(14, 349);
            this.pnlDivider3.Name = "pnlDivider3";
            this.pnlDivider3.Size = new System.Drawing.Size(436, 5);
            this.pnlDivider3.TabIndex = 5;
            // 
            // tbBuyPlace
            // 
            this.tbBuyPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbBuyPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.tbBuyPlace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbBuyPlace.FocusedState.Parent = this.tbBuyPlace;
            this.tbBuyPlace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBuyPlace.ForeColor = System.Drawing.Color.Black;
            this.tbBuyPlace.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbBuyPlace.HoverState.Parent = this.tbBuyPlace;
            this.tbBuyPlace.Location = new System.Drawing.Point(9, 377);
            this.tbBuyPlace.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbBuyPlace.Name = "tbBuyPlace";
            this.tbBuyPlace.PasswordChar = '\0';
            this.tbBuyPlace.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbBuyPlace.PlaceholderText = "Введите место покупки товара";
            this.tbBuyPlace.SelectedText = "";
            this.tbBuyPlace.ShadowDecoration.Parent = this.tbBuyPlace;
            this.tbBuyPlace.Size = new System.Drawing.Size(436, 35);
            this.tbBuyPlace.TabIndex = 4;
            this.tbBuyPlace.TextChanged += new System.EventHandler(this.tbBuyPlace_TextChanged);
            // 
            // tbSellPlace
            // 
            this.tbSellPlace.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tbSellPlace.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
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
            this.tbSellPlace.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbSellPlace.FocusedState.Parent = this.tbSellPlace;
            this.tbSellPlace.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellPlace.ForeColor = System.Drawing.Color.Black;
            this.tbSellPlace.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tbSellPlace.HoverState.Parent = this.tbSellPlace;
            this.tbSellPlace.Location = new System.Drawing.Point(9, 436);
            this.tbSellPlace.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbSellPlace.Name = "tbSellPlace";
            this.tbSellPlace.PasswordChar = '\0';
            this.tbSellPlace.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbSellPlace.PlaceholderText = "Введите место продажи товара";
            this.tbSellPlace.SelectedText = "";
            this.tbSellPlace.ShadowDecoration.Parent = this.tbSellPlace;
            this.tbSellPlace.Size = new System.Drawing.Size(436, 35);
            this.tbSellPlace.TabIndex = 5;
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
            // cbCargoName
            // 
            this.cbCargoName.BackColor = System.Drawing.Color.Transparent;
            this.cbCargoName.BorderColor = System.Drawing.Color.Black;
            this.cbCargoName.BorderThickness = 2;
            this.cbCargoName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCargoName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCargoName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cbCargoName.FocusedColor = System.Drawing.Color.Empty;
            this.cbCargoName.FocusedState.Parent = this.cbCargoName;
            this.cbCargoName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargoName.ForeColor = System.Drawing.Color.Black;
            this.cbCargoName.FormattingEnabled = true;
            this.cbCargoName.HoverState.Parent = this.cbCargoName;
            this.cbCargoName.IntegralHeight = false;
            this.cbCargoName.ItemHeight = 30;
            this.cbCargoName.Items.AddRange(new object[] {
            "Agricium",
            "Agr. Supplies",
            "Altruciatoxin",
            "Aluminium",
            "Amioshi Pl.",
            "Aphorite",
            "Astatine",
            "Beryl",
            "Bexalite",
            "Borase",
            "Chlorine",
            "CompBoard",
            "Copper",
            "Corundum",
            "Degnous R.",
            "Diamond",
            "Dist. Spirits",
            "Dolivine",
            "Fluorine",
            "Gold",
            "Hadanite",
            "Hephaest.",
            "Hydrogen",
            "Inert Materials",
            "Iodine",
            "Laranite",
            "Maze",
            "Med. Supplies",
            "Neon",
            "Pitambu",
            "Proc. Food",
            "Prota",
            "Quantanium",
            "Quartz",
            "Ranta Dung",
            "Red Fest. Env.",
            "Rev. Tree Pollen",
            "SLAM",
            "Scrap",
            "Stims",
            "Sunset Berries",
            "Taranite",
            "Titanium",
            "Tungstein",
            "Waste",
            "WiDoW"});
            this.cbCargoName.ItemsAppearance.Parent = this.cbCargoName;
            this.cbCargoName.Location = new System.Drawing.Point(12, 47);
            this.cbCargoName.Name = "cbCargoName";
            this.cbCargoName.ShadowDecoration.Parent = this.cbCargoName;
            this.cbCargoName.Size = new System.Drawing.Size(380, 36);
            this.cbCargoName.StartIndex = 0;
            this.cbCargoName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cbCargoName.TabIndex = 0;
            // 
            // lblBuyPlace
            // 
            this.lblBuyPlace.AutoSize = true;
            this.lblBuyPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyPlace.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyPlace.Location = new System.Drawing.Point(8, 356);
            this.lblBuyPlace.Name = "lblBuyPlace";
            this.lblBuyPlace.Size = new System.Drawing.Size(121, 19);
            this.lblBuyPlace.TabIndex = 1;
            this.lblBuyPlace.Text = "Место покупки:";
            // 
            // lblSellPlace
            // 
            this.lblSellPlace.AutoSize = true;
            this.lblSellPlace.BackColor = System.Drawing.Color.Transparent;
            this.lblSellPlace.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPlace.Location = new System.Drawing.Point(8, 414);
            this.lblSellPlace.Name = "lblSellPlace";
            this.lblSellPlace.Size = new System.Drawing.Size(126, 19);
            this.lblSellPlace.TabIndex = 1;
            this.lblSellPlace.Text = "Место продажи:";
            // 
            // PageDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(898, 529);
            this.Controls.Add(this.cbCargoName);
            this.Controls.Add(this.pnlStats);
            this.Controls.Add(this.lblSellPlace);
            this.Controls.Add(this.lblBuyPlace);
            this.Controls.Add(this.pnlDivider2);
            this.Controls.Add(this.pnlDivider3);
            this.Controls.Add(this.pnlDivider1);
            this.Controls.Add(this.pnlCargo);
            this.Controls.Add(this.btnAddCargo);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.tbCargoPrice);
            this.Controls.Add(this.tbSellPlace);
            this.Controls.Add(this.tbBuyPlace);
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
        private Guna.UI2.WinForms.Guna2ComboBox cbCargoName;
        private System.Windows.Forms.Label lblBuyPlace;
        private System.Windows.Forms.Label lblSellPlace;
    }
}