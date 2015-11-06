using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedMeBack.Models
{
    public class SystemKey
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public string Key { get; set; }

        public string System { get; set; }

        public string Url { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}