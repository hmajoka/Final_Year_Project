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
    public partial class SaleS : Form
    {
        PrintSaleInvoice PSale = new PrintSaleInvoice();
        Updation U = new Updation();
        Insertion I = new Insertion();        
        Regex Rg = new Regex(@"^[0-9]([.,][0-9]{1,3})?$");
        Regex RG1 = new Regex(@"^\d*$");
        Regex QtyRegex = new Regex("^[0-9]+$");
        Retrivel R = new Retrivel();
        SqlDataReader Sqldr;
        String ProductId;
        Int16 PQty;
        SqlCommand cmd;
        SqlDataAdapter sqlda;
        DataTable dt;
        Decimal Total;
        Int16 MultiplyQty;
        Decimal MultiplySubTotal;
        Decimal MultiplyPrice;
        Decimal SaveSubTotal;
        Int16 DeleteValidation = 0;
        Int16 SessionID;
        String Date = DateTime.Now.ToShortDateString();
        
        public SaleS()
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

        private void SaleS_Load(object sender, EventArgs e)
        {
            R.AutoCompleteProductName(ProductNamecomboBox);
            USerNAmelabel.Text = Retrivel.Name;
        }
        public void Clear()
        {
            dataGridView1.Rows.Clear();
            ProductNamecomboBox.Text = null;
            PricetextBox.Text = null;
            QtytextBox.Text = null;
            SubTotaltextBox.Text = null;
            DistextBox.Text = null;
            NetTotaltextBox.Text = null;
            NetPaytextBox.Text = null;
            BlancetextBox.Text = null;
            DeleteValidation = 0;
            Total = 0;

        }
        public void GetSessionID()
        {
            int A;
            try
            {
                cmd = new SqlCommand("GetSessionID", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                Db.Con.Open();
                Sqldr = cmd.ExecuteReader();
               if (Sqldr.Read())
                {
                    String val = Sqldr[0].ToString();
                    if (val == "")
                    {
                        SessionID = 1;
                    }
                    else
                    {//Generate BillNo
                        A = Convert.ToInt32(Sqldr[0].ToString());
                        A = A + 1;
                        SessionID = Convert.ToInt16(A);
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





        int Count;
        private void SavePurchasebutton_Click(object sender, EventArgs e)
        {


            try
            {
                if (TransactionValidation()) {
                    if (PNamelabel.Visible || Pricelabel.Visible || Qtylabel.Visible || QtyValidationlabel.Visible || SubTotallabel.Visible || Dislabel.Visible || NetTotallabel.Visible || NetPaylabel.Visible || Blancelabel.Visible)
                    {
                        MessageBox.Show("Fields With ! Are Mindatery");
                    }
                    else
                    {
                        if (dataGridView1.Rows.Count > 0)
                        {
                            using (TransactionScope Scope = new TransactionScope())
                            {
                                GetSessionID();
                                I.InsertSaleHeaderData("InsertSaleHeaderData", SessionID, Convert.ToDateTime(Date),Convert.ToSingle( SubTotaltextBox.Text),Convert.ToSingle( DistextBox.Text),Convert.ToSingle( NetTotaltextBox.Text),Convert.ToSingle( NetPaytextBox.Text),Convert.ToSingle( BlancetextBox.Text), USerNAmelabel.Text);
                                for (int L = 0; L < dataGridView1.Rows.Count; L++)
                                {
                                    //  I.InsertSaleRowData(dataGridView1.Rows[Row].Cells["PIDDGV"].Value.ToString(), dataGridView1.Rows[Row].Cells["PNameDGV"].Value.ToString(),Convert.ToSingle( dataGridView1.Rows[Row].Cells["PriceDGV"].Value.ToString()), dataGridView1.Rows[Row].Cells["QtyDGV"].Value.ToString(),Convert.ToSingle( dataGridView1.Rows[Row].Cells["TotalAmountDGV"].Value.ToString()), BillNotextBox.Text, Convert.ToDateTime(Date));
                                    U.DecreaseProductQty(Convert.ToInt16(dataGridView1.Rows[L].Cells[3].Value.ToString()), dataGridView1.Rows[L].Cells[0].Value.ToString());
                                    Count += I.InsertSaleRowData(dataGridView1.Rows[L].Cells[0].Value.ToString(), dataGridView1.Rows[L].Cells[1].Value.ToString(), Convert.ToSingle(dataGridView1.Rows[L].Cells[2].Value.ToString()), Convert.ToInt16(dataGridView1.Rows[L].Cells[3].Value.ToString()), Convert.ToSingle(dataGridView1.Rows[L].Cells[4].Value.ToString()),SessionID, Convert.ToDateTime(Date));
                                    //Count += I.InsertSaleDeatails(SessionID, Convert.ToDateTime(Date), Convert.ToInt16(dataGridView1.Rows[L].Cells[0].Value.ToString()), dataGridView1.Rows[L].Cells[0].Value.ToString(), Convert.ToSingle(dataGridView1.Rows[L].Cells[2].Value.ToString()), Convert.ToInt16(dataGridView1.Rows[L].Cells[3].Value.ToString()), Convert.ToSingle(dataGridView1.Rows[L].Cells[4].Value.ToString()), Convert.ToSingle(Total), Convert.ToSingle(DistextBox.Text), Convert.ToSingle(NetTotaltextBox.Text), Convert.ToSingle(NetPaytextBox.Text), Convert.ToSingle(BlancetextBox.Text), USerNAmelabel.Text);
                                    //MessageBox.Show(Total.ToString());
                                }

                                MainClass.StrInv = SessionID.ToString();
                                PSale.ShowDialog();
                                Scope.Complete();
                                Clear();
                            }
                            if (Count > 0)
                            {
                                MessageBox.Show("Sale Successfully Completed", "InforMation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Error");
                            }
                        }
                    }
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        

        private void ProductNamecomboBox_Enter(object sender, EventArgs e)
        {
            R.GetProductName(ProductNamecomboBox);
        }

        private void ProductNamecomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetProductsThroughPName();
        }
        public void GetProductsThroughPName()
        {
            try
            {
                cmd = new SqlCommand("GetProductsThroughProductName", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_Name",ProductNamecomboBox.Text);
                Db.Con.Open();
                sqlda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlda.Fill(dt);
                int i = dt.Rows.Count;
                int n = 0;
                while (i > 0)
                {
                    ProductId = dt.Rows[n][0].ToString();
                    PricetextBox.Text = dt.Rows[n][1].ToString();
                    PQty = Convert.ToInt16(dt.Rows[n][2].ToString());
                    RackNotextBox.Text = dt.Rows[n][3].ToString();
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

        private void SupplierNamecomboBox_Enter(object sender, EventArgs e)
        {
            
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (DistextBox.Text.Length > 0 || NetTotaltextBox.Text.Length > 0 || NetPaytextBox.Text.Length > 0 || BlancetextBox.Text.Length > 0)
            {
                MessageBox.Show("First Save Or Clear Transaction Details");
            }
            else
            {
                if (ISvalid())
                {
                    // Int16 c = Convert.ToInt16(QtytextBox.Text);
                    if (QtyRegex.Match(QtytextBox.Text).Success)
                    {


                        if (Int16.Parse(QtytextBox.Text) > PQty)
                        {
                            QtyValidationlabel.Text = "Short Stock";
                            QtyValidationlabel.Visible = true;
                        }
                        else
                        {

                            MultiplyQty = Convert.ToInt16(QtytextBox.Text);
                            MultiplyPrice = Convert.ToDecimal(PricetextBox.Text);
                            MultiplySubTotal = MultiplyPrice * MultiplyQty;
                            QtyValidationlabel.Visible = false;
                            dataGridView1.Rows.Add(ProductId, ProductNamecomboBox.Text, PricetextBox.Text, QtytextBox.Text, MultiplySubTotal);
                            Total += Convert.ToDecimal(MultiplySubTotal);
                            SubTotaltextBox.Text = Convert.ToString(Total);
                        }
                    }
                    else
                    {
                        Qtylabel.Visible = true;
                    }
                }
            }          
        }

        private bool ISvalid()
        {
            
             if (String.IsNullOrEmpty(ProductNamecomboBox.Text.Trim()))
            {
                PNamelabel.Visible = true;
                return false;
            }
                 else
             {
                 PNamelabel.Visible=false;
             }
             if (String.IsNullOrEmpty(PricetextBox.Text.Trim()))
            {
                Pricelabel.Visible = true;
                return false;
            }
                else
             {
                 Pricelabel.Visible=false;
             }
             if (String.IsNullOrEmpty(QtytextBox.Text.Trim()))
            {
                Qtylabel.Visible = true;
                return false;
            }
             else
             {
                 Qtylabel.Visible = false;
             }
            
            return true;
        }

        private void QtytextBox_TextChanged(object sender, EventArgs e)
        {
            /*if (QtytextBox != null&&PricetextBox !=null)
            {
               
                    TotaltextBox.Text = (Convert.ToDouble(PricetextBox.Text) * Convert.ToDouble(QtytextBox.Text)).ToString();
                    QtytextBox.Enabled = true;
            }
                else if (QtytextBox.Text == null)
                {
                    TotaltextBox.Text = "";
                }*/

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
                MessageBox.Show("You are check out first save record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CheckOutbutton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSubTotal = Convert.ToDecimal(SubTotaltextBox.Text);
                NetTotaltextBox.Text = SubTotaltextBox.Text;
                DeleteValidation = 1;
                EmptyTexboxes();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void NetPaytextBox_TextChanged(object sender, EventArgs e)
        {
            if (NetPaytextBox.Text.Length != 0)
            {
                /*float Net, Pay, Blance;
                Net = Convert.ToSingle(NetTotaltextBox.Text);
                Pay = Convert.ToSingle(NetPaytextBox.Text);
                Blance = Pay - Net;
                BlancetextBox.Text = Blance.ToString();*/
                if (decimal.Parse(NetPaytextBox.Text) >= decimal.Parse(NetTotaltextBox.Text))
                {
                    BlancetextBox.Text = (decimal.Parse(NetPaytextBox.Text) - decimal.Parse(NetTotaltextBox.Text)).ToString();
                }
                else
                {
                    BlancetextBox.Text = null;
                }
            }
        }

        private void DistextBox_Validated(object sender, EventArgs e)
        {
            if (Dislabel.Visible)
            {
                /*//NetTotaltextBox.Text
                float Net, Dis, Total;
                Net = Convert.ToSingle(NetTotaltextBox.Text);
                Dis = Convert.ToSingle(DistextBox.Text);
                Total = Net - Dis;
                NetTotaltextBox.Text = Total.ToString();*/
                Dislabel.Visible = false;
            }
        }
        public void EmptyTexboxes()
        {
            ProductNamecomboBox.Text = null;
            PricetextBox.Text = null;
            QtytextBox.Text = null;
            RackNotextBox.Text = null;
            MultiplySubTotal = 0;
        }
        int E;
        private void Testbutton_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(Date.ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void DistextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal D, N;
               // D = Convert.ToDecimal(DistextBox.Text);
                //N = Convert.ToDecimal(NetTotaltextBox.Text);
                if (DistextBox.Text.Length>0 && NetTotaltextBox.Text.Length>0)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            Clear();
        }
        public bool TransactionValidation()
        {
            if (String.IsNullOrEmpty(DistextBox.Text))
            {
                Dislabel.Visible = true;
                return false;
            }
            else if(String.IsNullOrEmpty(NetTotaltextBox.Text))
            {
                NetTotallabel.Visible = true;
                return false;
            }
            else if (String.IsNullOrEmpty(NetPaytextBox.Text))
            {
                NetPaylabel.Visible = true;
                return false;
            }
            else if (String.IsNullOrEmpty(BlancetextBox.Text))
            {
                Blancelabel.Visible = true;
                return false;
            }
            return true;
        }

        private void NetTotaltextBox_Validated(object sender, EventArgs e)
        {
            if (NetTotallabel.Visible)
            {
                NetTotallabel.Visible = false;
            }
        }

        private void NetPaytextBox_Validated(object sender, EventArgs e)
        {
            if (NetPaylabel.Visible)
            {
                NetPaylabel.Visible = false;
            }
        }

        private void BlancetextBox_Validated(object sender, EventArgs e)
        {
            if (Blancelabel.Visible)
            {
                Blancelabel.Visible = false;
            }
        }
        
        
    }
}
