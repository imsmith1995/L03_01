using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L03_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtSales.Text = string.Empty;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string displayName = txtName.Text;

            double calnum = Convert.ToDouble(txtSales.Text);
            double commision = calnum * 0.02;
            var displayCommision = commision;

            MessageBox.Show(
                    String.Format(
                    $"Your commission is {commision:C}."),
                    $"{displayName}'s Commission",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
        }

        private void lblSales_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
