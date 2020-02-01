using ISA3.Data.Common;
using ISA3.Data.Party;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Data.Party
{
    [TestClass]
    public class PersonDataTests : ClassTest<PersonData, UniqueEntityData>
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
        public void Gender() //sometimes works, sometimes not
        {
            IsProperty(() => BaseObj.Gender, x => BaseObj.Gender = x);
        }

        [TestMethod]
        public void IdentityCode()
        {
            IsNullableProperty(() => BaseObj.IdentityCode, x => BaseObj.IdentityCode = x);
        }

        [TestMethod]
        public void NationalityId()
        {
            IsNullableProperty(() => BaseObj.NationalityId, x => BaseObj.NationalityId = x);
        }

        [TestMethod]
        public void PartnerSince()
        {
            IsNullableProperty(() => BaseObj.PartnerSince, x => BaseObj.PartnerSince = x);
        }

        [TestMethod]
        public void Comment()
        {
            IsNullableProperty(() => BaseObj.Comment, x => BaseObj.Comment = x);
        }
    }
}