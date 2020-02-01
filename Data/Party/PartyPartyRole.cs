using ISA3.Data.Common;

namespace ISA3.Data.Party
{
    public class PartyPartyRole : UniqueEntityData
    {
        public string PartyId { get; set; }
        public string PartyRoleId { get; set; }

        public virtual PartyData Party { get; set; }

        public virtual PartyRoleData Role { get; set; }
    }
}
