using ISA3.Core;
using ISA3.Data.Country;
using ISA3.Data.Shipment;
using ISA3.Domain.Shipment;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


/*TODO: uncomment interface, lisa state pattern ja eemalda duplikatsioon
 */

namespace ISA3.Infra.Shipment
{
    public class IncomingShipmentCrudRepository : IShipmentCrudRepository
    {
        public List<CountryData> CountryList { get; set; }
        private readonly GateAccountingDbContext context;
        public string SortOrder { get; set; }
        public string SearchString { get; set; }
        public int PageSize { get; set; } = 5;
        public int PageIndex { get; set; } = 1;
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }

        public IncomingShipmentCrudRepository(GateAccountingDbContext context)
        {
            this.context = context;
            CountryList = context.Countries.ToList();
        }


        public async Task<IShipment> GetObject(string id)
        {
            var shipmentData = await context.IncomingShipments.FindAsync(id);
            return new IncomingShipmentObject(shipmentData);
        }

        public async Task<IEnumerable<IShipment>> GetObjectsList()
        {
            var listData = await CreatePaged(CreateFiltered(СreateSorted()));

            HasNextPage = listData.HasNextPage;
            HasPreviousPage = listData.HasPreviousPage;

            return new IncomingShipmentObjectsList(listData);
        }

        private async Task<PaginatedList<IncomingShipmentData>> CreatePaged(IQueryable<IncomingShipmentData> dataSet)
        {

            return await PaginatedList<IncomingShipmentData>.CreateAsync(
                dataSet, PageIndex, PageSize);
        }

        private IQueryable<IncomingShipmentData> CreateFiltered(IQueryable<IncomingShipmentData> set)
        {
            if (string.IsNullOrEmpty(SearchString)) return set;
            return set.Where(s => s.BillNumber.ToString().Contains(SearchString)
                                                   || s.ArrivalDate != null && s.ArrivalDate.ToString().Contains(SearchString)
                                                   || s.EstimatedReadyDate != null && s.EstimatedReadyDate.ToString().Contains(SearchString)
                                                   || s.ShipmentReportCreationDate != null && s.ShipmentReportCreationDate.ToString().Contains(SearchString)
                                                   || s.DeliveryNumber.ToString().Contains(SearchString)
                                                   || s.Notes.Contains(SearchString)
                                                   || s.LandCadastre.Contains(SearchString));


        }

        private IQueryable<IncomingShipmentData> СreateSorted()
        {
            IQueryable<IncomingShipmentData> incomingShipments = from s in context.IncomingShipments select s;
            

            switch (SortOrder)
            {
                case "billNumber_desc":
                    incomingShipments = incomingShipments.OrderByDescending(s => s.BillNumber);
                    break;
                case "countryId_desc":
                    incomingShipments = incomingShipments.OrderByDescending(s => s.CountryId);
                    break;
                case "CountryId":
                    incomingShipments = incomingShipments.OrderBy(s => s.CountryId);
                    break;
                case "deliveryNumber_desc":
                    incomingShipments = incomingShipments.OrderByDescending(s => s.DeliveryNumber);
                    break;
                case "DeliveryNumber":
                    incomingShipments = incomingShipments.OrderBy(s => s.DeliveryNumber);
                    break;
                case "estimatedArrivalDate_desc":
                    incomingShipments = incomingShipments.OrderByDescending(s => s.ArrivalDate);
                    break;
                case "EstimatedArrivalDate":
                    incomingShipments = incomingShipments.OrderBy(s => s.ArrivalDate);
                    break;
                case "estimatedReadyDate_desc":
                    incomingShipments = incomingShipments.OrderByDescending(s => s.EstimatedReadyDate);
                    break;
                case "EstimatedReadyDate":
                    incomingShipments = incomingShipments.OrderBy(s => s.EstimatedReadyDate);
                    break;
                case "shipmentReportCreationDate_desc":
                    incomingShipments = incomingShipments.OrderByDescending(s => s.ShipmentReportCreationDate);
                    break;
                case "ShipmentReportCreationDate":
                    incomingShipments = incomingShipments.OrderBy(s => s.ShipmentReportCreationDate);
                    break;
                default:
                    incomingShipments = incomingShipments.OrderBy(s => s.BillNumber);
                    break;
            }
            return incomingShipments.AsNoTracking();
        }

        public async Task<IShipment> AddObject(IShipment shipmentObject)
        {
            var aa = shipmentObject as IncomingShipmentObject;
            Debug.Assert(aa != null, nameof(aa) + " != null");
            context.IncomingShipments.Add(aa.Data);
            await context.SaveChangesAsync();
            return shipmentObject;
        }

        public async Task UpdateObject(IShipment shipmentObject)
        {
            var aa = shipmentObject as IncomingShipmentObject; // seda asja läheb vaja, kui me muudame incomingshipmentobj -> IShipmentObjektiks
            Debug.Assert(aa != null, nameof(aa) + " != null");
            context.IncomingShipments.Update(aa.Data);
            await context.SaveChangesAsync();
        }

        public async Task DeleteObject(IShipment shipmentObject)
        {
            var aa = shipmentObject as IncomingShipmentObject;
            if (aa == null) return;
            context.IncomingShipments.Remove(aa.Data);
            await context.SaveChangesAsync();
        }

    }
}