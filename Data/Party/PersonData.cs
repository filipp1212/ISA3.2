using ISA3.Core;
using ISA3.Data.Common;
using System;

namespace ISA3.Data.Party
{
    public class PersonData : UniqueEntityData
    {
        public string PartyId { get; set; }
        public PartyData Party { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CurrentWorkTitle { get; set; }
        public Gender Gender { get; set; }
        public string IdentityCode { get; set; }
        public string NationalityId { get; set; }
        public DateTime? PartnerSince { get; set; }
        public string Comment { get; set; }
    }
}
