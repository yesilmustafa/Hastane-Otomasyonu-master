using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BauWissenProjectHastane.OOP.Model
{
   public class Hasta:Kisi
    {
        public static List<Hasta> _hastalar = new List<Hasta>();

        public override string ToString()
        {
            return $"{Ad} {Soyad} ";
        }
    }
}
