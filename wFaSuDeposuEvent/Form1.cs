using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wFaSuDeposuEvent
{
    public partial class Form1 : Form
    {
        SuDeposu suDeposu = new SuDeposu(100);
        public Form1()
        {
            InitializeComponent();
            suDeposu.DepoDoldu += SuDeposu_DepoDoldu;
            pnlSu.Height = 0;
        }

        private void SuDeposu_DepoDoldu(object sender, TasmaMiktariEventArgs e)
        {
          //todo burası doldurulacak.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            suDeposu.Ekle((int)nudSuMiktari.Value);
            SuseviyesiniGuncelle();
        }

        private void SuseviyesiniGuncelle()
        {
            pnlSu.Height += suDeposu.SuMiktari;
        }
    }
}
