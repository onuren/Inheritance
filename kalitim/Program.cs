using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            stok stk = new stok();

            buzdolabi buz = new buzdolabi();
            buz.marka = "Arçelik";
            buz.model = "asde123";
            buz.hacim = 8;
            buz.fiyat = 1500;

            bulasikMakinesi bul = new bulasikMakinesi();
            bul.marka = "Ariston";
            bul.model = "erf123";
            bul.programSayisi = 5;
            bul.fiyat = 2000;

            stk.Ekle(buz);
            stk.Ekle(bul);

            stk.listele();
        }
    }
}
