using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.DAL
{
   public interface IDoctor
    {
        Doctor CreateDoctor(string name, uint id, string email,Constants.Speciality speciality);
        void ShowDoctor(Doctor doctor);

        bool DeleteDoctor(uint id);

        bool AddDoctor(Doctor doctor);

        bool AssignPatient(Patient patient);

    }
}
