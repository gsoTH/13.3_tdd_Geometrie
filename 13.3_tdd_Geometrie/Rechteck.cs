using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._3_tdd_Geometrie
{
    // Klasse muss public sein, sonst kann sie das 
    // externe Testprojekt nicht nutzen.
    public class Rechteck 
    {
        private int breite;
        private int hoehe;

        public int Breite { 
            get { return breite; } 
            set { breite = value; }
            
        }
        public int Hoehe { 
            get { return hoehe; } 
            set { hoehe = value; }
        }

        public void Skalieren(double faktor)
        {
            if (faktor <= 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            breite = Convert.ToInt32(breite * faktor);
            hoehe = Convert.ToInt32(hoehe * faktor);
        }
    }
}
