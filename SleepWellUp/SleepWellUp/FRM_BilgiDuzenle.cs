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
    public partial class FRM_BilgiDuzenle : Form
    {
        public FRM_BilgiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglanti con = new SqlBaglanti();
        public string Sifre2;
        private void FRM_BilgiDuzenle_Load(object sender, EventArgs e)
        {

            SqlCommand command = new SqlCommand("select * from TBL_Kullanicilar where Sifre=@p1", con.baglanti());
            command.Parameters.AddWithValue("@p1", Sifre2);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                txtAd.Text = dr[1].ToString();
                txtSoyad.Text = dr[2].ToString();
                mtxtTelefon.Text = dr[3].ToString();
                txtSifre.Text = dr[5].ToString();
                txtKullaniciAdi.Text = dr[4].ToString();

                con.baglanti().Close();
            }
        }

        private void pboxCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand cmdGuncelle = new SqlCommand("Update TBL_Kullanicilar set Ad=@Ad,Soyad=@Soyad,Telefon=@Telefon,KullaniciAdi=@KullaniciAdi where Sifre=@Sifre", con.baglanti());
            cmdGuncelle.Parameters.AddWithValue("@Ad", txtAd.Text);
            cmdGuncelle.Parameters.AddWithValue("@Soyad", txtSoyad.Text);
            cmdGuncelle.Parameters.AddWithValue("@Telefon", mtxtTelefon.Text);
            cmdGuncelle.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdi.Text);
            cmdGuncelle.Parameters.AddWithValue("@Sifre", Sifre2);
            cmdGuncelle.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Kayıt Başarıyla Gerçekleştirildi.", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
        }
    }
}
