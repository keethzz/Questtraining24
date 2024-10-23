using Day16ContactAssignment.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day16ContactAssignment.Model;

namespace Day16ContactAssignment.Repository
{
    internal class ContactRepository
    {
        private SqlConnection _connection;

        public ContactRepository()
        {
            _connection = new SqlConnection(AppSetting.ConnectionString);
        }

        public void Create(Contact contact)
        {
            EnsureConnectionIsOpen();
            var sql = "INSERT INTO Contacts (Name, Email, Phone) VALUES (@Name, @Email, @Phone)";
            var command = new SqlCommand(sql, _connection);
            command.Parameters.AddWithValue("@Name", contact.Name);
            command.Parameters.AddWithValue("@Email", contact.Email);
            command.Parameters.AddWithValue("@Phone", contact.Phone);
            command.ExecuteNonQuery();
        }

        public List<Contact> GetAll()
        {
            EnsureConnectionIsOpen();
            var sql = "SELECT ContactID, Name, Email, Phone FROM Contacts";
            var command = new SqlCommand(sql, _connection);
            var reader = command.ExecuteReader();

            var contacts = new List<Contact>();
            while (reader.Read())
            {
                contacts.Add(new Contact
                {
                    Id = (int)reader["ContactID"],
                    Name = (string)reader["Name"],
                    Email = (string)reader["Email"],
                    Phone = (string)reader["Phone"]
                });
            }
            return contacts;
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
