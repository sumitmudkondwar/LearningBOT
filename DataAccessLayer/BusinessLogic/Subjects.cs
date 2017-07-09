using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer.BusinessLogic
{
    public class Subjects
    {
        public int AddNewSubject(string SubjectName, string SubjectDescription)
        {
            int retval = 0;
            try
            {
                SqlParameter[] sqlParameter = new SqlParameter[]
                    {
                        new SqlParameter("@p_SubjectName", SubjectName),
                        new SqlParameter("@p_SubjectDescription", SubjectDescription)
                    };
                retval = DataAccess.DataAccess.executeInsertQuery("pr_Insert_Subject", sqlParameter);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return retval;
        }

        public DataTable GetSubjects()
        {
            DataTable dt = new DataTable();

            SqlParameter[] sqlParameter = new SqlParameter[]
                {
                    new SqlParameter("@p_Alias", "test"),
                };
            dt = DataAccess.DataAccess.executeGetDataTable("select SubjectId,Name,Description from Subjects", sqlParameter);

            return dt;
        }
    }
}
