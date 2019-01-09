//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1000cSharpPractice
//{
//    class sealedclass
//    {

//    //    sealed class sc
//    //    {
//    //        public int x;
//    //        public int y;
         
//    //    }
//    //    class test { 
//    //    public static void Main(string[] args)
//    //    {
//    //            sc s = new sc();
//    //            s.x = 900;
//    //            s.y = 800;
//    //            Console.WriteLine("x = {0}, y = {1}", s.x, s.y);
//    //            Console.Read();
//    //    }
//    //    }

//        sealed class area
//        {
//            public int len ,wid ,sqft;
          
//        }


//        public static void Main(string[] args)
//        {

           
            
//            area a = new area();
//            Console.Write("Enter the Length : ");
//            a.len = int.Parse(Console.ReadLine());

//            //Console.Write("Enter the Width : ");
//            a.wid = int.Parse(Console.ReadLine());


//            a.sqft = a.len * a.wid;
//            Console.WriteLine("Sq.foot of the house is {0}",a.sqft);
//            Console.Read();
//        }
//    }
//}
