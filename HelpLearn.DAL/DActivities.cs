using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpLearn.IDAL;
using HelpLearn.Model;
using HelpLearn.Utilities;
using MySql.Data.MySqlClient;

namespace HelpLearn.DAL
{
    /// <summary>
    /// individual activities access layer
    /// </summary>
    public class DActivities : IActivities
    {
        /// <summary>
        /// add one new activity
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public bool InsertNewOne(MActivities ma)
        {
            try
            {
                MySqlParameter[] mysqlParams = {
                    new MySqlParameter("@Activity_id", MySqlDbType.Int32)
                };

                mysqlParams[0].Value = ma.Activity_id;

                string sqlString = "insert into ";
                HelpLearn.Utilities.MySqlHelper.ExecuteNonQuery(sqlString, mysqlParams);
            }
            catch (Exception ex)
            {
                // write log

                return true;
            }

            return false;
        }

        /// <summary>
        /// delete one activity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool DeleteOneActivity(int id)
        {
            return true;
        }

        /// <summary>
        /// update one activity
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public bool UpdateOneActivity(MActivities ma)
        {
            return true;
        }
    }
}
