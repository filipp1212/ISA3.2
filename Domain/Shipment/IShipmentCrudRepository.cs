using ISA3.Core;
using ISA3.Data.Country;
using System.Collections.Generic;

namespace ISA3.Domain.Shipment
{
    public interface IShipmentCrudRepository : ICrudRepository<IShipment>
    {
        List<CountryData> CountryList { get; set; }
    }
}
