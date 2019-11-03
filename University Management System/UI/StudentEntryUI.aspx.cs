using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using University_Management_System.Manager;
using University_Management_System.Model;

namespace University_Management_System
{
    public partial class StudentEntryUI : System.Web.UI.Page
    {
        DepartmentManager aDepartmentManager = new DepartmentManager();
        StudentManager aStudentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                List<Department> departments = aDepartmentManager.GetAllDepartments();

                departmentsDropDownList.DataSource = departments;
                departmentsDropDownList.DataTextField = "Name";
                departmentsDropDownList.DataValueField = "DepartmentId"; // From Class Property
                departmentsDropDownList.DataBind();
            }

            
        }

        protected void saveButton_Click(object sender, EventArgs e)
        {

            Student aStudent = new Student();

            aStudent.RegNo = regNoTextBox.Text;
            aStudent.Name = nameTextBox.Text;
            aStudent.ContactNo = contactNoTextBox.Text;
            aStudent.Address = addressTextBox.Text;
            aStudent.Email = emailTextBox.Text;
            aStudent.DepartmentId = Convert.ToInt32(departmentsDropDownList.SelectedValue);

            messageLabel.Text = aStudentManager.Save(aStudent);
 
        }
    }
}