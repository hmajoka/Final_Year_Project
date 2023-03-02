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
    public partial class Home1 : Form
    {
        public Home1()
        {
            InitializeComponent();
        }

        private void Productsbutton_Click(object sender, EventArgs e)
        {
            Products Products = new Products();
            MainClass.ShowWindow(Products, this, MDI.ActiveForm);
        }

        private void Catagorybutton_Click(object sender, EventArgs e)
        {
            Catagories Catagory = new Catagories();
            MainClass.ShowWindow(Catagory, this, MDI.ActiveForm);
        }

        private void Supplierbutton_Click(object sender, EventArgs e)
        {
            Suppliers Supplier = new Suppliers();
            MainClass.ShowWindow(Supplier, this, MDI.ActiveForm);
        }

        private void Purchasebutton_Click(object sender, EventArgs e)
        {
            Purchase Purchase = new Purchase();
            MainClass.ShowWindow(Purchase, this, MDI.ActiveForm);
        }

        private void PurchaseDetailsbutton_Click(object sender, EventArgs e)
        {
            PurchaseDetailS PD = new PurchaseDetailS();
            MainClass.ShowWindow(PD, this, MDI.ActiveForm);
        }

        private void Salebutton_Click(object sender, EventArgs e)
        {
            SaleS Sale = new SaleS();
            MainClass.ShowWindow(Sale, this, MDI.ActiveForm);
        }

        private void SaleDetailsbutton_Click(object sender, EventArgs e)
        {
            SaleDetails Details = new SaleDetails();
            MainClass.ShowWindow(Details, this, MDI.ActiveForm);
        }

        private void SaleReturnbutton_Click(object sender, EventArgs e)
        {
            SaleReturn SaleReturn = new SaleReturn();
            MainClass.ShowWindow(SaleReturn, this, MDI.ActiveForm);
        }

        private void LogOutbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home1_Load(object sender, EventArgs e)
        {
            UserIDlabel.Text = Retrivel.Name;
        }
    }
}
