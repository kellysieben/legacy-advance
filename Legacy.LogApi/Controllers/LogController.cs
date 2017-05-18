using System;
using System.Collections.Generic;
using System.Web.Http;
using Legacy.LogApi.Data;

namespace Legacy.LogApi.Controllers
{
    public class LogController : ApiController
    {
        private readonly InMemoryDataStore _vals = new InMemoryDataStore();

        // GET: api/Log
        public IEnumerable<string> Get()
        {
            return _vals.Get();
        }

        // GET: api/Log/5
        public string Get(int id)
        {
            throw new NotImplementedException("Specific Gets Are Not Allowed.");
        }

        // POST: api/Log
        public void Post([FromBody]string value)
        {
            _vals.Add("<" + DateTime.Now + "> " + value);
            //return CreatedAtRoute();
        }

        // PUT: api/Log/5
//        public void Put(int id, [FromBody]string value)
//        {
//            _vals[id] = value;
//        }

        // DELETE: api/Log/5
        public void Delete(int id)
        {
            throw new NotImplementedException("Cannot Delete Anything In This Log");
        }
    }
}
