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
    public partial class UpdateUI : System.Web.UI.Page
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

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            string regNo = regNoTextBox.Text;

            Student student = aStudentManager.GetStudentByRegNo(regNo);

            if (student == null)
            {
                idHiddenField.Value = string.Empty;
                nameTextBox.Text = string.Empty;
                contactNoTextBox.Text = string.Empty;
                addressTextBox.Text = string.Empty;
                emailTextBox.Text = string.Empty;
                departmentsDropDownList.SelectedValue = string.Empty;

                messageLabel.Text = "No student registered with this registration number";
            }

            else
            {
                messageLabel.Text = string.Empty;

                idHiddenField.Value = student.Id.ToString();
                nameTextBox.Text = student.Name;
                contactNoTextBox.Text = student.ContactNo;
                addressTextBox.Text = student.Address;
                emailTextBox.Text = student.Email;
                departmentsDropDownList.SelectedValue = student.DepartmentId.ToString();
            }
        }

        protected void updateButton_Click(object sender, EventArgs e)
        {
            
            Student aStudent = new Student();
            aStudent.Id = Convert.ToInt32(idHiddenField.Value);
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