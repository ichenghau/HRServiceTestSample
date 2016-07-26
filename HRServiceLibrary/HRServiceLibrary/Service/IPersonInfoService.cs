using HRServiceLibrary.Service.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRServiceLibrary.Service
{
    /// <summary>
    /// 人員資訊服務
    /// </summary>
    public interface IPersonInfoService
    {
        /// <summary>
        /// 取得人員資訊
        /// </summary>
        /// <param name="condition">人員資訊查詢條件</param>
        /// <returns></returns>
        IEnumerable<PersonInfo> Get(PsersonCondition condition);
    }
}
