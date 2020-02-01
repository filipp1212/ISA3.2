using ISA3.Data.Common;
using ISA3.Data.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Data.Party
{
    [TestClass]
    public class OrganizationDataTests : ClassTest<OrganizationData, UniqueEntityData>
    {
        [TestMethod]
        public void PartyId()
        {
            IsNullableProperty(() => BaseObj.PartyId, x => BaseObj.PartyId = x);
        }

        [TestMethod]
        public void Party()
        {
            IsNullableProperty(() => BaseObj.Party, x => BaseObj.Party = x);
        }

        [TestMethod]
        public void OrganizationName()
        {
            IsNullableProperty(() => BaseObj.OrganizationName, x => BaseObj.OrganizationName = x);
        }
    }
}