using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelpLearn.IDAL;
using HelpLearn.DAL;

namespace HelpLearn.Factory
{
    /// <summary>
    /// get the data base access layer
    /// </summary>
    public class DBFactory
    {
        /// <summary>
        /// get the activity data base access layer
        /// </summary>
        /// <returns></returns>
        public static IActivities GetActivitiesDAL()
        {
            return new DActivities(); 
        }
    }
}
