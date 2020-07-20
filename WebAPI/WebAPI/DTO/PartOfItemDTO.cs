using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class PartOfItemDTO
    {
        public int PartOfItemId { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }

        public static PartOfItemDTO ConvertToDTO(PartOfItem p)
        {
            PartOfItemDTO pd = new PartOfItemDTO();
            pd.PartOfItemId = p.PartOfItemId;
            pd.ItemId = p.ItemId;
            pd.Name = p.Name;
            return pd;
        }

        public static PartOfItem ConvertFromDTO(PartOfItemDTO pd)
        {
            PartOfItem p = new PartOfItem();
            p.PartOfItemId = pd.PartOfItemId;
            p.ItemId = pd.ItemId;
            p.Name = pd.Name;
            return p;
        }

        public static List<PartOfItemDTO> ConvertToListOfDTO(List<PartOfItem> lp)
        {
            List<PartOfItemDTO> lpd = new List<PartOfItemDTO>();
            for (int i = 0; i < lp.LongCount(); i++)
            {
                PartOfItemDTO pd = new PartOfItemDTO();
                pd.PartOfItemId = lp[i].PartOfItemId;
                pd.ItemId = lp[i].ItemId;
                pd.Name = lp[i].Name;
                lpd.Add(pd);
            }
            return lpd;
        }

        public static List<PartOfItem> ConvertToListFromDTO(List<PartOfItemDTO> lpd)
        {
            List<PartOfItem> lp = new List<PartOfItem>();
            for (int i = 0; i < lpd.LongCount(); i++)
            {
                PartOfItem p = new PartOfItem();
                p.PartOfItemId = lpd[i].PartOfItemId;
                p.ItemId = lpd[i].ItemId;
                p.Name = lpd[i].Name;
                lp.Add(p);
            }
            return lp;
        }
    }
}
