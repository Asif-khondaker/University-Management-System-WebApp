using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using University_Management_System.Model;

namespace University_Management_System.Gateway
{
    
    public class StudentGateway : Gateway
    {
      
        public int Save(Student aStudent)
        {


            //Connection = new SqlConnection(connectionString);

            Query = "INSERT INTO Students (Name, RegNo, ContactNo, Address, Email, DepartmentId) VALUES('" + aStudent.Name + "', '" + aStudent.RegNo + "', '" + aStudent.ContactNo + "', '" + aStudent.Address + "', '" + aStudent.Email + "', '" + aStudent.DepartmentId + "')";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            int rowAffected = Command.ExecuteNonQuery();

            Connection.Close();

            return rowAffected;
        }

        internal Student GetStudentById(int id)
        {
            Query = "SELECT * FROM Students WHERE Id = '" + id + "'";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            Student student = null;

            if (Reader.HasRows)
            {
                Reader.Read();
                student = new Student();

                student.Id = Convert.ToInt32(Reader["Id"]);
                student.RegNo = Reader["RegNo"].ToString();
                student.Name = Reader["Name"].ToString();
                student.ContactNo = Reader["ContactNo"].ToString();
                student.Address = Reader["Address"].ToString();
                student.Email = Reader["Email"].ToString();
                student.DepartmentId = Convert.ToInt32(Reader["DepartmentId"]);
            }

            Reader.Close();
            Connection.Close();

            return student;
        }

        internal int Delete(int id)
        {
            Query = "DELETE FROM Students WHERE Id=" + id;
            Command = new SqlCommand(Query, Connection);

            Connection.Open();
            int rowAffected = Command.ExecuteNonQuery();

            Connection.Close();

            return rowAffected;
        }

        public Student GetStudentByRegNo(string RegNo)
        {
            //Connection = new SqlConnection(connectionString);

            Query = "SELECT * FROM Students WHERE RegNo = '"+RegNo+"'";

            Command = new SqlCommand(Query,Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            Student student = null;

            if(Reader.HasRows)
            {
                Reader.Read();
                student = new Student();

                student.Id = Convert.ToInt32(Reader["Id"]);
                student.RegNo = Reader["RegNo"].ToString();
                student.Name = Reader["Name"].ToString();
                student.ContactNo = Reader["ContactNo"].ToString();
                student.Address = Reader["Address"].ToString();
                student.Email = Reader["Email"].ToString();
                student.DepartmentId = Convert.ToInt32(Reader["DepartmentId"]);
            }

            Reader.Close();
            Connection.Close();

            return student;

        }

        internal int Update(Student aStudent)
        {
            Query = "UPDATE Students SET Name='"+aStudent.Name+"', ContactNo='"+aStudent.ContactNo+"', Address='"+aStudent.Address+"', Email='"+aStudent.Email+"', DepartmentId='"+aStudent.DepartmentId+"' WHERE Id="+aStudent.Id;

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            int rowAffected = Command.ExecuteNonQuery();

            return rowAffected;

        }

        public List<StudentViewModel> GetAllStudents()
        {
            //Connection = new SqlConnection(connectionString);

            Query = "SELECT * FROM StudentDepartmentView";

            Command = new SqlCommand(Query, Connection);

            Connection.Open();

            Reader = Command.ExecuteReader();

            List<StudentViewModel> students = new List<StudentViewModel>();

            while(Reader.Read())
            {
                StudentViewModel student = new StudentViewModel();

                student.StudentId = Convert.ToInt32(Reader["StudentId"]);
                student.RegistrationNo = Reader["RegistrationNumber"].ToString();
                student.StudentName = Reader["StudentName"].ToString();
                student.ContactNumber = Reader["ContactNo"].ToString();
                student.Address = Reader["Address"].ToString();
                student.Email = Reader["Email"].ToString();
                student.DepartmentName = Reader["Name"].ToString();

               

                students.Add(student);

               

            }
            Reader.Close();
            Connection.Close();

            return students;

        }


    }
}