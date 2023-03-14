# Vault .NET Client Library

[![Build][ci-build-badge]][ci-build] [![NuGet][nuget-badge]][nuget]

A .NET client library [generated][openapi-generator] from `OpenAPI`
[specification file][openapi-spec] to interact with [Hashicorp][hashicorp]
[Vault][vault].

> _**Note**_: This library is currently marked as **BETA**. Please try it out
> and give us feedback! Please do not use it in production.

> _**Note**_: We take Vault's security and our users' trust very seriously. If
> you believe you have found a security issue in Vault .NET, _please responsibly
> disclose_ by contacting us at
> [security@hashicorp.com](mailto:security@hashicorp.com).

## Contents

- [Vault .NET Client Library](#vault-net-client-library)
  - [Installation](#installation)
    - [Frameworks supported](#frameworks-supported)
  - [Examples](#examples)
    - [Getting Started](#getting-started)
    - [Configuring a Vault Client](#configuring-a-vault-client)
    - [Setting Headers](#setting-headers)
    - [Authenticating with Vault](#authenticating-with-vault)
    - [Reading a KV Secret](#reading-a-kv-secret)
    - [Exception Handling](#exception-handling)
    - [Wrapping and Unwrapping Responses](#wrapping-and-unwrapping-responses)
    - [Performing Generic Operations](#performing-generic-operations)
  - [Contributing to Vault .Net Library](#contributing-to-vault-net-library)
    - [Local Development](#local-development)
  - [Documentation for API Endpoints](#documentation-for-api-endpoints)

## Installation

Vault is a package available at [Hashicorp Nuget][nuget-hashicorp]. We've
provided install commands below.

Using Powershell:

```shell-session
 Install-Package HashiCorp.Vault -Version "0.1.0-beta"
```

Using Nuget CLI:

```shell-session
 nuget install HashiCorp.Vault -Version "0.1.0-beta"
```

> _**Note**_: You can find the latest package version in the Release tab in
> GitHub.

You can add the package to your .Net project using the following command:

```shell-session
dotnet add package Hashicorp.Vault -version "0.1.0-beta"
```

### Frameworks supported

- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

## Examples

### Getting Started

Here is a simple copy-pastable example of using the library to write a secret to
the kv secrets engine and then read the secret back. This example works with a
Vault server started in dev mode with a hardcoded root token (e.g.
`vault server -dev -dev-root-token-id="my-token"`);

```csharp
using Vault;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {
            string address = "http://127.0.0.1:8200";
            VaultConfiguration config = new VaultConfiguration(address);

            VaultClient vaultClient = new VaultClient(config);
            vaultClient.SetToken("my-token");

            try
            {
                var secretData = new Dictionary<string, string> { { "mypass", "pass" } };

                // Write a secret
                var kvRequestData = new KVv2WriteRequest(secretData);

                vaultClient.Secrets.KVv2Write("mypath", kvRequestData);

                // Read a secret
                VaultResponse<Object> resp = vaultClient.Secrets.KVv2Read("mypath");
                Console.WriteLine(resp.Data);
            }
            catch (VaultApiException e)
            {
                Console.WriteLine("Failed to read secret with message {0}", e.Message);
            }
        }
    }
}
```

_**Note**_: the responses are currently generic objects that need to be
marshalled into an appropriate model. Structured responses are coming soon!

### Configuring a Vault Client

The VaultClient requires you pass it a `VaultConfiguration` object.

```csharp
VaultConfiguration config = new VaultConfiguration("http:127.0.0.1:8200");
VaultClient vaultClient = new VaultClient(config);
```

You can also add custom configuration including a custom `HttpClientHandler`.
This can be used to intercept requests and add custom logic before the base
`SendAsync` is called by the HttpClient. See [HttpClientHandler
docs][http-client-handler-docs] for more details.

```csharp
// Create a custom HttpClientHandler
HttpClientHandler myClientHandler = new HttpClientHandler();

VaultConfiguration config = new VaultConfiguration("http://127.0.0.1:8200",
                                          myClientHandler);
```

The VaultClient also allows you to set a custom Timeout for all API calls.

```csharp
VaultConfiguration config = new VaultConfiguration(basePath: address,
                                        httpClientHandler: httpClientHandler,
                                        timeout: TimeSpan.FromSeconds(15));
```

### Setting Headers

The `SetToken` method can be used to set the `X-Vault-Token` header with the
given token for subsequent requests.

```csharp
vaultClient.SetToken("my-token");
```

The `SetNamespace` can be used to set the default namespace header.

```csharp
vaultClient.SetNamespace("n1");
vaultClient.ClearNamespace();
```

The Vault client also allows for adding custom headers that will be applied to
every request.

```csharp
IDictionary<string, string> myCustomHeaders = new Dictionary<string, string>
{
    { "my-custom-header", "myHeaders"}
};

vaultClient.AddCustomHeaders(myCustomHeaders);
vaultClient.ClearCustomHeaders();
```

### Authenticating with Vault

In the previous example we used an insecure (root token) authentication method.
For production applications, it is recommended to use [approle][doc-approle] or
one of the platform-specific authentication methods instead (e.g.
[kubernetes][doc-kubernetes], [AWS][doc-aws], [Azure][doc-azure], etc.). The
functions to access these authentication methods are automatically generated
under `vaultClient.Auth`. Below is an example of how to authenticate using
`approle` authentication method. Please refer to the [approle
documentation][doc-approle] for more details.

```csharp
VaultResponse<Object> vaultResp = vaultClient.Auth.PostAuthApproleLogin(
    new ApproleLoginRequest(roleId: "myRoleId", secretId: "mySecretId"),
    approleMountPath: "myMountPath");

vaultClient.SetToken(token: vaultResp.ResponseAuth.ClientToken);
```

The secret identifier is often delivered as a wrapped token. In this case, you
should unwrap it first as demonstrated
[here](#wrapping-and-unwrapping-responses).

### Reading a KV Secret

To call secrets endpoints, simply use the `VaultClient.Secrets` object, as shown
below.

All secrets and auth calls have an optional mount path parameter that can be
specified, otherwise we will use a default mount path.

```csharp
VaultResponse<Object> resp = await vaultClient.Secrets.KVv2ReadAsync("path", secretMountPath: "myCustomMountPath");
Console.WriteLine(resp.Data);
```

All calls have both an async and synchronous implementation. E.g.

```csharp
VaultResponse<Object> respAsync = await vaultClient.Secrets.KVv2ReadAsync("path");
VaultResponse<Object> respSync = vaultClient.Secrets.KVv2ReadAsync("path");
```

### Exception Handling

For api level exceptions we provide the `VaultApiException` that provides the
Vault specific errors, status code and original error content.

```csharp
try
{
    // Example call to Vault
    vaultClient.System.ReadMounts();
}
catch (VaultApiException e)
{
    // Status Code
    Console.WriteLine("Status code: {0}", e.StatusCode);

    // Print the individual errors returned by Vault
    e.Errors.ToList().ForEach(x => Console.WriteLine(x));

    // Well formatted exception message
    Console.WriteLine(e.Message);
}
```

### Wrapping and Unwrapping Responses

All functions accept an optional `TimeSpan? wrapTTL` function parameter. Vault
will wrap the response and return a response-wrapping token instead. More
documentation on response wrapping can be found [here]([doc-response-wrapping]).

```csharp
// Get a wrapped response from Vault
VaultResponse<Object> wrappedResp = vaultClient.System.ReadMounts(wrapTTL: TimeSpan.FromSeconds(100));

// Unwrap the given response object
VaultResponse<Object> unwrappedResp = vaultClient.Unwrap<Object>(wrappedResp.ResponseWrapInfo.Token);
```

We also provide an async version.

```csharp
Task<VaultResponse<Object>> unwrappedResp = await vauClient.UnwrapAsync<Object>(wrappedResp.ResponseWrapInfo.Token);
```

### Performing Generic Operations

We provide generic accessors for `Read`, `Write`, `List` and `Delete`, should
you need to access an endpoint that is not available in the library (e.g. a
plugin that is not builtin to Vault).

Each generic operation has a synchronous and asynchronous version.

```csharp
// Generic read from a path with query parameters
var readPath = "/some/path"
IDictionary<string, object> queryParams = new Dictionary<string, object>
{
    {"key", "value"}
};

VaultResponse<Object> resp = await vaultClient.ReadAsync<Object>(myPath, queryParams);

// Generic write to a path
var writePath = "/some/other/path";
IDictionary<string, object>  secretData = new Dictionary<string, object>
    {
        {"1", "1"},
        {"2", 2},
        {"3", false},
    };

await vaultClient.WriteAsync<Object>(writePath, secretData);
```

## Contributing to Vault .Net Library

### Local Development

To develop locally with the Vault .Net Library, you can generate the DLL using
your preferred tool (e.g. `dotnet build`) in the `src` folder.

Then include the generated DLL (under the `bin` folder) in the C# project, and
use the namespaces:

```csharp
using Vault;
using Vault.Api;
using Vault.Client;
using Vault.Model;
```

You will also need to include the following dependencies:

- [Json.Net][newtonsoft-json]
- [Polly][polly]

Using your preferred method:

```shell-session
Install-Package Newtonsoft.Json
Install-Package Polly
```

## Documentation for API Endpoints

- [Auth](docs/Auth.md)
- [Identity](docs/Identity.md)
- [Secrets](docs/Secrets.md)
- [System](docs/System.md)

<!-- prettier-ignore-start -->
[doc-approle]:                  https://developer.hashicorp.com/vault/docs/auth/approle
[doc-aws]:                      https://developer.hashicorp.com/vault/docs/auth/aws
[doc-azure]:                    https://developer.hashicorp.com/vault/docs/auth/azure
[doc-kubernetes]:               https://developer.hashicorp.com/vault/docs/auth/kubernetes
[doc-response-wrapping]:        https://www.vaultproject.io/docs/concepts/response-wrapping 
[hashicorp]:                    https://www.hashicorp.com/
[nuget-hashicorp]:              https://www.nuget.org/profiles/hashicorp
[http-client-handler-docs]:     https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclienthandler?view=net-6.0
[newtonsoft-json]:              https://www.nuget.org/packages/Newtonsoft.Json/
[openapi-spec]:                 openapi.json
[openapi-generator]:            https://openapi-generator.tech/docs/generators/csharp-netcore
[polly]:                        http://www.thepollyproject.org/
[vault]:                        https://www.vaultproject.io/
[ci-build-badge]:               https://github.com/hashicorp/vault-client-dotnet/actions/workflows/main.yml/badge.svg?brach=main
[ci-build]:                     https://github.com/hashicorp/vault-client-dotnet/actions/workflows/main.yml?query=branch%3Amain
[nuget-badge]:                  https://img.shields.io/nuget/v/HashiCorp.Vault.svg?style=flat&color=blue
[nuget]:                        https://www.nuget.org/packages/HashiCorp.Vault/
<!-- prettier-ignore-end -->
