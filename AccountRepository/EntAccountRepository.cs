using AccountContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntActContract = AccountContract;

namespace AccountRepository
{
    public class EntAccountRepository : IEntAccountRepository
    {
        public bool AddEntAccount(EntActContract.EntAccount entAccount)
        {
            EntAccount entAct = new EntAccount
            {
                UserName = entAccount.UserName,
                Password = entAccount.Password
            };
            using (var accountDbContext = new AccountEntities())
            {
                accountDbContext.EntAccounts.Add(entAct);
                accountDbContext.SaveChanges();
                return true;
            }
        }

        public bool DeleteEntAccount(int entAccountId)
        {
            throw new NotImplementedException();
        }

        public IQueryable<EntActContract.EntAccount> GetAllEntAccount()
        {
            throw new NotImplementedException();
        }

        public bool ValidateEntAccount(string userName, string password)
        {
            bool validCustomer = false;
            using (var accountDbContext = new AccountEntities())
            {
                validCustomer = accountDbContext.EntAccounts.Any(act => act.UserName == userName && act.Password == password);
            }
            return validCustomer;
        }

        public bool UpdateEntAccount(int entId, EntActContract.EntAccount entAccount)
        {
            throw new NotImplementedException();
        }
    }
}
