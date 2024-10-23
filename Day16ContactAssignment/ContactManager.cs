using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day16ContactAssignment.Repository;
using Day16ContactAssignment.Model;

namespace Day16ContactAssignment
{
    //gives connection 2
    internal class ContactManager
    {
        private ContactRepository _repository;

        public ContactManager()
        {
            _repository = new ContactRepository();
        }

        public void AddContact()
        {
            var contact = new Contact();

            Console.Write("Name: ");
            contact.Name = Console.ReadLine();

            Console.Write("Email: ");
            contact.Email = Console.ReadLine();

            Console.Write("Phone: ");
            contact.Phone = Console.ReadLine();

            _repository.Create(contact);
        }

        public void GetAllContacts()
        {
            var contacts = _repository.GetAll();
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Id} - {contact.Name} - {contact.Email} - {contact.Phone}");
            }
        }
    }
}
