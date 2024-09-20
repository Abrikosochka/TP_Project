using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {

        private Library _library;
        private string userType;

        public Form1() {
            InitializeComponent();
            _library = new Library();
            userType = string.Empty;
            _library.AddLibrarian(new Librarian("Kolesnikov", "Artem", new DateTime()));
        }

        // Обработчик для кнопки "Читатель"
        private void ReaderButton_Click(object sender, EventArgs e) {
            userType = "Reader";
        }

        // Обработчик для кнопки "Библиотекарь"
        private void LibrarianButton_Click(object sender, EventArgs e) {
            userType = "Librarian";
        }

        // Обработчик для кнопки "Войти"
        private void LoginButton_Click(object sender, EventArgs e) {
            string lastName = LastNameTextBox.Text;
            string firstName = FirstNameTextBox.Text;
            DateTime birthDate;

            // Проверка на валидность даты
            if (!DateTime.TryParse(BirthDateTextBox.Text, out birthDate)) {
                MessageBox.Show("Некорректная дата.");
                return;
            }

            // Проверка типа пользователя
            if (userType == "Reader") {
                Reader reader = _library.Readers.FirstOrDefault(r => r.LastName == lastName && r.FirstName == firstName && r.BirthDate == birthDate);

                if (reader != null) {
                    MessageBox.Show("Успешный вход как читатель.");
                    // Открываем форму для читателя
                    Form3 readerForm = new Form3(reader);
                    readerForm.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Читатель не найден.");
                }
            }
            else if (userType == "Librarian") {
                Librarian librarian = _library.Librarian;

                if (librarian.LastName == lastName && librarian.FirstName == firstName && librarian.BirthDate == birthDate) {
                    MessageBox.Show("Успешный вход как библиотекарь.");
                    // Открываем форму для библиотекаря
                    Form2 librarianForm = new Form2(librarian);
                    librarianForm.Show();
                    this.Hide();
                }
                else {
                    MessageBox.Show("Библиотекарь не найден.");
                }
            }
            else {
                MessageBox.Show("Выберите тип пользователя.");
            }
        }
    }
}
