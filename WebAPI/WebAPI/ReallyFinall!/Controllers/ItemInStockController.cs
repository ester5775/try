using Bll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReallyFinall_.Controllers
{
    public class ItemInStockController : ApiController
    {
        
        [Route("api/ItemInStock/GetMainDescriptionsOfItemInStockListByItemId/{itemId}")]
        // GET: api/ItemInStock
        public IHttpActionResult GetMainDescriptionsOfItemInStockListByItemId(int itemId)
        {
            return Ok(ItemInStockFunctions.getItemInStockListByItemId(itemId));
        }       
  
        // POST: api/ItemInStock
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ItemInStock/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ItemInStock/5
        public void Delete(int id)
        {
        }
    }
}
