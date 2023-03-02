using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
namespace PharmacyManagementSystem
{
    class Retrivel
    {
        SqlCommand cmd;
        SqlDataAdapter sqlda;
        SqlDataReader sqldr;
        DataTable dt;
        DataSet DSet;
        bool Log;
      /*  Home Admin = new Home();
        Home1 SaleMan = new Home1();
        LogIn Log = new LogIn();*/
        public void ShowUsers(DataGridView GridView, DataGridViewColumn UserIdGridview, DataGridViewColumn Namegv, DataGridViewColumn USerTypeGv, DataGridViewColumn USerNAmeGv, DataGridViewColumn PAsswordGv, DataGridViewColumn ContactGv, DataGridViewColumn AddressGv, DataGridViewColumn GenderGv, DataGridViewColumn USerStatusgv,String Search = null)
        {
            try
            {
                if (Search == null)
                {
                    cmd = new SqlCommand("GetUser", Db.Con);
                }
                else
                {
                    cmd = new SqlCommand("SearchGetUser", Db.Con);
                    cmd.Parameters.AddWithValue("@SearchValue", Search);
                }
                 
                cmd.CommandType = CommandType.StoredProcedure;
                sqlda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlda.Fill(dt);
                UserIdGridview.DataPropertyName = dt.Columns["ID"].ToString();
                Namegv.DataPropertyName = dt.Columns["Name"].ToString();
                USerTypeGv.DataPropertyName = dt.Columns["User Type"].ToString();
                USerNAmeGv.DataPropertyName = dt.Columns["User Name"].ToString();
                PAsswordGv.DataPropertyName = dt.Columns["Password"].ToString();
                ContactGv.DataPropertyName =  dt.Columns["Contact"].ToString();
                AddressGv.DataPropertyName = dt.Columns["Address"].ToString();
                GenderGv.DataPropertyName = dt.Columns["Gender"].ToString();
                USerStatusgv.DataPropertyName = dt.Columns["Status"].ToString();
                GridView.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ShowCatagories(DataGridView Gridview,DataGridViewColumn CatIGridviewColum ,DataGridViewColumn NameGridviewColum, DataGridViewColumn IsActiveGridViewColum,String Search=null)
        {
            try
            {
                if (Search == null)
                {
                    cmd = new SqlCommand("GetCatagories", Db.Con);
                }
                else
                {
                    cmd = new SqlCommand("SearchCatgory", Db.Con);
                    cmd.Parameters.AddWithValue("@Search", Search);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sqlda.Fill(dt);
                CatIGridviewColum.DataPropertyName = dt.Columns["ID"].ToString();
                NameGridviewColum.DataPropertyName = dt.Columns["Catagory"].ToString();
                IsActiveGridViewColum.DataPropertyName = dt.Columns["Status"].ToString();
                Gridview.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.ShowMessage(ex.Message, "Error", "Error");
            }
        }
        public void GetCatagoryList( ComboBox Cb)
        {
            try
            {
              //  Cb.Items.Insert(0, "Select");
                Cb.DataSource = null;
                Cb.Items.Clear();
                cmd = new SqlCommand("GetCatagoriesList", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlda.Fill(dt);
                Cb.DisplayMember = "Catagory";
                Cb.ValueMember = "ID";
                Cb.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.ShowMessage(ex.Message, "Error", "Error");
            }
        }
        public void GetProducts(String Procedure,DataGridView Gridview,DataGridViewColumn PIDGridviewcolum,DataGridViewColumn PUnitGridviewColum,DataGridViewColumn PCatNameGridviewColum,DataGridViewColumn PCatIDGridviewColum,DataGridViewColumn PNameGridviewColum,DataGridViewColumn PPowerGridviewColum,DataGridViewColumn PPriceGridviewColum,DataGridViewColumn salepricegridviewcolum,DataGridViewColumn Qtydatagridviewcolum,DataGridViewColumn PRackNoGridviewColum,DataGridViewColumn PDateGridviewColum,String Search=null)
        {
            try
            {
                if(Search==null)
                {
                cmd = new SqlCommand(Procedure, Db.Con);
                }
                else
                {
                    cmd=new SqlCommand (Procedure,Db.Con);
                    cmd.Parameters.AddWithValue("@Search", Search);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                sqlda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlda.Fill(dt);
                PIDGridviewcolum.DataPropertyName = dt.Columns["Product ID"].ToString();
                PUnitGridviewColum.DataPropertyName = dt.Columns["Unit"].ToString();
                PCatNameGridviewColum.DataPropertyName = dt.Columns["Catagory"].ToString();
                PCatIDGridviewColum.DataPropertyName = dt.Columns["Catagory ID"].ToString();
                PNameGridviewColum.DataPropertyName = dt.Columns["Name"].ToString();
                PPowerGridviewColum.DataPropertyName = dt.Columns["Power"].ToString();
                PPriceGridviewColum.DataPropertyName = dt.Columns["Price"].ToString();
                salepricegridviewcolum.DataPropertyName = dt.Columns["Sale Price"].ToString();
                Qtydatagridviewcolum.DataPropertyName = dt.Columns["Qty"].ToString();
                PRackNoGridviewColum.DataPropertyName = dt.Columns["Rack"].ToString();
                PDateGridviewColum.DataPropertyName = dt.Columns["Date"].ToString();
                Gridview.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetSuppliers(DataGridView Gridview, DataGridViewColumn SIDGridviewcolum, DataGridViewColumn SNameGridviewcolum, DataGridViewColumn SEmailGridviewcolum, DataGridViewColumn SPhoneGridviewcolum, DataGridViewColumn SAddressGridviewColum, DataGridViewColumn SStatusGridviewColum,String Search=null)
        {
            try
            {
                if (Search == null)
                {
                    cmd = new SqlCommand("GetSuppliers", Db.Con);
                }
                else
                {
                    cmd = new SqlCommand("SearchSuppliers", Db.Con);
                    cmd.Parameters.AddWithValue("@Search", Search);
                }
                cmd.CommandType = CommandType.StoredProcedure;
                sqlda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlda.Fill(dt);
                SIDGridviewcolum.DataPropertyName = dt.Columns["ID"].ToString();
                SNameGridviewcolum.DataPropertyName = dt.Columns["Name"].ToString();
                SEmailGridviewcolum.DataPropertyName = dt.Columns["Email"].ToString();
                SPhoneGridviewcolum.DataPropertyName = dt.Columns["Phone"].ToString();
                SAddressGridviewColum.DataPropertyName = dt.Columns["Address"].ToString();
                SStatusGridviewColum.DataPropertyName = dt.Columns["Status"].ToString();
                Gridview.DataSource = dt;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void GetSuppliersList(ComboBox Cb)
        {
            try
            {
                Cb.DataSource = null;
                Cb.Items.Clear();
                cmd = new SqlCommand("GetSuppliersList",Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlda.Fill(dt);
                Cb.DisplayMember = "Name";
                Cb.ValueMember = "ID";
                Cb.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetProductsUsingBarcode(String Barcode,String ID,ComboBox Products,TextBox Price,Int16 Qty)
        {
            try{
                cmd = new SqlCommand("GetProductsThroughBarcode",Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_Barcode",Barcode);
                Db.Con.Open();
                sqldr = cmd.ExecuteReader();
                
                if (sqldr.HasRows)
                {
                    while (sqldr.Read())
                    {
                        ID =(String)  sqldr["ID"].ToString();
                        Products.Text = sqldr["Product Name"].ToString();
                        Price.Text = sqldr["Price"].ToString();
                        Qty = (Int16) Convert.ToInt16(sqldr["Qty"].ToString());
                       
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
        public void GetProductsThroughPName(String Id, TextBox Price,String ProductName,Int16 Qty)
        {
            try
            {
                cmd = new SqlCommand("GetProductsThroughProductName", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_Name", ProductName);
                Db.Con.Open();
                sqlda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlda.Fill(dt);
                int i = dt.Rows.Count;
                int n = 0;
                while (i>0)
                {
                    Id = dt.Rows[n][0].ToString();
                    Price.Text = dt.Rows[n][1].ToString();
                    Qty =Convert.ToInt16( dt.Rows[n][2].ToString());
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
        public void GetProductName(ComboBox Cb)
        {
            try
            {
                cmd = new SqlCommand("GetProductsName", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                sqlda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlda.Fill(dt);
                Cb.DisplayMember = "Name";
                Cb.ValueMember = "ID";
                Cb.DataSource = dt;
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void AutoCompleteProductName(ComboBox Cb)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SearchProductsThroughProductName", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                Db.Con.Open();
                AutoCompleteStringCollection Auto = new AutoCompleteStringCollection();
                sqlda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    Auto.Add(dr["P_Name"].ToString());
                }
                Db.Con.Close();
                Cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                Cb.AutoCompleteSource = AutoCompleteSource.CustomSource;
                Cb.AutoCompleteCustomSource = Auto;
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void GetBillNo(TextBox T)
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
                        T.Text = "1";
                    }
                    else
                    {//Generate BillNo
                        A = Convert.ToInt32(sqldr[0].ToString());
                        A = A + 1;
                        T.Text = A.ToString();
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
        public void GetPurchaseDeatils(DateTimePicker FromDate, DateTimePicker ToDate, DataGridView Gridview, DataGridViewColumn BillNoDGVColum, DataGridViewColumn BillDateDGVColum, DataGridViewColumn BillAmountDGVColum, DataGridViewColumn DisCountAmountDGVColum, DataGridViewColumn NetTotalDGVColum,DataGridViewColumn SupplierNameDGVColum)
        {
            try
            {
                cmd = new SqlCommand("GetPurchaseDetails", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FromBillDate", FromDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@ToBillDate", ToDate.Value.ToShortDateString());
                sqlda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlda.Fill(dt);
                BillNoDGVColum.DataPropertyName = dt.Columns["Invoice No"].ToString();
                BillDateDGVColum.DataPropertyName = dt.Columns["Date"].ToString();
                BillAmountDGVColum.DataPropertyName = dt.Columns["Sub Total"].ToString();
                DisCountAmountDGVColum.DataPropertyName = dt.Columns["Dis"].ToString();
                NetTotalDGVColum.DataPropertyName = dt.Columns["Net Total"].ToString();
                SupplierNameDGVColum.DataPropertyName = dt.Columns["Supplier Name"].ToString();
                Gridview.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        ReportDocument Crpt = new ReportDocument();
        public void PurchaseInvoice(String Procedure,String Parameter,String BillNo,CrystalReportViewer RPT)
        {
            try
            {
                
                cmd = new SqlCommand(Procedure,Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(Parameter,BillNo);
                sqlda = new SqlDataAdapter(cmd);
                DSet = new DataSet();
                Db.Con.Open();
                sqlda.Fill(DSet, "PurchaseInvoice");
                Crpt.Load("PurchaseInvoice.rpt");
                Crpt.SetDataSource(DSet);
                Db.Con.Close();
                RPT.ReportSource = Crpt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void AllPurchaseReport(DateTimePicker FromDate ,DateTimePicker ToDate,CrystalReportViewer RPT)
        {
            try
            {

                cmd = new SqlCommand("GetAllPurchaseReport", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FromBillDate", FromDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@ToBillDate", ToDate.Value.ToShortDateString());
                sqlda = new SqlDataAdapter(cmd);
                DSet = new DataSet();
                Db.Con.Open();
                sqlda.Fill(DSet, "AllPurchaseReport");
                Crpt.Load("AllPurchaseSummary.rpt");
                Crpt.SetDataSource(DSet);
                Db.Con.Close();
                RPT.ReportSource = Crpt;

            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void PurchaseTransactionReport(DateTimePicker FromDate,DateTimePicker ToDate,CrystalReportViewer CRV)
        {
            try
            {
                sqlda = new SqlDataAdapter("PurchaseTransactionReport",Db.Con);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("@FromBillDate", FromDate.Value.ToShortDateString());
                sqlda.SelectCommand.Parameters.AddWithValue("@ToBillDate", ToDate.Value.ToShortDateString());
                DSet = new DataSet();
                Db.Con.Open();
                sqlda.Fill(DSet, "PurchaseTransactionReport");
                Crpt.Load("PurchaseReport.rpt");
                Crpt.SetDataSource(DSet);
                Db.Con.Close();
                CRV.ReportSource = Crpt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetSaleBillNo(TextBox T)
        {
            try
            {
                int A;
                cmd = new SqlCommand("GetSaleBillNo", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                Db.Con.Open();
                sqldr = cmd.ExecuteReader();
                if (sqldr.Read())
                {
                    String val = sqldr[0].ToString();
                    if (val == "")
                    {
                        T.Text = "1";
                    }
                    else
                    {//Generate BillNo
                        A = Convert.ToInt32(sqldr[0].ToString());
                        A = A + 1;
                        T.Text = A.ToString();
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
        public void GetSaleInvoice(String BillNo,CrystalReportViewer Rpt)
        {
            try
            {
                sqlda = new SqlDataAdapter("SaleInvoice", Db.Con);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue("@SessionID", BillNo);
                DSet = new DataSet();
                Db.Con.Open();
                sqlda.Fill(DSet, "SaleInvoice");
                Crpt.Load("SaleInvoice.rpt");
                Crpt.SetDataSource(DSet);
                Db.Con.Close();
                Rpt.ReportSource = Crpt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetSaleDetails(DateTimePicker FromDate, DateTimePicker ToDate, DataGridView DGV, DataGridViewColumn InvoiceNoDGVColum,DataGridViewColumn DateDGVColum, DataGridViewColumn SubTotalDGVColum,DataGridViewColumn DisDGVColum,DataGridViewColumn NetTotalDGVColum )
        {
            
                cmd = new SqlCommand("GetSaleDetails", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FromBillDate", FromDate.Value.ToString());
                cmd.Parameters.AddWithValue("@ToBillDate", ToDate.Value.ToString());
                dt = new DataTable();
                sqlda = new SqlDataAdapter(cmd);
                sqlda.Fill(dt);
                InvoiceNoDGVColum.DataPropertyName = dt.Columns["Bill No"].ToString();
                DateDGVColum.DataPropertyName = dt.Columns["Bill Date"].ToString();
                SubTotalDGVColum.DataPropertyName = dt.Columns["Sub Total"].ToString();
                DisDGVColum.DataPropertyName = dt.Columns["Dis"].ToString();
                NetTotalDGVColum.DataPropertyName = dt.Columns["Net Total"].ToString();              
                DGV.DataSource = dt;
            
        }
        public void SaleReport(String Procedure,String FromPram,String ToPram,String DataSet,String RName,DateTimePicker FromDate, DateTimePicker ToDate, CrystalReportViewer CRV)
        {
            try
            {
                sqlda = new SqlDataAdapter(Procedure, Db.Con);
                sqlda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlda.SelectCommand.Parameters.AddWithValue(FromPram, FromDate.Value.ToShortDateString());
                sqlda.SelectCommand.Parameters.AddWithValue(ToPram, ToDate.Value.ToShortDateString());
                DSet = new DataSet();
                Db.Con.Open();
                sqlda.Fill(DSet, DataSet);
                Crpt.Load(RName);
                Crpt.SetDataSource(DSet);
                Db.Con.Close();
                CRV.ReportSource = Crpt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetSaleReturnDetailsThroughSeesionId(DataGridView DGV,String SessionID, DataGridViewColumn ItemIDDGVColum, DataGridViewColumn ItemNameDGVColum, DataGridViewColumn SalePriceDGVColum, DataGridViewColumn QtyDGVColum, DataGridViewColumn AmountDGVColum, DataGridViewColumn TotalAmountDGVColum, DataGridViewColumn DisDGVColum, DataGridViewColumn NetTotalDGVColum, DataGridViewColumn PayDGVColum, DataGridViewColumn BlanceDGVColum,  DataGridViewColumn SessionIDDGVColum,DataGridViewColumn DateDGVColum)
        {
            try
            {
                cmd = new SqlCommand("GetSaleReturnDataThroughSessionId",Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BillNo", SessionID);
                sqlda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlda.Fill(dt);
                ItemIDDGVColum.DataPropertyName = dt.Columns["Item Id"].ToString();
                ItemNameDGVColum.DataPropertyName = dt.Columns["Item Name"].ToString();
                SalePriceDGVColum.DataPropertyName = dt.Columns["Sale Price"].ToString();
                QtyDGVColum.DataPropertyName = dt.Columns["Qty"].ToString();
                AmountDGVColum.DataPropertyName = dt.Columns["Amount"].ToString();
                TotalAmountDGVColum.DataPropertyName = dt.Columns["Sub Total"].ToString();
                DisDGVColum.DataPropertyName = dt.Columns["Dis"].ToString();
                NetTotalDGVColum.DataPropertyName = dt.Columns["Net Total"].ToString();
                PayDGVColum.DataPropertyName = dt.Columns["Net Pay"].ToString();
                BlanceDGVColum.DataPropertyName = dt.Columns["Blance"].ToString();
                SessionIDDGVColum.DataPropertyName = dt.Columns["Seession ID"].ToString();
                DateDGVColum.DataPropertyName = dt.Columns["Date"].ToString();
                DGV.DataSource = dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetSessionID(Int16 SessionID)
        {
            try
            {
                cmd = new SqlCommand("GetSessionID", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                Db.Con.Open();
                 sqldr = cmd.ExecuteReader();
                 if (sqldr.Read())
                 {
                     SessionID = Convert.ToInt16(sqldr[0].ToString());
                 }

                Db.Con.Close();
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message);
            }
        }
        public void SearchProductS(Int16 PCatID,String PName,Decimal Price)
        {

        }
        public void GetSaleReturnDetails(DateTimePicker FromDate,DateTimePicker ToDate,DataGridView DGV,DataGridViewColumn SessionIDDGVColum,DataGridViewColumn DateDGVColum,DataGridViewColumn ReturnByDGVColum,DataGridViewColumn PNameDGVColum,DataGridViewColumn QtyDGVColum,DataGridViewColumn ReturnAmountDGVColum,DataGridViewColumn DescriptionDGVColum)
        {
            try
            {
                cmd = new SqlCommand("SaleReturnDetails", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FromDate", FromDate.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@ToDate", ToDate.Value.ToShortDateString());
                sqlda = new SqlDataAdapter(cmd);
                dt = new DataTable();
                sqlda.Fill(dt);
                SessionIDDGVColum.DataPropertyName = dt.Columns["Session ID"].ToString();
                DateDGVColum.DataPropertyName = dt.Columns["Date"].ToString();
                ReturnByDGVColum.DataPropertyName = dt.Columns["Return By"].ToString();
                PNameDGVColum.DataPropertyName = dt.Columns["Product Name"].ToString();
                QtyDGVColum.DataPropertyName = dt.Columns["Return Qty"].ToString();
                ReturnAmountDGVColum.DataPropertyName = dt.Columns["Return Amount"].ToString();
                DescriptionDGVColum.DataPropertyName = dt.Columns["Description"].ToString();
                DGV.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "PHMS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static String Name
        {
            get;
            private set;
        }
        public static String UType
        {
            get;
            private set;
        }
        String UserLoginName, UPassword;
        public bool Login(String UserName,ComboBox UserType,String Password)
        {
            try
            {
                cmd = new SqlCommand("UserLogin",Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@UserType", UserType.Text);
                cmd.Parameters.AddWithValue("@Password", Password);
                Db.Con.Open();
                sqldr = cmd.ExecuteReader();
                if (sqldr.HasRows)
                {
                    Log = true;
                    while (sqldr.Read())
                    {
                        Name = sqldr["Name"].ToString();
                        UserLoginName = sqldr["User Name"].ToString();
                        UType = sqldr["User Type"].ToString();
                        UPassword = sqldr["Password"].ToString();
                    }
                }
                else
                {
                    /*if (UserLoginName != UserName)
                    {
                        MessageBox.Show("User Name Not Match");
                    }
                    else if (UType != UserType.Text)
                    {
                        MessageBox.Show("User Type Not Match");
                    }
                    else if (UPassword != Password)
                    {
                        MessageBox.Show("Password Not Match");
                    }*/
                    Log = false;
                    MessageBox.Show("Not Match");
                }
                Db.Con.Close();
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message);
            }
            return Log;
        }
        
    }
}
