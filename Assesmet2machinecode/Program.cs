using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Patient and Doctor Management System Using MSSQL
Create a C# console application that interacts with an MSSQL database to manage records of patients and doctors. Focus on basic CRUD operations for two separate tables: Patient and Doctor.
1. Database Schema
Patient Table
Fields:
Id(INT, Primary Key) – Unique identifier of the patient.
Name (NVARCHAR(100)) – Name of the patient.
Age (INT) – Age of the patient.
Gender (NVARCHAR(10)) – Gender of the patient.
MedicalCondition (NVARCHAR(200)) – Medical condition of the patient.
Doctor Table
Fields:
Id(INT, Primary Key) – Unique identifier of the doctor.
Name (NVARCHAR(100)) – Name of the doctor.
Specialization (NVARCHAR(100)) – Specialization of the doctor (e.g., Cardiologist, Neurologist).
PatientId (INT, Optional) – A nullable field to assign a patient to the doctor if needed (foreign key to Patient.Id).
2. Application Requirements
Perform CRUD Operations for Patients and DoctorsImplement the following operations using ADO.NET, keeping the operations simple for each table:
Create:
Add a new patient to the Patient table.
Add a new doctor to the Doctor table.
Read:
Retrieve and display a list of all patients with their details (name, age, medical condition).
Retrieve and display a list of all doctors with their specializations.
Update:
Update a patient’s details (e.g., medical condition).
Update a doctor’s specialization.
Delete:
Delete a patient record from the Patient table.
Delete a doctor record from the Doctor table.*/

namespace Assesmet2machinecode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patientManager = new PatientManager();
            var doctorManager = new DoctorManager();
            while (true)
            {
                Console.WriteLine("\n1. Add Patient");
                Console.WriteLine("2. Get All Patients");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Remove Patient");
                Console.WriteLine("5. Add Doctor");
                Console.WriteLine("6. Get All Doctors");
                Console.WriteLine("7. Update Doctor");
                Console.WriteLine("8. Remove Doctor");
                Console.Write("Choose an option: ");
                try
                {
                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            patientManager.AddPatient();
                            break;
                        case 2:
                            patientManager.GetAllPatients();
                            break;
                        case 3:
                            patientManager.UpdatePatient();
                            break;
                        case 4:
                            patientManager.RemovePatient();
                            break;
                        case 5:
                            doctorManager.AddDoctor();
                            break;
                        case 6:
                            doctorManager.GetAllDoctors();
                            break;
                        case 7:
                            doctorManager.UpdateDoctor();
                            break;
                        case 8:
                            doctorManager.RemoveDoctor();
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
        }
    }
}