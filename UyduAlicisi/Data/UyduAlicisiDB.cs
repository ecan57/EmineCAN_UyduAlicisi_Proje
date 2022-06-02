using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UyduAlicisi.Model;

namespace UyduAlicisi.Data
{
    class UyduAlicisiDB
    {
        public UyduAlicisiDB()
        {
            string strConn = ConfigurationManager.ConnectionStrings["ConnStr"].ConnectionString;
            Uydular = new Uydular(strConn);
            Radyolar = new Radyolar(strConn);
            Kanallar = new Kanallar(strConn);
            UyduRadyolar = new UyduRadyolar(strConn);
            UyduKanallar = new UyduKanallar(strConn);
        }
        public Uydular Uydular { get; set; }
        public Radyolar Radyolar { get; set; }
        public Kanallar Kanallar { get; set; }
        public UyduRadyolar UyduRadyolar { get; set; }
        public UyduKanallar UyduKanallar { get; set; }
    }
}
