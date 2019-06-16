using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrapQLSample.Data.Entities
{
    public class EntityBase : ViewModelBase
    {
        long _id;

        public long Id { get => _id; set => Set(ref _id, value); }
    }
}
