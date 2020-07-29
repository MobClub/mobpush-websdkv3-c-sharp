using System.Collections.Generic;

namespace MobPush.Model
{
    public class PushAreas
    {
        /// <summary>
        /// 需要推送的国家列表
        /// NotEmpty(message = "地理位置[pushAreas]中国家列表[countries]不能为空")
        /// </summary>
        public List<PushCountry> countries = new List<PushCountry>();

        public class PushCountry
        {
            /// <summary>
            /// NotEmpty(message = "国家[country]不能为空")
            /// </summary>
            public string country { get; set; }

            /// <summary>
            /// 如果 provinces 不为空，则只推送指定省份
            /// 如果 provinces 为空，则推送全国
            /// </summary>
            public List<PushProvince> provinces { get; set; }

            /// <summary>
            /// 如果 provinces 为空，则排除 excludeProvinces 相关省份的推送
            /// </summary>
            public List<string> excludeProvinces { get; set; }
        }

        public class PushProvince
        {
            /// <summary>
            /// NotEmpty(message = "省份[province]不能为空")
            /// </summary>
            public string province { get; set; }

            /// <summary>
            /// 如果 cities 不为空，则只推送指定城市
            /// 如果 cities 为空，则推送全省
            /// </summary>
            public List<string> cities { get; set; }

            /// <summary>
            /// 如果 cities 为空，则排除 excludeCities 相关城市的推送
            /// </summary>
            public List<string> excludeCities { get; set; }
        }
    }
}
