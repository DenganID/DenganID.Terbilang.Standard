using DenganID.Terbilang.Standard;
using NUnit.Framework;

namespace TerbilangTests
{
    [TestFixture]
    public class UnitTests1
    {
        private Terbilang _terbilang;
        
        [SetUp]
        public void Setup()
        {
            _terbilang = new Terbilang();
        }

        private bool Run(int num, string result)
        {
            return _terbilang.From(num) == result;
        }
        
        [Test]
        public void Satu()
        {
            var result = Run(1, "satu");
            Assert.IsTrue(result);
        }
        
        [Test]
        public void Sembilan()
        {
            var result = Run(9, "sembilan");
            Assert.IsTrue(result);
        }
        
        [Test]
        public void DuaBelas()
        {
            var result = Run(12, "dua belas");
            Assert.IsTrue(result);
        }

        [Test]
        public void SatuJutaLimaRatusRibuDuaPuluhTujuh()
        {
            var angka = 1000000 + 500000 + 27;
            var result = Run(angka, "satu juta lima ratus ribu dua puluh tujuh");
            Assert.IsTrue(result);
        }

    }
}