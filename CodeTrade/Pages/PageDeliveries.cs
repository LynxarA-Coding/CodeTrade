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
    public partial class PageDeliveries : Form
    {
        public PageDeliveries()
        {
            InitializeComponent();
        }

        public List<Data.Delivery> Deliveries = new List<Data.Delivery>();

        private void PageDeliveries_Load(object sender, EventArgs e)
        {
            
        }
    }
}
