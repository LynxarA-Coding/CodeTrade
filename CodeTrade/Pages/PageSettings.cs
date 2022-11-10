using CodeTrade.Properties;
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
    public partial class PageSettings : Form
    {
        public PageSettings()
        {
            InitializeComponent();
        }

        public int language = 0;

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            if (language == 1 ? MessageBox.Show("Вы точно хотите удалить все данные?", "Удаление Данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes : MessageBox.Show("Are you sure you want to delete all data?", "Delete Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dashboard dashboard = (Dashboard)this.Owner;
                List<Data.Delivery> deliveries = new List<Data.Delivery>();
                dashboard.Deliveries = deliveries;
                dashboard.SaveDeliveries();
            }
            
        }

        private void PageSettings_Load(object sender, EventArgs e)
        {
            UpdateLanguage();
        }

        private void UpdateLanguage()
        {
            lblLanguage.Text = language == 1 ? "Язык" : "Language";
            lblDeleteData.Text = language == 1 ? "Удаляет все логированные маршруты за всё время (невозможно восстановить)" : "Deletes all logged routes for all time (cannot be restored)";
            btnDeleteData.Text = language == 1 ? "УДАЛИТЬ ДАННЫЕ" : "DELETE DATA";
            cbLanguage.SelectedIndex = language;
        }

        private void cbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbLanguage.SelectedIndex)
            {
                case 0:
                    language = 0;
                    Dashboard dash = (Dashboard)this.Owner;
                    dash.language = language;
                    dash.UpdateLanguage();
                    Settings.Default["Language"] = "English";
                    Settings.Default.Save();
                    break;
                case 1:
                    language = 1;
                    Dashboard dash1 = (Dashboard)this.Owner;
                    dash1.language = language;
                    dash1.UpdateLanguage();
                    Settings.Default["Language"] = "Russian";
                    Settings.Default.Save();
                    break;
            }
            UpdateLanguage();
        }
    }
}
