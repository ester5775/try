using Dal;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class ItemInStockFunctions
    {
        static DataEntities data = new DataEntities();
        public static List<ItemInStockDTO> getItemInStockListByItemId(int itemId)
        {
            List<ItemInStockDTO> listItemInStock = new List<ItemInStockDTO>();            
            listItemInStock = ItemInStockDTO.ConvertToListOfDTO(data.ItemInStock.Where(x => x.ItemId == itemId).ToList());
            return listItemInStock;
        }
        public static List<int> getItemInStockIdListByItemId(int itemId)
        {
            List<int> itemInStockIdList = new List<int>();
            itemInStockIdList=getItemInStockListByItemId(itemId).Select(x => x.ItemInStockId).ToList();
            return itemInStockIdList;
        }
        public static List<int> getItemInStockBuyingOrSellingIdListByItemId(int itemId,int isBuying)
        {
            List<ItemInStockDTO> itemInStockBuyingOrSellingList = new List<ItemInStockDTO>();
            itemInStockBuyingOrSellingList = ItemInStockDTO.ConvertToListOfDTO(data.ItemInStock.Where(x=>x.ItemId==itemId&&x.Buying==isBuying).ToList());
            List<int> itemInStockBuyingOrSellingIdList = new List<int>();
            itemInStockBuyingOrSellingIdList = itemInStockBuyingOrSellingList.Select(x => x.ItemInStockId).ToList();
            return itemInStockBuyingOrSellingIdList;
        }
    }
}
