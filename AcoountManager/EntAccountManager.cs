using AccountContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    public class EntAccountManager : IEntAccountManager
    {
        IEntAccountRepository _repository;
        public EntAccountManager(IEntAccountRepository repository)
        {
            _repository = repository;
        }
        public bool AddEntAccount(EntAccount entAccount)
        {
            return _repository.AddEntAccount(entAccount);
        }

        public bool ValidateEntAccount(string userName, string password)
        {
            return _repository.ValidateEntAccount(userName, password);
        }
    }
}
