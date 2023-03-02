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
    public partial class PurchaseDetailS : Form
    {
        RePrintPurchaseInvoice RPrintPurchaseInvoice = new RePrintPurchaseInvoice();
        public PurchaseDetailS()
        {
            InitializeComponent();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            Retrivel R = new Retrivel();
            R.GetPurchaseDeatils( FromdateTimePicker, TodateTimePicker, dataGridView1,InvoiceDGV, InvoiceDateDGV, SubTotalDGV, DisDGV, NetTotalDGV, SupplierNameDGV);
        }

        private void PurchaseDetailS_Load(object sender, EventArgs e)
        {
            USerIDlabel.Text = Retrivel.Name;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                    MainClass.ReprintPurchase =row.Cells[1].Value.ToString();
                    RPrintPurchaseInvoice.ShowDialog();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MainClass.StrInv);
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
    }
}
