using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_BauWissenProjectHastane.OOP.Interface
{
   public  interface IDataProvider
    {
        void Export(string path);
        void Import(string path);
    }
}
