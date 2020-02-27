using Microsoft.VisualStudio.TestTools.UnitTesting;
using Projekt_bazodanowy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_bazodanowy.Tests
{
    [TestClass()]
    public class Form1TestBasketball
    {
        [TestMethod()]
        public void odczytZJsonTestOdczytJson_Pozytywny()
        {
            Form1 forma = new Form1(false);
            List<Zespol> testoweZespoly;
            string sciezkaPlik = @"C:\Users\sniad\Desktop\STUDIA\2 ROK\Pracownia programowania\Projekt bazodanowy\Basketball.json";
            bool resultat = forma.sprawdzJson(out testoweZespoly, sciezkaPlik);

            Assert.AreEqual(resultat, true);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Wyjątek dotyczy niepoprawnego zespołu id")]
        public void odczytZJsonTestOdczytJson_Negatywny()
        {
            Form1 forma = new Form1(false);
            List<Zespol> testoweZespoly;
            string sciezkaPlik = @"C:\Users\sniad\Desktop\STUDIA\2 ROK\Pracownia programowania\Projekt bazodanowy\Basketball - błędne.json";
            bool resultat = forma.sprawdzJson(out testoweZespoly, sciezkaPlik);
        }

        [TestMethod()]
        public void odczytZXmlTestOdczytXml_Pozytywny()
        {
            Form1 forma = new Form1(false);
            List<Zespol> testoweZespoly;
            string sciezkaPlik = @"C:\Users\sniad\Desktop\STUDIA\2 ROK\Pracownia programowania\Projekt bazodanowy\Basketball.xml";
            bool resultat = forma.sprawdzXml(out testoweZespoly, sciezkaPlik);

            Assert.AreEqual(resultat, true);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException), "Wyjątek dotyczy niepoprawnego zespołu id")]
        public void odczytZXmlTestOdczytXml_Negatywny()
        {
            Form1 forma = new Form1(false);
            List<Zespol> testoweZespoly;
            string sciezkaPlik = @"C:\Users\sniad\Desktop\STUDIA\2 ROK\Pracownia programowania\Projekt bazodanowy\Basketball - błędne.xml";
            bool resultat = forma.sprawdzXml(out testoweZespoly, sciezkaPlik);
        }
    }


}