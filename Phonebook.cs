﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1000cSharpPractice
//{
//    class Phonebook
//    {
//        static void Main(string[] arg)
//        {
//            Phonebook tab = new Phonebook();
//            string fileName;
//            if
//            {
//                (arg.Length > 0) fileName = arg[0];
//            }
//            else
//            {
//                fileName = "phoneBook.txt";
//            }
//            StreamReader r = File.OpenText(fileName);
//            string line = r.ReadLine();
//            while (line != null)
//            {
//                int pos = line.IndexOf('=');
//                string name = line.Substring(0, pos).Trim();
//                long phone = Convert.ToInt64(line.Substring(pos + 1));
//                tab[name] = phone;
//                line = r.ReadLine();
//            }
//            r.Close();
//            for (; ; )
//            {
//                Console.Write("Name : ");
//                string name = Console.ReadLine().Trim();
//                if (name == "")
//                    break;
//                object phone = tab[name];
//                if (phone == null)
//                    Console.WriteLine("-- Not Found in Phone Book");
//                else
//                    Console.WriteLine(phone);
//            }
//        }
//    }

//}
