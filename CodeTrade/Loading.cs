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
using CodeTrade.Properties;
using Octokit;

namespace CodeTrade
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private int tick;
        private int language;
        private readonly int AppVersion = 1001002;
        private bool isAppUpToDate = true;

        private async void CheckVersion()
        {
            GitHubClient client = new GitHubClient(new ProductHeaderValue("CodeTrade"));
            IReadOnlyList<Release> releases = await client.Repository.Release.GetAll("LynxarA-Coding", "CodeTrade");
            string latestVersion = releases[0].TagName;
            
            string latestVersionNumber = latestVersion.Substring(latestVersion.IndexOf("-") + 1);
            int latestVersionNumberInt = 0;
            
            latestVersionNumberInt += Convert.ToInt32(latestVersionNumber.Substring(0, latestVersionNumber.IndexOf("."))) * 1000000;
            latestVersionNumber = latestVersionNumber.Substring(latestVersionNumber.IndexOf(".") + 1);

            latestVersionNumberInt += Convert.ToInt32(latestVersionNumber.Substring(0, latestVersionNumber.IndexOf("."))) * 1000;
            latestVersionNumber = latestVersionNumber.Substring(latestVersionNumber.IndexOf(".") + 1);

            latestVersionNumberInt += Convert.ToInt32(latestVersionNumber);
            
            if (AppVersion < latestVersionNumberInt)
            {
                isAppUpToDate = false;
            }
        }

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
            if (Settings.Default["Language"].ToString() == "English")
            {
                language = 0;
                lblLoading.Text = "Loading...";
            }
            else
            {
                language = 1;
                lblLoading.Text = "Загрузка...";
            }
            
            lblLoading.Left = (this.Width - lblLoading.Width) / 2;
            pictureBox1.Left = (this.Width - pictureBox1.Width) / 2;
            pBar.Value = 0;
            loadTimer.Start();
        }

        private void loadTimer_Tick(object sender, EventArgs e)
        {
            if (tick == 30)
            {
                CheckVersion();
                tick++;
                pBar.Value++;
            }
            else if (tick == 65)
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

                if (isAppUpToDate)
                {
                    ((Main)this.Owner).LoadComplete();

                    this.Close();
                }
                else
                {
                    pBar.Visible = false;
                    lblLoading.Visible = false;
                    lblVersionOutdated.Text = language == 1 ? "Ваша версия программы устарела. Обновите программу!" : "Your app version is outdated. Update the program!";
                    lblVersionOutdated.Left = (this.Width - lblVersionOutdated.Width) / 2;
                    lblVersionOutdated.Top = (this.Height - lblVersionOutdated.Height) / 2 - 20;
                    loadTimer.Stop();
                }
            }
        }
    }
}
