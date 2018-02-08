using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BauWissenProjectHastane.OOP.Model
{
    public class DataKayit
    {
        public static List<Personel> PersonelListesi = new List<Personel>();
        public static List<Hemsire> HemsireListesi = new List<Hemsire>();
        public static List<Doktor> DoktorListesi = new List<Doktor>();
        public static List<Randevu> RandevuListesi = new List<Randevu>();
        public static List<Hasta> HastaListesi = new List<Hasta>();

        public List<Personel> PList { get { return PersonelListesi; } set { PersonelListesi = value; } }
        public List<Hemsire> Hemist { get { return HemsireListesi; } set { HemsireListesi = value; } }
        public List<Doktor> DList { get { return DoktorListesi; } set { DoktorListesi = value; } }
        public List<Randevu> RList { get { return RandevuListesi; } set { RandevuListesi = value; } }
        public List<Hasta> HasList { get { return HastaListesi; } set { HastaListesi = value; } }
    }
}
