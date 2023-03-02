using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem
{
    public partial class SaleReturn : Form
    {
        Retrivel R = new Retrivel();
        Regex Rg = new Regex("^[0-9]+$");
        String  ItemName, ItemCode;
        float Price;
        float Total, Amount, QtyMultiplyPriceAmount, FinalSubTotal, FinaNetTotal, FinalBlance;
        int Count;
        Int16 SessionID, Qty,QtyValidation,ReturnQtyValidation,ProductCode,ItemID;
        float  SalePrice,SubTotal, NetTotal,Pay,Blance,Sum,Discount;
        String Date = DateTime.Now.ToShortDateString();
        Updation U = new Updation();
        ReturnOperations Return = new ReturnOperations();
        RePrintSaleInvoice RPrintSaleInvoice = new RePrintSaleInvoice();
        public SaleReturn()
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

        private void SessionIDtextBox_TextChanged(object sender, EventArgs e)
        {
            if (Rg.Match(SessionIDtextBox.Text).Success)
            {
                if (SessionIDtextBox.Text.Length > 0)
                {
                    if (SessionIDlabel.Visible == true)
                    {
                        SessionIDlabel.Visible = false;
                    }
                    R.GetSaleReturnDetailsThroughSeesionId(dataGridView1, SessionIDtextBox.Text, ItemIDDGV, ItemNameDGV, SalePriceDGV, QtyDGV, AmountDGV, TotalAmountDGV, DisDGV, NetTotalDGV, PayDGV, BlanceDGV, SessionIDDGV, DateDGV);
                }
            }
            else
            {
                SessionIDlabel.Visible = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow Row = dataGridView1.Rows[e.RowIndex];
                if (DescriptiontextBox.Text != "")
                {
                    TotalQtytextBox.Text = Row.Cells["QtyDGV"].Value.ToString();
                }
                else if(SessionIDtextBox.Text !="")
                {
                    TotalQtytextBox.Text = Row.Cells["QtyDGV"].Value.ToString();
                    DatetextBox.Text = Row.Cells["DateDGV"].Value.ToString();
                }
            }
        }

        private void SaleReturn_Load(object sender, EventArgs e)
        {
            UserIDlabel.Text = Retrivel.Name;
        }

        private void ReturnitemsQtybutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (TotalQtytextBox.Text != "" && ReturntextBox.Text != "" && SessionIDtextBox.Text != "")
                {
                    QtyValidation = Convert.ToInt16(dataGridView1.CurrentRow.Cells["QtyDGV"].Value.ToString());
                    ReturnQtyValidation = Convert.ToInt16(ReturntextBox.Text);
                    if (ReturnQtyValidation < QtyValidation && ReturnQtyValidation > 0)
                    {
                        SalePrice = Convert.ToSingle(dataGridView1.CurrentRow.Cells["SalePriceDGV"].Value.ToString());
                        Price = SalePrice;
                        Qty = Convert.ToInt16(ReturntextBox.Text);
                        Total = SalePrice * Qty;
                        
                        
                        Amount = Convert.ToSingle(dataGridView1.CurrentRow.Cells["AmountDGV"].Value.ToString());
                        ItemName = dataGridView1.CurrentRow.Cells["ItemNameDGV"].Value.ToString();
                        ItemCode = dataGridView1.CurrentRow.Cells["ItemIDDGV"].Value.ToString();
                        SessionID = Convert.ToInt16(dataGridView1.CurrentRow.Cells["SessionIDDGV"].Value.ToString());
                        SubTotal = Convert.ToSingle(dataGridView1.CurrentRow.Cells["TotalAmountDGV"].Value.ToString());
                        Discount = Convert.ToSingle(dataGridView1.CurrentRow.Cells["DisDGV"].Value.ToString());
                        NetTotal = Convert.ToSingle(dataGridView1.CurrentRow.Cells["NetTotalDGV"].Value.ToString());
                        Pay = Convert.ToSingle(dataGridView1.CurrentRow.Cells["PayDGV"].Value.ToString());
                        Blance = Convert.ToSingle(dataGridView1.CurrentRow.Cells["BlanceDGV"].Value.ToString());
                        QtyMultiplyPriceAmount = Amount - Total;
                        FinalSubTotal =  QtyMultiplyPriceAmount;
                        FinaNetTotal =FinalSubTotal-Discount;
                        FinalBlance = Pay - FinaNetTotal;
                        MainClass.ReprintPurchase = SessionID.ToString();
                         MessageBox.Show(Total.ToString()+"Amount - Total "+QtyMultiplyPriceAmount+" Final SubTotal "+FinalSubTotal+" NetTotal "+NetTotal+" FinalNetTotal "+FinaNetTotal+" Final blance "+FinalBlance);
                       // MessageBox.Show("SAle Price " + SalePrice + " Price " + Price + " Qty " + Qty + " Price*Qty " + Total + " Item Name " + ItemName + " Item Code " + ItemCode + " Session ID " + SessionID + " Sub Total " + SubTotal + " Net Total " + NetTotal + " Blance " + Blance);
                         Count+=U.ItemQtyReturnThanUpdateSale(Qty, QtyMultiplyPriceAmount, ItemName, ItemCode, SessionID,FinalSubTotal, FinaNetTotal,FinalBlance,Convert.ToDateTime( DatetextBox.Text),UserIDlabel.Text,Convert.ToInt16( ItemCode),ReturntextBox.Text,Convert.ToDecimal( FinalBlance),DescriptiontextBox.Text);
                       
                      if (Count > 0)
                      {
                          MessageBox.Show(@"         Qty Return Succesfully
         Amount Return "+Total,"Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                          R.GetSaleReturnDetailsThroughSeesionId(dataGridView1, SessionIDtextBox.Text, ItemIDDGV, ItemNameDGV, SalePriceDGV, QtyDGV, AmountDGV, TotalAmountDGV, DisDGV, NetTotalDGV, PayDGV, BlanceDGV, SessionIDDGV, DateDGV);
                          ReturnAmounttextBox.Text = Total.ToString();
                          RPrintSaleInvoice.ShowDialog();

                      }
                      else
                      {
                          MessageBox.Show("Some Problems Please Try Again");
                      }
                    }
                    else
                    {
                        MessageBox.Show("Return Qty Must Be Lesser Than Actual SAle Qty");
                    }
                    }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void ReturnItembutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                   DialogResult DResult = MessageBox.Show("Are You Sure You Want To Return " + dataGridView1.CurrentRow.Cells["ItemNameDGV"].Value.ToString() + "", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);               
                    QtyValidation = Convert.ToInt16(dataGridView1.CurrentRow.Cells["QtyDGV"].Value.ToString());
                    SalePrice = Convert.ToSingle(dataGridView1.CurrentRow.Cells["SalePriceDGV"].Value.ToString());
                    Price = SalePrice;
                    Amount = Convert.ToSingle(dataGridView1.CurrentRow.Cells["AmountDGV"].Value.ToString());
                    ItemName = dataGridView1.CurrentRow.Cells["ItemNameDGV"].Value.ToString();
                    ItemID =Convert.ToInt16( dataGridView1.CurrentRow.Cells["ItemIDDGV"].Value.ToString());
                    ProductCode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ItemIDDGV"].Value.ToString());
                    SessionID = Convert.ToInt16(dataGridView1.CurrentRow.Cells["SessionIDDGV"].Value.ToString());
                    SubTotal = Convert.ToSingle(dataGridView1.CurrentRow.Cells["TotalAmountDGV"].Value.ToString());
                    Discount = Convert.ToSingle(dataGridView1.CurrentRow.Cells["DisDGV"].Value.ToString());
                    NetTotal = Convert.ToSingle(dataGridView1.CurrentRow.Cells["NetTotalDGV"].Value.ToString());
                    Pay = Convert.ToSingle(dataGridView1.CurrentRow.Cells["PayDGV"].Value.ToString());
                    Blance = Convert.ToSingle(dataGridView1.CurrentRow.Cells["BlanceDGV"].Value.ToString());            
                //Conditions For Procedures
                if (dataGridView1.Rows.Count > 1)
                {
                    if (DResult == DialogResult.Yes)
                    {
                        Price = SalePrice;
                        Total = SalePrice * QtyValidation;
                        //QtyMultiplyPriceAmount = Amount - Total;
                        FinalSubTotal = SubTotal-Total;
                        FinaNetTotal = FinalSubTotal - Discount;
                        FinalBlance = Pay - FinaNetTotal;
                        //MessageBox.Show(ItemID.ToString());

                       // MessageBox.Show("Total "+Total+" Final SubTotal "+FinalSubTotal+" Dis "+Discount+" Fina Net Total "+FinaNetTotal+" Pay "+Pay+" Final Blance "+FinalBlance);
                        Count +=Return.RITUT(SessionID, FinalSubTotal, FinaNetTotal, FinalBlance, ItemID, QtyValidation, ItemID, ItemName, Convert.ToDateTime(Date), UserIDlabel.Text, ItemID, QtyValidation, FinalBlance, DescriptiontextBox.Text);
                        if (Count > 0)
                        {
                            ReturnAmounttextBox.Text = Amount.ToString();
                            MessageBox.Show("Item Return Successfully Success Return Amount IS " + Amount);
                            MainClass.ReprintPurchase = SessionID.ToString();
                            RPrintSaleInvoice.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Try Again");
                        }
                    }
                }
                else
                {
                    if (DResult == DialogResult.Yes)
                    {
                        Count += Return.ReturnItem(SessionID, ProductCode, QtyValidation, ItemName, Convert.ToDateTime(Date), UserIDlabel.Text, ProductCode, QtyValidation, NetTotal,DescriptiontextBox.Text);
                        if (Count > 0)
                        {
                            float ReturnAmount = Pay - Discount;
                            ReturnAmounttextBox.Text = ReturnAmount.ToString();
                            MessageBox.Show("Item Return Successfully Success Return Amount IS " + ReturnAmount);
                        }
                        else
                        {
                            MessageBox.Show("Try Again");
                        }
                    }
                    
                }
            }
            }

        private void ReturnAllbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                DialogResult DResult = MessageBox.Show("Are You Sure You Want To Return All Item", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DResult == DialogResult.Yes)
                {
                  
          
                    QtyValidation = Convert.ToInt16(dataGridView1.CurrentRow.Cells["QtyDGV"].Value.ToString());
                    SalePrice = Convert.ToSingle(dataGridView1.CurrentRow.Cells["SalePriceDGV"].Value.ToString());
                    Price = SalePrice;
                    Amount = Convert.ToSingle(dataGridView1.CurrentRow.Cells["AmountDGV"].Value.ToString());
                    ItemName = dataGridView1.CurrentRow.Cells["ItemNameDGV"].Value.ToString();
                    ProductCode = Convert.ToInt16(dataGridView1.CurrentRow.Cells["ItemIDDGV"].Value.ToString());
                    SessionID = Convert.ToInt16(dataGridView1.CurrentRow.Cells["SessionIDDGV"].Value.ToString());
                    SubTotal = Convert.ToSingle(dataGridView1.CurrentRow.Cells["TotalAmountDGV"].Value.ToString());
                    NetTotal = Convert.ToSingle(dataGridView1.CurrentRow.Cells["NetTotalDGV"].Value.ToString());
                    Pay = Convert.ToSingle(dataGridView1.CurrentRow.Cells["PayDGV"].Value.ToString());
                    Discount = Convert.ToSingle(dataGridView1.CurrentRow.Cells["DisDGV"].Value.ToString());
                    Blance = Convert.ToSingle(dataGridView1.CurrentRow.Cells["BlanceDGV"].Value.ToString());
                    
                    for (int Row = 0; Row < dataGridView1.Rows.Count; Row++)
                    {
                       Count+=Return.SessionSaleReturn(Convert.ToInt16(dataGridView1.Rows[Row].Cells["SessionIDDGV"].Value.ToString()), Convert.ToInt16(dataGridView1.Rows[Row].Cells["ItemIDDGV"].Value.ToString()), Convert.ToInt16(dataGridView1.Rows[Row].Cells["QtyDGV"].Value.ToString()), dataGridView1.Rows[Row].Cells["ItemNameDGV"].Value.ToString(),Convert.ToDateTime( Date),UserIDlabel.Text,Convert.ToInt16( dataGridView1.Rows[Row].Cells["ItemIDDGV"].Value.ToString()),Convert.ToInt16( dataGridView1.Rows[Row].Cells["QtyDGV"].Value.ToString()),Convert.ToSingle( dataGridView1.Rows[Row].Cells["NetTotalDGV"].Value.ToString()),DescriptiontextBox.Text);
                       Sum +=Convert.ToSingle( dataGridView1.Rows[Row].Cells["NetTotalDGV"].Value.ToString());
                     //  Sum += Return.TestProcedure(Convert.ToInt16(dataGridView1.Rows[Row].Cells["ItemIDDGV"].Value.ToString()), Convert.ToInt16(dataGridView1.Rows[Row].Cells["QtyDGV"].Value.ToString()), dataGridView1.Rows[Row].Cells["ItemNameDGV"].Value.ToString());
                       // MessageBox.Show(dataGridView1.Rows[Row].Cells["SessionIDDGV"].Value.ToString());
                    }
                    if (Count > 0)
                    {
                        float ReturnAmount = Pay - Discount;
                        ReturnAmounttextBox.Text = ReturnAmount.ToString();
                        MessageBox.Show("Items Are Return Successfully Return Amount Is " + ReturnAmount);
                    }
                    else
                    {
                        MessageBox.Show("Please Try Again");
                    }
                }
            }
        }

        private void StockReturnbutton_Click(object sender, EventArgs e)
        {
            
        }

        private void Leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TotalQtytextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DatetextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturntextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DescriptiontextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ReturnAmounttextBox_TextChanged(object sender, EventArgs e)
        {

        }
        
        
    }
}
