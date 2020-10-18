using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Classes
{
    //class defination for person - 
    //which is contain common properties(attributes) for every human entity 
    class Person
    {

        private string fName, lName, sex, DOB, aboGroup, RH, phoneNo, email, address, date;
        float weight;
        //set and get method to set values and to return the value of defind variables
        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string Sex { get => sex; set => sex = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string AboGroup { get => aboGroup; set => aboGroup = value; }
        public string RH1 { get => RH; set => RH = value; }
        public string PhoneNo { get => phoneNo; set => phoneNo = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Date { get => date; set => date = value; }
        public float Weight { get => weight; set => weight = value; }

        

    }
}
