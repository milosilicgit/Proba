using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WindowsFormsApplication5
{
    public static class Konekcija
    {
        public static SqlConnection KonekcioniString()
        {

            string konStr = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Misa\documents\visual studio 2013\Projects\WindowsFormsApplication5\WindowsFormsApplication5\Database1.mdf;Integrated Security=True";

            SqlConnection con = new SqlConnection(konStr);

            return con;
        }
    }
}
