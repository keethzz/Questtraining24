using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace db
{
    public class Books
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var connStr = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\user\\Documents\\QuestDB.mdf;Integrated Security=True;Connect Timeout=30";
             /*Create table books
             
            var createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Books' AND xtype='U')
            CREATE TABLE Books (
                id INT PRIMARY KEY IDENTITY,
                name VARCHAR(50),
                author VARCHAR(50),
                price INT DEFAULT 0
            )";
            
            // input from user
            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Author: ");
            var author = Console.ReadLine();

            Console.Write("Price: ");
            var price = Console.ReadLine();

            var insertQuery = "INSERT INTO Books (name, author, price) VALUES (@name, @author, @price)";
            var conn = new SqlConnection(connStr);
            conn.Open();
            var command = new SqlCommand(insertQuery, conn);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@author", author);
            command.Parameters.AddWithValue("@price", price);
            command.ExecuteNonQuery();
            conn.Close();
            */
            var list = new List<Books>()
        {
            new Books { Name = "Book2", Author = "Author2", Price = 2000 },
            new Books { Name = "Book3", Author = "Author3", Price = 150 },
            new Books { Name = "Book4", Author = "Author4", Price = 250 },
            new Books { Name = "Book5", Author = "Author5", Price = 300 },
            new Books { Name = "Book6", Author = "Author6", Price = 500 }
        };

            var connect = new SqlConnection(connStr);
            connect.Open();
                foreach (var item in list)
                {
                    var insertQ = "INSERT INTO Books (name, author, price) VALUES(@name, @author, @price)";
                    using (var command = new SqlCommand(insertQ, connect))
                    {
                        command.Parameters.AddWithValue("@name", item.Name);
                        command.Parameters.AddWithValue("@author", item.Author);
                        command.Parameters.AddWithValue("@price", item.Price);
                        command.ExecuteNonQuery();
                    }
                }

                connect.Close();
            

        }    

    }
 }

