using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRServiceLibrary.Service.Model
{
    /// <summary>
    /// 人員資訊
    /// </summary>
    public class PersonInfo
    {
        /// <summary>
        /// 員工編號
        /// </summary>
        public string Empno { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// 部門名稱
        /// </summary>
        public string DptName { get; set; }

        /// <summary>
        /// 職稱
        /// </summary>
        public string JobTitle { get; set; }
    }
}
