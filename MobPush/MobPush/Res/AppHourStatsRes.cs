namespace MobPush.Res
{
    public class AppHourStatsRes : AppStatsBaseRes
    {
        /// <summary>
        /// appkey_hour
        /// </summary>
        public string id { get; set; }

        public string appkey { get; set; }

        /// <summary>
        /// 显示日期
        /// yyyyMMddHH
        /// 2019092500
        /// 2019092523
        /// </summary>
        public string hour { get; set; }
    }
}
