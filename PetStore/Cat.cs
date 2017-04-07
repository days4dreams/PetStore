using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStore
{
    public class Cat
    {

        public Cat(string name, int age)
        {
            this.catName = name;
            this.catAge = age;
        }
        //constructor for the Cat class. All Cats must have a name and age

        public int catAge { get; set; }
        public string catName { get; set; }
        public bool IsMicrochipped { get; set; }
        //three attributes of the Cat class 


    }
}
