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

        public int language = 0;

        public List<Data.Delivery> Deliveries = new List<Data.Delivery>();

        private void PageLogs_Load(object sender, EventArgs e)
        {
            foreach (Data.Delivery delivery in Deliveries)
            {
                string row = "";
                row += "ID: " + delivery.id + " ";
                row += language == 1 ? "Дата: " + delivery.DeliveryDate + " | " : "Data: " + delivery.DeliveryDate + " | ";
                row += language == 1 ? "Товар: " + delivery.GoodsName + "; " : "Cargo: " + delivery.GoodsName + "; ";
                row += language == 1 ? "Из: \"" + delivery.PickupPosName + "\" " : "From: \"" + delivery.PickupPosName + "\" ";
                row += language == 1 ? " В: \"" + delivery.DestinationPosName + "\"; " : " To: \"" + delivery.DestinationPosName + "\"";
                row += language == 1 ? "Профит: " + (delivery.SellPrice - delivery.BuyPrice) : "Profit: " + (delivery.SellPrice - delivery.BuyPrice);
                row += Environment.NewLine + "--------------------------------------------------------------------------------------------------------------------------------------------" + Environment.NewLine;

                tbLogs.Text += row;
            }
        }
    }
}
