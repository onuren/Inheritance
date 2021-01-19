using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim
{
    class stok
    {
        BeyazEsya[] esyalar;

        public stok()
        {
            esyalar = new BeyazEsya[0];
        }

        public void Ekle(buzdolabi bu)
        {
            BeyazEsya[] gecici = new BeyazEsya[esyalar.Length + 1];
            Array.Copy(esyalar, gecici, esyalar.Length);
            gecici[gecici.Length - 1] = bu;
            esyalar = gecici;
        }
        public void Ekle(bulasikMakinesi bm)
        {
            BeyazEsya[] gecici = new BeyazEsya[esyalar.Length + 1];
            Array.Copy(esyalar, gecici, esyalar.Length);
            gecici[gecici.Length - 1] = bm;
            esyalar = gecici;
        }

        public void listele()
        {
            foreach (BeyazEsya item in esyalar)
            {
                Console.WriteLine(item.Yazdir());
            }
        }
    }
}
