using MobPush.Model;
using System.Linq;

namespace MobPush.Builder
{
    public class PushAreasBuilder
    {
        private PushAreas pushAreas = new PushAreas();

        public PushAreas build()
        {
            return pushAreas;
        }

        public PushAreasBuilder buildCountries(params PushAreas.PushCountry[] countries)
        {
            pushAreas.countries = countries.ToList();
            return this;
        }
    }
}
