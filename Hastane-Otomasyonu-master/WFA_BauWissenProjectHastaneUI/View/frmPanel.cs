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
using WFA_BauWissenProjectHastane.OOP.Model;
using WFA_BauWissenProjectHastaneUI.View;
using static WFA_BauWissenProjectHastane.OOP.Model.Enums.EnumsHastane;

namespace WFA_BauWissenProjectHastaneUI
{
    public partial class frmPanel : Form
    {
        public frmPanel()
        {
            InitializeComponent();
        }

        #region FORM LOAD

        private void Form1_Load(object sender, EventArgs e)
        {
            #region PERSONEL KULLANICI ADI, ŞİFRE GİRİŞ EKRANI

            if (this.ActiveMdiChild != null)
                this.ActiveMdiChild.Hide();
            frmGirisYap frm = new frmGirisYap();
            frm.MdiParent = this;
            frm.Show();

            #endregion
        }

        #endregion

        #region TANIMLAMALAR

        ImportAndExport dosyaIslemleri = new ImportAndExport();

        #endregion

        #region CLICK İŞLEMLERİ

        #region XML İŞLEMLERİ
        private void içeriAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            DosyaAc.Filter = "XML | *.xml";
            DosyaAc.ShowDialog();
            dosyaIslemleri.Import(DosyaTuru.XML, DosyaAc.FileName);
        }
        private void dışarıAktarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            DosyaKayit.Filter = "XML | *.xml";
            DosyaKayit.ShowDialog();
            dosyaIslemleri.Export(DosyaTuru.XML, DosyaKayit.FileName);
        }

        #endregion

        #region JSON İŞLEMLERİ

        private void içeriAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            DosyaAc.Filter = "JSON | *.json";
            DosyaAc.ShowDialog();
            dosyaIslemleri.Import(DosyaTuru.JSON, DosyaAc.FileName);
        }
        private void dışarıAktarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            DosyaKayit.Filter = "JSON | *.json";
            DosyaKayit.ShowDialog();
            dosyaIslemleri.Export(DosyaTuru.JSON, DosyaKayit.FileName);
        }

        #endregion

        private void doktorlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            AciklariKapa();
            Doktor dk = new Doktor();
            frmYeniIslemler frm = new frmYeniIslemler(dk);
            frm.MdiParent = this;
            frm.Show();
        }
        private void hemşirelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            AciklariKapa();
            frmYeniIslemler frm = new frmYeniIslemler(new Hemsire());
            frm.MdiParent = this;
            frm.Show();
        }
        private void hastalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            AciklariKapa();
            frmYeniIslemler frm = new frmYeniIslemler(new Hasta());
            frm.MdiParent = this;
            frm.Show();
        }
        private void randevuİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            AciklariKapa();
            frmRandevu frm = new frmRandevu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void randevuÇıktısıPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            AciklariKapa();
            frmPDFRandevu frm = new frmPDFRandevu();
            frm.MdiParent = this;
            frm.Show();
        }

        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            AciklariKapa();
            frmYeniIslemler frm = new frmYeniIslemler(new Personel());
            frm.MdiParent = this;
            frm.Show();
        }

        #endregion

        #region METHODLAR 
        private void AciklariKapa()
        {
            List<Form> fm = this.MdiChildren.ToList();
            if (fm != null && fm.Count > 0)
            {
                foreach (Form lfm in fm)
                {
                    lfm.Close();
                }
            }
        }

        #endregion

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            AciklariKapa();
            btnCikisYap.Visible = false;
            menuStrip1.Visible = false;
            frmGirisYap frm = new frmGirisYap();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
