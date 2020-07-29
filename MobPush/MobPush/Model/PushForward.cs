using System.Collections.Generic;

namespace MobPush.Model
{
    public class PushForward
    {
        /**
     * 0 打开首页 1 url跳转 2  scheme 跳转
     */
        public int nextType = 0;

        /**
         * 跳转
         */
        public string url { get; set; }
        /**
         * scheme功能的的uri
         */
        public string scheme { get; set; }
        /**
         * moblink功能的参数 a=123&b=345
         */
        public List<PushMap> schemeDataList = new List<PushMap>();
    }
}
