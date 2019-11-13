using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public delegate void NotifyEvent<T>(T subject, EventArgs args);
    public class Timer
    {
        public event NotifyEvent<Timer> Notify;

        public void Start()
        {
            var thread = new Thread(() =>
            {
                while (true)
                {
                    if (Notify != null)
                    {
                        Notify(this, new EventArgs());
                    }
                    Thread.Sleep(1000);
                }
            });

            thread.Start();
        }
    }
    
}
