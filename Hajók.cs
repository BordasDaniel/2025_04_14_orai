using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_04_14_orai
{
    public class Hajók
    {
        public string Osztály { get; set; }
        public string Típus { get; set; }
        public string Ország { get; set; }
        public int ÁgyúkSzáma { get; set; }
        public int Kaliber { get; set; }
        public int Vízkiszorítás { get; set; }


        public Hajók(string osztály, string típus, string ország, int ágyúkSzáma, int kaliber, int vízkiszorítás)
        {
            Osztály = osztály;
            Típus = típus;
            Ország = ország;
            ÁgyúkSzáma = ágyúkSzáma;
            Kaliber = kaliber;
            Vízkiszorítás = vízkiszorítás;
        }

        public Hajók(string allomany)
        {
            string[] adatok = allomany.Split(';');
            Osztály = adatok[0];
            Típus = adatok[1];
            Ország = adatok[2];
            ÁgyúkSzáma = int.Parse(adatok[3]);
            Kaliber = int.Parse(adatok[4]);
            Vízkiszorítás = int.Parse(adatok[5]);
        }


    }
}
