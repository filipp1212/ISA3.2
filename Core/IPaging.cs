namespace ISA3.Core
{
    public interface IPaging
    {
        int PageIndex { get; set; }
        bool HasNextPage { get; set; }
        bool HasPreviousPage { get; set; }
    }
}