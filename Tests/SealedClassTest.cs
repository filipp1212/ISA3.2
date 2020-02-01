using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests
{
    [TestClass]
    public abstract class SealedClassTest<TClass, TBaseClass> : ClassTest<TClass, TBaseClass> where TClass : new()
    {
        [TestMethod]
        public void IsSealed()
        {
            Assert.IsTrue(Type.IsSealed);
        }
    }
}