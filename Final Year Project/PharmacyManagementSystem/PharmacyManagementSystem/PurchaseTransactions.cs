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
    public partial class PurchaseTransactions : Form
    {
        Retrivel R = new Retrivel();
        public PurchaseTransactions()
        {
            InitializeComponent();
        }

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            R.PurchaseTransactionReport(FromdateTimePicker,TodateTimePicker, crystalReportViewer1);
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

        private void PurchaseTransactions_Load(object sender, EventArgs e)
        {
            USerIDlabel.Text = Retrivel.Name;
        }
    }
}
