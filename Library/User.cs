using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public abstract class User {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Id { get; set; }

        private string filePath = "users.txt";

        public User(string lastName, string firstName, DateTime birthDate) {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
        }

        public abstract void ViewBooks(List<Books> books);

        public void AddUser(int Id, string firstName, string lastName, string role, DateTime birthDate) {

            string userInfo = $"Id: {Id}, FirstName: {firstName}, LastName: {lastName}, Role: {role}, BirthDate: {birthDate} \n";

            // Записываем строку в файл (используем Append чтобы не перезаписывать файл)
            using (StreamWriter sw = new StreamWriter(filePath, true)) {
                sw.WriteLine(userInfo);
            }
        }

        private int ReadUsersAndCountLines() {
            // Проверяем, существует ли файл
            if (File.Exists(filePath)) {
                // Читаем все строки файла
                string[] users = File.ReadAllLines(filePath);
                // Выводим количество строк
                return users.Length;
            }
            else {
                return -1;
            }
        }
    }
}
