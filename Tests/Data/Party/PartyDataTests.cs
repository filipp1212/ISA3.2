using ISA3.Data.Common;
using ISA3.Data.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Data.Party
{
    [TestClass]
    public class PartyDataTests : ClassTest<PartyData, UniqueEntityData>
    {
        [TestMethod]
        public void ContactMechanismId()
        {
            IsNullableProperty(() => BaseObj.ContactMechanismId, x => BaseObj.ContactMechanismId = x);
        }

        [TestMethod]
        public void ContactMechanism()
        {
            IsNullableProperty(() => BaseObj.ContactMechanism, x => BaseObj.ContactMechanism = x);
        }
    }
}