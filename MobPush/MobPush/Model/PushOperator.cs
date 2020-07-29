namespace MobPush.Model
{
    public class PushOperator
    {
        /// <summary>
        /// 运营保障 消息 修改类型： 1 取消 2 替换 3 撤回
        /// </summary>
        protected int dropType { get; set; }

        /// <summary>
        /// 撤回的消息的id
        /// </summary>
        protected string dropId { get; set; }

        /// <summary>
        /// 给每条消息设置唯一的消息id
        /// 有替换和撤回
        /// 1 根据workId 查询到 原来的消息id
        /// 2 如果是替换 直接 重置 notifyId
        /// 3 如果是撤回 设置dropId 为 notifyId 通知客户端去撤回那条消息
        /// </summary>
        protected string notifyId { get; set; }
    }
}
