// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0
//
// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.


using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using Polly;
using Polly.Retry;

namespace Vault.Client
{
    /// <summary>
    /// Configuration class to set the polly retry policies to be applied to the requests.
    /// </summary>
    public class RetryConfiguration
    {
        /// <summary>
        /// Http status codes to retry on
        /// </summary>
        /// <remarks>
        /// PreconditionFailed is apart of replication logic and is returned when 
        /// "X-Vault-Index" isn't satisfied
        /// </remarks>
        private static readonly HttpStatusCode[] _retryStatusCodes = {
            HttpStatusCode.PreconditionFailed,  // 412
            HttpStatusCode.InternalServerError, // 500
            HttpStatusCode.BadGateway,          // 502
            HttpStatusCode.ServiceUnavailable,  // 503
            HttpStatusCode.GatewayTimeout,      // 504
        };

        /// <summary>
        /// Async retry policy
        /// </summary>
        public Polly.AsyncPolicy<HttpResponseMessage> RetryPolicy { get; set; }

        /// <summary>
        /// Creates a new RetryConfiguration object
        /// </summary>
        /// <param name="MaxRetryCount">Maximum times to retry a request.</param>
        /// <param name="TimeBetweenRetries">Time to wait in between retries.</param>
        public RetryConfiguration(int MaxRetryCount, TimeSpan TimeBetweenRetries)
        {
            RetryPolicy = Policy
                    .HandleResult<HttpResponseMessage>(r => _retryStatusCodes.Contains(r.StatusCode))       
                    .WaitAndRetryAsync(MaxRetryCount, _ => TimeBetweenRetries);
        }

        /// <summary>
        /// Creates a new RetryConfiguration object
        /// </summary>
        public RetryConfiguration(AsyncRetryPolicy<HttpResponseMessage> retryPolicy)
        {
            RetryPolicy = retryPolicy;
        }
    }
}
