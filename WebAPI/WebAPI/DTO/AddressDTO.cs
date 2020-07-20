using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AddressDTO
    {
        public int AddressId { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Neighbourhood { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }

        public static AddressDTO convertToDTO(Address address)
        {
            AddressDTO addressDTO = new AddressDTO();
            addressDTO.AddressId = address.AddressId;
            addressDTO.Country = address.Country;
            addressDTO.City = address.City;
            addressDTO.Neighbourhood = address.Neighbourhood;
            addressDTO.Street = address.Street;
            addressDTO.HouseNumber = address.HouseNumber;
            return addressDTO;
        }

        public static Address convertFromDTO(AddressDTO addressDTO)
        {
            Address address = new Address();
            address.AddressId = addressDTO.AddressId;
            address.Country = addressDTO.Country;
            address.City = addressDTO.City;
            address.Neighbourhood = addressDTO.Neighbourhood;
            address.Street = addressDTO.Street;
            address.HouseNumber = addressDTO.HouseNumber;
            return address;
        }
        public static List<AddressDTO> convertListToDTOList(List<Address> listAddress)
        {
            List<AddressDTO> listAddressDTO = new List<AddressDTO>();
            for (int i = 0; i < listAddress.Count(); i++)
            {
                AddressDTO addressDTO = new AddressDTO();
                addressDTO.AddressId = listAddress[i].AddressId;
                addressDTO.Country = listAddress[i].Country;
                addressDTO.City = listAddress[i].City;
                addressDTO.Neighbourhood = listAddress[i].Neighbourhood;
                addressDTO.Street = listAddress[i].Street;
                addressDTO.HouseNumber = listAddress[i].HouseNumber;
                listAddressDTO.Add(addressDTO);
            }
            return listAddressDTO;
        }


    }
}
