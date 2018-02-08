using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_BauWissenProjectHastaneUI.View
{
    public partial class frmRandevu : Form
    {
        public frmRandevu()
        {
            InitializeComponent();
        }

        private void frmRandevu_Load(object sender, EventArgs e)
        {
            ucRandevu rnd = new ucRandevu();
            rnd.Dock = DockStyle.Fill;
            this.Controls.Add(rnd);
            rnd.BorderStyle = BorderStyle.None;
        }
    }
}
