using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.BOT
{
    public partial class SubjectsBulk : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataAccessLayer.BusinessLogic.Subjects subjects = new DataAccessLayer.BusinessLogic.Subjects();
            grdSubjects.DataSource = subjects.GetSubjects();
            grdSubjects.DataBind();
        }

        protected void grdSubjects_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}