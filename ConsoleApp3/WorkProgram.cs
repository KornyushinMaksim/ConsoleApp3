using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class WorkProgram
    {

        public void nestedList(ListElements listElements, ListGIUDs listGIUDs)
        {
            for (int i = 0; i < listGIUDs.getArray().Count; i++)
            {
                for (int j = 0; j < listElements.getArray().Count; j++)
                {
                    if (listGIUDs.getArray()[i].getParentGUID() == listElements.getArray()[j].getGUID())
                    {
                        for (int k = 0; k < listElements.getArray().Count; k++)
                        {
                            if (listGIUDs.getArray()[i].getInheritGUID() == listElements.getArray()[k].getGUID())
                            {
                                listElements.getArray()[k].setOtstup((listElements.getArray()[j].getOtstup()) + 1);
                            }

                        }
                    }
                }
            }
        }
    }
}
