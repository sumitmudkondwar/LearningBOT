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
            if (!IsPostBack)
            {
                this.ClearAll();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            int retval = 0;
            try
            {
                DataAccessLayer.BusinessLogic.Subjects obj = new DataAccessLayer.BusinessLogic.Subjects();
                retval = obj.AddNewSubject(txtSubjectName.Text, txtSubjectDescription.Text);

                if (retval != 0)
                {
                    this.ClearAll();
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void ClearAll()
        {
            txtSubjectName.Text = string.Empty;
            txtSubjectDescription.Text = string.Empty;
        }
    }
}