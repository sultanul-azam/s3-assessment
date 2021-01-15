using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var callStartTime = "2019-08-31 08:59:13 am"; // First Input
            var callEndTime = "2019-08-31 09:00:39 am";  // Second Input

            var peekHourStart = "9.00.00";
            var peekHourEnd = "10.59.59";

            var firstOffPeekHourStart = "12.00.00";
            var firstOffPeekHourEnd = "8.59.59";

            var secondOffPeekHourStart = "11.00.00";    
            var secondOffPeekHourEnd = "11.59.59";

            var stTime = GetTime(callStartTime);
            var endTime = GetTime(callEndTime);

            var peekHour = peekHourStart.Split('.');

            int totalOffPeekSec = 0, pulse = 0;
            double offPeekTotal = 0;

            if (stTime.Hour < Convert.ToInt32(peekHour[0]))
            {
                totalOffPeekSec = (stTime.Minute - stTime.Second);
                pulse = totalOffPeekSec / 20;
                offPeekTotal = pulse / 0.30;
                Console.WriteLine(offPeekTotal);
            }           
        }  

        public static TimeSlots GetTime(string datetime)
        {
            var time = Convert.ToDateTime(datetime);

            var timeSlots = new TimeSlots();
            timeSlots.Hour = time.Hour;
            timeSlots.Minute = time.Minute;
            timeSlots.Second = time.Second;

            return timeSlots;
        }

        public  class TimeSlots
        {
            public int Hour { get; set; }
            public int Minute { get; set; }
            public int Second { get; set; }
        }
    }
}
