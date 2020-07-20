using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetailingOfValuesDTO
    {
        public int DetailingOfValuesId { get; set; }
        public int DescriptionOfItemId { get; set; }
        public string Value { get; set; }

        public static DetailingOfValuesDTO ConvertToDTO(DetailingOfValues d)
        {
            DetailingOfValuesDTO dd = new DetailingOfValuesDTO();
            dd.DetailingOfValuesId = d.DetailingOfValuesId;
            dd.DescriptionOfItemId = d.DescriptionOfItemId;
            dd.Value = d.Value;
            return dd;
        }

        public static DetailingOfValues ConvertFromDTO(DetailingOfValuesDTO dd)
        {
            DetailingOfValues d = new DetailingOfValues();
            d.DetailingOfValuesId = dd.DetailingOfValuesId;
            d.DescriptionOfItemId = dd.DescriptionOfItemId;
            d.Value = dd.Value;
            return d;
        }

        public static List<DetailingOfValuesDTO> ConvertToListOfDTO(List<DetailingOfValues> ld)
        {
            List<DetailingOfValuesDTO> ldd = new List<DetailingOfValuesDTO>();
            for (int i = 0; i < ld.LongCount(); i++)
            {
                DetailingOfValuesDTO dd = new DetailingOfValuesDTO();
                dd.DetailingOfValuesId = ld[i].DetailingOfValuesId;
                dd.DescriptionOfItemId = ld[i].DescriptionOfItemId;
                dd.Value = ld[i].Value;
                ldd.Add(dd);
            }
            return ldd;
        }

        public static List<DetailingOfValues> ConvertToListFromDTO(List<DetailingOfValuesDTO> ldd)
        {
            List<DetailingOfValues> ld = new List<DetailingOfValues>();
            for (int i = 0; i < ldd.LongCount(); i++)
            {
                DetailingOfValues d = new DetailingOfValues();
                d.DetailingOfValuesId = ldd[i].DetailingOfValuesId;
                d.DescriptionOfItemId = ldd[i].DescriptionOfItemId;
                d.Value = ldd[i].Value;
                ld.Add(d);
            }
            return ld;
        }

    }
}
