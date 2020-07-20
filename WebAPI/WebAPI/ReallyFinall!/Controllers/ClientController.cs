using Bll;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReallyFinall_.Controllers
{
    public class ClientController : ApiController
    {// GET: api/Client/5
        [Route("api/Client/GetClientByProductInStock/{itemInStockId}")]
        public IHttpActionResult Get(int itemInStockId)
        {
            return Ok(ClientFunctions.getClientByItemInstockId(itemInStockId));
        }

        // POST: api/Client
        //[Route("api/Client/AddClient")]
        //public void Post([FromBody] ClientDTO newClient)
        //{
        //    ClientFunctions.AddClient(newClient);
        //}
        // PUT: api/Client/5
        //[Route("api/Client/AddClient/{cd}")]
        //public void Put([FromBody] ClientDTO cd)
        //{
        //    ClientFunctions.UpdateClientDetails(cd);
        //}
    }
}
