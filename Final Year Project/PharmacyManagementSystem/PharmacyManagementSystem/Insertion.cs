using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
namespace PharmacyManagementSystem
{
    class Insertion
    {
        SqlCommand cmd;
        public void InsertIntoUser(String Name,String UserType,String UserName,String Password,String Contact,String Address,String Gender,Int16 UserStatus)
        {
            try 
	           {	        
		        cmd=new SqlCommand ("InsertUser",Db.Con);
                cmd.CommandType=CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name",Name);
                cmd.Parameters.AddWithValue("@UserType",UserType);
                cmd.Parameters.AddWithValue("@UserName",UserName);
                cmd.Parameters.AddWithValue("@Password",Password);
                cmd.Parameters.AddWithValue("@Contact",Contact);
                cmd.Parameters.AddWithValue("@Address",Address);
                cmd.Parameters.AddWithValue("@Gender",Gender);
                cmd.Parameters.AddWithValue("@UserStatus", UserStatus);
                Db.Con.Open();
                int i=cmd.ExecuteNonQuery();
                Db.Con.Close();
                if (i>0)
              	{
                    MainClass.ShowMessage(Name + " Successfully Insert", "Information", "Success");
	            }
	           }
	         catch (Exception ex)
	           {
                   Db.Con.Close();
                   MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	            }
        }
        public void InsertCatagory(String Name, Int16 IsActtiveStatus)
        {
            try
            {
                cmd = new SqlCommand("InsertCatagories", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cat_Name", Name);
                cmd.Parameters.AddWithValue("@Cat_IsActive", IsActtiveStatus);
                Db.Con.Open();
                int i = cmd.ExecuteNonQuery();
                Db.Con.Close();
                if (i > 0)
                {
                    MainClass.ShowMessage(Name + " Successfully Saved", "Information", "Success");
                }
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MainClass.ShowMessage(ex.Message, "Error", "Error");
            }

        }
        public void InsertProducts( String PUnit, int PCatID, String PName,String PPower, float PPrice, float SalePrice,Int16 Qty,String PRackNo, DateTime? PExP)
        {
            try 
	       {	        
		    SqlCommand cmd = new SqlCommand("InsertProducts",Db.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@P_Unit", PUnit);
            cmd.Parameters.AddWithValue("@P_CatID", PCatID);
            cmd.Parameters.AddWithValue("@P_Name", PName);
            cmd.Parameters.AddWithValue("@P_Power", PPower);
            cmd.Parameters.AddWithValue("@P_Price", PPrice);
            cmd.Parameters.AddWithValue("@P_SalePrice",SalePrice);       
            cmd.Parameters.AddWithValue("@P_Qty", Qty);
            cmd.Parameters.AddWithValue("@P_RackNo",PRackNo);
            cmd.Parameters.AddWithValue("@P_Date", PExP);
            Db.Con.Open();
            int i = cmd.ExecuteNonQuery();
            Db.Con.Close();
            if (i > 0)
            {
                MessageBox.Show(PName+" Successfully Addedd","information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
	        }
	       catch (Exception ex)
	      {
              Db.Con.Close();
		      MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
	     }
         }
        public void InsertSuppliers(String SName,String SEMail,String SPhone,String SAddress,Int16 SStatus)
        {
            try
            {
                cmd = new SqlCommand("InsertSuppliers",Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@S_Name", SName);
                cmd.Parameters.AddWithValue("@S_EMail", SEMail);
                cmd.Parameters.AddWithValue("@S_Phone", SPhone);
                cmd.Parameters.AddWithValue("@S_Address", SAddress);
                cmd.Parameters.AddWithValue("@S_Status", SStatus);
                Db.Con.Open();
                int i = cmd.ExecuteNonQuery();
                Db.Con.Close();
                if(i>0)
                {
                    MessageBox.Show(SName + " Successfully Addeed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void InsertPurchaseHeaderData(String Procedure ,String BillNo,DateTime BillDate,float Subtotal,float? Dis,float? NetTotal,float? NetPay,float? Blance,String Supplier,String DoneBy)
        {
            try
            {
                cmd = new SqlCommand(Procedure, Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BillNo", BillNo);
                cmd.Parameters.AddWithValue("@BillDate", BillDate);
                cmd.Parameters.AddWithValue("@BillAmount", Subtotal);
                cmd.Parameters.AddWithValue("@DiscountAmount", Dis);
                cmd.Parameters.AddWithValue("@NetTotal", NetTotal);
                cmd.Parameters.AddWithValue("@NetPay", NetPay);
                cmd.Parameters.AddWithValue("@Blance", Blance);
                cmd.Parameters.AddWithValue("@SupplierName", Supplier);
                cmd.Parameters.AddWithValue("@DoneBy", DoneBy);
                Db.Con.Open();
                int i = cmd.ExecuteNonQuery();
                Db.Con.Close();
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int i;
        public int InsertPurchaseRowData(String Procedure ,String PName, float Price, Int16 Qty, float Amount, String Billno,DateTime BillDate)
        {
            try
            {
                cmd = new SqlCommand(Procedure, Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", PName);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Qty", Qty);
                cmd.Parameters.AddWithValue("@Amount", Amount);
                cmd.Parameters.AddWithValue("@BillNo", Billno);
                cmd.Parameters.AddWithValue("@Date", BillDate);
                Db.Con.Open();
                i = cmd.ExecuteNonQuery();
                Db.Con.Close();
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i;
        }

        public void InsertSaleHeaderData(String Procedure,Int16 SessionID, DateTime BillDate, float Subtotal, float? Dis, float? NetTotal, float? NetPay, float? Blance,String DoneBy)
        {
            try
            {
                cmd = new SqlCommand(Procedure, Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SessionID",SessionID);
                cmd.Parameters.AddWithValue("@BillDate", BillDate);
                cmd.Parameters.AddWithValue("@SubTotal", Subtotal);
                cmd.Parameters.AddWithValue("@DIS", Dis);
                cmd.Parameters.AddWithValue("@NetTotal", NetTotal);
                cmd.Parameters.AddWithValue("@NetPay", NetPay);
                cmd.Parameters.AddWithValue("@Blance", Blance);
                cmd.Parameters.AddWithValue("@DoneBy", DoneBy);
                Db.Con.Open();
                int i = cmd.ExecuteNonQuery();
                Db.Con.Close();
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int InsertSaleRowData(String ItemCode, String PName, float Price, Int16 Qty, float Amount,Int16 SessionID, DateTime BillDate)
        {
            try
            {
                cmd = new SqlCommand("InsertSaleRowData", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("@ProductName", PName);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Qty", Qty);
                cmd.Parameters.AddWithValue("@Amount", Amount);
                cmd.Parameters.AddWithValue("@SessionID", SessionID);
                cmd.Parameters.AddWithValue("@BillDate", BillDate);
                Db.Con.Open();
                i = cmd.ExecuteNonQuery();
                Db.Con.Close();
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return i;
        }
        public int InsertSaleDeatails(String SessionID,DateTime Date,Int16 PCode,String PName,float Price,Int16 Qty,float Amount,float SubTotal,float Dis,float NetTotal,float Pay,float Blance,String SaleMan)
        {
            try
            {
                cmd = new SqlCommand("InsertSaleDetail", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SessionID", SessionID);
               cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@PCode", PCode);
                cmd.Parameters.AddWithValue("@P_Name", PName);
                cmd.Parameters.AddWithValue("@P_Price", Price);
                cmd.Parameters.AddWithValue("@Qty", Qty);
                cmd.Parameters.AddWithValue("@Amount", Amount);
                cmd.Parameters.AddWithValue("@SubTotal", SubTotal);
                cmd.Parameters.AddWithValue("@Dis", Dis);
                cmd.Parameters.AddWithValue("@NetTotal", NetTotal);
                cmd.Parameters.AddWithValue("@Pay", Pay);
                cmd.Parameters.AddWithValue("@Blance", Blance);
                cmd.Parameters.AddWithValue("@SaleMan", SaleMan);
                Db.Con.Open();
                i = cmd.ExecuteNonQuery();
                Db.Con.Close();
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message);
            }
            return i;
        }
        
    }
}
