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
            dashboard.Locations = SetLocations();
            dashboard.Show();
        }

        private List<string[]> SetLocations()
        {
            List<string[]> locations = new List<string[]>();
            locations.Clear();

            string[] arcs = 
            { 
                "ARC-L1 | Admin",
                "ARC-L1 | Ref. Center",
                "ARC-L2 | Admin",
                "ARC-L2 | Ref. Center",
                "ARC-L3 | Admin",
                "ARC-L4 | Admin",
                "ARC-L4 | Ref. Center",
                "ARC-L5 | Admin"
            };
            locations.Add(arcs);

            string[] arccorp =
            {
                "Area 18 | Admin",
                "Area 18 | TDD",
                "Baijini Point | Admin",
                "Lyria | Humboldt Mines",
                "Lyria | LMR",
                "Lyria | Paradise Core",
                "Lyria | SMF SAL 2",
                "Lyria | SMF SAL 5",
                "Lyria | Orphanage",
                "Wala | AMA 045",
                "Wala | AMA 048",
                "Wala | AMA 056",
                "Wala | AMA 061",
                "Wala | S&S Salvage Center",
                "Wala | SG Farms"
            };
            locations.Add(arccorp);

            string[] cru =
            {
                "CRU-L1 | Admin",
                "CRU-L1 | Ref. Center",
                "CRU-L4 | Admin",
                "CRU-L4 | NQA Console",
                "CRU-L5 | Admin",
                "CRU-L5 | NQA Console"
            };
            locations.Add(cru);

            string[] crusader =
            {
                "Cellin | Gallete FF",
                "Cellin | Hickes RO",
                "Cellin | Private Property",
                "Cellin | Terra Mills HF",
                "Cellin | T&M Mining",
                "Daymar | AMA 141",
                "Daymar | Bountiful HH",
                "Daymar | Brios BY",
                "Daymar | Kudre Ore",
                "Daymar | Nuen WM",
                "Daymar | SMF SCD 1",
                "Orison | Admin",
                "Orison | TDD",
                "Port Olisar | Admin",
                "Yela | AMA 157",
                "Yela | Benson MO",
                "Yela | Deakins RO",
                "Yela | Jumptown",
                "Yela | NT 999 XX",
                "GrimHex | Admin"
            };
            locations.Add(crusader);

            string[] hur =
            {
                "HUR-L1 | Admin",
                "HUR-L1 | Ref. Center",
                "HUR-L2 | Admin",
                "HUR-L2 | Ref. Center",
                "HUR-L3 | Admin",
                "HUR-L4 | Admin",
                "HUR-L5 | Admin",
            };
            locations.Add(hur);

            string[] hurston =
            {
                "Aberdeen | HDMS Anderson",
                "Aberdeen | HDMS Norgaard",
                "Arial | HDMS Bezdek",
                "Arial | HDMS Lathan",
                "Everus Harbor | Admin",
                "Hurston | HDMS Edmond",
                "Hurston | HDMS Hadley",
                "Hurston | HDMS Oparei",
                "Hurston | HDMS Pinewood",
                "Hurston | HDMS Stanhope",
                "Hurston | HDMS Thedus",
                "Ita | HDMS Ryder",
                "Ita | HDMS Woordruff",
                "Lorville | Admin",
                "Lorville | TDD",
                "Magda | HDMS Hahn",
                "Magda | HDMS Perlman",
                "Hurston | R&DO"
            };
            locations.Add(hurston);

            string[] microtech =
            {
                "MIC-L1 | Admin",
                "MIC-L1 | Ref. Center",
                "MIC-L2 | Admin",
                "MIC-L2 | Ref. Center",
                "MIC-L3 | Admin",
                "MIC-L4 | Admin",
                "MIC-L5 | Admin",
                "MIC-L5 | Ref. Center",
                "Calliope | Ravens Roost",
                "Calliope | RAR Outpost",
                "Calliope | RKR Outpost",
                "Calliope | SMF SMCa 6",
                "Calliope | SMF SMCa 8",
                "Clio | RCR Outpost",
                "Clio | RMR Outpost",
                "Euterpe | Buds Growery",
                "Euterpe | Delvin S&S",
                "New Babbage | Admin",
                "New Babbage | TDD",
                "Port Tressler | Admin",
                "Microtech | Outpost 54",
                "Microtech | RDR Outpost",
                "Microtech | SMF SM0 10",
                "Microtech | SMF SM0 13",
                "Microtech | SMF SM0 18",
                "Microtech | SMF SM0 22",
                "Microtech | The Necropolis"
            };
            locations.Add(microtech);

            return locations;
        }

        private List<Data.Delivery> SetDeliveries()
        {
            List<Data.Delivery> deliveries;

            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CodeTrade\\deliveries.json";
            StreamReader sr = new StreamReader(path);
            string json = sr.ReadToEnd();
            sr.Close();
            sr.Dispose();

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

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    public class Data
    {
        public struct Delivery
        {
            public int id;
            public string PickupPosName;
            public string DestinationPosName;
            public string GoodsName;
            public string DeliveryDate;
            public int BuyPrice;
            public int SellPrice;
        }

        public List<Delivery> Deliveries = new List<Delivery>();
        public List<string[]> Locations = new List<string[]>();

        public List<Delivery> GetDeliveries()
        {
            return Deliveries;
        }
    }
}
