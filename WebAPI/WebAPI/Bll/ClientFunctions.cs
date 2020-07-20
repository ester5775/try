using Dal;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class ClientFunctions
    {
        static DataEntities d = new DataEntities();
        //•	הוספת לקוח.
        //v
        public static void AddClient(ClientDTO cd)
        {
            Client c = new Client();
            c = ClientDTO.ConvertFromDTO(cd);
            d.Client.Add(c);
            d.SaveChanges();
        }
        //•	מחיקת לקוח.
        //לכאורה לא צריך את הפונקציה הזאת
        //public static void DeleteClient(int id)
        //{
        //    Client c = new Client();
        //    c = d.Client.FirstOrDefault(x => x.ClientId == id);
        //    d.Client.Remove(c);
        //    d.SaveChanges();
        //}

        //•	שינוי פרטי לקוח.
        //v
        public static void UpdateClientDetails(ClientDTO cd)
        {
            Client c = new Client();
            c = d.Client.FirstOrDefault(x => x.ClientId == cd.ClientId);
            c = ClientDTO.ConvertFromDTO(cd);
            d.SaveChanges();
        }
        //•	החזרת לקוח מרשימת לקוחות ע"פ קוד חפץ במלאי.
        public static ClientDTO getClientByItemInstockId(int itemInStockId)
        {
            Client c = new Client();
            c = d.Client.FirstOrDefault(x => (x.ItemInStock.FirstOrDefault(y => y.ItemId == itemInStockId) != null));
            ClientDTO cd = new ClientDTO();
            cd = ClientDTO.ConvertToDTO(c);
            return cd;
        }
    }
}
