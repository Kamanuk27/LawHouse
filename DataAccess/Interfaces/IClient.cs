using LawHouseLibrary.Models;
using System.Collections.Generic;

namespace DataAccess
{
    //Lisa
    public interface IClient
    {
        int NewClient(ClientM client);
        ClientM GetClient(string tlf);
        List<ClientM> GetClients(bool active);
        int UpdateClient(ClientM client);
        int CloseClient(int id);
        
    }
}
