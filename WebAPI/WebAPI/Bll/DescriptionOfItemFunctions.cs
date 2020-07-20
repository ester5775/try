using Dal;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public  class DescriptionOfItemFunctions
    {
         //DataEntities d = new DataEntities();
        //public List<DescriptionOfItem> getDescriptionByItemName(string name)
        //{
        //    List<DescriptionOfItem> DescriptionOfItemList = new List<DescriptionOfItem>();
        //    Item item = new Item();
        //    item=getItembyitemName

        //    DescriptionOfItemList=d.DescriptionOfItem.Where()
        //    return 
        //}
        public static List<DescriptionOfItemDTO> getDescriptionOfItemListByItemId(int itemId)
             
        {
            DataEntities d = new DataEntities();
            List<DescriptionOfItemDTO> descriptionOfItemList = new List<DescriptionOfItemDTO>();
            foreach (var x in d.DescriptionOfItem)
            {
                if (x.ItemId == itemId || x.ItemId == 1)
                    descriptionOfItemList.Add(DescriptionOfItemDTO.ConvertToDTO(x));
            }
            //descriptionOfItemList = DescriptionOfItemDTO.ConvertToListOfDTO(d.DescriptionOfItem.Where(x => x.ItemId == itemId || x.ItemId==1).ToList());
            return descriptionOfItemList;
        }

        public static List<int> addDiscreptionOfItemList(List<DescriptionOfItemDTO> descriptionOfItemDTOList)
        {           
            return DescriptionOfItemDTO.ConvertFromListOfDTO(descriptionOfItemDTOList).Select(x=>x.DescriptionOfItemId).ToList();           
        }


        public static int getMainDescriptionOfItemIdByItemId(int itemId)
        {
            DataEntities d = new DataEntities();
            int i = 0;
            foreach (var item in d.DescriptionOfItem)
            {
                if (item.ItemId == itemId && item.MainDescription == 1)
                    i = item.DescriptionOfItemId;
            }
 //           int i = d.DescriptionOfItem.Where(x => x.ItemId == itemId && x.MainDescription == 1).FirstOrDefault().DescriptionOfItemId;
            return i;
        }
    }
}
