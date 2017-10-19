using AccountContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AccountService.Controllers
{
    public class EntAccountController : ApiController
    {
        IEntAccountManager _manager;
        public EntAccountController(IEntAccountManager manager)
        {
            _manager = manager;
        }
        // GET: api/EntAccount
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/EntAccount/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/EntAccount
        public bool Post([FromBody]EntAccount entAccount)
        {
            return _manager.AddEntAccount(entAccount);
        }

        // POST: api/EntAccount
        [Route("ValidateEntAccount")]
        public bool ValidateEntAccount([FromBody]EntAccount entAccount)
        {
            return _manager.ValidateEntAccount(entAccount.UserName, entAccount.Password);
        }

        // PUT: api/EntAccount/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/EntAccount/5
        public void Delete(int id)
        {
        }
    }
}
