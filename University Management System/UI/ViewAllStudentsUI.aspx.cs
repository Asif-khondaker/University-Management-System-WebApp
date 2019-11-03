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
    public partial class ViewAllStudentsUI : System.Web.UI.Page
    {

        StudentManager aStudentManager = new StudentManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void PopulateGridView()
        {
            List<StudentViewModel> students = aStudentManager.GetAllStudents();
            studentsGridView.DataSource = students;
            studentsGridView.DataBind();
        }

        protected void deleteLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton deleteLinkButton = sender as LinkButton;
            DataControlFieldCell cell = deleteLinkButton.Parent as DataControlFieldCell;
            GridViewRow selectRow = cell.Parent as GridViewRow;
            HiddenField selectedIdHiddenField = selectRow.FindControl("IdHiddenfield") as HiddenField;

            int id = Convert.ToInt32(selectedIdHiddenField.Value);

            string message = aStudentManager.Delete(id);

            Response.Write(message);

            PopulateGridView();
        }


        protected void updateLinkButton_Click(object sender, EventArgs e)
        {
            LinkButton updateLinkButton = sender as LinkButton;
            DataControlFieldCell cell = updateLinkButton.Parent as DataControlFieldCell;
            GridViewRow selectRow = cell.Parent as GridViewRow;
            HiddenField selectedIdHiddenField = selectRow.FindControl("IdHiddenfield") as HiddenField;

            int id = Convert.ToInt32(selectedIdHiddenField.Value);

            Response.Redirect("UpdateUI.aspx?id=" + id);
        }

    }
}