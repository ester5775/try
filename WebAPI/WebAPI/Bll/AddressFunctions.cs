using Dal;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class AddressFunctions
    {
        static DataEntities d = new DataEntities();
        public static AddressDTO city()
        {
            return AddressDTO.convertToDTO(d.Address.FirstOrDefault(x => x.AddressId == 2));
        }
    }
}
