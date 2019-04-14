//-----------------------------------------------------------------------
// <copyright file=" EmployeeAccess.cs" company="BridgeLabz">
//Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace CRUD
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// EmployeeAccess
    /// </summary>
    public class EmployeeAccess
    {
        string ConnectionString = "Data Source=(localDB)\\local;Initial Catalog=Employe;Integrated Security=true;";
        //To View all employees details    
        public IEnumerable<Model> GetAllEmployees()
        {
            try
            {
                List<Model> lstemployee = new List<Model>();
                SqlConnection conn = new SqlConnection(ConnectionString);
                {
                    SqlCommand cmd = new SqlCommand("spGetAllEmploye", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        Model employee = new Model();
                        employee.EmpId = Convert.ToInt32(rdr["EmpId"]);
                        employee.EmpName = rdr["EmpName"].ToString();
                        employee.EmpSalary = Convert.ToDouble(rdr["EmpSalary"].ToString());
                        lstemployee.Add(employee);
                    }
                    conn.Close();
                }
                return lstemployee;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public void AddEmployee(Model employee)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("spInsertData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", employee.EmpId);
                cmd.Parameters.AddWithValue("@EmpName", employee.EmpName);
                cmd.Parameters.AddWithValue("@EmpSalary", employee.EmpSalary);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public void UpdateEmployee(Model employee)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SpUpdate", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId",employee.EmpId);
                cmd.Parameters.AddWithValue("@EmpName", employee.EmpName);
                cmd.Parameters.AddWithValue("@EmpSalary", employee.EmpSalary);
                con.Open();
                cmd.ExecuteNonQuery();  
                con.Close(); 
            }
        }
        public void DeleteEmployee(int id)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("SpDeleteData", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public Model GetEmployeeData(int? id)
        {
            Model employee = new Model();

            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                string sqlQuery = "SELECT * FROM Employe WHERE EmpId= " + id;
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    employee.EmpId = Convert.ToInt32(rdr["EmpID"]);
                    employee.EmpName = rdr["EmpName"].ToString();
                    employee.EmpSalary = Convert.ToDouble ( rdr["EmpSalary"].ToString());
                   
                }
            }
            return employee;
        }

    }
    
}