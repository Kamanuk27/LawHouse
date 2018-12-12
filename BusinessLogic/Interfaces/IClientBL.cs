using LawHouseLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IClientBL
    {
        ClientM GetClient(string tlf);
        int NewClient(string cpr, string fName, string lName, string address, int postNo, string eMail, string tlf);
        int UpdateClient(int id, string fName, string lName, string cpr, string address, int postNo, string eMail, string tlf);
        int CloseClient(int id);

    }
}
