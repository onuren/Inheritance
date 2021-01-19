using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalitim
{
    class BeyazEsya
    {
        public string marka;
        public string model;
        public double fiyat;

        public virtual string Yazdir()
        {
            return "marka: " + marka + " model: " + model + " fiyat: " + fiyat;
        }
    }
}
