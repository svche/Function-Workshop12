using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Function_Workshop12
{
    class Program
    {
        static void Main(string[] args)
        {



            /*
            string path = "";
            string text;

            Console.Write("Enter the file name: ");
            path = Console.ReadLine();

            bool b = true;
            int choice;
            do
            {
                Console.WriteLine(@"
______________________________________________
_______________S_E_L_E_C_T____________________

        \1/                 \0/
     ENTER TEXT            EXIT
______________________________________________

");
                choice = int.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Enter text: ");
                    text = Console.ReadLine();
                    WrireToFile(text, path, b);
                }
                if (choice == 0)
                {
                    b = false;
                }

            } while (b); */


            //if (path.Length == 0)
            //{
            //    WrireToFile(text);
            //}
            //else
            //{
            //    WrireToFile(text, path);            
            //}

            /*
            List<int> numList = new List<int>();
            numList.Add(1);
            numList.Add(2);
            numList.Add(3);
            foreach (int i in numList) Console.WriteLine(i);

            Console.WriteLine();
            numList.Remove(1);
            foreach (int i in numList) Console.WriteLine(i);

            Console.WriteLine();
            numList.RemoveAt(0);
            foreach (int i in numList) Console.WriteLine(i);
            */

            /* */

            List<int> numList = new List<int>();
            int[] maxSize = new int[2];

            valueList(maxSize);

            Fill(numList, maxSize);

            Console.Write("\nList: ");
            writeList(numList);


            Console.ReadLine();
        }

        static int[] valueList(int[] maxSize)
        {
            Console.Write("maximum number: ");
            maxSize[0] = int.Parse(Console.ReadLine());

            Console.Write("size of array: ");
            maxSize[1] = int.Parse(Console.ReadLine());

            return maxSize;
        }

        static void Fill(List<int> list, int[] maxSize)
        {
            Random rand = new Random();

            for (int i = 0; i < maxSize[1]; i++)
            {
                list.Add(rand.Next(maxSize[0]));
            }
        }

        static void writeList(List<int> list)                   
        {
            foreach (int i in list) Console.Write(i + " ");
        }

        static List<int> GetList(List<int> list)
        {
            return new List<int>();
        }

        static void WrireToFile(string text, string path, bool b)
        {
            StreamWriter sw = new StreamWriter(path, true);
            sw.WriteLine(text);
            sw.Close();
        }

        static void WrireToFile(string text, string path)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(text);
            sw.Close();
        }

        static void WrireToFile(string text)
        {
            string path = "default.txt";
            WrireToFile(text, path);
        }

    }
}
