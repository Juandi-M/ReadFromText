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
                sr.ReadLine();

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
                        currentPerson.Age = (strArray[2]);
                        currentPerson.SocialSecurity = (strArray[4]);
                        currentPerson.Residence = (strArray[5]);

                        persondata.Add(currentPerson);
                        Console.WriteLine(currentPerson);
                        Console.Write(str);
                        Console.ReadKey();

                        sr.ReadToEnd();
                    }
                }

                else
                {
                    Console.WriteLine("Not able to find a .txt for reading.");
                }

                
            }

        }

        public static void WriteData()
        {

        }
    }
}
