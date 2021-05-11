using MobPush.Config;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MobPush.Helper
{
    public class HttpHelper
    {
        /// <summary>
        /// fix 静态化httpClient
        /// </summary>
        private static HttpClient client = new HttpClient();

        /// <summary>
        /// 发起POST同步请求
        ///
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postData"></param>
        /// <param name="contentType">application/xml、application/json、application/text、application/x-www-form-urlencoded</param>
        /// <param name="headers">填充消息头</param>
        /// <returns></returns>
        public static string HttpPost(string url, string postData = null, string contentType = null, int timeOut = 30, Dictionary<string, string> headers = null)
        {
            try
            {
                postData = postData ?? "";
                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }
                using (HttpContent httpContent = new StringContent(postData, Encoding.UTF8))
                {
                    if (contentType != null)
                    {
                        httpContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
                    }
                    else
                    {
                        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    }

                    HttpResponseMessage response = client.PostAsync(MobPushConfig.baseUrl + url, httpContent).Result;
                    var result = response.Content.ReadAsStringAsync().Result;
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 发起POST异步请求
        /// </summary>
        /// <param name="url"></param>
        /// <param name="postData"></param>
        /// <param name="contentType">application/xml、application/json、application/text、application/x-www-form-urlencoded</param>
        /// <param name="headers">填充消息头</param>
        /// <returns></returns>
        public static async Task<string> HttpPostAsync(string url, string postData = null, string contentType = null, int timeOut = 30, Dictionary<string, string> headers = null)
        {
            try
            {
                postData = postData ?? "";
                if (headers != null)
                {
                    foreach (var header in headers)
                    {
                        client.DefaultRequestHeaders.Add(header.Key, header.Value);
                    }
                }
                using (HttpContent httpContent = new StringContent(postData, Encoding.UTF8))
                {
                    if (contentType != null)
                    {
                        httpContent.Headers.ContentType = new MediaTypeHeaderValue(contentType);
                    }
                    else
                    {
                        httpContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                    }

                    HttpResponseMessage response = await client.PostAsync(MobPushConfig.baseUrl + url, httpContent);
                    var result = await response.Content.ReadAsStringAsync();
                    return result;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string PostObject(string postUri, object postData)
        {
            try
            {
                string postDataStr = JsonConvert.SerializeObject(postData);
                Dictionary<string, string> header = new Dictionary<string, string>();
                header.Add("sign", serverSign(postDataStr, MobPushConfig.appSecret));
                header.Add("key", MobPushConfig.appkey);
                return HttpPost(postUri, postDataStr, headers: header);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// add async
        /// </summary>
        /// <param name="postUri"></param>
        /// <param name="postData"></param>
        /// <returns></returns>
        public static async Task<string> PostObjectAsync(string postUri, object postData)
        {
            try
            {
                string postDataStr = JsonConvert.SerializeObject(postData);
                Dictionary<string, string> header = new Dictionary<string, string>();
                header.Add("sign", serverSign(postDataStr, MobPushConfig.appSecret));
                header.Add("key", MobPushConfig.appkey);
                return await HttpPostAsync(postUri, postDataStr, headers: header);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static string PostDictionary(string postUri, Dictionary<string, object> postData)
        {
            try
            {
                postData.Add("appkey", MobPushConfig.appkey);
                return PostObject(postUri, postData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string PostDictionary(string postUri, Dictionary<string, string> postData)
        {
            try
            {
                postData.Add("appkey", MobPushConfig.appkey);
                return PostObject(postUri, postData);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string serverSign(string decodeData, string appSecret)
        {
            return MD5Helper.GenerateMD5(decodeData + appSecret);
        }
    }
}
