using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.DAL
{
    interface IPatient
    {
        Patient CreatePatient(string name,uint id, string email,Constants.Speciality type);
        void ShowPatient(Patient patient);

        bool DeletePatient(uint id);

        bool AddPatient(Patient patient);

        List<Patient> GetPatients();

        Patient GetPatients(uint id);


    }
}
