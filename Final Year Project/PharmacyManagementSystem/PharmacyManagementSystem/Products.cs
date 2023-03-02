using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class Products : Form
    {
        String PID;
        Int16 ProductID;
        String Gender;
        Int16 Status;
        Int16 DeleteVlaidation;
        Int16 PCatID;
        Int16 SessionID;
        Retrivel R = new Retrivel();
        Deletion D = new Deletion();
        public Products()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {
            R.GetCatagoryList(CatagorycomboBox);
            USerIDlabel.Text = Retrivel.Name;
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            if (Retrivel.UType == "Admin")
            {
                Home Home = new Home();
                MainClass.ShowWindow(Home, this, MDI.ActiveForm);
            }
            else
            {
                Home1 Home1 = new Home1();
                MainClass.ShowWindow(Home1, this, MDI.ActiveForm);
            }
        }

        private void UpdateUserbutton_Click(object sender, EventArgs e)
        {

            try
            {
                if (ProductID > 0)
                {
                    Updation u = new Updation();
                    u.UpdateProducts(ItemUnitcomboBox.Text, Convert.ToInt16(CatagorycomboBox.SelectedValue), ItemNametextBox.Text, PowertextBox.Text, Convert.ToSingle(PurchasePricetextBox.Text), Convert.ToSingle(SalePricetextBox.Text), Convert.ToInt16(QtytextBox.Text), RackNotextBox.Text, ExpDatedateTimePicker.Value, ProductID);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsValid())
                {


                    Insertion i = new Insertion();
                    i.InsertProducts( ItemUnitcomboBox.Text, Convert.ToInt32(CatagorycomboBox.SelectedValue), ItemNametextBox.Text,PowertextBox.Text, Convert.ToSingle(PurchasePricetextBox.Text), Convert.ToSingle(SalePricetextBox.Text), Convert.ToInt16(QtytextBox.Text), RackNotextBox.Text, Convert.ToDateTime(ExpDatedateTimePicker.Text));
                    // i.InsertProducts(ItemCodetextBox.Text, ItemUnitcomboBox.Text, Convert.ToInt32(CatagorycomboBox.SelectedValue), ItemNametextBox.Text, BarcodetextBox.Text, PowertextBox.Text, Convert.ToSingle(PurchasePricetextBox.Text), Convert.ToSingle(SalePricetextBox.Text),Convert.ToInt16(QtytextBox.Text), RackNotextBox.Text, Convert.ToDateTime(ExpDatedateTimePicker.Text));
                    R.GetProducts("GetProducts", dataGridView1, PIDDatagridview, PUnitDatagridview, PCatagoryDatagridview, PCatIDDatagridview,PNameDataGridview, PPowerDatagridview, PPriceDatagridview, SalePriceDataGridview, QtyDataGridView, PRackNoDataGridview, PExpDateDatagridview);
                }
                // MainClass.Disable_Rest(Leftpanel);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private bool IsValid()
        {
          
             if (CatagorycomboBox.SelectedIndex==-1)
            {
                CatagorycomboBox.Focus();
                CatagorycomboBox.Visible = true;
                return false;
            }
            else if (ExpDatedateTimePicker.Value < DateTime.Now)
            {
                ExpiryDatelabel.Text = "Please Enter Correct Expiry";
                ExpiryDatelabel.Visible = true;
                return false;
            }
            return true;
        }

        private void ItemUnitcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (DeleteVlaidation == 1)
            {
                DialogResult Dresult = MessageBox.Show("Are you Sure you Want to Delete Record", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Dresult == DialogResult.Yes)
                {
                    Deletion D = new Deletion();
                    R.GetProducts("GetProducts", dataGridView1, PIDDatagridview, PUnitDatagridview, PCatagoryDatagridview, PCatIDDatagridview, PNameDataGridview, PPowerDatagridview, PPriceDatagridview, SalePriceDataGridview, QtyDataGridView, PRackNoDataGridview, PExpDateDatagridview);
                    DeleteVlaidation = 0;
                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DeleteVlaidation = 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ProductID=Convert.ToInt16( row.Cells["PIDDatagridview"].Value.ToString());
                ItemUnitcomboBox.SelectedItem = row.Cells[2].Value.ToString();
                CatagorycomboBox.Text = row.Cells[3].Value.ToString();
                PCatID =Convert.ToInt16( row.Cells[4].Value);
                ItemNametextBox.Text = row.Cells[5].Value.ToString();
                PowertextBox.Text = row.Cells[6].Value.ToString();
                PurchasePricetextBox.Text = row.Cells[7].Value.ToString();
                SalePricetextBox.Text = row.Cells[8].Value.ToString();
                QtytextBox.Text = row.Cells[9].Value.ToString();
                RackNotextBox.Text = row.Cells[10].Value.ToString();
                //ExpDatedateTimePicker.Value =Convert.ToDateTime( row.Cells[12].Value);
            }
        }

        private void Viewbutton_Click(object sender, EventArgs e)
        {
            R.GetProducts("GetProducts", dataGridView1, PIDDatagridview, PUnitDatagridview, PCatagoryDatagridview, PCatIDDatagridview, PNameDataGridview, PPowerDatagridview, PPriceDatagridview, SalePriceDataGridview, QtyDataGridView, PRackNoDataGridview, PExpDateDatagridview);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (int.Parse(row.Cells["QtyDataGridView"].Value.ToString()) <= 10)
                {
                    row.Cells["QtyDataGridView"].Style.BackColor = Color.Red;
                    row.Cells["QtyDataGridView"].Style.ForeColor = Color.White;
                }
            }
        }

        private void LowStockbutton_Click(object sender, EventArgs e)
        {
            R.GetProducts("LowStock", dataGridView1, PIDDatagridview, PUnitDatagridview, PCatagoryDatagridview, PCatIDDatagridview, PNameDataGridview, PPowerDatagridview, PPriceDatagridview, SalePriceDataGridview, QtyDataGridView, PRackNoDataGridview, PExpDateDatagridview);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (int.Parse(row.Cells["QtyDataGridView"].Value.ToString()) <= 10)
                {
                    row.Cells["QtyDataGridView"].Style.BackColor = Color.Red;
                    row.Cells["QtyDataGridView"].Style.ForeColor = Color.White;
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                DeleteVlaidation = 1;
                SessionID = Convert.ToInt16(row.Cells[1].Value);
                var senderGrid = (DataGridView)sender;
                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    if (DeleteVlaidation == 1)
                    {
                        DialogResult Dresult = MessageBox.Show("Are you Sure you Want to Delete " + row.Cells["PNameDataGridview"].Value.ToString() + "", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Dresult == DialogResult.Yes)
                        {                         
                            D.DeleteProducts(SessionID);
                            R.GetProducts("GetProducts", dataGridView1, PIDDatagridview, PUnitDatagridview, PCatagoryDatagridview, PCatIDDatagridview, PNameDataGridview, PPowerDatagridview, PPriceDatagridview, SalePriceDataGridview, QtyDataGridView, PRackNoDataGridview, PExpDateDatagridview);
                            foreach (DataGridViewRow row1 in dataGridView1.Rows)
                            {
                                if (int.Parse(row1.Cells["QtyDataGridView"].Value.ToString()) <= 10)
                                {
                                    row1.Cells["QtyDataGridView"].Style.BackColor = Color.Red;
                                    row1.Cells["QtyDataGridView"].Style.ForeColor = Color.White;
                                }
                            }
                            DeleteVlaidation = 0;
                        }
                    }
                 }
        }

        private void SearchtextBox_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                R.GetProducts("SearchProducts", dataGridView1, PIDDatagridview, PUnitDatagridview, PCatagoryDatagridview, PCatIDDatagridview, PNameDataGridview, PPowerDatagridview, PPriceDatagridview, SalePriceDataGridview, QtyDataGridView, PRackNoDataGridview, PExpDateDatagridview,SearchtextBox.Text);
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (int.Parse(row.Cells["QtyDataGridView"].Value.ToString()) <= 10)
                    {
                        row.Cells["QtyDataGridView"].Style.BackColor = Color.Red;
                        row.Cells["QtyDataGridView"].Style.ForeColor = Color.White;
                    }
                }
            }
        }
    }
}
