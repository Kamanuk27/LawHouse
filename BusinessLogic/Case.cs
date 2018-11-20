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
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal NegPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public Service ProvService { get; set; }
        public string RespEmployee { get; set; }
        public string Client { get; set; }
        public string Service { get; set; }

        //DatabaseFactory factory = DatabaseFactory.GetInstance();
        //private IDataAccess _data;
        private DbController dbController;
       
        public Case()
        {
            dbController = DatabaseFactory.Instance.GetDataAccess();
            //_data = factory.GetDataAccess();
        }
    
        public void GetCase(int id)
        {
            ICase c1 = new Case();
            c1 = dbController.GetCase(id);
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
    }
}
