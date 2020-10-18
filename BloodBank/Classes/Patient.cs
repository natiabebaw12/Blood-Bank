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
        string hospitalName, doctor, history, requiredBloodUnit, hospitalPhoneNo;
        int patientRegdNo, noRequiredUnit;

        public void setPatient(string hospitalName, string doctor, string history, string requiredBloodUnit, string hospitalPhoneNo, int patientRegdNo, int noRequiredUnit)
        {
            this.hospitalName = hospitalName;
            this.doctor = doctor;
            this.history = history;
            this.requiredBloodUnit = requiredBloodUnit;
            this.hospitalPhoneNo = hospitalPhoneNo;
            this.patientRegdNo = patientRegdNo;
            this.noRequiredUnit = noRequiredUnit;
        }

        public string getHospitalName()
        {
            return hospitalName;
        }
        public string getDoctor()
        {
            return doctor;
        }
        public string getHistory()
        {
            return history;
        }
        public string getRequiredBloodUnit()
        {
            return requiredBloodUnit;
        }
        public string getHospitalPhoneNo()
        {
            return hospitalPhoneNo;
        }
        public int getPatientRegdNo()
        {
            return patientRegdNo;
        }
        public int getNoRequiredUnit()
        {
            return noRequiredUnit;
        }
    }
}
