using MobPush.Config;
using MobPush.Model;
using System.Collections.Generic;

namespace MobPush.Builder
{
    public class PushWorkBuilder
    {

        public const int TARGET_ALL = 1;
        public const int TARGET_ALIAS = 2;
        public const int TARGET_TAGS = 3;
        public const int TARGET_RIDS = 4;
        public const int TARGET_AREAS = 9;

        private Push push = new Push();

        public Push build()
        {
            push.appkey = MobPushConfig.appkey;
            return push;
        }

        public void fillParams(string workNo, string title, string content)
        {
            if (push.pushTarget == null)
            {
                push.pushTarget = new PushTarget();
            }
            push.workno = workNo;
            if (push.pushNotify == null)
            {
                push.pushNotify = new PushNotify();
            }
            push.pushNotify.title = title;
            push.pushNotify.content = content;
        }


        public PushWorkBuilder setTargetAll(string workNo, string title, string content)
        {
            this.fillParams(workNo, title, content);
            push.pushTarget.target = TARGET_ALL;
            return this;
        }

        public PushWorkBuilder setTargetByAlias(string workNo, string title, string content, params string[] alias)
        {
            this.fillParams(workNo, title, content);
            push.pushTarget.target = TARGET_ALIAS;
            push.pushTarget.alias = alias;
            return this;
        }

        public PushWorkBuilder setTargetTags(string workNo, string title, string content, params string[] tags)
        {
            this.fillParams(workNo, title, content);
            push.pushTarget.target = TARGET_TAGS;
            push.pushTarget.tags = tags;
            return this;
        }

        public PushWorkBuilder setTargetRids(string workNo, string title, string content, params string[] rids)
        {
            this.fillParams(workNo, title, content);
            push.pushTarget.target = TARGET_RIDS;
            push.pushTarget.rids = rids;
            return this;
        }

        public PushWorkBuilder setTargetByAreas(string workNo, string title, string content, PushAreas pushAreas)
        {
            this.fillParams(workNo, title, content);
            push.pushTarget.target = TARGET_AREAS;
            push.pushTarget.pushAreas = pushAreas;
            return this;
        }

        public PushWorkBuilder setNotifyExtraParams(string key, string value)
        {
            PushMap pushMap = new PushMap();
            pushMap.key = key;
            pushMap.value = value;
            push.pushNotify.extrasMapList.Add(pushMap);
            return this;
        }

        public PushWorkBuilder setNotifyExtraMap(List<PushMap> extraMap)
        {
            push.pushNotify.extrasMapList.AddRange(extraMap);
            return this;
        }


        public PushWorkBuilder setForwardExtraParams(string key, string value)
        {
            PushMap pushMap = new PushMap();
            pushMap.key = key;
            pushMap.value = value;
            push.pushForward.schemeDataList.Add(pushMap);
            return this;
        }

        public PushWorkBuilder setForwardExtraMap(List<PushMap> extraMap)
        {
            push.pushForward.schemeDataList.AddRange(extraMap);
            return this;
        }

    }
}
