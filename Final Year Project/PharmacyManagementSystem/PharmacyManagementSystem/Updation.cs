using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace PharmacyManagementSystem
{
    class Updation
    {
        public void UpdateUser(String Name, String UserType, String UserName, String Password, String Contact, String Address, String Gender,int UserID,Int16 UserStatus)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateUserS", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@UserType", UserType);
                cmd.Parameters.AddWithValue("@UserName", UserName);
                cmd.Parameters.AddWithValue("@Password", Password);
                cmd.Parameters.AddWithValue("@Contact", Contact);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@UserId", UserID);
                cmd.Parameters.AddWithValue("@UserStatus", UserStatus);
                Db.Con.Open();
                int i = cmd.ExecuteNonQuery();
                Db.Con.Close();
                if (i > 0)
                {
                    AddUserS User = new AddUserS();
                    MainClass.ShowMessage(Name + " Successfully Updated", "Information", "Success");
                    MainClass.Disable_Rest(User.Leftpanel);
                }
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MainClass.ShowMessage(ex.Message, "Error", "Error");
            }
        }
        public void UpdateCatagory(String Name, Int16 IsActiveStatus,Int16 CatID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateCatagories", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Cat_Name", Name);
                cmd.Parameters.AddWithValue("@Cat_IsActive", IsActiveStatus);
                cmd.Parameters.AddWithValue("@Cat_Id", CatID);
                Db.Con.Open();
                int i = cmd.ExecuteNonQuery();
                Db.Con.Close();
                if (i > 0)
                {
                    MainClass.ShowMessage(Name + " Successfully Updated", "Success", "Success");
                }
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MainClass.ShowMessage(ex.Message, "Error", "Error");
            }
        }
        public void UpdateProducts(String PUnit, int PCatID, String PName,String PPower, float PPrice, float SalePrice, int Qty, String PRackNo, DateTime PExP, Int16 PID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateProducts", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
               // cmd.Parameters.AddWithValue("@P_ID", PID);
                cmd.Parameters.AddWithValue("@P_Unit", PUnit);
                cmd.Parameters.AddWithValue("@P_CatID", PCatID);
                cmd.Parameters.AddWithValue("@P_Name", PName);
                cmd.Parameters.AddWithValue("@P_Power", PPower);
                cmd.Parameters.AddWithValue("@P_Price", PPrice);
                cmd.Parameters.AddWithValue("@P_SalePrice", SalePrice);
                cmd.Parameters.AddWithValue("@P_Qty",Qty);
                cmd.Parameters.AddWithValue("@P_RackNo",PRackNo);
                cmd.Parameters.AddWithValue("@P_Date", PExP);
                cmd.Parameters.AddWithValue("@P_ID",PID);
                Db.Con.Open();
                int i = cmd.ExecuteNonQuery();
                Db.Con.Close();
                if (i > 0)
                {
                    MessageBox.Show(PName + " Successfully Updated", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void UpdateSuppliers(String SName, String SEMail, String SPhone, String SAddress, Int16 SStatus,Int16 SID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("UpdateSuppliers", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@S_Name", SName);
                cmd.Parameters.AddWithValue("@S_EMail", SEMail);
                cmd.Parameters.AddWithValue("@S_Phone", SPhone);
                cmd.Parameters.AddWithValue("@S_Address", SAddress);
                cmd.Parameters.AddWithValue("@S_Status", SStatus);
                cmd.Parameters.AddWithValue("@S_ID", SID);
                Db.Con.Open();
                int i = cmd.ExecuteNonQuery();
                Db.Con.Close();
                if (i > 0)
                {
                    MessageBox.Show(SName + " Updated Addeed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int i;
        public int IncreaseProductsQty(Int16 Qty, String PID,float PPrice)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("IncreaseProductsQty", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_Qty",Qty );
                cmd.Parameters.AddWithValue("@P_ID", PID);
                cmd.Parameters.AddWithValue("@P_Price", PPrice);
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
        int E;
        public int  DecreaseProductQty(Int16 Qty,String PID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DecreaseProductQty",Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_Qty", Qty);
               cmd.Parameters.AddWithValue("@P_ID", PID);
                Db.Con.Open();
                i = cmd.ExecuteNonQuery();
                Db.Con.Close();
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return E;
        }
        int Test;
        public int ItemQtyReturnThanUpdateSale(Int16 Qty,float Amount,String ProductName,String ItemCode,Int16 BillNo,float SubTotal,float NetTotal,float Blance,DateTime ReturnDate,String ReturnBy,Int16 ReturnProductID,String ReturnQty,Decimal ReturnAmount,String RDescription)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ItemQtyReturnThanUpdateSale",Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Qty", Qty);
                cmd.Parameters.AddWithValue("@Amount", Amount);
                cmd.Parameters.AddWithValue("@P_Name", ProductName);
                cmd.Parameters.AddWithValue("@ItemCode", ItemCode);
                cmd.Parameters.AddWithValue("@BillNo", BillNo);
                cmd.Parameters.AddWithValue("@SubTotal", SubTotal);
                cmd.Parameters.AddWithValue("@NetTotal", NetTotal);
                cmd.Parameters.AddWithValue("@Blance", Blance);
                cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                cmd.Parameters.AddWithValue("@ReturnBy", ReturnBy);
                cmd.Parameters.AddWithValue("@ReturnProductID", ReturnProductID);
                cmd.Parameters.AddWithValue("@ReturnQty", ReturnQty);
                cmd.Parameters.AddWithValue("@ReturnAmount", ReturnAmount);
                cmd.Parameters.AddWithValue("@RDescription", RDescription);
                Db.Con.Open();
                Test = cmd.ExecuteNonQuery();
                Db.Con.Close();
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return Test;
        }
    }
}
