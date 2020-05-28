using System.Collections.Generic;

namespace AddressBook
{
    class AddressBook
    {
        public List<Contact> contacts = new List<Contact>();
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
        }

    }
}