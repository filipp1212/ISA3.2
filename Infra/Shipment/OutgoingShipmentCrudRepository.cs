using ISA3.Data.Country;
using ISA3.Domain.Shipment;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


/*TODO: uncomment interface, lisa state pattern ja eemalda duplikatsioon
 */

namespace ISA3.Infra.Shipment
{
    public class OutgoingShipmentCrudRepository : IShipmentCrudRepository
    {
        public List<CountryData> CountryList { get; set; }
        private readonly GateAccountingDbContext context;
        public string SortOrder { get; set; }
        public string SearchString { get; set; }
        public int PageIndex { get; set; } = 1;
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }

        public OutgoingShipmentCrudRepository(GateAccountingDbContext context)
        {
            this.context = context;
            CountryList = context.Countries.ToList();
        }

        public async Task<IShipment> GetObject(string id)
        {
            var shipmentData = await context.OutgoingShipments.FindAsync(id);
            return new OutgoingShipmentObject(shipmentData);
        }


        public async Task<IEnumerable<IShipment>> GetObjectsList()
        {
            var listData = await context.OutgoingShipments.ToListAsync();
            return new OutgoingShipmentObjectsList(listData);
        }

        public async Task<IShipment> AddObject(IShipment shipmentObject)
        {
            var obj = shipmentObject as OutgoingShipmentObject;
            context.OutgoingShipments.Add(obj.Data);
            await context.SaveChangesAsync();
            return shipmentObject;
        }

        public async Task UpdateObject(IShipment shipmentObject)
        {
            var obj = shipmentObject as OutgoingShipmentObject;
            context.OutgoingShipments.Update(obj.Data);
            await context.SaveChangesAsync();
        }

        public async Task DeleteObject(IShipment shipmentObject)
        {
            var obj = shipmentObject as OutgoingShipmentObject;
            context.OutgoingShipments.Remove(obj.Data);
            await context.SaveChangesAsync();
        }




    }
}