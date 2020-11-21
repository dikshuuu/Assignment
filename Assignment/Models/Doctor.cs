using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Models
{
   public class Doctor : Person
    {
        public Doctor(string name, uint id, string email, Constants.Speciality speciality)
        {
            //Inatlizing a new doctor
            this.name = name;
            this.iD = id;
            this.email = email;
            this.type = speciality;
            this.patientAssigened = new List<uint>();
        }
        

        public List<uint> patientAssigened
        {
            get;
            set;
        }


    }
}
