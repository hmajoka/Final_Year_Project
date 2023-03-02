using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Transactions;

namespace PharmacyManagementSystem
{
    public partial class Purchase : Form
    {
        SqlCommand cmd;
        SqlDataReader sqldr;
        Retrivel R = new Retrivel();
        
        int SearchValidation;
        Decimal Total, Subtotal;
        Regex RegularExpression = new Regex(@"[+-]?([0-9]*[.])?[0-9]+");
        Regex QtyRegex = new Regex("^[0-9]+$");
        Regex DecimalRegex = new Regex(@"^[-+][0-9]+\.[0-9]+[eE][-+]?[0-9]+$");
        float Sub,MultiplyPrice,MultiplyAmount;
        Int16 PQty,MultiplyQty;
        //String date = Convert.ToString(DateTime.Now);
        Insertion I = new Insertion();
        Updation U = new Updation();
        String Date = DateTime.Now.ToShortDateString();
        SqlDataAdapter Sqlda;
        DataTable dt;
        Int16 PID;
        String BillNo;
        Decimal SaveSubTotal;
        Int16 DeleteValidation = 0;
        public Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {         
            R.AutoCompleteProductName(ProductsNamecomboBox);
            UserIDlabel.Text = Retrivel.Name;
        }
        public void Clear()
        {
            SubTotaltextBox.Text = String.Empty;
            SaveSubTotal =0;
            DeleteValidation = 0;
            DistextBox.Text = String.Empty;
            NetTotaltextBox.Text = String.Empty;
            NetPaytextBox.Text = String.Empty;
            BlancetextBox.Text = String.Empty;
            dataGridView1.Rows.Clear();

        }
        public void EmptyTexboxes()
        {
            ProductsNamecomboBox.Text =String.Empty;
            PricetextBox.Text = String.Empty;
            QtytextBox.Text = String.Empty;
            MultiplyAmount = 0;
        }
        public void GetBillNo()
        {
            try
            {
                int A;
                cmd = new SqlCommand("SelectMaxBillNo", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                Db.Con.Open();
                sqldr = cmd.ExecuteReader();
                if (sqldr.Read())
                {
                    String val = sqldr[0].ToString();
                    if (val == "")
                    {
                        BillNo = "1";
                    }
                    else
                    {//Generate BillNo
                        A = Convert.ToInt32(sqldr[0].ToString());
                        A = A + 1;
                        BillNo = A.ToString();
                    }
                }
                Db.Con.Close();

            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void GetProductsThroughPName()
        {
            try
            {
                cmd = new SqlCommand("GetProductsThroughProductName", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_Name", ProductsNamecomboBox.Text);
                Db.Con.Open();
                Sqlda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                Sqlda.Fill(dt);
                int i = dt.Rows.Count;
                int n = 0;
                while (i > 0)
                {
                    PID =Convert.ToInt16( dt.Rows[n][0].ToString());
                    n = n + 1;
                    i = i - 1;
                }
                Db.Con.Close();
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message);
            }
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

        
        String ProductID;
        private void Addbutton_Click(object sender, EventArgs e)
        {
            
/*
            try
            {
                if (IsValid())
                {
                    if (dataGridView1.Rows.Count != 0)
                    {
                        foreach (DataGridViewRow Row in dataGridView1.Rows)
                        {
                            if (Row.Cells[1].Value.ToString() == PID)
                            {
                                float TotalAmount;
                                Int16 Qty = Convert.ToInt16(Row.Cells[2].Value.ToString());
                                Qty += Convert.ToInt16(QtytextBox.Text);
                                TotalAmount = Convert.ToSingle(Row.Cells[4].Value.ToString()) * Qty;
                                Row.Cells[2].Value = Qty;
                                Row.Cells[4].Value = TotalAmount;
                                Sub += TotalAmount;
                                SubTotaltextBox.Text = Sub.ToString();
                            
                            }
                            else
                            {
                                dataGridView1.Rows.Add(PIDDGV, ProductsNamecomboBox.Text, QtytextBox.Text, PricetextBox.Text, TotaltextBox.Text);
                                Total += Convert.ToDecimal(TotaltextBox.Text);
                                SubTotaltextBox.Text = Convert.ToString(Total);
                                /*SelectBarcodetextBox.Text = null;
                                ProductsNamecomboBox.Text = null;
                                PricetextBox.Text = null;
                                QtytextBox.Text = null;
                                TotaltextBox.Text = null;

                            }
                        }
                    }
                    else
                    {
                        dataGridView1.Rows.Add(PIDDGV, ProductsNamecomboBox.Text, QtytextBox.Text, PricetextBox.Text, TotaltextBox.Text);
                        Total += Convert.ToDecimal(TotaltextBox.Text);
                        SubTotaltextBox.Text = Convert.ToString(Total);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }*/

            if (DistextBox.Text.Length > 0 || NetTotaltextBox.Text.Length > 0 || NetPaytextBox.Text.Length > 0 || BlancetextBox.Text.Length > 0)
            {
                MessageBox.Show("First Save Or Clear Transaction Details");
            }
            else
            {
                if (IsValid())
                {
                    if (QtyRegex.Match(QtytextBox.Text).Success)
                    {
                        Qtylabel.Visible = false;
                        MultiplyQty = Convert.ToInt16(QtytextBox.Text);
                        MultiplyPrice = Convert.ToSingle(PricetextBox.Text);
                        MultiplyAmount = MultiplyPrice * MultiplyQty;
                        dataGridView1.Rows.Add(PID, ProductsNamecomboBox.Text, QtytextBox.Text, PricetextBox.Text, MultiplyAmount);
                        Total += Convert.ToDecimal(MultiplyAmount);
                        SubTotaltextBox.Text = Convert.ToString(Total);
                        LowStocklabel.Text = null;
                        Pricelabel.Visible = false;
                    }
                    else
                    {
                        Qtylabel.Visible = true;
                    }
                }
            }
            

        }

        private bool IsValid()
        {
            if (String.IsNullOrEmpty(SupplierNamecomboBox.Text))
            {
                SupplierNamecomboBox.Focus();
                SupplierNamelabel.Visible = true;
                return false;
            }
            
            else if (String.IsNullOrEmpty(ProductsNamecomboBox.Text))
            {
                ProductsNamecomboBox.Focus();
                PNamelabel.Visible = true;
                return false;
            }
            else if (String.IsNullOrEmpty(PricetextBox.Text))
            {
               // PricetextBox.Focus();
                Pricelabel.Visible = true;
                return false;
            }
            else if (String.IsNullOrEmpty(QtytextBox.Text))
            {
                Qtylabel.Visible = true;
                return false;
            }
            return true;

        }

        private void ProducttextBox_Validated(object sender, EventArgs e)
        {
            
        }

        private void ProductsNamecomboBox_Validated(object sender, EventArgs e)
        {
            if (ProductsNamecomboBox.Text=="")
            {
                PNamelabel.Visible = true;
            }
            else
            {
                PNamelabel.Visible = false;
            }
        }

        private void QtytextBox_TextChanged(object sender, EventArgs e)
        {
           
        }


        private void ProductsNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductsThroughPName();
        }

        private void Leftpanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SupplierNamecomboBox_Validated(object sender, EventArgs e)
        {
            if (SupplierNamecomboBox.Text == "") 
            {
                SupplierNamelabel.Visible = true;
            }
            else
            {
                SupplierNamelabel.Visible = false;
            }
        }

        private void PricetextBox_Validated(object sender, EventArgs e)
        {
            if (PricetextBox.Text=="")
            {
                Pricelabel.Visible = true;
            }
            else
            {
                Pricelabel.Visible = false;
            }
        }

        private void QtytextBox_Validated(object sender, EventArgs e)
        {
            if (QtytextBox.Text=="")
            {
                Qtylabel.Visible = true;
            }
            else
            {
                Qtylabel.Visible = false;
            }
        }

        private void SupplierNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductsThroughPName();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DeleteValidation == 0)
            {
                if (e.RowIndex != -1 && e.ColumnIndex != -1)
                {
                    var senderGrid = (DataGridView)sender;
                    if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                        e.RowIndex >= 0)
                    {
                        DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                        Total = Total - Convert.ToDecimal(row.Cells[4].Value.ToString());
                        SubTotaltextBox.Text = Total.ToString();
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
            else
            {
                MessageBox.Show("You Are Already Check Out Frist Save The Record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int Count;
        private void SaveUserbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 0)
                {
                    using (TransactionScope TScope = new TransactionScope())
                    {
                        GetBillNo();
                        I.InsertPurchaseHeaderData("InsertPurchaseHeader", BillNo, Convert.ToDateTime(Date), Convert.ToSingle(SubTotaltextBox.Text), Convert.ToSingle(DistextBox.Text), Convert.ToSingle(NetTotaltextBox.Text), Convert.ToSingle(NetPaytextBox.Text), Convert.ToSingle(BlancetextBox.Text), SupplierNamecomboBox.Text,UserIDlabel.Text);
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                         
                            U.IncreaseProductsQty(Convert.ToInt16( dataGridView1.Rows[i].Cells["QtyDGV"].Value.ToString()), dataGridView1.Rows[i].Cells["PIDDGV"].Value.ToString(),Convert.ToSingle( dataGridView1.Rows[i].Cells["PriceDGV"].Value.ToString()));
                            Count += I.InsertPurchaseRowData("InsertPurchaseRow", dataGridView1.Rows[i].Cells["PNameDGV"].Value.ToString(), Convert.ToSingle(dataGridView1.Rows[i].Cells["PriceDGV"].Value.ToString()), Convert.ToInt16(dataGridView1.Rows[i].Cells["QtyDGV"].Value.ToString()), Convert.ToSingle(dataGridView1.Rows[i].Cells["TotalAmountDGV"].Value.ToString()),BillNo, Convert.ToDateTime(Date));
                            
                        }

                        if (Count > 0)
                        {              
                            MainClass.StrInv = BillNo;
                            PhurchaseInvoice PInvoice = new PhurchaseInvoice();
                            PInvoice.ShowDialog();
                            Clear();
                            TScope.Complete();
                        }
                    }
                    if (Count > 0)
                    {
                        MessageBox.Show("Purchase Successfully Completed", "InforMation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void CheckOutbutton_Click_1(object sender, EventArgs e)
        {           
            SaveSubTotal=Convert.ToDecimal( SubTotaltextBox.Text);
            NetTotaltextBox.Text=SubTotaltextBox.Text;
            DeleteValidation = 1;
            EmptyTexboxes();
        }

        private void DistextBox_Validated(object sender, EventArgs e)
        {
            
        }

        private void NetPaytextBox_Validated(object sender, EventArgs e)
        {
            if (NetPaytextBox.Text.Length !=0)
            {
               float Net,Pay,Blance;
               Net = Convert.ToSingle(NetTotaltextBox.Text);
               Pay = Convert.ToSingle(NetPaytextBox.Text);
               Blance = Pay - Net;
               BlancetextBox.Text = Blance.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Date);
        }

        private void ProductsNamecomboBox_Enter(object sender, EventArgs e)
        {
            
            R.GetProductName(ProductsNamecomboBox);
        }

        private void SupplierNamecomboBox_Enter(object sender, EventArgs e)
        {
            R.GetSuppliersList(SupplierNamecomboBox);
            
        }

        private void NetPaytextBox_TextChanged(object sender, EventArgs e)
        {
            if (NetPaytextBox.Text.Length != 0)
            {
                BlancetextBox.Text = (decimal.Parse(NetPaytextBox.Text) - decimal.Parse(NetTotaltextBox.Text)).ToString();
            }
            else
            {
                BlancetextBox.Text = string.Empty;
            }
        }

        private void DistextBox_TextChanged(object sender, EventArgs e)
        {
            if (DistextBox.Text.Length > 0 && NetTotaltextBox.Text.Length > 0)
            {
                if (decimal.Parse(DistextBox.Text) < decimal.Parse(NetTotaltextBox.Text))
                {
                    NetTotaltextBox.Text = (decimal.Parse(NetTotaltextBox.Text) - decimal.Parse(DistextBox.Text)).ToString();
                }
                else
                {
                    NetTotaltextBox.Text = SubTotaltextBox.Text;
                    DistextBox.Text = "0";
                }
            }
            else
            {
                NetTotaltextBox.Text = SubTotaltextBox.Text;
            }
        }


        private void Clearbutton_Click(object sender, EventArgs e)
        {
            //Clear();
            MessageBox.Show(PID.ToString());
        }

        private void DeleteUserbutton_Click(object sender, EventArgs e)
        {
            if ( DecimalRegex.Match(PricetextBox.Text).Success)
            {
                MessageBox.Show("Success");
            }
        }
        }
    }

