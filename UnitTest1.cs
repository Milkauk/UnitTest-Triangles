using NUnit.Framework;

namespace KolmionTestit
{
    //
    // Milka Ukkonen
    //
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
       
        [Test]
        [Repeat(5)] //Repeat Attribute, eli ajetaan testi l‰pi sulkeissa olevan m‰‰r‰n verran
        public void TestSimpleTasasivuinen()
        {
            //Arrange
            int a = 10;
            int b = 10;
            int c = 10;
            bool odote = true;
            KolmioTarkistin kolmiotarkistin = new KolmioTarkistin();

            //Act
            bool saanti = kolmiotarkistin.OnTasasivuinen(a, b, c);

            //Assert
            Assert.AreEqual(odote, saanti);
        }
        [Test]
        [Repeat(5)] //Repeat Attribute, eli ajetaan testi l‰pi sulkeissa olevan m‰‰r‰n verran
        public void TestSimpleTasakylkinen()
        {
            //Arrange
            int a = 10;
            int b = 10;
            int c = 5;
            bool odote = true;
            KolmioTarkistin kolmiotarkistin = new KolmioTarkistin();

            //Act
            bool saanti = kolmiotarkistin.OnTasakylkinen(a, b, c);

            //Assert
            Assert.AreEqual(odote, saanti);
        }
        [Test]
        [Repeat(5)] //Repeat Attribute, eli ajetaan testi l‰pi sulkeissa olevan m‰‰r‰n verran
        public void TestSimpleEpasaannollinen()
        {
            //Arrange
            int a = 10;
            int b = 7;
            int c = 5;
            bool odote = true;
            KolmioTarkistin kolmiotarkistin = new KolmioTarkistin();

            //Act
            bool saanti = kolmiotarkistin.OnEpasaannollinen(a, b, c);

            //Assert
            Assert.AreEqual(odote, saanti);
        }
    }
    public class KolmioTarkistin
    {
        public bool OnTasasivuinen(int a, int b, int c)
            //tarkistaa onko kolmion kaikki sivut samanpituiset
        {
            if ((a == b) && (b == c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool OnTasakylkinen(int a, int b, int c)
            //tarkistaa onko kolmion kaksi sivua samanpituiset ja yksi eripituinen
        {
            if((a==b) || (a==c) || (b == c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool OnEpasaannollinen(int a, int b, int c)
            //Tarkistaa onko kolmion kaikki sivut erimittaiset
        {
            if((a!=b) && (b != c))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
    
}