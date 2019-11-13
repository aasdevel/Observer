using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Timer();

            var clock = new ConsoleClock();

            timer.Notify += clock.Update;

            timer.Start();

            Console.ReadLine();
        }
    }
}
