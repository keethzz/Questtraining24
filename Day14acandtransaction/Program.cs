using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14acandtransaction
{
    class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Balance { get; set; }
    }
    class Transaction
    {
        public int Id { get; set; }
        public int Fromac_id { get; set; }
        public int To { get; set; }
        public int Amount { get; set; }
        public DateTime date { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<Account>()
            {
                new Account{Id=1, Name="Person1" , Balance= 1000},
                new Account{Id=2, Name="Person2" , Balance= 2000},
                new Account{Id=3, Name="Person3" , Balance= 3000},
            };
            var transactions = new List<Transaction>()
            {
                new Transaction{Id=1, Fromac_id=1, To= 2, Amount= 1000, date=DateTime.Now()},
                new Transaction{Id=2, Fromac_id=2, To= 3, Amount= 2000, date=DateTime.Now()}
            };
            var tr = from transaction in transactions
                     join  from 
        }
    }
}
