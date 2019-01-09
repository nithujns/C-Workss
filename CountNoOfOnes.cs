//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1000cSharpPractice
//{
//    class CountNoOfOnes
//    {

//        public static void Main(string[] args)
//        {
//            int count = 0;
//            Console.Write(" Enter the number: ");

//            int n = int.Parse(Console.ReadLine());

//            int[] m = new int[n];

//            Console.WriteLine("Enter the numbers : ");

//            for (int i = 0; i < n; i++)
//            {
//                m[i] = Convert.ToInt32(Console.ReadLine());
//            }
//            foreach (int o in m)
//            {
//                if (o == 1)
//                {
//                    count++;
//                }
//            }
//            Console.WriteLine("Number of 1's in the Entered Number : ");
//            Console.WriteLine(count);
//            Console.ReadLine();
//        }
//    }
//}
