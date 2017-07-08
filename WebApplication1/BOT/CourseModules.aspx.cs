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
            int retval = 0;

            DataAccessLayer.BusinessLogic.CourseModules obj = new DataAccessLayer.BusinessLogic.CourseModules();
            DataAccessLayer.Models.CourseModules obj1 = new DataAccessLayer.Models.CourseModules();

            obj1.CourseId = ddlCourses.SelectedValue;
            obj1.ModuleName = txtModuleName.Text;
            obj1.Description = txtModuleDescription.Text;
            obj1.Abstract = txtAbstract.Text;
            obj1.Details = txtDetails.Text;
            obj1.Level = Convert.ToInt32(ddllevel.SelectedValue);
            obj1.Style = Convert.ToInt32(ddlStyle.SelectedValue);
            obj1.Duration = txtDuration.Text;
            obj1.LastUpdated = Convert.ToDateTime(txtLastUpdated.Text);
            obj1.Order = Convert.ToInt32(txtOrder.Text);

            retval = obj.AddNewCourseModules(obj1);

        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}