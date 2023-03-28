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
    public partial class FRM_KayitPaneli : Form
    {
        public FRM_KayitPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti connection = new SqlBaglanti();
        private void pboxCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connection.baglanti();
            SqlCommand command = new SqlCommand("insert into TBL_Kullanicilar(Ad,Soyad,Telefon,KullaniciAdi,Sifre) values (@Ad,@Soyad,@Telefon,@KullaniciAdi,@Sifre)", connection.baglanti());
            command.Parameters.AddWithValue("@Ad", txtAd.Text);
            command.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            command.Parameters.AddWithValue("@Telefon", mtxtTelefon.Text);
            command.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
            command.Parameters.AddWithValue("@Sifre", txtSifre.Text);
            command.ExecuteNonQuery();
            connection.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi.", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
