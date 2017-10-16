using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntContract = AccountContract;

namespace AccountContract
{
    public interface IEnterpriseRepository
    {
        IQueryable<EntContract.Enterprise> GetAllEnterprise();
        bool AddEnterprise(EntContract.Enterprise enterprise);

        bool UpdateEnterprise(int entId, EntContract.Enterprise enterprise);

        bool DeleteEnterprise(int enterpriseId);
    }
}
