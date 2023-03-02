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
    class ReturnOperations
    {
        SqlCommand cmd;
        SqlDataAdapter Sqlda;
        SqlDataReader Sqldr;
        int i;
        public int ReturnItem(Int16 SessionID,Int16 PCode,Int16 Qty,String P_NAME,DateTime ReturnDate,String ReturnBy,Int16 REturnProductID,Int16 ReturnProductQty,float ReturnAmount,String RDescription)
        {
            try
            {
                cmd = new SqlCommand("ReturnItem", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SessionID", SessionID);
                cmd.Parameters.AddWithValue("@PCode", PCode);
                cmd.Parameters.AddWithValue("@Qty", Qty);
                cmd.Parameters.AddWithValue("@P_Name", P_NAME);
                cmd.Parameters.AddWithValue("@ReturnDate",ReturnDate);
                cmd.Parameters.AddWithValue("@ReturnBy", ReturnBy);
                cmd.Parameters.AddWithValue("@ReturnProductID", REturnProductID);
                cmd.Parameters.AddWithValue("@ReturnQty", ReturnProductQty);
                cmd.Parameters.AddWithValue("@ReturnAmount", ReturnAmount);
                cmd.Parameters.AddWithValue("@RDescription", RDescription);
                Db.Con.Open();
                i = cmd.ExecuteNonQuery();
                Db.Con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return i;
        }
        public int SessionSaleReturn(Int16 SessionID, Int16 PCode, Int16 Qty, String PName, DateTime ReturnDate, String ReturnBy, Int16 ReturnProductID, Int16 ReturnQty, float ReturnAmount,String RDescription)
        {
            try
            {
                cmd = new SqlCommand("SessionSaleReturn",Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SessionID", SessionID);
                cmd.Parameters.AddWithValue("@PCode", PCode);
                cmd.Parameters.AddWithValue("@Qty", Qty);
                cmd.Parameters.AddWithValue("@P_Name", PName);
                cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                cmd.Parameters.AddWithValue("@ReturnBy", ReturnBy);
                cmd.Parameters.AddWithValue("@ReturnProductID", ReturnProductID);
                cmd.Parameters.AddWithValue("@ReturnQty", ReturnQty);
                cmd.Parameters.AddWithValue("@ReturnAmount", ReturnAmount);
                cmd.Parameters.AddWithValue("@RDescription", RDescription);
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
        public int TestProcedure(Int16 PCode, Int16 Qty, String PName)
        { 
            try
            {
                cmd = new SqlCommand("TestProcedure", Db.Con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PCode", PCode);
            cmd.Parameters.AddWithValue("@Qty", Qty);
            cmd.Parameters.AddWithValue("@P_Name", PName);
            Db.Con.Open();
            i = cmd.ExecuteNonQuery();
            Db.Con.Close();
            Db.Con.Close();
            }
            catch (Exception ex)
            {
                Db.Con.Close();
                MessageBox.Show(ex.Message);
            }
            return i;
        }
        public int RITUT(Int16 SessionID, float SubTotal, float NetTotal, float Blance, Int16 PID, Int16 Qty, int PCode, String PName, DateTime ReturnDate, String ReturnBy, Int16 ReturnProductID, Int16 ReturnQty, float ReturnAmount, String RDescription)
        {
            try
            {
                cmd = new SqlCommand("ReturnItemThanUpdateTrasaction", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@SessionID", SessionID);
                cmd.Parameters.AddWithValue("@SubTotal", SubTotal);
                cmd.Parameters.AddWithValue("@NetTotal", NetTotal);
                cmd.Parameters.AddWithValue("@Blance", Blance);
                cmd.Parameters.AddWithValue("@P_ID", PID);
                cmd.Parameters.AddWithValue("@Qty", Qty);
                cmd.Parameters.AddWithValue("@PCode", PCode);
                cmd.Parameters.AddWithValue("@P_Name", PName);
                cmd.Parameters.AddWithValue("@ReturnDate", ReturnDate);
                cmd.Parameters.AddWithValue("@ReturnBy", ReturnBy);
                cmd.Parameters.AddWithValue("@ReturnProductID", ReturnProductID);
                cmd.Parameters.AddWithValue("@ReturnQty", ReturnQty);
                cmd.Parameters.AddWithValue("@ReturnAmount", ReturnAmount);
                cmd.Parameters.AddWithValue("@RDescription", RDescription);
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
    }
}
