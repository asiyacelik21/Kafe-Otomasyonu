using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.Skins;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class frmSatis: Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ASIYA;Initial Catalog=InternetCafe;Integrated Security=True;Pooling=False;Encrypt=False;TrustServerCertificate=False");
        private void frmSatis_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'internetCafeDataSet.Tbl_SaatUcreti' table. You can move, or remove it, as needed.
            this.tbl_SaatUcretiTableAdapter.Fill(this.internetCafeDataSet.Tbl_SaatUcreti);
            rdbtnSuresiz.Checked = true;
            Yenile();
            cmbBosMasalar.Text = "";
            timer1.Start();
        }

        public void Yenile()
        {
            Veritabani.SepetListele(dataGridView1);
            Veritabani.ListviewdeKayitlariGoster(listView1);
            Veritabani.ComboyaBosMasaGetir(cmbBosMasalar);
           
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    if (item.Name != btnMasaAc.Name)
                    {
                        Veritabani.baglanti.Open();
                        SqlCommand komut = new SqlCommand("select *from Tbl_Masalar",Veritabani. baglanti);
                        SqlDataReader dr = komut.ExecuteReader();
                        while (dr.Read())
                        {
                            if (dr["Durumu"].ToString() == "Boş" && dr["Masalar"].ToString() == item.Text)
                            {
                                item.BackColor = Color.LightGreen;
                            }
                            if (dr["Durumu"].ToString() == "Dolu" && dr["Masalar"].ToString() == item.Text)
                            {
                                item.BackColor = Color.OrangeRed;
                            }
                        }
                       Veritabani. baglanti.Close();
                    }
                }
            }
        }


        Button btn;
        private void SecileneGore(object sender, MouseEventArgs e)
        {
            btn = sender as Button;
            if(btn.BackColor==Color.OrangeRed)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem.Visible = false;
            }
            if (btn.BackColor == Color.LightGreen)
            {
                süreliMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
                süresizMasaAçmaİsteğiGönderToolStripMenuItem.Visible = true;
            }
        }
        RadioButton radio;
        private void RadioButtonSeciliyeGore(object sender, EventArgs e)
        {
            radio = sender as RadioButton;
        }

        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            if (Kullanici.KullaniciID==1)
            {
                string sqlsorgu = "insert into Tbl_Sepet (MasaID,Masa,AcilisTuru,Baslangic,Tarih) values('" + cmbBosMasalar.Text.Substring(5) + "'" +
                    ",'" + cmbBosMasalar.Text + "','" + radio.Text + "',@Baslangic,@Tarih)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.AddWithValue("@Baslangic", DateTime.Parse(DateTime.Now.ToString()));
                komut.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToString()));
                Veritabani.ESG(komut, sqlsorgu);
                MessageBox.Show(cmbBosMasalar.Text.Substring(5) + "nolu masa açıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Yenile();
                rdbtnSuresiz.Checked = true;
                
            }
            else
            {
                MessageBox.Show("böyle bir yetkiniz bulunmuyor","Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Hesapla"].Index)
            {
                if(cmbSaatUcreti.Text !="")
                {
                    DateTime BitisTarihi = DateTime.Now;
                    DateTime BaslangicTarihi = DateTime.Parse(dataGridView1.CurrentRow.Cells["BaslamaSaati"].Value.ToString());
                    TimeSpan saatfarki = BitisTarihi - BaslangicTarihi;
                    double saatfarki2 = saatfarki.TotalHours;
                    dataGridView1.CurrentRow.Cells["Sure"].Value = saatfarki2.ToString("0.00");
                    double toplamtutar = saatfarki2 * double.Parse(cmbSaatUcreti.Text);
                    dataGridView1.CurrentRow.Cells["Tutar"].Value = toplamtutar.ToString("0.00");
                    dataGridView1.CurrentRow.Cells["BitisSaati"].Value = BitisTarihi;
                }
                if(cmbSaatUcreti.Text=="")
                {
                    MessageBox.Show("önce saat ücreti belirtilmelidir", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (e.ColumnIndex == dataGridView1.Columns["MasaKapat"].Index)
            {
                if (dataGridView1.CurrentRow.Cells["BitisSaati"].Value!=null)
                {
                    frmMasaKapat frm = new frmMasaKapat();
                    frm.txtID.Text = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                    frm.txtMasaID.Text = dataGridView1.CurrentRow.Cells["Masa_ID"].Value.ToString();
                    frm.txtMasa.Text = dataGridView1.CurrentRow.Cells["_Masa"].Value.ToString();
                    frm.txtAcilisTuru.Text = dataGridView1.CurrentRow.Cells["AcilisTuru"].Value.ToString();
                    frm.txtBaslamaSaati.Text = dataGridView1.CurrentRow.Cells["BaslamaSaati"].Value.ToString();
                    frm.txtBitisSaati.Text = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
                    frm.txtSaatUcreti.Text = cmbSaatUcreti.Text;
                    frm.txtSure.Text = dataGridView1.CurrentRow.Cells["Sure"].Value.ToString();
                    frm.txtTutar.Text = dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
                    frm.txtTarih.Text = dataGridView1.CurrentRow.Cells["_Tarih"].Value.ToString();
                    frm.ShowDialog();
                }
               else  if (dataGridView1.CurrentRow.Cells["BitisSaati"].Value == null)
                {
                    MessageBox.Show("Önce Hesaplama Yapılmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
        }
        string Istek = "";
        private void yöneticiÇağırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Istek = "yöneticiyi çağırıyor";
            Istekler();
        }

        private void Istekler()
        {
            string sqlsorgu = "insert into Tbl_Hareketler (KullaniciID,MasaID,Masa,IstekTuru,Aciklama,Tarih)values ("+"'" + Kullanici.KullaniciID + "','" + btn.Text.Substring(5) + "','" + btn.Text + "','" + Istek + "','yapılmadı',@Tarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.AddWithValue("@Tarih", DateTime.Parse(DateTime.Now.ToString()));
            Veritabani.ESG(komut, sqlsorgu);
            Veritabani.ListviewdeKayitlariGoster(listView1);
        }

        private void süresizMasaAçmaİsteğiGönderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Istek = "süresiz masa açma isteği gönder";
            Istekler();
        }

        private void masadegistirmeistegigonder_Click(object sender, EventArgs e)
        {
            Istek = "masa değiştirme isteği gönder";
            Istekler();
        }

        ToolStripMenuItem item;
        private void SureliIstekSecilirse(object sender, EventArgs e)
        {
            item = sender as ToolStripMenuItem;
            Istek = item.Text + "dk süre ile masa açma isteği gönder";
            Istekler();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;
            if(sayac>29)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (cmbSaatUcreti.Text != "")
                    {
                        DateTime BitisTarihi = DateTime.Now;
                        DateTime BaslangicTarihi = DateTime.Parse(dataGridView1.Rows[i].Cells["BaslamaSaati"].Value.ToString());
                        TimeSpan saatfarki = BitisTarihi - BaslangicTarihi;
                        double saatfarki2 = saatfarki.TotalHours;
                        dataGridView1.Rows[i].Cells["Sure"].Value = saatfarki2.ToString("0.00");
                        double toplamtutar = saatfarki2 * double.Parse(cmbSaatUcreti.Text);
                        dataGridView1.Rows[i].Cells["Tutar"].Value = toplamtutar.ToString("0.00");
                        dataGridView1.Rows[i].Cells["BitisSaati"].Value = BitisTarihi;
                    }
                    if (cmbSaatUcreti.Text == "")
                    {
                        MessageBox.Show("önce saat ücreti belirtilmelidir", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                }
            }
        }

        private void btnMasaDegistir_Click(object sender, EventArgs e)
        {
            int SepetID = int.Parse(dataGridView1.CurrentRow.Cells["ID"].Value.ToString());
            int Masa_ID = int.Parse(dataGridView1.CurrentRow.Cells["Masa_ID"].Value.ToString());
            string sql = "update Tbl_Sepet set MasaID='" + int.Parse(cmbBosMasalar.Text.Substring(5)) + "',Masa='" + cmbBosMasalar.Text + "' where SepetID='" + SepetID + "'";
            SqlCommand cmd = new SqlCommand();
            Veritabani.ESG(cmd, sql);

            /////////////////////////////
            string sql2 = "update Tbl_Masalar set  Durumu='Boş'where MasaID='" + Masa_ID + "'";
            SqlCommand cmd2 = new SqlCommand();
            Veritabani.ESG(cmd2, sql2);
            /////////////////////////////
            string sql3 = "update Tbl_Masalar set Durumu='Dolu' where MasaID='"+int.Parse(cmbBosMasalar.Text.Substring(5))+"' ";
            SqlCommand cmd3 = new SqlCommand();
            Veritabani.ESG(cmd3, sql3);
            Yenile();
            MessageBox.Show("masa değiştirme işlemi başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i=0; i<dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells["Sure"].Value != null)
                {
                    if (dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString() != "Süresiz")
                    {
                        double sure = double.Parse(dataGridView1.Rows[i].Cells["Sure"].Value.ToString()) * 60;
                        double AcilisTuru = double.Parse(dataGridView1.Rows[i].Cells["AcilisTuru"].Value.ToString());
                        if (AcilisTuru - sure <= 5.0)
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                        }
                    }
                }
            }
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            frmSatislariListele frm = new frmSatislariListele();
            frm.Enabled = true;
            frm.ShowDialog();
        }
    }
}
