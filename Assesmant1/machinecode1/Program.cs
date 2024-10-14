/*Patient Record System
Scenario:
Create a Patient Record System in C# that manages patient details, updates, and searches.

 
Requirements:
Implement functionality to manage:
Patient Details: Store the basic information for each patient, including Name, Age, Diagnosis, and Admission Status (whether the patient is admitted or discharged).
Search and Update: Search for a patient by name and display their details. Allow updating the patient’s diagnosis and admission status.

Functionality:
Add new patient records, including their details(Name, Age, Diagnosis, and Admission Status).
Search for a patient by name and display their details (if found).
Update a patient’s diagnosis or admission status (e.g., mark them as discharged).
List all patients currently admitted to the system.

Operations:
Searching for and updating patient details.
Displaying patient information based on the search or specific criteria (e.g., all admitted patients).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace machinecode1
{
    internal class Program
    {
        //Creating a list of dictionaries.
        static List<Dictionary<string, string>> patients = new List<Dictionary<string, string>>();
        
        //Adding patient details as mentioned in the qs.
        static void AddPatient()
        {
            var patient = new Dictionary<string, string>();

            Console.WriteLine("Enter patient name: ");
            patient.Add("name", Console.ReadLine());

            Console.WriteLine("Enter the patient age: ");
            patient.Add("age", Console.ReadLine());

            Console.WriteLine("Enter the symptom: ");
            patient.Add("symptom", Console.ReadLine());

            Console.WriteLine("Admission Status:");
            patient.Add("status", Console.ReadLine());

            //Generate a unique ID for the patient
            var id = Guid.NewGuid().ToString();
            patient.Add("id", id);

            //Add to the list patients.
            patients.Add(patient);
            Console.WriteLine($"Patient added successfully with id: {id}\n");
        }
        
        //Search a patient by their unique ID.
        static void PatientID()
        {
            Console.WriteLine("Enter the patient ID to search: ");
            string id = Console.ReadLine();
            //We use a bool fuction just like a flag.
            bool result = false;

            //Loop through each item in the list
            foreach (var patient in patients)
            {
                //if value of id key = given id from console then display information which may contain initial and final spaces.
                if (patient["id"] == id.Trim())
                {
                    Console.WriteLine("Patient Found:");
                    Console.WriteLine($"ID: {patient["id"]}");
                    Console.WriteLine($"Name: {patient["name"]}");
                    Console.WriteLine($"Age: {patient["age"]}");
                    Console.WriteLine($"Symptom: {patient["symptom"]}\n");
                    result = true; 
                    break;
                }
            }

            if (!result)
            {
                Console.WriteLine("Patient not found!\n");
            }
        }

        //Function to search patients by a given symptom or diagnosis.
        static void Symptom()
        {
            Console.WriteLine("Enter the symptom to search for: ");
            string symptom = Console.ReadLine();

            bool result = false; 

            foreach (var patient in patients)
            {
                
                if (patient["symptom"] == symptom.Trim())
                {
                    Console.WriteLine("Patient Found:");
                    Console.WriteLine($"ID: {patient["id"]}");
                    Console.WriteLine($"Name: {patient["name"]}");
                    Console.WriteLine($"Age: {patient["age"]}");
                    Console.WriteLine($"Symptom: {patient["symptom"]}\n");
                    result = true; // Set the flag to true if a patient with that symptom is found
                }
            }

            if (!result)
            {
                Console.WriteLine("No patients found with the specified symptom.\n");
            }
        }

        //List of admitted patients
        static void AdmitPatients()
        {
            Console.WriteLine("List of Admitted Patients:");
            bool result = false; 
            foreach (var patient in patients)
            {
                if (patient["status"].ToLower() == "admitted")
                {
                    Console.WriteLine($"ID: {patient["id"]}");
                    Console.WriteLine($"Name: {patient["name"]}");
                    Console.WriteLine($"Age: {patient["age"]}");
                    result = true; 
                }
            }

            if (!result)
            {
                Console.WriteLine("No admitted patients found.\n");
            }
        }
        //Updating patient status from admitted to discharged.
        static void Update()
        {
            Console.WriteLine("Enter the id");
            string id = Console.ReadLine();
            Console.WriteLine("Enter the changed diagnosis");
            string newdiag= Console.ReadLine();
            foreach(var patient in patients)
            {
                if (patient["id"] == id.Trim())
                {
                    if (patient["status"].ToLower() == "admitted")
                    {
                        patient["status"] = "discharged";
                      
                    }
                    patient["symptom"] = newdiag;
                    Console.WriteLine("Patient status and diagnosis updated.");
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Add Patient");
                Console.WriteLine("2.Search Patient by ID");
                Console.WriteLine("3.Search Patients by Symptoms/diagnosis");
                Console.WriteLine("4.Admitted Patients");
                Console.WriteLine("5.Update");
                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        AddPatient();
                        break;
                    case 2:
                        PatientID();
                        break;
                    case 3:
                        Symptom();
                        break;
                    case 4:
                        AdmitPatients();
                        break;
                    case 5:
                        Update();
                        break;
                    default:
                        Console.WriteLine("Something Entered Wrong...");
                        break;
                }
            }

        }
    }
}
