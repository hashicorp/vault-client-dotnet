// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0
//
// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vault.Client
{
    /// <summary>
    /// API Exception
    /// </summary>
    public class VaultApiException : Exception
    {
        /// <summary>
        /// Gets or sets the error code (HTTP status code)
        /// </summary>
        /// <value>The error code (HTTP status code).</value>
        public int StatusCode { get; private set; }

        /// <summary>
        /// Gets or sets the list of Api Errors
        /// </summary>
        public IEnumerable<string> Errors { get; private set; }

        /// <summary>
        /// Gets or sets the HTTP headers
        /// </summary>
        /// <value>HTTP headers</value>
        public Multimap<string, string> Headers { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultApiException"/> class.
        /// </summary>
        public VaultApiException() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultApiException"/> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        public VaultApiException(int statusCode, string message) : base(message)
        {
            this.StatusCode = statusCode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VaultApiException"/> class.
        /// </summary>
        /// <param name="statusCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        /// <param name="errorContent">Error content.</param>
        /// <param name="headers">HTTP Headers.</param>
        public VaultApiException(int statusCode, string message, string errorContent, Multimap<string, string> headers = null) : base(message)
        {
            this.StatusCode = statusCode;
            this.Headers = headers;

            try
            {
                var structured = JsonConvert.DeserializeObject<Dictionary<string, IEnumerable<string>>>(errorContent);

                if (structured.ContainsKey("errors"))
                {
                    this.Errors = structured["errors"];
                }
            }
            catch
            {
                // With a deserialization exception we set the full 
                // error content to the first element
                this.Errors = new List<string>() { errorContent };
            }
        }
    }

}
