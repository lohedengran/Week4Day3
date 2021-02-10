using System;
using System.Collections.Generic;
using System.Text;

namespace Week4Day3
{
    class Person
    {
        public int WorkplaceId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}. Age: {Age}.";
        }
    }
}
