using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;   // Notwendig, um Exceptions testen zu können.
using _13._3_tdd_Geometrie; // <zuTestendesProjekt> angeben.
                            // Zusätzlich Verweis hinzufügen (Eigenschaft des Testsprojekts).

namespace _13._3_tdd_GeometrieTests // Namenskonvention: <zuTestendesProjekt>Tests
{
    [TestClass]
    public class RechteckTests  // Namenskonvention: <zuTestendeKlasse>Tests
    {
        # region BereitsErledigt
        [TestMethod] // Muss angegeben werden, damit der Testexplorer den Test findet.
        public void Rechteck_kannOhneParameterErstelltWerden()
        {
            // Arrange

            // Act
            Rechteck r = new Rechteck();

            // Assert
            Assert.AreEqual(0, r.Breite);
            Assert.AreEqual(0, r.Hoehe);
        }

        [TestMethod]
        public void Skalieren_AendertBreiteUndHoehe()
        {
            // Arrange
            Rechteck r = new Rechteck();
            r.Breite = 10;
            r.Hoehe = 20;
            double faktor = 1.5;

            // Act
            r.Skalieren(faktor);

            // Assert
            Assert.AreEqual(15, r.Breite);
            Assert.AreEqual(30, r.Hoehe);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Skalieren_ZuNiedrigerFaktorWirftException()
        {
            // Arrange
            Rechteck r = new Rechteck();
            r.Breite = 10;
            r.Hoehe = 20;

            // Act
            r.Skalieren(0);
        }

        #endregion

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Breite_ZuNiedrigerWertWirftException()
        {
            // Arrange
            Rechteck r = new Rechteck();

            // Act
            r.Breite = -1;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Hoehe_ZuNiedrigerWertWirftException()
        {
            // Arrange
            Rechteck r = new Rechteck();

            // Act
            r.Hoehe = -1;
        }

        [TestMethod] 
        public void Umfang_WirdBerechnet()
        {
            // Arrange
            Rechteck r = new Rechteck();
            r.Breite = 10;
            r.Hoehe = 20;

            // Act
            int ergebnis = r.Umfang();

            // Assert
            Assert.AreEqual(60, ergebnis);
        }

        [TestMethod]
        public void Flaeche_WirdBerechnet()
        {
            // Arrange
            Rechteck r = new Rechteck();
            r.Breite = 10;
            r.Hoehe = 20;

            // Act
            int ergebnis = r.Flaeche();

            // Assert
            Assert.AreEqual(200, ergebnis);
        }

        [TestMethod]
        public void Rechteck_KannMitStartwertenErsteltWerden()
        {
            // Arrange
            int breite = 1;
            int hoehe = 2;

            // Act
            Rechteck r = new Rechteck(breite, hoehe);
            
            // Assert
            Assert.AreEqual(breite, r.Breite);
            Assert.AreEqual(hoehe, r.Hoehe);
        }
    }
}