using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_BauWissenProjectHastane.OOP.Model;
using static WFA_BauWissenProjectHastane.OOP.Model.Enums.EnumsHastane;
using WFA_BauWissenProjectHastane.OOP.Class;

namespace WFA_BauWissenProjectHastaneUI
{
    public partial class ucIslem : UserControl
    {
        public ucIslem()
        {
            InitializeComponent();

        }

        public Kisi secilenKisi { get; set; } = new Kisi();
        Kisi guncellenecekKisi;
        DataKayit aranan = new DataKayit();

        #region Methodlar
        public void GenelAyarlar()
        {
            cmbCinsiyet.Items.AddRange(Enum.GetNames(typeof(EnumCinsiyet)));
            tbGenel.TabPages.Remove(tabPage2);
        }

        #region Ekleme Methodları
        void DoktorEkle()
        {
            foreach (var item in DataKayit.DoktorListesi)
            {
                if (txtTC.Text == item.TC)
                {
                    MessageBox.Show("Aynı TC ile kayıt yapılamaz.");
                    FormuTemizle();
                    return;
                }
            }

            Doktor yeniDoktor = new Doktor
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TC = txtTC.Text,
                Cinsiyet = (EnumCinsiyet)Enum.Parse(typeof(EnumCinsiyet), cmbCinsiyet.SelectedItem.ToString()),
                DogumTarihi = dtpDogumTarihi.Value,
                Email = txtEposta.Text,
                TelefonNumarasi = txtTelNo.Text,
                DoktorBransi = (EnumDoktorBrans)Enum.Parse(typeof(EnumDoktorBrans), cmbBrans.SelectedItem.ToString()),
                Maas = nMaas.Value,
            };
            DataKayit.DoktorListesi.Add(yeniDoktor);
            ListeyiDoldur();
            FormuTemizle();




        }
        void HemsireEkle()
        {
            foreach (var item in DataKayit.HemsireListesi)
            {
                if (txtTC.Text == item.TC)
                {
                    MessageBox.Show("Aynı TC ile kayıt yapılamaz.");
                    FormuTemizle();
                    return;
                }
            }
            Hemsire yeniHemsire = new Hemsire
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TC = txtTC.Text,
                Cinsiyet = (EnumCinsiyet)Enum.Parse(typeof(EnumCinsiyet), cmbCinsiyet.SelectedItem.ToString()),
                DogumTarihi = dtpDogumTarihi.Value,
                Email = txtEposta.Text,
                TelefonNumarasi = txtTelNo.Text,
                HemsireBransi = (EnumHemsireBrans)Enum.Parse(typeof(EnumHemsireBrans), cmbBrans.SelectedItem.ToString()),
                Maas = nMaas.Value,
            };
            DataKayit.HemsireListesi.Add(yeniHemsire);
            ListeyiDoldur();
            FormuTemizle();


        }
        void PersonelEkle()
        {
            foreach (var item in DataKayit.PersonelListesi)
            {
                if (txtTC.Text == item.TC)
                {
                    MessageBox.Show("Aynı TC ile kayıt yapılamaz.");
                    FormuTemizle();
                    return;
                }
            }
            Personel yeniPersonel = new Personel
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TC = txtTC.Text,
                Cinsiyet = (EnumCinsiyet)Enum.Parse(typeof(EnumCinsiyet), cmbCinsiyet.SelectedItem.ToString()),
                DogumTarihi = dtpDogumTarihi.Value,
                Email = txtEposta.Text,
                TelefonNumarasi = txtTelNo.Text,
                PersonelBransi = (EnumPersonelBrans)Enum.Parse(typeof(EnumPersonelBrans), cmbBrans.SelectedItem.ToString()),
                Maas = nMaas.Value,
            };
            DataKayit.PersonelListesi.Add(yeniPersonel);
            ListeyiDoldur();
            FormuTemizle();

        }
        void HastaEkle()
        {
            foreach (var item in DataKayit.HastaListesi)
            {
                if (txtTC.Text == item.TC)
                {
                    MessageBox.Show("Aynı TC ile kayıt yapılamaz.");
                    FormuTemizle();
                    return;
                }
            }
            Hasta yeniHasta = new Hasta
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                TC = txtTC.Text,
                Cinsiyet = (EnumCinsiyet)Enum.Parse(typeof(EnumCinsiyet), cmbCinsiyet.SelectedItem.ToString()),
                DogumTarihi = dtpDogumTarihi.Value,
                Email = txtEposta.Text,
                TelefonNumarasi = txtTelNo.Text,
            };
            DataKayit.HastaListesi.Add(yeniHasta);
            ListeyiDoldur();
            FormuTemizle();

        }
        #endregion

        private void IcerigiDoldur()
        {
            if (guncellenecekKisi is Doktor)
            {
                KisiyiDoldur();
                nMaas.Value = (guncellenecekKisi as Doktor).Maas;
                cmbBrans.SelectedIndex = (int)(guncellenecekKisi as Doktor).DoktorBransi;
            }
            else if (guncellenecekKisi is Hemsire)
            {
                KisiyiDoldur();
                nMaas.Value = (guncellenecekKisi as Hemsire).Maas;
                cmbBrans.SelectedIndex = (int)(guncellenecekKisi as Hemsire).HemsireBransi;
            }
            else if (guncellenecekKisi is Personel)
            {
                KisiyiDoldur();
                nMaas.Value = (guncellenecekKisi as Personel).Maas;
                cmbBrans.SelectedIndex = (int)(guncellenecekKisi as Personel).PersonelBransi;
            }
            else if (guncellenecekKisi is Hasta)
            {
                KisiyiDoldur();
            }
        }

        void KisiyiDoldur()
        {
            txtAd.Text = guncellenecekKisi.Ad;
            txtSoyad.Text = guncellenecekKisi.Soyad;
            txtTC.Text = guncellenecekKisi.TC;
            txtTelNo.Text = guncellenecekKisi.TelefonNumarasi;
            txtEposta.Text = guncellenecekKisi.Email;
            cmbCinsiyet.SelectedIndex = (int)guncellenecekKisi.Cinsiyet;
            dtpDogumTarihi.Value = guncellenecekKisi.DogumTarihi;
        }

        private void Guncelle()
        {
            guncellenecekKisi.Ad = txtAd.Text;
            guncellenecekKisi.Soyad = txtSoyad.Text;
            guncellenecekKisi.TC = txtTC.Text;
            guncellenecekKisi.DogumTarihi = dtpDogumTarihi.Value;
            guncellenecekKisi.Cinsiyet = (EnumCinsiyet)Enum.Parse(typeof(EnumCinsiyet), cmbCinsiyet.SelectedItem.ToString());
            guncellenecekKisi.TelefonNumarasi = txtTelNo.Text;
            guncellenecekKisi.Email = txtEposta.Text;
            guncellenecekKisi = null;
            ListeyiDoldur();
            MessageBox.Show("Güncelleme işlemi başarılı");
            FormuTemizle();
        }

        void FormuTemizle()
        {
            guncellenecekKisi = new Kisi();

            foreach (Control item in this.groupBox1.Controls)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is ComboBox)
                    (item as ComboBox).SelectedIndex = 0;
                else if (item is DateTimePicker)
                    (item as DateTimePicker).Value = DateTime.Now;
            }
        }

        void ListeyiDoldur()
        {
            lstListe.Items.Clear();
            if (secilenKisi is Doktor)
            {
                foreach (Doktor item in DataKayit.DoktorListesi)
                {
                    ListViewItem liste = new ListViewItem();
                    liste.Text = item.Ad;
                    liste.SubItems.Add(item.Soyad);
                    liste.SubItems.Add(item.TC);
                    liste.SubItems.Add(item.DogumTarihi.ToShortDateString());
                    liste.SubItems.Add(item.Cinsiyet.ToString());
                    liste.SubItems.Add(item.Email);
                    liste.SubItems.Add(item.TelefonNumarasi);
                    liste.SubItems.Add(item.DoktorBransi.ToString());
                    liste.SubItems.Add(item.Maas.ToString());
                    lstListe.Items.Add(liste);
                    liste.Tag = item;
                }
            }
            else if (secilenKisi is Hemsire)
            {
                foreach (Hemsire item in DataKayit.HemsireListesi)
                {
                    ListViewItem liste = new ListViewItem();
                    liste.Text = item.Ad;
                    liste.SubItems.Add(item.Soyad);
                    liste.SubItems.Add(item.TC);
                    liste.SubItems.Add(item.DogumTarihi.ToShortDateString());
                    liste.SubItems.Add(item.Cinsiyet.ToString());
                    liste.SubItems.Add(item.Email);
                    liste.SubItems.Add(item.TelefonNumarasi);
                    liste.SubItems.Add(item.HemsireBransi.ToString());
                    liste.SubItems.Add(item.Maas.ToString());
                    lstListe.Items.Add(liste);
                    liste.Tag = item;
                }
            }
            else if (secilenKisi is Personel)
            {
                foreach (Personel item in DataKayit.PersonelListesi)
                {
                    ListViewItem liste = new ListViewItem();
                    liste.Text = item.Ad;
                    liste.SubItems.Add(item.Soyad);
                    liste.SubItems.Add(item.TC);
                    liste.SubItems.Add(item.DogumTarihi.ToShortDateString());
                    liste.SubItems.Add(item.Cinsiyet.ToString());
                    liste.SubItems.Add(item.Email);
                    liste.SubItems.Add(item.TelefonNumarasi);
                    liste.SubItems.Add(item.PersonelBransi.ToString());
                    liste.SubItems.Add(item.Maas.ToString());
                    lstListe.Items.Add(liste);
                    liste.Tag = item;
                }
            }
            else if (secilenKisi is Hasta)
            {
                foreach (Hasta item in DataKayit.HastaListesi)
                {
                    ListViewItem liste = new ListViewItem();
                    liste.Text = item.Ad;
                    liste.SubItems.Add(item.Soyad);
                    liste.SubItems.Add(item.TC);
                    liste.SubItems.Add(item.DogumTarihi.ToShortDateString());
                    liste.SubItems.Add(item.Cinsiyet.ToString());
                    liste.SubItems.Add(item.Email);
                    liste.SubItems.Add(item.TelefonNumarasi);
                    liste.SubItems.Add("-");
                    liste.SubItems.Add("-");
                    lstListe.Items.Add(liste);
                    liste.Tag = item;
                }
            }
        }

        void HemsireDoldur()
        {
            lstHemsireListe.Items.Clear();
            bool hemsiremusaitmi = true;
            foreach (Hemsire hemsire in DataKayit.HemsireListesi)
            {
                foreach (Doktor doktor in DataKayit.DoktorListesi)
                {
                    foreach (Hemsire baglihemsire in doktor._doktorabaglihemsirelistesi)
                    {
                        if (hemsire.ID == baglihemsire.ID)
                        {
                            hemsiremusaitmi = false;
                        }
                    }

                }
                if (hemsiremusaitmi)
                {
                    ListViewItem lstHemsire = new ListViewItem();
                    lstHemsire.Text = hemsire.Ad;
                    lstHemsire.SubItems.Add(hemsire.Soyad);
                    lstHemsire.SubItems.Add(hemsire.Cinsiyet.ToString());
                    lstHemsire.SubItems.Add(hemsire.HemsireBransi.ToString());
                    lstHemsire.SubItems.Add(hemsire.TC);
                    lstHemsireListe.Items.Add(lstHemsire);
                    lstHemsire.Tag = hemsire;
                }
                hemsiremusaitmi = true;

            }
        }

        private void BudoktoraBagliHemsireleriDoldur()
        {
            lstDoktoraBagliHemsireler.Items.Clear();
            foreach (Hemsire hemsire in (guncellenecekKisi as Doktor)._doktorabaglihemsirelistesi)
            {
                ListViewItem lstHemsire = new ListViewItem();
                lstHemsire.Text = hemsire.Ad;
                lstHemsire.SubItems.Add(hemsire.Soyad);
                lstHemsire.SubItems.Add(hemsire.TC);
                lstHemsire.SubItems.Add(hemsire.HemsireBransi.ToString());
                lstDoktoraBagliHemsireler.Items.Add(lstHemsire);
                lstHemsire.Tag = hemsire;
            }
        }
        #endregion

        #region UserConrol Load
        private void List_Us_Load(object sender, EventArgs e)
        {
            GenelAyarlar();
            ListeyiDoldur();
            pnlBransMaas.Visible = false;
            if (secilenKisi is Doktor)
            {
                pnlBransMaas.Visible = true;
                tbGenel.TabPages.Add(tabPage2);
                cmbBrans.Items.AddRange(Enum.GetNames(typeof(EnumDoktorBrans)));
            }
            else if (secilenKisi is Hemsire)
            {
                pnlBransMaas.Visible = true;
                cmbBrans.Items.AddRange(Enum.GetNames(typeof(EnumHemsireBrans)));
            }
            else if (secilenKisi is Personel)
            {
                pnlBransMaas.Visible = true;
                cmbBrans.Items.AddRange(Enum.GetNames(typeof(EnumPersonelBrans)));
            }
            else if (secilenKisi is Hasta)
            {
                pnlBransMaas.Visible = false;
            }


        }
        #endregion

        #region ListeView'e Listeleme
        private void lstListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (secilenKisi is Doktor)
                {
                    guncellenecekKisi = new Doktor();
                    guncellenecekKisi = (Doktor)lstListe.FocusedItem.Tag;
                    HemsireDoldur();
                    BudoktoraBagliHemsireleriDoldur();
                    IcerigiDoldur();
                }
                else if (secilenKisi is Hemsire)
                {
                    guncellenecekKisi = new Hemsire();
                    guncellenecekKisi = (Hemsire)lstListe.FocusedItem.Tag;
                    IcerigiDoldur();

                }
                else if (secilenKisi is Personel)
                {
                    guncellenecekKisi = new Personel();
                    guncellenecekKisi = (Personel)lstListe.FocusedItem.Tag;
                    IcerigiDoldur();

                }
                else if (secilenKisi is Hasta)
                {
                    guncellenecekKisi = new Hasta();
                    guncellenecekKisi = (Hasta)lstListe.FocusedItem.Tag;
                    IcerigiDoldur();

                }
            }
            catch (Exception ex)
            {
                SoundsEffect.falseeffect.Play();
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Click İşlemleri  

        #region Hemşire Ekleme Çıkartma İşlemleri
        private void btnHemsireEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SoundsEffect.clickeffect.Play();
                Hemsire hemsire = lstHemsireListe.FocusedItem.Tag as Hemsire;
                (guncellenecekKisi as Doktor)._doktorabaglihemsirelistesi.Add(hemsire);
                HemsireDoldur();
                BudoktoraBagliHemsireleriDoldur();
            }
            catch (Exception)
            {
                SoundsEffect.falseeffect.Play();
                MessageBox.Show("Hemsire Seciniz.");
            }

        }

        private void btnHemsireCikar_Click(object sender, EventArgs e)
        {

            try
            {
                Hemsire hemsire = lstDoktoraBagliHemsireler.FocusedItem.Tag as Hemsire;
                (guncellenecekKisi as Doktor)._doktorabaglihemsirelistesi.Remove(hemsire);
                HemsireDoldur();
                BudoktoraBagliHemsireleriDoldur();
            }
            catch (Exception)
            {

                MessageBox.Show("Hemsire Seciniz.");
            }
        }
        #endregion

        #region Formu Temizleme İşlemi
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            SoundsEffect.clickeffect.Play();
            FormuTemizle();
        }
        #endregion

        #region Silme İşlemi
        private void btnSil_Click(object sender, EventArgs e)
        {
            SoundsEffect.falseeffect.Play();
            if (lstListe.SelectedIndices.Count < 0) return;
            if (secilenKisi is Doktor)
            {
                foreach (ListViewItem item in lstListe.SelectedItems)
                {
                    DataKayit.DoktorListesi.Remove((Doktor)item.Tag);
                    item.Remove();
                }
                FormuTemizle();
            }
            else if (secilenKisi is Hemsire)
            {
                foreach (ListViewItem item in lstListe.SelectedItems)
                {
                    DataKayit.HemsireListesi.Remove((Hemsire)item.Tag);
                    item.Remove();
                }
                FormuTemizle();
            }
            else if (secilenKisi is Personel)
            {
                foreach (ListViewItem item in lstListe.SelectedItems)
                {
                    DataKayit.PersonelListesi.Remove((Personel)item.Tag);
                    item.Remove();
                }
                FormuTemizle();
            }
            else if (secilenKisi is Hasta)
            {
                foreach (ListViewItem item in lstListe.SelectedItems)
                {
                    DataKayit.HastaListesi.Remove((Hasta)item.Tag);
                    item.Remove();
                }
                FormuTemizle();
            }
        }
        #endregion

        #region Güncelleme İşlemi
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (guncellenecekKisi is Doktor)
            {
                if (DataKayit.DoktorListesi == null)
                {
                    MessageBox.Show("Neyi Güncelleyeyim");
                    return;
                }
                DialogResult cevap1 = MessageBox.Show($"{txtAd.Text} adlı aracı güncellemek istiyor musunuz?", "Kişi güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap1 == DialogResult.Yes)
                {
                    try
                    {
                        SoundsEffect.trueeffect.Play();
                        guncellenecekKisi = DataKayit.DoktorListesi
                      .Where(x => x.ID == guncellenecekKisi.ID)
                      .FirstOrDefault();
                        (guncellenecekKisi as Doktor).DoktorBransi = (EnumDoktorBrans)Enum.Parse(typeof(EnumDoktorBrans), cmbBrans.SelectedItem.ToString());
                        (guncellenecekKisi as Doktor).Maas = nMaas.Value;
                        Guncelle();
                    }
                    catch (Exception ex)
                    {
                        SoundsEffect.falseeffect.Play();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (guncellenecekKisi is Hemsire)
            {
                if (DataKayit.HemsireListesi == null)
                {
                    MessageBox.Show("Neyi Güncelleyeyim");
                    return;
                }
                DialogResult cevap2 = MessageBox.Show($"{txtAd.Text} adlı aracı güncellemek istiyor musunuz?", "Kişi güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap2 == DialogResult.Yes)
                {
                    try
                    {
                        SoundsEffect.trueeffect.Play();
                        guncellenecekKisi = DataKayit.HemsireListesi
                      .Where(x => x.ID == guncellenecekKisi.ID)
                      .FirstOrDefault();
                        (guncellenecekKisi as Hemsire).HemsireBransi = (EnumHemsireBrans)Enum.Parse(typeof(EnumHemsireBrans), cmbBrans.SelectedItem.ToString());
                        (guncellenecekKisi as Hemsire).Maas = nMaas.Value;
                        Guncelle();
                    }
                    catch (Exception ex)
                    {
                        SoundsEffect.falseeffect.Play();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (guncellenecekKisi is Personel)
            {
                if (DataKayit.PersonelListesi == null)
                {
                    MessageBox.Show("Neyi Güncelleyeyim");
                    return;
                }
                DialogResult cevap3 = MessageBox.Show($"{txtAd.Text} adlı aracı güncellemek istiyor musunuz?", "Kişi güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap3 == DialogResult.Yes)
                {
                    try
                    {
                        SoundsEffect.trueeffect.Play();
                        guncellenecekKisi = DataKayit.PersonelListesi
                      .Where(x => x.ID == guncellenecekKisi.ID)
                      .FirstOrDefault();
                        (guncellenecekKisi as Personel).PersonelBransi = (EnumPersonelBrans)Enum.Parse(typeof(EnumPersonelBrans), cmbBrans.SelectedItem.ToString());
                        (guncellenecekKisi as Personel).Maas = nMaas.Value;
                        Guncelle();
                    }
                    catch (Exception ex)
                    {
                        SoundsEffect.falseeffect.Play();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else if (guncellenecekKisi is Hasta)
            {
                if (DataKayit.HastaListesi == null)
                {
                    MessageBox.Show("Neyi Güncelleyeyim");
                    return;
                }
                DialogResult cevap4 = MessageBox.Show($"{txtAd.Text} adlı aracı güncellemek istiyor musunuz?", "Kişi güncelleme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap4 == DialogResult.Yes)
                {
                    try
                    {
                        SoundsEffect.trueeffect.Play();
                        guncellenecekKisi = DataKayit.HastaListesi
                       .Where(x => x.ID == guncellenecekKisi.ID)
                       .FirstOrDefault();
                        Guncelle();
                    }
                    catch (Exception ex)
                    {
                        SoundsEffect.falseeffect.Play();
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        #endregion

        #region Ekleme İşlemi
        private void btnEkle_Click(object sender, EventArgs e)
        {
            SoundsEffect.trueeffect.Play();
            try
            {
                if (secilenKisi is Doktor)
                {
                    DoktorEkle();
                }
                else if (secilenKisi is Hemsire)
                {
                    HemsireEkle();
                }
                else if (secilenKisi is Personel)
                {
                    PersonelEkle();
                }
                else if (secilenKisi is Hasta)
                {
                    HastaEkle();
                }
            }
            catch (Exception ex)
            {
                SoundsEffect.falseeffect.Play();
                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #endregion

        #region Arama İşlemleri

        private void txtArama_TextChanged_1(object sender, EventArgs e)
        {
            if (secilenKisi is Doktor)
            {
                var sonuc = Kisi.DoktorArama(txtArama.Text, aranan.DList);
                ListeyiDoldur(sonuc);
            }
            else if (secilenKisi is Hemsire)
            {
                var sonuc2 = Kisi.HemsireArama(txtArama.Text, aranan.Hemist);
                ListeyiDoldur(sonuc2);
            }
            else if (secilenKisi is Personel)
            {
                var sonuc2 = Kisi.PersonelArama(txtArama.Text, aranan.PList);
                ListeyiDoldur(sonuc2);
            }
            else if (secilenKisi is Hasta)
            {
                var sonuc2 = Kisi.HastaArama(txtArama.Text, aranan.HasList);
                ListeyiDoldur(sonuc2);
            }
        }

        private void ListeyiDoldur(List<Doktor> sonuc)
        {
            lstListe.Items.Clear();
            if (secilenKisi is Doktor)
            {
                foreach (var item in sonuc)
                {
                    ListViewItem liste = new ListViewItem();
                    liste.Text = item.Ad;
                    liste.SubItems.Add(item.Soyad);
                    liste.SubItems.Add(item.TC);
                    liste.SubItems.Add(item.DogumTarihi.ToShortDateString());
                    liste.SubItems.Add(item.Cinsiyet.ToString());
                    liste.SubItems.Add(item.Email);
                    liste.SubItems.Add(item.TelefonNumarasi);
                    liste.SubItems.Add(item.DoktorBransi.ToString());
                    liste.SubItems.Add(item.Maas.ToString());
                    lstListe.Items.Add(liste);
                    liste.Tag = item;
                }
            }
        }

        private void ListeyiDoldur(List<Hemsire> sonuc2)
        {
            lstListe.Items.Clear();
            if (secilenKisi is Hemsire)
            {
                foreach (var item in sonuc2)
                {
                    ListViewItem liste = new ListViewItem();
                    liste.Text = item.Ad;
                    liste.SubItems.Add(item.Soyad);
                    liste.SubItems.Add(item.TC);
                    liste.SubItems.Add(item.DogumTarihi.ToShortDateString());
                    liste.SubItems.Add(item.Cinsiyet.ToString());
                    liste.SubItems.Add(item.Email);
                    liste.SubItems.Add(item.TelefonNumarasi);
                    liste.SubItems.Add(item.HemsireBransi.ToString());
                    liste.SubItems.Add(item.Maas.ToString());
                    lstListe.Items.Add(liste);
                    liste.Tag = item;
                }
            }
        }

        private void ListeyiDoldur(List<Personel> sonuc3)
        {
            lstListe.Items.Clear();
            if (secilenKisi is Personel)
            {
                foreach (var item in sonuc3)
                {
                    ListViewItem liste = new ListViewItem();
                    liste.Text = item.Ad;
                    liste.SubItems.Add(item.Soyad);
                    liste.SubItems.Add(item.TC);
                    liste.SubItems.Add(item.DogumTarihi.ToShortDateString());
                    liste.SubItems.Add(item.Cinsiyet.ToString());
                    liste.SubItems.Add(item.Email);
                    liste.SubItems.Add(item.TelefonNumarasi);
                    liste.SubItems.Add(item.PersonelBransi.ToString());
                    liste.SubItems.Add(item.Maas.ToString());
                    lstListe.Items.Add(liste);
                    liste.Tag = item;
                }
            }
        }

        private void ListeyiDoldur(List<Hasta> sonuc4)
        {
            lstListe.Items.Clear();
            if (secilenKisi is Hasta)
            {
                foreach (var item in sonuc4)
                {
                    ListViewItem liste = new ListViewItem();
                    liste.Text = item.Ad;
                    liste.SubItems.Add(item.Soyad);
                    liste.SubItems.Add(item.TC);
                    liste.SubItems.Add(item.DogumTarihi.ToShortDateString());
                    liste.SubItems.Add(item.Cinsiyet.ToString());
                    liste.SubItems.Add(item.Email);
                    liste.SubItems.Add(item.TelefonNumarasi);
                    lstListe.Items.Add(liste);
                    liste.Tag = item;
                }
            }
        }

        #endregion


    }
}



