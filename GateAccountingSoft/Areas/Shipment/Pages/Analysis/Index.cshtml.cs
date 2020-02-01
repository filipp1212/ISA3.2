using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISA3.Domain.Common;
using ISA3.Facade.Shipments;
using ISA3.Pages.Analysis;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ISA3.GateAccountingSoft.Areas.Shipment.Pages.Analysis
{
    public class IndexModel : AnalysisPage
    {
        public IndexModel(IAnalysisRepository analysisContext) : base(
            analysisContext)
        {

        }

        public override Task OnPageHandlerSelectionAsync(PageHandlerSelectedContext context)
        {
            return base.OnPageHandlerSelectionAsync(context);
        }

        public async Task OnGetAsync(string sortOrder,
            string currentFilter, string searchString,
            string countrySearch, string typeSearch,
            string billNrSearch, string deliveryNrSearch,
            string landCadastreSearch, string orderIdSearch,
            string shippingCompanyIdSearch, string transportCompanyIdSearch,
            int? pageIndex)
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

            _analysisContext.SortOrder = sortOrder;
            SearchString = CurrentFilter; /*salvestatakse filter, et kaduma ei läheks*/


            _analysisContext.SearchString = searchString;
            _analysisContext.CountrySearch = countrySearch;
            _analysisContext.TypeSearch = typeSearch;
            _analysisContext.BillNrSearch = billNrSearch;
            _analysisContext.DeliveryNrSearch = deliveryNrSearch;
            _analysisContext.LandCadastreSearch = landCadastreSearch;
            _analysisContext.OrderIdSearch = orderIdSearch;
            _analysisContext.ShippingCompanyIdSearch = shippingCompanyIdSearch;
            _analysisContext.TransportCompanyIdSearch = transportCompanyIdSearch;



            _analysisContext.PageIndex = pageIndex ?? 1;
            PageIndex = _analysisContext.PageIndex;

            var l = await _analysisContext.GetObjectsList();
            Items = new List<ShipmentView>();

            foreach (var element in l)
            {
                try
                {
                    Items.Add(ShipmentViewFactory.Create(element));
                }
                catch (NullReferenceException)
                {
                    // Catches empty thing that the analysiscontext somehow get, but we don't want it
                }
            }
            for (int i = 0; i < Items.Count; i++)
            {
                var country = CountryList.FirstOrDefault(item => item.Id == Items[i].CountryId);
                Items[i].Country = country.Name;
                var shippingCompany = CompanyList.FirstOrDefault(item => item.PartyId == Items[i].ShippingCompanyId);
                Items[i].ShippingCompany = shippingCompany.OrganizationName;
                var transportCompany = CompanyList.FirstOrDefault(item => item.PartyId == Items[i].TransportCompanyId);
                Items[i].TransportCompany = transportCompany.OrganizationName;
            }

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

        public string TypeSearch { get; set; }
        public string BillNrSearch { get; set; }
        public string DeliveryNrSearch { get; set; }
        public string LandCadastreSearch { get; set; }
        public string OrderIdSearch { get; set; }
        public string ShippingCompanyIdSearch { get; set; }
        public string TransportCompanyIdSearch { get; set; }
        public string SearchString { get; set; }
        public string CurrentFilter { get; set; }
        // public string CurrentCountryFilter { get; set; }
    }
}
