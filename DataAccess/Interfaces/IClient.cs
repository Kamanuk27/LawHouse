using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IClient
    {

        int NewClient(ClientM client);
        ClientM GetClient(string tlf);
        List<ClientM> GetClients(bool active);
        int UpdateClient(ClientM client);
        int CloseClient(int id);
        
    }
}
