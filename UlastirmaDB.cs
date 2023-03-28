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

        public SqlConnection baglanti = new SqlConnection("Data Source=TB701-5887;Initial Catalog=Ulastirma;Integrated Security=True;MultipleActiveResultSets=True");
        DataTable tablo =new DataTable();
    
    public void ekle_sil_guncelle(SqlCommand komut, string sorgu)
        {
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Close();
                baglanti.Open();
            }
            komut.Connection=baglanti;
            komut.CommandText=sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();

        }
        public DataTable listele(SqlDataAdapter adtr, string sorgu)
        {
            tablo = new DataTable();
            adtr = new SqlDataAdapter(sorgu,baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        public void Araclar(ComboBox combo1, string sorgu)
        {
            combo1.Items.Clear();

            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Close();
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo1.Items.Add(read["PLAKA"].ToString());

            }
            baglanti.Close();
        }
        public void bosAraclar( ComboBox combo1, ComboBox combo2, ComboBox combo3, string sorgu)
        {
            combo1.Items.Clear();
            combo2.Items.Clear();
            combo3.Items.Clear();

            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Close();
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                combo1.Items.Add(read["PLAKA"].ToString());
                combo2.Items.Add(read["MARKA"].ToString());
                combo3.Items.Add(read["SERI"].ToString());

            }
            baglanti.Close();
        }
        public void PerGoster(TextBox txt1,TextBox txt2,TextBox txt3, 
            TextBox txt4, TextBox txt5, string sorgu)
        {
            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Close();
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt1.Text = read["ad"].ToString();
                txt2.Text = read["soyad"].ToString();
                txt3.Text = read["SINIFI"].ToString();
                txt4.Text = read["RUTBESI"].ToString();
                txt5.Text = read["SICILI"].ToString();
            }
            baglanti.Close();
        }
        public void PlakaileGoster(ComboBox txt1, ComboBox txt2, ComboBox txt3, string sorgu)
        {
            
            txt2.Items.Clear();
            txt3.Items.Clear();

            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Close();
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt1.SelectedItem = read["PLAKA"].ToString();
                txt2.Items.Add(read["MARKA"].ToString());
                txt3.Items.Add(read["SERI"].ToString());
                
            }
            baglanti.Close();

        }
        public void MarkaileGoster(ComboBox txt1, ComboBox txt2, ComboBox txt3, string sorgu)
        {
            txt1.Items.Clear();
            txt3.Items.Clear();

            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Close();
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt2.SelectedItem = read["MARKA"].ToString();
                txt1.Items.Add(read["PLAKA"].ToString());
                txt3.Items.Add(read["SERI"].ToString());

            }
            baglanti.Close();

        }
        public void SeriileGoster(ComboBox txt1, ComboBox txt2, ComboBox txt3, string sorgu)
        {
            txt2.Items.Clear();
            txt1.Items.Clear();
            

            if (baglanti.State != ConnectionState.Open)
            {
                baglanti.Close();
                baglanti.Open();
            }
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txt3.SelectedItem = read["SERI"].ToString();
                txt2.Items.Add(read["MARKA"].ToString());
                txt1.Items.Add(read["PLAKA"].ToString());

            }
            baglanti.Close();

        }
    }
}
