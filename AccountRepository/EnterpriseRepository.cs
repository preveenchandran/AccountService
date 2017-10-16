using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntContract = AccountContract;

namespace AccountRepository
{
    public class EnterpriseRepository: EntContract.IEnterpriseRepository
    {
        AccountEntities accountDbContext;
        public EnterpriseRepository()
        {
        }

        public IQueryable<EntContract.Enterprise> GetAllEnterprise()
        {
            accountDbContext = new AccountEntities();
            return from ent in accountDbContext.Enterprises
                   select new EntContract.Enterprise
                   {
                       Id = ent.Id,
                       Name = ent.Name,
                   };
        }

        public bool AddEnterprise(EntContract.Enterprise enterprise)
        {
            ICollection<Office> offices = new List<Office>();
            if(enterprise.Offices!=null)
            enterprise.Offices.ToList().ForEach(off => {
                offices.Add(new Office {
                    Name=off.Name
                });
            });
            
            Enterprise ent = new Enterprise
            {
                Name = enterprise.Name,
                Offices= offices
            };
            using (var accountDbContext = new AccountEntities())
            {
                accountDbContext.Enterprises.Add(ent);
                accountDbContext.SaveChanges();
                return true;
            }

        }

        public bool UpdateEnterprise(int entId, EntContract.Enterprise enterprise)
        {
            using (var accountDbContext = new AccountEntities())
            {
                Enterprise updateEnterPrise = (from ent in accountDbContext.Enterprises
                                         where ent.Id == entId
                                            select ent).FirstOrDefault();
                updateEnterPrise.Name = enterprise.Name;
                accountDbContext.SaveChanges();
                return true;
            }

        }

        /// <summary>
        /// Delete the Enterprise 
        /// </summary>
        /// <param name="patientId"></param>
        /// <returns>Success/Failure</returns>

        public bool DeleteEnterprise(int enterpriseId)
        {
            using (accountDbContext = new AccountEntities())
            {
                Enterprise entDelete = new Enterprise
                {
                    Id = enterpriseId
                };

                accountDbContext.Entry(entDelete).State = EntityState.Deleted;
                accountDbContext.SaveChanges();
                return true;
            }
        }
    }
}
