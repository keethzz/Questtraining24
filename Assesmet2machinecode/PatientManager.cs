using Assesmet2machinecode.Entities;
using Assesmet2machinecode.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesmet2machinecode
{
    internal class PatientManager
    {
        enum Gender
        {
            Male,
            Female
        }
        private PatientRepository _repository;

        public PatientManager()
        {
            _repository = new PatientRepository();
        }

        public void AddPatient()
        {
            var patient = new Patient();

            Console.Write("Name: ");
            patient.Name = Console.ReadLine();
            Console.Write("Age: ");
            patient.Age= int.Parse(Console.ReadLine());
            Console.WriteLine("Gender: ");
            foreach (var gender in Enum.GetValues(typeof(Gender)))
            {
                Console.WriteLine($"{(int)gender} - {gender}");
            }
            int genderChoice = int.Parse(Console.ReadLine());
            patient.Gender = ((Gender)genderChoice).ToString();
            Console.Write("Medical Condition: ");
            patient.MedicalCondition = Console.ReadLine();

            _repository.Create(patient);
        }
        public void GetAllPatients()
        {
            var patients = _repository.GetAll();
            foreach (var patient in patients)
            {
                Console.WriteLine($"{patient.Id} - {patient.Name} - {patient.Age} - {patient.Gender} - {patient.MedicalCondition}");
            }
        }
        public void UpdatePatient()
        {
            Console.Write("Enter Patient ID to update: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var patient = new Patient { Id = id };

                Console.Write("New Medical Condition: ");
                patient.MedicalCondition = Console.ReadLine();

                _repository.Update(patient);
                Console.WriteLine("Patient updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid Patient ID.");
            }
        }
        public void RemovePatient()
        {
            Console.Write("Enter Patient ID to remove: ");
            int id = int.Parse(Console.ReadLine());
            _repository.Delete(id);
            Console.WriteLine("Patient removed successfully.");
        }
    }
}
