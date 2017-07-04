using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer.BusinessLogic;

namespace WebApplication1.BOT
{
    public partial class Subjects : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int retval = 0;
            DataAccessLayer.BusinessLogic.Subjects obj = new DataAccessLayer.BusinessLogic.Subjects();
            retval = obj.AddNewSubject(txtSubjectName.Text, txtSubjectDescription.Text);
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtSubjectName.Text = string.Empty;
            txtSubjectDescription.Text = string.Empty;
        }
    }
}