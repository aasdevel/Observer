using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ConsoleClock
    {
        public void Update(Timer sender, EventArgs args)
        {
            Console.WriteLine(DateTime.Now.TimeOfDay);
        }
    }
}
