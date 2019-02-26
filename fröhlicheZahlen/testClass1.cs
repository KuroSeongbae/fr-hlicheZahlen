using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fröhlicheZahlen
{
    public class testClass1
    {

        public static string ÜberprüfeObFröhlich(int zahl1)
        {
            while (true)
            {
                List<int> zahlenListe = ErstelleZahlenListe(zahl1);
                zahl1 = BerechneZwischensumme(zahlenListe);

                switch (zahl1) {
                    case 1:

                        return "fröhlich :)";
                    case 4:
                        return "traurig :(";
                    default:
                        break;
                }
            }
        }

        internal static List<int> ErstelleZahlenListe(int zahl)
        {
            var zahlen = new List<int>();
            while (zahl > 0)
            {
                zahlen.Add(zahl % 10);
                zahl = zahl /10;
            }
            zahlen.Reverse();
            return zahlen;
        }

        internal static int BerechneZwischensumme(List<int> zl)
        {
            var ergebnis = 0;
            for (int i = 0; i <= zl.Count(); i++)
            {
                ergebnis += zl[i] * zl[i];
            }

            return ergebnis;
        }
    }

}
