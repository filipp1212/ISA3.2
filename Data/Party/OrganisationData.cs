using ISA3.Data.Common;

namespace ISA3.Data.Party
{
    public sealed class OrganizationData : UniqueEntityData
    {
        public string PartyId { get; set; }
        public PartyData Party { get; set; }
        public string OrganizationName { get; set; }
    }
}
