using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.BusinessLogic
{
    public class Courses
    {
        public int AddNewCourses(Models.Courses course)
        {
            int retval = 0;
            try
            {
                SqlParameter[] sqlParameter = new SqlParameter[]
                    {
                        new SqlParameter("@p_SubjectId", course.SubjectId),
                        new SqlParameter("@p_Source", course.Source),
                        new SqlParameter("@p_CourseName", course.CourseName),
                        new SqlParameter("@p_Description", course.Description),
                        new SqlParameter("@p_Abstract", course.Abstract),
                        new SqlParameter("@p_CourseAudience", course.CourseAudience),
                        new SqlParameter("@p_courseDuration", course.CourseDuration),
                        new SqlParameter("@p_Level", course.Level),
                        new SqlParameter("@p_Rating", course.Rating),
                        new SqlParameter("@p_RatingCount", course.RatingCount),
                        new SqlParameter("@p_Author", course.Author),
                        new SqlParameter("@p_CourseDate", course.CourseDate),
                    };
                retval = DataAccess.DataAccess.executeInsertQuery("pr_Insert_Courses", sqlParameter);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return retval;
        }

        public DataTable GetCourses(int SubjectId)
        {
            DataTable dt = new DataTable();

            SqlParameter[] sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@p_SubjectId", SubjectId),
                };
            dt = DataAccess.DataAccess.executeGetDataTable("select * from Courses where SubjectId = @p_SubjectId", sqlParameter);

            return dt;
        }
    }
}
