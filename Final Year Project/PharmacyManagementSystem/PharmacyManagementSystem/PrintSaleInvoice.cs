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
    public partial class PrintSaleInvoice : Form
    {
        Retrivel R = new Retrivel();
        public PrintSaleInvoice()
        {
            InitializeComponent();
        }

        private void PrintSaleInvoice_Load(object sender, EventArgs e)
        {
            R.GetSaleInvoice(MainClass.StrInv, crystalReportViewer1);
        }
    }
}
