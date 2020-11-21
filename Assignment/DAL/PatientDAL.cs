using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Assignment.DAL
{
    public class PatientDAL : IPatient
    {
       public List<Patient> patients = new List<Patient>();
        public PatientDAL()
        {
           
            patients.Add(CreatePatient("Diksha", 12334, "diks@123",Constants.Speciality.cardiologist));
            patients.Add(CreatePatient("Shweta", 23456, "shweta@123",Constants.Speciality.distician));
            patients.Add(CreatePatient("Apoorva", 657889, "apoorva@123",Constants.Speciality.physician));
            patients.Add(CreatePatient("Vishaka", 123235, "vishaka@123",Constants.Speciality.psychatrist));
        }
       
        public Patient CreatePatient(string name, uint id, string email,Constants.Speciality type)
        {
            return new Patient(name, id, email,type);
        }
        public void ShowPatient(Patient patient)
        {
            Console.WriteLine("Patient Name" + patient.name);
            Console.WriteLine("Patient Id" + patient.iD);
            Console.WriteLine("Patient Email" + patient.email);
            Console.WriteLine("Patient Type" + patient.type);
        }

        public bool DeletePatient(uint id)
        {
            Patient patient= patients.Where(x => x.iD == id).ToList().FirstOrDefault();
           if (patient!=null)
            {
                patients.Remove(patient);
                return true;
            }

            return false;
        }

        public bool AddPatient(Patient patient)
        {
            if (patients != null)
            {
                if(patients.Where(x=>x.iD== patient.iD).ToList().Count > 0)
                {
                    throw new Exception("Patient with id" + patient.iD + "already exits");
                }
                patients.Add(patient);
                return true;
            }
            return false;
        }

        public List<Patient> GetPatients()
        {
            return patients;
        }

        public Patient GetPatients(uint id)
        {
            Patient patient= patients.Where(x => x.iD == id).FirstOrDefault();
            if(patient != null)
            {
                return patient;
            }
            else
            {
                throw new Exception("Patient with id" + patient.iD + "does not exits");
            }
        }

    }
}
