using System;

namespace MobPush.Model
{
    public class PushSmsSupply
    {
        /// <summary>
        /// NotEmpty(message = "短信补量rid不能为空")
        /// </summary>
        public String rid { get; set; }
        public String phone { get; set; }
    }
}
