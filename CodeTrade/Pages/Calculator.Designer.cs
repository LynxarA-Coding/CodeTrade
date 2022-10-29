namespace CodeTrade.Pages
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.dragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbInput1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblInput1 = new System.Windows.Forms.Label();
            this.lblCurrency1 = new System.Windows.Forms.Label();
            this.tbOutput1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCurrency2 = new System.Windows.Forms.Label();
            this.lblOutput1 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2TileButton();
            this.btnReset = new Guna.UI2.WinForms.Guna2TileButton();
            this.tbBalanceBefore = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbBalanceAfter = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblBalanceBefore = new System.Windows.Forms.Label();
            this.lblCurrencyBefore = new System.Windows.Forms.Label();
            this.lblCurrencyAfter = new System.Windows.Forms.Label();
            this.lblBalanceAfter = new System.Windows.Forms.Label();
            this.btnCalculate = new Guna.UI2.WinForms.Guna2TileButton();
            this.tbDifference = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDifference = new System.Windows.Forms.Label();
            this.lblDifferenceCurrency = new System.Windows.Forms.Label();
            this.pnlDivider = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderColor = System.Drawing.Color.Black;
            this.pnlHeader.BorderThickness = 3;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Controls.Add(this.btnClose);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.ShadowDecoration.Parent = this.pnlHeader;
            this.pnlHeader.Size = new System.Drawing.Size(775, 59);
            this.pnlHeader.TabIndex = 0;
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.pnlHeader;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::CodeTrade.Properties.Resources.cancel;
            this.btnClose.Location = new System.Drawing.Point(728, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(12, 12);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(162, 33);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Калькулятор";
            // 
            // tbInput1
            // 
            this.tbInput1.BorderColor = System.Drawing.Color.Black;
            this.tbInput1.BorderRadius = 6;
            this.tbInput1.BorderThickness = 3;
            this.tbInput1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbInput1.DefaultText = "";
            this.tbInput1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbInput1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbInput1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbInput1.DisabledState.Parent = this.tbInput1;
            this.tbInput1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbInput1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbInput1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.tbInput1.FocusedState.Parent = this.tbInput1;
            this.tbInput1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput1.ForeColor = System.Drawing.Color.Black;
            this.tbInput1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.tbInput1.HoverState.Parent = this.tbInput1;
            this.tbInput1.Location = new System.Drawing.Point(18, 93);
            this.tbInput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.PasswordChar = '\0';
            this.tbInput1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbInput1.PlaceholderText = "";
            this.tbInput1.SelectedText = "";
            this.tbInput1.ShadowDecoration.Parent = this.tbInput1;
            this.tbInput1.Size = new System.Drawing.Size(298, 49);
            this.tbInput1.TabIndex = 1;
            this.tbInput1.TextChanged += new System.EventHandler(this.tbInput1_TextChanged);
            // 
            // lblInput1
            // 
            this.lblInput1.AutoSize = true;
            this.lblInput1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput1.Location = new System.Drawing.Point(13, 63);
            this.lblInput1.Name = "lblInput1";
            this.lblInput1.Size = new System.Drawing.Size(73, 26);
            this.lblInput1.TabIndex = 2;
            this.lblInput1.Text = "Число:";
            // 
            // lblCurrency1
            // 
            this.lblCurrency1.AutoSize = true;
            this.lblCurrency1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency1.Location = new System.Drawing.Point(323, 104);
            this.lblCurrency1.Name = "lblCurrency1";
            this.lblCurrency1.Size = new System.Drawing.Size(57, 26);
            this.lblCurrency1.TabIndex = 2;
            this.lblCurrency1.Text = "aUEC";
            // 
            // tbOutput1
            // 
            this.tbOutput1.BorderColor = System.Drawing.Color.Black;
            this.tbOutput1.BorderRadius = 6;
            this.tbOutput1.BorderThickness = 3;
            this.tbOutput1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbOutput1.DefaultText = "";
            this.tbOutput1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbOutput1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbOutput1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOutput1.DisabledState.Parent = this.tbOutput1;
            this.tbOutput1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbOutput1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbOutput1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.tbOutput1.FocusedState.Parent = this.tbOutput1;
            this.tbOutput1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbOutput1.ForeColor = System.Drawing.Color.Black;
            this.tbOutput1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.tbOutput1.HoverState.Parent = this.tbOutput1;
            this.tbOutput1.Location = new System.Drawing.Point(18, 235);
            this.tbOutput1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbOutput1.Name = "tbOutput1";
            this.tbOutput1.PasswordChar = '\0';
            this.tbOutput1.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbOutput1.PlaceholderText = "";
            this.tbOutput1.ReadOnly = true;
            this.tbOutput1.SelectedText = "";
            this.tbOutput1.ShadowDecoration.Parent = this.tbOutput1;
            this.tbOutput1.Size = new System.Drawing.Size(298, 49);
            this.tbOutput1.TabIndex = 1;
            // 
            // lblCurrency2
            // 
            this.lblCurrency2.AutoSize = true;
            this.lblCurrency2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrency2.Location = new System.Drawing.Point(323, 248);
            this.lblCurrency2.Name = "lblCurrency2";
            this.lblCurrency2.Size = new System.Drawing.Size(57, 26);
            this.lblCurrency2.TabIndex = 2;
            this.lblCurrency2.Text = "aUEC";
            // 
            // lblOutput1
            // 
            this.lblOutput1.AutoSize = true;
            this.lblOutput1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput1.Location = new System.Drawing.Point(13, 205);
            this.lblOutput1.Name = "lblOutput1";
            this.lblOutput1.Size = new System.Drawing.Size(104, 26);
            this.lblOutput1.TabIndex = 2;
            this.lblOutput1.Text = "Результат:";
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
            this.btnAdd.Location = new System.Drawing.Point(18, 149);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(298, 43);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "ДОБАВИТЬ";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReset
            // 
            this.btnReset.BorderRadius = 6;
            this.btnReset.BorderThickness = 2;
            this.btnReset.CheckedState.Parent = this.btnReset;
            this.btnReset.CustomImages.Parent = this.btnReset;
            this.btnReset.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.HoverState.Parent = this.btnReset;
            this.btnReset.Location = new System.Drawing.Point(18, 291);
            this.btnReset.Name = "btnReset";
            this.btnReset.ShadowDecoration.Parent = this.btnReset;
            this.btnReset.Size = new System.Drawing.Size(298, 43);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "СБРОС";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // tbBalanceBefore
            // 
            this.tbBalanceBefore.BorderColor = System.Drawing.Color.Black;
            this.tbBalanceBefore.BorderRadius = 6;
            this.tbBalanceBefore.BorderThickness = 3;
            this.tbBalanceBefore.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBalanceBefore.DefaultText = "";
            this.tbBalanceBefore.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBalanceBefore.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBalanceBefore.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBalanceBefore.DisabledState.Parent = this.tbBalanceBefore;
            this.tbBalanceBefore.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBalanceBefore.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbBalanceBefore.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.tbBalanceBefore.FocusedState.Parent = this.tbBalanceBefore;
            this.tbBalanceBefore.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBalanceBefore.ForeColor = System.Drawing.Color.Black;
            this.tbBalanceBefore.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.tbBalanceBefore.HoverState.Parent = this.tbBalanceBefore;
            this.tbBalanceBefore.Location = new System.Drawing.Point(404, 93);
            this.tbBalanceBefore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBalanceBefore.Name = "tbBalanceBefore";
            this.tbBalanceBefore.PasswordChar = '\0';
            this.tbBalanceBefore.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbBalanceBefore.PlaceholderText = "";
            this.tbBalanceBefore.SelectedText = "";
            this.tbBalanceBefore.ShadowDecoration.Parent = this.tbBalanceBefore;
            this.tbBalanceBefore.Size = new System.Drawing.Size(298, 49);
            this.tbBalanceBefore.TabIndex = 1;
            this.tbBalanceBefore.TextChanged += new System.EventHandler(this.tbBalanceBefore_TextChanged);
            // 
            // tbBalanceAfter
            // 
            this.tbBalanceAfter.BorderColor = System.Drawing.Color.Black;
            this.tbBalanceAfter.BorderRadius = 6;
            this.tbBalanceAfter.BorderThickness = 3;
            this.tbBalanceAfter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbBalanceAfter.DefaultText = "";
            this.tbBalanceAfter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbBalanceAfter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbBalanceAfter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBalanceAfter.DisabledState.Parent = this.tbBalanceAfter;
            this.tbBalanceAfter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbBalanceAfter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbBalanceAfter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.tbBalanceAfter.FocusedState.Parent = this.tbBalanceAfter;
            this.tbBalanceAfter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBalanceAfter.ForeColor = System.Drawing.Color.Black;
            this.tbBalanceAfter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.tbBalanceAfter.HoverState.Parent = this.tbBalanceAfter;
            this.tbBalanceAfter.Location = new System.Drawing.Point(404, 182);
            this.tbBalanceAfter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBalanceAfter.Name = "tbBalanceAfter";
            this.tbBalanceAfter.PasswordChar = '\0';
            this.tbBalanceAfter.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbBalanceAfter.PlaceholderText = "";
            this.tbBalanceAfter.SelectedText = "";
            this.tbBalanceAfter.ShadowDecoration.Parent = this.tbBalanceAfter;
            this.tbBalanceAfter.Size = new System.Drawing.Size(298, 49);
            this.tbBalanceAfter.TabIndex = 1;
            this.tbBalanceAfter.TextChanged += new System.EventHandler(this.tbBalanceAfter_TextChanged);
            // 
            // lblBalanceBefore
            // 
            this.lblBalanceBefore.AutoSize = true;
            this.lblBalanceBefore.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceBefore.Location = new System.Drawing.Point(399, 63);
            this.lblBalanceBefore.Name = "lblBalanceBefore";
            this.lblBalanceBefore.Size = new System.Drawing.Size(279, 26);
            this.lblBalanceBefore.TabIndex = 2;
            this.lblBalanceBefore.Text = "Баланс до покупки/продажи:";
            // 
            // lblCurrencyBefore
            // 
            this.lblCurrencyBefore.AutoSize = true;
            this.lblCurrencyBefore.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyBefore.Location = new System.Drawing.Point(709, 104);
            this.lblCurrencyBefore.Name = "lblCurrencyBefore";
            this.lblCurrencyBefore.Size = new System.Drawing.Size(57, 26);
            this.lblCurrencyBefore.TabIndex = 2;
            this.lblCurrencyBefore.Text = "aUEC";
            // 
            // lblCurrencyAfter
            // 
            this.lblCurrencyAfter.AutoSize = true;
            this.lblCurrencyAfter.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrencyAfter.Location = new System.Drawing.Point(709, 195);
            this.lblCurrencyAfter.Name = "lblCurrencyAfter";
            this.lblCurrencyAfter.Size = new System.Drawing.Size(57, 26);
            this.lblCurrencyAfter.TabIndex = 2;
            this.lblCurrencyAfter.Text = "aUEC";
            // 
            // lblBalanceAfter
            // 
            this.lblBalanceAfter.AutoSize = true;
            this.lblBalanceAfter.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalanceAfter.Location = new System.Drawing.Point(399, 152);
            this.lblBalanceAfter.Name = "lblBalanceAfter";
            this.lblBalanceAfter.Size = new System.Drawing.Size(309, 26);
            this.lblBalanceAfter.TabIndex = 2;
            this.lblBalanceAfter.Text = "Баланс после покупки/продажи:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BorderRadius = 6;
            this.btnCalculate.BorderThickness = 2;
            this.btnCalculate.CheckedState.Parent = this.btnCalculate;
            this.btnCalculate.CustomImages.Parent = this.btnCalculate;
            this.btnCalculate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.Black;
            this.btnCalculate.HoverState.Parent = this.btnCalculate;
            this.btnCalculate.Location = new System.Drawing.Point(404, 238);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.ShadowDecoration.Parent = this.btnCalculate;
            this.btnCalculate.Size = new System.Drawing.Size(298, 43);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "ПОДСЧИТАТЬ РАЗНИЦУ";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // tbDifference
            // 
            this.tbDifference.BorderColor = System.Drawing.Color.Black;
            this.tbDifference.BorderRadius = 6;
            this.tbDifference.BorderThickness = 3;
            this.tbDifference.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbDifference.DefaultText = "";
            this.tbDifference.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbDifference.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbDifference.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDifference.DisabledState.Parent = this.tbDifference;
            this.tbDifference.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbDifference.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.tbDifference.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.tbDifference.FocusedState.Parent = this.tbDifference;
            this.tbDifference.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDifference.ForeColor = System.Drawing.Color.Black;
            this.tbDifference.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(14)))), ((int)(((byte)(19)))));
            this.tbDifference.HoverState.Parent = this.tbDifference;
            this.tbDifference.Location = new System.Drawing.Point(404, 330);
            this.tbDifference.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDifference.Name = "tbDifference";
            this.tbDifference.PasswordChar = '\0';
            this.tbDifference.PlaceholderForeColor = System.Drawing.Color.Black;
            this.tbDifference.PlaceholderText = "";
            this.tbDifference.ReadOnly = true;
            this.tbDifference.SelectedText = "";
            this.tbDifference.ShadowDecoration.Parent = this.tbDifference;
            this.tbDifference.Size = new System.Drawing.Size(298, 49);
            this.tbDifference.TabIndex = 1;
            // 
            // lblDifference
            // 
            this.lblDifference.AutoSize = true;
            this.lblDifference.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifference.Location = new System.Drawing.Point(399, 300);
            this.lblDifference.Name = "lblDifference";
            this.lblDifference.Size = new System.Drawing.Size(93, 26);
            this.lblDifference.TabIndex = 2;
            this.lblDifference.Text = "Разница:";
            // 
            // lblDifferenceCurrency
            // 
            this.lblDifferenceCurrency.AutoSize = true;
            this.lblDifferenceCurrency.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDifferenceCurrency.Location = new System.Drawing.Point(709, 343);
            this.lblDifferenceCurrency.Name = "lblDifferenceCurrency";
            this.lblDifferenceCurrency.Size = new System.Drawing.Size(57, 26);
            this.lblDifferenceCurrency.TabIndex = 2;
            this.lblDifferenceCurrency.Text = "aUEC";
            // 
            // pnlDivider
            // 
            this.pnlDivider.BackColor = System.Drawing.Color.Black;
            this.pnlDivider.Location = new System.Drawing.Point(388, 55);
            this.pnlDivider.Name = "pnlDivider";
            this.pnlDivider.Size = new System.Drawing.Size(2, 345);
            this.pnlDivider.TabIndex = 5;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(775, 398);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblDifferenceCurrency);
            this.Controls.Add(this.lblCurrency2);
            this.Controls.Add(this.lblCurrencyAfter);
            this.Controls.Add(this.lblCurrencyBefore);
            this.Controls.Add(this.lblCurrency1);
            this.Controls.Add(this.lblDifference);
            this.Controls.Add(this.lblOutput1);
            this.Controls.Add(this.lblBalanceAfter);
            this.Controls.Add(this.lblBalanceBefore);
            this.Controls.Add(this.lblInput1);
            this.Controls.Add(this.tbDifference);
            this.Controls.Add(this.tbOutput1);
            this.Controls.Add(this.tbBalanceAfter);
            this.Controls.Add(this.tbBalanceBefore);
            this.Controls.Add(this.tbInput1);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlDivider);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Calculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CODΞTrade | Калькулятор";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2DragControl dragControl;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblInput1;
        private Guna.UI2.WinForms.Guna2TextBox tbInput1;
        private System.Windows.Forms.Label lblCurrency1;
        private Guna.UI2.WinForms.Guna2TextBox tbOutput1;
        private System.Windows.Forms.Label lblCurrency2;
        private System.Windows.Forms.Label lblOutput1;
        private Guna.UI2.WinForms.Guna2TileButton btnAdd;
        private Guna.UI2.WinForms.Guna2TileButton btnReset;
        private Guna.UI2.WinForms.Guna2TextBox tbBalanceBefore;
        private Guna.UI2.WinForms.Guna2TextBox tbBalanceAfter;
        private System.Windows.Forms.Label lblCurrencyBefore;
        private System.Windows.Forms.Label lblBalanceBefore;
        private System.Windows.Forms.Label lblCurrencyAfter;
        private Guna.UI2.WinForms.Guna2TileButton btnCalculate;
        private System.Windows.Forms.Label lblBalanceAfter;
        private System.Windows.Forms.Label lblDifferenceCurrency;
        private System.Windows.Forms.Label lblDifference;
        private Guna.UI2.WinForms.Guna2TextBox tbDifference;
        private System.Windows.Forms.Panel pnlDivider;
    }
}