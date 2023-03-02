using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
namespace PharmacyManagementSystem
{
    class Db
    {
        private static String Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);//ConnectionString File In My DocumentS
        public static String ConRead = File.ReadAllText(Path + "//ConnectionString");//Than WE Read That File And Store Into ConRead
        public static SqlConnection Con = new SqlConnection(ConRead);
    }
}
