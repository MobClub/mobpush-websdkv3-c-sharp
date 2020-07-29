using System;

namespace MobPush.Helper
{
    public static class TimerHelper
    {
        public static double GetTimeStamp()
        {
            TimeSpan ts = DateTime.Now - new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return ts.TotalSeconds;
        }
    }
}
