using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_Management_System.Model
{
    public class StudentViewModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string RegistrationNo { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string DepartmentName { get; set; }

    }
}