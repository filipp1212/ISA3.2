using ISA3.Data.Common;
using ISA3.Data.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Data.Party
{
    [TestClass]
    public class PartyPartyRoleTests : ClassTest<PartyPartyRole, UniqueEntityData>
    {
        [TestMethod]
        public void PartyId()
        {
            IsNullableProperty(() => BaseObj.PartyId, x => BaseObj.PartyId = x);
        }

        [TestMethod]
        public void PartyRoleId()
        {
            IsNullableProperty(() => BaseObj.PartyRoleId, x => BaseObj.PartyRoleId = x);
        }

        [TestMethod]
        public void Party()
        {
            IsNullableProperty(() => BaseObj.Party, x => BaseObj.Party = x);
        }

        [TestMethod]
        public void Role()
        {
            IsNullableProperty(() => BaseObj.Role, x => BaseObj.Role = x);
        }
    }
}