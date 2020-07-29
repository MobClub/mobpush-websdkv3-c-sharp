using System.Collections.Generic;

namespace MobPush.Model
{
    public class PushSms
    {
        /// <summary>
        /// 指定补量范围
        /// 1广播；
        /// 2别名；
        /// 3标签；
        /// 4regid；
        ///
        /// NotNull
        /// Determine(values = {1, 2, 3, 4}, message = "短信补量target错误")
        /// </summary>
        public int target { get; set; }

        /// <summary>
        /// 短信模板id
        /// NotEmpty(message = "短信模板id不能为空")
        /// </summary>
        public string templateId { get; set; }

        /// <summary>
        /// 模板自定义参数
        /// 例如：
        /// 模板：【XXX签名】您的收益{income}元已经到账，请及时查收。
        /// templateParams: {"income":"8.8"}
        /// </summary>
        public Dictionary<string, string> templateParams { get; set; }

        /// <summary>
        /// 补量别名
        /// </summary>
        public List<string> alias { get; set; }

        /// <summary>
        /// 补量tags, 含有这些表情的设备全补量
        /// </summary>
        public List<string> tags { get; set; }

        /// <summary>
        /// 补量rid
        /// </summary>
        public List<string> rids { get; set; }
    }
}
