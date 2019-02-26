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
            var ergebnis = testClass1.ErstelleZahlenListe(123);
            Assert.AreEqual(new[] { 1, 2, 3 }, ergebnis.ToArray());
        }
    }
}
