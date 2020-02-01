using System.Collections.Generic;
using System.Threading.Tasks;

namespace ISA3.Core
{
    public interface ICrudMethods<TObject>
    {
        Task<TObject> GetObject(string id);
        Task<IEnumerable<TObject>> GetObjectsList();
        Task<TObject> AddObject(TObject shipmentObject);
        Task UpdateObject(TObject shipmentObject);
        Task DeleteObject(TObject o);
    }
}