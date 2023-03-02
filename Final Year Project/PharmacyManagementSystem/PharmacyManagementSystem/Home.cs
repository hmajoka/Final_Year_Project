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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

      

        


        private void Userbutton_Click_1(object sender, EventArgs e)
        {
            AddUserS AddUserS = new AddUserS();
            MainClass.ShowWindow(AddUserS, this, MDI.ActiveForm);
        }

        private void Productbutton_Click_1(object sender, EventArgs e)
        {
            Products P = new Products();
            MainClass.ShowWindow(P, this, MDI.ActiveForm);
        }

        private void Catagorybutton_Click_1(object sender, EventArgs e)
        {
            Catagories Catagory = new Catagories();
            MainClass.ShowWindow(Catagory, this, MDI.ActiveForm);
        }

        private void Supplierbutton_Click_1(object sender, EventArgs e)
        {
            Suppliers Suppliers = new Suppliers();
            MainClass.ShowWindow(Suppliers, this, MDI.ActiveForm);
        }

        private void Purchasebutton_Click_1(object sender, EventArgs e)
        {
            Purchase Purchase = new Purchase();
            MainClass.ShowWindow(Purchase, this, MDI.ActiveForm);
        }

        private void PurchaseDetailsbutton_Click_1(object sender, EventArgs e)
        {
            PurchaseDetailS PDetails = new PurchaseDetailS();
            MainClass.ShowWindow(PDetails, this, MDI.ActiveForm);
        }

        private void Salebutton_Click_1(object sender, EventArgs e)
        {
            SaleS SaleS = new SaleS();
            MainClass.ShowWindow(SaleS, this, MDI.ActiveForm);
        }

        private void SaleDeatilsbutton_Click(object sender, EventArgs e)
        {
            SaleDetails SaleDetails = new SaleDetails();
            MainClass.ShowWindow(SaleDetails, this, MDI.ActiveForm);
        }

        private void PurchaseReportbutton_Click(object sender, EventArgs e)
        {
            AllPurchaseProdcutsReport AllPurchaseProductReport = new AllPurchaseProdcutsReport();
            MainClass.ShowWindow(AllPurchaseProductReport, this, MDI.ActiveForm);
        }

        private void SaleReportbutton_Click(object sender, EventArgs e)
        {
            PrintAllSaleReport PASaleRepot = new PrintAllSaleReport();
            MainClass.ShowWindow(PASaleRepot, this, MDI.ActiveForm);
        }

        private void SaleSummarybutton_Click(object sender, EventArgs e)
        {
            SalesSummaryReport Sale = new SalesSummaryReport();
            MainClass.ShowWindow(Sale, this, MDI.ActiveForm);
        }

        private void SaleReturnbutton_Click_1(object sender, EventArgs e)
        {
            SaleReturn SaleReturn = new SaleReturn();
            MainClass.ShowWindow(SaleReturn, this, MDI.ActiveForm);
        }

        private void ReturnDetailsbutton_Click(object sender, EventArgs e)
        {
            SaleReturnDetails R = new SaleReturnDetails();
            MainClass.ShowWindow(R, this, MDI.ActiveForm);
        }

        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            UserIDlabel.Text = Retrivel.Name;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
