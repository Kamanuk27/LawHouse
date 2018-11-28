using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class HrHandler
    {
        private static HrHandler _instance;
        private EmployeeRepository _employee;
        private ClientRepository _client;
        private SpecializationRepository _specialization;

        public HrHandler()
        {
            _employee = new EmployeeRepository();
            _client = new ClientRepository();
        }

        public static HrHandler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new HrHandler();
                return _instance;
            }
        }
        public List<string> GetLawyers()
        {
            return _employee.GetLawyers();
        }

        public List<string> GetEmplNames()
        {
            return _employee.GetEmplNames();
        }
    }

   
}
