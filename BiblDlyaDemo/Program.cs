using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SF2022User_NN_Lib;

namespace BiblDlyaDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan ts1 = TimeSpan.Parse("10:00");
            TimeSpan ts2 = TimeSpan.Parse("11:00");
            TimeSpan ts3 = TimeSpan.Parse("15:00");
            TimeSpan ts4 = TimeSpan.Parse("15:30");
            TimeSpan ts5 = TimeSpan.Parse("16:50");

            TimeSpan[] ts = { ts1, ts2, ts3, ts4, ts5 };

            int[] durations = { 60, 30, 10, 10, 40 };

            TimeSpan ts6 = TimeSpan.Parse("8:00");
            TimeSpan ts7 = TimeSpan.Parse("18:00");

            var ch = new SF2022User_NN_Lib.Calculations();
            string[] s = ch.AvailablePeriods(ts, durations, ts6, ts7, 30);

            foreach (string s2 in s)
            {
                Console.WriteLine(s2);
            }
        }
    }
}
