using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Deidre_MVC.Models
{

    public class EmployeeDAL
    {
       const string serverName = "";
       const string userName = "sa";
       const string password = "123";

        string connectionString = $"Data Source=" + serverName + ";Initial Catalog=EMPLOYEEDB;Persist Security Info=False;User ID=" + userName +" ;password=" + password;

        //Get All Employee
        public IEnumerable<Employeeinfo> GetAllEmployee()
        {
            List<Employeeinfo> empList = new List<Employeeinfo>();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GetAllEmployee",con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                  con.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Employeeinfo emp = new Employeeinfo();
                    emp.ID = Convert.ToInt32(dr["ID"].ToString());
                    emp.Name = dr["Name"].ToString();
                    emp.Gender = dr["Gender"].ToString();
                    emp.Company = dr["Company"].ToString();
                    emp.Departament = dr["Departament"].ToString();
                    empList.Add(emp);

                }
                con.Close();
            }
            return empList;
        }

        //Insert Employer
        public void AddEmployee(Employeeinfo emp)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_InsertEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.Parameters.AddWithValue("@Company", emp.Company);
                cmd.Parameters.AddWithValue("@Departament", emp.Departament);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        // Update Employee

        public void UpdateEmployee(Employeeinfo emp)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_UpdateEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpId", emp.ID);
                cmd.Parameters.AddWithValue("@Name", emp.Name);
                cmd.Parameters.AddWithValue("@Gender", emp.Gender);
                cmd.Parameters.AddWithValue("@Company", emp.Company);
                cmd.Parameters.AddWithValue("@Departament", emp.Departament);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        // Delete Employee
        public void DeleteEmployee(int? empId)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_DeleteEmployee", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@EmpId", empId);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }

        }

        // Get Employee by ID
        public Employeeinfo GetEmployeeById(int? empId)
        {
            Employeeinfo emp = new Employeeinfo();
            
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("SP_GetEmployeeById", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpId", empId);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    emp.ID = Convert.ToInt32(dr["ID"].ToString());
                    emp.Name = dr["Name"].ToString();
                    emp.Gender = dr["Gender"].ToString();
                    emp.Company = dr["Company"].ToString();
                    emp.Departament = dr["Departament"].ToString();
                }
                con.Close();
            }
            return emp;
        }

    }




}
