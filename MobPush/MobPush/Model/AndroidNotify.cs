namespace MobPush.Model
{
    public class AndroidNotify
    {
        /// <summary>
        /// 通知标题
        /// </summary>
        public string appName { get; set; }

        /// <summary>
        /// 如果不设置，则默认的通知标题为应用的名称。
        /// Length(max = 20, message = "推送标题最大长度20")
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// warn:  提醒类型： 1提示音；2震动；3指示灯
        /// 如果多个组合则对应编号组合如：12 标识提示音+震动
        /// </summary>
        public string warn = "12";

        /// <summary>
        /// 显示样式标识  0、默认通知无； 1、长内容则为内容数据； 2、大图则为图片地址； 3、横幅则为多行内容
        /// Determine(values = {0, 1, 2, 3}, message = "安卓消息格式参数错误")
        /// </summary>
        public int style = 0;

        /// <summary>
        /// content:  style样式具体内容
        /// </summary>
        public string[] content { get; set; }

        /// <summary>
        /// 自定义声音
        /// </summary>
        public string sound { get; set; }

    }
}
