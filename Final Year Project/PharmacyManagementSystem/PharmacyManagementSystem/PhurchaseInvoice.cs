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
    public partial class PhurchaseInvoice : Form
    {
        String BillNoID = MainClass.StrInv;
        public PhurchaseInvoice()
        {
            InitializeComponent();
        }

        private void PhurchaseInvoice_Load(object sender, EventArgs e)
        {
            Retrivel R = new Retrivel();
            R.PurchaseInvoice("PrintPurchaseInvoice", "@BillNo",BillNoID, crystalReportViewer1);
        }
    }
}
