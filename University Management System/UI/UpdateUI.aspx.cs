using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using University_Management_System.Manager;
using University_Management_System.Model;

namespace University_Management_System.UI
{
    public partial class UpdateUI1 : System.Web.UI.Page
    {
        StudentManager aStudentManager = new StudentManager();

        DepartmentManager aDepartmentManager = new DepartmentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            List<Department> departments = aDepartmentManager.GetAllDepartments();

            departmentsDropDownList.DataSource = departments;
            departmentsDropDownList.DataTextField = "Name";
            departmentsDropDownList.DataValueField = "DepartmentId"; // From Class Property
            departmentsDropDownList.DataBind();

            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Request.QueryString["id"]);

                Student student = aStudentManager.GetStudentById(id);

                if (student != null)
                {
                    LoadFromWithStudents(student);
                }
            }

            
        }

        private void LoadFromWithStudents(Student student)
        {
            idHiddenField.Value = student.Id.ToString();
            regNoTextBox.Text = student.RegNo;
            nameTextBox.Text = student.Name;
            addressTextBox.Text = student.Address;
            contactNoTextBox.Text = student.ContactNo;
            emailTextBox.Text = student.Email;
            departmentsDropDownList.SelectedValue = student.DepartmentId.ToString();
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            Student aStudent = new Student();

            if (idHiddenField.Value != string.Empty)
            {
                aStudent.Id = Convert.ToInt32(idHiddenField.Value);
            }

            
            aStudent.Name = nameTextBox.Text;
            aStudent.ContactNo = contactNoTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.DepartmentId = Convert.ToInt32(departmentsDropDownList.SelectedValue);

            string message = aStudentManager.Update(aStudent);

            messageLabel.Text = message;
        }
    }

}