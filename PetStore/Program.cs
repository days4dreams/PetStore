using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog Walter = new Dog("Walter", 3);
            Dog Pugsley = new Dog("Pugsley", 6);
            Cat Felix = new Cat("Felix", 9);

            Customer Nigel = new Customer("Nigel", "Baker");

            List<Customer> peopleStore = new List<Customer>();

            peopleStore.Add(Nigel);
            Nigel.PostCode = "NE1 1AB";
            Nigel.ContactNumber = 01912319019;

                /* THINK THIS NEEDS INHERITANCE? */

            List<Dog> customerDogs = new List<Dog>();

            customerDogs.Add(Walter);
            customerDogs.Add(Pugsley);

            List<Cat> customerCats = new List<Cat>();

            customerCats.Add(Felix);

            Nigel.NumberOfPets = (customerDogs.Count + customerCats.Count);

            Console.WriteLine(Nigel.FirstName + " has " + Nigel.NumberOfPets + " pets.");
            Console.ReadKey();

            //need to add a function so that each time a new dog is added to the list customerDogs, the double of
            // customers pets goes up



        }
}
}
