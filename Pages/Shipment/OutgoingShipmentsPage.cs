using ISA3.Facade.Shipments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using ISA3.Data.Country;
using ISA3.Infra.Shipment;

namespace ISA3.Pages.Shipment
{
    public abstract class OutgoingShipmentsPage : PageModel
    {
        public List<CountryData> CountryList { get; set; }
        protected internal readonly OutgoingShipmentCrudRepository _context;

        protected internal OutgoingShipmentsPage(OutgoingShipmentCrudRepository context)
        {
            _context = context;
            CountryList = _context.CountryList;
        } 

        [BindProperty]
        public OutgoingShipmentView Item { get; set; }
        public IList<OutgoingShipmentView> Items { get; set; }
        public string PageTitle { get; set; } = "Outgoing shipment";
        public string PageSubTitle { get; set; } = "Create";
        public string CurrentSort { get; set; } = "Current sort";
        public string CurrentFilter { get; set; } = "Current filter";
        public int PageIndex { get; set; } = 3;
        public int TotalPages { get; set; } = 10;
    }
}
