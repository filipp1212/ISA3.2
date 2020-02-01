using System.Collections.Generic;
using ISA3.Core;
using ISA3.Data.Country;
using ISA3.Data.Party;
using ISA3.Domain.Shipment;

namespace ISA3.Domain.Common
{
    public interface IAnalysisRepository : ICrudMethods<IShipment>, ISorting, ISearching, IPaging
    {
        List<CountryData> CountryList { get; set; }
        List<OrganizationData> CompanyList { get; set; }
        string CountrySearch { get; set; }
        string TypeSearch { get; set; }
        string BillNrSearch { get; set; }
        string DeliveryNrSearch { get; set; }
        string LandCadastreSearch { get; set; }
        string OrderIdSearch { get; set; }
        string ShippingCompanyIdSearch { get; set; }
        string TransportCompanyIdSearch { get; set; }
    }
}