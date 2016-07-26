using HRServiceLibrary.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRServiceLibrary.Service.Model;
using HRServiceLibrary.Repository.Model;

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
        /// <param name="condition">人員資訊查詢條件</param>
        /// <returns></returns>
        public IEnumerable<PersonInfo> Get(PsersonCondition condition)
        {
            var person = _PresonRepository.Get();
            var departMent = _DepartMentRepository.Get();

            var dpt = new DepartMentModel();
            var list = new List<PersonInfo>();

            foreach (var item in person)
            {
                dpt = departMent.FirstOrDefault(f => f.Dpt == item.Dpt);
                list.Add(new PersonInfo()
                {
                    DptName = dpt.Name,
                    Empno = item.Empno,
                    JobTitle = item.JobTitle,
                    UserName = item.Name
                });
            }

            return list.OrderBy(o=>o.Empno);
        }
    }
}
