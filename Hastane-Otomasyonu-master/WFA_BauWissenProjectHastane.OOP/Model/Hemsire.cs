using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_BauWissenProjectHastane.OOP.Interface;
using static WFA_BauWissenProjectHastane.OOP.Model.Enums.EnumsHastane;

namespace WFA_BauWissenProjectHastane.OOP.Model
{
    public class Hemsire : Kisi, IMaasAlabilen
    {
        
        public bool atandiMi = false;
        public EnumHemsireBrans HemsireBransi { get; set; } 
        public override string ToString()
        {
            return $"{Ad} {Soyad} -{HemsireBransi}";
        }

        public decimal Maas
        {
            get;
            set;
        } = 0;

    }
}
