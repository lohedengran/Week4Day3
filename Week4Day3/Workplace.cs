using System;
using System.Collections.Generic;
using System.Text;

namespace Week4Day3
{
    class Workplace
    {
        public int WorkplaceId { get; set; }
        public string CompanyName { get; set; }

        public override string ToString()
        {
            return $"{CompanyName} {WorkplaceId}";
        }
    }
}
