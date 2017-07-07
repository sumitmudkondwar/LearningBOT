using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.BOT
{
    public partial class CourseModules : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccessLayer.BusinessLogic.Courses courses = new DataAccessLayer.BusinessLogic.Courses();
            ddlCourses.DataTextField = "CourseName";
            ddlCourses.DataValueField = "CourseId";
            ddlCourses.DataSource = courses.GetCourses();
            ddlCourses.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}