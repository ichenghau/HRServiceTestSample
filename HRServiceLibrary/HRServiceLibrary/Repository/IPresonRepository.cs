using HRServiceLibrary.Repository.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRServiceLibrary.Repository
{
    /// <summary>
    /// 人員資料庫
    /// </summary>
    public interface IPresonRepository
    {
        IEnumerable<PersonModel> Get();
    }
}
