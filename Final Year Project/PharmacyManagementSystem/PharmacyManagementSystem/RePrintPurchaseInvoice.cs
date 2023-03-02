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
    public partial class RePrintPurchaseInvoice : Form
    {
        Retrivel R = new Retrivel();
        
        public RePrintPurchaseInvoice()
        {
            InitializeComponent();
        }

        private void RePrintPurchaseInvoice_Load(object sender, EventArgs e)
        {
            String PIDw = MainClass.ReprintPurchase;
            R.PurchaseInvoice("PrintPurchaseInvoice", "@BillNo", PIDw, crystalReportViewer1);
        }

        
    }
}
