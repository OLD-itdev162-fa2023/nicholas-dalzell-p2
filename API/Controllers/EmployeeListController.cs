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

        //GET api/posts
        [HttpGet(Name = "GetEmployeeList")]
        public ActionResult<List<AddEmployee>> Get()
        {
            return this.context.EmployeeList.ToList();
        }
    }
}