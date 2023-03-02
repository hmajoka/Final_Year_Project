using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
namespace PharmacyManagementSystem
{
    public partial class AllReturns : Form
    {
        String Date = DateTime.Now.ToString();
        DateTime D = DateTime.Now;
        public AllReturns()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("insert into TableRowData(Date) values('" + Date + "')", Db.Con);
                Db.Con.Open();
                int i = cmd.ExecuteNonQuery();
                Db.Con.Close();
                if (i>0)
                {
                    MessageBox.Show("Success");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(D.ToString());
        }
    }
}
