//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1000cSharpPractice
//{
//    class average
//    {
//        public static void Main(string [] args)
//        {
//            int num, avg=0,sum=0;
//            Console.Write("enter how many numbers: ");
//            num = int.Parse(Console.ReadLine());

//            int[] a =  new int[num];
//            Console.WriteLine("Enter the array elements: ");
//            for(int i=0; i< num; i++)
//            {
//                a[i] = int.Parse(Console.ReadLine());

//            }

//            for (int i = 0; i < num; i++)
//            {
//                sum += a[i];
//            }
//            avg = sum / num;
//            Console.WriteLine("Average is {0}", avg);

//            Console.Read();
//        }
//    }
//}
