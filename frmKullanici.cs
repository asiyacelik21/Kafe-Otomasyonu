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

namespace CafeOtomasyonu
{
	public partial class frmKullanici: DevExpress.XtraEditors.XtraForm
	{
        public frmKullanici()
		{
            InitializeComponent();
		}

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Kullanici.KullaniciGirisi(txtKullaniciAdi, txtSifre);
            if(Kullanici.durum==true)
            {
                frmSatis frm = new frmSatis();
                frm.Show();
                this.Hide();
            }
            else if(Kullanici.durum==false)
            {
                MessageBox.Show("Kullanıcı adı veye şifrenizi kontrol ediniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}