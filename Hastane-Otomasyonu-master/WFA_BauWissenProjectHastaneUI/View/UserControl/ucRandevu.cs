using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WFA_BauWissenProjectHastane.OOP.Model.Enums.EnumsHastane;
using WFA_BauWissenProjectHastane.OOP.Model;
using WFA_BauWissenProjectHastane.OOP.Class;

namespace WFA_BauWissenProjectHastaneUI
{
    public partial class ucRandevu : UserControl
    {
        public DateTime MesaiBaslangic { get; set; } = new DateTime(1, 1, 1, 8, 0, 0);
        public DateTime OglenBaslangic { get; set; } = new DateTime(1, 1, 1, 12, 0, 0);
        public DateTime OglenBitis { get; set; } = new DateTime(1, 1, 1, 13, 0, 0);
        public DateTime MesaiBitis { get; set; } = new DateTime(1, 1, 1, 17, 0, 0);
        public int ColumnSayisi { get; set; } = 6;
        public int HastaBasinaDakikaSayisi { get; set; } = 15;
        public Hasta SeciliHasta { get; set; } = new Hasta();

        public ucRandevu()
        {
            InitializeComponent();
        }

        private void Randevu_Ekle_Us_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(EnumDoktorBrans)))
            {
                cmbBolum.Items.Add(item);
            }

        }

        private void cmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBolum.SelectedIndex < 0)
                return;
            cmbDoktor.Items.Clear();
            foreach (Doktor item in DataKayit.DoktorListesi)
            {
                if (item.DoktorBransi == (EnumDoktorBrans)cmbBolum.SelectedItem)
                {
                    cmbDoktor.Items.Add(item);
                }
            }
        }

        private void cmbDoktorAdi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDoktor.SelectedIndex < 0)
                return;
            RandevuTablosunuOlustur((Doktor)cmbDoktor.SelectedItem);
        }

        private void RandevuTablosunuOlustur(Doktor doktor)
        {
            TabloButonlariniAyarla();
            ButonlarınRandevuDurumlariniAyarla();

        }

        private void ButonlarınRandevuDurumlariniAyarla()
        {
            foreach (Button btn in tlpRandevu.Controls)
            {

                btn.BackColor = Color.Green;
                btn.Tag = null;
            }


            foreach (Randevu randevu in DataKayit.RandevuListesi)
            {
                if (randevu.Doktor.ID == (cmbDoktor.SelectedItem as Doktor).ID)
                {
                    foreach (Button btn in tlpRandevu.Controls)
                    {
                        if (DateTime.Parse(btn.Text) == randevu.RandevuGunSaat)
                        {
                            btn.BackColor = Color.Orange;
                            btn.Tag = randevu;
                        }
                    }
                }
            }

        }

        private void TabloButonlariniAyarla()
        {

            tlpRandevu.Controls.Clear();

            if (MesaiBaslangic >= OglenBaslangic && OglenBaslangic >= OglenBitis && OglenBitis >= MesaiBitis)
                throw new Exception("Mesai saatlerinde hata ile karşılaşıldı.");
            int satirIndexi = 0;
            DateTime suankiZaman = MesaiBaslangic;
            while (suankiZaman <= MesaiBitis)
            {
                for (int sutunIndexi = 0; sutunIndexi < ColumnSayisi; sutunIndexi++)
                {
                    if ((suankiZaman < OglenBaslangic || suankiZaman >= OglenBitis) && suankiZaman <= MesaiBitis)
                    {
                        Button btn = new Button();
                        btn.Dock = DockStyle.Fill;
                        btn.Click += RandevuSaait_Click;
                        btn.Text = suankiZaman.ToShortTimeString();
                        tlpRandevu.Controls.Add(btn, sutunIndexi, satirIndexi);
                        suankiZaman = suankiZaman.AddMinutes(HastaBasinaDakikaSayisi);
                    }
                    else
                    {
                        suankiZaman = suankiZaman.AddMinutes(HastaBasinaDakikaSayisi);
                    }
                }
                satirIndexi++;
            }
        }

        private void RandevuSaait_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Tag != null)
            {
                DialogResult result = MessageBox.Show("Bu Saate " + ((sender as Button).Tag as Randevu).Hasta.ToString() + " var.", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    SoundsEffect.trueeffect.Play();
                    if (HastaRandevuKontrol(SeciliHasta, (sender as Button).Text))
                    {
                        DataKayit.RandevuListesi.Remove(((sender as Button).Tag as Randevu));
                    RandevuTablosunuOlustur(cmbDoktor.SelectedItem as Doktor);
                    }
                    else
                    {
                        SoundsEffect.falseeffect.Play();
                        MessageBox.Show("Bu hastanın bu saatte bir randevusu zaten var.");
                    }
                }
            }
            else
            {
                if (HastaRandevuKontrol(SeciliHasta,(sender as Button).Text))
                {
                    Randevu rnd = new Randevu
                    {
                        Doktor = cmbDoktor.SelectedItem as Doktor,
                        Hasta = SeciliHasta,
                        RandevuGunSaat = DateTime.Parse((sender as Button).Text)
                    };
                    DataKayit.RandevuListesi.Add(rnd);
                    (sender as Button).Tag = rnd;
                    SoundsEffect.trueeffect.Play();
                    MessageBox.Show("Başarılı");
                    RandevuTablosunuOlustur((Doktor)cmbDoktor.SelectedItem);
                }
                else
                {
                    SoundsEffect.falseeffect.Play();
                    MessageBox.Show("Bu hastanın bu saatte bir randevusu zaten var.");
                }
                // ButonlarınRandevuDurumlariniAyarla();
            }
        }

        public bool HastaRandevuKontrol(Hasta hasta,string saat) {
            foreach (Randevu randevu in DataKayit.RandevuListesi)
            {
                if (randevu.Hasta.ID==hasta.ID)
                {
                    if (randevu.RandevuGunSaat==DateTime.Parse(saat))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private void btnHastaGetir_Click(object sender, EventArgs e)
        {
            try
            {
                SoundsEffect.clickeffect.Play();
                foreach (Hasta item in DataKayit.HastaListesi)
                {
                    if (item.TC == txtHastaTC.Text)
                    {
                        SeciliHasta = item;
                        lblHastaAdi.Text = item.ToString();
                        grp2.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                SoundsEffect.falseeffect.Play();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
