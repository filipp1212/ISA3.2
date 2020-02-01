using ISA3.Data.Common;
using ISA3.Data.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Data.Party
{
    [TestClass]
    public class PartyRoleDataTests : ClassTest<PartyRoleData, UniqueEntityData>
    {
        [TestMethod]
        public void RoleType()
        {
            IsNullableProperty(() => BaseObj.RoleType, x => BaseObj.RoleType = x);
        }
    }
}