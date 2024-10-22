﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Contact
{
    public class Contact
    {
        public int ContactID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class ContactRepository
    {

        private string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\QuestDB.mdf;Integrated Security=True;Connect Timeout=30";

        public ContactRepository()
        {
            CreateContactsTable();
        }

        private void CreateContactsTable()
        {
            string createTableQuery = @"CREATE TABLE Contacts (
                ContactID INT PRIMARY KEY IDENTITY(1,1),
                Name VARCHAR(100) NOT NULL,
                Phone VARCHAR(20) NOT NULL,
                Email VARCHAR(100) NULL
            )";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand(createTableQuery, connection);
            command.ExecuteNonQuery();
           
        }

        public void AddContact(Contact contact)
        {
            string query = "INSERT INTO Contacts (Name, Phone, Email) VALUES (@Name, @Phone, @Email)";
            SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", contact.Name);
                command.Parameters.AddWithValue("@Phone", contact.Phone);
                command.Parameters.AddWithValue("@Email", contact.Email ?? (object)DBNull.Value);

                connection.Open();
                command.ExecuteNonQuery();

        }
        public Contact SearchByNameOrPhone(string input)
        {
            string query = "SELECT * FROM Contacts WHERE Name = @Input OR Phone = @Input";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Input", input);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Contact
                        {
                            ContactID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Phone = reader.GetString(2),
                            Email = reader.IsDBNull(3) ? null : reader.GetString(3)
                        };
                    }
                }
            }
            return null;
        }
        public void UpdateContact(Contact contact)
        {
            string query = "UPDATE Contacts SET Name = @Name, Phone = @Phone, Email = @Email WHERE ContactID = @ContactID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", contact.Name);
                command.Parameters.AddWithValue("@Phone", contact.Phone);
                command.Parameters.AddWithValue("@Email", contact.Email ?? (object)DBNull.Value);
                command.Parameters.AddWithValue("@ContactID", contact.ContactID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        public void DeleteContact(int contactID)
        {
            string query = "DELETE FROM Contacts WHERE ContactID = @ContactID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ContactID", contactID);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ContactRepository repository = new ContactRepository();

            // Add a new contact
            repository.AddContact(new Contact { Name = "John Doe", Phone = "123456789", Email = "john@example.com" });

            // Search contact by name or phone
            var contact = repository.SearchByNameOrPhone("John Doe");
            if (contact != null)
            {
                Console.WriteLine($"Found: {contact.Name}, Phone: {contact.Phone}, Email: {contact.Email}");

                // Update contact
                contact.Name = "John Smith";
                repository.UpdateContact(contact);
                Console.WriteLine("Contact updated.");

                // Delete contact
                repository.DeleteContact(contact.ContactID);
                Console.WriteLine("Contact deleted.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }
}
