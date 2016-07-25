using HRServiceLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRServiceLibrary.Service.Model;

namespace HRServiceLibrary.Service
{
    /// <summary>
    /// 人員資訊服務
    /// </summary>
    public class PersonInfoService : IPersonInfoService
    {
        public IPresonRepository _PresonRepository { get; set; }
        public IDepartMentRepository _DepartMentRepository { get; set; }

        public PersonInfoService(IPresonRepository PresonRepository, IDepartMentRepository DepartMentRepository)
        {
            _PresonRepository = PresonRepository;
            _DepartMentRepository = DepartMentRepository;
        }

        /// <summary>
        /// 取得人員資訊
        /// </summary>
        /// <returns></returns>
        public IEnumerable<PersonInfo> Get()
        {
            throw new NotImplementedException();
        }
    }
}
