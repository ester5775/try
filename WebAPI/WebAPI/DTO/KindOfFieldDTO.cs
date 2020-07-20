using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class KindOfFieldDTO
    {
        public int KindOfFieldId { get; set; }
        public string Name { get; set; }

        public static KindOfFieldDTO ConvertToDTO(KindOfField k)
        {
            KindOfFieldDTO kd = new KindOfFieldDTO();
            kd.KindOfFieldId = k.KindOfFieldId;
            kd.Name = k.Name;
            return kd;
        }

        public static KindOfField ConvertFromDTO(KindOfFieldDTO kd)
        {
            KindOfField k = new KindOfField();
            k.KindOfFieldId = kd.KindOfFieldId;
            k.Name = kd.Name;
            return k;
        }

        public static List<KindOfFieldDTO> ConvertToListOfDTO(List<KindOfField> lk)
        {
            List<KindOfFieldDTO> lkd = new List<KindOfFieldDTO>();
            for (int i = 0; i < lk.LongCount(); i++)
            {
                KindOfFieldDTO kd = new KindOfFieldDTO();
                kd.KindOfFieldId = lk[i].KindOfFieldId;
                kd.Name = lk[i].Name;
                lkd.Add(kd);
            }
            return lkd;
        }

        public static List<KindOfField> ConvertToListFromDTO(List<KindOfFieldDTO> lkd)
        {
            List<KindOfField> lk = new List<KindOfField>();
            for (int i = 0; i < lkd.LongCount(); i++)
            {
                KindOfField k = new KindOfField();
                k.KindOfFieldId = lkd[i].KindOfFieldId;
                k.Name = lkd[i].Name;
                lk.Add(k);
            }
            return lk;
        }
    }
}
