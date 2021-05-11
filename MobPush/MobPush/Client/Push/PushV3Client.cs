using MobPush.Builder;
using MobPush.Helper;
using MobPush.Model;
using MobPush.Res;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MobPush.Client.Push
{
    public class PushV3Client
    {
        public const string PUSH_URI = "/v3/push/createPush";
        public const string GET_BY_WORKID_URI = "/v3/push/getByWorkId";
        public const string GET_BY_WORKNO_URI = "/v3/push/getByWorkno";
        public const string CANCEL_TASK_URI = "/push/drop";
        public const string REPLACE_TASK_URI = "/push/replace";
        public const string RECALL_TASK_URI = "/push/recall";

        public static Result<PushV3Res> pushTaskV3(Model.Push push)
        {
            string postResult = HttpHelper.PostObject(PUSH_URI, push);
            try
            {
                Result<PushV3Res> result = JsonConvert.DeserializeObject<Result<PushV3Res>>(postResult);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// add async pushTaskV3 
        /// </summary>
        /// <param name="push"></param>
        /// <returns></returns>
        public static async Task<Result<PushV3Res>> pushTaskV3Async(Model.Push push)
        {
            string postResult = await HttpHelper.PostObjectAsync(PUSH_URI, push);
            try
            {
                Result<PushV3Res> result = JsonConvert.DeserializeObject<Result<PushV3Res>>(postResult);

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static Result<PushV3Res> pushAll(string workNo, string title, string content)
        {
            return pushTaskV3(
                new PushWorkBuilder()
                .setTargetAll(workNo, title, content)
                .build()
                );
        }

        public static Result<PushV3Res> pushByAlias(string workNo, string title, string content, params string[] alias)
        {
            return pushTaskV3(
                new PushWorkBuilder()
                    .setTargetByAlias(workNo, title, content, alias)
                    .build()
                    );
        }

        public static Result<PushV3Res> pushByTags(string workNo, string title, string content, params string[] tags)
        {
            return pushTaskV3(
                new PushWorkBuilder()
                    .setTargetTags(workNo, title, content, tags)
                    .build()
                    );
        }

        public static Result<PushV3Res> pushByRids(string workNo, string title, string content, params string[] rids)
        {
            return pushTaskV3(new PushWorkBuilder()
                    .setTargetRids(workNo, title, content, rids)
                    .build());
        }

        public static Result<PushV3Res> pushByAreas(string workNo, string title, string content, PushAreas pushAreas)
        {
            return pushTaskV3(new PushWorkBuilder()
                    .setTargetByAreas(workNo, title, content, pushAreas)
                    .build());
        }

        public static Result<CancelWorkRes> cancelPushTask(string workId)
        {
            return CancelPushTaskHandel(workId, 1);
        }

        public static Result<CancelWorkRes> replacePushTask(string workId, string content)
        {
            return CancelPushTaskHandel(workId, 2, content);
        }

        public static Result<CancelWorkRes> recallPushTask(string workId)
        {
            return CancelPushTaskHandel(workId, 3);
        }

        private static Result<CancelWorkRes> CancelPushTaskHandel(string workId, int taskType, string content = "")
        {
            Dictionary<string, string> postData = new Dictionary<string, string>();
            postData.Add("batchId", workId);
            if (taskType == 2)
            {
                postData.Add("content", content);
            }
            string postUri = string.Empty;
            switch (taskType)
            {
                case 1: postUri = CANCEL_TASK_URI; break;
                case 2: postUri = REPLACE_TASK_URI; break;
                case 3: postUri = RECALL_TASK_URI; break;
            }
            string postResult = HttpHelper.PostDictionary(postUri, postData);
            Result<CancelWorkRes> cancelWorkRes = JsonConvert.DeserializeObject<Result<CancelWorkRes>>(postResult);
            return cancelWorkRes;
        }

        public static Result<PushTaskV3Res> getPushByBatchId(string batchId)
        {
            return GetPushTask(batchId, 1);
        }

        /**
         * 只能获取到3天之内的任务，长时间的任务请使用 getPushByBatchId 方法获取
         */

        public static Result<PushTaskV3Res> getPushByWorkno(string workno)
        {
            return GetPushTask(workno, 2);
        }

        private static Result<PushTaskV3Res> GetPushTask(string value, int taskType)
        {
            Dictionary<string, string> postData = new Dictionary<string, string>();
            string postUri = string.Empty;
            switch (taskType)
            {
                case 1: postData.Add("workId", value); postUri = GET_BY_WORKID_URI; break;
                case 2: postData.Add("workno", value); postUri = GET_BY_WORKNO_URI; break;
            }
            string postResult = HttpHelper.PostDictionary(postUri, postData);
            Result<PushTaskV3Res> pushTaskV3Res = JsonConvert.DeserializeObject<Result<PushTaskV3Res>>(postResult);
            return pushTaskV3Res;
        }
    }
}