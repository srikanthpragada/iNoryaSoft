using System;
using System.Threading;

namespace csdemo
{
    delegate void ProcessCompleted();
    public class EventsDemo
    {
        static event ProcessCompleted completed; 
        public static void Main(string[] args)
        {
            Console.WriteLine("Process starting...");
            //ProcessCompleted pc = DoneProcess;
            //pc.Invoke();
                
            completed += DoneProcess;
            Thread t = new Thread(Process);
            t.Start();

            Thread t2 = new Thread(() => Console.WriteLine("In Thread"));
            t2.Start();

            Console.WriteLine("Back in Main");
        }

        public static void DoneProcess()
        {
            Console.WriteLine("Done process!");
        }
        public static void Process() 
        {
            // some lengthy process in a separate thread
            Thread.Sleep(10000);
            if (completed != null)
                  completed(); 
        }
    }
}
