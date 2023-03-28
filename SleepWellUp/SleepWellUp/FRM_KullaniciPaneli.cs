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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;

namespace UykuSaatiTakip
{
    public partial class FRM_KullaniciPaneli : Form
    {
        public FRM_KullaniciPaneli()
        {
            InitializeComponent();
        }
        public string sifre;
        SqlBaglanti con = new SqlBaglanti();
        private void FRM_KullaniciPaneli_Load(object sender, EventArgs e)
        {
            
            
            lblSifre.Text = sifre;
           
            SqlCommand command = new SqlCommand("select ID,Ad,Soyad,Telefon,KullaniciAdi from TBL_Kullanicilar where Sifre=@Sifre", con.baglanti());
            command.Parameters.AddWithValue("@Sifre", lblSifre.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblID.Text = dr[0].ToString();
                lblAd.Text = dr[1].ToString();
                lblSoyad.Text = dr[2].ToString();

            }
            con.baglanti().Close();


            SqlCommand commandList = new SqlCommand("select ID[Sıra],UykuSuresi[Uyku Süresi],Tarih from TBL_Uyku where Kullanici=@KullaniciID", con.baglanti());
            commandList.Parameters.AddWithValue("@KullaniciID", lblID.Text);
            SqlDataAdapter da = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwListele.DataSource = dt;
        }

        private void pboxCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void dgwListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenDeger = dgwListele.SelectedCells[0].RowIndex;
            txtID.Text = dgwListele.Rows[secilenDeger].Cells[0].Value.ToString();
            txtUykuSuresi.Text = dgwListele.Rows[secilenDeger].Cells[1].Value.ToString();
            dtpTarih.Text = dgwListele.Rows[secilenDeger].Cells[2].Value.ToString();
        }

        private void btnUykuKaydet_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into TBL_Uyku (UykuSuresi,Tarih,Kullanici) values (@UykuSuresi,@Tarih,@Kullanici)", con.baglanti());
            command.Parameters.AddWithValue("@UykuSuresi", txtUykuEkle.Text);
            command.Parameters.AddWithValue("@Tarih", dtpUykuEkle.Text);
            command.Parameters.AddWithValue("@Kullanici", lblID.Text);
            command.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Uyku Kaydı Başarıyla Eklendi", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            FRM_BilgiDuzenle BilgiDuzenle = new FRM_BilgiDuzenle();
            BilgiDuzenle.Sifre2 = sifre;
            BilgiDuzenle.Show();
            
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            SqlCommand commandList = new SqlCommand("select ID[Sıra],UykuSuresi[Uyku Süresi],Tarih from TBL_Uyku where Kullanici=@KullaniciID", con.baglanti());
            commandList.Parameters.AddWithValue("@KullaniciID", lblID.Text);
            SqlDataAdapter da = new SqlDataAdapter(commandList);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwListele.DataSource = dt;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdGuncelle = new SqlCommand("Update TBL_Uyku set UykuSuresi=@UykuSuresi,Tarih=@Tarih where ID='" + txtID.Text + "'", con.baglanti());
            cmdGuncelle.Parameters.AddWithValue("@UykuSuresi", txtUykuSuresi.Text);
            cmdGuncelle.Parameters.AddWithValue("@Tarih", dtpTarih.Text);
            cmdGuncelle.ExecuteNonQuery();
            con.baglanti().Close();
            MessageBox.Show("Güncelleme İşlemi Başarıyla Gerçekleşti", "Güncelleme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmdDelete = new SqlCommand("Delete from TBL_Uyku where ID='" + txtID.Text + "'", con.baglanti());
            cmdDelete.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti", "Silme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBulveListele_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * from TBL_Uyku where Tarih Between'"+dtpTarihBulBaslangıc.Text+"' and '"+dtpTarihBulBitis.Text+"'", con.baglanti());
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwListele.DataSource = dt;


            con.baglanti().Close();
        }

        private void btnHesapSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmdDelete = new SqlCommand("Delete from TBL_Kullanicilar where Sifre='" + lblSifre.Text + "'", con.baglanti());
            cmdDelete.ExecuteNonQuery();
            MessageBox.Show("Silme İşlemi Başarıyla Gerçekleşti", "Silme İşlemi Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Samet Fazıl Şentürk\AppData\Local\Programs\Opera GX\Opera.Exe");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            MessageBox.Show(dt.ToString(),"Tarih ve Saat",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
