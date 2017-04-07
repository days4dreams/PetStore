using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Customer
    {
        public string _firstName = string.Empty;
        public string _lastName = string.Empty;
        public double _numberOfPets = 0;
        public string _postCode = string.Empty;
        public int _contactNumber = 0;
        //declare five variables used within the Customer class

        public Customer(string firstname, string lastName)
        {
            _firstName = firstname;
            _lastName = lastName;
        }
        //create a constructor for the class, which indicates that objects belonging to the Customer class
        //objects must include firstname lastname

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public double NumberOfPets
        {
            get { return _numberOfPets; }
            set { _numberOfPets = value; }
        }

        public string PostCode
        {
            get { return _postCode; }
            set { _postCode = value; }
        }

        public int ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }
        //declare five attributes of Customer class

        public List<Cat> _cats = new List<Cat>();
        //create a list for Customers Cat

        public List<Cat> Cats
        {
            get { return _cats; }
            set { _cats = value; }
        }
        //declare sixth attribute, allowing objects of Customer class to contain a list of Cats

        List<Dog> _dogs = new List<Dog>();
        //create a list for Customers Dogs

        List<Dog> Dogs
        {
            get { return _dogs; }
            set { _dogs = value; }
        }
        //declare attribute, allowing objects of Customer class to contain a list of Dogs

        /* public double CountPetsD(double petCount)
        {
            foreach (Dog customerDogs in customerDogs)
            {
                //function to add count
            }
            return Dog._numberOfPets;
        }
        //trying to write a function to ensure the _numberOfPets increases, each time a new customers pet is added

        public double CountPetsC(double petCount)
        {
            foreach (Cat _cats in Cats)
            {
                _numberOfPets = petCount++;
            }
            return _numberOfPets;
        }
        */
    }
}
