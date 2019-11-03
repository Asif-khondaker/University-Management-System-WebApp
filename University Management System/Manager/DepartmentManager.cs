using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University_Management_System.Gateway;
using University_Management_System.Model;

namespace University_Management_System.Manager
{
    public class DepartmentManager
    {
        DepartmentGateway aDepartmentGateway = new DepartmentGateway();
        public List<Department> GetAllDepartments()
        {
           return aDepartmentGateway.GetAllDeartment(); 
        }
    }
}