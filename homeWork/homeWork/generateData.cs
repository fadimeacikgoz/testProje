using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace homeWorkk
{
    class generateData
    {
      
        
        string[] name = { "fadime", "rengin", "zeynep", "gokçe" };
        string[] surname = { "Açıkgöz", "Atilla", "Pektaş", "Tenekeci" };
        string[] city = { "Yozgat", "Batman", "Malatya", "sakarya" };
        Random rnd = new Random();
        public string personName
        {
            get { return name[rnd.Next(0,4)]; }
        }
        public string personSurname
        {
           get { return surname[rnd.Next(0, 4)]; }
        }
        public string personCity
        {
            get { return city[rnd.Next(0, 4)]; }
        }
        public DateTime personTarih
        {
            get
            {
                var a = rnd.Next(12, 22);
                return Convert.ToDateTime(a);
            }
    }
     
}
        
}