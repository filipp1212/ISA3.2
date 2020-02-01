using ISA3.Data.Common;
using ISA3.Data.Country;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISA3.Tests.Data.Country
{
    [TestClass]
    public class CountryTests : ClassTest<CountryData, UniqueEntityData>
    {

        [TestMethod]
        public void Id()
        {
            IsNullableProperty(() => BaseObj.Id, x => BaseObj.Id = x);
        }
        [TestMethod]
        public void Name()
        {
            IsNullableProperty(() => BaseObj.Name, x => BaseObj.Name = x);
        }
    }
}