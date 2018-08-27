using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpLearn.Model;

namespace HelpLearn.IDAL
{
    /// <summary>
    /// interface of activities access layer
    /// </summary>
    public interface IActivities
    {
        /// <summary>
        /// add one new activity
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        bool InsertNewOne(MActivities ma);

        /// <summary>
        /// delete one activity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool DeleteOneActivity(int id);

        /// <summary>
        /// update one activity
        /// </summary>
        /// <param name="ma"></param>
        /// <returns></returns>
        bool UpdateOneActivity(MActivities ma);
    }
}
