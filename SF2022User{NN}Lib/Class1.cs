using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SF2022User_NN_Lib
{
    public class Calculations
    {
        public string[] AvailablePeriods(TimeSpan[] startTimes,int[] durations,TimeSpan beginWorkingTime,TimeSpan endWorkingTime,int consultationTime)
        {
            int n = 0;
            int z = 0;
            string[] result = new string[14];
            while (beginWorkingTime<=endWorkingTime)
            {

                if(beginWorkingTime==endWorkingTime)
                {
                    break;
                }



                //Console.WriteLine(beginWorkingTime);

                //Console.WriteLine(startTimes[n]);
                if ((beginWorkingTime >= startTimes[n].Subtract(TimeSpan.Parse("00:20")) && beginWorkingTime <= startTimes[n].Add(TimeSpan.Parse("00:20")))&& n !=5)
                {
                    beginWorkingTime = startTimes[n];

                    if (durations[n] < 60)
                    {
                        Console.WriteLine(beginWorkingTime);
                        beginWorkingTime = beginWorkingTime.Add(TimeSpan.Parse(String.Format("00:{0}", durations[n])));
                    }
                    else
                    {
                        Console.WriteLine(beginWorkingTime);
                        beginWorkingTime = beginWorkingTime.Add(TimeSpan.Parse(String.Format("1:00", consultationTime)));

                    }
                    n++;
                    if(n==5)
                    {
                        n = 0;
                    }
                    continue;
                }
                else
                {
                    beginWorkingTime = beginWorkingTime.Add(TimeSpan.Parse(String.Format("00:{0}", consultationTime)));
                }


                result[z] = String.Format("{1}-{0}", beginWorkingTime.ToString(), beginWorkingTime.Subtract(TimeSpan.Parse(String.Format("00:{0}", consultationTime))).ToString());
                z++;

            }


            return result;
        }
    }
}
