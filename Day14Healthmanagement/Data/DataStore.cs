using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day14Healthmanagement.Models;

namespace Day14Healthmanagement.Data
{
    internal class DataStore
    {
        public List<Patient> Patients { get; set; } = new List<Patient>();
        public List<Appoinment> Appointments { get; set; } = new List<Appoinment>();

        public DataStore()
        {
            // Sample data
            Patients.Add(new Patient { Id = 1, Name = "John Doe", Age = 65, Gender = "Male", MedicalCondition = "Diabetes" });
            Patients.Add(new Patient { Id = 2, Name = "Jane Smith", Age = 45, Gender = "Female", MedicalCondition = "Hypertension" });
            Patients.Add(new Patient { Id = 3, Name = "Mike Brown", Age = 70, Gender = "Male", MedicalCondition = "Heart Disease" });

            Appointments.Add(new Appoinment { Id = 1, PatientId = 1, DoctorName = "Dr. Adams", AppointmentDate = DateTime.Now.AddDays(3), AppointmentType = "Consultation" });
            Appointments.Add(new Appoinment { Id = 2, PatientId = 2, DoctorName = "Dr. Baker", AppointmentDate = DateTime.Now.AddDays(5), AppointmentType = "Follow-up" });
            Appointments.Add(new Appoinment { Id = 3, PatientId = 3, DoctorName = "Dr. Carter", AppointmentDate = DateTime.Now.AddDays(-10), AppointmentType = "Surgery" });
            Appointments.Add(new Appoinment { Id = 4, PatientId = 1, DoctorName = "Dr. Adams", AppointmentDate = DateTime.Now.AddDays(-20), AppointmentType = "Follow-up" });
            Appointments.Add(new Appoinment { Id = 5, PatientId = 1, DoctorName = "Dr. Adams", AppointmentDate = DateTime.Now.AddDays(-5), AppointmentType = "Consultation" });
        }
    }
}
