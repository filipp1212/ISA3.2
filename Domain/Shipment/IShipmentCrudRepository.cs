using ISA3.Data.Country;
using System.Collections.Generic;
using ISA3.Domain.Common;

namespace ISA3.Domain.Shipment
{
    public interface IShipmentCrudRepository : ICrudRepository<IShipment>
    {
        List<CountryData> CountryList { get; set; }
    }
}
