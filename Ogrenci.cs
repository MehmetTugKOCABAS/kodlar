using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
{
    internal class Ogrenci
    {
        public int No;
        public string Ad;
        public string Soyad;
        public string Sube;
        public int sira;

        public Ogrenci()
        {
            Console.WriteLine("bir nesen olusturuldu");
        }
        public int yas(int dogumyil)
        {
            return  DateTime.Now.Year - dogumyil;
           

        }
    }
}
