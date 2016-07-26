using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRServiceLibrary.Service.Model
{
    /// <summary>
    /// 人員資訊查詢條件
    /// </summary>
    public class PsersonCondition
    {
        /// <summary>
        /// 是否包含離職 true:含離職  false:不含離職
        /// </summary>
        public bool IsIncludeGoAway { get; set; }
    }
}
