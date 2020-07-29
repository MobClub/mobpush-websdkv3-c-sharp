namespace MobPush.Model
{
    public class Push
    {
        public const int TASK_CRON_ENABLE = 1;
        public const int BUSINESS_TYPE_AD = 1;
        public const int IOS_PROD = 1;
        public const int IOS_DEV = 0;
        private const long serialVersionUID = -1914482721382496441L;

        /**
         * 推送任务标识，对接用户服务端唯一ID，传入后原样返回（用户服务端自有）
         */
        public string workno { get; set; }

        /**
         * 推送任务来源：webapi 、developerPlatform
         *
         * StrDetermine(values = {"webapi", "upsapi", "sdkapi", "devplat"}, message = "消息源格式错误")
         */
        public string source = "webapi";

        /**
         * NotEmpty(message = "[appkey]不能为空")
         */
        public string appkey { get; set; }

        /**
         * NotNull(message = "[pushTarget]不能为空")
         */
        public PushTarget pushTarget { get; set; }

        /**
         * 推送展示细节
         * NotNull(message = "[pushNotify]不能为空")
         */
        public PushNotify pushNotify { get; set; }

        /**
         * 运营保障相关配置
         */
        public PushOperator pushOperator = new PushOperator();

        /**
         * link 相关打开配置
         */
        public PushForward pushForward { get; set; }

        /**
         * 短信补量相关配置
         */
        public PushSms pushSms { get; set; }

    }
}
