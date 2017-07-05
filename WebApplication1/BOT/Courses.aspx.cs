using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer.BusinessLogic;
using DataAccessLayer.DataAccess;
using DataAccessLayer.Models;
using DataAccessLayer;

namespace WebApplication1.BOT
{
    public partial class Courses : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccessLayer.BusinessLogic.Subjects subjects = new DataAccessLayer.BusinessLogic.Subjects();
            ddlSubjectName.DataTextField = "Name";
            ddlSubjectName.DataValueField = "SubjectId";
            ddlSubjectName.DataSource = subjects.GetSubjects();
            ddlSubjectName.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int retval = 0;

            DataAccessLayer.BusinessLogic.Courses obj = new DataAccessLayer.BusinessLogic.Courses();
            DataAccessLayer.Models.Courses obj1 = new DataAccessLayer.Models.Courses();

            obj1.SubjectId = ddlSubjectName.SelectedValue;
            obj1.Source = Convert.ToInt32(ddlSource.SelectedValue);
            obj1.CourseName = txtCourseName.Text;
            obj1.Description = txtCourseDescription.Text;
            obj1.Abstract = txtAbstract.Text;
            obj1.CourseAudience = Convert.ToInt32(ddlCourseAudience.SelectedValue);
            obj1.CourseDuration = txtCourseDuration.Text;
            obj1.Level = Convert.ToInt32(ddlLevel.SelectedValue);
            obj1.Rating = Convert.ToInt32(ddlRating.SelectedValue);
            obj1.RatingCount = Convert.ToInt32(txtRatingCount.Text);
            obj1.Author = txtAuthor.Text;
            obj1.CourseDate = Convert.ToDateTime(txtCourseDate.Text);

            retval = obj.AddNewCourses(obj1);
            
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtCourseName.Text = string.Empty;
            txtCourseDescription.Text = string.Empty;
            txtAbstract.Text = string.Empty;
            txtCourseDuration.Text = string.Empty;
            txtRatingCount.Text = string.Empty;
            txtAuthor.Text = string.Empty;
            txtCourseDate.Text = string.Empty;
        }
    }
}