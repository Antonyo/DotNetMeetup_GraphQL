using System;
using System.Collections.Generic;
using System.Text;

namespace GrapQLSample.Data.Entities
{
    public class Address : EntityBase
    {
        string _line1;
        string _line2;
        string _city;
        int _postalCode;
        string _country;

        public string Line1 { get => _line1; set => Set(ref _line1, value); }
        public string Line2 { get => _line2; set => Set(ref _line2, value); }
        public string City { get => _city; set => Set(ref _city, value); }
        public int PostalCode { get => _postalCode; set => Set(ref _postalCode, value); }
        public string Country { get => _country; set => Set(ref _country, value); }
    }
}
