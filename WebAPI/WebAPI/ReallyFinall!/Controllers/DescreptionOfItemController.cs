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
    public class DescreptionOfItemController : ApiController
    {
        // GET: api/Descreption
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };        }

        // GET: api/Descreption/5
        [Route("api/DescriptionOfItem/GetDescriptionOfItemListByItemId")]
        public IHttpActionResult GetDescriptionOfItemListByItemId(int itemId)
        {
            return Ok(DescriptionOfItemFunctions.getDescriptionOfItemListByItemId(itemId));
        }
        

        // POST: api/Descreption
        [Route(" api/DescriptionOfItem/AddDescriptinOfItemList")]
        public List<int> AddDescriptinOfItemList([FromBody] List<DescriptionOfItemDTO> descriptionOfItemDTOList)
        {
            return DescriptionOfItemFunctions.addDiscreptionOfItemList(descriptionOfItemDTOList);
        }


        // PUT: api/Descreption/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Descreption/5
        public void Delete(int id)
        {
        }
    }
}
