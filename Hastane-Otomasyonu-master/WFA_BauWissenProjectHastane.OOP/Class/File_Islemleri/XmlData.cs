using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WFA_BauWissenProjectHastane.OOP.Interface;

namespace WFA_BauWissenProjectHastane.OOP.Model.File_Islemleri
{
    public class XmlData : IDataProvider
    {
        public void Export(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataKayit));
            StringWriter yazici = new StringWriter();
            FileStream Dfile = File.Open(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            using (StreamWriter writer = new StreamWriter(Dfile))
            {
                xmlSerializer.Serialize(writer, new DataKayit());
                writer.Close();
                Dfile.Close();
            }
        }

        public void Import(string path)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataKayit));
            StringWriter yazici = new StringWriter();

            using (TextReader reader = new StreamReader(path))
            {
                DataKayit dt = xmlSerializer.Deserialize(reader) as DataKayit;
                reader.Close();
            }
        }
    }
}
