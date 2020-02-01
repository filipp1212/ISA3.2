using ISA3.Domain.Shipment;
using ISA3.Facade.Shipments;
using ISA3.Pages.Shipment;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISA3.GateAccountingSoft.Areas.Shipment.Pages.Incoming
{
    public class EditModel : IncomingShipmentsPage
    {
        public List<SelectListItem> CountryNameSelectList { get; } = new List<SelectListItem>();
        public EditModel(IShipmentCrudRepository context) : base(context) { }
        public async Task<IActionResult> OnGetAsync(string id)
        {
            CountryList = _context.CountryList;

            foreach (var item in CountryList)
            {
                CountryNameSelectList.Add(new SelectListItem { Value = string.Format("{0}", item.Id), Text = string.Format("{0}", item.Name) });
            }

            if (id == null) return NotFound();

            Item = IncomingShipmentViewFactory.Create(await _context.GetObject(id));

            var country = CountryList.FirstOrDefault(item => item.Id == Item.CountryId);
            Item.Country = country.Name;


            if (Item == null) return NotFound();
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            await _context.UpdateObject(IncomingShipmentViewFactory.Create(Item));

            return RedirectToPage("./Index");
        }

       


    }
}
