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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnselfhosting_Click(object sender, EventArgs e)
        {
            string pass =txtpass.Text;
            int id = int.Parse(txtid.Text);
            try
            {
                ServiceReference1.LoginClient login = new ServiceReference1.LoginClient();
                var res=login.Authenticate(id,pass);
                if(res==true)
                MessageBox.Show("Authenciated"); 
                else
                    MessageBox.Show("Not Autheciated");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
