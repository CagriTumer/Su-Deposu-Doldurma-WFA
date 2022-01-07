using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wFaSuDeposuEvent
{
    public class TasmaMiktariEventArgs : EventArgs
    {
        private readonly int tasmaMiktari;

        public TasmaMiktariEventArgs(int tasmaMiktari)
        {
            this.tasmaMiktari = tasmaMiktari;
        }
        public int TasmaMiktari => tasmaMiktari;
    }
}
