using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UykuSaatiTakip
{
    public partial class FRM_AnaPanel : Form
    {
        public FRM_AnaPanel()
        {
            InitializeComponent();
        }

        private void pboxCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pboxKayitOl_Click(object sender, EventArgs e)
        {
            FRM_KayitPaneli FrmKayitOl = new FRM_KayitPaneli();
            FrmKayitOl.Show();
        }

        private void pboxGirisYap_Click(object sender, EventArgs e)
        {
            FRM_GirisPaneli FrmGirisYap = new FRM_GirisPaneli();
            FrmGirisYap.Show();

        }
    }
}
