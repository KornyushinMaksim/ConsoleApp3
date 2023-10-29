using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ListGIUDs
    {
        private List<Conect> conects;

        public ListGIUDs()
        {
            conects = new List<Conect>();
        }

        public List<Conect> getArray()
        {
            return conects;
        }

        public void AddConect(Conect conect)
        {
            conects.Add(conect);
        }

        public string print()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Conect con in conects)
            {
                sb.Append(con.print());
            }
            return sb.ToString();
        }
    }
}
