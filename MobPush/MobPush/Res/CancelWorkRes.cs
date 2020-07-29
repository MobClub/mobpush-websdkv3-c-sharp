namespace MobPush.Res
{
    public class CancelWorkRes
    {
        public const long serialVersionUID = -5708586329117384238L;

        /// <summary>
        /// 新的batchId
        /// </summary>
        public string batchId { get; set; }

        /// <summary>
        ///  0 取消失败 
        ///  1 取消成功
        /// </summary>
        public int code { get; set; }

        /// <summary>
        /// 任务状态  
        /// 1创建中；
        /// 2等待发送；
        /// 3发送中；
        /// 4发送完成；
        /// 5发送失败；
        /// 6停止发送 
        /// 7已取消 
        /// 8 取消成功 
        /// 9 已撤回
        /// </summary>
        public int status { get; set; }

        /// <summary>
        /// 错误消息
        /// </summary>
        public string errorMsg { get; set; }
    }
}
