using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookProject
{
    internal class AddressBook
    {
        private string _owner;
        private List<Address> _addresses = new List<Address>();

        public string owner
        {
            get { return _owner; }
            set { _owner = value; }
        }

        public List<Address> Addresses
        {
            get { return _addresses; }
            set { _addresses = value; }
        }
        public AddressBook(string owner)
        {
            _owner = owner;
        }

        public void AddAddress(Address address) 
        {
            _addresses.Add(address); 
        }
        public void RemoveAddress(int index)
        {
            _addresses.RemoveAt(index);
        }

        public static AddressBook SamletAdresseBog(AddressBook adresseBog1, AddressBook adresseBog2)
        {
            AddressBook samletAdresseBog = new AddressBook($"{adresseBog1.owner} & {adresseBog2.owner}");
            samletAdresseBog.Addresses.AddRange(adresseBog1.Addresses);
            samletAdresseBog.Addresses.AddRange(adresseBog2.Addresses);
            return samletAdresseBog;
        }
        public override string ToString()
        {
            string adresseBog = $"{_owner}\n";
            for (int i = 0; i < _addresses.Count; i++)
            {
                adresseBog += $"{i+1}.{_addresses[i]}\n";
            }
            return adresseBog;
        }
    }
}
