using DevExpress.XtraEditors.Filtering.Templates;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    class Veritabani
    {
      public static  SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ASIYA;Initial Catalog=InternetCafe;Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False");
    public static DataTable SepetListele(DataGridView gridView)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select*from Tbl_Sepet", baglanti);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            gridView.DataSource = tbl;
            return tbl;
        }
        public static DataTable Listele(DataGridView gridView,string sorgu)
        {
            SqlDataAdapter adtr = new SqlDataAdapter(sorgu, baglanti);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            gridView.DataSource = tbl;
            return tbl;
        }
        public static DataTable ComboyaBosMasaGetir(ComboBox combo)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from Tbl_Masalar where Durumu='Boş'", baglanti);
            DataTable tbl = new DataTable();
            adtr.Fill(tbl);
            combo.DataSource = tbl;
            combo.DisplayMember = "Masalar";
            combo.ValueMember = "MasaID";
            baglanti.Close();
            return tbl;
        }

        public static void ESG(SqlCommand Command, string sorgu)
        {
            baglanti.Open();
            Command.Connection = baglanti;
            Command.CommandText = sorgu;
            Command.ExecuteNonQuery();
            baglanti.Close(); 
        }
        public static SqlDataReader ListviewdeKayitlariGoster(ListView list)
        {
            list.Items.Clear();
            baglanti.Open();
            SqlCommand cmd = new SqlCommand("select*from Tbl_Hareketler where Tarih>=@Tarih", baglanti);
            cmd.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToShortDateString()));
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dr[0].ToString();
                ekle.SubItems.Add(dr[1].ToString());
                ekle.SubItems.Add(dr[2].ToString());
                ekle.SubItems.Add(dr[3].ToString());
                ekle.SubItems.Add(dr[4].ToString());
                ekle.SubItems.Add(dr[5].ToString());
                ekle.SubItems.Add(dr[6].ToString());
                list.Items.Add(ekle);
            }
            baglanti.Close();
            return dr;
        }
    }
}
