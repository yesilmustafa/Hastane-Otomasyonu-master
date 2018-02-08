using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_BauWissenProjectHastane.OOP.Interface;

namespace WFA_BauWissenProjectHastane.OOP.Model.File_Islemleri
{
    public class JsonData : IDataProvider
    {
        public void Export(string path)
        {
            if (DataKayit.DoktorListesi.Count == 0 && DataKayit.HastaListesi.Count == 0 && DataKayit.HemsireListesi.Count == 0 && DataKayit.PersonelListesi.Count == 0 && DataKayit.RandevuListesi.Count == 0)
            {
                throw new Exception("Dışarı Aktarılacak Kayıt yok!");
            }
            FileStream Dfile = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using (StreamWriter writer = new StreamWriter(Dfile))
            {
                string Sonuc = JsonConvert.SerializeObject(new DataKayit());
                writer.Write(Sonuc);
                writer.Close();
                Dfile.Close();
            }
        }

        public void Import(string path)
        {
            
            FileStream dosya = File.OpenRead(path);
            StreamReader reader = new StreamReader(dosya);
            string icerik = reader.ReadToEnd();
            dosya.Close();
            reader.Close();
            DataKayit dt = JsonConvert.DeserializeObject<DataKayit>(icerik);
        }
    }
}
