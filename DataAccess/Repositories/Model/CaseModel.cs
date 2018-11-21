using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.Repositories;

namespace DataAccess.Model
{
    class CaseModel : CaseRepo
    {
        public CaseModel() : base()
        {

        }
        public CaseModel(int id) : base(id)
        {

        }

    }
}
