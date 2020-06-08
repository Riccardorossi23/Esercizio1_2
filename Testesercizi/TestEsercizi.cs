using System;
using Esercizi;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Testesercizi
{
    [TestClass]
    public class TestEsercizi
    {
        [TestMethod]
        public void Max1()
        {
            double max = ClassEsercizi.Max(5, 2);
            Assert.AreEqual(max, 5);
        }
        [TestMethod]
        public void Minimo1()
        {
            double min = ClassEsercizi.Min(5, 2);
            Assert.AreEqual(min, 2);
        }
        [TestMethod]
        public void Media1()
        {
            double med = ClassEsercizi.Media(5, 2);
            Assert.AreEqual(med, 3.5);
        }
        [TestMethod]
        public void Max2()
        {
            double max2 = ClassEsercizi.Max(3, 4);
            Assert.AreEqual(max2, 4);
        }
        [TestMethod]
        public void Minimo2()
        {
            double min2 = ClassEsercizi.Min(3, 4);
            Assert.AreEqual(min2, 3);
        }
        [TestMethod]
        public void Media2()
        {
            double med2 = ClassEsercizi.Media(3, 4);
            Assert.AreEqual(med2, 3.5);
        }
        [TestMethod]
        public void Max3()
        {
            double max3 = ClassEsercizi.Max(7, 7);
            Assert.AreEqual(max3, 7);
        }
        [TestMethod]
        public void Minimo3()
        {
            double min3 = ClassEsercizi.Min(7, 7);
            Assert.AreEqual(min3, 7);
        }
        [TestMethod]
        public void Media3()
        {
            double med3 = ClassEsercizi.Media(7, 7);
            Assert.AreEqual(med3, 7);


        }
        [TestMethod]
        public void Array1()
        {
            double[] v = new double[] { 34.66, 14.1, 85, 68 };
            double risposta_aspettata = 201.76;
            double risp = ClassEsercizi.CalcoloMisterioso(v);
            Assert.AreEqual(risposta_aspettata, risp);

        }
        [TestMethod]
        public void Array2()
        {
            double[] v = new double[] { 7, 9.5, 4.5, 65 };
            double risposta_aspettata = 86;
            double risp = ClassEsercizi.CalcoloMisterioso(v);
            Assert.AreEqual(risposta_aspettata, risp);

        }
        [TestMethod]
        public void Array3()
        {
            double[] v = new double[] { 7.7, 95, 5, 3.67 };
            double risposta_aspettata = 111.37;
            double risp = ClassEsercizi.CalcoloMisterioso(v);
            Assert.AreEqual(risposta_aspettata, risp);

        }
    }
