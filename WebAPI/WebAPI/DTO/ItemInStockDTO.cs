using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ItemInStockDTO
    {
        public int ItemInStockId { get; set; }
        public int ItemId { get; set; }       
        public int ClientId { get; set; }
 

        public static ItemInStockDTO ConvertToDTO(ItemInStock i)
        {
            ItemInStockDTO idt = new ItemInStockDTO();
            idt.ItemInStockId = i.ItemInStockId;
            idt.ItemId = i.ItemId;
            idt.ClientId = i.ClientId;       
            return idt;
        }

        public static ItemInStock ConvertFromDTO(ItemInStockDTO idt)
        {
            ItemInStock i = new ItemInStock();
            i.ItemInStockId = idt.ItemInStockId;
            i.ItemId = idt.ItemId;           
            i.ClientId = idt.ClientId;          
            return i;
        }

        public static List<ItemInStockDTO> ConvertToListOfDTO(List<ItemInStock> li)
        {
            List<ItemInStockDTO> lidt = new List<ItemInStockDTO>();
            for (int i = 0; i < li.LongCount(); i++)
            {
                ItemInStockDTO idt = new ItemInStockDTO();
                idt.ItemInStockId = li[i].ItemInStockId;
                idt.ItemId = li[i].ItemId;              
                idt.ClientId = li[i].ClientId;                
                lidt.Add(idt);
            }
            return lidt;
        }

        public static List<ItemInStock> ConvertToListFromDTO(List<ItemInStockDTO> lidt)
        {
            List<ItemInStock> li = new List<ItemInStock>();
            for (int i = 0; i < lidt.LongCount(); i++)
            {
                ItemInStock ii = new ItemInStock();
                ii.ItemInStockId = lidt[i].ItemInStockId;
                ii.ItemId = lidt[i].ItemId;
                ii.ClientId = lidt[i].ClientId;                
                li.Add(ii);
            }
            return li;
        }
    }
}
