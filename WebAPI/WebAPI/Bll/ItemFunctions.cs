using Dal;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class ItemFunctions
    {
        static DataEntities data = new DataEntities();
        public static int mone = 0;
        
        public static int getItemIdByItemName(string itemName)
        {
            Item item = data.Item.FirstOrDefault(x => x.Name == itemName);
            if(item==null)
            {
                ItemDTO idt = new ItemDTO();
                idt.ItemId = mone++;
                idt.Name = itemName;
                ItemDTO.ConvertFromDTO(idt);

                return idt.ItemId;
            }
            int i = item.ItemId;
            return i;
        }

        public static ItemDTO getItemByItemName(string itemName)
        {
            Item item = data.Item.FirstOrDefault(x => x.Name == itemName);
            if (item == null)
            {
                ItemDTO itemDTO = new ItemDTO();
                itemDTO.Name = itemName;
                return ItemDTO.ConvertToDTO(ItemDTO.ConvertFromDTO(itemDTO));
            }
            return ItemDTO.ConvertToDTO(item);          
        }     
    }
}
