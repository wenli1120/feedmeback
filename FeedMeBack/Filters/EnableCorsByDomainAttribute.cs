using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Cors;
using System.Web.Helpers;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;
using System.Web.Http.Filters;
using System.Web.Mvc;
using FeedMeBack.Models;

namespace FeedMeBack.Filters
{
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false)]
    public class EnableCorsByDomainAttribute : Attribute, ICorsPolicyProvider
    {
        private readonly CorsPolicy _policy;

        private FeedMeBackContext db = new FeedMeBackContext();


        public EnableCorsByDomainAttribute()
        {
            _policy = new CorsPolicy
            {
                AllowAnyMethod = true,
                AllowAnyHeader = true
            };

            var listOfUrl = db.SystemKeys.Select(x => x.Url).ToList();

            foreach (var origin in listOfUrl)
            {
                _policy.Origins.Add(origin);
            }

        }

        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_policy);
        }
    }
}