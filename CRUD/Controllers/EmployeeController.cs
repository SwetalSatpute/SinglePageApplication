//-----------------------------------------------------------------------
// <copyright file=" EmployeeController.cs" company="BridgeLabz">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace CRUD.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        EmployeeAccess objEmployee = new EmployeeAccess();

        /// <summary>
        /// Indexes this instance.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("view")]
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

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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

        /// <summary>
        /// Updates the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [HttpPut]
        [Route("Update")]
        public bool Update(  [Bind]Model employee)
        {
            try
            {
                objEmployee.UpdateEmployee( employee);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        /// <summary>
        /// Adds the specified employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("Add")]
        public bool Add([Bind]Model employee)
        {
            objEmployee.AddEmployee(employee);
            return true;
        }

        /// <summary>
        /// Detailses the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
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