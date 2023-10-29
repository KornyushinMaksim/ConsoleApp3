using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Укажите пути к файлу номенклатуры, подключению номенклатур и куда сохранить файл с результатами");
            //string pathNom = Console.ReadLine();
            //string pathConectNom = Console.ReadLine();
            //string pathWriter = Console.ReadLine();

            OpenFile openFile = new OpenFile();
            WorkProgram workProgram = new WorkProgram();
            string pathNom = "Robot\\номенклатура.txt";
            string pathConectNom = "Robot\\подключения номенклатур.txt";
            string pathWriter = "Robot\\итоговая номенклатура.txt";
            Console.WriteLine("Сколько нужно роботов?");
            int value = Convert.ToInt32(Console.ReadLine());

            ListElements listElements = openFile.open(pathNom);
            ListGIUDs listGUIDs = openFile.openConect(listElements, pathConectNom, value);
            workProgram.nestedList(listElements, listGUIDs);
            openFile.writeTofile(pathWriter, listElements.pirnt());

            Console.WriteLine(listElements.pirnt());


        }
    }
}
