using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRServiceLibrary.Repository.Model
{
    /// <summary>
    /// 人員資料庫模型
    /// </summary>
    public class PersonModel
    {
        /// <summary>
        /// 唯一值
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 員工編號
        /// </summary>
        public string Empno { get; set; }

        /// <summary>
        /// 員工姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 是否離職 true:是 false:否
        /// </summary>
        public bool IsGoAway { get; set; }

        /// <summary>
        /// 身分證字號
        /// </summary>
        public string IdentityCard { get; set; }

        /// <summary>1
        /// 部門代號
        /// </summary>
        public string Dpt { get; set; }

        /// <summary>
        /// 職稱
        /// </summary>
        public string JobTitle { get; set; }
    }
}
