using System;

namespace ISA3.Aids
{
    public interface ILogBook
    {
        void WriteEntry(string message);

        void WriteEntry(Exception e);
    }
}