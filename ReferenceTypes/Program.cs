using System.Globalization;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int,decimal,float,enum,boolean = Value Types
            int sayi1 = 10; //20
            int sayi2 = 20;    //100                       

            sayi1 = sayi2 ;

            sayi2 = 100;

            Console.WriteLine(sayi1);


            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };
            sayilar1 = sayilar2;

            sayilar2[0] = 1000;
            
            Console.WriteLine(sayilar1[0]);




            Person person1 = new Person();
            Person person2 = new Person();

            person1.FirstName = "Engin";

           
            
            person1 = person2;
            person1.FirstName = "Derin";
            Console.WriteLine(person1.FirstName);

            
            
            Customer customer = new Customer();
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "123567890";

            
            
            
            Employee employee = new Employee();
            employee.EmployeeNumber = "15";
            employee.FirstName = "Veli";

            
            
            
            Person person3 = customer; 

            customer.FirstName = "Ahmet";
            
         //   Console.WriteLine(((Customer)person3).CreditCardNumber);

            PersonManager personManager = new PersonManager();
            personManager.Add(employee);


            

        }


        class Person // kişi
        {
            public int Id { get; set; }

            public string FirstName { get; set; }

            public string LastName { get; set; }


        }
        //base class : Person
        //inheritence : Miras alma 
        class Customer : Person //Bu bir kişi ama aynı zamanda müşteri //Müşteri
        {
            public string CreditCardNumber { get; set; }
        }

        class Employee : Person // Bu ise çalışan bununda sadece Çalışan numarası var . Ama aynı zamanda bu da bir kişi
        {
            public string EmployeeNumber { get; set; }
        }

        class PersonManager
        {
            public void Add(Person person)
            {
                Console.WriteLine(person.FirstName + " Added");
            }
        }

    }
}