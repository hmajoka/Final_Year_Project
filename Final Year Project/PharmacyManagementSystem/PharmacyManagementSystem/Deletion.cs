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
    class Deletion
    {
        int i;
        public int Delete(Object id, String Proc, String Param)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(Proc, Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(Param, id);
                Db.Con.Open();
                i=cmd.ExecuteNonQuery();
                Db.Con.Close();
            }
            catch (Exception ex)
            {
                Db.Con.Close();

                MainClass.ShowMessage(ex.Message, "Error", "Error");
            }
            return i;
        }
        public void DeleteProducts(Int16 PID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteProducts", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@P_ID", PID);
                Db.Con.Open();
                 i = cmd.ExecuteNonQuery();
                Db.Con.Close();
                if (i > 0)
                {
                    MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void DeleteSupplirs(Int16 SID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeleteSuppliers", Db.Con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@S_ID", SID);
                Db.Con.Open();
                i = cmd.ExecuteNonQuery();
                Db.Con.Close();
                if (i > 0)
                {
                    MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
