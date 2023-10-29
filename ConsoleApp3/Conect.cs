using System.Text;

namespace ConsoleApp3
{
    internal class Conect
    {
        private string parentGUID;
        private string inheritGUID;

        public Conect()
        {
            parentGUID = string.Empty;
            inheritGUID = string.Empty;
        }

        public string getParentGUID()
        {
            return parentGUID;
        }

        public string getInheritGUID()
        {
            return inheritGUID;
        }

        public void addGUIDs(string[] strings)
        {
            parentGUID = strings[0];
            inheritGUID = strings[1];
        }

        public string print()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("{0} {1}", parentGUID, inheritGUID);
            stringBuilder.Append("\n");
            return stringBuilder.ToString();
        }
    }

}
