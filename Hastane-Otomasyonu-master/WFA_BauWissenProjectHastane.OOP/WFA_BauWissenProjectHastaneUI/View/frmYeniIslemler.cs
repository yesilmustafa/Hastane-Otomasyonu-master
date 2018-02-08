using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_BauWissenProjectHastane.OOP.Model;

namespace WFA_BauWissenProjectHastaneUI.View
{
    public partial class frmYeniIslemler : Form
    {
        public frmYeniIslemler(Kisi k)
        {
            InitializeComponent();
            ucIslem1.secilenKisi = k;
        }
        public frmYeniIslemler()
        {
            InitializeComponent();
        }
    }
}
