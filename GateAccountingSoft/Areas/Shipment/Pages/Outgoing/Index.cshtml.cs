using ISA3.Data.Shipment;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISA3.Data.Country;
using ISA3.Facade.Shipments;
using ISA3.Infra.Shipment;
using ISA3.Pages.Shipment;

namespace ISA3.GateAccountingSoft.Areas.Shipment.Pages.Outgoing
{
    public class IndexModel : OutgoingShipmentsPage
    {
        public IndexModel(OutgoingShipmentCrudRepository context) : base(context) { }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString, int? pageIndex)
        {
            CurrentSort = sortOrder;

            BillNumberSort = string.IsNullOrEmpty(sortOrder) ? "billNumber_desc" : "";
            CountryIdSort = string.IsNullOrEmpty(sortOrder) ? "countryId_desc" : "";
            DeliveryNumberSort = string.IsNullOrEmpty(sortOrder) ? "deliveryNumber_desc" : "";




            EstimatedArrivalSort = sortOrder == "EstimatedArrivalDate" ? "estimatedArrivalDate_desc" : "EstimatedArrivalDate";
            EstimatedReadyDateSort = sortOrder == "EstimatedReadyDate" ? "estimatedReadyDate_desc" : "EstimatedReadyDate";
            ShipmentReportCreationDateSort = sortOrder == "shipmentReportCreationDate" ? "shipmentReportCreationDate_desc" : "shipmentReportCreationDate";

            if (searchString != null)
            {
                pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            _context.SortOrder = sortOrder;
            SearchString = CurrentFilter/*searchString*/;
            _context.SearchString = searchString;
            _context.PageIndex = pageIndex ?? 1;
            PageIndex = _context.PageIndex;

            CountryList = _context.CountryList;

            var l = await _context.GetObjectsList();
            Items = new List<OutgoingShipmentView>();

            foreach (var element in l) { Items.Add(OutgoingShipmentViewFactory.Create(element)); }
            for (int i = 0; i < Items.Count; i++)
            {
                var country = CountryList.FirstOrDefault(item => item.Id == Items[i].CountryId);
                Items[i].Country = country.Name;
            }


            HasNextPage = _context.HasNextPage;
            HasPreviousPage = _context.HasPreviousPage;

        }
        public string CurrentSort { get; set; }
        public string DeliveryNumberSort { get; private set; }
        public string BillNumberSort { get; set; }
        public string CountryIdSort { get; private set; }

        public string ShipmentReportCreationDateSort { get; set; }

        public string EstimatedReadyDateSort { get; set; }

        public string EstimatedArrivalSort { get; set; }

        public bool HasPreviousPage { get; set; }
        public bool HasNextPage { get; set; }
        public int PageIndex { get; set; }

        public string SearchString { get; set; }
        public string CurrentFilter { get; set; }

        //public List<CountryData> CountryList { get; set; }



        public IList<OutgoingShipmentData> OutgoingShipmentData { get; set; }
    }
}
