using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Library
    {
        public List<Books> BooksCollection { get; private set; }
        public List<Reader> Readers { get; private set; }
        public List<Librarian> Librarian { get; private set; }

        // Конструктор для инициализации библиотеки
        public Library(/*Librarian librarian*/) {
            BooksCollection = new List<Books>();
            Readers = new List<Reader>();
            //Librarian = librarian;
        }

        // Метод для добавления книги в библиотеку
        public void AddBook(Books book) {
            BooksCollection.Add(book);
        }

        // Метод для удаления книги из библиотеки
        public void RemoveBook(Books book) {
            BooksCollection.Remove(book);
        }

        // Метод для редактирования книги
        public void EditBook(int id, Books book, string newAuthor, string newTitle, int newYearOfPublication, int newQuantity) {
            Librarian[id].EditBook(book, newAuthor, newTitle, newYearOfPublication, newQuantity);
        }

        // Метод для добавления библиотекаря
        public void AddLibrarian(Librarian librarian) {
            Librarian.Add(librarian);
        }

        // Метод для добавления читателя в библиотеку
        public void AddReader(Reader reader) {
            Readers.Add(reader);
        }

        // Метод для удаления читателя из библиотеки
        public void RemoveReader(Reader reader) {
            Readers.Remove(reader);
        }

        // Метод для редактирования информации о читателе
        public void EditReader(Reader reader, string newLastName, string newFirstName, DateTime newBirthDate) {
            Librarian.EditReader(reader, newLastName, newFirstName, newBirthDate);
        }

        // Метод для выдачи книги читателю
        public void IssueBook(Books book, Reader reader) {
            Librarian.IssueBook(book, reader);
        }

        // Метод для приема книги от читателя
        public void AcceptBook(Books book, Reader reader) {
            Librarian.AcceptBook(book, reader);
        }

        // Метод для отображения всех книг
        public void DisplayBooks() {
            foreach (var book in BooksCollection) {
                Console.WriteLine(book);
            }
        }

        // Метод для отображения всех читателей
        public void DisplayReaders() {
            foreach (var reader in Readers) {
                Console.WriteLine($"LastName: {reader.LastName}, FirstName: {reader.FirstName}, BirthDate: {reader.BirthDate.ToShortDateString()}");
            }
        }
    }
}
