using System;
using System.Collections.Generic;

namespace homeWorkk
{
    class Program
    {
        static void Main(string[] args)
        {
            generateData gt = new generateData(); 
           
            Random rnd = new Random();
            List<person> kisiler = new List<person>();
            int sayac = 1;
            for (int i = 0; i < 100; i++)
            {
                person pr = new person();
                pr.Ad = gt.personName;
                pr.Soyad = gt.personSurname;
                pr.Sehir = gt.personCity;
                var a = rnd.Next(12, 22);
                pr.dogumTarihi = DateTime.Now.AddYears(-a);
                kisiler.Add(pr);

            }



            Console.WriteLine("***************************************************************");
            Console.WriteLine($"{"NAME",-10} {"SURNAME",-10}{"CITY",-10}{"DATEBIRTH",-15}{"AGE",-10}");
            Console.WriteLine("----------------------------------------------------------------");
            foreach (var item in kisiler)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{sayac,-10}{item.Ad,-10}{item.Soyad,-10}{item.Sehir,-10}{item.dogumTarihi.ToShortDateString(),-15}{2019-item.dogumTarihi.Year,-10}");
                sayac++;
            }

            
            Console.ReadLine();
        }
    }
}