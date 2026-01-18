using System;
using System.Collections.Generic;

namespace Zadatak02
{
    internal class BookTitleAscComparer : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            if (ReferenceEquals(x, y)) return 0;
            if (y is null) return 1;
            if (x is null) return -1;
            return string.Compare(x.Title, y.Title, StringComparison.Ordinal);
        }
    }
}