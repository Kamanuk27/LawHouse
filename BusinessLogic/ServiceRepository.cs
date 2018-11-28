using DataAccess;
using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    class ServiceRepository : IRepository<Service>
    {


        private  DbController _dbController;

        public ServiceRepository()
        {
            _dbController = DbController.Instance;
        }
        public int Create(Service s1)
        {
           return  _dbController.NewService(s1);
        }

        public int Delete(int id)
        {
           return _dbController.DeleteService(id);
        }

        public Service GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Service> GetList(int id)
        {
            return _dbController.GetProvidedServices(id);
        }

        public List<Service> GetList()
        {
            throw new NotImplementedException();
        }

        public int Update(Service s1)
        {
            return _dbController.UpdateService(s1);
        }
    }
}
