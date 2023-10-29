using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    internal class Nomenclature
    {
        private string name;
        private string designation;
        private string GUID;
        private int cnt;
        private string sale;
        private int otstup;

        public Nomenclature()
        {
            name = string.Empty;
            designation = string.Empty;
            GUID = string.Empty;
            cnt = 0;
            sale = string.Empty;
            otstup = 0;
        }

        public string getGUID() { return GUID; }
        public int getOtstup() { return otstup; }

        public void setCnt(string[] strings, int value)
        {
            cnt = Convert.ToInt32(strings[2]) * value;
        }
        public void setOtstup(int i)
        {
            otstup = i;
        }

        public void initObj(string[] strings)
        {
            name = strings[0];
            designation = strings[1];
            GUID = strings[2];
            sale = strings[3];
        }

        public string toString()
        {
            string s = string.Empty;
            for (int i = 0; i < otstup; i++)
            {
                s += "  ";
            }
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}\t{2}\t{3}\t{4}\t{5}", s, name, designation, GUID, cnt, sale);
            sb.Append('\n');
            return sb.ToString();
        }
    }
}
