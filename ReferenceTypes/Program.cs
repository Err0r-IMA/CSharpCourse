using System.Globalization;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int sayi1 = 10;
            //int sayi2 = 100;

            //sayi1 = sayi2;

            //sayi2 = 100;

            //Console.WriteLine("Sayı 1 : " + sayi1);



            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Eng";

            person2 = person1;
            person1.FirstName = "Derinn";
          Console.WriteLine(person1.FirstName);

            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "123567890";
            
            Employee employee = new Employee();

            employee.FirstName = "Veli";

            Person person3 = customer;

           customer.FirstName = "Ahmet";

            Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager(); 
            personManager.Add(customer);



        }


        class Person // kişi
        {
            public int Id { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            
        }
        //base class : Person
        //inheritence : Miras alma 
        class Customer:Person //Bu bir kişi ama aynı zamanda müşteri //Müşteri
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee:Person // Bu ise çalışan bununda sadece Çalışan numarası var . Ama aynı zamanda bu da bir kişi
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
}