namespace ISA3.Domain.Common
{
    public interface ICrudRepository<TObject> : ICrudMethods<TObject>, IPaging, ISorting, ISearching
    {


    }
}