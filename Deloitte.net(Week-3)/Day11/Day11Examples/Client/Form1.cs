using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnhosting_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtnum1.Text);
            int n1 = int.Parse(txtnum2.Text);
            try
            {
                ServiceReference1.CalculatorClient cc = new ServiceReference1.CalculatorClient();
                var Add = cc.Add(n, n1);
                var Sub = cc.Sub(n, n1);
                MessageBox.Show("Addition:" + Add);
                MessageBox.Show("Subtraction:"+Sub);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnselfhosting_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtnum1.Text);
            int n1 = int.Parse(txtnum2.Text);
            try
            {
                ServiceReference2.CalculatorClient cc = new ServiceReference2.CalculatorClient();
                var Add = cc.Add(n, n1);
                var Sub = cc.Sub(n, n1);
                MessageBox.Show("Addition:" + Add);
                MessageBox.Show("Subtraction:" + Sub);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
