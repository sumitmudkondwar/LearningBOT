using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.BusinessLogic
{
    public class CourseModules
    {
        public int AddNewCourseModules(Models.CourseModules courseModules)
        {
            int retval = 0;
            try
            {
                SqlParameter[] sqlParameter = new SqlParameter[]
                    {
                        new SqlParameter("@p_ModuleName", courseModules.ModuleName),
                        new SqlParameter("@p_Description", courseModules.Description),
                        new SqlParameter("@p_Abstract", courseModules.Abstract),
                        new SqlParameter("@p_Details", courseModules.Details),
                        new SqlParameter("@p_CourseId", courseModules.CourseId),
                        new SqlParameter("@p_Level", courseModules.Level),
                        new SqlParameter("@p_Style", courseModules.Style),
                        new SqlParameter("@p_Duration", courseModules.Duration),
                        new SqlParameter("@p_LastUpdated", courseModules.LastUpdated),
                        new SqlParameter("@p_Order", courseModules.Order),
                    };
                retval = DataAccess.DataAccess.executeInsertQuery("pr_Insert_CourseModules", sqlParameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retval;
        }

        public DataTable GetCourseModules()
        {
            DataTable dt = new DataTable();

            SqlParameter[] sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@p_SubjectId", "val"),
                };
            dt = DataAccess.DataAccess.executeGetDataTable("select ModuleId,ModuleName from CourseModules", sqlParameter);

            return dt;
        }
    }
}
