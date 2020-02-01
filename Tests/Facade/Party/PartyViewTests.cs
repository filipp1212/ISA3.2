using ISA3.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Facade.Party
{
    [TestClass]
    public class PartyViewTests : AbstractClassTest<PartyView, object>
    {
        private class TestClass : PartyView { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            BaseObj = new TestClass();
        }
    }
}