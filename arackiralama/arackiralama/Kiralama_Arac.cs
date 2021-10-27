using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace arackiralama
{
    
    class Kiralama_Arac
    {
        SqlConnection baglanti = new SqlConnection("Data Source = DESKTOP - 1H5NTHC\\SQLEXPRESS; Initial Catalog = kiralamaoto; Integrated Security = True");
        DataTable tablo;
        public DataTable listeleme(SqlDataAdapter adtr,string sorgu)
        {
            tablo = new DataTable();
            adtr = new  SqlDataAdapter(sorgu,baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        public void ekle_sil_guncelle(SqlCommand komut, string sorgu)
        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
