using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GovernmentalInformation.Model
{
    [Serializable]
    /// <summary>
    /// 部门
    /// </summary>
    public class Department
    {
        /// <summary>
        /// 部门编码
        /// </summary>
        public int DepartmentID { get; set; }

        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 部门排序ID
        /// </summary>
        public int DepartmentSortID { get; set; }

        public string DepartPath { get; set; }

        public override string ToString()
        {
            return this.DepartmentName;
        }
    }
}
