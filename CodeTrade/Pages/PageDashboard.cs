using Guna.UI2.WinForms;
using LiveCharts;
using LiveCharts.Wpf;
using Octokit;
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
        public int language;

        public List<Data.Delivery> Deliveries = new List<Data.Delivery>();
        private List<int> Gains = new List<int>();
        private List<int> Expenses = new List<int>();
        private int total;
        private int totalTemp;

        private int value { get; set; }
        private List<string> dates = new List<string>();

        private List<Guna2Panel> panels = new List<Guna2Panel>();
        
        private void FillGraph(List<Data.Delivery> tempDeliveries)
        {
            Gains.Clear();
            Expenses.Clear();
            dates.Clear();
            
            chart1.Series.Clear();
            chart1.AxisX.Clear();
            chart1.AxisY.Clear();

            foreach (Data.Delivery delivery in tempDeliveries)
            {
                Gains.Add(delivery.SellPrice);
                Expenses.Add(delivery.BuyPrice);
                dates.Add(delivery.DeliveryDate);
            }

            chart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = language == 1 ? "Дата" : "Date",
                Labels = dates
            });

            chart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = language == 1 ? "Сумма" : "Total",
                LabelFormatter = value => value + " aUEC"
            });

            chart1.LegendLocation = LiveCharts.LegendLocation.Right;
            chart1.BackColorTransparent = true;

            chart1.Series.Clear();
            SeriesCollection series = new SeriesCollection();

            series.Add(new LineSeries() { Title = language == 1 ? "Прибыль" : "Profit", Values = new ChartValues<int>(Gains), LineSmoothness = 0.8});
            series.Add(new LineSeries() { Title = language == 1 ? "Траты" : "Expenses", Values = new ChartValues<int>(Expenses), LineSmoothness = 0.8});
            chart1.Series = series;

            chart1.ScrollMode = ScrollMode.XY;
            chart1.Zoom = ZoomingOptions.Xy;
        }

        private void FillDataSet()
        {
            int counter = 0;
            if (panels.Count > 0)
            {
                foreach (Guna2Panel panel in panels)
                {
                    dataSet.Controls.Remove(panel);
                }

                panels.Clear();
            }

            int delCount = 0;
            int delLast = 0;
            bool isContinue = true;

            if (cbRouteCount.SelectedIndex > 1)
            {
                delCount = Deliveries.Count - 1;
                delLast = Deliveries.Count <= (cbRouteCount.SelectedIndex - 1) ? 0 : Deliveries.Count - (cbRouteCount.SelectedIndex - 1);
            }
            else if (cbRouteCount.SelectedIndex == 1 && tbIdCheck())
            {
                delLast = Convert.ToInt32(tbIdChoice.Text);
                delCount = delLast;
            }
            else if (cbRouteCount.SelectedIndex == 0)
            {
                delCount = Deliveries.Count - 1;
                delLast = 0;
            }
            else
            {
                isContinue = false;
            }
            
            if (isContinue)
            {
                for (int i = delCount; i >= delLast; i--)
                {
                    Data.Delivery delivery = Deliveries[i];
                    totalTemp += delivery.SellPrice - delivery.BuyPrice;

                    Guna2Panel panel = new Guna2Panel();
                    panel.BackColor = Color.Transparent;
                    panel.BorderColor = Color.Black;
                    panel.BorderRadius = 5;
                    panel.BorderThickness = 0;
                    panel.FillColor = ColorTranslator.FromHtml("#800E13");
                    panel.Name = "data" + counter;
                    panel.Size = new Size(282, 135);
                    panel.AutoSize = true;
                    panel.AutoSizeMode = AutoSizeMode.GrowOnly;

                    // labels
                    System.Windows.Forms.Label lblId = new System.Windows.Forms.Label();
                    lblId.AutoSize = true;
                    lblId.Font = new Font("Calibri", 10, FontStyle.Bold);
                    lblId.Name = "id" + counter;
                    lblId.Text = language == 1 ? "ID: " + delivery.id + " | Дата: " + delivery.DeliveryDate : "ID: " + delivery.id + " | Date: " + delivery.DeliveryDate;
                    lblId.Location = new Point(6, 0);
                    panel.Controls.Add(lblId);

                    System.Windows.Forms.Label lblpickup = new System.Windows.Forms.Label();
                    lblpickup.AutoSize = true;
                    lblpickup.Font = new Font("Calibri", 10, FontStyle.Bold);
                    lblpickup.Name = "lblpickup" + counter;
                    lblpickup.Text = language == 1 ? "Место получения: " + delivery.PickupPosName : "Pickup Place: " + delivery.PickupPosName;
                    lblpickup.Location = new Point(6, 20);
                    panel.Controls.Add(lblpickup);

                    System.Windows.Forms.Label lbldrop = new System.Windows.Forms.Label();
                    lbldrop.AutoSize = true;
                    lbldrop.Font = new Font("Calibri", 10, FontStyle.Bold);
                    lbldrop.Name = "lbldrop" + counter;
                    lbldrop.Text = language == 1 ? "Место доставки: " + delivery.DestinationPosName : "Destination Place: " + delivery.DestinationPosName;
                    lbldrop.Location = new Point(6, 40);
                    panel.Controls.Add(lbldrop);

                    System.Windows.Forms.Label lblcargo = new System.Windows.Forms.Label();
                    lblcargo.AutoSize = true;
                    lblcargo.Font = new Font("Calibri", 10, FontStyle.Bold);
                    lblcargo.Name = "lblcargo" + counter;
                    lblcargo.Text = language == 1 ? "Товар: " + delivery.GoodsName : "Goods: " + delivery.GoodsName;
                    lblcargo.Location = new Point(6, 60);
                    panel.Controls.Add(lblcargo);

                    System.Windows.Forms.Label lblprice = new System.Windows.Forms.Label();
                    lblprice.AutoSize = true;
                    lblprice.Font = new Font("Calibri", 10, FontStyle.Bold);
                    lblprice.ForeColor = Color.Red;
                    lblprice.Name = "lblprice" + counter;
                    lblprice.Text = language == 1 ? "Цена покупки: " + delivery.BuyPrice + " aUEC" : "Buy Price: " + delivery.BuyPrice + " aUEC";
                    lblprice.Location = new Point(6, 80);
                    panel.Controls.Add(lblprice);

                    System.Windows.Forms.Label lblsell = new System.Windows.Forms.Label();
                    lblsell.AutoSize = true;
                    lblsell.Font = new Font("Calibri", 10, FontStyle.Bold);
                    lblsell.ForeColor = Color.Lime;
                    lblsell.Name = "lblsell" + counter;
                    lblsell.Text = language == 1 ? "Цена продажи: " + delivery.SellPrice + " aUEC" : "Sell Price: " + delivery.SellPrice + " aUEC";
                    lblsell.Location = new Point(6, 100);

                    panel.Controls.Add(lblsell);

                    panel.Height += 20;

                    panels.Add(panel);
                    dataSet.Controls.Add(panel);

                    counter++;
                }
            }
        }

        private void ChangeLanguageVisuals()
        {
            lblData.Text = language == 1 ? "Последние 5 Маршрутов (всего: 5):" : "Last 5 Routes (total: 5):";
            lblTotalTemp.Text = language == 1 ? "Промежуточная прибыль: 0 aUEC" : "Intermediate profit: 0 aUEC";
            lblTotal.Text = language == 1 ? "Конечная прибыль: 0 aUEC" : "Final profit: 0 aUEC";
            lblChartLoading.Text = language == 1 ? "Загрузка графика..." : "Loading chart...";

            if (language == 1)
            {
                cbRouteCount.Items.Clear();
                cbRouteCount.Items.Add("Показать ВСЕ");
                cbRouteCount.Items.Add("Показать по ID");
                cbRouteCount.Items.Add("Показать: 1");
                cbRouteCount.Items.Add("Показать: 2");
                cbRouteCount.Items.Add("Показать: 3");
                cbRouteCount.Items.Add("Показать: 4");
                cbRouteCount.Items.Add("Показать: 5");
            }
            else
            {
                cbRouteCount.Items.Clear();
                cbRouteCount.Items.Add("Show ALL");
                cbRouteCount.Items.Add("Show by ID");
                cbRouteCount.Items.Add("Show: 1");
                cbRouteCount.Items.Add("Show: 2");
                cbRouteCount.Items.Add("Show: 3");
                cbRouteCount.Items.Add("Show: 4");
                cbRouteCount.Items.Add("Show: 5");
            }
        } 

        private void CalculateTotal()
        {
            int delLast = 0;
            int delFirst = 0;

            if (cbRouteCount.SelectedIndex > 1)
            {
                delLast = cbRouteCount.SelectedIndex;
                delFirst = Deliveries.Count - 1;
            }
            else if (cbRouteCount.SelectedIndex == 1)
            {
                delFirst = Convert.ToInt32(tbIdChoice.Text);
                delLast = delFirst;
            }
            else
            {
                delFirst = Deliveries.Count - 1;
                delLast = 0;
            }

            if (Deliveries.Count > 0)
            {
                totalTemp = 0;
                for (int i = delFirst; i >= delLast; i--)
                {
                    totalTemp += Deliveries[i].SellPrice - Deliveries[i].BuyPrice;
                }


                if (totalTemp >= 0)
                {
                    lblTotalTemp.ForeColor = Color.Lime;
                }
                else
                {
                    lblTotalTemp.ForeColor = Color.Red;
                }

                lblTotalTemp.Text = language == 1 ? "Промежуточная прибыль: " + totalTemp + " aUEC" : "Intermediate profit: " + totalTemp + " aUEC";
                
                total = 0;
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

                lblTotal.Text = language == 1 ? "Конечная прибыль: " + total + " aUEC" : "Final profit: " + total + " aUEC";
            }
        }
        private void PageDashboard_Load(object sender, EventArgs e)
        {
            ChangeLanguageVisuals();
            FillGraph(Deliveries);
            FillDataSet();
            cbRouteCount.SelectedIndex = 2;
            CalculateTotal();
        }

        private void cbRouteCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Deliveries.Count != 0)
            {
                if (cbRouteCount.SelectedIndex > 1 || cbRouteCount.SelectedIndex == 0)
                {
                    tbIdChoice.Enabled = false;
                    tbIdChoice.Visible = false;
                    
                    int amount = Deliveries.Count;

                    while (amount < cbRouteCount.SelectedIndex - 1)
                    {
                        cbRouteCount.SelectedIndex--;
                    }

                    if (language == 1)
                    {
                        switch (cbRouteCount.SelectedIndex)
                        {
                            case 0:
                                lblData.Text = "Все маршруты:";
                                break;
                            case 1:
                                lblData.Text = "Маршрут:";
                                break;
                            case 2:
                                lblData.Text = $"Последний маршрут (всего: {Deliveries.Count}):";
                                break;
                            case 3:
                                lblData.Text = $"Последние 2 маршрута (всего: {Deliveries.Count}):";
                                break;
                            case 4:
                                lblData.Text = $"Последние 3 маршрута (всего: {Deliveries.Count}):";
                                break;
                            case 5:
                                lblData.Text = $"Последние 4 маршрута (всего: {Deliveries.Count}):";
                                break;
                            case 6:
                                lblData.Text = $"Последние 5 маршрутов (всего: {Deliveries.Count}):";
                                break;
                        }
                    }
                    else
                    {
                        if (cbRouteCount.SelectedIndex == 0)
                        {
                            lblData.Text = "All routes:";
                        }
                        else
                        {
                            lblData.Text = $"Last {cbRouteCount.SelectedIndex - 1} Routes (total: {Deliveries.Count}):";
                        }
                    }

                    if (cbRouteCount.SelectedIndex - 1 <= amount)
                    {
                        int lastIndex = 0;
                        if (cbRouteCount.SelectedIndex != 0)
                        {
                            lastIndex = Deliveries.Count - (cbRouteCount.SelectedIndex - 1);
                        }

                        List<Data.Delivery> deliveries = new List<Data.Delivery>();
                        for (int i = Deliveries.Count - 1; i >= lastIndex; i--)
                        {
                            deliveries.Add(Deliveries[i]);
                        }

                        FillGraph(deliveries);
                        FillDataSet();
                        CalculateTotal();
                    }
                }
                else if (cbRouteCount.SelectedIndex == 1)
                {
                    tbIdChoice.Enabled = true;
                    tbIdChoice.Visible = true;

                    lblData.Text = language == 1 ? "Маршрут:" : "Route:";
                }
            }
            else
            {
                lblData.Text = language == 1 ? "Маршруты (0):" : "Routes (0):";
            }
        }

        private bool tbIdCheck()
        {
            if (tbIdChoice.Text != "")
            {
                if (Convert.ToInt32(tbIdChoice.Text) >= 0 && Convert.ToInt32(tbIdChoice.Text) <= Deliveries.Count)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void tbIdChoice_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in tbIdChoice.Text)
            {
                if (!char.IsDigit(c))
                {
                    tbIdChoice.Text = "";
                }
            }
            
            if (tbIdChoice.Text != "")
            {
                int id = Convert.ToInt32(tbIdChoice.Text);
                if (id > Deliveries.Count)
                {
                    tbIdChoice.Text = (Deliveries.Count - 1).ToString();
                    id = Deliveries.Count - 1;
                }
                else if (id < 0)
                {
                    tbIdChoice.Text = "0";
                    id = 0;
                }
                tbIdChoice.SelectionStart = tbIdChoice.Text.Length;

                List<Data.Delivery> deliveries = new List<Data.Delivery>();
                deliveries.Add(Deliveries[id]);

                FillGraph(deliveries);
                FillDataSet();
                CalculateTotal();
            }
        }
    }
}
