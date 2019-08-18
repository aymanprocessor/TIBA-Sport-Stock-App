using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tibasport_stock_new
{
    public partial class aimTable : Form
    {
        public aimTable()
        {
            InitializeComponent();
        }

        private void major_gpBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void aimTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.trans_type' table. You can move, or remove it, as needed.
            this.trans_typeTableAdapter.Fill(this.tibasport_dbDataSet.trans_type);
            // TODO: This line of code loads data into the 'tibasport_dbDataSet.trans_type' table. You can move, or remove it, as needed.
            this.trans_typeTableAdapter.Fill(this.tibasport_dbDataSet.trans_type);
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

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                switch (tabControl.SelectedTab.Text)
                {
                    case "المجموعة الرئيسية":
                        majorgpBindingSource.EndEdit();
                        major_gpTableAdapter.Update(this.tibasport_dbDataSet.major_gp);
                        set_autoinc("major_gp", "id",dgViewMajor);
                        break;
                    case "الماركة":
                        markBindingSource.EndEdit();
                        markTableAdapter.Update(this.tibasport_dbDataSet.mark);
                        set_autoinc("mark", "id", dgViewMark);
                        break;
                    case "النوع":
                        typeBindingSource.EndEdit();
                        typeTableAdapter.Update(this.tibasport_dbDataSet.type);
                        set_autoinc("type", "id", dgViewType);
                        break;
                    case "الوان":
                        colorBindingSource.EndEdit();
                        colorTableAdapter.Update(this.tibasport_dbDataSet.color);
                        set_autoinc("color", "id", dgViewColor);
                        break;
                    case "المقاس":
                        sizeBindingSource.EndEdit();
                        sizeTableAdapter.Update(this.tibasport_dbDataSet.size);
                        set_autoinc("size", "id", dgViewSize);
                        break;
                    case "المخزن":
                        storeBindingSource.EndEdit();
                        storeTableAdapter.Update(this.tibasport_dbDataSet.store);
                        set_autoinc("store", "id", dgViewStore);
                        break;
                    case "الوحدة":
                        unitBindingSource.EndEdit();
                        unitTableAdapter.Update(this.tibasport_dbDataSet.unit);
                        set_autoinc("unit", "id", dgViewUnit);
                        break;
                    case "الرف":
                        locationBindingSource.EndEdit();
                        locationTableAdapter.Update(this.tibasport_dbDataSet.location);
                        set_autoinc("location", "id", dgViewLocation);
                        break;
                    case "نوع الحركة":
                        transtypeBindingSource.EndEdit();
              trans_typeTableAdapter.Update(this.tibasport_dbDataSet.trans_type);
                        set_autoinc("trans_type", "id", dgViewTransType);
                        break;

                }
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

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //label1.Text = tabControl.SelectedTab.Text;
        }

        private void set_autoinc(string table, string id_name, DataGridView dgView)
        {
            if (dgView.Rows.Count > 1)
            {
                string query = string.Format(@"select max({0}) from [{1}]", id_name, table);
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.tibasport_dbConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        int res = (int)cmd.ExecuteScalar();
                        string query1 = string.Format(@"DBCC CHECKIDENT({0}, RESEED, {1})", table, res);

                        using (SqlConnection conn1 = new SqlConnection(Properties.Settings.Default.tibasport_dbConnectionString))
                        {
                            conn1.Open();
                            using (SqlCommand cmd1 = new SqlCommand(query, conn1))
                            {
                                cmd1.ExecuteNonQuery();

                            }
                        }
                    }
                }
            }
            else
            {
                string query = string.Format(@"DBCC CHECKIDENT({0}, RESEED, {1})", table, 0);
                using (SqlConnection conn = new SqlConnection(Properties.Settings.Default.tibasport_dbConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
