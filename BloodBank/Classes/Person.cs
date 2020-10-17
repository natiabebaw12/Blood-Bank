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

        //a set method to set values for defind variables
        public void setPersonInfo(string fName, string lName, string sex, string DOB, string aboGroup, string RH, string phoneNo, string address, string date, float weight, string email = "Don't have")
        {
            this.fName = fName;
            this.lName = lName;
            this.sex = sex;
            this.DOB = DOB;
            this.aboGroup = aboGroup;
            this.RH = RH;
            this.phoneNo = phoneNo;
            this.email = email;
            this.address = address;
            this.date = date;
            this.weight = weight;
        }

        //a get method for each attribute
        public string getFName()
        {
            return fName;
        }
        public string getLName()
        {
            return lName;
        }
        public string getSex()
        {
            return sex;
        }
        public string getDOB()
        {
            return DOB;
        }
        public string getABOGroup()
        {
            return aboGroup;
        }
        public string getRH()
        {
            return RH;
        }
        public string getPhoneNo()
        {
            return phoneNo;
        }
        public string getEmail()
        {
            return email;
        }
        public string getAddress()
        {
            return address;
        }
        public string getDate()
        {
            return date;
        }
        public float getWeight()
        {
            return weight;
        }
    }
}
