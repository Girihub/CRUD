﻿using Common.Models;
using EmployeeRepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace EmployeeRepository.Services
{
    public class RepositoryServices : IRepository
    {
        private static readonly string sqlString = @"Data Source =localhost;Initial Catalog =EmployeeManagement; Integrated Security = true";

        SqlConnection sqlConnection = new SqlConnection(sqlString);

        public bool AddEmployee(EmployeeModel employeeModel)
        {
            SqlCommand sqlCommand = new SqlCommand("spEmployeeCreate", sqlConnection);
            try
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@FirstName", employeeModel.FirstName));
                sqlCommand.Parameters.Add(new SqlParameter("@Lastname", employeeModel.LastName));
                sqlCommand.Parameters.Add(new SqlParameter("@Address", employeeModel.EmpAddress));
                sqlCommand.Parameters.Add(new SqlParameter("@MobileNumber", employeeModel.MobileNumber));
                sqlCommand.Parameters.Add(new SqlParameter("@ZipCode", employeeModel.ZipCode));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool DeleteEmployee(int id)
        {
            SqlCommand sqlCommand = new SqlCommand("spEmployeeDelete", sqlConnection);
            try
            {                
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.Add(new SqlParameter("@Id", id));
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public IList<EmployeeModel> DisplayEmployees()
        {
            SqlCommand sqlCommand = new SqlCommand("spEmployeeDisplay", sqlConnection);
            List<EmployeeModel> employeeModel = new List<EmployeeModel>();
            try
            {
                sqlConnection.Open();
                sqlCommand.CommandType = CommandType.StoredProcedure;
                SqlDataReader dataReader = sqlCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    employeeModel.Add(new EmployeeModel
                    {                        
                        FirstName = dataReader["FirstName"].ToString(),
                        LastName = dataReader["LastName"].ToString(),
                        EmpAddress = dataReader["EmpAddress"].ToString(),
                        MobileNumber = Convert.ToInt32(dataReader["MobileNumber"]),
                        ZipCode = Convert.ToInt32(dataReader["ZipCode"])
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
                sqlConnection.Close();
            }            
        }        

        public bool UpdateEmployee(int id, EmployeeModel employeeModel)
        {
            SqlCommand sqlCommand = new SqlCommand("spEmployeeUpdate", sqlConnection);
            try
            {
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlConnection.Open();
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
                sqlConnection.Close();
            }
            return true;
        }
    }
}
