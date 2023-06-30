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
        public void Test1()//�������� ������ �������� ������ (��������)
        {
            Cabel cabel = new Cabel("����������",50,500);
            double actuality = cabel.CalculateQuality();
            Assert.AreEqual(10, actuality);
            Assert.Pass();
            
        }
        [Test]
        public void Test2()//�������� ������ ��������� ������ ��� ������� ������� (��������)
        {
            CabelChild cabelChild=new CabelChild("����������",1000,100000,true);
            double actuality = cabelChild.CalculateQuality();
            Assert.AreEqual(200, actuality);
            Assert.Pass();
        }
        [Test]
        public void Test3() //�������� ������ ��������� ������ ��� ���������� ������� (��������)
        {
            CabelChild cabelChild = new CabelChild("������", 1000, 100000, false);
            double actuality = cabelChild.CalculateQuality();
            Assert.AreEqual(70, actuality);
            Assert.Pass();
        }
        [Test]
        public void Test4() //�������� ������ �������� ������ ��� ���������� ������ ������� ��� ������� ������ (�����������)
        {
            Cabel cabel = new Cabel("������",1000,600);
            double actuality = cabel.CalculateQuality();
            Assert.AreNotEqual(0.6, actuality);
            
        }



    }
}