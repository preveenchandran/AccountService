using System.Collections.Generic;

namespace AccountContract
{
    public class EntAccount
    {
        public int EntAccountId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public ICollection<Office> Offices { get; set; }
    }
}