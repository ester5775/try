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
    public class CategoryController : ApiController
    {



        // POST: api/Category
        [Route("api/Category/AddCategory")]
        public void Post([FromBody]CategoryDTO cd)
        {
            CategoryFunctions.AddCategory(cd);
        }
        [Route("api/Category/getAll")]
        public string getAll()
        {
            return "wow";
        }


    }
}
