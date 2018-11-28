using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    internal class HR
    {
        private DbController _dbController;
        public HR()
        {
            _dbController = DbController.Instance;
        }
    }
}
