using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UyduAlicisi.Model
{
    class Kanal
    {
        public int KanalID { get; set; }
        public string KanalAdi { get; set; }
        public int Frekans { get; set; }
        public string YayinAdi { get; set; }
        public string Dil { get; set; }
        public bool HDmi { get; set; }
        public int? RadyoID { get; set; }
    }
}
