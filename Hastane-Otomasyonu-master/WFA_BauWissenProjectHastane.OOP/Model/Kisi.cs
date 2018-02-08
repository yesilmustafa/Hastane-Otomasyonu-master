using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static WFA_BauWissenProjectHastane.OOP.Model.Enums.EnumsHastane;

namespace WFA_BauWissenProjectHastane.OOP.Model
{
    public class Kisi
    {
        private string _ad;
        public string Ad { get { return _ad; } set { _ad = YaziDuzen(value); } }
        private string _soyad;
        public string Soyad { get { return _soyad; } set { _soyad = YaziDuzen(value); }}
        private string _tc;
        public string TC { get { return _tc; } set {_tc=TCKNKontrol(value); } }     

        public DateTime DogumTarihi { get; set; }

        public EnumCinsiyet Cinsiyet { get; set; }

        public Guid ID { get; set; } = Guid.NewGuid();
        private string _email;
        public string Email { get { return _email; } set { _email = EMailKontrol(value); } }
        private string _telNo;

        public string TelefonNumarasi { get { return _telNo; } set { _telNo = TelefonNumarasiKontrol(value); } }


        #region Kontroller
        private string YaziDuzen(string _kelime)
        {
            if (String.IsNullOrEmpty(_kelime)) return "";
            string yaziduzen = _kelime.Trim();
            foreach (char harf in yaziduzen)
            {
                if (!char.IsLetter(harf) || char.IsWhiteSpace(harf))
                    throw new Exception("Yazı içerisinde geçersiz karakter bulunmaktadır!");
            }
            if (yaziduzen.Length < 3)
                throw new Exception("Yazınız en az 3 karakter olmalı");
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(yaziduzen);
        }
        private string TCKNKontrol(string _tckn)
        {
            if (String.IsNullOrEmpty(_tckn)) return "";
            if (_tckn.Length != 11)
                throw new Exception("TCKN 11 haneli olmalıdır");
            foreach (char harf in _tckn)
                if (!char.IsDigit(harf))
                    throw new Exception("TCKN içerisinde sadece rakam bulunmalıdır");
            if (Convert.ToInt32(_tckn[10]) % 2 != 0)
                throw new Exception("TCKN son rakamı çift olmalı");
            if (_tckn[0] == '0')
                throw new Exception("TCKN '0' ile başlayamaz");
            return _tckn;
        }

        private string TelefonNumarasiKontrol(string _telefonNo)
        {
            if (String.IsNullOrEmpty(_telefonNo)) return "";
            /*Telefon desenini belirledik.*/
            string telefonDeseni = "^(05)[0-9][0-9][1-9]([0-9]){6}$";
            /*Telefon desenine uygun RegularExpression degiskenini olusturduk.*/
            Regex rxTelefon = new Regex(telefonDeseni);
            /*textbox'a girilen deger, telefonDeseni'ne uyuyorsa uyari ver.*/
            if (!rxTelefon.Match(_telefonNo).Success)
                throw new Exception("telefon numarası hatalı");
            else
                return _telefonNo;
        }

        public string EMailKontrol(string _email)
        {
            if (String.IsNullOrEmpty(_email)) return "";
            string patternStrict = @"^(([^<>()[\]\\.,;:\s@\""]+"
            + @"(\.[^<>()[\]\\.,;:\s@\""]+)*)|(\"".+\""))@"
            + @"((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}"
            + @"\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+"
            + @"[a-zA-Z]{2,}))$";
            Regex reStrict = new Regex(patternStrict);
            bool gecerliMi = reStrict.IsMatch(_email);
            if (!gecerliMi)
                throw new Exception("email adresi hatalı");
            else
                return _email;
        }
        #endregion

        #region Arama İşlemleri
        public static List<Doktor> DoktorArama(string kelime, List<Doktor> kisiler)
        {
            string arama = kelime.ToLower();
            var sonuc = kisiler.Where(x => x.Ad.ToLower().Contains(arama) || x.Soyad.ToLower().Contains(arama) || x.TC.Contains(arama)).ToList();
            return sonuc;
        }
        public static List<Hemsire> HemsireArama(string kelime, List<Hemsire> kisiler)
        {
            string arama = kelime.ToLower();
            var sonuc = kisiler.Where(x => x.Ad.ToLower().Contains(arama) || x.Soyad.ToLower().Contains(arama) || x.TC.Contains(arama)).ToList();
            return sonuc;
        }
        public static List<Personel> PersonelArama(string kelime, List<Personel> kisiler)
        {
            string arama = kelime.ToLower();
            var sonuc = kisiler.Where(x => x.Ad.ToLower().Contains(arama) || x.Soyad.ToLower().Contains(arama) || x.TC.Contains(arama)).ToList();
            return sonuc;
        }
        public static List<Hasta> HastaArama(string kelime, List<Hasta> kisiler)
        {
            string arama = kelime.ToLower();
            var sonuc = kisiler.Where(x => x.Ad.ToLower().Contains(arama) || x.Soyad.ToLower().Contains(arama) || x.TC.Contains(arama)).ToList();
            return sonuc;
        }
        #endregion
    }

}
