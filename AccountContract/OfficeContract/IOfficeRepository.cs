using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OffContract = AccountContract;

namespace AccountContract
{
    public interface IOfficeRepository
    {
        IQueryable<OffContract.Office> GetAllOffice();
        bool AddOffice(OffContract.Office Office);

        bool UpdateOffice(int entId, OffContract.Office Office);

        bool DeleteOffice(int OfficeId);
    }
}
