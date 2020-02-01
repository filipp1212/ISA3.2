using System.Linq;
using System.Threading.Tasks;
using ISA3.Domain.Shipment;
using ISA3.Facade.Shipments;
using ISA3.Pages.Shipment;
using Microsoft.AspNetCore.Mvc;

namespace ISA3.GateAccountingSoft.Areas.Shipment.Pages.Incoming
{
    public class DetailsModel : IncomingShipmentsPage
    {
        public DetailsModel(IShipmentCrudRepository context) : base(context) { }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null) return NotFound();

            
            Item = IncomingShipmentViewFactory.Create(await _context.GetObject(id));

            var country = CountryList.FirstOrDefault(item => item.Id == Item.CountryId);
            Item.Country = country.Name;

            if (Item == null) return NotFound();
            return Page();
        }

        
    }

}
