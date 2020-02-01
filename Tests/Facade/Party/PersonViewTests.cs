using ISA3.Facade.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Facade.Party
{
    [TestClass]
    public class PersonViewTests : ClassTest<PersonView, object>
    {
        [TestMethod]
        public void FirstName()
        {
            IsNullableProperty(() => BaseObj.FirstName, x => BaseObj.FirstName = x);
        }

        [TestMethod]
        public void LastName()
        {
            IsNullableProperty(() => BaseObj.LastName, x => BaseObj.LastName = x);
        }

        [TestMethod]
        public void CurrentWorkTitle()
        {
            IsNullableProperty(() => BaseObj.CurrentWorkTitle, x => BaseObj.CurrentWorkTitle = x);
        }

        [TestMethod]
        public void Gender()
        {
            IsNullableProperty(() => BaseObj.Gender, x => BaseObj.Gender = x);
        }

        [TestMethod]
        public void IdentityCode()
        {
            IsProperty(() => BaseObj.IdentityCode, x => BaseObj.IdentityCode = x);
        }

        [TestMethod]
        public void Nationality()
        {
            IsNullableProperty(() => BaseObj.Nationality, x => BaseObj.Nationality = x);
        }

        [TestMethod]
        public void PartnerSince()
        {
            IsProperty(() => BaseObj.PartnerSince, x => BaseObj.PartnerSince = x);
        }
    }
}