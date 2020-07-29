using MobPush.Model;
using System.Linq;

namespace MobPush.Builder
{
    public class PushCountryBuilder
    {
        private PushAreas.PushCountry pushCountry = new PushAreas.PushCountry();

        public PushAreas.PushCountry buid()
        {
            return pushCountry;
        }

        public PushCountryBuilder buildPushProvince(params PushAreas.PushProvince[] pushProvince)
        {
            pushCountry.provinces = pushProvince.ToList();
            return this;
        }

        public PushCountryBuilder buildPushCountry(string country)
        {
            pushCountry.country = country;
            return this;
        }

        public PushCountryBuilder builExcludeProvinces(params string[] province)
        {
            pushCountry.excludeProvinces = province.ToList();
            return this;
        }
    }
}
