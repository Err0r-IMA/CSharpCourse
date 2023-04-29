namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id=1,FirstName="Engin",LastName = "Demiroğ",City = "Ankara"};
            
            Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara");

            
        }


        class Customer
        {
            //Default Constructor
            public Customer(int id,string firstname,string lastname,string city)
            {
                Console.WriteLine("Yapıcı blok çalıştı");
            }
            public int Id { get; set; }
            
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string City { get; set; }

        }   
    }
}