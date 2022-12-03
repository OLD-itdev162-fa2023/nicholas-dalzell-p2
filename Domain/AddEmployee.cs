using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    
    public class AddEmployee
    {
        public Guid Id { get; set; }
        public string Name  { get; set; }
        public double Wage { get; set; }
        public DateTime HireDate { get; set; }
    }

    
}