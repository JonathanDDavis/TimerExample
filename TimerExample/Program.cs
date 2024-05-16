using System;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);

            myTimer.Elapsed += MyTimer_Elasped;
        }

        private static void MyTimer_Elasped(object sender, ElapsedEventArgs)
        {
            Console.WriteLine("Elasped: ");
        }
    }
}
