using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UykuSaatiTakip
{
    internal class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-S89STPQ\\SQLEXPRESS;Initial Catalog=DB_SleepWellUP;Integrated Security=True");
            con.Open();
            return con;
        }
    }
}
