using The_Best_Application;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestButterflyGetAddNum()
        {
            var butterfly = new Butterfly (5, 10, 3, 6);
            Assert.AreEqual(60, butterfly.GetAddNum()); // проверяет на равенство два значения
        }

        [Test]
        public void TestButterflyGetSubNum()
        {
            var butterfly = new Butterfly(8, 10, 3, 6);
            Assert.AreEqual(18, butterfly.GetSubNum());
        }

        [Test]
        public void TestButterflyGenDen()
        {
            var butterfly = new Butterfly(8, 10, 3, 6);
            Assert.AreEqual(60, butterfly.GenDen());
        }

        [Test]
        public void TestButterflyDenZero()
        {
            var butterfly = new Butterfly(8, 0, 3, 6);
            Assert.AreEqual(Convert.ToInt32(null), butterfly.GetSubNum());
        }


        [Test]
        public void TestButterflyBigAdd()
        {
            var butterfly = new Butterfly(567, 234, 123, 890);
            Assert.AreEqual(533412, butterfly.GetAddNum());
        }

        [Test]
        public void TestButterflyMinus()
        {
            var butterfly = new Butterfly(-56, 34, 12, 15);
            Assert.AreEqual(-432, butterfly.GetAddNum());
        }

        [Test]
        public void TestButterflyAllZero()
        {
            var butterfly = new Butterfly(0, 0, 0, 0);
            Assert.AreEqual(Convert.ToInt32(null), butterfly.GetSubNum());
        }

    }
}