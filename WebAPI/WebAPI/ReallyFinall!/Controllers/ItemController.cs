using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReallyFinall_.Controllers
{
    public class ItemController : ApiController
    {
                  
           [Route("api/Item/GetItemByItemName/{itemName}")]
        // GET: api/Item
        public IHttpActionResult GetItemByItemName(string itemName)
        {
            return Ok(ItemFunctions.getItemByItemName(itemName));
        }

        // GET: api/Item/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Item
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Item/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Item/5
        public void Delete(int id)
        {
        }
    }
}
