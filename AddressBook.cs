using System.Collections;
using System.Collections.Generic;

namespace AddressBook
{
    class AddressBook
    {
        public Dictionary<string, Contact> contacts = new Dictionary<string, Contact>();
        public void AddContact(Contact contact)
        {
            contacts.Add(contact.Email, contact);
        }

        public Contact GetByEmail(string email)
        {
            Contact contact = contacts[email];
            return contact;

        }

    }
}