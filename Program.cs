using System;
using System.Threading;

namespace dotnetNamedMutex
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Application");
            Mutex myMutex = new Mutex (true, "theVeryExclusiveMutex", out bool createdNew);
            //check if mutex is availalbe
            if (createdNew)
            {
                //then enter
                Console.WriteLine("entering the very exciting program");
                while (true); 
            }
            else
            {
                           
                //else exit
                Console.WriteLine("not enough resources to enter right now"); 
            }

        }
    }
}
