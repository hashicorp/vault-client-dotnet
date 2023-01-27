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
            var secretData = new Dictionary<string, string> { { "mypass", "pass" } };
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

        [Fact]
        public void SanitizePath_ShouldSanitizePath()
        {
            var pathToSanitize = "path/to/sanitize";
            var actual = ClientUtils.SanitizePath(pathToSanitize);

            var expected = "/path/to/sanitize";
            Assert.Equal(expected, actual);
        }
    }
}