using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    internal class Address
    {
        private string _Name;
        private string _StreetAddress;
        private string _Telephone;
        public string name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        public string streetaddress
        {
            get { return _StreetAddress; }
            set { _StreetAddress = value; }
        }
        public string telephone
        {
            get { return _Telephone; }
            set { _Telephone = value; }
        }
       public Address(string name, string streetaddress, string telephone) 
        {
            _Name = name;
            _StreetAddress = streetaddress;
            _Telephone = telephone;
        }

        public override string ToString()
        {
            return $"Navn: {_Name} Adresse: {_StreetAddress} Telefonnummer: {_Telephone}";
        }
    }
}
