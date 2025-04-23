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

namespace CafeOtomasyonu
{
	public partial class frmSatislariListele: DevExpress.XtraEditors.XtraForm
	{
        public frmSatislariListele()
		{
            InitializeComponent();
		}

        private void frmSatislariListele_Load(object sender, EventArgs e)
        {
            Veritabani.Listele(dataGridView1, "select*from Tbl_Satis");
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            int MasaID = int.Parse(dataGridView1.CurrentRow.Cells["MasaID"].Value.ToString());
            int KullaniciID = int.Parse(dataGridView1.CurrentRow.Cells["KullaniciID"].Value.ToString());
            string Masa = "Masa" + MasaID;
            string AcilisTuru = dataGridView1.CurrentRow.Cells["AcilisTuru"].Value.ToString();
            DateTime baslangic = DateTime.Parse(dataGridView1.CurrentRow.Cells["Baslangic"].Value.ToString());
            DateTime Tarih = DateTime.Parse(dataGridView1.CurrentRow.Cells["Tarih"].Value.ToString());
            string sql = "insert into Tbl_Sepet(MasaID,Masa,AcilisTuru,Baslangic,Tarih)values( " + " '" + MasaID + "','" + Masa + "','" + AcilisTuru + "',@Baslangic,@Tarih)";
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Baslangic", baslangic);
            cmd.Parameters.AddWithValue("@Tarih", Tarih);
            Veritabani.ESG(cmd, sql);
            ///////////////////////////////
            string sql2 = "delete from Tbl_Satis where SatisID='" + int.Parse(dataGridView1.CurrentRow.Cells["SatisID"].Value.ToString())+"'";
            SqlCommand cmd2 = new SqlCommand();
            Veritabani.ESG(cmd2, sql2);
            this.Close();
            frmSatis frm = (frmSatis)Application.OpenForms["frmSatis"];
            frm.Yenile();
        }
    }
}