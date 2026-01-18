using System;
using System.Linq;

namespace Zadatak02
{
    internal class Book :
        IComparable<Book>,
        ICloneable,
        IEquatable<Book>,
        IFormattable
    {
        private static int _counter;

        private readonly int _id;
        private string _isbn;

        // -------------------------------
        // Constructor
        // -------------------------------
        public Book(string title, string author, string isbn)
        {
            _id = ++_counter;

            Title  = title ?? throw new ArgumentNullException(nameof(title));
            Author = author ?? throw new ArgumentNullException(nameof(author));
            Isbn   = isbn ?? throw new ArgumentNullException(nameof(isbn));
        }

        // -------------------------------
        // Properties
        // -------------------------------
        public int Id => _id;

        public string Title { get; set; }

        public string Author { get; set; }

        public string Isbn
        {
            get => _isbn;
            set
            {
                if (value == null)
                    throw new ArgumentNullException(nameof(value));

                if (value.Length != 13 || !value.All(char.IsDigit))
                    throw new ArgumentException("ISBN must contain exactly 13 digits.", nameof(Isbn));

                _isbn = value;
            }
        }

        // -------------------------------
        // ToString
        // -------------------------------
        public override string ToString()
        {
            return $"{Id}\t{Title}\t{Author}\t{Isbn}";

        }

        public string ToString(string format, IFormatProvider formatProvider)
        {
            if (string.IsNullOrEmpty(format))
                return ToString();

            switch (format)
            {
                case "I":
                    return Isbn;

                case "F":
                    return $"{Title} by {Author} (ISBN: {Isbn})";

                default:
                    return ToString();
            }
        }

        // -------------------------------
        // Comparison
        // -------------------------------
        public int CompareTo(Book other)
        {
            return other == null ? 1 : string.CompareOrdinal(Isbn, other.Isbn);
        }

        // -------------------------------
        // Equality
        // -------------------------------
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
                return true;

            var other = obj as Book;
            return other != null && Equals(other);
        }

        public bool Equals(Book other)
        {
            return other != null && string.Equals(Isbn, other.Isbn, StringComparison.Ordinal);
        }

        public override int GetHashCode()
        {
            return StringComparer.Ordinal.GetHashCode(Isbn);
        }

        // -------------------------------
        // Clone
        // -------------------------------
        public object Clone()
        {
            return new Book(Title, Author, Isbn);
        }
    }
}
