using System.Collections.Generic;
using ISA3.Data.Country;
using ISA3.Domain.Shipment;
using ISA3.Facade.Shipments;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ISA3.Pages.Shipment
{
    public abstract class IncomingShipmentsPage : PageModel
    {
        public List<CountryData> CountryList { get; set; }

        protected internal readonly IShipmentCrudRepository _context;


        protected internal IncomingShipmentsPage(IShipmentCrudRepository context) { 
            _context = context;
            CountryList = _context.CountryList;
        }

        [BindProperty]
        public IncomingShipmentView Item { get; set; }
        public IList<IncomingShipmentView> Items { get; set; }
    }
}
