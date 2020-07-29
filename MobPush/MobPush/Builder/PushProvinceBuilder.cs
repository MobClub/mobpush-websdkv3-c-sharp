using MobPush.Model;
using System.Linq;

namespace MobPush.Builder
{
    public class PushProvinceBuilder
    {
        private PushAreas.PushProvince pushProvince = new PushAreas.PushProvince();

        public PushAreas.PushProvince build()
        {
            return pushProvince;
        }

        public PushProvinceBuilder buildProvince(string province)
        {
            pushProvince.province = province;
            return this;
        }

        public PushProvinceBuilder buildCities(params string[] cities)
        {
            pushProvince.cities = cities.ToList();
            return this;
        }

        public PushProvinceBuilder buildExcludeCities(params string[] cities)
        {
            pushProvince.excludeCities = cities.ToList();
            return this;
        }
    }
}
