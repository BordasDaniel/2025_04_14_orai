using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_04_14_orai
{
    public class Hajok
    {
        public string Osztaly { get; set; }
        public string Tipus { get; set; }
        public string Orszag { get; set; }
        public int AgyukSzama { get; set; }
        public int Kaliber { get; set; }
        public int Vizkiszoritas { get; set; }


        public Hajok(string osztaly, string tipus, string orszag, int agyúkSzama, int kaliber, int vizkiszoritas)
        {
            Osztaly = osztaly;
            Tipus = tipus;
            Orszag = orszag;
            AgyukSzama = agyúkSzama;
            Kaliber = kaliber;
            Vizkiszoritas = vizkiszoritas;
        }

        public Hajok(string allomany)
        {
            string[] adatok = allomany.Split(';');
            Osztaly = adatok[0];
            Tipus = adatok[1];
            Orszag = adatok[2];
            AgyukSzama = int.Parse(adatok[3]);
            Kaliber = int.Parse(adatok[4]);
            Vizkiszoritas = int.Parse(adatok[5]);
        }


    }
}
