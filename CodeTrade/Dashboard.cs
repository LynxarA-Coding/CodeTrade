using System;
using System.Collections.Generic;
using System.Drawing;
using CodeTrade.Pages;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Newtonsoft.Json;
using CodeTrade.Properties;
using DiscordRPC;

namespace CodeTrade
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private bool MenuState = true;
        private List<Guna2TileButton> TButtons = new List<Guna2TileButton>();
        private int PreviousBtn;
        
        public List<Data.Delivery> Deliveries = new List<Data.Delivery>();
        public List<string[]> Locations = new List<string[]>();

        public int language;
        private DiscordRpcClient client;
        private Timestamps TimeFromStart;
        private readonly string InviteLink = "https://discord.gg/TutC2SzWKU";
        private string RPCText = "";

        private void DiscordUpdateRichPresence()
        {
            client.SetPresence(new RichPresence()
            {
                Details = RPCText,
                State = language == 1 ? "Версия 1.1.1" : "Version 1.1.1",
                Timestamps = TimeFromStart,
                Assets = new Assets()
                {
                    LargeImageKey = "large",
                    LargeImageText = "CodeTrade",
                    SmallImageKey = "small",
                    SmallImageText = "CODΞGaming Corporation | Star Citizen"
                },
                Buttons = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button() {Label = "CODΞGAMING DISCORD", Url = "https://discord.gg/TutC2SzWKU"}
                }
            });
        }

        private void DiscordRichPresence()
        {
            TimeFromStart = Timestamps.Now;
            client = new DiscordRpcClient("1041128482492653718");
            client.Initialize();
            client.SetPresence(new RichPresence()
            {
                Details = RPCText,
                State = language == 1 ? "Версия 1.1.1" : "Version 1.1.1",
                Timestamps = TimeFromStart,
                Assets = new Assets()
                {
                    LargeImageKey = "large",
                    LargeImageText = "CodeTrade",
                    SmallImageKey = "small",
                    SmallImageText = "CODΞGaming Corporation | Star Citizen"
                },
                Buttons = new DiscordRPC.Button[]
                {
                    new DiscordRPC.Button() {Label = "CODΞGAMING DISCORD", Url = "https://discord.gg/TutC2SzWKU"}
                }
            });
        }

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
                    TButtons[PreviousBtn].FillColor = Color.Transparent;
                    PreviousBtn = 1;
                    PageDeliveries page1 = new PageDeliveries() { Owner = this };
                    page1.TopLevel = false;
                    page1.language = language;
                    page1.Deliveries = Deliveries;
                    page1.Locations = Locations;
                    pnlPage.Controls.Add(page1);
                    page1.Show();
                    TButtons[1].FillColor = ColorTranslator.FromHtml("#800E13");
                    Main own1 = (Main)this.Owner;
                    own1.Text = language == 1 ? "CodeTrade | Доставки" : "CodeTrade | Deliveries";
                    own1.lblTitle.Text = language == 1 ? "CODΞTrade | Доставки" : "CODΞTrade | Deliveries";
                    
                    RPCText = language == 1 ? "В торговом путешествии" : "In trade journey";
                    DiscordUpdateRichPresence();
                    
                    break;
                case 2:
                    pnlPage.Controls.Clear();
                    TButtons[PreviousBtn].FillColor = Color.Transparent;
                    PreviousBtn = 2;
                    PageSettings page3 = new PageSettings() { Owner = this };
                    page3.TopLevel = false;
                    pnlPage.Controls.Add(page3);
                    page3.language = language;
                    page3.Show();
                    TButtons[2].FillColor = ColorTranslator.FromHtml("#800E13");
                    Main own3 = (Main)this.Owner;
                    own3.Text = language == 1 ? "CodeTrade | Настройки" : "CodeTrade | Settings";
                    own3.lblTitle.Text = language == 1 ? "CODΞTrade | Настройки" : "CODΞTrade | Settings";
                    
                    RPCText = language == 1 ? "Настраивает программу" : "Configuring the program";
                    DiscordUpdateRichPresence();
                    
                    break;
                default:
                    pnlPage.Controls.Clear();
                    TButtons[PreviousBtn].FillColor = Color.Transparent;
                    PreviousBtn = 0;
                    PageDashboard page = new PageDashboard() { Owner = this };
                    page.TopLevel = false;
                    pnlPage.Controls.Add(page);
                    page.language = language;
                    page.Deliveries = Deliveries;
                    page.Show();
                    TButtons[0].FillColor = ColorTranslator.FromHtml("#800E13");
                    Main own = (Main)this.Owner;
                    own.Text = language == 1 ? "CodeTrade | Панель" : "CodeTrade | Dashboard";
                    own.lblTitle.Text = language == 1 ? "CODΞTrade | Панель" : "CODΞTrade | Dashboard";
                    
                    if (client != null)
                    {
                        RPCText = language == 1 ? "Просматривает Статистику" : "Viewing Statistics";
                        DiscordUpdateRichPresence();
                    }
                    
                    break;
            }
        }

        public void UpdateLanguage()
        {
            btnDashboard.Text = language == 1 ? "ПАНЕЛЬ" : "DASHBOARD";
            btnDeliveries.Text = language == 1 ? "ДОСТАВКИ" : "DELIVERIES";
            btnSettings.Text = language == 1 ? "НАСТРОЙКИ" : "SETTINGS";
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            if (Settings.Default["Language"].ToString() == "Russian")
            {
                language = 1;
            }
            else if (Settings.Default["Language"].ToString() == "English")
            {
                language = 0;
            }
            UpdateLanguage();
            
            TButtons.Clear();
            TButtons.Add(btnDashboard);
            TButtons.Add(btnDeliveries);
            TButtons.Add(btnSettings);

            btnMenuToggle.Top = (pnlMenu.Height - btnMenuToggle.Height) / 2;

            OpenPage(0);

            RPCText = language == 1 ? "Просматривает Статистику" : "Viewing Statistics";
            DiscordRichPresence();
        }

        private void btnToggleMenu_Click(object sender, EventArgs e)
        {
            if (MenuState)
            {
                lblCopyright.Visible = false;
                
                foreach (Guna2TileButton btn in TButtons)
                {
                    btn.Visible = false;
                    btn.Enabled = false;
                }
                
                btnMenuToggle.Image = Properties.Resources.right_arrow;
                pnlMenu.Width = 36;

                MenuState = false;
            }
            else
            {
                btnMenuToggle.Image = Properties.Resources.left_arrow;
                pnlMenu.Width = 195;
                
                lblCopyright.Visible = true;
                
                foreach (Guna2TileButton btn in TButtons)
                {
                    btn.Visible = true;
                    btn.Enabled = true;
                }

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

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (PreviousBtn != 2)
            {
                OpenPage(2);
            }
        }
    }
}
