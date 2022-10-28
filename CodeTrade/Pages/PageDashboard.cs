using Guna.UI2.WinForms;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using Color = System.Drawing.Color;

namespace CodeTrade.Pages
{
    public partial class PageDashboard : Form
    {
        public PageDashboard()
        {
            InitializeComponent();
        }

        public List<Data.Delivery> Deliveries = new List<Data.Delivery>();
        private List<int> Gains = new List<int>();
        private List<int> Expenses = new List<int>();
        private int total = 0;
        private int totalTemp = 0;

        private int value { get; set; }
        private List<string> dates = new List<string>();

        private List<Guna2Panel> panels = new List<Guna2Panel>();

        private void FillGraph()
        {
            chart1.ScrollMode = ScrollMode.X;
            foreach (Data.Delivery delivery in Deliveries)
            {
                Gains.Add(delivery.SellPrice);
                Expenses.Add(delivery.BuyPrice);
                dates.Add(delivery.DeliveryDate);
            }

            chart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Дата",
                Labels = dates
            });

            chart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Сумма",
                LabelFormatter = value => value + " aUEC"
            });

            chart1.LegendLocation = LiveCharts.LegendLocation.Right;
            chart1.BackColorTransparent = true;

            chart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            series.Add(new LineSeries() { Title = "Прибыль", Values = new ChartValues<int>(Gains) });
            series.Add(new LineSeries() { Title = "Траты", Values = new ChartValues<int>(Expenses) });
            chart1.Series = series;
        }

        private void FillDataSet()
        {
            int counter = 0;

            int last = Deliveries.Count <= 6 ? 0 : Deliveries.Count - 6;
            for (int i = Deliveries.Count - 1; i >= last; i--)
            {
                Data.Delivery delivery = Deliveries[i];
                totalTemp += delivery.SellPrice - delivery.BuyPrice;

                // panel
                Guna2Panel panel = new Guna2Panel();
                panel.BackColor = Color.Transparent;
                panel.BorderColor = Color.Black;
                panel.BorderRadius = 15;
                panel.BorderThickness = 2;
                panel.FillColor = ColorTranslator.FromHtml("#800E13");
                panel.Name = "data" + counter;
                panel.Size = new Size(282, 135);

                // labels
                Label lblId = new Label();
                lblId.AutoSize = true;
                lblId.Font = new Font("Calibri", 10, FontStyle.Bold);
                lblId.Name = "id" + counter;
                lblId.Text = "ID: " + delivery.id + " | Дата: " + delivery.DeliveryDate;
                lblId.Location = new Point(6, 9);
                panel.Controls.Add(lblId);

                Label lblpickup = new Label();
                lblpickup.AutoSize = true;
                lblpickup.Font = new Font("Calibri", 10, FontStyle.Bold);
                lblpickup.Name = "lblpickup" + counter;
                lblpickup.Text = "Место получения: " + delivery.PickupPosName;
                lblpickup.Location = new Point(6, 24);
                panel.Controls.Add(lblpickup);

                Label lbldrop = new Label();
                lbldrop.AutoSize = true;
                lbldrop.Font = new Font("Calibri", 10, FontStyle.Bold);
                lbldrop.Name = "lbldrop" + counter;
                lbldrop.Text = "Место доставки: " + delivery.DestinationPosName;
                lbldrop.Location = new Point(6, 39);
                panel.Controls.Add(lbldrop);

                Label lblcargo = new Label();
                lblcargo.AutoSize = true;
                lblcargo.Font = new Font("Calibri", 10, FontStyle.Bold);
                lblcargo.Name = "lblcargo" + counter;
                lblcargo.Text = "Товар: " + delivery.GoodsName;
                lblcargo.Location = new Point(6, 54);
                panel.Controls.Add(lblcargo);

                Label lblprice = new Label();
                lblprice.AutoSize = true;
                lblprice.Font = new Font("Calibri", 10, FontStyle.Bold);
                lblprice.ForeColor = Color.Red;
                lblprice.Name = "lblprice" + counter;
                lblprice.Text = "Цена покупки: " + delivery.BuyPrice + " aUEC";
                lblprice.Location = new Point(6, 90);
                panel.Controls.Add(lblprice);

                Label lblsell = new Label();
                lblsell.AutoSize = true;
                lblsell.Font = new Font("Calibri", 10, FontStyle.Bold);
                lblsell.ForeColor = Color.Lime;
                lblsell.Name = "lblsell" + counter;
                lblsell.Text = "Цена продажи: " + delivery.SellPrice + " aUEC";
                lblsell.Location = new Point(6, 105);
                panel.Controls.Add(lblsell);

                panels.Add(panel);
                dataSet.Controls.Add(panel);

                counter++;
            }
        }

        private void CalculateTotal()
        {
            if (totalTemp >= 0)
            {
                lblTotalTemp.ForeColor = Color.Lime;
            }
            else
            {
                lblTotalTemp.ForeColor = Color.Red;    
            }

            lblTotalTemp.Text = "Промежуточная прибыль: " + totalTemp + " aUEC";

            foreach (int bought in Expenses)
            {
                total -= bought;
            }

            foreach (int sold in Gains)
            {
                total += sold;
            }

            if (total >= 0)
            {
                lblTotal.ForeColor = Color.Lime;
            }
            else
            {
                lblTotal.ForeColor = Color.Red;
            }

            lblTotal.Text = "Конечная прибыль: " + total + " aUEC";
        }
        private void PageDashboard_Load(object sender, EventArgs e)
        {
            FillGraph();
            FillDataSet();
            CalculateTotal();
        }
    }
}
