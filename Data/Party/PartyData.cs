using ISA3.Data.Common;
using ISA3.Data.ContactMechanism;

namespace ISA3.Data.Party
{
    public class PartyData : UniqueEntityData
    {
        public string ContactMechanismId { get; set; }
        public ContactMechanismData ContactMechanism { get; set; }
    }
}