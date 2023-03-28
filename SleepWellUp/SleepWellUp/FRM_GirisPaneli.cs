using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UykuSaatiTakip
{
    public partial class FRM_GirisPaneli : Form
    {
        public FRM_GirisPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti con = new SqlBaglanti();
        private void pboxCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TBL_Kullanicilar where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre", con.baglanti());
            command.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
            command.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı", "Giriş Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRM_AnaPanel FrmAnaPanel = new FRM_AnaPanel();
                FrmAnaPanel.Hide();
                FRM_KullaniciPaneli FrmKullaniciPanel = new FRM_KullaniciPaneli();
                FrmKullaniciPanel.sifre = txtSifre.Text;
                FrmKullaniciPanel.Show();                
                this.Hide();

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Veya Şifre Hatalı", "Hata !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            con.baglanti().Close();
        }

    }
}
