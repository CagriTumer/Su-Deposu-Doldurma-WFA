using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFaSuDeposuEvent
{
    public delegate void DepoDolmaEventHandler(object sender, TasmaMiktariEventArgs e);
    public class SuDeposu
    {
        public event DepoDolmaEventHandler DepoDoldu;

        public SuDeposu(int kapasite)
        {
            Kapasite = kapasite;
        }
        public int Kapasite { get; private set; }
        public int SuMiktari { get; private set; }
        public decimal DolulukOranı => SuMiktari / Kapasite;

        public void Ekle(int miktar)
        {
            SuMiktari += miktar;
            if (SuMiktari>= Kapasite)
            {
                int tasan = SuMiktari - Kapasite;
                SuMiktari = Kapasite;
                if (DepoDoldu!=null)
                {
                    DepoDoldu(this, new TasmaMiktariEventArgs(tasan));
                }
            }
        }

    }
}
