using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class OpenFile
    {
        public ListElements open(string pathNom)
        {
            ListElements listElements = new ListElements();
            using (FileStream fileStream = new FileStream(pathNom, FileMode.Open))
            {
                string line = null;
                int cnt = 0;
                try
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            if (cnt != 0 && line != "")
                            {
                                Nomenclature nomenclature = new Nomenclature();
                                nomenclature.initObj(line.Split('\t'));
                                listElements.addItem(nomenclature);
                            }
                            cnt++;
                        }
                    }
                }
                catch (NotImplementedException ex)
                {
                    throw new NotImplementedException();
                }
            }
            return listElements;
        }

        public ListGIUDs openConect(ListElements list, string pathConectNom, int value)
        {
            ListGIUDs listGIUDs = new ListGIUDs();
            using (FileStream fileStream = new FileStream(pathConectNom, FileMode.Open))
            {
                string line = null;
                int cnt = 0;
                int i = 0;
                try
                {
                    using (StreamReader streamReader = new StreamReader(fileStream))
                    {
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            if (cnt != 0 && line != "")
                            {
                                Conect conect = new Conect();
                                list.getArray()[i++].setCnt(line.Split(' '), value);
                                conect.addGUIDs(line.Split(' '));
                                listGIUDs.AddConect(conect);
                            }
                            cnt++;
                        }
                    }
                }
                catch (NotImplementedException ex)
                {
                    throw new NotImplementedException();
                }
            }
            return listGIUDs;
        }

        public void writeTofile(string pathWrite, string result)
        {
            using (FileStream fileStream = new FileStream(pathWrite, FileMode.Create))
            {
                using (StreamWriter streamWriter = new StreamWriter(fileStream))
                {
                    streamWriter.Write(result);
                }
            }
        }
    }
}
