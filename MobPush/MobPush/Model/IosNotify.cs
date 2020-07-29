using Newtonsoft.Json;

namespace MobPush.Model
{
    public class IosNotify
    {
        public const long serialVersionUID = 6316980682876425791L;

        public const int BADGE_TYPE_SET = 1;
        public const int BADGE_TYPE_ADD = 2;

        /// <summary>
        /// 标题- 不填写则为应用名称
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        public string subtitle { get; set; }

        /// <summary>
        /// APNs通知，通过这个字段指定声音。默认为default，即系统默认声音。 如果设置为空值，则为静音。
        /// 如果设置为特殊的名称，则需要你的App里配置了该声音才可以正常。
        /// </summary>
        public string sound = "default";

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        /// <summary>
        /// 可直接指定 APNs 推送通知的 badge，未设置这个值角标则不带角标推送
        /// </summary>
        public int badge { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        /// <summary>
        /// badgeAdd=true 时，增加badge对应的角标数，负数时，算减法
        /// 当这个数值设置了值时，会更新数据库数据
        /// 未设置这个值角标则不带角标推送
        /// 1: 绝对值，2: 修改值
        /// </summary>
        public int badgeType { get; set; }

        /// <summary>
        /// 只有IOS8及以上系统才支持此参数推送
        /// </summary>
        public string category { get; set; }

        /// <summary>
        /// 如果只携带content-available: 1,不携带任何badge，sound 和消息内容等参数，
        /// 则可以不打扰用户的情况下进行内容更新等操作即为“Silent Remote Notifications”。
        /// </summary>
        public const int SLIENT = 1;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int slientPush { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        /// <summary>
        /// 将该键设为 1 则表示有新的可用内容。带上这个键值，意味着你的 App 在后台启动了或恢复运行了，application:didReceiveRemoteNotification:fetchCompletionHandler:被调用了。
        /// </summary>
        public int contentAvailable { get; set; }

        /// <summary>
        /// 需要在附加字段中配置相应参数
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int mutableContent { get; set; }

        /// <summary>
        /// ios富文本0无 ；1 图片 ；2 视频 ；3 音频
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int attachmentType { get; set; }

        public string attachment { get; set; }
    }
}
