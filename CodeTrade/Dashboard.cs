using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeTrade.Pages;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Newtonsoft.Json;
using Guna.UI2.WinForms.Helpers;
using System.Windows.Markup;

namespace CodeTrade
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private bool MenuState = true;
        private List<Guna2TileButton> Buttons = new List<Guna2TileButton>();
        private int PreviousBtn = 0;

        public List<Data.Delivery> Deliveries = new List<Data.Delivery>();
        public List<string[]> Locations = new List<string[]>();

        public void SaveDeliveries()
        {
            string json = JsonConvert.SerializeObject(Deliveries, Formatting.Indented);
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\CodeTrade\\deliveries.json";

            if (System.IO.File.Exists(path))
            {
                System.IO.File.Delete(path);
            }

            System.IO.File.WriteAllText(path, json);
        }

        private void OpenPage(int pagenum)
        {
            switch (pagenum)
            {
                case 1:
                    pnlPage.Controls.Clear();
                    Buttons[PreviousBtn].FillColor = Color.Transparent;
                    PreviousBtn = 1;
                    PageDeliveries page1 = new PageDeliveries() { Owner = this };
                    page1.TopLevel = false;
                    page1.Deliveries = Deliveries;
                    page1.Locations = Locations;
                    pnlPage.Controls.Add(page1);
                    page1.Show();
                    Buttons[1].FillColor = ColorTranslator.FromHtml("#800E13");
                    Main own1 = (Main)this.Owner;
                    own1.Text = "CodeTrade | Доставки";
                    own1.lblTitle.Text = "CODΞTrade | Доставки";
                    break;
                case 2:
                    pnlPage.Controls.Clear();
                    Buttons[PreviousBtn].FillColor = Color.Transparent;
                    PreviousBtn = 2;
                    PageLogs page2 = new PageLogs() { Owner = this };
                    page2.TopLevel = false;
                    pnlPage.Controls.Add(page2);
                    page2.Deliveries = Deliveries;
                    page2.Show();
                    Buttons[2].FillColor = ColorTranslator.FromHtml("#800E13");
                    Main own2 = (Main)this.Owner;
                    own2.Text = "CodeTrade | Логи";
                    own2.lblTitle.Text = "CODΞTrade | Логи";
                    break;
                case 3:
                    pnlPage.Controls.Clear();
                    Buttons[PreviousBtn].FillColor = Color.Transparent;
                    PreviousBtn = 3;
                    PageSettings page3 = new PageSettings() { Owner = this };
                    page3.TopLevel = false;
                    pnlPage.Controls.Add(page3);
                    page3.Show();
                    Buttons[3].FillColor = ColorTranslator.FromHtml("#800E13");
                    Main own3 = (Main)this.Owner;
                    own3.Text = "CodeTrade | Настройки";
                    own3.lblTitle.Text = "CODΞTrade | Настройки";
                    break;
                default:
                    pnlPage.Controls.Clear();
                    Buttons[PreviousBtn].FillColor = Color.Transparent;
                    PreviousBtn = 0;
                    PageDashboard page = new PageDashboard() { Owner = this };
                    page.TopLevel = false;
                    pnlPage.Controls.Add(page);
                    page.Deliveries = Deliveries;
                    page.Show();
                    Buttons[0].FillColor = ColorTranslator.FromHtml("#800E13");
                    Main own = (Main)this.Owner;
                    own.Text = "CodeTrade | Панель";
                    own.lblTitle.Text = "CODΞTrade | Панель";
                    break;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            Buttons.Clear();
            Buttons.Add(btnDashboard);
            Buttons.Add(btnDeliveries);
            Buttons.Add(btnLogs);
            Buttons.Add(btnSettings);

            btnMenuToggle.Top = (pnlMenu.Height - btnMenuToggle.Height) / 2;

            OpenPage(0);
        }

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            if (MenuState)
            {
                lblCopyright.Visible = false;
                btnMenuToggle.Image = Properties.Resources.right_arrow;
                menuTransition.MaxAnimationTime = 1500;
                menuTransition.HideSync(pnlMenu);
                menuTransition.MaxAnimationTime = 0;
                pnlMenu.Width = 40;
                menuTransition.ShowSync(pnlMenu);

                foreach (Guna2TileButton btn in Buttons)
                {
                    btn.Visible = false;
                    btn.Enabled = false;
                }

                MenuState = false;
            }
            else
            {
                foreach (Guna2TileButton btn in Buttons)
                {
                    btn.Visible = true;
                    btn.Enabled = true;
                }

                lblCopyright.Visible = true;

                btnMenuToggle.Image = Properties.Resources.left_arrow;
                menuTransition.MaxAnimationTime = 0;
                menuTransition.HideSync(pnlMenu);
                pnlMenu.Width = 195;

                menuTransition.MaxAnimationTime = 1500;
                menuTransition.ShowSync(pnlMenu);

                MenuState = true;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (PreviousBtn != 0)
            {
                OpenPage(0);
            }
        }

        private void btnDeliveries_Click(object sender, EventArgs e)
        {
            if (PreviousBtn != 1)
            {
                OpenPage(1);
            }
        }

        private void btnLogs_Click(object sender, EventArgs e)
        {
            if (PreviousBtn != 2)
            {
                OpenPage(2);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (PreviousBtn != 3)
            {
                OpenPage(3);
            }
        }
    }
}
