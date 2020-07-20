using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DescriptionOfItemInStockDTO
    {

       
        public int DescriptionOfItemId { get; set; }        
        public string Value { get; set; }

        private static int mone = 0;

        public static DescriptionOfItemInStockDTO ConvertToDTO(DescriptionOfItemInStock d)
        {
            DescriptionOfItemInStockDTO dd = new DescriptionOfItemInStockDTO();           
            dd.DescriptionOfItemId = d.DescriptionOfItemId;           
            dd.Value = d.Value;
            return dd;
        }
        public int ItemInStockId { get; set; }
        public int DescriptionOfItemInStockId { get; set; }
        public static DescriptionOfItemInStock ConvertFromDTO(DescriptionOfItemInStockDTO dd)
        {
            DescriptionOfItemInStock d = new DescriptionOfItemInStock();
            d.DescriptionOfItemInStockId = mone;
            d.DescriptionOfItemId = dd.DescriptionOfItemId;
            d.ItemInStockId = dd.ItemInStockId;
            d.Value = dd.Value;
            mone ++;
            return d;
        }

        public static List<DescriptionOfItemInStockDTO> ConvertToListOfDTO(List<DescriptionOfItemInStock> ld)
        {
            List<DescriptionOfItemInStockDTO> ldd = new List<DescriptionOfItemInStockDTO>();
            for (int i = 0; i < ld.LongCount(); i++)
            {
                DescriptionOfItemInStockDTO dd = new DescriptionOfItemInStockDTO();
                dd.DescriptionOfItemInStockId = ld[i].DescriptionOfItemInStockId;
                dd.DescriptionOfItemId = ld[i].DescriptionOfItemId;
                dd.ItemInStockId = ld[i].ItemInStockId;
                dd.Value = ld[i].Value;
                ldd.Add(dd);
            }
            return ldd;
        }

        public static List<DescriptionOfItemInStock> ConvertToListFromDTO(List<DescriptionOfItemInStockDTO> ldd)
        {
            List<DescriptionOfItemInStock> ld = new List<DescriptionOfItemInStock>();
            for (int i = 0; i < ldd.LongCount(); i++)
            {
                DescriptionOfItemInStock d = new DescriptionOfItemInStock();
                d.DescriptionOfItemInStockId = mone;
                d.DescriptionOfItemId = ldd[i].DescriptionOfItemId;
                d.ItemInStockId = ldd[i].ItemInStockId;
                d.Value = ldd[i].Value;
                ld.Add(d);
                mone++;
            }
            return ld;
        }
    }
}
