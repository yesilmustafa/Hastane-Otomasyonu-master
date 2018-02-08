using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_BauWissenProjectHastane.OOP.Interface;
using static WFA_BauWissenProjectHastane.OOP.Model.Enums.EnumsHastane;

namespace WFA_BauWissenProjectHastane.OOP.Model
{
    public class Doktor : Kisi, IMaasAlabilen, IHemsireAlabilen
    {
       
        public List<Hemsire> _doktorabaglihemsirelistesi = new List<Hemsire>();
        public EnumDoktorBrans DoktorBransi { get; set; }

        public decimal Maas
        {
            get;
            set;
        } = 0;

        List<Hemsire> IHemsireAlabilen.DoktoraBagliHemsireListesi
        {
            get
            {
                return _doktorabaglihemsirelistesi;
            }

            set
            {
                _doktorabaglihemsirelistesi = value;
            }
        }

        public override string ToString()
        {
            return $"{Ad} {Soyad} ";
        }
    }
}
