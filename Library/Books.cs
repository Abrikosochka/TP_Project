using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Books
    {
        // Свойства для хранения информации о книге
        public string Author { get; set; }
        public string Title { get; set; }
        public int YearOfPublication { get; set; }
        public int Quantity { get; set; } // Количество доступных экземпляров книги

        // Конструктор для инициализации книги
        public Books(string author, string title, int yearOfPublication, int quantity) {
            Author = author;
            Title = title;
            YearOfPublication = yearOfPublication;
            Quantity = quantity;
        }

        // Метод для вывода информации о книге
        public override string ToString() {
            return $"Author: {Author}, Title: {Title}, Year of Publication: {YearOfPublication}, Quantity: {Quantity}";
        }
    }
}
