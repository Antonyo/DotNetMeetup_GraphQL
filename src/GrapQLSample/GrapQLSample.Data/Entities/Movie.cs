using System;
using System.Collections.Generic;
using System.Text;

namespace GrapQLSample.Data.Entities
{
    public class Movie : EntityBase
    {
        string _title;
        short _year;
        string _genre;
        string _director;

        public string Title { get => _title; set => Set(ref _title, value); }
        public short Year { get => _year; set => Set(ref _year, value); }
        public string Genre { get => _genre; set => Set(ref _genre, value); }
        public string Director { get => _director; set => Set(ref _director, value); }
    }
}
