using ISA3.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Data.Common
{
    [TestClass]
    public class UniqueEntityDataTests : AbstractClassTest<UniqueEntityData, PeriodData>
    {
        private class TestClass : UniqueEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            BaseObj = new TestClass();
        }
        [TestMethod]
        public void Id()
        {
            IsNullableProperty(() => BaseObj.Id, x => BaseObj.Id = x);
        }
    }
}