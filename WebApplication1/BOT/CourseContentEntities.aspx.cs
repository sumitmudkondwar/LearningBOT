using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.BOT
{
    public partial class CourseContentEntities : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccessLayer.BusinessLogic.CourseModules courses = new DataAccessLayer.BusinessLogic.CourseModules();
            ddlCourseModule.DataTextField = "ModuleName";
            ddlCourseModule.DataValueField = "ModuleId";
            ddlCourseModule.DataSource = courses.GetCourseModules();
            ddlCourseModule.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int retval = 0;

            DataAccessLayer.BusinessLogic.CourseContentEntities obj = new DataAccessLayer.BusinessLogic.CourseContentEntities();
            DataAccessLayer.Models.CourseContentEntities obj1 = new DataAccessLayer.Models.CourseContentEntities();

            obj1.ModuleId = ddlCourseModule.SelectedValue;
            obj1.Name = txtEntityName.Text;
            obj1.Duration = txtDuration.Text;
            obj1.Uri = txtURI.Text;
            obj1.Order = Convert.ToInt32(txtOrder.Text);
            obj1.Style = Convert.ToInt32(ddlStyle.SelectedValue);
            
            retval = obj.AddNewCourseContentEntities(obj1);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtEntityName.Text = string.Empty;
            txtDuration.Text = string.Empty;
            txtURI.Text = string.Empty;
            txtOrder.Text = string.Empty;
            ddlStyle.SelectedValue = "1";
        }
    }
}