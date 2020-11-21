using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment.DAL
{
    public class DoctorDAL : IDoctor
    {
        List<Doctor> doctors = new List<Doctor>();
       public DoctorDAL()
        {

            doctors.Add(CreateDoctor("Abhishek", 12334, "abhi@123",Constants.Speciality.psychatrist));
            doctors.Add(CreateDoctor("Mitusha", 23456, "mit@123", Constants.Speciality.distician));
            doctors.Add(CreateDoctor("Sachin", 657889, "sachin@123", Constants.Speciality.physician));
            doctors.Add(CreateDoctor("Kusha", 123235, "kusha@123", Constants.Speciality.cardiologist));
        }
        public Doctor CreateDoctor(string name, uint id, string email, Constants.Speciality speciality)
        {
            return new Doctor(name, id, email,speciality);
        }
        public void ShowDoctor(Doctor doctor)
        {
            Console.WriteLine("Doctor Name" + doctor.name);
            Console.WriteLine("Doctor Id" + doctor.iD);
            Console.WriteLine("Doctpr Email" + doctor.email);
            Console.WriteLine("Doctpr Email" + doctor.type);
        }


        public bool DeleteDoctor(uint id)
        {
            Doctor doctor = doctors.Where(x => x.iD == id).ToList().FirstOrDefault();
            if (doctor != null)
            {
                doctors.Remove(doctor);
                return true;
            }

            return false;
        }

        public bool AddDoctor(Doctor doctor)
        {
            if (doctors != null)
            {
                if (doctors.Where(x => x.iD == doctor.iD).ToList().Count > 0)
                {
                    throw new Exception("Doctor with id" + doctor.iD + "already exits");
                }
                doctors.Add(doctor);
                return true;
            }
            return false;
        }

        public bool AssignPatient(Patient patient)
        {
           Doctor doc= doctors.Where(x => x.type == patient.type).FirstOrDefault();

            if(doc != null)
            {
                doc.patientAssigened.Add(patient.iD);
                return true;
            }

            return false;
        }
    }
}
