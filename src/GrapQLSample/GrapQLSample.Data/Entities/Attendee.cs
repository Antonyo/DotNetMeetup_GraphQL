using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrapQLSample.Data.Entities
{
    public class Attendee : ViewModelBase
    {
        string _name;
        string _surname;
        int _age;
        Address _currentAddress;
        Address _homeTownAddress;
        string _company;
        string _position;

        public string Name { get => _name; set => Set(ref _name, value); }
        public string Surname { get => _surname; set => Set(ref _surname, value); }
        public Address CurrentAddress { get => _currentAddress; set => Set(ref _currentAddress, value); }
        public Address HomeTownAddress { get => _homeTownAddress; set => Set(ref _homeTownAddress, value); }
        public string Company { get => _company; set => Set(ref _company, value); }
        public string Position { get => _position; set => Set(ref _position, value); }
    }
}
