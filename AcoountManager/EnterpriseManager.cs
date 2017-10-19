using AccountContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    public class EnterpriseManager : IEnterpriseManager
    {
        private IEnterpriseRepository _repository;

        public EnterpriseManager(IEnterpriseRepository repository)
        {
            _repository = repository;
        }
        public bool AddEnterprise(Enterprise enterprise)
        {
            return _repository.AddEnterprise(enterprise);
;        }

        public bool DeleteEnterprise(int enterpriseId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Enterprise> GetAllEnterprise()
        {
            return _repository.GetAllEnterprise();
        }

        public bool UpdateEnterprise(int entId, Enterprise enterprise)
        {
            throw new NotImplementedException();
        }
    }
}
