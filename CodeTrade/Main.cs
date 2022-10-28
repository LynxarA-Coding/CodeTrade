using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeTrade
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        public void LoadComplete()
        {
            Dashboard dashboard = new Dashboard() { Owner = this };
            dashboard.TopLevel = false;
            pnlMain.Controls.Add(dashboard);
            dashboard.Deliveries = SetDeliveries();
            dashboard.Show();
        }

        private List<Data.Delivery> SetDeliveries()
        {
            List<Data.Delivery> deliveries = new List<Data.Delivery>();

            StreamReader sr = new StreamReader("deliveries.json");
            string json = sr.ReadToEnd();

            deliveries = JsonConvert.DeserializeObject<List<Data.Delivery>>(json);

            return deliveries;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.Text = "CodeTrade | Загрузка...";
            Loading load = new Loading() { Owner = this };
            load.TopLevel = false;
            pnlMain.Controls.Add(load);
            load.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }

    public class Data
    {
        public struct Delivery
        {
            public int id;
            public string PickupPosName;
            public string GoodsName;
            public string DestinationPosName;
            public string DeliveryDate;
            public int BuyPrice;
            public int SellPrice;
        }

        public List<Delivery> Deliveries = new List<Delivery>();

        public List<Delivery> GetDeliveries()
        {
            return Deliveries;
        }
    }
}
