// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0

using System;
using System.Collections.Generic;
using System.Net.Http;

using Vault.Client;
using Xunit;

namespace Vault.Test
{
    public class ClientUtilsTests
    {
        [Fact]
        public void CloneRequest_ExceptionIfNull()
        {
            // Test for thrown exception
            Assert.Throws<ArgumentNullException>("req", () => ClientUtils.CloneRequest(null));
        }

        [Fact]
        public void CloneRequest_ShouldCloneHttpRequest()
        {
            // Create a dummy request message
            HttpRequestMessage expectedReq = new HttpRequestMessage();
            expectedReq.Method = HttpMethod.Get;
            expectedReq.Headers.TryAddWithoutValidation("X-Example-Header", "my-header-value");

            HttpRequestMessage actualReq = ClientUtils.CloneRequest(expectedReq);

            Assert.Equal(expectedReq.Method, actualReq.Method);
            Assert.Equal(expectedReq.Headers.ToString(), actualReq.Headers.ToString());
        }

        [Fact]
        public void SanitizePath_ExceptionIfEmpty()
        {
            // Test for thrown exception
            Assert.Throws<ArgumentNullException>("path", () => ClientUtils.SanitizePath(string.Empty));
        }

        [Theory]
        [InlineData("path/to/sanitize", "/path/to/sanitize")]
        [InlineData("/path/to/sanitize", "/path/to/sanitize")]
        public void SanitizePath_ShouldSanitizePath(string pathToSanitize, string expected)
        {
            var actual = ClientUtils.SanitizePath(pathToSanitize);

            Assert.Equal(expected, actual);
        }
    }
}