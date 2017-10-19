using OffContract = AccountContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountContract;

namespace AccountRepository
{
    public class OfficeRepository : IOfficeRepository
    {
        AccountEntities accountDbContext;
        public bool AddOffice(OffContract.Office office)
        {
            Office off = new Office
            {
                Name = office.Name,
                EntId = office.EntId
            };
            using (var accountDbContext = new AccountEntities())
            {
                accountDbContext.Offices.Add(off);
                accountDbContext.SaveChanges();
                return true;
            }
        }

        public bool DeleteOffice(int OfficeId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<OffContract.Office> GetAllOffice()
        {
            accountDbContext = new AccountEntities();
            return from off in accountDbContext.Offices
                   select new OffContract.Office
                   {
                       Id=off.Id,
                       Name=off.Name,
                       EntId=off.EntId
                   };
        }

        public bool UpdateOffice(int entId, OffContract.Office Office)
        {
            throw new NotImplementedException();
        }
    }
}
