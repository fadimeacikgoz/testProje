using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace homeWorkk
{

   
    class person
    {
        private string ad;
        private string soyad;
        private string sehir;
        private DateTime DT;
        public string Ad {
            get {return ad.First().ToString().ToUpper()+ad.Substring(1);}
            set { ad = value; }
        }
        public string Soyad {
            get { return soyad.ToUpper(); }
            set { soyad = value; }
       
        }
        public string Sehir { get; set; }
        public DateTime  dogumTarihi { get; set; }
     
    }
}