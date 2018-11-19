using System;
using DataAccess;

namespace BusinessLogic1
{
    public class Case
    {
        public int id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal NegPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public Service Service { get; set; }
        public string RespEmployee { get; set; }
        public string Client { get; set; }

        private IDataAccessAdapter _data;

        public Case()
        {
            DatabaseFactory factory = DatabaseFactory.GetInstance();
            _data = factory.GetDataAccess();
        }

        public Case GetCase(int id)
        {
            return _data.GetCase(id);
        }
    }
}
