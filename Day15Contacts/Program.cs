using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15Contacts
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            // SQL query to create the Contacts table if it does not exist
            var createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Contacts' AND xtype='U')
            CREATE TABLE Contacts (
                Id INT PRIMARY KEY IDENTITY,
                Name VARCHAR(100),
                Phone VARCHAR(15),
                Email VARCHAR(100) NULL
            )";

            // Open the connection to the LocalDB and the attached database
            using (var conn = new SqlConnection(connStr))
            {
                conn.Open();

                // Create the table if it does not exist
                using (var command = new SqlCommand(createTableQuery, conn))
                {
                    command.ExecuteNonQuery();
                    Console.WriteLine("Table 'Contacts' created successfully (if not existing).");
                }
            }
        }
    }
}
