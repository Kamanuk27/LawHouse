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

        DatabaseFactory factory = DatabaseFactory.GetInstance();
        private IDataAccessAdapter _data;
       
        public Case()
        {
           _data = factory.GetDataAccess();
        }
    
        public void GetCase(int id)
        {
            ICase c1 = new Case();
            c1 = _data.GetCase(1);
            Id = c1.Id;
            Name = c1.Name;
            StartDate = c1.StartDate;
        }
    }
}
