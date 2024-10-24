using Assesmet2machinecode.Entities;
using Assesmet2machinecode.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesmet2machinecode
{
    internal class DoctorManager
    {
        private DoctorRepository _repository;
        public DoctorManager()
        {
            _repository = new DoctorRepository();
        }
        public void AddDoctor()
        {
            var doctor = new Doctor();
            Console.Write("Doctor Name: ");
            doctor.Names = Console.ReadLine();
            Console.Write("Specialization of doctor: ");
            doctor.Specialization = Console.ReadLine();
            Console.Write("Patient ID: ");
            if (int.TryParse(Console.ReadLine(), out int patientId))
            {
                doctor.PatientId = patientId;
            }
            _repository.Create(doctor);
        }
        public void GetAllDoctors()
        {
            var doctors = _repository.GetAll();
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"{doctor.Id} - {doctor.Names} - {doctor.Specialization} - {doctor.PatientId}");
            }
        }
        public void UpdateDoctor()
        {
            Console.Write("Enter Doctor ID to update: ");
            int id= int.Parse(Console.ReadLine());
            var doctor = new Doctor { Id = id };
            Console.Write("New Specialization: ");
            doctor.Specialization = Console.ReadLine();
            _repository.Update(doctor);
            Console.WriteLine("Doctor updated successfully.");
        }
        public void RemoveDoctor()
        {
            Console.Write("Enter Doctor ID to remove: ");
            int id= int.Parse(Console.ReadLine());
             _repository.Delete(id);
             Console.WriteLine("Doctor removed successfully.");
        }
    }
}
