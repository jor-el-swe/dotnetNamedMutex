using System;
using System.Threading;

namespace dotnetNamedMutex
{
    class Program
    {
        static void Main(string[] args)
        {
            //set this to false to try the counting semaphore example
            const bool runMutex = true;
            Console.WriteLine("Hello Application");
            if (runMutex)
            {
                Mutex myMutex = new Mutex (true, "theVeryExclusiveMutex", out bool createdNew);
                //check if mutex is available
                //disable this line to try the "createdNew" bool instead
                myMutex.WaitOne();
                Console.WriteLine("waited for one mutex");
                
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
            else
            {
                if (Semaphore.TryOpenExisting("theSomewhatExclusiveSemaphore", out var mySemaphore))
                {
                    Console.WriteLine("opened an existing semaphore");
                }
                else
                {
                    mySemaphore = new Semaphore(3,3,"theSomewhatExclusiveSemaphore"); 
                    Console.WriteLine("created a new semaphore");
                }
                
                mySemaphore.WaitOne();
                Console.WriteLine("waited one semaphore");
                while (true) ;
            }
        }
    }
}
