//----------------------------------------------------
// <copyright file="RepositoryServices.cs" company="Bridgelabz">
// Company copyright tag.
// </copyright>
//----------------------------------------------------

namespace EmployeeRepository.Services
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SqlClient;
    using Common.Models;
    using EmployeeRepository.Interfaces;        

    /// <summary>
    /// RepositoryServices implements interface IRepository
    /// </summary>
    public class RepositoryServices : IRepository
    {
        /// <summary>
        /// private readonly field to store connection string
        /// </summary>
        private static readonly string SqlString = @"Data Source =localhost;Initial Catalog =EmployeeManagement; Integrated Security = true";

        /// <summary>
        /// Get instance of Connection class
        /// </summary>
        private SqlConnection sqlConnection = new SqlConnection(SqlString);

        /// <summary>
        /// Method to add employee 
        /// </summary>
        /// <param name="employeeModel">employeeModel as a parameter</param>
        /// <returns>returns boolean value</returns>
        public bool AddEmployee(EmployeeModel employeeModel)
        {
            SqlCommand sqlCommand = new SqlCommand("spEmployeeCreate", this.sqlConnection);
            try
            {
                this.sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@FirstName", employeeModel.FirstName));
                sqlCommand.Parameters.Add(new SqlParameter("@Lastname", employeeModel.LastName));
                sqlCommand.Parameters.Add(new SqlParameter("@Address", employeeModel.EmpAddress));
                sqlCommand.Parameters.Add(new SqlParameter("@MobileNumber", employeeModel.MobileNumber));
                sqlCommand.Parameters.Add(new SqlParameter("@ZipCode", employeeModel.ZipCode));
                sqlCommand.ExecuteNonQuery();
                this.sqlConnection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.sqlConnection.Close();
            }

            return true;
        }

        /// <summary>
        /// Method to delete employee
        /// </summary>
        /// <param name="id">id as a parameter</param>
        /// <returns>returns true after deleting value</returns>
        public bool DeleteEmployee(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("spEmployeeDelete", this.sqlConnection);
            try
            {
                this.sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@Id", id));
                sqlCommand.ExecuteNonQuery();
                this.sqlConnection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.sqlConnection.Close();
            }

            return true;
        }

        /// <summary>
        /// Method to display employee
        /// </summary>
        /// <returns>returns list of employees</returns>
        public IList<EmployeeModel> DisplayEmployees()
        {
            SqlCommand sqlCommand = new SqlCommand("spEmployeeDisplay", this.sqlConnection);
            List<EmployeeModel> employeeModel = new List<EmployeeModel>();
            try
            {
                this.sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    employeeModel.Add(new EmployeeModel
                    {                        
                        FirstName = dataReader["FirstName"].ToString(),
                        LastName = dataReader["LastName"].ToString(),
                        EmpAddress = dataReader["EmpAddress"].ToString(),
                        MobileNumber = dataReader["MobileNumber"].ToString(),
                        ZipCode = dataReader["ZipCode"].ToString()
                    });
                }

                return employeeModel;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.sqlConnection.Close();
            }            
        }

        /// <summary>
        /// Method to Get Employee By Id employee
        /// </summary>
        /// <param name="id">id as a parameter</param>
        /// <returns>return list of employee</returns>
        public IList<EmployeeModel> GetEmployeeById(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("spEmployeeDataGetById", this.sqlConnection);
            try
            {
                IList<EmployeeModel> list = new List<EmployeeModel>();
               
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@Id", id);
                this.sqlConnection.Open();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                EmployeeModel model = null;
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        model = new EmployeeModel();
                        model.FirstName = dataReader["FirstName"].ToString();
                        model.LastName = dataReader["LastName"].ToString();
                        model.EmpAddress = dataReader["EmpAddress"].ToString();
                        model.MobileNumber = dataReader["MobileNumber"].ToString();
                        model.ZipCode = dataReader["ZipCode"].ToString();
                        list.Add(model);
                    }
                }

                return list;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                this.sqlConnection.Close();
            }
        }

        /// <summary>
        /// Method to update employee
        /// </summary>
        /// <param name="id">id as a parameter</param>
        /// <param name="employeeModel">employeeModel as a parameter</param>
        /// <returns>returns boolean value</returns>
        public bool UpdateEmployee(int id, EmployeeModel employeeModel)
        {
            SqlCommand sqlCommand = new SqlCommand("spEmployeeUpdate", this.sqlConnection);
            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                this.sqlConnection.Open();
                sqlCommand.Parameters.Add(new SqlParameter("@Id", id));
                sqlCommand.Parameters.Add(new SqlParameter("@FirstName", employeeModel.FirstName));
                sqlCommand.Parameters.Add(new SqlParameter("@Lastname", employeeModel.LastName));
                sqlCommand.Parameters.Add(new SqlParameter("@Address", employeeModel.EmpAddress));
                sqlCommand.Parameters.Add(new SqlParameter("@MobileNumber", employeeModel.MobileNumber));
                sqlCommand.Parameters.Add(new SqlParameter("@ZipCode", employeeModel.ZipCode));
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                this.sqlConnection.Close();
            }

            return true;
        }
    }
}
