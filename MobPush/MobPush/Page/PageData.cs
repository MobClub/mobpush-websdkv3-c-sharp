using System.Collections.Generic;

namespace MobPush.Page
{
    public class PageData<T>
    {
        public int totalPages { get; set; }
        public int total { get; set; }
        public List<T> content { get; set; }
    }
}
