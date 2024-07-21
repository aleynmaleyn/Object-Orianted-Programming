using System;
namespace btk_interface1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager manager = new PersonManager();

            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Aleyna",
                LastName = "YILMAZ",
                Address = "Elazığ"
            };

            Student student = new Student
            {
                Id = 2,
                FirstName = "Zehra",
                LastName = "Kurt",
                Departmant = "Computer Engineering"
            };
            Worker worker = new Worker
            {
                Id = 3,
                FirstName = "Emir",
                LastName = "Kurt",
                Departmant = "Computer Engineering"
            };

            manager.Add(customer);
            manager.Add(student);
            manager.Add(worker);


            Console.ReadLine();
        }

        interface IPerson //soyut nesneler oluştururuz.
        /*burada oluşturulanların tamamı ,bunu kullanan tüm sınıflar
        tarafından implemente edilmek zorundadır.*/
        {
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

        }
        class Customer : IPerson //IPerson'da tanımlanmış her şeyi bu sınıfta kullanabilirsin
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; } //müşteriye ait ayrıca bir özellik

        }
        class Student : IPerson //IPerson'da tanımlanmış her şeyi bu sınıfta kullanabilirsin
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant { get; set; }//öğrenciye ait ayrıca bir özellik

        }
        class Worker : IPerson //IPerson'da tanımlanmış her şeyi bu sınıfta kullanabilirsin
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Departmant{ get; set; } 

        }
        class PersonManager
        {
           // public void Add(Customer customer)//müşteri sınıfından müşteri nesnesi oluşturduk.
           public void Add(IPerson person)//IPerson'dan person nesnesi oluşturduk.
            {
                Console.Write(person.FirstName+" ");
                Console.WriteLine(person.LastName);
         
            }
        }
    }
}