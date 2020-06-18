using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeService.Controllers
{
    [Authorize]
    public class EmployeesController : ApiController
    {
        EmployeeDBEntities db = new EmployeeDBEntities();

        public IEnumerable<Employees> GetEmployees()
        {
            var EmployeesList = db.Employees.ToList();
            return EmployeesList;
        }
    }
}
