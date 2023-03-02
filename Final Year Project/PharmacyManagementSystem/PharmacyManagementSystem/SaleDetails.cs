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
    public partial class SaleDetails : Form
    {
        Int16 InvoiceNo;
        Retrivel R = new Retrivel();
        RePrintSaleInvoice RPSaleInvoice = new RePrintSaleInvoice();
        public SaleDetails()
        {
            InitializeComponent();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            R.GetSaleDetails(FromdateTimePicker, TodateTimePicker, dataGridView1,InvoiceDGV,InvoiceDateDGV,SubTotalDGV,DisDGV,NetTotalDGV);
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

        private void SaleDetails_Load(object sender, EventArgs e)
        {
            USerIDlabel.Text = Retrivel.Name;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {

                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    InvoiceNo = Convert.ToInt16(row.Cells[1].Value.ToString());
                    MainClass.ReprintPurchase = InvoiceNo.ToString();
                    RPSaleInvoice.ShowDialog();
                }
            }

        }
    }
}
