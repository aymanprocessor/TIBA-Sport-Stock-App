using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tibasport_stock_new
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnItemMaster_Click(object sender, EventArgs e)
        {
            itemMaster im = new itemMaster();
            im.Show();
        }

        private void btnAddPermission_Click(object sender, EventArgs e)
        {
            addPermission ap = new addPermission();
            ap.Show();
        }

        private void btnExchangePermission_Click(object sender, EventArgs e)
        {
            exchangePermission ep = new exchangePermission();
            ep.Show();
        }

        private void btnAimTable_Click(object sender, EventArgs e)
        {
            aimTable at = new aimTable();
            at.Show();
        }

        private void btnBalance_Click(object sender, EventArgs e)
        {
            Balance b = new Balance();
            b.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            Client c = new Client();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbSetting dbs = new dbSetting();
            dbs.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {
           
        }
    }
}
