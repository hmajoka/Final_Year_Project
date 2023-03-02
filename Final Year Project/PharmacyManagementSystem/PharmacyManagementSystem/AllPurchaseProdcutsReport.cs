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
    public partial class AllPurchaseProdcutsReport : Form
    {
        Retrivel R = new Retrivel();
        public AllPurchaseProdcutsReport()
        {
            InitializeComponent();
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

        private void Searchbutton_Click(object sender, EventArgs e)
        {
            R.AllPurchaseReport(FromdateTimePicker, TodateTimePicker, crystalReportViewer1);
        }

        private void AllPurchaseProdcutsReport_Load(object sender, EventArgs e)
        {
            USerIDlabel.Text = Retrivel.Name;
        }
    }
}
