using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ItemDTO
    {
        
        public int ItemId { get; set; }       
        public string Name { get; set; }


        

        
        public static ItemDTO ConvertToDTO(Item i)
        {
            ItemDTO itemDTO = new ItemDTO();
            itemDTO.ItemId = i.ItemId;
            itemDTO.Name = i.Name;
            return itemDTO;
        }

        public static Item ConvertFromDTO(ItemDTO idt)
        {
            DataEntities data = new DataEntities();
            int mone = 20;
            Item i = new Item();
            i.ItemId =mone++;
            i.CategoryId = 1;
            i.Name = idt.Name;
            data.Item.Add(i);
            return i;
        }

        public static List<ItemDTO> ConvertToListOfDTO(List<Item> li)
        {
            List<ItemDTO> lidt = new List<ItemDTO>();
            for (int i = 0; i < li.LongCount(); i++)
            {
                ItemDTO idt = new ItemDTO();
                idt.ItemId = li[i].ItemId;                
                idt.Name = li[i].Name;
                lidt.Add(idt);
            }
            return lidt;
        }

        public static List<Item> ConvertToListFromDTO(List<ItemDTO> lidt)
        {
            DataEntities data = new DataEntities();
            int mone = 50;
            List<Item> li = new List<Item>();
            for (int i = 0; i < lidt.LongCount(); i++)
            {
                Item it = new Item();
                it.ItemId = mone++;
                it.CategoryId = 1;
                it.Name = lidt[i].Name;
                li.Add(it);
            }
            return li;
        }
    }
}
