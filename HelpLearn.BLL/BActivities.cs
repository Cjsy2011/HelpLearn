using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpLearn.Model;
using HelpLearn.IDAL;
using HelpLearn.Factory;

namespace HelpLearn.BLL
{
    public class BActivities
    {
        /// <summary>
        /// data base access layer interface
        /// </summary>
        private IActivities idal = DBFactory.GetActivitiesDAL();

        /// <summary>
        /// add one new activity
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public bool InsertNewOne(MActivities ma)
        {
            try
            {
                this.idal.InsertNewOne(ma);
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
            try
            {
                this.idal.DeleteOneActivity(id);
            }
            catch (Exception ex)
            {
                // write log

                return true;
            }

            return false;
        }

        /// <summary>
        /// update one activity
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        public bool UpdateOneActivity(MActivities ma)
        {
            try
            {
                this.idal.UpdateOneActivity(ma);
            }
            catch (Exception ex)
            {
                // write log

                return true;
            }

            return false;
        }
    }
}
