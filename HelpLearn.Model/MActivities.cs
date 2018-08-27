using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelpLearn.Model
{
    /// <summary>
    /// MActivities
    /// </summary>
    public class MActivities
    {
        public string Activity_id
        {
            get;
            set;
        }

        public string Activity_name
        {
            get;
            set;
        }

        public string School_id
        {
            get;
            set;
        }

        public string Activity_desc
        {
            get;
            set;
        }

        /// <summary>
        /// 活动类型 ，枚举类型
        /// </summary>
        public string Activity_type
        {
            get;
            set;
        }

        public string Expire_start
        {
            get;
            set;
        }

        public string Expire_End
        {
            get;
            set;
        }

        public string Activity_Address
        {
            get;
            set;
        }

        public string Longitude_rate
        {
            get;
            set;
        }

        public string Dimension_rate
        {
            get;
            set;
        }

        public string School
        {
            get;
            set;
        }

        public string Activity_img_url
        {
            get;
            set;
        }

        public string Lecturer
        {
            get;
            set;
        }

        public string Lecturer_desc
        {
            get;
            set;
        }

        /// <summary>
        /// 活动规模人数
        /// </summary>
        public int Activity_Person_count
        {
            get;
            set;
        }

        /// <summary>
        /// 已报名人数
        /// </summary>
        public int Join_person_count
        {
            get;
            set;
        }

        /// <summary>
        /// 1:启用 0：禁用
        /// </summary>
        public int Status
        {
            get;
            set;
        }

        /// <summary>
        /// 1:需要 审核 0：不 需要审核
        /// </summary>
        public int Is_check
        {
            get;
            set;
        }

        /// <summary>
        /// 排序权重
        /// </summary>
        public int Sort_id
        {
            get;
            set;
        }

        /// <summary>
        /// 1:接受报名 0:不接受报名
        /// </summary>
        public int Is_accept_join
        {
            get;
            set;
        }

        public DateTime Join_time
        {
            get;
            set;
        }

        public DateTime Create_time
        {
            get;
            set;
        }

        public int IsDelete
        {
            get;
            set;
        }
    }
}
