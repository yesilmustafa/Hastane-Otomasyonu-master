using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFA_BauWissenProjectHastane.OOP.Model;

namespace WFA_BauWissenProjectHastane.OOP.Interface
{
    public interface IHemsireAlabilen
    {
        List<Hemsire> DoktoraBagliHemsireListesi { get; set; }
    }
}
