using System;
using System.Threading;

namespace MMPProject
{
    // Threads share data if they have a common reference to the same object instance.
    // A thread, while blocked, doesn't consume CPU resources.


    class ThreadSafe
    {
        static bool done;
        static readonly object locker = new object();

        static void Main()
        {
            new Thread(Go).Start();
            Go();
        }

        static void Go()
        {
            lock (locker)
            {
                if (!done) { Console.WriteLine("Done"); done = true; }
            }
        }
    }
}
