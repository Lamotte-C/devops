using DemoDevopsProjet;
using NUnit.Framework;

namespace DemoDevopsTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            int a = 2;
            int b = 4;
            calculatrice calc = new calculatrice();
            int result = calc.add(a, b);

            Assert.AreEqual(6, result);
        }
    }
}