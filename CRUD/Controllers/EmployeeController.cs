using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        EmployeeAccess objEmployee = new EmployeeAccess();


        [HttpGet]
        
        public IEnumerable<Model> Index()
        {
            try
            {
                return objEmployee.GetAllEmployees();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }


        [HttpDelete]
        [Route("delete/{id}")]
        public bool Delete(int id)
        {
            try
            {
                objEmployee.DeleteEmployee(id);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }



        [HttpPut]
        [Route("Update/")]
        public bool Update(  [Bind]Model employee)


        {
            try
            {
                objEmployee.UpdateEmployee( employee);
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
        [HttpPost]
        [Route("Add")]
        public bool Add([Bind]Model employee)
        {
            objEmployee.AddEmployee(employee);
            return true;
        }

        [HttpGet]
        [Route("Details/{id}")]
        public bool Details(int? id)
        {
            try
            {
                objEmployee.GetEmployeeData(id);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }
    }
}