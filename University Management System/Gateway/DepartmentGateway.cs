using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using University_Management_System.Model;

namespace University_Management_System.Gateway
{
    public class DepartmentGateway : Gateway
    {
        public List<Department> GetAllDeartment()
        {
            Query = "SELECT * FROM Departments";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            List<Department> departments = new List<Department>();

            while(Reader.Read())
            {
                Department aDepartment = new Department();

                aDepartment.DepartmentId = Convert.ToInt32(Reader["Id"]);
                aDepartment.Code = Reader["Code"].ToString();
                aDepartment.Name = Reader["Name"].ToString();

                departments.Add(aDepartment);
            }
            Reader.Close();
            Connection.Close();

            return departments;


        }
    }
}