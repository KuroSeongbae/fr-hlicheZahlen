using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using fröhlicheZahlen;

namespace testsFürFröhlicheZahlen
{
    [TestFixture]
    public class Tests1
    {
        [Test, Category ("Gerüsttest")]

        public void ZahlenListe()
        {
            var ergebnis = fröhlicheClass.ErstelleZahlenListe(123);
            Assert.AreEqual(new[] { 1, 2, 3 }, ergebnis.ToArray());
        }

        [Test, Category ("Gerüsttest")]

        public void Berechnung()
        {
            var ergebnis = fröhlicheClass.BerechneZwischensumme(new List<int> { 1, 2, 3 });
            Assert.AreEqual(14, ergebnis);
        }

        [Test, Category ("Akzeptanztest")]

        public void FröhlichOderTraurig()
        {
            var ergebnis = fröhlicheClass.ÜberprüfeObFröhlich(19);
            Assert.AreEqual("fröhlich :)", ergebnis.ToString());
        }
    }
}
