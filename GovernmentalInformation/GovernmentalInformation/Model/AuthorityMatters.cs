using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GovernmentalInformation.Model
{
    [Serializable]
    /// <summary>
    /// 职权事项
    /// </summary>
    public class AuthorityMattery
    {
        /// <summary>
        /// 职权事项ID
        /// </summary>
        public int AuthorityMatteryID { get; set; }
        /// <summary>
        /// 职权事项
        /// </summary>
        public string AuthorityMatteryName { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        public Department Department { get; set; }

        /// <summary>
        /// 分类
        /// </summary>
        public AdministrativeCategory AdministrativeCategory { get; set; }

        /// <summary>
        /// 子项
        /// </summary>
        public List<AuthorityMatteryDetail> AuthorityMatteryDetail { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}]{1}\t[{2}子项]", Department.DepartmentName, AuthorityMatteryName, AuthorityMatteryDetail.Count > 1 ? AuthorityMatteryDetail.Count.ToString() : "无");
        }
    }

    [Serializable]
    public class AuthorityMatteryDetail
    {
        /// <summary>
        /// 职权编码
        /// </summary>
        public string AuthorityCode
        {
            get
            {
                if (AuthorityDetail.FindIndex(c => c.AuthorityMatteryTitle == "职权编码") > 0)
                {
                    return AuthorityDetail.Find(c => c.AuthorityMatteryTitle == "职权编码").AuthorityMatteryContent.Trim();
                }
                else
                {
                    return "";
                }
            }
        }

        /// <summary>
        /// 职权名称
        /// </summary>

        public string AuthorityName { get; set; }
        /// <summary>
        /// 职权明细
        /// </summary>

        public List<AuthorityDetail> AuthorityDetail { get; set; }
        /// <summary>
        /// 流程图
        /// </summary>
        public AuthorityMatteryFlow AuthorityMatteryFlow { get; set; }

        public string AuthorityFullName { get; set; }
        public override string ToString()
        {
            return string.Format("[{0}]{1}", AuthorityCode, AuthorityFullName);
        }
    }

    [Serializable]
    public class AuthorityDetail
    {
        /// <summary>
        /// 职权标题
        /// </summary>
        public string AuthorityMatteryTitle { get; set; }
        /// <summary>
        /// 职权内容
        /// </summary>
        public string AuthorityMatteryContent { get; set; }
    }

    [Serializable]
    /// <summary>
    /// 流程图
    /// </summary>
    public class AuthorityMatteryFlow
    {
        /// <summary>
        /// 流程图ID
        /// </summary>
        public int AuthorityMatteryFlowID { get; set; }
        /// <summary>
        /// 流程图
        /// </summary>
        public System.Drawing.Image AuthorityMatteryFlowImage { get; set; }
        /// <summary>
        /// 流程图排序编码
        /// </summary>
        public string FlowInagePath { get; set; }
    }
}
