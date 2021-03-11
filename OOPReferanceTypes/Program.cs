using System;

namespace OOPReferanceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //int, decimal, float, enum, bool = Değer Tipdir.
            //int sayi1 = 10;
            //int sayi2 = 20;

            //sayi1 = sayi2;

            //sayi2 = 100;
            //Console.WriteLine("Sayı 1 :" + sayi1);
            //----------------------------------------------------
            ////arrays, class, interface = Referans Tipdir.
            //int[] sayilar1 =new int[] { 10, 20, 30 };
            //int[] sayilar2 =new int[] { 100, 200, 300 };
            //sayilar1 = sayilar2;
            //sayilar2[0] = 999;
            //Console.WriteLine("Sayilar 1 :" + sayilar1[0]);
            //----------------------------------------------------

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Soner";

            person2 = person1;
            person1.FirstName = "Cafer";

            //Console.WriteLine(person1.FirstName);


            Customer customer = new Customer();
            customer.FirstName = "Necati";
            customer.CreditCardNumber = "1234567890";
            //Console.WriteLine(customer.FirstName + customer.CreditCardNumber);

            Employee employee = new Employee();
            employee.FirstName = "Şakir";

            Person person3 = customer;
            customer.FirstName = "Ahmet";
            //Console.WriteLine(person3.FirstName);
            //Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(person3);
            personManager.Add(customer);
            personManager.Add(employee);
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    //base class : Person
    class Customer:Person
    {
        public string CreditCardNumber { get; set; }
    }
    class Employee:Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
