using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodBank.Classes
{
    //patient class contains patient's attributes
    //Patient class inherit all properties and method from Person class according to their visiblity
    class Patient : Person
    {
       protected string hospitalName, doctor, history, requiredBloodUnit, hospitalPhoneNo;
       protected int patientRegdNo, noRequiredUnit;
        //set and get method to set values and to return the value of defind variables
        public string HospitalName { get => hospitalName; set => hospitalName = value; }
        public string Doctor { get => doctor; set => doctor = value; }
        public string History { get => history; set => history = value; }
        public string RequiredBloodUnit { get => requiredBloodUnit; set => requiredBloodUnit = value; }
        public string HospitalPhoneNo { get => hospitalPhoneNo; set => hospitalPhoneNo = value; }
        public int PatientRegdNo { get => patientRegdNo; set => patientRegdNo = value; }
        public int NoRequiredUnit { get => noRequiredUnit; set => noRequiredUnit = value; }
    }
}
