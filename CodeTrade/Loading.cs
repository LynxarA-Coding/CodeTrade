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

        private int tick;

        private void CheckJson()
        {
            string documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CodeTrade\\deliveries.json";
            // check if foler exists
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CodeTrade"))
            {
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CodeTrade");
            }
            if (!File.Exists(documents))
            {
                Data data = new Data();
                data.Deliveries = new List<Data.Delivery>();

                string json = JsonConvert.SerializeObject(data.Deliveries, Formatting.Indented);

                File.WriteAllText(documents, json);
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            lblLoading.Left = (this.Width - lblLoading.Width) / 2;
            pictureBox1.Left = (this.Width - pictureBox1.Width) / 2;
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
