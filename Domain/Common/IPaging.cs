﻿namespace ISA3.Domain.Common
{
    public interface IPaging
    {
        int PageIndex { get; set; }
        bool HasNextPage { get; set; }
        bool HasPreviousPage { get; set; }
    }
}