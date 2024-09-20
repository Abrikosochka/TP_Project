using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Librarian : User
    {
        public Librarian(string lastName, string firstName, DateTime birthDate)
            : base(lastName, firstName, birthDate) {
        }

        public override void ViewBooks(List<Books> books) {
            foreach (var book in books) {
                Console.WriteLine(book);
            }
        }

        public void AddBook(List<Books> books, Books book) {
            books.Add(book);
        }

        public void EditBook(Books book, string newAuthor, string newTitle, int newYearOfPublication, int newQuantity) {
            book.Author = newAuthor;
            book.Title = newTitle;
            book.YearOfPublication = newYearOfPublication;
            book.Quantity = newQuantity;
        }

        public void RemoveBook(List<Books> books, Books book) {
            books.Remove(book);
        }

        public void AddReader(List<Reader> readers, Reader reader) {
            readers.Add(reader);
        }

        public void EditReader(Reader reader, string newLastName, string newFirstName, DateTime newBirthDate) {
            reader.LastName = newLastName;
            reader.FirstName = newFirstName;
            reader.BirthDate = newBirthDate;
        }

        public void RemoveReader(List<Reader> readers, Reader reader) {
            readers.Remove(reader);
        }

        public void IssueBook(Books book, Reader reader) {
            if (book.Quantity > 0) {
                book.Quantity--;
                reader.BorrowedBooks.Add(book);
            }
            else {
                Console.WriteLine("Book is not available.");
            }
        }

        public void AcceptBook(Books book, Reader reader) {
            if (reader.BorrowedBooks.Contains(book)) {
                book.Quantity++;
                reader.BorrowedBooks.Remove(book);
                reader.ReadBooks.Add(book);
            }
            else {
                Console.WriteLine("This book is not borrowed by the reader.");
            }
        }
    }
}
