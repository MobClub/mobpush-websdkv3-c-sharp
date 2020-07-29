using System.Collections.Generic;

namespace MobPush.Res
{
    public class AppDeviceStatsRes
    {
        protected string id { get; set; }

        public string rid { get; set; }

        public string alias { get; set; }

        public string guardId { get; set; }

        public string tag { get; set; }

        public string workId { get; set; }

        public string patchId { get; set; }

        public List<string> deliver { get; set; }

        public List<long> deliverTime { get; set; }

        public List<string> report { get; set; }

        public List<long> reportTime { get; set; }

        public List<string> click { get; set; }

        public List<long> clickTime { get; set; }

    }
}
