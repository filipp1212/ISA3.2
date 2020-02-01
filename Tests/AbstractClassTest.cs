using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests
{
    [TestClass]
    public abstract class AbstractClassTest<TClass, TBaseClass> : BaseTest<TClass, TBaseClass>
    {
        [TestMethod]
        public void IsAbstract()
        {
            Assert.IsTrue(Type.IsAbstract);
        }
    }
}