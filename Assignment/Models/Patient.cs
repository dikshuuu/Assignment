using Assignment.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Models
{
    public class Patient : Person
    {
       public Patient(string name, uint id, string email,Constants.Speciality type)
        {
            this.name = name;
            this.iD = id;
            this.email = email;
            this.type = type;
        }


    }
}
