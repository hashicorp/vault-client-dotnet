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
        public RateLimitPolicy RateLimitPolicy;

        public RateLimitConfiguration(int numberOfExecutions, TimeSpan perTimeSpan)
        {         
            RateLimitPolicy = Policy.RateLimit(numberOfExecutions, perTimeSpan);
        }

        public RateLimitConfiguration(RateLimitPolicy rateLimitPolicy)
        {
            RateLimitPolicy = rateLimitPolicy;
        }
    }
}