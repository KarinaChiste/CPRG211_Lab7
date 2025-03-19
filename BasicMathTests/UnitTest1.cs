using BasicMath;
namespace BasicMathTests
{
    [TestFixture]
    public class Tests
    {
        
        private BasicMath1? newObject;
        [SetUp]
        public void Setup()
        {
            newObject = new BasicMath1();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [Test]
        public void Test_AddMethod()
        {
            double expected = 5;
            double actual = newObject.Add(3, 2);
            Assert.AreEqual(expected, actual);
            

        }

        [Test]
        public void Test_SubtractMethod()
        {
            double expected = 1;
            double actual = newObject.Subtract(3, 2);
            Assert.AreEqual(expected, actual);


        }

        [Test]
        public void Test_MultiplyMethod()
        {
            double expected = 6;
            double actual = newObject.Multiply(3, 2);
            Assert.AreEqual(expected, actual);


        }

        [Test]
        public void Test_DivideMethod()
        {
            double expected = 1.5;
            double actual = newObject.Divide(3, 2);
            Assert.AreEqual(expected, actual);


        }
    }
}

