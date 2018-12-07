using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawHouseLibrary.Models;

namespace DataAccess
{
    class TestClient : IClient
    {

        public int NewClient(ClientM client)
        {
            return 1;
        }
        public ClientM GetClient(string tlf)
        {
            ClientM client = new ClientM();
            client.TlfNo = tlf;
            return client;
        }

        public int UpdateClient(ClientM client)
        {
            return 1;
        }

        public int CloseClient(int id)
        {
            return 1;
        }
    }
}
