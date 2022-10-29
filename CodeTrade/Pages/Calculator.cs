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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        
        private void Calculator_Load(object sender, EventArgs e)
        {
            tbOutput1.Text = sum.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int sum;

        private void tbInput1_TextChanged(object sender, EventArgs e)
        {
            if (tbInput1.Text.Length > 0)
            {
                if (!char.IsNumber(tbInput1.Text[tbInput1.Text.Length - 1]))
                {
                    tbInput1.Text = tbInput1.Text.Remove(tbInput1.Text.Length - 1);
                    tbInput1.SelectionStart = tbInput1.Text.Length;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbInput1.Text.Length > 0)
            {
                sum += Convert.ToInt32(tbInput1.Text);
                tbOutput1.Text = sum.ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            sum = 0;
            tbOutput1.Text = sum.ToString();
            tbInput1.Text = "";
        }

        private void tbBalanceBefore_TextChanged(object sender, EventArgs e)
        {
            if (tbBalanceBefore.Text.Length > 0)
            {
                if (!char.IsNumber(tbBalanceBefore.Text[tbBalanceBefore.Text.Length - 1]))
                {
                    tbBalanceBefore.Text = tbBalanceBefore.Text.Remove(tbBalanceBefore.Text.Length - 1);
                    tbBalanceBefore.SelectionStart = tbBalanceBefore.Text.Length;
                }
            }
        }

        private void tbBalanceAfter_TextChanged(object sender, EventArgs e)
        {
            if (tbBalanceAfter.Text.Length > 0)
            {
                if (!char.IsNumber(tbBalanceAfter.Text[tbBalanceAfter.Text.Length - 1]))
                {
                    tbBalanceAfter.Text = tbBalanceAfter.Text.Remove(tbBalanceAfter.Text.Length - 1);
                    tbBalanceAfter.SelectionStart = tbBalanceAfter.Text.Length;
                }
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (tbBalanceBefore.Text.Length > 0 && tbBalanceAfter.Text.Length > 0)
            {
                tbDifference.Text = Math.Abs(Convert.ToInt32(tbBalanceAfter.Text) - Convert.ToInt32(tbBalanceBefore.Text)).ToString();
            }
        }
    }
}
