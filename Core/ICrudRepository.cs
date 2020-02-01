namespace ISA3.Core
{
    public interface ICrudRepository<TObject> : ICrudMethods<TObject>, IPaging, ISorting, ISearching
    {


    }
}