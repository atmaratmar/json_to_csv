using System;
using System.Collections.Generic;
using System.IO;

namespace ReadCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            string name= Console.ReadLine();
            string lastname = Console.ReadLine();

            Console.WriteLine(string.Join(" ",record(name, lastname,1)));

           
            Console.ReadKey();
        }
        public static string[] record(string search,string filepath,int posision)
        {
           

            posision--;
            string[] recordnotfound = { "record not found" };
            try
            {

                string[] lines = File.ReadAllLines(@"C:\Users\DJ\Desktop\intagrate csv object withc_sharp\data1.csv");
                for (int i = 0; i < lines.Length; i++)
                {

                        string[] fields = lines[i].Split(';');
                        if (recordmatch(search, fields, posision))
                        {

                            Console.WriteLine("record found");

                            return fields;
                        }


                }
                return recordnotfound;
            }
            
            catch (Exception)
            {

                throw;
            }
        }
        public static bool recordmatch(string search, string[] record, int posision)
        {
            if (record[posision].Equals(search))
            {
                return true;
            }
            return false;
        }
    }

    //using (var reader = new StreamReader(@"C:\Users\DJ\Desktop\intagrate csv with c_sharp\data1.csv"))
}