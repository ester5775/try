using Bll;
using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ReallyFinall_.Controllers
{
    public class AddressController : ApiController
    {
        DataEntities d = new DataEntities();
        [Route("api/Address/Get")]
        // GET: api/Default
        public IHttpActionResult Get()
        {
            return Ok(AddressFunctions.city());
        }
    }
}