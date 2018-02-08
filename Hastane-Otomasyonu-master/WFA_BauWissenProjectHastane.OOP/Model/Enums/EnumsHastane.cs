using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BauWissenProjectHastane.OOP.Model.Enums
{
    public class EnumsHastane
    {
        public enum EnumCinsiyet
        {
            Erkek,
            Kadın
        }
        public enum EnumDoktorBrans
        {
            Göz_Hastalıkları,
            Beyin_Cerrahisi,
            Kalp_Damar_Cerrahisi,
            Gastro_Cerrahi,
            Genel_Cerrahi,
            Anestezi,
            Ortopedi,
            Pediatrik_Cerrahi,
            Kulak_Burun_Boğaz_Hekimliği,
            Genel_Dahiliye,
            Pediatri,
            Psikiatri,
            Fizik_Tedavi_ve_Rehabilitasyon,
            Kardioloji
        }

        public enum EnumHemsireBrans
        {
            Anestezi_Hemşiresi,
            Ebe,
            Diyabet_Hemşiresi,
            Yeni_Doğan_Hemşiresi,
            Klinik_Hemşiresi,
            Yaşlı_Bakım_Hemşiresi,
            Akademisyen_Hemşire
        }
        public enum EnumPersonelBrans
        {
            Hizmetli,
            Memur,
            Bilgi_İşlem,
            Muasebe,
            Sekreter,
            Tıbbi_Müdür,
            İdari_Müdür,
            Baş_Hekim,
            Eczacı,
            Röntgen_Teknisyeni,
            Pratisyen_Hekim
        }
        public enum DosyaTuru
        {
            JSON,
            XML
        }
    }
}
