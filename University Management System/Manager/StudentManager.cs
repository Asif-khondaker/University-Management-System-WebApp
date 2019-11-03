using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using University_Management_System.Gateway;
using University_Management_System.Model;

namespace University_Management_System.Manager
{
    public class StudentManager
    {
        StudentGateway aStudentGateway = new StudentGateway();
        public string Save(Student aStudent)
        {
            if (aStudent.RegNo.Length>6)
            {
                if (aStudentGateway.GetStudentByRegNo(aStudent.RegNo) != null)
                {
                    return "Registration Number already exists.";
                }
                else
                {
                    if (aStudentGateway.Save(aStudent) > 0)
                    {
                        return "Save Successfully";
                    }
                    else
                    {
                        return "Save Failed!";
                    }

                }


            }
            else
            {
                return "Registration Number Must be 6 charecter long";
            }


        }

        internal Student GetStudentById(int id)
        {
            return aStudentGateway.GetStudentById(id);
        }

        public Student GetStudentByRegNo(string regNo)
        {
            return aStudentGateway.GetStudentByRegNo(regNo);
        }

        internal string Delete(int id)
        {
            int rowAffected = aStudentGateway.Delete(id);

            if(rowAffected>0)
            {
                return "Delete Successfully";
            }
            return "Delete failed";
        }

        public List<StudentViewModel> GetAllStudents()
        {
            return aStudentGateway.GetAllStudents();
        }

        internal string Update(Student aStudent)
        {
            int rowAffected = aStudentGateway.Update(aStudent);

            if(rowAffected>0)
            {
                return "Updated successfully";
            }
            return "Update failed!";
        }
    }
}