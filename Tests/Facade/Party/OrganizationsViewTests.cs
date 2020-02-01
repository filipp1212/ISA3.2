using ISA3.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Facade.Party
{
    [TestClass]
    public class OrganizationsViewTests : ClassTest<OrganizationsView, object>
    {
        [TestMethod]
        public void OrganizationName()
        {
            IsNullableProperty(() => BaseObj.OrganizationName, x => BaseObj.OrganizationName = x);
        }
    }
}