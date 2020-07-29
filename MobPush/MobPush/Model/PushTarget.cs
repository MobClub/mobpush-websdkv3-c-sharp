using System.Collections.Generic;

namespace MobPush.Model
{
    public class PushTarget
    {
        public const int TARGET_ALL = 1;
        public const int TARGET_ALIAS = 2;
        public const int TARGET_TAGS = 3;
        public const int TARGET_RIDS = 4;
        public const int TARGET_AREA = 5;
        public const int TARGET_LABEL = 5;
        public const int TARGET_SMS = 8;
        public const int TARGET_AREAS = 9;
        private const long serialVersionUID = 3205738723648870635L;

        /// <summary>
        /// 推送范围:0 全部；1广播；2别名；3标签；4regid；5地理位置；7智能标签;8短信补量; 9复杂地理位置
        /// WorkDetailTargetEnum
        ///
        /// NotNull
        /// Determine(values = {1, 2, 3, 4, 5, 7,8, 9}, message = "推送消息target错误")
        /// </summary>
        public int target { get; set; }

        /// <summary>
        /// target:3 => 设置推送标签集合["tag1","tag2"]
        /// </summary>
        public string[] tags { get; set; }

        /// <summary>
        /// target:3 => 标签组合方式：1并集；2交集；3补集(3暂不考虑)
        /// </summary>
        public int tagsType = 1;

        /// <summary>
        /// target:2 => 设置推送别名集合["alias1","alias2"]
        /// </summary>
        public string[] alias { get; set; }

        /// <summary>
        /// target:4 => 设置推送Registration Id集合["id1","id2"]
        /// </summary>
        public string[] rids { get; set; }

        /// <summary>
        /// target:6 => 用户分群ID
        /// </summary>
        public string block { get; set; }

        /// <summary>
        /// target:5 => 推送地理位置
        /// </summary>
        public string city { get; set; }
        public string country { get; set; }
        public string province { get; set; }

        /// <summary>
        /// target:7 => 智能标签列表, 关联关系为与, 必须同时满足条件
        /// </summary>
        public List<PushLabel> smartLabels { get; set; }

        /// <summary>
        /// target:8 => 短信补量
        /// </summary>
        public List<PushSmsSupply> smsSupply { get; set; }

        public PushAreas pushAreas { get; set; }
    }
}
