using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISA3.Core;
using ISA3.Data.Country;
using ISA3.Data.Party;
using ISA3.Data.Shipment;
using ISA3.Domain.Common;
using ISA3.Domain.Shipment;
using Microsoft.EntityFrameworkCore;

namespace ISA3.Infra.Analysis
{
    public class AnalysisRepository : IAnalysisRepository
    {
        public List<CountryData> CountryList { get; set; }
        public List<OrganizationData> CompanyList { get; set; }
        private readonly GateAccountingDbContext _context;

        public string SearchString { get; set; }
        public string CountrySearch { get; set; }
        public string TypeSearch { get; set; }
        public string BillNrSearch { get; set; }
        public string DeliveryNrSearch { get; set; }
        public string LandCadastreSearch { get; set; }
        public string OrderIdSearch { get; set; }
        public string ShippingCompanyIdSearch { get; set; }
        public string TransportCompanyIdSearch { get; set; }



        public string SortOrder { get; set; }
        public int PageSize { get; set; } = 5;
        public int PageIndex { get; set; } = 1;
        public bool HasNextPage { get; set; }
        public bool HasPreviousPage { get; set; }

        public AnalysisRepository(GateAccountingDbContext context
        )
        {
            _context = context;
            CountryList = _context.Countries.ToList();
            CompanyList = _context.Organization.ToList();
        }

        public async Task<IEnumerable<IShipment>> GetObjectsList()
        {
            var listData = await CreatePaged(CreateFiltered(СreateSorted()));

            HasNextPage = listData.HasNextPage;
            HasPreviousPage = listData.HasPreviousPage;

            return new ShipmentObjectsList(listData);
        }

        private async Task<PaginatedList<ShipmentData>> CreatePaged(IQueryable<ShipmentData> dataSet)
        {

            return await PaginatedList<ShipmentData>.CreateAsync(
                dataSet, PageIndex, PageSize);
        }

        private IQueryable<ShipmentData> CreateFiltered(IQueryable<ShipmentData> set)
        {
            if (string.IsNullOrEmpty(SearchString) && string.IsNullOrEmpty(CountrySearch) 
                                                   && string.IsNullOrEmpty(BillNrSearch) 
                                                   && string.IsNullOrEmpty(DeliveryNrSearch) 
                                                   && string.IsNullOrEmpty(LandCadastreSearch) 
                                                   && string.IsNullOrEmpty(OrderIdSearch) 
                                                   && string.IsNullOrEmpty(ShippingCompanyIdSearch)
                                                   && string.IsNullOrEmpty(TransportCompanyIdSearch)) return set;
            if (SearchString != null) 
            {
                set = set.Where(s => s.BillNumber.ToString().Contains(SearchString)
                                     || s.ArrivalDate != null && s.ArrivalDate.ToString().Contains(SearchString)
                                     || s.EstimatedReadyDate != null && s.EstimatedReadyDate.ToString().Contains(SearchString)
                                     || s.ShipmentReportCreationDate != null && s.ShipmentReportCreationDate.ToString().Contains(SearchString)
                                     || s.DeliveryNumber.ToString().Contains(SearchString)
                                     || s.Notes.Contains(SearchString)
                                     || s.LandCadastre.Contains(SearchString));
            }
            if (CountrySearch != null) 
                set = set.Where(s => s.CountryId.Contains(CountrySearch));
            if (BillNrSearch != null) 
                set = set.Where(s => s.BillNumber.ToString().Contains(BillNrSearch));
            if (DeliveryNrSearch != null) 
                set = set.Where(s => s.DeliveryNumber.ToString().Contains(DeliveryNrSearch));
            if (LandCadastreSearch != null) 
                set = set.Where(s => s.LandCadastre.Contains(LandCadastreSearch));
            if (OrderIdSearch != null) 
                set = set.Where(s => s.OrderId.Contains(OrderIdSearch));
            if (ShippingCompanyIdSearch != null)
                set = set.Where(s => s.ShippingCompanyId.Contains(ShippingCompanyIdSearch));
            if (TransportCompanyIdSearch != null) 
                set = set.Where(s => s.TransportCompanyId.Contains(TransportCompanyIdSearch));
            
            return set;


            // enum selectbox
            //if (TypeSearch != null) // tähendab, et kui midagi on sisestatud CountrySearch'i, siis filtreeri.
            //{
            //    set = set.Where(s => (s.ShipmentType == ShipmentType.Incoming));
            //}
            //if (DeliveryNrSearch != null) // tähendab, et kui midagi on sisestatud CountrySearch'i, siis filtreeri.
            //{
            //    set = set.Where(s => s.DeliveryNumber.ToString().Contains(DeliveryNrSearch)
            //    );
            //}
            //// Todo: Think how to search by datetime
            ////if (EstimatedArrivalDateSearch != null) // tähendab, et kui midagi on sisestatud CountrySearch'i, siis filtreeri.
            ////{
            ////    set = set.Where(s => s.ArrivalDate.Contains(CountrySearch)
            ////    );
            ////}




        }

