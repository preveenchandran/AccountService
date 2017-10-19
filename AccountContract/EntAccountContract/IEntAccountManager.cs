using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountContract
{
    public interface IEntAccountManager
    {
        bool AddEntAccount(EntAccount entAccount);

        bool ValidateEntAccount(string userName, string password);
    }
}
