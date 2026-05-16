using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Drawing;
namespace proje_hastane
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=Salih\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True;TrustServerCertificate=True");
            baglanti.Open();
            return baglanti;
        }

    }
}
