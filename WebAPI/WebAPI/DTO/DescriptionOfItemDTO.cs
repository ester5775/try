using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DescriptionOfItemDTO
    {

        static DataEntities data = new DataEntities();
        public int FieldOfItemId { get; set; }
        public int ItemId { get; set; }
        public string FieldName { get; set; } 

        private static int mone = 20;

        public static DescriptionOfItemDTO ConvertToDTO(DescriptionOfItem d)
        {
            DescriptionOfItemDTO dd = new DescriptionOfItemDTO();
            dd.FieldOfItemId = d.DescriptionOfItemId;
            dd.ItemId = d.ItemId;
            dd.FieldName = d.FieldName;          
            return dd;
        }

        public static DescriptionOfItem ConvertFromDTO(DescriptionOfItemDTO dd)
        {
            DescriptionOfItem d = new DescriptionOfItem();
            d.DescriptionOfItemId = mone;
            d.ItemId = dd.ItemId;
            d.FieldName = dd.FieldName;
            d.KindOfFieldId = 2;
            mone++;
            data.DescriptionOfItem.Add(d);
            return d;
        }

        public static List<DescriptionOfItemDTO> ConvertToListOfDTO(List<DescriptionOfItem> ld)
        {
            List<DescriptionOfItemDTO> ldd = new List<DescriptionOfItemDTO>();
            for (int i = 0; i < ld.LongCount(); i++)
            {
                DescriptionOfItemDTO dd = new DescriptionOfItemDTO();
                dd.FieldOfItemId = ld[i].DescriptionOfItemId;
                dd.ItemId = ld[i].ItemId;
                dd.FieldName = ld[i].FieldName;               
                ldd.Add(dd);
            }
            
            return ldd;
        }

        public static List<DescriptionOfItem> ConvertFromListOfDTO(List<DescriptionOfItemDTO> ldd)
        {
            List<DescriptionOfItem> ld = new List<DescriptionOfItem>();
            for (int i = 0; i < ldd.LongCount(); i++)
            {
                DescriptionOfItem d = new DescriptionOfItem();
                d.DescriptionOfItemId = mone;
                d.ItemId = ldd[i].ItemId;
                d.FieldName = ldd[i].FieldName;
                d.KindOfFieldId = 2;
                ld.Add(d);
                mone++;
            }
            return ld;
        }
    }
}
