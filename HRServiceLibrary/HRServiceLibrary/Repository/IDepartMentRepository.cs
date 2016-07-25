using HRServiceLibrary.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRServiceLibrary.Repository
{
    /// <summary>
    /// 部門資料庫
    /// </summary>
    public interface IDepartMentRepository
    {
        IEnumerable<DepartMentModel> Get();
    }
}
