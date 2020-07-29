using MobPush.Helper;
using Newtonsoft.Json;
using System;

namespace MobPush.Res
{
    public class StatsV3Res
    {
        public const long serialVersionUID = -258327454138179322L;

        /*
         * 主键 , 批次编号(同WorkDetail主键)
         */

        public string id;

        /**
         * 创建时间
         */
        public long createAt = Convert.ToInt64(TimerHelper.GetTimeStamp());

        public void setCreateAt(long createAt)
        {
            this.createAt = createAt;
        }

        /**
         * 更新时间
         */
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public long updateAt { get; set; }

        /**
         * 第三方IDW
         */
        public String workno { get; set; }

        /**
         * 应用APPKEY
         */
        public String appkey { get; set; }

        /**
         * 属性名 StatCategoryEnum  的constName 相同 一一对应
         */
        public WorkStatCountDetail android { get; set; }
        public WorkStatCountDetail ios { get; set; }
        public WorkStatCountDetail factory { get; set; }
        public WorkStatCountDetail iostcp { get; set; }
        public WorkStatCountDetail androidtcp { get; set; }
        public WorkStatCountDetail apns { get; set; }
        public WorkStatCountDetail huawei { get; set; }
        public WorkStatCountDetail xiaomi { get; set; }
        public WorkStatCountDetail flyme { get; set; }
        public WorkStatCountDetail fcm { get; set; }
        public WorkStatCountDetail oppo { get; set; }
        public WorkStatCountDetail vivo { get; set; }
        public WorkStatCountDetail offlineIos { get; set; }
        public WorkStatCountDetail offlineAndroid { get; set; }
        public WorkStatCountDetail offlineDrop { get; set; }
        public WorkStatCountDetail offlineVivo { get; set; }
    }
    public class WorkStatCountDetail
    {
        /** 目标数 */
        public long fetchNum = 0L;
        /** 下发数 */
        public long deliverNum = 0L;
        /** 下发失败数 */
        public long deliverFailNum = 0L;
        /** 回执数目 */
        public long reportNum = 0L;
        /** 点击数目 */
        public long clickNum = 0L;

    }
}
