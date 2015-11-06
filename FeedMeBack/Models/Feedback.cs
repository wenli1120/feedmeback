using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedMeBack.Models
{
    public class Feedback
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        public string UserName { get; set; }

        public string UserIpAddress { get; set; }

        public string Key { get; set; }

        public string System { get; set; }

        public DateTime CreatedOn { get; set; }

        public string Message { get; set; }
    }
}