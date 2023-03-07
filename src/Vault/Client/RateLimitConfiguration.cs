// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0
//
// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

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
        /// <summary>
        /// An async rate limit policy
        /// </summary>
        public AsyncRateLimitPolicy<HttpResponseMessage> RateLimitPolicy;

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitConfiguration"/> class
        /// </summary>
        public RateLimitConfiguration(int numberOfExecutions, TimeSpan perTimeSpan)
        {
            RateLimitPolicy = Policy.RateLimitAsync<HttpResponseMessage>(numberOfExecutions, perTimeSpan);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RateLimitConfiguration"/> class
        /// </summary>
        public RateLimitConfiguration(AsyncRateLimitPolicy<HttpResponseMessage> rateLimitPolicy)
        {
            RateLimitPolicy = rateLimitPolicy;
        }
    }
}