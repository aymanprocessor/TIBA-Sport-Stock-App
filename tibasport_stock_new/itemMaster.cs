using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tibasport_stock_new.Models;

namespace tibasport_stock_new
{
    public partial class itemMaster : Form
    {

        private common c;
        public itemMaster()
        {
            InitializeComponent();
        }

        private void item_masterBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.item_masterBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tibasport_dbDataSet);

        }

        private void itemMaster_Load(object sender, EventArgs e)
        {
            c = new common();
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.unit' table. You can move, or remove it, as needed.
            this.unitTableAdapter.Fill(this.tibasport_dbDataSet.unit);
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.location' table. You can move, or remove it, as needed.
            this.locationTableAdapter.Fill(this.tibasport_dbDataSet.location);
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.store' table. You can move, or remove it, as needed.
            this.storeTableAdapter.Fill(this.tibasport_dbDataSet.store);
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.size' table. You can move, or remove it, as needed.
            this.sizeTableAdapter.Fill(this.tibasport_dbDataSet.size);
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.color' table. You can move, or remove it, as needed.
            this.colorTableAdapter.Fill(this.tibasport_dbDataSet.color);
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.type' table. You can move, or remove it, as needed.
            this.typeTableAdapter.Fill(this.tibasport_dbDataSet.type);
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.mark' table. You can move, or remove it, as needed.
            this.markTableAdapter.Fill(this.tibasport_dbDataSet.mark);
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.major_gp' table. You can move, or remove it, as needed.
            this.major_gpTableAdapter.Fill(this.tibasport_dbDataSet.major_gp);
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.item_master' table. You can move, or remove it, as needed.
            this.item_masterTableAdapter.Fill(this.tibasport_dbDataSet.item_master);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var tiba = new TibaContext())
                {


                    var item = new ItemMaster()
                    {
                        Code = getCode(),
                        MajorGp = major_gpComboBox.Text,
                        Mark = markComboBox.Text,
                        Type = typeComboBox.Text,
                        Color = colorComboBox.Text,
                        Size = sizeComboBox.Text,
                        Store = storeComboBox.Text,
                        Location = locationComboBox.Text,
                        Unit = unitComboBox.Text,
                        Reorder = reorderTextBox.Text,
                        ItemDesc = getDesc()

                    };

                    var balance = new Models.Balance()
                    {
                        Year = DateTime.Today.Year,
                        Code = getCode(),
                        ItemDesc = getDesc(),
                        Avg = "0",
                        Count = "0",
                        Store = storeComboBox.Text

                    };


                    tiba.ItemMaster.Add(item);
                    tiba.SaveChanges();

                    tiba.Balance.Add(balance);
                    tiba.SaveChanges();
                }
                this.item_masterTableAdapter.Dispose();
                this.item_masterTableAdapter.Fill(this.tibasport_dbDataSet.item_master);

                this.balanceTableAdapter.Dispose();
                this.balanceTableAdapter.Fill(this.tibasport_dbDataSet.balance);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.InnerException.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private string getCode()
        {
            string majorCode, markCode, typeCode, colorCode, sizeCode;

            using (var tiba = new TibaContext())
            {
                majorCode = tiba.MajorGp.Where(s => s.Name == major_gpComboBox.Text).Select(s => s.Id).FirstOrDefault().ToString("00");
                markCode = tiba.Mark.Where(s => s.Name == markComboBox.Text).Select(s => s.Id).FirstOrDefault().ToString("00");
                typeCode = tiba.Type.Where(s => s.Name == typeComboBox.Text).Select(s => s.Id).FirstOrDefault().ToString();
                colorCode = tiba.Color.Where(s => s.Name == colorComboBox.Text).Select(s => s.Id).FirstOrDefault().ToString("00");
                sizeCode = tiba.Size.Where(s => s.Name == sizeComboBox.Text).Select(s => s.Id).FirstOrDefault().ToString();

            }

           
            return sizeCode + "-" + colorCode + "-" + typeCode + "-" + markCode + "-" + majorCode;

        }

        private string getDesc()
        {
            string major, mark, type, color, size;


            major = major_gpComboBox.Text;
            mark = markComboBox.Text;
            type = typeComboBox.Text;
            color = colorComboBox.Text;
            size = sizeComboBox.Text;



            return major + " " + mark + " " + type + " " + color + " " + size;

        }

        private void major_gpComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            codeLabel1.Text = getCode();
            item_descLabel1.Text = getDesc();
        }

        private void markComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            codeLabel1.Text = getCode();
            item_descLabel1.Text = getDesc();
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            codeLabel1.Text = getCode();
            item_descLabel1.Text = getDesc();
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            codeLabel1.Text = getCode();
            item_descLabel1.Text = getDesc();
        }

        private void sizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            codeLabel1.Text = getCode();
            item_descLabel1.Text = getDesc();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedrow = item_masterDataGridView.SelectedRows.OfType<DataGridViewRow>().Where(r => !r.IsNewRow).ToArray();
                using (var tiba = new TibaContext())
                {


                    var record = tiba.ItemMaster.Where(x => x.Id == int.Parse(selectedrow[0].Cells[0].Value.ToString())).First();
                    record.Code = getCode();
                    record.MajorGp = major_gpComboBox.Text;
                    record.Mark = markComboBox.Text;
                    record.Type = typeComboBox.Text;
                    record.Color = colorComboBox.Text;
                    record.Size = sizeComboBox.Text;
                    record.Store = storeComboBox.Text;
                    record.Location = locationComboBox.Text;
                    record.Unit = unitComboBox.Text;
                    record.Reorder = reorderTextBox.Text;
                    record.ItemDesc = getDesc();

                    tiba.SaveChanges();
                    this.item_masterTableAdapter.Dispose();
                    this.item_masterTableAdapter.Fill(this.tibasport_dbDataSet.item_master);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد مسح تلك البيانات ؟","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var selectedrow = item_masterDataGridView.SelectedRows.OfType<DataGridViewRow>().Where(r => !r.IsNewRow).ToArray();
                    using (var tiba = new TibaContext())
                    {

                        foreach (var i in selectedrow)
                        {

                            var record = tiba.ItemMaster.Where(x => x.Id == int.Parse(i.Cells[0].Value.ToString())).First();
                            tiba.ItemMaster.Remove(record);
                        }

 
                        tiba.SaveChanges();
                        this.item_masterTableAdapter.Dispose();
                        this.item_masterTableAdapter.Fill(this.tibasport_dbDataSet.item_master);
                    }
                  
                    c.set_autoinc("item_master", "id", item_masterDataGridView);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.InnerException.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                   
                }
                
            }

        }


        private void item_masterDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Delete)
            {
                btnDelete.PerformClick();
            }
        }
    }
}
