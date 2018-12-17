using LawHouseLibrary.Models;
using System.Collections.Generic;

namespace BusinessLogic
{
    //LIsa

    public class ClientHandler
    {
        private static ClientHandler _instance;
        private ClientCrud _clientCrud;


        public ClientHandler()
        {
            _clientCrud = new ClientCrud();
        }
        public static ClientHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ClientHandler();
                return _instance;
            }
        }

        public ClientM GetClient(string tlf)
        {
            return _clientCrud.GetClient(tlf);
        }

        public List<ClientM> GetClients(bool active)
        {
            return _clientCrud.GetClients(active);
        }

        public int NewClient(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf)
        {
            return _clientCrud.NewClient(cpr, fName, lName, address, postNo, eMail, tlf);
        }

        public int UpdateClient(int id, string fName, string lName, string cpr, string address, int postNo, string eMail, string tlf)
        {
            return _clientCrud.UpdateClient(id, fName, lName, cpr, address, postNo, eMail, tlf);
        }
        public int CloseClient(int id)
        {
            return _clientCrud.CloseClient(id);
        }
    }
}
