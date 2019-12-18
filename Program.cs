using System;
using static System.Console;

namespace hour_min_sec
{
    class Program
    {
        // use class-level static variables, since
        // we are not instantiating objects (yet!)
        static int totalSeconds,
                   remainingSeconds,
                   hours,
                   minutes,
                   seconds;
        static void Main(string[] args)
        {
            totalSeconds = ReadInt("Please enter total number of seconds:");
            remainingSeconds = totalSeconds;
            CalculateHours();
            CalculateMinutes();
            CalculateSeconds();
            WriteLine(FormatOutput());
        }
        static int ReadInt(string label)
        {
            Write("{0} ", label);
            int number;
            string userInput = ReadLine();
            while (int.TryParse(userInput, out number) == false)
            {
                Write("{0} {1} ", "Invalid input!", label);
                userInput = ReadLine();
            }
            return number;
        }
        // use void methods to perform calculations
        static void CalculateHours()
        {
            hours = remainingSeconds / 360;
            remainingSeconds %= 360;
        }
        static void CalculateMinutes()
        {
            minutes = remainingSeconds / 60;
            remainingSeconds %= 60;
        }
        static void CalculateSeconds()
        {
            seconds = remainingSeconds;
        }
        static string FormatOutput()
        {
            string result = String.Format("{0}\n", "********* Time Table *********");
            result += String.Format("{0, 16} {1, 12:N0}\n", "Total seconds:", totalSeconds);
            result += String.Format("{0, 16} {1, 12:N0}\n", "Hours:", hours);
            result += String.Format("{0, 16} {1, 12:N0}\n", "Minutes:", minutes);
            result += String.Format("{0, 16} {1, 12:N0}\n", "Seconds:", seconds);
            result += String.Format("{0}\n", "******************************");
            return result;
        }
    }
}