        private IQueryable<ShipmentData> СreateSorted() //
        {
            IQueryable<ShipmentData> incomingShipments = from s in _context.IncomingShipments select s;
            //IQueryable<ShipmentData> outgoingShipments = from s in _context.OutgoingShipments select s;


            //List<ShipmentData> list = incomingShipments.ToList();
            //IEnumerable<ShipmentData> list2 = outgoingShipments.ToList();
            //IEnumerable<ShipmentData> list3 = list.Concat(list2);
            //list2.ToListAsync();
            //foreach (ShipmentData data in list)
            //{
            //    list3.Append(ShipmentDataFactory.Create(data.Id,
            //        data.BillNumber,
            //        data.CountryId,
            //        data.DeliveryNumber,
            //        data.ArrivalDate ?? DateTime.MaxValue,
            //        data.EstimatedReadyDate ?? DateTime.MaxValue,
            //        data.ShipmentReportCreationDate ?? DateTime.Now,
            //        data.LandCadastre,
            //        data.OrderId,
            //        data.ShippingCompanyId,
            //        data.TransportCompanyId,
            //        data.Notes));
            //}
            //foreach (ShipmentData data in list2)
            //{
            //    list3.Append(ShipmentDataFactory.Create(data.Id,
            //        data.BillNumber,
            //        data.CountryId,
            //        data.DeliveryNumber,
            //        data.ArrivalDate ?? DateTime.MaxValue,
            //        data.EstimatedReadyDate ?? DateTime.MaxValue,
            //        data.ShipmentReportCreationDate ?? DateTime.Now,
            //        data.LandCadastre,
            //        data.OrderId,
            //        data.ShippingCompanyId,
            //        data.TransportCompanyId,
            //        data.Notes));
            //}

            //IQueryable<ShipmentData> finalquery = list3.AsQueryable();

            var shipments = incomingShipments;



            switch (SortOrder)
            {
                case "billNumber_desc":
                    shipments = shipments.OrderByDescending(s => s.BillNumber);
                    break;
                case "countryId_desc":
                    shipments = shipments.OrderByDescending(s => s.CountryId);
                    break;
                case "CountryId":
                    shipments = shipments.OrderBy(s => s.CountryId);
                    break;
                case "deliveryNumber_desc":
                    shipments = shipments.OrderByDescending(s => s.DeliveryNumber);
                    break;
                case "DeliveryNumber":
                    shipments = shipments.OrderBy(s => s.DeliveryNumber);
                    break;
                case "estimatedArrivalDate_desc":
                    shipments = shipments.OrderByDescending(s => s.ArrivalDate);
                    break;
                case "EstimatedArrivalDate":
                    shipments = shipments.OrderBy(s => s.ArrivalDate);
                    break;

                case "estimatedReadyDate_desc":
                    shipments = shipments.OrderByDescending(s => s.EstimatedReadyDate);
                    break;
                case "EstimatedReadyDate":
                    shipments = shipments.OrderBy(s => s.EstimatedReadyDate);
                    break;
                case "shipmentReportCreationDate_desc":
                    shipments = shipments.OrderByDescending(s => s.ShipmentReportCreationDate);
                    break;
                case "ShipmentReportCreationDate":
                    shipments = shipments.OrderBy(s => s.ShipmentReportCreationDate);
                    break;
                //case "shippingCompanyId_desc":
                //    incomingShipments = incomingShipments.OrderByDescending(s => s.ShippingCompanyId);
                //    break;
                //case "ShippingCompanyId":
                //    incomingShipments = incomingShipments.OrderBy(s => s.ShippingCompanyId);
                //    break;
                //case "transportCompanyId_desc":
                //    incomingShipments = incomingShipments.OrderByDescending(s => s.TransportCompanyId);
                //    break;
                //case "TransportCompanyId":
                //    incomingShipments = incomingShipments.OrderBy(s => s.TransportCompanyId);
                //    break;
                default:
                    shipments = shipments.OrderBy(s => s.BillNumber);
                    break;
            }

           
            return shipments.AsNoTracking();
        }

        public async Task<IShipment> GetObject(string id)
        {
            throw new System.NotImplementedException();
            //var shipmentData = await _context.IncomingShipments.FindAsync(id);
            //return new IncomingShipmentObject(shipmentData);
        }

        public async Task<IShipment> AddObject(IShipment shipmentObject)
        {
            throw new System.NotImplementedException();
        }

        public async Task UpdateObject(IShipment shipmentObject)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteObject(IShipment o)
        {
            throw new System.NotImplementedException();
        }

    }
}
