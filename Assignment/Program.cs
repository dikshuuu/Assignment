using Assignment.DAL;
using Assignment.Models;
using System;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            IDoctor doctordal = new DoctorDAL();
            IPatient patientdal = new PatientDAL();
            Console.WriteLine("Enter 1 For Create & save /n Eneter 2 for Delete /n Enter 3 for display patients");
            int number = Convert.ToInt32(Console.ReadLine());
            string name = string.Empty;
            string email = string.Empty;
            uint id;
            uint type;
            switch (number)
            {
                case 1:
                    //Create , Save and Assign patient to doctor
                    Console.WriteLine("enter Patient Name");
                    name = Console.ReadLine();
                    Console.WriteLine("enter Patient email");
                    email = Console.ReadLine();
                    Console.WriteLine("enter Patient type \n Cardiologist \n Physcician \n Dietician \n Psychtraist");
                    type = Convert.ToUInt16(Console.ReadLine());

                    Patient patient = patientdal.CreatePatient(name, patientdal.GetPatients().Max(x => x.iD) + 1, email, (Constants.Speciality)type);

                    if(patientdal.AddPatient(patient))
                    {
                        doctordal.AssignPatient(patient);
                    }

                    break;

                case 2:
                    //Delete patients
                    Console.WriteLine("enter the id of patient");
                    id = Convert.ToUInt16(Console.ReadLine());
                    patientdal.DeletePatient(id);
                    break;

               case 3:
                    //Show Patient
                    Console.WriteLine("Enter the id of patient");
                    id = Convert.ToUInt16(Console.ReadLine());
                    patientdal.ShowPatient(patientdal.GetPatients(id));
                    break;
            }
        }
    }
}
