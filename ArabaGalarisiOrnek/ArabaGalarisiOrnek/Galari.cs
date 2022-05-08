using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArabaGalarisiOrnek
{
    public class Galari
    {
        //(firmabilgilerivb.)
        public string GalariAd{ get; set; }
        // arabalareklenip,çıkartılabilir(satılabilir),listelemeyapılabilir.
        private List<Araba> Arabalar = new List<Araba>();
        public void ArabaEkle(Araba a)
        {
            //Araba ekleme islemleri
            Arabalar.Add(a);
        }
        public string ArabaListele()
        {
            //Araba listeleme islemleri
            string bilgiler = "";
            foreach (Araba araba in Arabalar)
            {
                bilgiler += "\nMarka: " + araba.Marka +
                            "\nModel: " + araba.Model +
                           "\nRenk: " + araba.Renk + "\n";
            }

            return bilgiler;
        }
        public void ArabaCikar(Araba a)
        {
            //Araba cikarma islemleri
            Arabalar.Remove(a);
        }
        public List<Araba> ArabaListesiVer()
        {
            return Arabalar;
        }

    }
}
