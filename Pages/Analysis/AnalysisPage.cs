using System.Collections.Generic;
using ISA3.Data.Country;
using ISA3.Data.Party;
using ISA3.Domain.Common;
using ISA3.Facade.Shipments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ISA3.Pages.Analysis
{
    public class AnalysisPage : PageModel
    {
        protected internal readonly IAnalysisRepository _analysisContext;
        public List<CountryData> CountryList { get; set; }
        public List<OrganizationData> CompanyList { get; set; }

        public AnalysisPage(IAnalysisRepository analysisContext)
        {
            //var ss = new IncomingShipmentData();
            //var aa = new ShipmentObject(ss);

            _analysisContext = analysisContext;
            CountryList = analysisContext.CountryList;
            CompanyList = analysisContext.CompanyList;
        }

        [BindProperty]
        public ShipmentView Item { get; set; }

        public IList<ShipmentView> Items { get; set; }
        public string PageTitle { get; set; } = "Analysis";
        public string CurrentSort { get; set; } = "Current sort";
        public string CurrentFilter { get; set; } = "Current filter";
        public int PageIndex { get; set; } = 3;
        public int TotalPages { get; set; } = 10;

    }
}