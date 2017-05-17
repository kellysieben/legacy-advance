using System.Collections.Generic;
using System.Web.Http;

namespace Legacy.LogApi.Controllers
{
    public class LogController : ApiController
    {
        private readonly List<string> _vals = new List<string>();

        // GET: api/Log
        public IEnumerable<string> Get()
        {
            return _vals;
        }

        // GET: api/Log/5
        public string Get(int id)
        {
            return _vals[id];
        }

        // POST: api/Log
        public void Post([FromBody]string value)
        {
            _vals.Add(value);
        }

        // PUT: api/Log/5
        public void Put(int id, [FromBody]string value)
        {
            _vals[id] = value;
        }

        // DELETE: api/Log/5
        public void Delete(int id)
        {
        }
    }
}
