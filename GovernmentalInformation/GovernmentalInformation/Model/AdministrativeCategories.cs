using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GovernmentalInformation.Model
{
    [Serializable]
    /// <summary>
    /// 行政类别
    /// </summary>
    public class AdministrativeCategory
    {
        /// <summary>
        /// 行政类别编码
        /// </summary>
        public int AdministrativeCategoryID { get; set; }
        /// <summary>
        /// 行政类别名称
        /// </summary>
        public string AdministrativeCategoryName { get; set; }
        /// <summary>
        /// 行政列表SortID
        /// </summary>
        public int AdministrativeCategorySortID { get; set; }

        public Department Department { get; set; }

        public string CategoryPath { get; set; }

        public override string ToString()
        {
            return this.AdministrativeCategoryName;
        }
    }
}
