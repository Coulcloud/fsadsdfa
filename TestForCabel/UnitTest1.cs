using StahovskiySA_01_04;
using StahovskiySA_01_04.Models;

namespace TestForCabel
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()//проверка метода базового класса (успешный)
        {
            Cabel cabel = new Cabel("Алюминевый",50,500);
            double actuality = cabel.CalculateQuality();
            Assert.AreEqual(10, actuality);
            Assert.Pass();
            
        }
        [Test]
        public void Test2()//проверка метода дочернего класса при наличии оплетки (успешный)
        {
            CabelChild cabelChild=new CabelChild("Алюминевый",1000,100000,true);
            double actuality = cabelChild.CalculateQuality();
            Assert.AreEqual(200, actuality);
            Assert.Pass();
        }
        [Test]
        public void Test3() //проверка метода дочернего класса при отсутствии оплетки (успешный)
        {
            CabelChild cabelChild = new CabelChild("Медный", 1000, 100000, false);
            double actuality = cabelChild.CalculateQuality();
            Assert.AreEqual(70, actuality);
            Assert.Pass();
        }
        [Test]
        public void Test4() //проверка метода базового класса при количестве витков большем чем диаметр кабеля (безуспешный)
        {
            Cabel cabel = new Cabel("Медный",1000,600);
            double actuality = cabel.CalculateQuality();
            Assert.AreNotEqual(0.6, actuality);
            
        }



    }
}