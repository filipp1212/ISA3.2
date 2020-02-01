using System;

namespace ISA3.Facade.Party
{
    public class PersonView
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CurrentWorkTitle { get; set; }
        public string Gender { get; set; }
        public int IdentityCode { get; set; }
        public string Nationality { get; set; }
        public DateTime PartnerSince { get; set; }
    }
}