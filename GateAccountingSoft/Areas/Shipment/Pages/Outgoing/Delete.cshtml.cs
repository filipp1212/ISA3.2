using ISA3.Data.Shipment;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ISA3.Facade.Shipments;
using ISA3.Infra.Shipment;
using ISA3.Pages.Shipment;

namespace ISA3.GateAccountingSoft.Areas.Shipment.Pages.Outgoing
{
    public class DeleteModel : OutgoingShipmentsPage
    {


        public DeleteModel(OutgoingShipmentCrudRepository context) : base(context) { }

        [BindProperty]
        public OutgoingShipmentData OutgoingShipmentData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null) return NotFound();

            Item = OutgoingShipmentViewFactory.Create(await _context.GetObject(id));

            if (Item == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null) return NotFound();
            var o = await _context.GetObject(id);
            await _context.DeleteObject(o);
            return RedirectToPage("./Index");
        }
    }
}
