using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Persistence;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeListController : ControllerBase
    {
        private readonly DataContext context;

        public EmployeeListController(DataContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// GET api/EmployeeList
        /// </summary>
        /// <returns> A list of employees</returns>
        [HttpGet(Name = "GetEmployeeList")]
        public ActionResult<List<AddEmployee>> Get()
        {
            return this.context.EmployeeList.ToList();
        }

        /// <summary>
        /// GET api/addEmployee/[id]
        /// </summary>
        /// <param name="id">AddEmployee id</param>
        /// <returns> A single employee </returns>
        [HttpGet("{id}", Name = "GetById")]
        public ActionResult<AddEmployee> GetById(Guid id)
        {
            var AddEmployee = this.context.EmployeeList.Find(id);
            if(AddEmployee is null)
            {
                return NotFound();
            }

            return Ok(AddEmployee);
        }

        /// <summary>
        /// POST api/AddEmployee
        /// </summary>
        /// <param name="request">JSON request containing employee fields</param>
        /// <returns> A new employee</returns>
        [HttpPost(Name = "Create")]
        public ActionResult<AddEmployee> Create([FromBody]AddEmployee request)
        {
            var AddEmployee = new AddEmployee{
                Id = request.Id,
                Name = request.Name,
                Wage = request.Wage,
                HireDate = request.HireDate
            };

            context.EmployeeList.Add(AddEmployee);
            var success = context.SaveChanges() > 0;

            if(success)
            {
                return Ok(AddEmployee);
            }

            throw new Exception("Error creating employee");
        }

        /// <summary>
        /// PUT api/AddEmployee
        /// </summary>
        /// <param name="request">JSON request containing one or more updated post fields</param>
        /// <returns>An updated employee</returns>
        [HttpPut(Name = "Update")]
        public ActionResult<AddEmployee> Update([FromBody]AddEmployee request)
        {
            var AddEmployee = context.EmployeeList.Find(request.Id);
            if (AddEmployee == null) 
            {
                throw new Exception("Could not find employee");
            }
            //update employee properties with request values if present
            AddEmployee.Name = request.Name != null ? request.Name : AddEmployee.Name;
            AddEmployee.Wage = request.Wage != 0 ? request.Wage : AddEmployee.Wage;
            AddEmployee.HireDate = request.HireDate != null ? request.HireDate : AddEmployee.HireDate;

            var success = context.SaveChanges() > 0;

            if(success)
            {
                return Ok(AddEmployee);
            }

            throw new Exception("Error updating employee");
        }
    }
}