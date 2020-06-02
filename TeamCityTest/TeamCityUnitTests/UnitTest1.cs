using NUnit.Framework;

namespace TeamCityUnitTests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int result = TeamCity.Program.Sum(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Test2()
        {
            int result = TeamCity.Program.Sum(0, 3);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void Test3()
        {
            int result = TeamCity.Program.Sum(-2, 3);
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Test4()
        {
            int result = TeamCity.Program.Sum(-3, 3);
            Assert.AreEqual(0, result);
        }
    }
}