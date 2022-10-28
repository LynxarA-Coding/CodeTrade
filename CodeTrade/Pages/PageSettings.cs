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

        private void btnDeleteData_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить все данные?", "Удаление Данных", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Dashboard dashboard = (Dashboard)this.Owner;
                List<Data.Delivery> deliveries = new List<Data.Delivery>();
                dashboard.Deliveries = deliveries;
                dashboard.SaveDeliveries();
            }
            
        }
    }
}
