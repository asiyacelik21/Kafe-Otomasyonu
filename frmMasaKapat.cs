using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using DevExpress.XtraEditors.Filtering.Templates;

namespace CafeOtomasyonu
{
	public partial class frmMasaKapat: DevExpress.XtraEditors.XtraForm
	{
        public frmMasaKapat()
		{
            InitializeComponent();
		}

        private void frmMasaKapat_Load(object sender, EventArgs e)
        {

        }

        private void btnMasaKpat_Click(object sender, EventArgs e)
        {
            string sorgu = "insert into Tbl_Satis(KullaniciID,MasaID,AcilisTuru,BaslangicSaati,BitisSaati,Sure,Tutar,Aciklama,Tarih)" + " values" +
                " ('" + Kullanici.KullaniciID + "','" + int.Parse(txtMasaID.Text) + "','"+txtAcilisTuru.Text+"',@Baslangic,@Bitis,@Sure,@Tutar,'Aciklama Yapılmadı',@Tarih)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("Baslangic", DateTime.Parse(txtBaslamaSaati.Text));
            cmd.Parameters.AddWithValue("Bitis", DateTime.Parse(txtBitisSaati.Text));
            cmd.Parameters.AddWithValue("Sure", decimal.Parse(txtSure.Text));
            cmd.Parameters.AddWithValue("Tutar", decimal.Parse(txtTutar.Text));
            cmd.Parameters.AddWithValue("Tarih", DateTime.Parse(txtTarih.Text));
            Veritabani.ESG(cmd, sorgu);
            this.Close();
            frmSatis frm = (frmSatis)Application.OpenForms["frmSatis"];
            frm.Yenile();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {

        }
    }
}