using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public List<Data.Delivery> Deliveries = new List<Data.Delivery>();
        public List<string[]> Locations = new List<string[]>();

        private void PageDeliveries_Load(object sender, EventArgs e)
        {
            cbPlanetary1.SelectedIndex = 0;
            cbTradingPlace1.SelectedIndex = 0;

            cbPlanetary2.SelectedIndex = 0;
            cbTradingPlace2.SelectedIndex = 0;
        }

        private void cbPlanetary_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTradingPlace1.Items.Clear();

            foreach (string location in Locations[cbPlanetary1.SelectedIndex])
            {
                cbTradingPlace1.Items.Add(location);
            }
            
            cbTradingPlace1.SelectedIndex = 0;
        }

        private void cbPlanetary2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbTradingPlace2.Items.Clear();
            
            foreach (string location in Locations[cbPlanetary2.SelectedIndex])
            {
                cbTradingPlace2.Items.Add(location);
            }

            cbTradingPlace2.SelectedIndex = 0;
        }

        private void tbPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbPrice.Text.Length > 0)
            {
                if (!char.IsNumber(tbPrice.Text[tbPrice.Text.Length - 1]))
                {
                    tbPrice.Text = tbPrice.Text.Remove(tbPrice.Text.Length - 1);
                    tbPrice.SelectionStart = tbPrice.Text.Length;
                }
            }
        }

        private void tbSellPrice_TextChanged(object sender, EventArgs e)
        {
            if (tbSellPrice.Text.Length > 0)
            {
                if (!char.IsNumber(tbSellPrice.Text[tbSellPrice.Text.Length - 1]))
                {
                    tbSellPrice.Text = tbSellPrice.Text.Remove(tbSellPrice.Text.Length - 1);
                    tbSellPrice.SelectionStart = tbSellPrice.Text.Length;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbTradingPlace1.SelectedItem == "ВЫБЕРИТЕ ПЛАНЕТАРНУЮ СИСТЕМУ")
            {
                MessageBox.Show("Выберите планетарную систему!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tbPrice.Text.Length == 0 || tbSellPrice.Text.Length == 0 )
            {
                MessageBox.Show("Заполните все поля цен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Data.Delivery delivery = new Data.Delivery();
                delivery.id = Deliveries.Count;
                delivery.PickupPosName = cbTradingPlace1.SelectedItem.ToString();
                delivery.DestinationPosName = cbTradingPlace2.SelectedItem.ToString();
                delivery.GoodsName = tbCargoName.Text;
                delivery.BuyPrice = Convert.ToInt32(tbPrice.Text);
                delivery.SellPrice = Convert.ToInt32(tbSellPrice.Text);
                DateTime date = DateTime.Now;
                delivery.DeliveryDate = date.Day.ToString() + "/" + date.Month.ToString() + "/" + date.Year.ToString();

                Deliveries.Add(delivery);
                Dashboard dash = (Dashboard)this.Owner;
                dash.Deliveries = Deliveries;
                dash.SaveDeliveries();

                MessageBox.Show("Лог успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
