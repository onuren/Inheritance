using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim
{
    class buzdolabi:BeyazEsya
    {
        public int hacim;

        public override string Yazdir()
        {
            return base.Yazdir() + "Hacim: "+hacim;
        }
    }
    class bulasikMakinesi:BeyazEsya
    {
        public int programSayisi;

        public override string Yazdir()
        {
            return base.Yazdir()+"Program Sayısı: "+programSayisi;
        }
    }
}
