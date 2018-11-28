using LawHouseLibrary.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    interface IRepository<T> where T : Entity
    {
        T GetById(int id);

        int Create(T entity);

        int Delete(int id);

        int Update(T entity);

        List<T> GetList();
    }
}
