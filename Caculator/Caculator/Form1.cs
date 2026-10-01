using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            double ketQua = a + b;

            txtKetQua.Text = ketQua.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            double ketQua = a - b;

            txtKetQua.Text = ketQua.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            double ketQua = a * b;

            txtKetQua.Text = ketQua.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtA.Text);
            double b = double.Parse(txtB.Text);

            if (b == 0)
            {
                MessageBox.Show("Không thể chia cho 0!");
                return;
            }

            double ketQua = a / b;

            txtKetQua.Text = ketQua.ToString();
        }
    }
}