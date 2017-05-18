using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Legacy.LogApi.Data;

namespace Legacy.LogApi.Controllers
{
    public class LogController : ApiController
    {
        // GET: api/Log
        public IEnumerable<string> Get()
        {
            return InMemoryDataStore.Get();
        }

        // GET: api/Log/5
        public string Get(int id)
        {
            return InMemoryDataStore.Get()[id];
        }

        // POST: api/Log
        public HttpResponseMessage Post([FromBody]string value)
        {
            try
            {
                InMemoryDataStore.Add("<" + DateTime.Now + "> " + value);

                // Common practice in REST is to return the location of the new resource
                var response = Request.CreateResponse(HttpStatusCode.Created);
                response.Headers.Location = new Uri(Request.RequestUri + "/" + (InMemoryDataStore.Get().Count - 1));
                return response;
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        // PUT: api/Log/5
        public void Put(int id, [FromBody]string value)
        {
            throw new NotImplementedException("Cannot Modify Entires in the Log.");
        }

        // DELETE: api/Log/5
        public void Delete(int id)
        {
            throw new NotImplementedException("Cannot Delete Anything in the Log.");
        }
    }
}
