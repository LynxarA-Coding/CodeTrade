using System;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeTrade
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private int tick = 0;

        private void CheckJson()
        {
            if (!File.Exists("deliveries.json"))
            {
                Data data = new Data();
                data.Deliveries = new List<Data.Delivery>();

                Random rnd = new Random();
                for (int i = 0; i < 5; i++)
                {
                    Data.Delivery delivery = new Data.Delivery();
                    delivery.id = i;
                    delivery.PickupPosName = "HDMS Bezdek";
                    delivery.GoodsName = "Agricium";
                    delivery.DestinationPosName = "Port Olisar";

                    int day = 10 + i;
                    int month = 5 + i;
                    int year = 2020 + i;
                    delivery.DeliveryDate = day + "/" + month + "/" + year;
                    
                    delivery.BuyPrice = rnd.Next(10000, 5000000);
                    delivery.SellPrice = rnd.Next(10000, 5000000);

                    data.Deliveries.Add(delivery);
                }
                

                string json = JsonConvert.SerializeObject(data.Deliveries, Formatting.Indented);

                File.WriteAllText("deliveries.json", json);
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            lblLoading.Left = (this.Width - lblLoading.Width) / 2;
            pBar.Value = 0;
            loadTimer.Start();
        }

        private void loadTimer_Tick(object sender, EventArgs e)
        {
            if (tick == 50)
            {
                CheckJson();
                tick++;
                pBar.Value++;
            }
            else if (tick < 100)
            {
                tick++;
                pBar.Value++;
            }
            else if (tick >= 100)
            {
                loadTimer.Stop();
                ((Main)this.Owner).LoadComplete();
                this.Close();
            }
        }
    }
}
