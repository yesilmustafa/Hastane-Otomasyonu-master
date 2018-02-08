using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using WFA_BauWissenProjectHastane.OOP.Model.File_Islemleri;
using static WFA_BauWissenProjectHastane.OOP.Model.Enums.EnumsHastane;

namespace WFA_BauWissenProjectHastane.OOP.Model
{
    public class ImportAndExport
    {
        public JsonData dsjs { get; set; } = new JsonData();
        public XmlData dsxml { get; set; } = new XmlData();

        public void Export(DosyaTuru Tur, string path)
        {
            try
            {

                if (DosyaTuru.JSON == Tur)
                {
                    dsjs.Export(path);
                }
                else if (DosyaTuru.XML == Tur)
                {
                    dsxml.Export(path);
                }
            }
            catch (Exception ex)
            {
               
            }
        }
        public  void Import(DosyaTuru Tur, string path)
        {
            try
            {
                if (DosyaTuru.JSON == Tur)
                {
                    dsjs.Import(path);
                }
                else if (DosyaTuru.XML == Tur)
                {
                    dsxml.Import(path);
                }
            }
            catch (Exception ex)
            {
               
            }
        }
    }
}
