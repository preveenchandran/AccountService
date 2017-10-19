using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntActContract = AccountContract;

namespace AccountContract
{
    public interface IEntAccountRepository
    {
        IQueryable<EntActContract.EntAccount> GetAllEntAccount();
        bool AddEntAccount(EntActContract.EntAccount entAccount);

        bool UpdateEntAccount(int entId, EntActContract.EntAccount entAccount);

        bool ValidateEntAccount(string userName, string password);

        bool DeleteEntAccount(int entAccountId);
    }
}
