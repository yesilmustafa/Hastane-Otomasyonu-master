using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BauWissenProjectHastane.OOP.Model
{
   public class Randevu
    {
        public Guid ID { get; set; } = Guid.NewGuid();
        public DateTime RandevuGunSaat { get; set; } = new DateTime(1, 1, 1);
        public Doktor Doktor { get; set; }
        public Hasta Hasta { get; set; }
       
    }
}
