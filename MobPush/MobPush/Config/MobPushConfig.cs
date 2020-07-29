namespace MobPush.Config
{
    public class MobPushConfig
    {

        /// <summary>
        /// appkey: 需要先设置此数据，怎样获取appkey请至http://www.mob.com官网
        /// </summary>
        public static string appkey { get; set; }

        /// <summary>
        /// appSecret: appkey对应密钥,需要先设置此数据
        /// </summary>
        public static string appSecret { get; set; }

        /// <summary> 
        /// baseUrl: webapi http 接口基础url
        /// </summary>
        public static string baseUrl = "http://api.push.mob.com";

    }
}
