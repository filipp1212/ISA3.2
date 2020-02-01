using ISA3.Data.Common;

namespace ISA3.Data.ContactMechanism
{
    public class ContactMechanismData : UniqueEntityData
    {
        public string PostalAddressId { get; set; }
        public virtual PostalAddressData PostalAddress { get; set; }

        public string ElectronicAddressId { get; set; }
        public virtual ElectronicAddressData ElectronicAddress { get; set; }
        public string TelecommunicationsNumberId { get; set; }
        public virtual TelecommunicationsNumber TelecommunicationsNumber { get; set; }

    }
}
