//
// ICT2106 Software Design - Timer exercise
//
// A class representing a timer.
//
using System;
using System.Collections.Generic;
namespace Timer
{
    class Timer
    {
        private List<TextAlarm> _observers = new List<TextAlarm>();
      
        // repeatedly wait one second, exiting after numberOfTicks iterations
        public void Run(int numberOfTicks)
        {
            while (numberOfTicks > 0)
            {
                System.Threading.Thread.Sleep(1000);
                System.Console.WriteLine("Sleeping...");
                Notify();
                numberOfTicks--;
                Console.WriteLine("\n");
            }
            System.Environment.Exit(0);
        }

        public void Attach(TextAlarm observer)
        {
            _observers.Add(observer);
        } 

        public void Detach(TextAlarm observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (TextAlarm o in _observers)
            {   
                o.Update();
            }
        }

    }
}
