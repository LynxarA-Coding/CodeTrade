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
    public partial class PageLogs : Form
    {
        public PageLogs()
        {
            InitializeComponent();
        }

        public List<Data.Delivery> Deliveries = new List<Data.Delivery>();

        private void PageLogs_Load(object sender, EventArgs e)
        {
            foreach (Data.Delivery delivery in Deliveries)
            {
                string row = "";
                row += "ID: " + delivery.id + " ";
                row += "Дата: " + delivery.DeliveryDate + " | ";
                row += "Товар: " + delivery.GoodsName + "; ";
                row += "Из: \"" + delivery.PickupPosName + "\" ";
                row += " В: \"" + delivery.DestinationPosName + "\"; ";
                row += "Профит: " + (delivery.SellPrice - delivery.BuyPrice);
                row += Environment.NewLine + "--------------------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

                tbLogs.Text += row;
            }
        }
    }
}
