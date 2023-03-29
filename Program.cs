using System;
using System.ComponentModel.DataAnnotations;

namespace asynchronous
{
    internal class Program
    {
        
         static void Main(string[] args)
        {




            //Task<int> resultantNumber = ReturnNumber();
            FirstMethod();
            
            // await resultantNumber;
            //.WriteLine($"The number = {resultantNumber.Result} ");
            // SecondMethod();
            Console.WriteLine("calling display method: ");
            //Task<int> result= display();
            int result1 = Convert.ToInt32(display().Result); ;
            Console.WriteLine(result1);
            Console.ReadLine();
            //return 0;
            
        }

        public static async Task<string> FirstMethod()
        {

            Console.WriteLine("Method1 has started");
            Console.WriteLine("Message in method1");
            string message = await SecondMethod();
            Console.WriteLine(message);
       
            //await Task.Delay(5000);
            Console.WriteLine("Method1 has Ended");
            return "completed";
        }
        /*
        public static async Task<int> ReturnNumber()
        {
            Thread.Sleep(2000);
            return 10;
        }
        */

        public static async Task<string> SecondMethod()
        {
            Console.WriteLine("Method2 has started");
            await Task.Delay(7000);
            string msg = "message from method2";
            Console.WriteLine("Method2 has Ended");
            return msg;
        }
        public static async Task<int> display()
        {
            Console.WriteLine("dummy");
            return 3;
        }

    }
}

