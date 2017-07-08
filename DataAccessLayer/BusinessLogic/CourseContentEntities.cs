using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.BusinessLogic
{
    public class CourseContentEntities
    {
        public int AddNewCourseContentEntities(Models.CourseContentEntities courseContentEntities)
        {
            int retval = 0;
            try
            {
                SqlParameter[] sqlParameter = new SqlParameter[]
                    {
                        new SqlParameter("@p_ModuleId", courseContentEntities.ModuleId),
                        new SqlParameter("@p_Name", courseContentEntities.Name),
                        new SqlParameter("@p_Duration", courseContentEntities.Duration),
                        new SqlParameter("@p_Uri", courseContentEntities.Uri),
                        new SqlParameter("@p_Order", courseContentEntities.Order),
                        new SqlParameter("@p_Style", courseContentEntities.Style),
                    };
                retval = DataAccess.DataAccess.executeInsertQuery("pr_Insert_CourseContentEntities", sqlParameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retval;
        }
    }
}
