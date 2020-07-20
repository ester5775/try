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
    public class DescriptionOfItemInStockController : ApiController
    {
        //[Route("api/DescriptionOfItemInStock/GetItemInStockBuyingOrSellingNameListByItemId/{itemId}")]
        // GET: api/DescriptionOfItemInStock

        [Route("api/DescriptionOfItemInStock/GetItemInStockBuyingOrSellingNameListByItemId/{itemId}/{isBuying}")]
        public IHttpActionResult GetItemInStockBuyingOrSellingNameListByItemId(int itemId,int isBuying)
        {
            return Ok(DescriptionOfItemInStockFunctions.getItemInStockBuyingOrSellingNameListByItemId(itemId,isBuying));
        }

        //public IHttpActionResult GetItemInStockSellingNameListByItemId(int itemId)
        //{
        //    return Ok(DescriptionOfItemInStockFunctions.getItemInStockSellingNameListByItemId(itemId));
        //}

        [Route("api/DescriptionOfItemInStock/GetAllDetailsOfItemInStockByItemInStockId/{itemInStockId}")]
        public IHttpActionResult GetAllDetailsOfItemInStockByItemInStockId(int itemInStockId)
        {
            return Ok(DescriptionOfItemInStockFunctions.getAllDetailsOfItemInStockByItemInStockId(itemInStockId));
        }

        // GET: api/DescriptionOfItemInStock/5
        public string Get(int id)
        {
            return "value";
        }
        
        // POST: api/Descreption
        [Route("api/DescreptionOfItemInStock/AddDiscreptionOfItemInStock")]
        public void AddDiscreptionOfItemInStock([FromBody] DescriptionOfItemInStockDTO descriptionOfItemInStockDTO)
        {
            DescriptionOfItemInStockFunctions.addDiscreptionOfItemInStock(descriptionOfItemInStockDTO);
        }

        // POST: api/DescriptionOfItemInStock
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DescriptionOfItemInStock/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DescriptionOfItemInStock/5
        public void Delete(int id)
        {
        }
    }
}
