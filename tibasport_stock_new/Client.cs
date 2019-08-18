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
    public partial class Client : Form
    {
        private common c;
        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.trans_type' table. You can move, or remove it, as needed.
            this.trans_typeTableAdapter.Fill(this.tibasport_dbDataSet.trans_type);
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.tibasport_dbDataSet.customer);
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.trans_detail' table. You can move, or remove it, as needed.
            this.trans_detailTableAdapter.Fill(this.tibasport_dbDataSet.trans_detail);
            c = new common();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                customerBindingSource.EndEdit();
                customerTableAdapter.Update(this.tibasport_dbDataSet.customer);
                c.set_autoinc("customer", "Id", dgViewCustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("تم عملية الحفظ بنجاح", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Cursor.Current = Cursors.Default;


        }
    }
}
