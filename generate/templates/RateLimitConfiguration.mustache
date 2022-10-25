using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Polly;
using Polly.RateLimit;

namespace Vault.Client
{
    /// <summary>
    /// Policy class to set the polly rate limit policies to be applied to the requests.
    /// </summary>
    public class RateLimitConfiguration
    {
        public AsyncRateLimitPolicy<HttpResponseMessage> RateLimitPolicy;

        public RateLimitConfiguration(int numberOfExecutions, TimeSpan perTimeSpan)
        {         
            RateLimitPolicy = Policy.RateLimitAsync<HttpResponseMessage>(numberOfExecutions, perTimeSpan);
        }

        public RateLimitConfiguration(AsyncRateLimitPolicy<HttpResponseMessage> rateLimitPolicy)
        {
            RateLimitPolicy = rateLimitPolicy;
        }
    }
}