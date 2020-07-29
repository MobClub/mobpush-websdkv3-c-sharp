using Newtonsoft.Json;
using System.Collections.Generic;

namespace MobPush.Model
{
    public class PushNotify
    {
        /// <summary>
        /// 是否是定时任务：0否，1是，默认0
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int taskCron = 0;

        /// <summary>
        /// 定时消息 发送时间
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long taskTime { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        /// <summary>
        /// 可使用平台，1 android;2 ios ;3 winphone(暂不使用) ;
        /// </summary>
        public List<int> plats = new List<int>() { 1, 2 };

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        /// <summary>
        /// plat = 2下，0测试环境，1生产环境，默认1
        /// </summary>
        public int iosProduction = 1;

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        /// <summary>
        /// 离线时间，秒
        /// </summary>
        public int offlineSeconds = 3600;

        /// <summary>
        /// 推送内容
        /// NotEmpty(message = "推送消息不能为空")
        /// </summary>
        public string content { get; set; }


        /// <summary>
        /// 推送标题
        /// </summary>
        public string title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        /// <summary>
        /// 推送类型：1通知；2自定义
        /// NotNull(message = "消息类型不能为空")
        /// Determine(values = {1, 2}, message = "消息类型1：通知，2：自定义")
        /// </summary>
        public int type = 1;

        /// <summary>
        /// 自定义内容, type=2
        /// CustomMessage.class
        /// </summary>
        public CustomNotify customNotify { get; set; }

        /// <summary>
        /// android通知消息, type=1, android
        /// AndroidNotify.class
        /// </summary>
        public AndroidNotify androidNotify { get; set; }

        /// <summary>
        /// ios通知消息, type=1, ios
        /// IosNotify.class
        /// </summary>
        public IosNotify iosNotify { get; set; }

        /// <summary>
        /// 打开链接
        /// </summary>
        public string url { get; set; }

        /// <summary>
        /// 附加字段键值对的方式
        /// </summary>
        public List<PushMap> extrasMapList = new List<PushMap>();

    }
}
