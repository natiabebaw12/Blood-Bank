using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Classes
{
    //Donor class contains donor's attributes
    //Donor class inherit all properties and method from Person class according to their visiblity
    class Donor : Person 
    {
        
        private string occupation;
        //set and get method to set values and to return the value of defind variables
        public string Occupation { 
            get => occupation; 
            set => occupation = value;
        }



    }
}
