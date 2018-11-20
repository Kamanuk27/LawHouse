using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using LawHouseLibrary;

namespace BusinessLogic
{
    public partial class Case : ACase
    {
       
        private DbController dbController;
       
        public Case()
        {
            dbController = DatabaseFactory.Instance.GetDataAccess();
           
        }
    
        public void GetCase(int id)
        {

            ACase c1 = dbController.GetCase(id);
            Id = c1.Id;
            Name = c1.Name;
            StartDate = c1.StartDate;
            EndDate = c1.EndDate;
            NegPrice = c1.NegPrice;
            TotalPrice = c1.TotalPrice;
            RespEmployee = c1.RespEmployee;
            Client = c1.Client;
            Service = c1.Service;

        }

        public int RegisterService(AService s1)
        {
           
            dbController.EditService(s1);
            return 1;
        }

        public int NewCase(ACase c1)
        {
            dbController.NewCase(c1);
            return 1;
        }
    }
}
