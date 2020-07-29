namespace MobPush.Res
{
    public class AppDayStatsRes : AppStatsBaseRes
    {
        /// <summary>
        /// appkey_day
        /// </summary>
        public string id { get; set; }

        public string appkey { get; set; }
        /// <summary>
        ///  显示日期
        ///  yyyyMMdd
        ///  20190925
        /// </summary>
        public string day { get; set; }
    }
}
