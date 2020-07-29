using MobPush.Model;
using System;

namespace MobPush.Res
{
    public class PushTaskV3Res
    {
        public const int TASK_CRON_ENABLE = 1;
        public const int BUSINESS_TYPE_AD = 1;
        public const int IOS_PROD = 1;
        public const int IOS_DEV = 0;
        public const long serialVersionUID = 3365392369623543343L;

        /**
         * 推送任务标识，对接用户服务端唯一ID，传入后原样返回（用户服务端自有）
         */
        public String workno;

        /**
         * 推送任务来源：webapi 、developerPlatform
         *
         * StrDetermine(values = {"webapi", "upsapi", "sdkapi", "devplat"}, message = "消息源格式错误")
         */
        public String source = "webapi";

        /**
         * NotEmpty(message = "[appkey]不能为空")
         */
        public String appkey;

        /**
         * NotNull(message = "[pushTarget]不能为空")
         */
        public PushTarget pushTarget;

        /**
         * 推送展示细节
         * NotNull(message = "[pushNotify]不能为空")
         */
        public PushNotify pushNotify;

        /**
         * 运营保障相关配置
         */
        public PushOperator pushOperator = new PushOperator();

        /**
         * link 相关打开配置
         */
        public PushForward pushForward;

        /**
         * 短信补量相关配置
         */
        public PushSms pushSms;
    }
}
