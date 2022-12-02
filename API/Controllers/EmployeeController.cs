using Microsoft.AspNetCore.Mvc;
using Domain;
using Persistence;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class EmployeeController : ControllerBase
{

    private readonly ILogger<EmployeeController> _logger;

    private readonly DataContext _context;

    public EmployeeController(ILogger<EmployeeController> logger, DataContext context)
    {
        _logger = logger;
        _context = context;
    }

    [HttpGet(Name = "GetEmployee")]
    public IEnumerable<Employee> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Employee
        {
            Name = "John",
            Wage = 20.25,
            HireDate = DateTime.Now.AddDays(-20)
            //JobTitle = "worker"
        })
        .ToArray();
    }

    [HttpPost]
    public ActionResult<Employee> Create()
    {
        Console.WriteLine($"DB path: {_context.DbPath}");
        Console.WriteLine("Insert a new Employee");

        var employee = new Employee()
        {
            Name = "name",
            Wage = 20.25,
            HireDate = DateTime.Now.AddDays(-20)
            //JobTitle = "jobTitle"
        };

        _context.Employees.Add(employee);
        var success = _context.SaveChanges() > 0;

        if (success)
        {
            return employee;
        };

        throw new Exception("Error creating employee.");
    }
};
