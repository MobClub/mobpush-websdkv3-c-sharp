using MobPush.Config;
using MobPush.Helper;
using MobPush.Page;
using MobPush.Res;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace MobPush.Client.Stats
{
    public class StatsV3Client
    {
        public const string GET_BY_WORKID_URI = "/v3/stats/getByWorkId";
        public const string GET_BY_WORKIDS_URI = "/v3/stats/getByWorkIds";
        public const string GET_BY_WORKNO_URI = "/v3/stats/getByWorkno";
        public const string GET_BY_HOUR_URI = "/v3/stats/getByHour";
        public const string GET_BY_DAY_URI = "/v3/stats/getByDay";
        public const string GET_BY_DEVICE_URI = "/v3/stats/getByDevice";


        public static Result<StatsV3Res> getStatsByWorkId(string workId)
        {
            return getStats(workId, 1);
        }

        public static Result<List<StatsV3Res>> getStatsByWorkIds(List<string> workIds)
        {
            Dictionary<string, object> postData = new Dictionary<string, object>();
            postData.Add("workIds", workIds);
            string postResult = HttpHelper.PostDictionary(GET_BY_WORKIDS_URI, postData);
            Result<List<StatsV3Res>> result = JsonConvert.DeserializeObject<Result<List<StatsV3Res>>>(postResult);

            return result;
        }

        public static Result<StatsV3Res> getStatsByWorkno(string workno)
        {
            return getStats(workno, 2);
        }

        private static Result<StatsV3Res> getStats(string value, int type)
        {
            Dictionary<string, object> postData = new Dictionary<string, object>();
            string postUri = string.Empty;
            switch (type)
            {
                case 1: postData.Add("workId", value); postUri = GET_BY_WORKID_URI; break;
                case 2: postData.Add("workno", value); postUri = GET_BY_WORKNO_URI; break;
            }
            string postResult = HttpHelper.PostDictionary(postUri, postData);
            Result<StatsV3Res> result = JsonConvert.DeserializeObject<Result<StatsV3Res>>(postResult);
            return result;
        }

        public static Result<AppHourStatsRes> getStatsByHour(string hour)
        {
            Dictionary<string, string> postData = new Dictionary<string, string>();
            postData.Add("hour", hour);
            string postResult = HttpHelper.PostDictionary(GET_BY_HOUR_URI, postData);
            Result<AppHourStatsRes> result = JsonConvert.DeserializeObject<Result<AppHourStatsRes>>(postResult);
            return result;
        }

        public static Result<AppDayStatsRes> getStatsByDay(string day)
        {
            Dictionary<string, string> postData = new Dictionary<string, string>();
            postData.Add("day", day);
            string postResult = HttpHelper.PostDictionary(GET_BY_DAY_URI, postData);
            Result<AppDayStatsRes> result = JsonConvert.DeserializeObject<Result<AppDayStatsRes>>(postResult);
            return result;
        }

        public static Result<PageData<AppDeviceStatsRes>> getStatsByDevice(string workId, int pageIndex, int pageSize)
        {
            Dictionary<string, object> postData = new Dictionary<string, object>();
            postData.Add("workId", workId);
            postData.Add("pageIndex", pageIndex);
            postData.Add("pageSize", pageSize);
            string postResult = HttpHelper.PostDictionary(GET_BY_DEVICE_URI, postData);
            Result<PageData<AppDeviceStatsRes>> result = JsonConvert.DeserializeObject<Result<PageData<AppDeviceStatsRes>>>(postResult);
            return result;
        }
    }
}
