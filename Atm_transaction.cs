//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace _1000cSharpPractice
//{
//    class Atm_transaction
//    {

//        /*          First Method*/

//        public static void Main(string[] args)

//        {
//            int pin, temp;
            
//            do
//            {
//                Console.Write("Enter you ATM pin: ");
//                pin = int.Parse(Console.ReadLine());
//                if (pin == 0122)
//                {


//                    int balance = 1000;
//                    do { 
//                    Console.WriteLine("*****Welcome to ATM Transaction*****");
//                    Console.WriteLine("Enter your Choice from the following ");
                   
//                    Console.WriteLine("1. Withdrawl");
//                    Console.WriteLine("2. Deposition");
//                    Console.WriteLine("3. Check Balance");

//                    Console.Write("Enter your Choice: ");

//                    int choice = int.Parse(Console.ReadLine());

//                    switch (choice)
//                    {
                        
//                        case 1:

//                            Console.Write("How much would you like to withdraw: ");
//                            int withdrawamt = int.Parse(Console.ReadLine());
//                           temp = balance - withdrawamt;
//                            Console.WriteLine("Your balance now is : " + temp);

//                                if (balance <= 200)
//                                {
//                                    Console.WriteLine("Your balance is " + balance + " You cannot make a transaction ");
//                                }
                                
//                                balance = temp;
//                            break;

//                        case 2:

//                            Console.Write("How much would you like to deposit: ");
//                            int deposit = int.Parse(Console.ReadLine());
//                            temp = balance + deposit;
//                            Console.WriteLine("Your balance now after the deposit is: " + temp);
                          
//                            balance = temp;
                           
//                            break;

//                        case 3:
//                            Console.Write("Yor balance is: " + balance);
                              
//                            break;
//                    }
//                    Console.WriteLine("continue:(Y:N) ");

//                } while (Console.ReadLine() == "Y") ;
//            }


//                else
//                {
//                    Console.WriteLine("Incorrect Pin!!");
//                }

//                Console.WriteLine("Do you like to continue:(Y:N) ");
                
//            } while (Console.ReadLine() == "Y");
//            Console.Read();


//        }


         
//    }
//        }




 