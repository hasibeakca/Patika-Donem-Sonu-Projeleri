using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telefon_Rehberi
{
    public class Kisiler
    {
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string telNo { get; set; }
        public Kisiler() { }
        public Kisiler(string Isim, string Soyisim, string TelNo)
        {
            this.isim = Isim;
            this.soyisim = Soyisim;
            this.telNo = TelNo;
        }

    }
}
