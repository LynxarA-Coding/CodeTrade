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
