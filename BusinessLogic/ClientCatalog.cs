﻿using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class ClientCatalog
    {

        private DbController _dbController;

        public ClientCatalog()
        {
            _dbController = DbController.Instance;
        }

        internal ClientE GetClient(string cpr)
        {
            return _dbController.GetClient(cpr);
        }

        internal int NewClient(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf)
        {
            ClientE client = new ClientE();
            client.CprNo = cpr;
            client.FirstName = fName;
            client.LastName = lName;
            client.Address = address;
            client.PostNo = postNo;
            client.Email = eMail;
            client.TlfNo = tlf;
            return _dbController.NewClient(client);
        }

        internal int UpdateClient(string cpr, string address, int postNo, string eMail, string tlf)
        {
            ClientE client = new ClientE();
            client.CprNo = cpr;
            client.Address = address;
            client.PostNo = postNo;
            client.Email = eMail;
            client.TlfNo = tlf;
            return _dbController.UpdateClient(client);
        }

        internal int CloseClient(string cpr)
        {
            return _dbController.CloseClient(cpr);
        }
    }
}
