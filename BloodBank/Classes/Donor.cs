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

        public void setDonnor(string occupation)
        {
            this.occupation = occupation;
        }

        public string getOccupation()
        {
            return occupation;
        }
    }
}
