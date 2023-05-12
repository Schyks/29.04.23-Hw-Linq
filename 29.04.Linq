using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29._04._23_HW_Linq
{
    public class Firm
    {
        public string name { get;set;}
        public DateTime date { get;set;}
        public string profile { get;set;}
        public string directorName { get;set;}
        public int countOfEmployees { get;set;}
        public string address { get;set;}
        public Firm(string name, DateTime date, string profile, string directorName, int countOfEmployees, string address)
        {  
            this.name = name;
            this.date = date;   
            this.profile = profile;
            this.directorName = directorName;
            this.countOfEmployees = countOfEmployees;
            this.address = address;
        }
        public void Show()
        { Console.WriteLine($"Назва: {name}\nДата заснування: {date}\nПрофiль бiзнесу: {profile}\nПIБ директора: {directorName}\nКiлькiсть працiвникiв: {countOfEmployees}\nАдреса: {address}\n"); }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Firm[] firms = { new Firm("ABC Inc.", new DateTime(2021, 1, 1), "Software Development", "John Smith", 50, "Kyiv, 123 Main St."),
            new Firm("XYZ Corp.", new DateTime(2020, 5, 1), "Marketing and Advertising", "Jane Doe", 25, "London, 456 Maple Ave."),
            new Firm("Acme Co.", new DateTime(2019, 3, 1), "Manufacturing", "Bob Johnson", 100, "789 Oak St."),
            new Firm("GHI LLC", new DateTime(2022, 2, 1), "Consulting", "Sarah Lee", 10, "101 Elm St."),
            new Firm("123 Enterprises", new DateTime(2020, 4, 1), "E-commerce", "Alex Chen", 75, "202 Pine St."),
            new Firm("Big Ideas Ltd.", new DateTime(2021, 7, 1), "Business Consulting", "Emily Kim", 20, "London, 303 Cedar St."),
            new Firm("New Horizons Inc.", new DateTime(2018, 6, 1), "Education and Training", "David White", 200, "Kyiv, 404 Birch Ave."),
            new Firm("Innovative Solutions LLC", new DateTime(2020, 8, 1), "IT Services", "Maria Rodriguez", 30, "505 Spruce St."),
            new Firm("White Global Ventures Co.", new DateTime(2021, 9, 1), "International Business", "Kevin Black", 15, "606 Oak Ave."),
            new Firm("Swift Enterprises", new DateTime(2019, 11, 1), "Logistics and Transportation", "Samantha Lee", 50, "707 Maple St."),
            new Firm("Proactive Strategies Inc.", new DateTime(2022, 3, 1), "Management Consulting", "Mark Johnson", 5, "London, 808 Pine Ave."),
            new Firm("Elite Solutions LLC", new DateTime(2021, 6, 1), "Marketing and Sales", "Linda Kim", 40, "909 Cedar St."),
            new Firm("NextGen Innovations Co.", new DateTime(2020, 12, 1), "Technology and Innovation", "Michael Lee", 75, "Kyiv, 1010 Birch Ave."),
            new Firm("Food Consulting", new DateTime(2018, 10, 1), "Business Intelligence", "Jessica Chen", 20, "Paris, 1111 Spruce St."),
            new Firm("True North Ventures", new DateTime(2022, 4, 1), "Venture Capital", "Adam Johnson", 10, "1212 Oak Ave.")};

            Console.WriteLine($"****************************************\nОтримати iнформацiю про всi фiрми.\n");
            var query = firms;
            foreach (var firm in query)
            firm.Show();
           
            Console.WriteLine($"****************************************\nОтримати фiрми, якi мають у назвi слово «Food».\n");
            var query1 = firms.Where(x => x.name.Contains("Food"));
            foreach (var firm in query1)
                firm.Show();

            Console.WriteLine($"****************************************\nОтримати фiрми, якi працюють у галузi маркетингу.\n");
            var query2 = firms.Where(x => x.profile.Contains("Marketing"));
            foreach (var firm in query2)
                firm.Show();

            Console.WriteLine($"****************************************\nОтримати фiрми, якi працюють у галузi маркетингу або IT.\n");
            var query3 = firms.Where(x => x.profile.Contains("Marketing") || x.profile.Contains("IT"));
            foreach (var firm in query3)
                firm.Show();

            Console.WriteLine($"****************************************\nОтримати фiрми з кiлькiстю працiвникiв бiльшою, нiж 100.\n");
            var query4 = firms.Where(x => x.countOfEmployees>100);
            foreach (var firm in query4)
                firm.Show();

            Console.WriteLine($"****************************************\nОтримати фiрми з кiлькiстю працiвникiв у дiапазонi вiд 100 до 300.\n");
            var query5 = firms.Where(x => x.countOfEmployees >= 100 && x.countOfEmployees <= 300);
            foreach (var firm in query5)
                firm.Show();

            Console.WriteLine($"****************************************\nОтримати фiрми, якi знаходяться в Лондонi.\n");
            var query6 = from firm in firms where firm.address.Contains("London") select firm;
            foreach (var firm in query6)
                firm.Show();

            Console.WriteLine($"****************************************\nОтримати фiрми, в яких прiзвище директора White.\n");
            var query7 = from firm in firms where firm.directorName.Contains("White") select firm;
            foreach (var firm in query7)
                firm.Show();

            Console.WriteLine($"****************************************\nОтримати фiрми, якi заснованi бiльше двох рокiв тому.\n");
            var query8 = from firm in firms where ((DateTime.Now - firm.date).TotalDays / 365)>2 select firm;
            foreach (var firm in query8)
                firm.Show();

            Console.WriteLine($"****************************************\nОтримати фiрми з дня заснування яких минуло 123 дні.\n");
            var query9 = from firm in firms where (DateTime.Now - firm.date).TotalDays > 123 select firm;
            foreach (var firm in query9)
                firm.Show();

            Console.WriteLine($"****************************************\nОтримати фiрми, в яких прiзвище директора Black i мають у назвi фiрми слово «White».\n");
            var query10 = from firm in firms where firm.directorName.Contains("Black") && firm.name.Contains("White") select firm;
            foreach (var firm in query10)
                firm.Show();
        }
        }
    }
    

