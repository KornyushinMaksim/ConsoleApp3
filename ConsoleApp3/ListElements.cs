using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ListElements
    {
        private List<Nomenclature> nomenclatures;

        public ListElements()
        {
            nomenclatures = new List<Nomenclature>();
        }
        public List<Nomenclature> getArray()
        {
            return nomenclatures;
        }
         public void addItem(Nomenclature nomenclature)
        {
            nomenclatures.Add(nomenclature);
        }

        public string pirnt()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(var item in nomenclatures)
            {
                stringBuilder.Append(item.toString());
            }
            return stringBuilder.ToString();
        }
    }
}
