using System;
using static System.Console;

namespace hour_min_sec
{
    class Program
    {
        // use class-level static variables, since
        // we are not instantiating objects (yet!)
        static int totalSeconds,
                   hours,
                   minutes,
                   seconds;
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
        }
    }
}
