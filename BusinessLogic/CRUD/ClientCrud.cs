using DataAccess;
using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogic
{
    internal class ClientCrud
    {
        internal IClient _dbClient;
        internal ClientCrud()
        {
            _dbClient = DatabaseFactory.Instance.GetClientDataAccess();
        }
        internal ClientM GetClient(string tlf)
        {
            return _dbClient.GetClient(tlf);
        }

        internal int NewClient(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf)
        {
            ClientM client = new ClientM();
            client.CprNo = cpr;
            client.FirstName = fName;
            client.LastName = lName;
            client.Address = address;
            client.PostNo = postNo;
            client.Email = eMail;
            client.TlfNo = tlf;
            return _dbClient.NewClient(client);
        }

        internal int UpdateClient(int id, string fName, string lName, string cpr, string address, int postNo, string eMail, string tlf)
        {
            ClientM client = new ClientM();
            client.Id = id;
            client.FirstName = fName;
            client.LastName = lName;
            client.CprNo = cpr;
            client.Address = address;
            client.PostNo = postNo;
            client.Email = eMail;
            client.TlfNo = tlf;
            return _dbClient.UpdateClient(client);
        }

        internal int CloseClient(int id)
        {
            return _dbClient.CloseClient(id);
        }
    }
}
