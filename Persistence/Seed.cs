using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static void SeedData(DataContext context)
        {
            if (!context.EmployeeList.Any())
            {
                var EmployeeList = new List<AddEmployee>
                {
                    new AddEmployee {
                        Name = "John Covington",
                        Wage = 25.00,
                        HireDate = DateTime.Now.AddDays(-10)
                    },
                    new AddEmployee {
                        Name = "Tina Thompson",
                        Wage = 30.00,
                        HireDate = DateTime.Now.AddDays(-15)
                    },
                    new AddEmployee {
                        Name = "Veronica Hoover",
                        Wage = 22.50,
                        HireDate = DateTime.Now.AddDays(-5)
                    },
                    new AddEmployee {
                        Name = "Aaron Ronald",
                        Wage = 21.75,
                        HireDate = DateTime.Now.AddDays(-3)
                    }
                };
            }
        }
    }
}