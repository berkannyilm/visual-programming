using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane
{
    public class Kitap
    {
        public string Ad;

        public string Yazar;

        public Kitap (string ad, string yazar)
        {
            Ad = ad;
            Yazar = yazar;
        }

        public override string ToString()
        {
            return Ad + " (" + Yazar + ")";
        }
    }
}
