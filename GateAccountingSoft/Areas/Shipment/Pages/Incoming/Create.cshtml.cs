using ISA3.Domain.Shipment;
using ISA3.Facade.Shipments;
using ISA3.Pages.Shipment;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ISA3.GateAccountingSoft.Areas.Shipment.Pages.Incoming
{
    public class CreateModel : IncomingShipmentsPage
    {
        public CreateModel(IShipmentCrudRepository context) : base(context) { }

        public IActionResult OnGet() => Page();

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            await _context.AddObject(IncomingShipmentViewFactory.Create(Item));
            return RedirectToPage("./Index");
        }

    }
}
