//
// ICT2106 Software Design - Timer exercise
//
// Main program.
//

namespace Timer
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a clock
            Timer timer = new Timer();

            // create some alarms
            TextAlarm alarm1 = new TextAlarm("Wake up!");
            TextAlarm alarm2 = new TextAlarm("No more sleep!");

            // BeepAlarm alarm2 = new BeepAlarm();
            // timer.Attach(alarm2);

            // attach the alarms to the clock
            timer.Attach(alarm1);
            timer.Attach(alarm2);

            // run the clock for thirty seconds
            timer.Run(3);
        }
    }
}
