using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawHouseTabForm
{
    class GuiFactory
    {
        private static GuiFactory _instance;

        internal GuiFactory()
        {

        }
        public static GuiFactory Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GuiFactory();
                return _instance;
            }
        }
        public IUserInterface GetUserInterface()
        {
            return new MainForm();
        }
    }
}
