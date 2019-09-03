using System;
using System.Collections.Generic;
using System.Text;

namespace Conversion
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public string City { get; set; }
        public override string ToString()
        {
            return ID + '\t' + Name + '\t' + Job + '\t' + City;
        }
    }
}
