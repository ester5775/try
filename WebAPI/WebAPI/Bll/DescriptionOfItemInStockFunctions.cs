using Dal;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class DescriptionOfItemInStockFunctions
    {
        static DataEntities data = new DataEntities();
        public static void addDiscreptionOfItemInStock(DescriptionOfItemInStockDTO descriptionOfItemInStockDTO)
        {
            data.DescriptionOfItemInStock.Add(DescriptionOfItemInStockDTO.ConvertFromDTO(descriptionOfItemInStockDTO));
        }

        public static List<ItemInStockDetailsDTO> getItemInStockBuyingOrSellingNameListByItemId(int itemId,int isBuying)
        {
            int descriptionOfItemId = DescriptionOfItemFunctions.getMainDescriptionOfItemIdByItemId(itemId);
            List<int> itemInStockIdList = new List<int>();
            itemInStockIdList = ItemInStockFunctions.getItemInStockBuyingOrSellingIdListByItemId(itemId, isBuying);
            List<ItemInStockDetailsDTO> itemInStockNameList = new List<ItemInStockDetailsDTO>();
            foreach (int itemInStockId in itemInStockIdList)
            {
                ItemInStockDetailsDTO itemInStockName=new ItemInStockDetailsDTO();
                itemInStockName.MainDescriptionofItemValue = data.DescriptionOfItemInStock.
                FirstOrDefault(x => x.DescriptionOfItemId == descriptionOfItemId && x.ItemInStockId == itemInStockId).Value;
                itemInStockName.ItemInstockId = itemInStockId;
                itemInStockNameList.Add(itemInStockName);
            } 
            return itemInStockNameList;
        }


        public static ItemInStockAllDetails getAllDetailsOfItemInStockByItemInStockId(int itemInStockId)
        {
            ClientDTO clientDTO = ClientFunctions.getClientByItemInstockId(itemInStockId);
            ItemInStockAllDetails itemInStockAllDetails = new ItemInStockAllDetails();
            itemInStockAllDetails.ClientFirstName = clientDTO.FirstName;
            itemInStockAllDetails.ClientLastName = clientDTO.LastName;
            itemInStockAllDetails.AllDescriptionsOfItemInStock= data.DescriptionOfItemInStock.Where(x => x.ItemInStockId == itemInStockId).
                                                                                              Select(x => x.Value).ToList();
            return itemInStockAllDetails;
        }
    }
}

//==================================================
