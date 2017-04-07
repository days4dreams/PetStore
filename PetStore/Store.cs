using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Store
    {
        public string _locationName = string.Empty;
        public double _numberOfCustomers = 0;
        public string _postCode = string.Empty;
        public int _contactNumber = 0;
        //declare four variables used within the Store class

        public Store(string locationName, string postCode)
        {
            _locationName = locationName;
            _postCode = postCode;
        }
        //create a constructor for the class, which indicates that objects belonging to the Store class
        //objects must include locationName and postCode

        public string LocationName
        {
            get { return _locationName; }
            set { _locationName = value; }
        }

        public double NumberOfCustomers
        {
            get { return _numberOfCustomers; }
            set { _numberOfCustomers = value; }
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
        //declare four attributes of Customer class

        List<Customer> _customers = new List<Customer>();
        //create a list 

        public List<Customer> Customer
        {
            get { return _customers; }
            set { _customers = value; }
        }
        //declare an attribute, allowing objects of PetStore class to contain a list of Customers
    }
}
