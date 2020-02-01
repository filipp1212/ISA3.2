using ISA3.Data.Common;
using ISA3.Data.Country;

namespace ISA3.Data.ContactMechanism
{
    public class PostalAddressData : UniqueEntityData
    {
        public string Street { get; set; }
        public string Building { get; set; }
        public string Apartment { get; set; }
        public string Zip { get; set; }
        public string CountryId { get; set; }
        public virtual CountryData Country { get; set; }
        public string City { get; set; }
    }
}