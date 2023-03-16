using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje
{
    internal class UlastirmaDB
    {
        //alttaki kotları ne kadar connection istiyorsak o kadar çok kopyalayacağız

        public SqlConnection baglanti = new SqlConnection("Data Source=TB701-5887;Initial Catalog=Ulastirma;Integrated Security=True");
        DataTable tablo;

        public void ekle_sil_guncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection=baglanti;
            komut.CommandText=sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

    }
}
