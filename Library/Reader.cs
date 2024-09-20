using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Reader : User
    {
        public List<Books> BorrowedBooks { get; private set; }
        public List<Books> ReadBooks { get; private set; }

        public Reader(string lastName, string firstName, DateTime birthDate)
            : base(lastName, firstName, birthDate) {
            BorrowedBooks = new List<Books>();
            ReadBooks = new List<Books>();
        }

        public override void ViewBooks(List<Books> books) {
            foreach (var book in books) {
                Console.WriteLine(book.ToString());
            }
        }

        public void BorrowBook(Books book) {
            if (book.Quantity > 0) {
                book.Quantity--;
                BorrowedBooks.Add(book);
            }
            else {
                Console.WriteLine("Book is not available.");
            }
        }

        public void ReturnBook(Books book) {
            if (BorrowedBooks.Contains(book)) {
                book.Quantity++;
                BorrowedBooks.Remove(book);
                ReadBooks.Add(book);
            }
            else {
                Console.WriteLine("You don't have this book.");
            }
        }
    }
}
