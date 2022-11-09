using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeTrade.Pages
{
    public partial class PageDeliveries : Form
    {
        public PageDeliveries()
        {
            InitializeComponent();
        }

        public int language = 0;

        public List<Data.Delivery> Deliveries = new List<Data.Delivery>();
        public List<string[]> Locations = new List<string[]>();

        private List<Cargo> ShipCargo = new List<Cargo>();
        private List<Guna2Panel> CargoSquares = new List<Guna2Panel>();

        private int TotalBuyPrice = 0;
        private int TotalSellPrice = 0;

        private void PageDeliveries_Load(object sender, EventArgs e)
        {
            LoadLanguage();
            CalculateTotal();
        }

        private void LoadLanguage()
        {
            lblCargo.Text = language == 1 ? "Название Груза:" : "Cargo Name:";
            tbCargoName.PlaceholderText = language == 1 ? "Введите название товара" : "Enter cargo name";
            tbCargoPrice.PlaceholderText = language == 1 ? "Введите цену товара" : "Enter cargo price";
            btnAddCargo.Text = language == 1 ? "ДОБАВИТЬ ТОВАР НА КОРАБЛЬ" : "ADD CARGO TO SHIP";
            lblBuyTotal.Text = language == 1 ? "Сумма закупки: 0 aUEC" : "Buy total: 0 aUEC";
            lblSellTotal.Text = language == 1 ? "Сумма продажи: 0 aUEC" : "Sell total: 0 aUEC";
            lblFullTotal.Text = language == 1 ? "Итого за поездку: 0 aUEC" : "Trip total: 0 aUEC";
            tbBuyPlace.Text = language == 1 ? "Введите место покупки товара" : "Enter pickup location";
            tbSellPlace.Text = language == 1 ? "Введите место продажи товара" : "Enter dropoff location";
            btnFinish.Text = language == 1 ? "ЗАВЕРШИТЬ ПОЕЗДКУ" : "FINISH TRIP";
            lblCargoTitle.Text = language == 1 ? "Товары на корабле:" : "Cargo on ship:";
        }

        private void CalculateTotal()
        {
            int buytotal = 0;
            int selltotal = 0;

            foreach (Cargo cargo in ShipCargo)
            {
                buytotal += cargo.BuyPrice;
                selltotal += cargo.SellPrice;
            }


            lblBuyTotal.Text = language == 1 ? $"Сумма покупки: {buytotal} aUEC" : $"Buy total: {buytotal} aUEC";
            lblBuyTotal.Location = new Point(pnlStats.Width / 2 - lblBuyTotal.Width / 2, lblBuyTotal.Location.Y);
            lblSellTotal.Text = language == 1 ? $"Сумма продажи: {selltotal} aUEC" : $"Sell total: {selltotal} aUEC";
            lblSellTotal.Location = new Point(pnlStats.Width / 2 - lblSellTotal.Width / 2, lblSellTotal.Location.Y);
            lblFullTotal.Text = language == 1 ? $"Итого за поездку: {selltotal - buytotal} aUEC" : $"Trip total: {selltotal - buytotal} aUEC";
            lblFullTotal.Location = new Point(pnlStats.Width / 2 - lblFullTotal.Width / 2, lblFullTotal.Location.Y);

            if (selltotal - buytotal > 0)
            {
                lblFullTotal.ForeColor = Color.Lime;
            }
            else if (selltotal - buytotal < 0)
            {
                lblFullTotal.ForeColor = Color.Red;
            }
            else
            {
                lblFullTotal.ForeColor = Color.Yellow;
            }

            TotalBuyPrice = buytotal;
            TotalSellPrice = selltotal;
        }

        private void btnAddCargo_Click(object sender, EventArgs e)
        {
            if (tbCargoName.Text.Length > 4 && tbCargoPrice.Text.Length > 0)
            {
                int price = Convert.ToInt32(tbCargoPrice.Text);

                if (price > 0)
                {
                    Cargo newCargo = new Cargo();
                    newCargo.Name = tbCargoName.Text;
                    newCargo.BuyPrice = price;
                    ShipCargo.Add(newCargo);
                    CalculateTotal();

                    Guna2Panel newPanel = new Guna2Panel();
                    newPanel.Name = $"cargo{ShipCargo.Count}";
                    newPanel.Size = new Size(390, 140);

                    newPanel.BorderColor = Color.Black;
                    newPanel.BorderThickness = 3;
                    newPanel.BorderRadius = 10;

                    Label newCargoTitle = new Label();
                    newCargoTitle.AutoSize = true;
                    newCargoTitle.Name = $"cargo{ShipCargo.Count}Title";
                    newCargoTitle.Font = new Font("Calibri", 12, FontStyle.Bold);
                    newCargoTitle.Location = new Point(10, 10);
                    newCargoTitle.Text = language == 1 ? $"Груз: {newCargo.Name}" : $"Cargo: {newCargo.Name}";
                    newPanel.Controls.Add(newCargoTitle);

                    Label newBuyPrice = new Label();
                    newBuyPrice.AutoSize = true;
                    newBuyPrice.Name = $"cargo{ShipCargo.Count}BuyPrice";
                    newBuyPrice.Font = new Font("Calibri", 12, FontStyle.Bold);
                    newBuyPrice.Location = new Point(10, 30);
                    newBuyPrice.Text = language == 1 ? $"Цена покупки: {newCargo.BuyPrice} aUEC" : $"Buy price: {newCargo.BuyPrice} aUEC";
                    newPanel.Controls.Add(newBuyPrice);

                    Label newSellPrice = new Label();
                    newSellPrice.AutoSize = true;
                    newSellPrice.Name = $"cargo{ShipCargo.Count}SellPrice";
                    newSellPrice.Font = new Font("Calibri", 12, FontStyle.Bold);
                    newSellPrice.Location = new Point(10, 50);
                    newSellPrice.Text = language == 1 ? $"Цена продажи: {newCargo.SellPrice} aUEC" : $"Sell price: {newCargo.SellPrice} aUEC";
                    newPanel.Controls.Add(newSellPrice);

                    Guna2TextBox newtbSellPrice = new Guna2TextBox();
                    newtbSellPrice.AutoSize = false;
                    newtbSellPrice.AutoScaleMode = AutoScaleMode.None;
                    newtbSellPrice.Name = $"cargo{ShipCargo.Count}tbSellPrice";
                    newtbSellPrice.Size = new Size(370, 30);
                    newtbSellPrice.Location = new Point(10, 73);
                    newtbSellPrice.ForeColor = Color.Transparent;
                    newtbSellPrice.FillColor = Color.FromArgb(173, 40, 49);
                    newtbSellPrice.PlaceholderText = language == 1 ? "Введите цену продажи" : "Enter sell price";
                    newtbSellPrice.PlaceholderForeColor = Color.Black;
                    newtbSellPrice.BorderColor = Color.Black;
                    newtbSellPrice.BorderRadius = 6;
                    newtbSellPrice.BorderThickness = 1;
                    newtbSellPrice.Font = new Font("Calibri", 10, FontStyle.Bold);
                    newtbSellPrice.TextChanged += new EventHandler(tbSellPrice_TextChanged);
                    newPanel.Controls.Add(newtbSellPrice);

                    Guna2Button newSellButton = new Guna2Button();
                    newSellButton.Name = $"sell{ShipCargo.Count}";
                    newSellButton.Size = new Size(370, 30);
                    newSellButton.Location = new Point(10, 105);
                    newSellButton.Text = language == 1 ? "Продать Товар" : "Sell Cargo";
                    newSellButton.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    newSellButton.FillColor = Color.FromArgb(173, 40, 49);
                    newSellButton.ForeColor = Color.Black;
                    newSellButton.BorderRadius = 6;
                    newSellButton.BorderThickness = 2;
                    newSellButton.BorderColor = Color.Black;
                    newSellButton.Click += new EventHandler(SellButton_Click);
                    newPanel.Controls.Add(newSellButton);

                    pnlCargo.Controls.Add(newPanel);
                    CargoSquares.Add(newPanel);
                }
                else
                {
                    if (language == 1)
                    {
                        MessageBox.Show("Введите цену корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Enter price correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (language == 1)
                {
                    MessageBox.Show("Введите название товара и цену покупки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Enter cargo name and buy price!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void tbCargoPrice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(tbCargoPrice.Text, "[^0-9]"))
            {
                tbCargoPrice.Text = tbCargoPrice.Text.Remove(tbCargoPrice.Text.Length - 1);
            }
        }

        private void tbSellPrice_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox tb = (Guna2TextBox)sender;
            if (System.Text.RegularExpressions.Regex.IsMatch(tb.Text, "[^0-9]"))
            {
                tb.Text = tb.Text.Remove(tb.Text.Length - 1);
            }
        }
        private void tbBuyPlace_TextChanged(object sender, EventArgs e)
        {
            if (tbBuyPlace.Text.Length > 50)
            {
                tbBuyPlace.Text.Remove(50);
            }
        }

        private void tbSellPlace_TextChanged(object sender, EventArgs e)
        {
            if (tbSellPlace.Text.Length > 50)
            {
                tbSellPlace.Text.Remove(50);
            }
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            Guna2Button btn = (Guna2Button)sender;

            int cargoNum = 0;
            Guna2Panel square = null;
            foreach (Guna2Panel data in CargoSquares)
            {
                if (data.Contains(btn))
                {
                    square = data;
                    cargoNum = CargoSquares.IndexOf(data);
                    break;
                }
                cargoNum++;
            }

            if (square != null)
            {
                Guna2TextBox tb = (Guna2TextBox)square.Controls.Find($"cargo{cargoNum + 1}tbSellPrice", true)[0];

                if (tb.Text != "")
                {
                    ShipCargo[cargoNum].SellPrice = Convert.ToInt32(tb.Text);

                    Label lbl = (Label)square.Controls.Find($"cargo{cargoNum + 1}SellPrice", true)[0];
                    lbl.Text = language == 1 ? $"Цена продажи: {ShipCargo[cargoNum].SellPrice} aUEC" : $"Sell price: {ShipCargo[cargoNum].SellPrice} aUEC";
                    square.Size = new Size(390, 90);

                    square.Controls.Remove(tb);
                    square.Controls.Remove(btn);
                    CalculateTotal();
                }
                else
                {
                    if (language == 1)
                    {
                        MessageBox.Show("Введите цену продажи корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Enter sell price correctly!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (CargoSquares.Count == 0 || ShipCargo.Count == 0)
            {
                if (language == 1)
                {
                    MessageBox.Show("Перевезите хотя бы 1 товар!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Add at least 1 cargo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            foreach (Guna2Panel panel in CargoSquares)
            {
                if (panel.Controls.Find($"cargo{CargoSquares.IndexOf(panel) + 1}tbSellPrice", true).Length > 0)
                {
                    if (language == 1)
                    {
                        MessageBox.Show("Пожалуйста установите\nсумму продажи на всех товарах!\n(если товар потерян - ставьте 0)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Please set sell price\non all cargo!\n(if cargo is lost - set 0)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    return;
                }
            }

            if (tbBuyPlace.Text.Length < 5 || tbSellPlace.Text.Length < 5)
            {
                if (language == 1)
                {
                    MessageBox.Show("Пожалуйста введите корректные названия мест покупки!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Please enter correct pickup/dropoff location!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            // Save Delivery
            Data.Delivery delivery = new Data.Delivery();
            delivery.id = Deliveries.Count;
            delivery.PickupPosName = tbBuyPlace.Text;
            delivery.DestinationPosName = tbSellPlace.Text;

            string goods = "";
            foreach (Cargo cargo in ShipCargo)
            {
                goods += $"{cargo.Name},";
            }
            goods = goods.Remove(goods.Length - 1);

            delivery.GoodsName = goods;
            DateTime date = DateTime.Now;
            delivery.DeliveryDate = date.ToString("dd/MM/yyyy");

            delivery.BuyPrice = TotalBuyPrice;
            delivery.SellPrice = TotalSellPrice;

            Deliveries.Add(delivery);
            Dashboard dash = (Dashboard)this.Owner;
            dash.Deliveries = Deliveries;
            dash.SaveDeliveries();

            // Reset Page
            tbCargoName.Text = "";
            tbCargoPrice.Text = "";

            ShipCargo.Clear();
            CalculateTotal();

            foreach (Guna2Panel panel in CargoSquares)
            {
                pnlCargo.Controls.Remove(panel);
            }
            CargoSquares.Clear();

            tbBuyPlace.Text = "";
            tbSellPlace.Text = "";

            if (language == 1)
            {
                MessageBox.Show("Торговая поездка успешно сохранена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Delivery successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }

    public class Cargo
    {
        public string Name { get; set; }
        public int BuyPrice { get; set; }
        public int SellPrice { get; set; }
    }
}
