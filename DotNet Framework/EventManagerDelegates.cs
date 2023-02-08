using System;

using System.Threading;

namespace FrameWorksApp
{
    delegate void CallMe(string str);
    class ShowClock
    {
        private static DateTime _alarmSetter;
        public static event CallMe OnAlarmTime;
        public static void setAlarm(DateTime time)
        {
            _alarmSetter = time;
        }
        public static void ShowClockFunc()
        {
            do
            {
                if(DateTime.Now.Minute == _alarmSetter.Minute)
                {
                    if(OnAlarmTime != null)
                    {
                        OnAlarmTime("time to break");
                        Console.Beep(2000, 10000);
                    }
                }

                Console.WriteLine(DateTime.Now.ToLongTimeString());
                Thread.Sleep(1000);
                Console.Clear();
            } while (true);
        }
    }
    class EventManagerDelegates
    {
        static void Main(string[] args)
        {
            ShowClock.OnAlarmTime += ShowClock_OnAlarmTime;
            ShowClock.setAlarm(DateTime.Now.AddMinutes(1));
            ShowClock.ShowClockFunc();
        }

        private static void ShowClock_OnAlarmTime(string str)
        {
            Console.WriteLine(str);
        }
    }
}
