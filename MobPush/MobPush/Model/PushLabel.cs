using System.Collections.Generic;

namespace MobPush.Model
{
    public class PushLabel
    {
        /// <summary>
        /// 标签列表, 内容是 SmartLabel.id
        /// 标签Id不能为空
        /// </summary>
        public List<string> labelIds { get; set; }

        /// <summary>
        /// mobId不能为空
        /// </summary>
        public string mobId { get; set; }

        /// <summary>
        /// 标签搭配方式, 1:与, 2:或, 3:非
        /// </summary>
        public int type = 2;

        public const int AND = 1;
        public const int OR = 2;
        public const int NOT = 3;
    }
}
