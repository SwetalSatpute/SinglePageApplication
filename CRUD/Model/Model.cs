namespace CRUD
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Model
    /// </summary>
    public class Model
    {
        /// <summary>
        /// The emp identifier
        /// </summary>
        private int empId;

        /// <summary>
        /// The emp name
        /// </summary>
        private string empName;

        /// <summary>
        /// The emp salary
        /// </summary>
        private double empSalary;

        /// <summary>
        /// Gets or sets the emp identifier.
        /// </summary>
        /// <value>
        /// The emp identifier.
        /// </value>
       public int EmpId { get => empId; set => empId = value; }

        /// <summary>
        /// Gets or sets the name of the emp.
        /// </summary>
        /// <value>
        /// The name of the emp.
        /// </value>
        //ublic string EmpName { get => empName; set => empName = value; }h c
        public double EmpSalary { get => empSalary; set => empSalary = value; }

        /// <summary>
        /// Gets or sets the name of the emp.
        /// </summary>
        /// <value>
        /// The name of the emp.
        /// </value>
        public string EmpName { get => empName; set => empName = value; }
    }
}
