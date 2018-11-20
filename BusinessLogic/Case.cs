using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using LawHouseLibrary;

namespace BusinessLogic
{
    public partial class Case : ICase
    {
       
        private DbController dbController;
       
        public Case()
        {
            dbController = DatabaseFactory.Instance.GetDataAccess();
           
        }
    
        public void GetCase(int id)
        {

            ICase c1 = dbController.GetCase(id);
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

        //public int RegisterService(int hours, int km)
        //{
        //    int confirm = 0;
        //    dbController.RegisterService(hours, km);
        //    return confirm;
        //}
    }
}
