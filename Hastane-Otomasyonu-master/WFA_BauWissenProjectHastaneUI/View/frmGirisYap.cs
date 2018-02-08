using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_BauWissenProjectHastane.OOP.Class;

namespace WFA_BauWissenProjectHastaneUI
{
    public partial class frmGirisYap : Form
    {
        public frmGirisYap()
        {
            InitializeComponent();
        }

        #region TANIMLAMALAR

        Random rasgele = new Random();

        #endregion

        #region FORM LOAD

        private void Form_Giris_Yap_Load(object sender, EventArgs e)
        {
            lblGuvenlikKodu.Text = rasgele.Next(1000, 10000).ToString();
        }

        #endregion

        #region GÜVENLİK KODU DEĞİŞTİRME

        private void pBoxReload_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            lblGuvenlikKodu.Text = rasgele.Next(1000, 10000).ToString();
        }

        #endregion

        #region GİRİŞ YAP BUTONU TIKLANDIĞINDA 

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtGuvenlikKodu.Text == lblGuvenlikKodu.Text && txtKullaniciAdi.Text == "admin" && txtSifre.Text == "12345")
            {
                SoundsEffect.clickeffect.Play();
                frmPanel frm = (frmPanel)this.ParentForm;
                frm.btnCikisYap.Visible = true;
                frm.menuStrip1.Visible = true;
                MessageBox.Show("Giriş işleminiz başarı ile gerçekleşti.");
                this.Hide();
            }
            else
            {
                SoundsEffect.falseeffect.Play();
                MessageBox.Show("Hatalı Giriş Yaptınız.");
                lblGuvenlikKodu.Text = rasgele.Next(1000, 10000).ToString();
                txtGuvenlikKodu.Text = "";
                txtKullaniciAdi.Text = "";
                txtSifre.Text = "";
            }
        }

        #endregion

        #region GÜVENLİK KODUNA SADECE SAYI GİRİLSİN!

        private void txtGuvenlikKodu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else
                e.Handled = false;
        }

        #endregion
    }
}
