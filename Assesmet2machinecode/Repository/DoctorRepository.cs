using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Assesmet2machinecode.Entities;
using Assesmet2machinecode.Connection;

namespace Assesmet2machinecode.Repository
{
    internal class DoctorRepository
    {
        private SqlConnection _connection;

        public DoctorRepository()
        {
            _connection = new SqlConnection(DataConnection.ConnectionString);
        }

        // Add new doctor
        public void Create(Doctor doctor)
        {
            EnsureConnectionIsOpen();
            var sql = "INSERT INTO Doctor (Name, Specialization, PatientId) VALUES (@Name, @Specialization, @PatientId)";
            var command = new SqlCommand(sql, _connection);
            command.Parameters.AddWithValue("@Name", doctor.Names);
            command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
            command.Parameters.AddWithValue("@PatientId", doctor.PatientId);
            command.ExecuteNonQuery();
        }
        //Get doctors
        public List<Doctor> GetAll()
        {
            EnsureConnectionIsOpen();
            var sql = "SELECT Id, Name, Specialization, PatientId FROM Doctor";
            var command = new SqlCommand(sql, _connection);
            var reader = command.ExecuteReader();

            var doctors = new List<Doctor>();
            while (reader.Read())
            {
                doctors.Add(new Doctor
                {
                    Id = (int)reader["Id"],
                    Names = (string)reader["Name"],
                    Specialization = (string)reader["Specialization"],
                    PatientId = Convert.ToInt32(reader["PatientId"]) 
                });
            }
            return doctors;
        }
        // Update
        public void Update(Doctor doctor)
        {
            EnsureConnectionIsOpen();
            var sql = "UPDATE Doctor SET Specialization = @Specialization WHERE Id = @Id";
            var command = new SqlCommand(sql, _connection);
            command.Parameters.AddWithValue("@Specialization", doctor.Specialization);
            command.Parameters.AddWithValue("@Id", doctor.Id);
            command.ExecuteNonQuery();
        }
        //Remove a doctor
        public void Delete(int id)
        {
            EnsureConnectionIsOpen();
            var sql = "DELETE FROM Doctor WHERE Id = @Id";
            var command = new SqlCommand(sql, _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
        }
        private void EnsureConnectionIsOpen()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }
    }
}