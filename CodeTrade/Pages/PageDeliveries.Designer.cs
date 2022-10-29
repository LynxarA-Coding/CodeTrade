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
            this.cbPlanetary1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPlanetary1 = new System.Windows.Forms.Label();
            this.cbTradingPlace1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTradingPlace1 = new System.Windows.Forms.Label();
            this.tbCargoName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.tbPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceCurrency = new System.Windows.Forms.Label();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.lblSellPriceCurrency = new System.Windows.Forms.Label();
            this.tbSellPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2TileButton();
            this.lblBuying = new System.Windows.Forms.Label();
            this.pnlBuying = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlSelling = new Guna.UI2.WinForms.Guna2Panel();
            this.cbTradingPlace2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblPlanetary2 = new System.Windows.Forms.Label();
            this.lblTradingPlace2 = new System.Windows.Forms.Label();
            this.cbPlanetary2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblSelling = new System.Windows.Forms.Label();
            this.btnCalculator = new Guna.UI2.WinForms.Guna2TileButton();
            this.pnlBuying.SuspendLayout();
            this.pnlSelling.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPlanetary1
            // 
            this.cbPlanetary1.BackColor = System.Drawing.Color.Transparent;
            this.cbPlanetary1.BorderColor = System.Drawing.Color.Black;
            this.cbPlanetary1.BorderRadius = 5;
            this.cbPlanetary1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPlanetary1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlanetary1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cbPlanetary1.FocusedColor = System.Drawing.Color.Empty;
            this.cbPlanetary1.FocusedState.Parent = this.cbPlanetary1;
            this.cbPlanetary1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlanetary1.ForeColor = System.Drawing.Color.Black;
            this.cbPlanetary1.FormattingEnabled = true;
            this.cbPlanetary1.HoverState.Parent = this.cbPlanetary1;
            this.cbPlanetary1.ItemHeight = 30;
            this.cbPlanetary1.Items.AddRange(new object[] {
            "ARC",
            "ArcCorp",
            "CRU",
            "Crusader",
            "HUR",
            "Hurston",
            "Microtech"});
            this.cbPlanetary1.ItemsAppearance.Parent = this.cbPlanetary1;
            this.cbPlanetary1.Location = new System.Drawing.Point(11, 38);
            this.cbPlanetary1.Name = "cbPlanetary1";
            this.cbPlanetary1.ShadowDecoration.Parent = this.cbPlanetary1;
            this.cbPlanetary1.Size = new System.Drawing.Size(239, 36);
            this.cbPlanetary1.StartIndex = 0;
            this.cbPlanetary1.TabIndex = 0;
            this.cbPlanetary1.SelectedIndexChanged += new System.EventHandler(this.cbPlanetary_SelectedIndexChanged);
            // 
            // lblPlanetary1
            // 
            this.lblPlanetary1.AutoSize = true;
            this.lblPlanetary1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetary1.Location = new System.Drawing.Point(6, 9);
            this.lblPlanetary1.Name = "lblPlanetary1";
            this.lblPlanetary1.Size = new System.Drawing.Size(215, 26);
            this.lblPlanetary1.TabIndex = 1;
            this.lblPlanetary1.Text = "Планетарная Система:";
            // 
            // cbTradingPlace1
            // 
            this.cbTradingPlace1.BackColor = System.Drawing.Color.Transparent;
            this.cbTradingPlace1.BorderColor = System.Drawing.Color.Black;
            this.cbTradingPlace1.BorderRadius = 5;
            this.cbTradingPlace1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTradingPlace1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTradingPlace1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cbTradingPlace1.FocusedColor = System.Drawing.Color.Empty;
            this.cbTradingPlace1.FocusedState.Parent = this.cbTradingPlace1;
            this.cbTradingPlace1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTradingPlace1.ForeColor = System.Drawing.Color.Black;
            this.cbTradingPlace1.FormattingEnabled = true;
            this.cbTradingPlace1.HoverState.Parent = this.cbTradingPlace1;
            this.cbTradingPlace1.ItemHeight = 30;
            this.cbTradingPlace1.Items.AddRange(new object[] {
            "ВЫБЕРИТЕ ПЛАНЕТАРНУЮ СИСТЕМУ"});
            this.cbTradingPlace1.ItemsAppearance.Parent = this.cbTradingPlace1;
            this.cbTradingPlace1.Location = new System.Drawing.Point(270, 38);
            this.cbTradingPlace1.Name = "cbTradingPlace1";
            this.cbTradingPlace1.ShadowDecoration.Parent = this.cbTradingPlace1;
            this.cbTradingPlace1.Size = new System.Drawing.Size(548, 36);
            this.cbTradingPlace1.TabIndex = 0;
            // 
            // lblTradingPlace1
            // 
            this.lblTradingPlace1.AutoSize = true;
            this.lblTradingPlace1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTradingPlace1.Location = new System.Drawing.Point(265, 9);
            this.lblTradingPlace1.Name = "lblTradingPlace1";
            this.lblTradingPlace1.Size = new System.Drawing.Size(150, 26);
            this.lblTradingPlace1.TabIndex = 1;
            this.lblTradingPlace1.Text = "Торговая Точка:";
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
            this.tbCargoName.Location = new System.Drawing.Point(18, 474);
            this.tbCargoName.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbCargoName.Name = "tbCargoName";
            this.tbCargoName.PasswordChar = '\0';
            this.tbCargoName.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbCargoName.PlaceholderText = "Введите название товара";
            this.tbCargoName.SelectedText = "";
            this.tbCargoName.ShadowDecoration.Parent = this.tbCargoName;
            this.tbCargoName.Size = new System.Drawing.Size(431, 43);
            this.tbCargoName.TabIndex = 2;
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(13, 443);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(68, 26);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "Товар:";
            // 
            // tbPrice
            // 
            this.tbPrice.BorderColor = System.Drawing.Color.Black;
            this.tbPrice.BorderRadius = 6;
            this.tbPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPrice.DefaultText = "";
            this.tbPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.DisabledState.Parent = this.tbPrice;
            this.tbPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.FocusedState.Parent = this.tbPrice;
            this.tbPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.ForeColor = System.Drawing.Color.Black;
            this.tbPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbPrice.HoverState.Parent = this.tbPrice;
            this.tbPrice.Location = new System.Drawing.Point(270, 117);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.PasswordChar = '\0';
            this.tbPrice.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbPrice.PlaceholderText = "Введите цену закупки товара";
            this.tbPrice.SelectedText = "";
            this.tbPrice.ShadowDecoration.Parent = this.tbPrice;
            this.tbPrice.Size = new System.Drawing.Size(314, 43);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(265, 86);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(146, 26);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Цена Покупки:";
            // 
            // lblPriceCurrency
            // 
            this.lblPriceCurrency.AutoSize = true;
            this.lblPriceCurrency.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriceCurrency.Location = new System.Drawing.Point(584, 125);
            this.lblPriceCurrency.Name = "lblPriceCurrency";
            this.lblPriceCurrency.Size = new System.Drawing.Size(57, 26);
            this.lblPriceCurrency.TabIndex = 1;
            this.lblPriceCurrency.Text = "aUEC";
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPrice.Location = new System.Drawing.Point(265, 86);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(152, 26);
            this.lblSellPrice.TabIndex = 1;
            this.lblSellPrice.Text = "Цена Продажи:";
            // 
            // lblSellPriceCurrency
            // 
            this.lblSellPriceCurrency.AutoSize = true;
            this.lblSellPriceCurrency.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellPriceCurrency.Location = new System.Drawing.Point(584, 126);
            this.lblSellPriceCurrency.Name = "lblSellPriceCurrency";
            this.lblSellPriceCurrency.Size = new System.Drawing.Size(57, 26);
            this.lblSellPriceCurrency.TabIndex = 1;
            this.lblSellPriceCurrency.Text = "aUEC";
            // 
            // tbSellPrice
            // 
            this.tbSellPrice.BorderColor = System.Drawing.Color.Black;
            this.tbSellPrice.BorderRadius = 6;
            this.tbSellPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSellPrice.DefaultText = "";
            this.tbSellPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSellPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSellPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSellPrice.DisabledState.Parent = this.tbSellPrice;
            this.tbSellPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSellPrice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbSellPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSellPrice.FocusedState.Parent = this.tbSellPrice;
            this.tbSellPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSellPrice.ForeColor = System.Drawing.Color.Black;
            this.tbSellPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSellPrice.HoverState.Parent = this.tbSellPrice;
            this.tbSellPrice.Location = new System.Drawing.Point(270, 117);
            this.tbSellPrice.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tbSellPrice.Name = "tbSellPrice";
            this.tbSellPrice.PasswordChar = '\0';
            this.tbSellPrice.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbSellPrice.PlaceholderText = "Введите цену продажи товара";
            this.tbSellPrice.SelectedText = "";
            this.tbSellPrice.ShadowDecoration.Parent = this.tbSellPrice;
            this.tbSellPrice.Size = new System.Drawing.Size(314, 43);
            this.tbSellPrice.TabIndex = 2;
            this.tbSellPrice.TextChanged += new System.EventHandler(this.tbSellPrice_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 6;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(457, 474);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(415, 43);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "ДОБАВИТЬ МАРШРУТНЫЙ ЛОГ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBuying
            // 
            this.lblBuying.AutoSize = true;
            this.lblBuying.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuying.Location = new System.Drawing.Point(20, 9);
            this.lblBuying.Name = "lblBuying";
            this.lblBuying.Size = new System.Drawing.Size(107, 26);
            this.lblBuying.TabIndex = 1;
            this.lblBuying.Text = "ПОКУПКА:";
            // 
            // pnlBuying
            // 
            this.pnlBuying.BorderColor = System.Drawing.Color.Black;
            this.pnlBuying.BorderRadius = 15;
            this.pnlBuying.BorderThickness = 3;
            this.pnlBuying.Controls.Add(this.cbTradingPlace1);
            this.pnlBuying.Controls.Add(this.lblPlanetary1);
            this.pnlBuying.Controls.Add(this.tbPrice);
            this.pnlBuying.Controls.Add(this.lblTradingPlace1);
            this.pnlBuying.Controls.Add(this.cbPlanetary1);
            this.pnlBuying.Controls.Add(this.lblPrice);
            this.pnlBuying.Controls.Add(this.lblPriceCurrency);
            this.pnlBuying.Location = new System.Drawing.Point(18, 38);
            this.pnlBuying.Name = "pnlBuying";
            this.pnlBuying.ShadowDecoration.Parent = this.pnlBuying;
            this.pnlBuying.Size = new System.Drawing.Size(861, 173);
            this.pnlBuying.TabIndex = 5;
            // 
            // pnlSelling
            // 
            this.pnlSelling.BorderColor = System.Drawing.Color.Black;
            this.pnlSelling.BorderRadius = 15;
            this.pnlSelling.BorderThickness = 3;
            this.pnlSelling.Controls.Add(this.cbTradingPlace2);
            this.pnlSelling.Controls.Add(this.tbSellPrice);
            this.pnlSelling.Controls.Add(this.lblPlanetary2);
            this.pnlSelling.Controls.Add(this.lblSellPrice);
            this.pnlSelling.Controls.Add(this.lblTradingPlace2);
            this.pnlSelling.Controls.Add(this.lblSellPriceCurrency);
            this.pnlSelling.Controls.Add(this.cbPlanetary2);
            this.pnlSelling.Location = new System.Drawing.Point(18, 243);
            this.pnlSelling.Name = "pnlSelling";
            this.pnlSelling.ShadowDecoration.Parent = this.pnlSelling;
            this.pnlSelling.Size = new System.Drawing.Size(861, 173);
            this.pnlSelling.TabIndex = 6;
            // 
            // cbTradingPlace2
            // 
            this.cbTradingPlace2.BackColor = System.Drawing.Color.Transparent;
            this.cbTradingPlace2.BorderColor = System.Drawing.Color.Black;
            this.cbTradingPlace2.BorderRadius = 5;
            this.cbTradingPlace2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTradingPlace2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTradingPlace2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cbTradingPlace2.FocusedColor = System.Drawing.Color.Empty;
            this.cbTradingPlace2.FocusedState.Parent = this.cbTradingPlace2;
            this.cbTradingPlace2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTradingPlace2.ForeColor = System.Drawing.Color.Black;
            this.cbTradingPlace2.FormattingEnabled = true;
            this.cbTradingPlace2.HoverState.Parent = this.cbTradingPlace2;
            this.cbTradingPlace2.ItemHeight = 30;
            this.cbTradingPlace2.Items.AddRange(new object[] {
            "ВЫБЕРИТЕ ПЛАНЕТАРНУЮ СИСТЕМУ"});
            this.cbTradingPlace2.ItemsAppearance.Parent = this.cbTradingPlace2;
            this.cbTradingPlace2.Location = new System.Drawing.Point(270, 39);
            this.cbTradingPlace2.Name = "cbTradingPlace2";
            this.cbTradingPlace2.ShadowDecoration.Parent = this.cbTradingPlace2;
            this.cbTradingPlace2.Size = new System.Drawing.Size(548, 36);
            this.cbTradingPlace2.TabIndex = 0;
            // 
            // lblPlanetary2
            // 
            this.lblPlanetary2.AutoSize = true;
            this.lblPlanetary2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanetary2.Location = new System.Drawing.Point(6, 10);
            this.lblPlanetary2.Name = "lblPlanetary2";
            this.lblPlanetary2.Size = new System.Drawing.Size(215, 26);
            this.lblPlanetary2.TabIndex = 1;
            this.lblPlanetary2.Text = "Планетарная Система:";
            // 
            // lblTradingPlace2
            // 
            this.lblTradingPlace2.AutoSize = true;
            this.lblTradingPlace2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTradingPlace2.Location = new System.Drawing.Point(265, 10);
            this.lblTradingPlace2.Name = "lblTradingPlace2";
            this.lblTradingPlace2.Size = new System.Drawing.Size(150, 26);
            this.lblTradingPlace2.TabIndex = 1;
            this.lblTradingPlace2.Text = "Торговая Точка:";
            // 
            // cbPlanetary2
            // 
            this.cbPlanetary2.BackColor = System.Drawing.Color.Transparent;
            this.cbPlanetary2.BorderColor = System.Drawing.Color.Black;
            this.cbPlanetary2.BorderRadius = 5;
            this.cbPlanetary2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPlanetary2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPlanetary2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.cbPlanetary2.FocusedColor = System.Drawing.Color.Empty;
            this.cbPlanetary2.FocusedState.Parent = this.cbPlanetary2;
            this.cbPlanetary2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPlanetary2.ForeColor = System.Drawing.Color.Black;
            this.cbPlanetary2.FormattingEnabled = true;
            this.cbPlanetary2.HoverState.Parent = this.cbPlanetary2;
            this.cbPlanetary2.ItemHeight = 30;
            this.cbPlanetary2.Items.AddRange(new object[] {
            "ARC",
            "ArcCorp",
            "CRU",
            "Crusader",
            "HUR",
            "Hurston",
            "Microtech"});
            this.cbPlanetary2.ItemsAppearance.Parent = this.cbPlanetary2;
            this.cbPlanetary2.Location = new System.Drawing.Point(11, 39);
            this.cbPlanetary2.Name = "cbPlanetary2";
            this.cbPlanetary2.ShadowDecoration.Parent = this.cbPlanetary2;
            this.cbPlanetary2.Size = new System.Drawing.Size(239, 36);
            this.cbPlanetary2.StartIndex = 0;
            this.cbPlanetary2.TabIndex = 0;
            this.cbPlanetary2.SelectedIndexChanged += new System.EventHandler(this.cbPlanetary2_SelectedIndexChanged);
            // 
            // lblSelling
            // 
            this.lblSelling.AutoSize = true;
            this.lblSelling.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelling.Location = new System.Drawing.Point(20, 214);
            this.lblSelling.Name = "lblSelling";
            this.lblSelling.Size = new System.Drawing.Size(112, 26);
            this.lblSelling.TabIndex = 1;
            this.lblSelling.Text = "ПРОДАЖА:";
            // 
            // btnCalculator
            // 
            this.btnCalculator.BorderRadius = 6;
            this.btnCalculator.BorderThickness = 2;
            this.btnCalculator.CheckedState.Parent = this.btnCalculator;
            this.btnCalculator.CustomImages.Parent = this.btnCalculator;
            this.btnCalculator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnCalculator.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculator.ForeColor = System.Drawing.Color.Black;
            this.btnCalculator.HoverState.Parent = this.btnCalculator;
            this.btnCalculator.Location = new System.Drawing.Point(457, 428);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.ShadowDecoration.Parent = this.btnCalculator;
            this.btnCalculator.Size = new System.Drawing.Size(415, 43);
            this.btnCalculator.TabIndex = 3;
            this.btnCalculator.Text = "ОТКРЫТЬ КАЛЬКУЛЯТОР";
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // PageDeliveries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(898, 529);
            this.Controls.Add(this.pnlSelling);
            this.Controls.Add(this.pnlBuying);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbCargoName);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblSelling);
            this.Controls.Add(this.lblBuying);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PageDeliveries";
            this.Text = "PageDeliveries";
            this.Load += new System.EventHandler(this.PageDeliveries_Load);
            this.pnlBuying.ResumeLayout(false);
            this.pnlBuying.PerformLayout();
            this.pnlSelling.ResumeLayout(false);
            this.pnlSelling.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbPlanetary1;
        private System.Windows.Forms.Label lblPlanetary1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTradingPlace1;
        private System.Windows.Forms.Label lblTradingPlace1;
        private Guna.UI2.WinForms.Guna2TextBox tbCargoName;
        private System.Windows.Forms.Label lblCargo;
        private Guna.UI2.WinForms.Guna2TextBox tbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceCurrency;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.Label lblSellPriceCurrency;
        private Guna.UI2.WinForms.Guna2TextBox tbSellPrice;
        private Guna.UI2.WinForms.Guna2TileButton btnAdd;
        private System.Windows.Forms.Label lblBuying;
        private Guna.UI2.WinForms.Guna2Panel pnlBuying;
        private Guna.UI2.WinForms.Guna2Panel pnlSelling;
        private System.Windows.Forms.Label lblPlanetary2;
        private Guna.UI2.WinForms.Guna2ComboBox cbPlanetary2;
        private System.Windows.Forms.Label lblSelling;
        private Guna.UI2.WinForms.Guna2ComboBox cbTradingPlace2;
        private System.Windows.Forms.Label lblTradingPlace2;
        private Guna.UI2.WinForms.Guna2TileButton btnCalculator;
    }
}