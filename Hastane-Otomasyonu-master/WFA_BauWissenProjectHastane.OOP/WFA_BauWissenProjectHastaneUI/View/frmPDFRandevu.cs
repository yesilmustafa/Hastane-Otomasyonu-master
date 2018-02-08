using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_BauWissenProjectHastane.OOP.Model;

namespace WFA_BauWissenProjectHastaneUI.View
{
    public partial class frmPDFRandevu : Form
    {
        public frmPDFRandevu()
        {
            InitializeComponent();
        }

        private void frmPDFRandevu_Load(object sender, EventArgs e)
        {
            cmbDoktorlar.Items.AddRange(DataKayit.DoktorListesi.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument PD = new PrintDocument();
            PD.PrintPage += new PrintPageEventHandler(OnPrintDocument);

            try
            {
                PD.Print();
            }
            catch
            {
                Console.WriteLine("Yazıcı çıktısı alınamıyor...");
            }
            finally
            {
                PD.Dispose();
            }
        }

        private void OnPrintDocument(object sender, PrintPageEventArgs e)
        {

            e.Graphics.DrawString((cmbDoktorlar.SelectedItem as Doktor).ToString(), new Font("Arial", 14), new SolidBrush(Color.Black), 50, 50);
            int y = 100;
            foreach (Randevu randevu in DataKayit.RandevuListesi)
            {
                if ((cmbDoktorlar.SelectedItem as Doktor).ID==randevu.Doktor.ID)
                {
                    e.Graphics.DrawString($"Hasta TC: {randevu.Hasta.TC} Hasta Ad-Soyad:{randevu.Hasta.ToString()} Randevu Saati:{randevu.RandevuGunSaat.ToShortTimeString()}", new Font("Arial", 8), new SolidBrush(Color.Black), 60, y);
                }
                y += 20;
            }
        }
    }
}
