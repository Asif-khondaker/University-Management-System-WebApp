﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace University_Management_System
{
    public class Student
    {
        public int Id { get; set; }
        public string RegNo { get; set; }

        public string Name { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }

        public string Email { get; set; }

        public int DepartmentId { get; set; }
    }
}