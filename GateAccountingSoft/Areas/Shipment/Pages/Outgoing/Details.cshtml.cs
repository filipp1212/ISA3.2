using ISA3.Data.Shipment;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ISA3.Facade.Shipments;
using ISA3.Infra.Shipment;
using ISA3.Pages.Shipment;

namespace ISA3.GateAccountingSoft.Areas.Shipment.Pages.Outgoing
{
    public class DetailsModel : OutgoingShipmentsPage
    {


        public DetailsModel(OutgoingShipmentCrudRepository context) : base(context) { }

        public OutgoingShipmentData OutgoingShipmentData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null) return NotFound();

            Item = OutgoingShipmentViewFactory.Create(await _context.GetObject(id));

            if (Item == null) return NotFound();
            return Page();
        }
    }
}
