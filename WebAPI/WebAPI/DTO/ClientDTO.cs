using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClientDTO
    {
        public int ClientId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AddressId { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public static ClientDTO ConvertToDTO(Client c)
        {
            ClientDTO cd = new ClientDTO();
            cd.ClientId = c.ClientId;
            cd.Password = c.Password;
            cd.FirstName = c.FirstName;
            cd.LastName = c.LastName;
            cd.AddressId = c.AddressId;
            cd.PhoneNumber = c.PhoneNumber;
            cd.Email = c.Email;
            return cd;
        }

        public static Client ConvertFromDTO(ClientDTO cd)
        {
            Client c = new Client();
            c.ClientId = cd.ClientId;
            c.Password = cd.Password;
            c.FirstName = cd.FirstName;
            c.LastName = cd.LastName;
            c.AddressId = cd.AddressId;
            c.PhoneNumber = cd.PhoneNumber;
            c.Email = cd.Email;
            return c;
        }

        public static List<ClientDTO> ConvertToListOfDTO(List<Client> lc)
        {
            List<ClientDTO> lcd = new List<ClientDTO>();
            for (int i = 0; i < lc.LongCount(); i++)
            {
                ClientDTO cd = new ClientDTO();
                cd.ClientId = lc[i].ClientId;
                cd.Password = lc[i].Password;
                cd.FirstName = lc[i].FirstName;
                cd.LastName = lc[i].LastName;
                cd.AddressId = lc[i].AddressId;
                cd.PhoneNumber = lc[i].PhoneNumber;
                cd.Email = lc[i].Email;
                lcd.Add(cd);
            }
            return lcd;
        }

        public static List<Client> ConvertToListFromDTO(List<ClientDTO> lcd)
        {
            List<Client> lc = new List<Client>();
            for (int i = 0; i < lcd.LongCount(); i++)
            {
                Client c = new Client();
                c.ClientId = lcd[i].ClientId;
                c.Password = lcd[i].Password;
                c.FirstName = lcd[i].FirstName;
                c.LastName = lcd[i].LastName;
                c.AddressId = lcd[i].AddressId;
                c.PhoneNumber = lcd[i].PhoneNumber;
                c.Email = lcd[i].Email;
                lc.Add(c);
            }
            return lc;
        }

    }
}
