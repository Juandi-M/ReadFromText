using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintfromFile;

namespace PrintfromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            ReadData();
        }
        

        public static void ReadData()
        {
            List<PersonInfo> persondata = new List<PersonInfo>();


            using (StreamReader sr =
                new StreamReader(path: "C:\\Users\\Juan Monge\\source\\repos\\PrintfromFile\\TESTPRACTICE.txt"))
            {
                if (sr != null)
                {
                    while (sr.Peek() >= 0)
                    {
                        string str;
                        string[] strArray;
                        str = sr.ReadLine();

                        strArray = str.Split(',');
                        PersonInfo currentPerson = new PersonInfo();

                        currentPerson.Name = strArray[0];
                        currentPerson.Lastname = strArray[1];
                        currentPerson.Age = Convert.ToInt32(strArray[2]);
                        currentPerson.SocialSecurity = (strArray[3]);
                        currentPerson.Residence = (strArray[4]);

                        persondata.Add(currentPerson);
                        Console.WriteLine(currentPerson);
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("no textFile t");
                }

            }

        }

        public static void WriteData()
        {

        }
    }
}
