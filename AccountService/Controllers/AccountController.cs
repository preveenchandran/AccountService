using AccountContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AccountService.Controllers
{
    public class AccountController : ApiController
    {
        private IEnterpriseManager _manager;

        public AccountController(IEnterpriseManager manager)
        {
            _manager = manager;
        }
        // GET api/<controller>
        public IEnumerable<Enterprise> Get()
        {
            return _manager.GetAllEnterprise();
        }

        // GET api/<controller>/5
        public IEnumerable<Enterprise> Get(int id)
        {
            return _manager.GetAllEnterprise();
        }

        // POST api/<controller>
        public bool Post([FromBody]Enterprise enterprise)
        {
            return _manager.AddEnterprise(enterprise);
        }

        // PUT api/<controller>/5
        public bool Put(int id, [FromBody]Enterprise enterprise)
        {
            return _manager.UpdateEnterprise(id, enterprise);
        }

        // DELETE api/<controller>/5
        public bool Delete(int id)
        {
            return _manager.DeleteEnterprise(id);
        }
    }
}