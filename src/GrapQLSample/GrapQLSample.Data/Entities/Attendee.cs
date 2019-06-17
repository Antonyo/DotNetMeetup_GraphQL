using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrapQLSample.Data.Entities
{
    public class Attendee : EntityBase
    {
        string _name;
        string _lastName;
        int _age;
        Address _currentAddress;
        Address _homeTownAddress;
        string _company;
        string _position;
        string _email;

        public string Name { get => _name; set => Set(ref _name, value); }
        public string LastName { get => _lastName; set => Set(ref _lastName, value); }
        public Address CurrentAddress { get => _currentAddress; set => Set(ref _currentAddress, value); }
        public Address HomeTownAddress { get => _homeTownAddress; set => Set(ref _homeTownAddress, value); }
        public string Company { get => _company; set => Set(ref _company, value); }
        public string Position { get => _position; set => Set(ref _position, value); }
        public string Email { get => _email; set => Set(ref _email, value); }
    }
}
