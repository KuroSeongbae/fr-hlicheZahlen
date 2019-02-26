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

        public void ZahlInListe()
        {
            var ergebnis = testClass1.ZahlenListe(26);
            Assert.AreEqual(new[] { 2, 6 }, ergebnis.ToArray());
        }
    }
}
