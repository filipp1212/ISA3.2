using System.Collections.Generic;
using ISA3.Data.Shipment;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using ISA3.Data.Country;
using ISA3.Facade.Shipments;
using ISA3.Infra.Shipment;
using ISA3.Pages.Shipment;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ISA3.GateAccountingSoft.Areas.Shipment.Pages.Outgoing
{
    public class EditModel : OutgoingShipmentsPage
    {
        //public List<CountryData> CountryList { get; set; }
        public List<SelectListItem> CountryNameSelectList { get; } = new List<SelectListItem>();
        public EditModel(OutgoingShipmentCrudRepository context) : base(context) { }

        [BindProperty]
        public OutgoingShipmentData OutgoingShipmentData { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            CountryList = _context.CountryList;

            foreach (var item in CountryList)
            {
                CountryNameSelectList.Add(new SelectListItem { Value = string.Format("{0}", item.Id), Text = string.Format("{0}", item.Name) });
            }


            if (id == null) return NotFound();

            Item = OutgoingShipmentViewFactory.Create(await _context.GetObject(id));

            var country = CountryList.FirstOrDefault(item => item.Id == Item.CountryId);
            Item.Country = country.Name;

            //IncomingShipmentView = await _context.IncomingShipmentViews.FirstOrDefaultAsync(m => m.Id == id);

            if (Item == null) return NotFound();
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            await _context.UpdateObject(OutgoingShipmentViewFactory.Create(Item));

            return RedirectToPage("./Index");
        }

    }
}
