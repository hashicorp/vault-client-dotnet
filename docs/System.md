# Vault.Api.System

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CalculateAuditHash**](System.md#calculateaudithash) | **POST** /sys/audit-hash/{path} | The hash of the given string via the given audit backend
[**DeleteAuditDevice**](System.md#deleteauditdevice) | **DELETE** /sys/audit/{path} | Disable the audit device at the given path.
[**DeleteAuthMethod**](System.md#deleteauthmethod) | **DELETE** /sys/auth/{path} | Disable the auth method at the given auth path
[**DeleteConfigAuditingRequestHeader**](System.md#deleteconfigauditingrequestheader) | **DELETE** /sys/config/auditing/request-headers/{header} | Disable auditing of the given request header.
[**DeleteConfigCORS**](System.md#deleteconfigcors) | **DELETE** /sys/config/cors | Remove any CORS settings.
[**DeleteConfigUIHeader**](System.md#deleteconfiguiheader) | **DELETE** /sys/config/ui/headers/{header} | Remove a UI header.
[**DeleteGenerateRoot**](System.md#deletegenerateroot) | **DELETE** /sys/generate-root | Cancels any in-progress root generation attempt.
[**DeleteGenerateRootAttempt**](System.md#deletegeneraterootattempt) | **DELETE** /sys/generate-root/attempt | Cancels any in-progress root generation attempt.
[**DeleteLogger**](System.md#deletelogger) | **DELETE** /sys/loggers/{name} | Revert a single logger to use log level provided in config.
[**DeleteLoggers**](System.md#deleteloggers) | **DELETE** /sys/loggers | Revert the all loggers to use log level provided in config.
[**DeleteMount**](System.md#deletemount) | **DELETE** /sys/mounts/{path} | Disable the mount point specified at the given path.
[**DeletePluginsCatalogByTypeByName**](System.md#deletepluginscatalogbytypebyname) | **DELETE** /sys/plugins/catalog/{type}/{name} | Remove the plugin with the given name.
[**DeletePoliciesACL**](System.md#deletepoliciesacl) | **DELETE** /sys/policies/acl/{name} | Delete the ACL policy with the given name.
[**DeletePoliciesPassword**](System.md#deletepoliciespassword) | **DELETE** /sys/policies/password/{name} | Delete a password policy.
[**DeletePolicy**](System.md#deletepolicy) | **DELETE** /sys/policy/{name} | Delete the policy with the given name.
[**DeleteQuotasRateLimit**](System.md#deletequotasratelimit) | **DELETE** /sys/quotas/rate-limit/{name} | 
[**DeleteRaw**](System.md#deleteraw) | **DELETE** /sys/raw | Delete the key with given path.
[**DeleteRawPath**](System.md#deleterawpath) | **DELETE** /sys/raw/{path} | Delete the key with given path.
[**DeleteRekeyBackup**](System.md#deleterekeybackup) | **DELETE** /sys/rekey/backup | Delete the backup copy of PGP-encrypted unseal keys.
[**DeleteRekeyInit**](System.md#deleterekeyinit) | **DELETE** /sys/rekey/init | Cancels any in-progress rekey.
[**DeleteRekeyRecoveryKeyBackup**](System.md#deleterekeyrecoverykeybackup) | **DELETE** /sys/rekey/recovery-key-backup | Allows fetching or deleting the backup of the rotated unseal keys.
[**DeleteRekeyVerify**](System.md#deleterekeyverify) | **DELETE** /sys/rekey/verify | Cancel any in-progress rekey verification operation.
[**ListConfigUIHeaders**](System.md#listconfiguiheaders) | **GET** /sys/config/ui/headers/ | Return a list of configured UI headers.
[**ListLeasesLookupPrefix**](System.md#listleaseslookupprefix) | **GET** /sys/leases/lookup/{prefix} | Returns a list of lease ids.
[**ListPluginsCatalogByType**](System.md#listpluginscatalogbytype) | **GET** /sys/plugins/catalog/{type} | List the plugins in the catalog.
[**ListPoliciesACL**](System.md#listpoliciesacl) | **GET** /sys/policies/acl | List the configured access control policies.
[**ListPoliciesPassword**](System.md#listpoliciespassword) | **GET** /sys/policies/password | List the existing password policies.
[**ListQuotasRateLimits**](System.md#listquotasratelimits) | **GET** /sys/quotas/rate-limit | 
[**ListVersionHistory**](System.md#listversionhistory) | **GET** /sys/version-history/ | Returns map of historical version change entries
[**MFAValidate**](System.md#mfavalidate) | **POST** /sys/mfa/validate | Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token
[**Monitor**](System.md#monitor) | **GET** /sys/monitor | 
[**PprofRead**](System.md#pprofread) | **GET** /sys/pprof/ | Returns an HTML page listing the available profiles.
[**PprofReadAllocs**](System.md#pprofreadallocs) | **GET** /sys/pprof/allocs | Returns a sampling of all past memory allocations.
[**PprofReadBlock**](System.md#pprofreadblock) | **GET** /sys/pprof/block | Returns stack traces that led to blocking on synchronization primitives
[**PprofReadCmdline**](System.md#pprofreadcmdline) | **GET** /sys/pprof/cmdline | Returns the running program&#39;s command line.
[**PprofReadGoroutine**](System.md#pprofreadgoroutine) | **GET** /sys/pprof/goroutine | Returns stack traces of all current goroutines.
[**PprofReadHeap**](System.md#pprofreadheap) | **GET** /sys/pprof/heap | Returns a sampling of memory allocations of live object.
[**PprofReadMutex**](System.md#pprofreadmutex) | **GET** /sys/pprof/mutex | Returns stack traces of holders of contended mutexes
[**PprofReadProfile**](System.md#pprofreadprofile) | **GET** /sys/pprof/profile | Returns a pprof-formatted cpu profile payload.
[**PprofReadSymbol**](System.md#pprofreadsymbol) | **GET** /sys/pprof/symbol | Returns the program counters listed in the request.
[**PprofReadThreadcreate**](System.md#pprofreadthreadcreate) | **GET** /sys/pprof/threadcreate | Returns stack traces that led to the creation of new OS threads
[**PprofReadTrace**](System.md#pprofreadtrace) | **GET** /sys/pprof/trace | Returns the execution trace in binary form.
[**ReadAuditDevices**](System.md#readauditdevices) | **GET** /sys/audit | List the enabled audit devices.
[**ReadAuthMethod**](System.md#readauthmethod) | **GET** /sys/auth/{path} | Read the configuration of the auth engine at the given path.
[**ReadAuthMethodTune**](System.md#readauthmethodtune) | **GET** /sys/auth/{path}/tune | Reads the given auth path&#39;s configuration.
[**ReadAuthMethods**](System.md#readauthmethods) | **GET** /sys/auth | List the currently enabled credential backends.
[**ReadConfigAuditingRequestHeader**](System.md#readconfigauditingrequestheader) | **GET** /sys/config/auditing/request-headers/{header} | List the information for the given request header.
[**ReadConfigAuditingRequestHeaders**](System.md#readconfigauditingrequestheaders) | **GET** /sys/config/auditing/request-headers | List the request headers that are configured to be audited.
[**ReadConfigCORS**](System.md#readconfigcors) | **GET** /sys/config/cors | Return the current CORS settings.
[**ReadConfigStateSanitized**](System.md#readconfigstatesanitized) | **GET** /sys/config/state/sanitized | Return a sanitized version of the Vault server configuration.
[**ReadConfigUIHeader**](System.md#readconfiguiheader) | **GET** /sys/config/ui/headers/{header} | Return the given UI header&#39;s configuration
[**ReadGenerateRoot**](System.md#readgenerateroot) | **GET** /sys/generate-root | Read the configuration and progress of the current root generation attempt.
[**ReadGenerateRootAttempt**](System.md#readgeneraterootattempt) | **GET** /sys/generate-root/attempt | Read the configuration and progress of the current root generation attempt.
[**ReadHAStatus**](System.md#readhastatus) | **GET** /sys/ha-status | Check the HA status of a Vault cluster
[**ReadHealth**](System.md#readhealth) | **GET** /sys/health | Returns the health status of Vault.
[**ReadHostInfo**](System.md#readhostinfo) | **GET** /sys/host-info | Information about the host instance that this Vault server is running on.
[**ReadInFlightRequests**](System.md#readinflightrequests) | **GET** /sys/in-flight-req | reports in-flight requests
[**ReadInit**](System.md#readinit) | **GET** /sys/init | Returns the initialization status of Vault.
[**ReadInternalCountersActivity**](System.md#readinternalcountersactivity) | **GET** /sys/internal/counters/activity | Report the client count metrics, for this namespace and all child namespaces.
[**ReadInternalCountersActivityExport**](System.md#readinternalcountersactivityexport) | **GET** /sys/internal/counters/activity/export | Report the client count metrics, for this namespace and all child namespaces.
[**ReadInternalCountersActivityMonthly**](System.md#readinternalcountersactivitymonthly) | **GET** /sys/internal/counters/activity/monthly | Report the number of clients for this month, for this namespace and all child namespaces.
[**ReadInternalCountersConfig**](System.md#readinternalcountersconfig) | **GET** /sys/internal/counters/config | Read the client count tracking configuration.
[**ReadInternalCountersEntities**](System.md#readinternalcountersentities) | **GET** /sys/internal/counters/entities | Backwards compatibility is not guaranteed for this API
[**ReadInternalCountersRequests**](System.md#readinternalcountersrequests) | **GET** /sys/internal/counters/requests | Backwards compatibility is not guaranteed for this API
[**ReadInternalCountersTokens**](System.md#readinternalcounterstokens) | **GET** /sys/internal/counters/tokens | Backwards compatibility is not guaranteed for this API
[**ReadInternalInspectRouter**](System.md#readinternalinspectrouter) | **GET** /sys/internal/inspect/router/{tag} | Expose the route entry and mount entry tables present in the router
[**ReadInternalSpecsOpenAPI**](System.md#readinternalspecsopenapi) | **GET** /sys/internal/specs/openapi | Generate an OpenAPI 3 document of all mounted paths.
[**ReadInternalUIFeatureFlags**](System.md#readinternaluifeatureflags) | **GET** /sys/internal/ui/feature-flags | Lists enabled feature flags.
[**ReadInternalUIMount**](System.md#readinternaluimount) | **GET** /sys/internal/ui/mounts/{path} | Return information about the given mount.
[**ReadInternalUIMounts**](System.md#readinternaluimounts) | **GET** /sys/internal/ui/mounts | Lists all enabled and visible auth and secrets mounts.
[**ReadInternalUINamespaces**](System.md#readinternaluinamespaces) | **GET** /sys/internal/ui/namespaces | Backwards compatibility is not guaranteed for this API
[**ReadInternalUIResultantACL**](System.md#readinternaluiresultantacl) | **GET** /sys/internal/ui/resultant-acl | Backwards compatibility is not guaranteed for this API
[**ReadKeyStatus**](System.md#readkeystatus) | **GET** /sys/key-status | Provides information about the backend encryption key.
[**ReadLeader**](System.md#readleader) | **GET** /sys/leader | Returns the high availability status and current leader instance of Vault.
[**ReadLeases**](System.md#readleases) | **GET** /sys/leases | List leases associated with this Vault cluster
[**ReadLeasesCount**](System.md#readleasescount) | **GET** /sys/leases/count | Count of leases associated with this Vault cluster
[**ReadLogger**](System.md#readlogger) | **GET** /sys/loggers/{name} | Read the log level for a single logger.
[**ReadLoggers**](System.md#readloggers) | **GET** /sys/loggers | Read the log level for all existing loggers.
[**ReadMetrics**](System.md#readmetrics) | **GET** /sys/metrics | Export the metrics aggregated for telemetry purpose.
[**ReadMount**](System.md#readmount) | **GET** /sys/mounts/{path} | Read the configuration of the secret engine at the given path.
[**ReadMounts**](System.md#readmounts) | **GET** /sys/mounts | List the currently mounted backends.
[**ReadMountsConfig**](System.md#readmountsconfig) | **GET** /sys/mounts/{path}/tune | Tune backend configuration parameters for this mount.
[**ReadPluginsCatalog**](System.md#readpluginscatalog) | **GET** /sys/plugins/catalog | Lists all the plugins known to Vault
[**ReadPluginsCatalogByTypeByName**](System.md#readpluginscatalogbytypebyname) | **GET** /sys/plugins/catalog/{type}/{name} | Return the configuration data for the plugin with the given name.
[**ReadPolicies**](System.md#readpolicies) | **GET** /sys/policy | List the configured access control policies.
[**ReadPoliciesACL**](System.md#readpoliciesacl) | **GET** /sys/policies/acl/{name} | Retrieve information about the named ACL policy.
[**ReadPoliciesPassword**](System.md#readpoliciespassword) | **GET** /sys/policies/password/{name} | Retrieve an existing password policy.
[**ReadPoliciesPasswordGenerate**](System.md#readpoliciespasswordgenerate) | **GET** /sys/policies/password/{name}/generate | Generate a password from an existing password policy.
[**ReadPolicy**](System.md#readpolicy) | **GET** /sys/policy/{name} | Retrieve the policy body for the named policy.
[**ReadQuotasConfig**](System.md#readquotasconfig) | **GET** /sys/quotas/config | 
[**ReadQuotasRateLimit**](System.md#readquotasratelimit) | **GET** /sys/quotas/rate-limit/{name} | 
[**ReadRaw**](System.md#readraw) | **GET** /sys/raw | Read the value of the key at the given path.
[**ReadRawPath**](System.md#readrawpath) | **GET** /sys/raw/{path} | Read the value of the key at the given path.
[**ReadRekeyBackup**](System.md#readrekeybackup) | **GET** /sys/rekey/backup | Return the backup copy of PGP-encrypted unseal keys.
[**ReadRekeyInit**](System.md#readrekeyinit) | **GET** /sys/rekey/init | Reads the configuration and progress of the current rekey attempt.
[**ReadRekeyRecoveryKeyBackup**](System.md#readrekeyrecoverykeybackup) | **GET** /sys/rekey/recovery-key-backup | Allows fetching or deleting the backup of the rotated unseal keys.
[**ReadRekeyVerify**](System.md#readrekeyverify) | **GET** /sys/rekey/verify | Read the configuration and progress of the current rekey verification attempt.
[**ReadRemountStatus**](System.md#readremountstatus) | **GET** /sys/remount/status/{migration_id} | Check status of a mount migration
[**ReadReplicationStatus**](System.md#readreplicationstatus) | **GET** /sys/replication/status | 
[**ReadRotateConfig**](System.md#readrotateconfig) | **GET** /sys/rotate/config | 
[**ReadSealStatus**](System.md#readsealstatus) | **GET** /sys/seal-status | Check the seal status of a Vault.
[**Remount**](System.md#remount) | **POST** /sys/remount | Initiate a mount migration
[**Renew**](System.md#renew) | **POST** /sys/renew | Renews a lease, requesting to extend the lease.
[**RenewFor**](System.md#renewfor) | **POST** /sys/renew/{url_lease_id} | Renews a lease, requesting to extend the lease.
[**Revoke**](System.md#revoke) | **POST** /sys/revoke | Revokes a lease immediately.
[**RevokeForce**](System.md#revokeforce) | **POST** /sys/revoke-force/{prefix} | Revokes all secrets or tokens generated under a given prefix immediately
[**RevokeLease**](System.md#revokelease) | **POST** /sys/revoke/{url_lease_id} | Revokes a lease immediately.
[**RevokePrefix**](System.md#revokeprefix) | **POST** /sys/revoke-prefix/{prefix} | Revokes all secrets (via a lease ID prefix) or tokens (via the tokens&#39; path property) generated under a given prefix immediately.
[**Rotate**](System.md#rotate) | **POST** /sys/rotate | Rotates the backend encryption key used to persist data.
[**Seal**](System.md#seal) | **POST** /sys/seal | Seal the Vault.
[**StepDownLeader**](System.md#stepdownleader) | **POST** /sys/step-down | Cause the node to give up active status.
[**SysDeletePluginsCatalogName**](System.md#sysdeletepluginscatalogname) | **DELETE** /sys/plugins/catalog/{name} | Remove the plugin with the given name.
[**SysListLeasesLookup**](System.md#syslistleaseslookup) | **GET** /sys/leases/lookup/ | Returns a list of lease ids.
[**SysReadPluginsCatalogName**](System.md#sysreadpluginscatalogname) | **GET** /sys/plugins/catalog/{name} | Return the configuration data for the plugin with the given name.
[**SysWriteLockedusersMountAccessorUnlockAliasIdentifier**](System.md#syswritelockedusersmountaccessorunlockaliasidentifier) | **POST** /sys/lockedusers/{mount_accessor}/unlock/{alias_identifier} | Unlocks the user with given mount_accessor and alias_identifier
[**SysWritePluginsCatalogName**](System.md#syswritepluginscatalogname) | **POST** /sys/plugins/catalog/{name} | Register a new plugin, or updates an existing one with the supplied name.
[**SysWriteToolsRandomUrlbytes**](System.md#syswritetoolsrandomurlbytes) | **POST** /sys/tools/random/{urlbytes} | Generate random bytes
[**ToolsGenerateRandom**](System.md#toolsgeneraterandom) | **POST** /sys/tools/random | Generate random bytes
[**ToolsGenerateRandomSource**](System.md#toolsgeneraterandomsource) | **POST** /sys/tools/random/{source} | Generate random bytes
[**ToolsGenerateRandomSourceBytes**](System.md#toolsgeneraterandomsourcebytes) | **POST** /sys/tools/random/{source}/{urlbytes} | Generate random bytes
[**ToolsHash**](System.md#toolshash) | **POST** /sys/tools/hash | Generate a hash sum for input data
[**ToolsHashWith**](System.md#toolshashwith) | **POST** /sys/tools/hash/{urlalgorithm} | Generate a hash sum for input data
[**Unseal**](System.md#unseal) | **POST** /sys/unseal | Unseal the Vault.
[**WrappingReadLookup**](System.md#wrappingreadlookup) | **GET** /sys/wrapping/lookup | Look up wrapping properties for the requester&#39;s token.
[**WrappingRewrap**](System.md#wrappingrewrap) | **POST** /sys/wrapping/rewrap | Rotates a response-wrapped token.
[**WrappingUnwrap**](System.md#wrappingunwrap) | **POST** /sys/wrapping/unwrap | Unwraps a response-wrapped token.
[**WrappingWrap**](System.md#wrappingwrap) | **POST** /sys/wrapping/wrap | Response-wraps an arbitrary JSON object.
[**WrappingWriteLookup**](System.md#wrappingwritelookup) | **POST** /sys/wrapping/lookup | Look up wrapping properties for the given token.
[**WriteAuditDevice**](System.md#writeauditdevice) | **POST** /sys/audit/{path} | Enable a new audit device at the supplied path.
[**WriteAuthMethod**](System.md#writeauthmethod) | **POST** /sys/auth/{path} | Enables a new auth method.
[**WriteAuthMethodTune**](System.md#writeauthmethodtune) | **POST** /sys/auth/{path}/tune | Tune configuration parameters for a given auth path.
[**WriteCapabilities**](System.md#writecapabilities) | **POST** /sys/capabilities | Fetches the capabilities of the given token on the given path.
[**WriteCapabilitiesAccessor**](System.md#writecapabilitiesaccessor) | **POST** /sys/capabilities-accessor | Fetches the capabilities of the token associated with the given token, on the given path.
[**WriteCapabilitiesSelf**](System.md#writecapabilitiesself) | **POST** /sys/capabilities-self | Fetches the capabilities of the given token on the given path.
[**WriteConfigAuditingRequestHeader**](System.md#writeconfigauditingrequestheader) | **POST** /sys/config/auditing/request-headers/{header} | Enable auditing of a header.
[**WriteConfigCORS**](System.md#writeconfigcors) | **POST** /sys/config/cors | Configure the CORS settings.
[**WriteConfigReloadSubsystem**](System.md#writeconfigreloadsubsystem) | **POST** /sys/config/reload/{subsystem} | Reload the given subsystem
[**WriteConfigUIHeader**](System.md#writeconfiguiheader) | **POST** /sys/config/ui/headers/{header} | Configure the values to be returned for the UI header.
[**WriteGenerateRoot**](System.md#writegenerateroot) | **POST** /sys/generate-root | Initializes a new root generation attempt.
[**WriteGenerateRootAttempt**](System.md#writegeneraterootattempt) | **POST** /sys/generate-root/attempt | Initializes a new root generation attempt.
[**WriteGenerateRootUpdate**](System.md#writegeneraterootupdate) | **POST** /sys/generate-root/update | Enter a single unseal key share to progress the root generation attempt.
[**WriteInit**](System.md#writeinit) | **POST** /sys/init | Initialize a new Vault.
[**WriteInternalCountersConfig**](System.md#writeinternalcountersconfig) | **POST** /sys/internal/counters/config | Enable or disable collection of client count, set retention period, or set default reporting period.
[**WriteLeasesLookup**](System.md#writeleaseslookup) | **POST** /sys/leases/lookup | Retrieve lease metadata.
[**WriteLeasesRenew**](System.md#writeleasesrenew) | **POST** /sys/leases/renew | Renews a lease, requesting to extend the lease.
[**WriteLeasesRenew2**](System.md#writeleasesrenew2) | **POST** /sys/leases/renew/{url_lease_id} | Renews a lease, requesting to extend the lease.
[**WriteLeasesRevoke**](System.md#writeleasesrevoke) | **POST** /sys/leases/revoke | Revokes a lease immediately.
[**WriteLeasesRevoke2**](System.md#writeleasesrevoke2) | **POST** /sys/leases/revoke/{url_lease_id} | Revokes a lease immediately.
[**WriteLeasesRevokeForce**](System.md#writeleasesrevokeforce) | **POST** /sys/leases/revoke-force/{prefix} | Revokes all secrets or tokens generated under a given prefix immediately
[**WriteLeasesRevokePrefix**](System.md#writeleasesrevokeprefix) | **POST** /sys/leases/revoke-prefix/{prefix} | Revokes all secrets (via a lease ID prefix) or tokens (via the tokens&#39; path property) generated under a given prefix immediately.
[**WriteLeasesTidy**](System.md#writeleasestidy) | **POST** /sys/leases/tidy | This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
[**WriteLogger**](System.md#writelogger) | **POST** /sys/loggers/{name} | Modify the log level of a single logger.
[**WriteLoggers**](System.md#writeloggers) | **POST** /sys/loggers | Modify the log level for all existing loggers.
[**WriteMount**](System.md#writemount) | **POST** /sys/mounts/{path} | Enable a new secrets engine at the given path.
[**WriteMountsConfig**](System.md#writemountsconfig) | **POST** /sys/mounts/{path}/tune | Tune backend configuration parameters for this mount.
[**WritePluginsCatalogByTypeByName**](System.md#writepluginscatalogbytypebyname) | **POST** /sys/plugins/catalog/{type}/{name} | Register a new plugin, or updates an existing one with the supplied name.
[**WritePluginsReloadBackend**](System.md#writepluginsreloadbackend) | **POST** /sys/plugins/reload/backend | Reload mounted plugin backends.
[**WritePoliciesACL**](System.md#writepoliciesacl) | **POST** /sys/policies/acl/{name} | Add a new or update an existing ACL policy.
[**WritePoliciesPassword**](System.md#writepoliciespassword) | **POST** /sys/policies/password/{name} | Add a new or update an existing password policy.
[**WritePolicy**](System.md#writepolicy) | **POST** /sys/policy/{name} | Add a new or update an existing policy.
[**WriteQuotasConfig**](System.md#writequotasconfig) | **POST** /sys/quotas/config | 
[**WriteQuotasRateLimit**](System.md#writequotasratelimit) | **POST** /sys/quotas/rate-limit/{name} | 
[**WriteRaw**](System.md#writeraw) | **POST** /sys/raw | Update the value of the key at the given path.
[**WriteRawPath**](System.md#writerawpath) | **POST** /sys/raw/{path} | Update the value of the key at the given path.
[**WriteRekeyInit**](System.md#writerekeyinit) | **POST** /sys/rekey/init | Initializes a new rekey attempt.
[**WriteRekeyUpdate**](System.md#writerekeyupdate) | **POST** /sys/rekey/update | Enter a single unseal key share to progress the rekey of the Vault.
[**WriteRekeyVerify**](System.md#writerekeyverify) | **POST** /sys/rekey/verify | Enter a single new key share to progress the rekey verification operation.
[**WriteRotateConfig**](System.md#writerotateconfig) | **POST** /sys/rotate/config | 


<a name="calculateaudithash"></a>
# **CalculateAuditHash**
> void CalculateAuditHash (CalculateAuditHashRequest calculateAuditHashRequest, string path, TimeSpan? wrapTTL = null)

The hash of the given string via the given audit backend

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class CalculateAuditHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | The name of the backend. Cannot be delimited. Example: \"mysql\"
            var calculateAuditHashRequest = new CalculateAuditHashRequest(); // CalculateAuditHashRequest | 

            try
            {
                // The hash of the given string via the given audit backend
                apiInstance.CalculateAuditHash(path, calculateAuditHashRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.CalculateAuditHash: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot; | 
 **calculateAuditHashRequest** | [**CalculateAuditHashRequest**](CalculateAuditHashRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauditdevice"></a>
# **DeleteAuditDevice**
> void DeleteAuditDevice (string path, TimeSpan? wrapTTL = null)

Disable the audit device at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuditDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | The name of the backend. Cannot be delimited. Example: \"mysql\"

            try
            {
                // Disable the audit device at the given path.
                apiInstance.DeleteAuditDevice(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteAuditDevice: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteauthmethod"></a>
# **DeleteAuthMethod**
> void DeleteAuthMethod (string path, TimeSpan? wrapTTL = null)

Disable the auth method at the given auth path

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteAuthMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | The path to mount to. Cannot be delimited. Example: \"user\"

            try
            {
                // Disable the auth method at the given auth path
                apiInstance.DeleteAuthMethod(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteAuthMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to mount to. Cannot be delimited. Example: \&quot;user\&quot; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteconfigauditingrequestheader"></a>
# **DeleteConfigAuditingRequestHeader**
> void DeleteConfigAuditingRequestHeader (string header, TimeSpan? wrapTTL = null)

Disable auditing of the given request header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteConfigAuditingRequestHeaderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var header = "header_example";  // string | 

            try
            {
                // Disable auditing of the given request header.
                apiInstance.DeleteConfigAuditingRequestHeader(header);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteConfigAuditingRequestHeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteconfigcors"></a>
# **DeleteConfigCORS**
> void DeleteConfigCORS (TimeSpan? wrapTTL = null)

Remove any CORS settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteConfigCORSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Remove any CORS settings.
                apiInstance.DeleteConfigCORS();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteConfigCORS: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteconfiguiheader"></a>
# **DeleteConfigUIHeader**
> void DeleteConfigUIHeader (string header, TimeSpan? wrapTTL = null)

Remove a UI header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteConfigUIHeaderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var header = "header_example";  // string | The name of the header.

            try
            {
                // Remove a UI header.
                apiInstance.DeleteConfigUIHeader(header);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteConfigUIHeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header** | **string**| The name of the header. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegenerateroot"></a>
# **DeleteGenerateRoot**
> void DeleteGenerateRoot (TimeSpan? wrapTTL = null)

Cancels any in-progress root generation attempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteGenerateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Cancels any in-progress root generation attempt.
                apiInstance.DeleteGenerateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteGenerateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletegeneraterootattempt"></a>
# **DeleteGenerateRootAttempt**
> void DeleteGenerateRootAttempt (TimeSpan? wrapTTL = null)

Cancels any in-progress root generation attempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteGenerateRootAttemptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Cancels any in-progress root generation attempt.
                apiInstance.DeleteGenerateRootAttempt();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteGenerateRootAttempt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletelogger"></a>
# **DeleteLogger**
> void DeleteLogger (string name, TimeSpan? wrapTTL = null)

Revert a single logger to use log level provided in config.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteLoggerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the logger to be modified.

            try
            {
                // Revert a single logger to use log level provided in config.
                apiInstance.DeleteLogger(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteLogger: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the logger to be modified. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteloggers"></a>
# **DeleteLoggers**
> void DeleteLoggers (TimeSpan? wrapTTL = null)

Revert the all loggers to use log level provided in config.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteLoggersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Revert the all loggers to use log level provided in config.
                apiInstance.DeleteLoggers();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteLoggers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletemount"></a>
# **DeleteMount**
> void DeleteMount (string path, TimeSpan? wrapTTL = null)

Disable the mount point specified at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteMountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | The path to mount to. Example: \"aws/east\"

            try
            {
                // Disable the mount point specified at the given path.
                apiInstance.DeleteMount(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteMount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to mount to. Example: \&quot;aws/east\&quot; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepluginscatalogbytypebyname"></a>
# **DeletePluginsCatalogByTypeByName**
> void DeletePluginsCatalogByTypeByName (string name, string type, TimeSpan? wrapTTL = null)

Remove the plugin with the given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeletePluginsCatalogByTypeByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the plugin
            var type = "type_example";  // string | The type of the plugin, may be auth, secret, or database

            try
            {
                // Remove the plugin with the given name.
                apiInstance.DeletePluginsCatalogByTypeByName(name, type);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeletePluginsCatalogByTypeByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the plugin | 
 **type** | **string**| The type of the plugin, may be auth, secret, or database | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepoliciesacl"></a>
# **DeletePoliciesACL**
> void DeletePoliciesACL (string name, TimeSpan? wrapTTL = null)

Delete the ACL policy with the given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeletePoliciesACLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the policy. Example: \"ops\"

            try
            {
                // Delete the ACL policy with the given name.
                apiInstance.DeletePoliciesACL(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeletePoliciesACL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the policy. Example: \&quot;ops\&quot; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepoliciespassword"></a>
# **DeletePoliciesPassword**
> void DeletePoliciesPassword (string name, TimeSpan? wrapTTL = null)

Delete a password policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeletePoliciesPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the password policy.

            try
            {
                // Delete a password policy.
                apiInstance.DeletePoliciesPassword(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeletePoliciesPassword: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the password policy. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletepolicy"></a>
# **DeletePolicy**
> void DeletePolicy (string name, TimeSpan? wrapTTL = null)

Delete the policy with the given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeletePolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the policy. Example: \"ops\"

            try
            {
                // Delete the policy with the given name.
                apiInstance.DeletePolicy(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeletePolicy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the policy. Example: \&quot;ops\&quot; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletequotasratelimit"></a>
# **DeleteQuotasRateLimit**
> void DeleteQuotasRateLimit (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteQuotasRateLimitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the quota rule.

            try
            {
                apiInstance.DeleteQuotasRateLimit(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteQuotasRateLimit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the quota rule. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteraw"></a>
# **DeleteRaw**
> void DeleteRaw (TimeSpan? wrapTTL = null)

Delete the key with given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteRawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Delete the key with given path.
                apiInstance.DeleteRaw();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteRaw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterawpath"></a>
# **DeleteRawPath**
> void DeleteRawPath (string path, TimeSpan? wrapTTL = null)

Delete the key with given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteRawPathExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | 

            try
            {
                // Delete the key with given path.
                apiInstance.DeleteRawPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteRawPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterekeybackup"></a>
# **DeleteRekeyBackup**
> void DeleteRekeyBackup (TimeSpan? wrapTTL = null)

Delete the backup copy of PGP-encrypted unseal keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteRekeyBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Delete the backup copy of PGP-encrypted unseal keys.
                apiInstance.DeleteRekeyBackup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteRekeyBackup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterekeyinit"></a>
# **DeleteRekeyInit**
> void DeleteRekeyInit (TimeSpan? wrapTTL = null)

Cancels any in-progress rekey.

This clears the rekey settings as well as any progress made. This must be called to change the parameters of the rekey. Note: verification is still a part of a rekey. If rekeying is canceled during the verification flow, the current unseal keys remain valid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteRekeyInitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Cancels any in-progress rekey.
                apiInstance.DeleteRekeyInit();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteRekeyInit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterekeyrecoverykeybackup"></a>
# **DeleteRekeyRecoveryKeyBackup**
> void DeleteRekeyRecoveryKeyBackup (TimeSpan? wrapTTL = null)

Allows fetching or deleting the backup of the rotated unseal keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteRekeyRecoveryKeyBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Allows fetching or deleting the backup of the rotated unseal keys.
                apiInstance.DeleteRekeyRecoveryKeyBackup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteRekeyRecoveryKeyBackup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleterekeyverify"></a>
# **DeleteRekeyVerify**
> void DeleteRekeyVerify (TimeSpan? wrapTTL = null)

Cancel any in-progress rekey verification operation.

This clears any progress made and resets the nonce. Unlike a `DELETE` against `sys/rekey/init`, this only resets the current verification operation, not the entire rekey atttempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteRekeyVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Cancel any in-progress rekey verification operation.
                apiInstance.DeleteRekeyVerify();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteRekeyVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listconfiguiheaders"></a>
# **ListConfigUIHeaders**
> void ListConfigUIHeaders (TimeSpan? wrapTTL = null)

Return a list of configured UI headers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListConfigUIHeadersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Return a list of configured UI headers.
                apiInstance.ListConfigUIHeaders(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListConfigUIHeaders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listleaseslookupprefix"></a>
# **ListLeasesLookupPrefix**
> void ListLeasesLookupPrefix (string prefix, TimeSpan? wrapTTL = null)

Returns a list of lease ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListLeasesLookupPrefixExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var prefix = "prefix_example";  // string | The path to list leases under. Example: \"aws/creds/deploy\"
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Returns a list of lease ids.
                apiInstance.ListLeasesLookupPrefix(prefix, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListLeasesLookupPrefix: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **prefix** | **string**| The path to list leases under. Example: \&quot;aws/creds/deploy\&quot; | 
 **list** | **string**| Must be set to &#x60;true&#x60; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpluginscatalogbytype"></a>
# **ListPluginsCatalogByType**
> void ListPluginsCatalogByType (string type, TimeSpan? wrapTTL = null)

List the plugins in the catalog.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListPluginsCatalogByTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var type = "type_example";  // string | The type of the plugin, may be auth, secret, or database
            var list = "true";  // string | Must be set to `true`

            try
            {
                // List the plugins in the catalog.
                apiInstance.ListPluginsCatalogByType(type, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListPluginsCatalogByType: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The type of the plugin, may be auth, secret, or database | 
 **list** | **string**| Must be set to &#x60;true&#x60; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpoliciesacl"></a>
# **ListPoliciesACL**
> void ListPoliciesACL (TimeSpan? wrapTTL = null)

List the configured access control policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListPoliciesACLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // List the configured access control policies.
                apiInstance.ListPoliciesACL(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListPoliciesACL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listpoliciespassword"></a>
# **ListPoliciesPassword**
> void ListPoliciesPassword (TimeSpan? wrapTTL = null)

List the existing password policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListPoliciesPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // List the existing password policies.
                apiInstance.ListPoliciesPassword(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListPoliciesPassword: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listquotasratelimits"></a>
# **ListQuotasRateLimits**
> void ListQuotasRateLimits (TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListQuotasRateLimitsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`

            try
            {
                apiInstance.ListQuotasRateLimits(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListQuotasRateLimits: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listversionhistory"></a>
# **ListVersionHistory**
> void ListVersionHistory (TimeSpan? wrapTTL = null)

Returns map of historical version change entries

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListVersionHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Returns map of historical version change entries
                apiInstance.ListVersionHistory(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListVersionHistory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mfavalidate"></a>
# **MFAValidate**
> void MFAValidate (MFAValidateRequest mFAValidateRequest, TimeSpan? wrapTTL = null)

Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MFAValidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var mFAValidateRequest = new MFAValidateRequest(); // MFAValidateRequest | 

            try
            {
                // Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token
                apiInstance.MFAValidate(mFAValidateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.MFAValidate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mFAValidateRequest** | [**MFAValidateRequest**](MFAValidateRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="monitor"></a>
# **Monitor**
> void Monitor (string logFormat = default(string), string logLevel = default(string), TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class MonitorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var logFormat = "\"standard\"";  // string | Output format of logs. Supported values are \"standard\" and \"json\". The default is \"standard\". (optional)  (default to "standard")
            var logLevel = "logLevel_example";  // string | Log level to view system logs at. Currently supported values are \"trace\", \"debug\", \"info\", \"warn\", \"error\". (optional) 

            try
            {
                apiInstance.Monitor(logFormat, logLevel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Monitor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logFormat** | **string**| Output format of logs. Supported values are \&quot;standard\&quot; and \&quot;json\&quot;. The default is \&quot;standard\&quot;. | [optional] [default to &quot;standard&quot;]
 **logLevel** | **string**| Log level to view system logs at. Currently supported values are \&quot;trace\&quot;, \&quot;debug\&quot;, \&quot;info\&quot;, \&quot;warn\&quot;, \&quot;error\&quot;. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pprofread"></a>
# **PprofRead**
> void PprofRead (TimeSpan? wrapTTL = null)

Returns an HTML page listing the available profiles.

Returns an HTML page listing the available  profiles. This should be mainly accessed via browsers or applications that can  render pages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PprofReadExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns an HTML page listing the available profiles.
                apiInstance.PprofRead();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofRead: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pprofreadallocs"></a>
# **PprofReadAllocs**
> void PprofReadAllocs (TimeSpan? wrapTTL = null)

Returns a sampling of all past memory allocations.

Returns a sampling of all past memory allocations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PprofReadAllocsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns a sampling of all past memory allocations.
                apiInstance.PprofReadAllocs();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofReadAllocs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pprofreadblock"></a>
# **PprofReadBlock**
> void PprofReadBlock (TimeSpan? wrapTTL = null)

Returns stack traces that led to blocking on synchronization primitives

Returns stack traces that led to blocking on synchronization primitives

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PprofReadBlockExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns stack traces that led to blocking on synchronization primitives
                apiInstance.PprofReadBlock();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofReadBlock: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pprofreadcmdline"></a>
# **PprofReadCmdline**
> void PprofReadCmdline (TimeSpan? wrapTTL = null)

Returns the running program's command line.

Returns the running program's command line, with arguments separated by NUL bytes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PprofReadCmdlineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns the running program's command line.
                apiInstance.PprofReadCmdline();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofReadCmdline: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pprofreadgoroutine"></a>
# **PprofReadGoroutine**
> void PprofReadGoroutine (TimeSpan? wrapTTL = null)

Returns stack traces of all current goroutines.

Returns stack traces of all current goroutines.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PprofReadGoroutineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns stack traces of all current goroutines.
                apiInstance.PprofReadGoroutine();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofReadGoroutine: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pprofreadheap"></a>
# **PprofReadHeap**
> void PprofReadHeap (TimeSpan? wrapTTL = null)

Returns a sampling of memory allocations of live object.

Returns a sampling of memory allocations of live object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PprofReadHeapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns a sampling of memory allocations of live object.
                apiInstance.PprofReadHeap();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofReadHeap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pprofreadmutex"></a>
# **PprofReadMutex**
> void PprofReadMutex (TimeSpan? wrapTTL = null)

Returns stack traces of holders of contended mutexes

Returns stack traces of holders of contended mutexes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PprofReadMutexExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns stack traces of holders of contended mutexes
                apiInstance.PprofReadMutex();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofReadMutex: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pprofreadprofile"></a>
# **PprofReadProfile**
> void PprofReadProfile (TimeSpan? wrapTTL = null)

Returns a pprof-formatted cpu profile payload.

Returns a pprof-formatted cpu profile payload. Profiling lasts for duration specified in seconds GET parameter, or for 30 seconds if not specified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PprofReadProfileExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns a pprof-formatted cpu profile payload.
                apiInstance.PprofReadProfile();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofReadProfile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pprofreadsymbol"></a>
# **PprofReadSymbol**
> void PprofReadSymbol (TimeSpan? wrapTTL = null)

Returns the program counters listed in the request.

Returns the program counters listed in the request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PprofReadSymbolExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns the program counters listed in the request.
                apiInstance.PprofReadSymbol();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofReadSymbol: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pprofreadthreadcreate"></a>
# **PprofReadThreadcreate**
> void PprofReadThreadcreate (TimeSpan? wrapTTL = null)

Returns stack traces that led to the creation of new OS threads

Returns stack traces that led to the creation of new OS threads

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PprofReadThreadcreateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns stack traces that led to the creation of new OS threads
                apiInstance.PprofReadThreadcreate();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofReadThreadcreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pprofreadtrace"></a>
# **PprofReadTrace**
> void PprofReadTrace (TimeSpan? wrapTTL = null)

Returns the execution trace in binary form.

Returns  the execution trace in binary form. Tracing lasts for duration specified in seconds GET parameter, or for 1 second if not specified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class PprofReadTraceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns the execution trace in binary form.
                apiInstance.PprofReadTrace();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofReadTrace: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readauditdevices"></a>
# **ReadAuditDevices**
> void ReadAuditDevices (TimeSpan? wrapTTL = null)

List the enabled audit devices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAuditDevicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // List the enabled audit devices.
                apiInstance.ReadAuditDevices();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadAuditDevices: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readauthmethod"></a>
# **ReadAuthMethod**
> void ReadAuthMethod (string path, TimeSpan? wrapTTL = null)

Read the configuration of the auth engine at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAuthMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | The path to mount to. Cannot be delimited. Example: \"user\"

            try
            {
                // Read the configuration of the auth engine at the given path.
                apiInstance.ReadAuthMethod(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadAuthMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to mount to. Cannot be delimited. Example: \&quot;user\&quot; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readauthmethodtune"></a>
# **ReadAuthMethodTune**
> void ReadAuthMethodTune (string path, TimeSpan? wrapTTL = null)

Reads the given auth path's configuration.

This endpoint requires sudo capability on the final path, but the same functionality can be achieved without sudo via `sys/mounts/auth/[auth-path]/tune`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAuthMethodTuneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | Tune the configuration parameters for an auth path.

            try
            {
                // Reads the given auth path's configuration.
                apiInstance.ReadAuthMethodTune(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadAuthMethodTune: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Tune the configuration parameters for an auth path. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readauthmethods"></a>
# **ReadAuthMethods**
> void ReadAuthMethods (TimeSpan? wrapTTL = null)

List the currently enabled credential backends.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadAuthMethodsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // List the currently enabled credential backends.
                apiInstance.ReadAuthMethods();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadAuthMethods: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readconfigauditingrequestheader"></a>
# **ReadConfigAuditingRequestHeader**
> void ReadConfigAuditingRequestHeader (string header, TimeSpan? wrapTTL = null)

List the information for the given request header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadConfigAuditingRequestHeaderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var header = "header_example";  // string | 

            try
            {
                // List the information for the given request header.
                apiInstance.ReadConfigAuditingRequestHeader(header);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadConfigAuditingRequestHeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readconfigauditingrequestheaders"></a>
# **ReadConfigAuditingRequestHeaders**
> void ReadConfigAuditingRequestHeaders (TimeSpan? wrapTTL = null)

List the request headers that are configured to be audited.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadConfigAuditingRequestHeadersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // List the request headers that are configured to be audited.
                apiInstance.ReadConfigAuditingRequestHeaders();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadConfigAuditingRequestHeaders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readconfigcors"></a>
# **ReadConfigCORS**
> void ReadConfigCORS (TimeSpan? wrapTTL = null)

Return the current CORS settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadConfigCORSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Return the current CORS settings.
                apiInstance.ReadConfigCORS();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadConfigCORS: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readconfigstatesanitized"></a>
# **ReadConfigStateSanitized**
> void ReadConfigStateSanitized (TimeSpan? wrapTTL = null)

Return a sanitized version of the Vault server configuration.

The sanitized output strips configuration values in the storage, HA storage, and seals stanzas, which may contain sensitive values such as API tokens. It also removes any token or secret fields in other stanzas, such as the circonus_api_token from telemetry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadConfigStateSanitizedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Return a sanitized version of the Vault server configuration.
                apiInstance.ReadConfigStateSanitized();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadConfigStateSanitized: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readconfiguiheader"></a>
# **ReadConfigUIHeader**
> void ReadConfigUIHeader (string header, TimeSpan? wrapTTL = null)

Return the given UI header's configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadConfigUIHeaderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var header = "header_example";  // string | The name of the header.

            try
            {
                // Return the given UI header's configuration
                apiInstance.ReadConfigUIHeader(header);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadConfigUIHeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header** | **string**| The name of the header. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readgenerateroot"></a>
# **ReadGenerateRoot**
> void ReadGenerateRoot (TimeSpan? wrapTTL = null)

Read the configuration and progress of the current root generation attempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGenerateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Read the configuration and progress of the current root generation attempt.
                apiInstance.ReadGenerateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadGenerateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readgeneraterootattempt"></a>
# **ReadGenerateRootAttempt**
> void ReadGenerateRootAttempt (TimeSpan? wrapTTL = null)

Read the configuration and progress of the current root generation attempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadGenerateRootAttemptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Read the configuration and progress of the current root generation attempt.
                apiInstance.ReadGenerateRootAttempt();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadGenerateRootAttempt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readhastatus"></a>
# **ReadHAStatus**
> void ReadHAStatus (TimeSpan? wrapTTL = null)

Check the HA status of a Vault cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadHAStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Check the HA status of a Vault cluster
                apiInstance.ReadHAStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadHAStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readhealth"></a>
# **ReadHealth**
> void ReadHealth (TimeSpan? wrapTTL = null)

Returns the health status of Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadHealthExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns the health status of Vault.
                apiInstance.ReadHealth();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadHealth: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | initialized, unsealed, and active |  -  |
| **429** | unsealed and standby |  -  |
| **472** | data recovery mode replication secondary and active |  -  |
| **501** | not initialized |  -  |
| **503** | sealed |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readhostinfo"></a>
# **ReadHostInfo**
> void ReadHostInfo (TimeSpan? wrapTTL = null)

Information about the host instance that this Vault server is running on.

Information about the host instance that this Vault server is running on.   The information that gets collected includes host hardware information, and CPU,   disk, and memory utilization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadHostInfoExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Information about the host instance that this Vault server is running on.
                apiInstance.ReadHostInfo();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadHostInfo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinflightrequests"></a>
# **ReadInFlightRequests**
> void ReadInFlightRequests (TimeSpan? wrapTTL = null)

reports in-flight requests

This path responds to the following HTTP methods.   GET /    Returns a map of in-flight requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInFlightRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // reports in-flight requests
                apiInstance.ReadInFlightRequests();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInFlightRequests: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinit"></a>
# **ReadInit**
> void ReadInit (TimeSpan? wrapTTL = null)

Returns the initialization status of Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns the initialization status of Vault.
                apiInstance.ReadInit();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternalcountersactivity"></a>
# **ReadInternalCountersActivity**
> void ReadInternalCountersActivity (TimeSpan? wrapTTL = null)

Report the client count metrics, for this namespace and all child namespaces.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalCountersActivityExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Report the client count metrics, for this namespace and all child namespaces.
                apiInstance.ReadInternalCountersActivity();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalCountersActivity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternalcountersactivityexport"></a>
# **ReadInternalCountersActivityExport**
> void ReadInternalCountersActivityExport (TimeSpan? wrapTTL = null)

Report the client count metrics, for this namespace and all child namespaces.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalCountersActivityExportExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Report the client count metrics, for this namespace and all child namespaces.
                apiInstance.ReadInternalCountersActivityExport();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalCountersActivityExport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternalcountersactivitymonthly"></a>
# **ReadInternalCountersActivityMonthly**
> void ReadInternalCountersActivityMonthly (TimeSpan? wrapTTL = null)

Report the number of clients for this month, for this namespace and all child namespaces.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalCountersActivityMonthlyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Report the number of clients for this month, for this namespace and all child namespaces.
                apiInstance.ReadInternalCountersActivityMonthly();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalCountersActivityMonthly: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternalcountersconfig"></a>
# **ReadInternalCountersConfig**
> void ReadInternalCountersConfig (TimeSpan? wrapTTL = null)

Read the client count tracking configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalCountersConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Read the client count tracking configuration.
                apiInstance.ReadInternalCountersConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalCountersConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternalcountersentities"></a>
# **ReadInternalCountersEntities**
> void ReadInternalCountersEntities (TimeSpan? wrapTTL = null)

Backwards compatibility is not guaranteed for this API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalCountersEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Backwards compatibility is not guaranteed for this API
                apiInstance.ReadInternalCountersEntities();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalCountersEntities: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternalcountersrequests"></a>
# **ReadInternalCountersRequests**
> void ReadInternalCountersRequests (TimeSpan? wrapTTL = null)

Backwards compatibility is not guaranteed for this API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalCountersRequestsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Backwards compatibility is not guaranteed for this API
                apiInstance.ReadInternalCountersRequests();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalCountersRequests: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternalcounterstokens"></a>
# **ReadInternalCountersTokens**
> void ReadInternalCountersTokens (TimeSpan? wrapTTL = null)

Backwards compatibility is not guaranteed for this API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalCountersTokensExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Backwards compatibility is not guaranteed for this API
                apiInstance.ReadInternalCountersTokens();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalCountersTokens: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternalinspectrouter"></a>
# **ReadInternalInspectRouter**
> void ReadInternalInspectRouter (string tag, TimeSpan? wrapTTL = null)

Expose the route entry and mount entry tables present in the router

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalInspectRouterExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var tag = "tag_example";  // string | Name of subtree being observed

            try
            {
                // Expose the route entry and mount entry tables present in the router
                apiInstance.ReadInternalInspectRouter(tag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalInspectRouter: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **tag** | **string**| Name of subtree being observed | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternalspecsopenapi"></a>
# **ReadInternalSpecsOpenAPI**
> void ReadInternalSpecsOpenAPI (TimeSpan? wrapTTL = null)

Generate an OpenAPI 3 document of all mounted paths.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalSpecsOpenAPIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Generate an OpenAPI 3 document of all mounted paths.
                apiInstance.ReadInternalSpecsOpenAPI();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalSpecsOpenAPI: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternaluifeatureflags"></a>
# **ReadInternalUIFeatureFlags**
> void ReadInternalUIFeatureFlags (TimeSpan? wrapTTL = null)

Lists enabled feature flags.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalUIFeatureFlagsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Lists enabled feature flags.
                apiInstance.ReadInternalUIFeatureFlags();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalUIFeatureFlags: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternaluimount"></a>
# **ReadInternalUIMount**
> void ReadInternalUIMount (string path, TimeSpan? wrapTTL = null)

Return information about the given mount.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalUIMountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | The path of the mount.

            try
            {
                // Return information about the given mount.
                apiInstance.ReadInternalUIMount(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalUIMount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path of the mount. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternaluimounts"></a>
# **ReadInternalUIMounts**
> void ReadInternalUIMounts (TimeSpan? wrapTTL = null)

Lists all enabled and visible auth and secrets mounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalUIMountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Lists all enabled and visible auth and secrets mounts.
                apiInstance.ReadInternalUIMounts();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalUIMounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternaluinamespaces"></a>
# **ReadInternalUINamespaces**
> void ReadInternalUINamespaces (TimeSpan? wrapTTL = null)

Backwards compatibility is not guaranteed for this API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalUINamespacesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Backwards compatibility is not guaranteed for this API
                apiInstance.ReadInternalUINamespaces();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalUINamespaces: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readinternaluiresultantacl"></a>
# **ReadInternalUIResultantACL**
> void ReadInternalUIResultantACL (TimeSpan? wrapTTL = null)

Backwards compatibility is not guaranteed for this API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadInternalUIResultantACLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Backwards compatibility is not guaranteed for this API
                apiInstance.ReadInternalUIResultantACL();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInternalUIResultantACL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readkeystatus"></a>
# **ReadKeyStatus**
> void ReadKeyStatus (TimeSpan? wrapTTL = null)

Provides information about the backend encryption key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadKeyStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Provides information about the backend encryption key.
                apiInstance.ReadKeyStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadKeyStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readleader"></a>
# **ReadLeader**
> void ReadLeader (TimeSpan? wrapTTL = null)

Returns the high availability status and current leader instance of Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadLeaderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Returns the high availability status and current leader instance of Vault.
                apiInstance.ReadLeader();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadLeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readleases"></a>
# **ReadLeases**
> void ReadLeases (TimeSpan? wrapTTL = null)

List leases associated with this Vault cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadLeasesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // List leases associated with this Vault cluster
                apiInstance.ReadLeases();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadLeases: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readleasescount"></a>
# **ReadLeasesCount**
> void ReadLeasesCount (TimeSpan? wrapTTL = null)

Count of leases associated with this Vault cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadLeasesCountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Count of leases associated with this Vault cluster
                apiInstance.ReadLeasesCount();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadLeasesCount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readlogger"></a>
# **ReadLogger**
> void ReadLogger (string name, TimeSpan? wrapTTL = null)

Read the log level for a single logger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadLoggerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the logger to be modified.

            try
            {
                // Read the log level for a single logger.
                apiInstance.ReadLogger(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadLogger: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the logger to be modified. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readloggers"></a>
# **ReadLoggers**
> void ReadLoggers (TimeSpan? wrapTTL = null)

Read the log level for all existing loggers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadLoggersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Read the log level for all existing loggers.
                apiInstance.ReadLoggers();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadLoggers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readmetrics"></a>
# **ReadMetrics**
> void ReadMetrics (string format = default(string), TimeSpan? wrapTTL = null)

Export the metrics aggregated for telemetry purpose.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadMetricsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var format = "format_example";  // string | Format to export metrics into. Currently accepts only \"prometheus\". (optional) 

            try
            {
                // Export the metrics aggregated for telemetry purpose.
                apiInstance.ReadMetrics(format);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadMetrics: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Format to export metrics into. Currently accepts only \&quot;prometheus\&quot;. | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readmount"></a>
# **ReadMount**
> void ReadMount (string path, TimeSpan? wrapTTL = null)

Read the configuration of the secret engine at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadMountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | The path to mount to. Example: \"aws/east\"

            try
            {
                // Read the configuration of the secret engine at the given path.
                apiInstance.ReadMount(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadMount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to mount to. Example: \&quot;aws/east\&quot; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readmounts"></a>
# **ReadMounts**
> void ReadMounts (TimeSpan? wrapTTL = null)

List the currently mounted backends.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadMountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // List the currently mounted backends.
                apiInstance.ReadMounts();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadMounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readmountsconfig"></a>
# **ReadMountsConfig**
> void ReadMountsConfig (string path, TimeSpan? wrapTTL = null)

Tune backend configuration parameters for this mount.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadMountsConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | The path to mount to. Example: \"aws/east\"

            try
            {
                // Tune backend configuration parameters for this mount.
                apiInstance.ReadMountsConfig(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadMountsConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to mount to. Example: \&quot;aws/east\&quot; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpluginscatalog"></a>
# **ReadPluginsCatalog**
> void ReadPluginsCatalog (TimeSpan? wrapTTL = null)

Lists all the plugins known to Vault

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPluginsCatalogExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Lists all the plugins known to Vault
                apiInstance.ReadPluginsCatalog();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadPluginsCatalog: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpluginscatalogbytypebyname"></a>
# **ReadPluginsCatalogByTypeByName**
> void ReadPluginsCatalogByTypeByName (string name, string type, TimeSpan? wrapTTL = null)

Return the configuration data for the plugin with the given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPluginsCatalogByTypeByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the plugin
            var type = "type_example";  // string | The type of the plugin, may be auth, secret, or database

            try
            {
                // Return the configuration data for the plugin with the given name.
                apiInstance.ReadPluginsCatalogByTypeByName(name, type);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadPluginsCatalogByTypeByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the plugin | 
 **type** | **string**| The type of the plugin, may be auth, secret, or database | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpolicies"></a>
# **ReadPolicies**
> void ReadPolicies (string list = default(string), TimeSpan? wrapTTL = null)

List the configured access control policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPoliciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // List the configured access control policies.
                apiInstance.ReadPolicies(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadPolicies: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Return a list if &#x60;true&#x60; | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpoliciesacl"></a>
# **ReadPoliciesACL**
> void ReadPoliciesACL (string name, TimeSpan? wrapTTL = null)

Retrieve information about the named ACL policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPoliciesACLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the policy. Example: \"ops\"

            try
            {
                // Retrieve information about the named ACL policy.
                apiInstance.ReadPoliciesACL(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadPoliciesACL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the policy. Example: \&quot;ops\&quot; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpoliciespassword"></a>
# **ReadPoliciesPassword**
> void ReadPoliciesPassword (string name, TimeSpan? wrapTTL = null)

Retrieve an existing password policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPoliciesPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the password policy.

            try
            {
                // Retrieve an existing password policy.
                apiInstance.ReadPoliciesPassword(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadPoliciesPassword: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the password policy. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpoliciespasswordgenerate"></a>
# **ReadPoliciesPasswordGenerate**
> void ReadPoliciesPasswordGenerate (string name, TimeSpan? wrapTTL = null)

Generate a password from an existing password policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPoliciesPasswordGenerateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the password policy.

            try
            {
                // Generate a password from an existing password policy.
                apiInstance.ReadPoliciesPasswordGenerate(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadPoliciesPasswordGenerate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the password policy. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readpolicy"></a>
# **ReadPolicy**
> void ReadPolicy (string name, TimeSpan? wrapTTL = null)

Retrieve the policy body for the named policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the policy. Example: \"ops\"

            try
            {
                // Retrieve the policy body for the named policy.
                apiInstance.ReadPolicy(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadPolicy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the policy. Example: \&quot;ops\&quot; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readquotasconfig"></a>
# **ReadQuotasConfig**
> void ReadQuotasConfig (TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadQuotasConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.ReadQuotasConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadQuotasConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readquotasratelimit"></a>
# **ReadQuotasRateLimit**
> void ReadQuotasRateLimit (string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadQuotasRateLimitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the quota rule.

            try
            {
                apiInstance.ReadQuotasRateLimit(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadQuotasRateLimit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the quota rule. | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readraw"></a>
# **ReadRaw**
> void ReadRaw (string list = default(string), TimeSpan? wrapTTL = null)

Read the value of the key at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadRawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Read the value of the key at the given path.
                apiInstance.ReadRaw(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadRaw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Return a list if &#x60;true&#x60; | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readrawpath"></a>
# **ReadRawPath**
> void ReadRawPath (string path, string list = default(string), TimeSpan? wrapTTL = null)

Read the value of the key at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadRawPathExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | 
            var list = "list_example";  // string | Return a list if `true` (optional) 

            try
            {
                // Read the value of the key at the given path.
                apiInstance.ReadRawPath(path, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadRawPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **list** | **string**| Return a list if &#x60;true&#x60; | [optional] 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readrekeybackup"></a>
# **ReadRekeyBackup**
> void ReadRekeyBackup (TimeSpan? wrapTTL = null)

Return the backup copy of PGP-encrypted unseal keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadRekeyBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Return the backup copy of PGP-encrypted unseal keys.
                apiInstance.ReadRekeyBackup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadRekeyBackup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readrekeyinit"></a>
# **ReadRekeyInit**
> void ReadRekeyInit (TimeSpan? wrapTTL = null)

Reads the configuration and progress of the current rekey attempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadRekeyInitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Reads the configuration and progress of the current rekey attempt.
                apiInstance.ReadRekeyInit();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadRekeyInit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readrekeyrecoverykeybackup"></a>
# **ReadRekeyRecoveryKeyBackup**
> void ReadRekeyRecoveryKeyBackup (TimeSpan? wrapTTL = null)

Allows fetching or deleting the backup of the rotated unseal keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadRekeyRecoveryKeyBackupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Allows fetching or deleting the backup of the rotated unseal keys.
                apiInstance.ReadRekeyRecoveryKeyBackup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadRekeyRecoveryKeyBackup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readrekeyverify"></a>
# **ReadRekeyVerify**
> void ReadRekeyVerify (TimeSpan? wrapTTL = null)

Read the configuration and progress of the current rekey verification attempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadRekeyVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Read the configuration and progress of the current rekey verification attempt.
                apiInstance.ReadRekeyVerify();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadRekeyVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readremountstatus"></a>
# **ReadRemountStatus**
> void ReadRemountStatus (string migrationId, TimeSpan? wrapTTL = null)

Check status of a mount migration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadRemountStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var migrationId = "migrationId_example";  // string | The ID of the migration operation

            try
            {
                // Check status of a mount migration
                apiInstance.ReadRemountStatus(migrationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadRemountStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **migrationId** | **string**| The ID of the migration operation | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readreplicationstatus"></a>
# **ReadReplicationStatus**
> void ReadReplicationStatus (TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadReplicationStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.ReadReplicationStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadReplicationStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readrotateconfig"></a>
# **ReadRotateConfig**
> void ReadRotateConfig (TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadRotateConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                apiInstance.ReadRotateConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadRotateConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readsealstatus"></a>
# **ReadSealStatus**
> void ReadSealStatus (TimeSpan? wrapTTL = null)

Check the seal status of a Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadSealStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Check the seal status of a Vault.
                apiInstance.ReadSealStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSealStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="remount"></a>
# **Remount**
> void Remount (RemountRequest remountRequest, TimeSpan? wrapTTL = null)

Initiate a mount migration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RemountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var remountRequest = new RemountRequest(); // RemountRequest | 

            try
            {
                // Initiate a mount migration
                apiInstance.Remount(remountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Remount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **remountRequest** | [**RemountRequest**](RemountRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="renew"></a>
# **Renew**
> void Renew (RenewRequest renewRequest, TimeSpan? wrapTTL = null)

Renews a lease, requesting to extend the lease.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RenewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var renewRequest = new RenewRequest(); // RenewRequest | 

            try
            {
                // Renews a lease, requesting to extend the lease.
                apiInstance.Renew(renewRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Renew: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **renewRequest** | [**RenewRequest**](RenewRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="renewfor"></a>
# **RenewFor**
> void RenewFor (RenewForRequest renewForRequest, string urlLeaseId, TimeSpan? wrapTTL = null)

Renews a lease, requesting to extend the lease.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RenewForExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var urlLeaseId = "urlLeaseId_example";  // string | The lease identifier to renew. This is included with a lease.
            var renewForRequest = new RenewForRequest(); // RenewForRequest | 

            try
            {
                // Renews a lease, requesting to extend the lease.
                apiInstance.RenewFor(urlLeaseId, renewForRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RenewFor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlLeaseId** | **string**| The lease identifier to renew. This is included with a lease. | 
 **renewForRequest** | [**RenewForRequest**](RenewForRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revoke"></a>
# **Revoke**
> void Revoke (RevokeRequest revokeRequest, TimeSpan? wrapTTL = null)

Revokes a lease immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var revokeRequest = new RevokeRequest(); // RevokeRequest | 

            try
            {
                // Revokes a lease immediately.
                apiInstance.Revoke(revokeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Revoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **revokeRequest** | [**RevokeRequest**](RevokeRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revokeforce"></a>
# **RevokeForce**
> void RevokeForce (string prefix, TimeSpan? wrapTTL = null)

Revokes all secrets or tokens generated under a given prefix immediately

Unlike `/sys/leases/revoke-prefix`, this path ignores backend errors encountered during revocation. This is potentially very dangerous and should only be used in specific emergency situations where errors in the backend or the connected backend service prevent normal revocation.  By ignoring these errors, Vault abdicates responsibility for ensuring that the issued credentials or secrets are properly revoked and/or cleaned up. Access to this endpoint should be tightly controlled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RevokeForceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var prefix = "prefix_example";  // string | The path to revoke keys under. Example: \"prod/aws/ops\"

            try
            {
                // Revokes all secrets or tokens generated under a given prefix immediately
                apiInstance.RevokeForce(prefix);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RevokeForce: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **prefix** | **string**| The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revokelease"></a>
# **RevokeLease**
> void RevokeLease (RevokeLeaseRequest revokeLeaseRequest, string urlLeaseId, TimeSpan? wrapTTL = null)

Revokes a lease immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RevokeLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var urlLeaseId = "urlLeaseId_example";  // string | The lease identifier to renew. This is included with a lease.
            var revokeLeaseRequest = new RevokeLeaseRequest(); // RevokeLeaseRequest | 

            try
            {
                // Revokes a lease immediately.
                apiInstance.RevokeLease(urlLeaseId, revokeLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RevokeLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlLeaseId** | **string**| The lease identifier to renew. This is included with a lease. | 
 **revokeLeaseRequest** | [**RevokeLeaseRequest**](RevokeLeaseRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="revokeprefix"></a>
# **RevokePrefix**
> void RevokePrefix (RevokePrefixRequest revokePrefixRequest, string prefix, TimeSpan? wrapTTL = null)

Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RevokePrefixExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var prefix = "prefix_example";  // string | The path to revoke keys under. Example: \"prod/aws/ops\"
            var revokePrefixRequest = new RevokePrefixRequest(); // RevokePrefixRequest | 

            try
            {
                // Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.
                apiInstance.RevokePrefix(prefix, revokePrefixRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RevokePrefix: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **prefix** | **string**| The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot; | 
 **revokePrefixRequest** | [**RevokePrefixRequest**](RevokePrefixRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rotate"></a>
# **Rotate**
> void Rotate (TimeSpan? wrapTTL = null)

Rotates the backend encryption key used to persist data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class RotateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Rotates the backend encryption key used to persist data.
                apiInstance.Rotate();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Rotate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="seal"></a>
# **Seal**
> void Seal (TimeSpan? wrapTTL = null)

Seal the Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SealExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Seal the Vault.
                apiInstance.Seal();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Seal: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="stepdownleader"></a>
# **StepDownLeader**
> void StepDownLeader (TimeSpan? wrapTTL = null)

Cause the node to give up active status.

This endpoint forces the node to give up active status. If the node does not have active status, this endpoint does nothing. Note that the node will sleep for ten seconds before attempting to grab the active lock again, but if no standby nodes grab the active lock in the interim, the same node may become the active node again.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class StepDownLeaderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Cause the node to give up active status.
                apiInstance.StepDownLeader();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.StepDownLeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sysdeletepluginscatalogname"></a>
# **SysDeletePluginsCatalogName**
> void SysDeletePluginsCatalogName (string name, TimeSpan? wrapTTL = null)

Remove the plugin with the given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SysDeletePluginsCatalogNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the plugin

            try
            {
                // Remove the plugin with the given name.
                apiInstance.SysDeletePluginsCatalogName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.SysDeletePluginsCatalogName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the plugin | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | empty body |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syslistleaseslookup"></a>
# **SysListLeasesLookup**
> void SysListLeasesLookup (TimeSpan? wrapTTL = null)

Returns a list of lease ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SysListLeasesLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var list = "true";  // string | Must be set to `true`

            try
            {
                // Returns a list of lease ids.
                apiInstance.SysListLeasesLookup(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.SysListLeasesLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Must be set to &#x60;true&#x60; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sysreadpluginscatalogname"></a>
# **SysReadPluginsCatalogName**
> void SysReadPluginsCatalogName (string name, TimeSpan? wrapTTL = null)

Return the configuration data for the plugin with the given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SysReadPluginsCatalogNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the plugin

            try
            {
                // Return the configuration data for the plugin with the given name.
                apiInstance.SysReadPluginsCatalogName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.SysReadPluginsCatalogName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the plugin | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syswritelockedusersmountaccessorunlockaliasidentifier"></a>
# **SysWriteLockedusersMountAccessorUnlockAliasIdentifier**
> void SysWriteLockedusersMountAccessorUnlockAliasIdentifier (string aliasIdentifier, string mountAccessor, TimeSpan? wrapTTL = null)

Unlocks the user with given mount_accessor and alias_identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SysWriteLockedusersMountAccessorUnlockAliasIdentifierExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var aliasIdentifier = "aliasIdentifier_example";  // string | It is the name of the alias (user). For example, if the alias belongs to userpass backend, the name should be a valid username within userpass auth method. If the alias belongs to an approle auth method, the name should be a valid RoleID
            var mountAccessor = "mountAccessor_example";  // string | MountAccessor is the identifier of the mount entry to which the user belongs

            try
            {
                // Unlocks the user with given mount_accessor and alias_identifier
                apiInstance.SysWriteLockedusersMountAccessorUnlockAliasIdentifier(aliasIdentifier, mountAccessor);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.SysWriteLockedusersMountAccessorUnlockAliasIdentifier: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **aliasIdentifier** | **string**| It is the name of the alias (user). For example, if the alias belongs to userpass backend, the name should be a valid username within userpass auth method. If the alias belongs to an approle auth method, the name should be a valid RoleID | 
 **mountAccessor** | **string**| MountAccessor is the identifier of the mount entry to which the user belongs | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syswritepluginscatalogname"></a>
# **SysWritePluginsCatalogName**
> void SysWritePluginsCatalogName (SysWritePluginsCatalogNameRequest sysWritePluginsCatalogNameRequest, string name, TimeSpan? wrapTTL = null)

Register a new plugin, or updates an existing one with the supplied name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SysWritePluginsCatalogNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the plugin
            var sysWritePluginsCatalogNameRequest = new SysWritePluginsCatalogNameRequest(); // SysWritePluginsCatalogNameRequest | 

            try
            {
                // Register a new plugin, or updates an existing one with the supplied name.
                apiInstance.SysWritePluginsCatalogName(name, sysWritePluginsCatalogNameRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.SysWritePluginsCatalogName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the plugin | 
 **sysWritePluginsCatalogNameRequest** | [**SysWritePluginsCatalogNameRequest**](SysWritePluginsCatalogNameRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="syswritetoolsrandomurlbytes"></a>
# **SysWriteToolsRandomUrlbytes**
> void SysWriteToolsRandomUrlbytes (SysWriteToolsRandomUrlbytesRequest sysWriteToolsRandomUrlbytesRequest, string urlbytes, TimeSpan? wrapTTL = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class SysWriteToolsRandomUrlbytesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var urlbytes = "urlbytes_example";  // string | The number of bytes to generate (POST URL parameter)
            var sysWriteToolsRandomUrlbytesRequest = new SysWriteToolsRandomUrlbytesRequest(); // SysWriteToolsRandomUrlbytesRequest | 

            try
            {
                // Generate random bytes
                apiInstance.SysWriteToolsRandomUrlbytes(urlbytes, sysWriteToolsRandomUrlbytesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.SysWriteToolsRandomUrlbytes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlbytes** | **string**| The number of bytes to generate (POST URL parameter) | 
 **sysWriteToolsRandomUrlbytesRequest** | [**SysWriteToolsRandomUrlbytesRequest**](SysWriteToolsRandomUrlbytesRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolsgeneraterandom"></a>
# **ToolsGenerateRandom**
> void ToolsGenerateRandom (ToolsGenerateRandomRequest toolsGenerateRandomRequest, TimeSpan? wrapTTL = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ToolsGenerateRandomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var toolsGenerateRandomRequest = new ToolsGenerateRandomRequest(); // ToolsGenerateRandomRequest | 

            try
            {
                // Generate random bytes
                apiInstance.ToolsGenerateRandom(toolsGenerateRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ToolsGenerateRandom: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **toolsGenerateRandomRequest** | [**ToolsGenerateRandomRequest**](ToolsGenerateRandomRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolsgeneraterandomsource"></a>
# **ToolsGenerateRandomSource**
> void ToolsGenerateRandomSource (ToolsGenerateRandomSourceRequest toolsGenerateRandomSourceRequest, string source, TimeSpan? wrapTTL = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ToolsGenerateRandomSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var source = "\"platform\"";  // string | Which system to source random data from, ether \"platform\", \"seal\", or \"all\". (default to "platform")
            var toolsGenerateRandomSourceRequest = new ToolsGenerateRandomSourceRequest(); // ToolsGenerateRandomSourceRequest | 

            try
            {
                // Generate random bytes
                apiInstance.ToolsGenerateRandomSource(source, toolsGenerateRandomSourceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ToolsGenerateRandomSource: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | **string**| Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;. | [default to &quot;platform&quot;]
 **toolsGenerateRandomSourceRequest** | [**ToolsGenerateRandomSourceRequest**](ToolsGenerateRandomSourceRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolsgeneraterandomsourcebytes"></a>
# **ToolsGenerateRandomSourceBytes**
> void ToolsGenerateRandomSourceBytes (ToolsGenerateRandomSourceBytesRequest toolsGenerateRandomSourceBytesRequest, string source, string urlbytes, TimeSpan? wrapTTL = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ToolsGenerateRandomSourceBytesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var source = "\"platform\"";  // string | Which system to source random data from, ether \"platform\", \"seal\", or \"all\". (default to "platform")
            var urlbytes = "urlbytes_example";  // string | The number of bytes to generate (POST URL parameter)
            var toolsGenerateRandomSourceBytesRequest = new ToolsGenerateRandomSourceBytesRequest(); // ToolsGenerateRandomSourceBytesRequest | 

            try
            {
                // Generate random bytes
                apiInstance.ToolsGenerateRandomSourceBytes(source, urlbytes, toolsGenerateRandomSourceBytesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ToolsGenerateRandomSourceBytes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | **string**| Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;. | [default to &quot;platform&quot;]
 **urlbytes** | **string**| The number of bytes to generate (POST URL parameter) | 
 **toolsGenerateRandomSourceBytesRequest** | [**ToolsGenerateRandomSourceBytesRequest**](ToolsGenerateRandomSourceBytesRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolshash"></a>
# **ToolsHash**
> void ToolsHash (ToolsHashRequest toolsHashRequest, TimeSpan? wrapTTL = null)

Generate a hash sum for input data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ToolsHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var toolsHashRequest = new ToolsHashRequest(); // ToolsHashRequest | 

            try
            {
                // Generate a hash sum for input data
                apiInstance.ToolsHash(toolsHashRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ToolsHash: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **toolsHashRequest** | [**ToolsHashRequest**](ToolsHashRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="toolshashwith"></a>
# **ToolsHashWith**
> void ToolsHashWith (ToolsHashWithRequest toolsHashWithRequest, string urlalgorithm, TimeSpan? wrapTTL = null)

Generate a hash sum for input data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ToolsHashWithExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var urlalgorithm = "urlalgorithm_example";  // string | Algorithm to use (POST URL parameter)
            var toolsHashWithRequest = new ToolsHashWithRequest(); // ToolsHashWithRequest | 

            try
            {
                // Generate a hash sum for input data
                apiInstance.ToolsHashWith(urlalgorithm, toolsHashWithRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ToolsHashWith: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlalgorithm** | **string**| Algorithm to use (POST URL parameter) | 
 **toolsHashWithRequest** | [**ToolsHashWithRequest**](ToolsHashWithRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unseal"></a>
# **Unseal**
> void Unseal (UnsealRequest unsealRequest, TimeSpan? wrapTTL = null)

Unseal the Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UnsealExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var unsealRequest = new UnsealRequest(); // UnsealRequest | 

            try
            {
                // Unseal the Vault.
                apiInstance.Unseal(unsealRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Unseal: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unsealRequest** | [**UnsealRequest**](UnsealRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wrappingreadlookup"></a>
# **WrappingReadLookup**
> void WrappingReadLookup (TimeSpan? wrapTTL = null)

Look up wrapping properties for the requester's token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WrappingReadLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Look up wrapping properties for the requester's token.
                apiInstance.WrappingReadLookup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WrappingReadLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wrappingrewrap"></a>
# **WrappingRewrap**
> void WrappingRewrap (WrappingRewrapRequest wrappingRewrapRequest, TimeSpan? wrapTTL = null)

Rotates a response-wrapped token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WrappingRewrapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var wrappingRewrapRequest = new WrappingRewrapRequest(); // WrappingRewrapRequest | 

            try
            {
                // Rotates a response-wrapped token.
                apiInstance.WrappingRewrap(wrappingRewrapRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WrappingRewrap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wrappingRewrapRequest** | [**WrappingRewrapRequest**](WrappingRewrapRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wrappingunwrap"></a>
# **WrappingUnwrap**
> void WrappingUnwrap (WrappingUnwrapRequest wrappingUnwrapRequest, TimeSpan? wrapTTL = null)

Unwraps a response-wrapped token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WrappingUnwrapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var wrappingUnwrapRequest = new WrappingUnwrapRequest(); // WrappingUnwrapRequest | 

            try
            {
                // Unwraps a response-wrapped token.
                apiInstance.WrappingUnwrap(wrappingUnwrapRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WrappingUnwrap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wrappingUnwrapRequest** | [**WrappingUnwrapRequest**](WrappingUnwrapRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wrappingwrap"></a>
# **WrappingWrap**
> void WrappingWrap (TimeSpan? wrapTTL = null)

Response-wraps an arbitrary JSON object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WrappingWrapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // Response-wraps an arbitrary JSON object.
                apiInstance.WrappingWrap();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WrappingWrap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wrappingwritelookup"></a>
# **WrappingWriteLookup**
> void WrappingWriteLookup (WrappingWriteLookupRequest wrappingWriteLookupRequest, TimeSpan? wrapTTL = null)

Look up wrapping properties for the given token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WrappingWriteLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var wrappingWriteLookupRequest = new WrappingWriteLookupRequest(); // WrappingWriteLookupRequest | 

            try
            {
                // Look up wrapping properties for the given token.
                apiInstance.WrappingWriteLookup(wrappingWriteLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WrappingWriteLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **wrappingWriteLookupRequest** | [**WrappingWriteLookupRequest**](WrappingWriteLookupRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeauditdevice"></a>
# **WriteAuditDevice**
> void WriteAuditDevice (WriteAuditDeviceRequest writeAuditDeviceRequest, string path, TimeSpan? wrapTTL = null)

Enable a new audit device at the supplied path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteAuditDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | The name of the backend. Cannot be delimited. Example: \"mysql\"
            var writeAuditDeviceRequest = new WriteAuditDeviceRequest(); // WriteAuditDeviceRequest | 

            try
            {
                // Enable a new audit device at the supplied path.
                apiInstance.WriteAuditDevice(path, writeAuditDeviceRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteAuditDevice: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot; | 
 **writeAuditDeviceRequest** | [**WriteAuditDeviceRequest**](WriteAuditDeviceRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeauthmethod"></a>
# **WriteAuthMethod**
> void WriteAuthMethod (WriteAuthMethodRequest writeAuthMethodRequest, string path, TimeSpan? wrapTTL = null)

Enables a new auth method.

After enabling, the auth method can be accessed and configured via the auth path specified as part of the URL. This auth path will be nested under the auth prefix.  For example, enable the \"foo\" auth method will make it accessible at /auth/foo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteAuthMethodExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | The path to mount to. Cannot be delimited. Example: \"user\"
            var writeAuthMethodRequest = new WriteAuthMethodRequest(); // WriteAuthMethodRequest | 

            try
            {
                // Enables a new auth method.
                apiInstance.WriteAuthMethod(path, writeAuthMethodRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteAuthMethod: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to mount to. Cannot be delimited. Example: \&quot;user\&quot; | 
 **writeAuthMethodRequest** | [**WriteAuthMethodRequest**](WriteAuthMethodRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeauthmethodtune"></a>
# **WriteAuthMethodTune**
> void WriteAuthMethodTune (WriteAuthMethodTuneRequest writeAuthMethodTuneRequest, string path, TimeSpan? wrapTTL = null)

Tune configuration parameters for a given auth path.

This endpoint requires sudo capability on the final path, but the same functionality can be achieved without sudo via `sys/mounts/auth/[auth-path]/tune`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteAuthMethodTuneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | Tune the configuration parameters for an auth path.
            var writeAuthMethodTuneRequest = new WriteAuthMethodTuneRequest(); // WriteAuthMethodTuneRequest | 

            try
            {
                // Tune configuration parameters for a given auth path.
                apiInstance.WriteAuthMethodTune(path, writeAuthMethodTuneRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteAuthMethodTune: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Tune the configuration parameters for an auth path. | 
 **writeAuthMethodTuneRequest** | [**WriteAuthMethodTuneRequest**](WriteAuthMethodTuneRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writecapabilities"></a>
# **WriteCapabilities**
> void WriteCapabilities (WriteCapabilitiesRequest writeCapabilitiesRequest, TimeSpan? wrapTTL = null)

Fetches the capabilities of the given token on the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteCapabilitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeCapabilitiesRequest = new WriteCapabilitiesRequest(); // WriteCapabilitiesRequest | 

            try
            {
                // Fetches the capabilities of the given token on the given path.
                apiInstance.WriteCapabilities(writeCapabilitiesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteCapabilities: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeCapabilitiesRequest** | [**WriteCapabilitiesRequest**](WriteCapabilitiesRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writecapabilitiesaccessor"></a>
# **WriteCapabilitiesAccessor**
> void WriteCapabilitiesAccessor (WriteCapabilitiesAccessorRequest writeCapabilitiesAccessorRequest, TimeSpan? wrapTTL = null)

Fetches the capabilities of the token associated with the given token, on the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteCapabilitiesAccessorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeCapabilitiesAccessorRequest = new WriteCapabilitiesAccessorRequest(); // WriteCapabilitiesAccessorRequest | 

            try
            {
                // Fetches the capabilities of the token associated with the given token, on the given path.
                apiInstance.WriteCapabilitiesAccessor(writeCapabilitiesAccessorRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteCapabilitiesAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeCapabilitiesAccessorRequest** | [**WriteCapabilitiesAccessorRequest**](WriteCapabilitiesAccessorRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writecapabilitiesself"></a>
# **WriteCapabilitiesSelf**
> void WriteCapabilitiesSelf (WriteCapabilitiesSelfRequest writeCapabilitiesSelfRequest, TimeSpan? wrapTTL = null)

Fetches the capabilities of the given token on the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteCapabilitiesSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeCapabilitiesSelfRequest = new WriteCapabilitiesSelfRequest(); // WriteCapabilitiesSelfRequest | 

            try
            {
                // Fetches the capabilities of the given token on the given path.
                apiInstance.WriteCapabilitiesSelf(writeCapabilitiesSelfRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteCapabilitiesSelf: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeCapabilitiesSelfRequest** | [**WriteCapabilitiesSelfRequest**](WriteCapabilitiesSelfRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeconfigauditingrequestheader"></a>
# **WriteConfigAuditingRequestHeader**
> void WriteConfigAuditingRequestHeader (WriteConfigAuditingRequestHeaderRequest writeConfigAuditingRequestHeaderRequest, string header, TimeSpan? wrapTTL = null)

Enable auditing of a header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteConfigAuditingRequestHeaderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var header = "header_example";  // string | 
            var writeConfigAuditingRequestHeaderRequest = new WriteConfigAuditingRequestHeaderRequest(); // WriteConfigAuditingRequestHeaderRequest | 

            try
            {
                // Enable auditing of a header.
                apiInstance.WriteConfigAuditingRequestHeader(header, writeConfigAuditingRequestHeaderRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteConfigAuditingRequestHeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header** | **string**|  | 
 **writeConfigAuditingRequestHeaderRequest** | [**WriteConfigAuditingRequestHeaderRequest**](WriteConfigAuditingRequestHeaderRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeconfigcors"></a>
# **WriteConfigCORS**
> void WriteConfigCORS (WriteConfigCORSRequest writeConfigCORSRequest, TimeSpan? wrapTTL = null)

Configure the CORS settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteConfigCORSExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeConfigCORSRequest = new WriteConfigCORSRequest(); // WriteConfigCORSRequest | 

            try
            {
                // Configure the CORS settings.
                apiInstance.WriteConfigCORS(writeConfigCORSRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteConfigCORS: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeConfigCORSRequest** | [**WriteConfigCORSRequest**](WriteConfigCORSRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeconfigreloadsubsystem"></a>
# **WriteConfigReloadSubsystem**
> void WriteConfigReloadSubsystem (string subsystem, TimeSpan? wrapTTL = null)

Reload the given subsystem

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteConfigReloadSubsystemExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var subsystem = "subsystem_example";  // string | 

            try
            {
                // Reload the given subsystem
                apiInstance.WriteConfigReloadSubsystem(subsystem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteConfigReloadSubsystem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subsystem** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeconfiguiheader"></a>
# **WriteConfigUIHeader**
> void WriteConfigUIHeader (WriteConfigUIHeaderRequest writeConfigUIHeaderRequest, string header, TimeSpan? wrapTTL = null)

Configure the values to be returned for the UI header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteConfigUIHeaderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var header = "header_example";  // string | The name of the header.
            var writeConfigUIHeaderRequest = new WriteConfigUIHeaderRequest(); // WriteConfigUIHeaderRequest | 

            try
            {
                // Configure the values to be returned for the UI header.
                apiInstance.WriteConfigUIHeader(header, writeConfigUIHeaderRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteConfigUIHeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header** | **string**| The name of the header. | 
 **writeConfigUIHeaderRequest** | [**WriteConfigUIHeaderRequest**](WriteConfigUIHeaderRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writegenerateroot"></a>
# **WriteGenerateRoot**
> void WriteGenerateRoot (WriteGenerateRootRequest writeGenerateRootRequest, TimeSpan? wrapTTL = null)

Initializes a new root generation attempt.

Only a single root generation attempt can take place at a time. One (and only one) of otp or pgp_key are required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteGenerateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeGenerateRootRequest = new WriteGenerateRootRequest(); // WriteGenerateRootRequest | 

            try
            {
                // Initializes a new root generation attempt.
                apiInstance.WriteGenerateRoot(writeGenerateRootRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteGenerateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeGenerateRootRequest** | [**WriteGenerateRootRequest**](WriteGenerateRootRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writegeneraterootattempt"></a>
# **WriteGenerateRootAttempt**
> void WriteGenerateRootAttempt (WriteGenerateRootAttemptRequest writeGenerateRootAttemptRequest, TimeSpan? wrapTTL = null)

Initializes a new root generation attempt.

Only a single root generation attempt can take place at a time. One (and only one) of otp or pgp_key are required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteGenerateRootAttemptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeGenerateRootAttemptRequest = new WriteGenerateRootAttemptRequest(); // WriteGenerateRootAttemptRequest | 

            try
            {
                // Initializes a new root generation attempt.
                apiInstance.WriteGenerateRootAttempt(writeGenerateRootAttemptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteGenerateRootAttempt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeGenerateRootAttemptRequest** | [**WriteGenerateRootAttemptRequest**](WriteGenerateRootAttemptRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writegeneraterootupdate"></a>
# **WriteGenerateRootUpdate**
> void WriteGenerateRootUpdate (WriteGenerateRootUpdateRequest writeGenerateRootUpdateRequest, TimeSpan? wrapTTL = null)

Enter a single unseal key share to progress the root generation attempt.

If the threshold number of unseal key shares is reached, Vault will complete the root generation and issue the new token. Otherwise, this API must be called multiple times until that threshold is met. The attempt nonce must be provided with each call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteGenerateRootUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeGenerateRootUpdateRequest = new WriteGenerateRootUpdateRequest(); // WriteGenerateRootUpdateRequest | 

            try
            {
                // Enter a single unseal key share to progress the root generation attempt.
                apiInstance.WriteGenerateRootUpdate(writeGenerateRootUpdateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteGenerateRootUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeGenerateRootUpdateRequest** | [**WriteGenerateRootUpdateRequest**](WriteGenerateRootUpdateRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeinit"></a>
# **WriteInit**
> void WriteInit (WriteInitRequest writeInitRequest, TimeSpan? wrapTTL = null)

Initialize a new Vault.

The Vault must not have been previously initialized. The recovery options, as well as the stored shares option, are only available when using Vault HSM.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteInitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeInitRequest = new WriteInitRequest(); // WriteInitRequest | 

            try
            {
                // Initialize a new Vault.
                apiInstance.WriteInit(writeInitRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteInit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeInitRequest** | [**WriteInitRequest**](WriteInitRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeinternalcountersconfig"></a>
# **WriteInternalCountersConfig**
> void WriteInternalCountersConfig (WriteInternalCountersConfigRequest writeInternalCountersConfigRequest, TimeSpan? wrapTTL = null)

Enable or disable collection of client count, set retention period, or set default reporting period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteInternalCountersConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeInternalCountersConfigRequest = new WriteInternalCountersConfigRequest(); // WriteInternalCountersConfigRequest | 

            try
            {
                // Enable or disable collection of client count, set retention period, or set default reporting period.
                apiInstance.WriteInternalCountersConfig(writeInternalCountersConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteInternalCountersConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeInternalCountersConfigRequest** | [**WriteInternalCountersConfigRequest**](WriteInternalCountersConfigRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeleaseslookup"></a>
# **WriteLeasesLookup**
> void WriteLeasesLookup (WriteLeasesLookupRequest writeLeasesLookupRequest, TimeSpan? wrapTTL = null)

Retrieve lease metadata.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteLeasesLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeLeasesLookupRequest = new WriteLeasesLookupRequest(); // WriteLeasesLookupRequest | 

            try
            {
                // Retrieve lease metadata.
                apiInstance.WriteLeasesLookup(writeLeasesLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteLeasesLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeLeasesLookupRequest** | [**WriteLeasesLookupRequest**](WriteLeasesLookupRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeleasesrenew"></a>
# **WriteLeasesRenew**
> void WriteLeasesRenew (WriteLeasesRenewRequest writeLeasesRenewRequest, TimeSpan? wrapTTL = null)

Renews a lease, requesting to extend the lease.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteLeasesRenewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeLeasesRenewRequest = new WriteLeasesRenewRequest(); // WriteLeasesRenewRequest | 

            try
            {
                // Renews a lease, requesting to extend the lease.
                apiInstance.WriteLeasesRenew(writeLeasesRenewRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteLeasesRenew: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeLeasesRenewRequest** | [**WriteLeasesRenewRequest**](WriteLeasesRenewRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeleasesrenew2"></a>
# **WriteLeasesRenew2**
> void WriteLeasesRenew2 (WriteLeasesRenew2Request writeLeasesRenew2Request, string urlLeaseId, TimeSpan? wrapTTL = null)

Renews a lease, requesting to extend the lease.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteLeasesRenew2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var urlLeaseId = "urlLeaseId_example";  // string | The lease identifier to renew. This is included with a lease.
            var writeLeasesRenew2Request = new WriteLeasesRenew2Request(); // WriteLeasesRenew2Request | 

            try
            {
                // Renews a lease, requesting to extend the lease.
                apiInstance.WriteLeasesRenew2(urlLeaseId, writeLeasesRenew2Request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteLeasesRenew2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlLeaseId** | **string**| The lease identifier to renew. This is included with a lease. | 
 **writeLeasesRenew2Request** | [**WriteLeasesRenew2Request**](WriteLeasesRenew2Request.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeleasesrevoke"></a>
# **WriteLeasesRevoke**
> void WriteLeasesRevoke (WriteLeasesRevokeRequest writeLeasesRevokeRequest, TimeSpan? wrapTTL = null)

Revokes a lease immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteLeasesRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeLeasesRevokeRequest = new WriteLeasesRevokeRequest(); // WriteLeasesRevokeRequest | 

            try
            {
                // Revokes a lease immediately.
                apiInstance.WriteLeasesRevoke(writeLeasesRevokeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteLeasesRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeLeasesRevokeRequest** | [**WriteLeasesRevokeRequest**](WriteLeasesRevokeRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeleasesrevoke2"></a>
# **WriteLeasesRevoke2**
> void WriteLeasesRevoke2 (WriteLeasesRevoke2Request writeLeasesRevoke2Request, string urlLeaseId, TimeSpan? wrapTTL = null)

Revokes a lease immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteLeasesRevoke2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var urlLeaseId = "urlLeaseId_example";  // string | The lease identifier to renew. This is included with a lease.
            var writeLeasesRevoke2Request = new WriteLeasesRevoke2Request(); // WriteLeasesRevoke2Request | 

            try
            {
                // Revokes a lease immediately.
                apiInstance.WriteLeasesRevoke2(urlLeaseId, writeLeasesRevoke2Request);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteLeasesRevoke2: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlLeaseId** | **string**| The lease identifier to renew. This is included with a lease. | 
 **writeLeasesRevoke2Request** | [**WriteLeasesRevoke2Request**](WriteLeasesRevoke2Request.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeleasesrevokeforce"></a>
# **WriteLeasesRevokeForce**
> void WriteLeasesRevokeForce (string prefix, TimeSpan? wrapTTL = null)

Revokes all secrets or tokens generated under a given prefix immediately

Unlike `/sys/leases/revoke-prefix`, this path ignores backend errors encountered during revocation. This is potentially very dangerous and should only be used in specific emergency situations where errors in the backend or the connected backend service prevent normal revocation.  By ignoring these errors, Vault abdicates responsibility for ensuring that the issued credentials or secrets are properly revoked and/or cleaned up. Access to this endpoint should be tightly controlled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteLeasesRevokeForceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var prefix = "prefix_example";  // string | The path to revoke keys under. Example: \"prod/aws/ops\"

            try
            {
                // Revokes all secrets or tokens generated under a given prefix immediately
                apiInstance.WriteLeasesRevokeForce(prefix);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteLeasesRevokeForce: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **prefix** | **string**| The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot; | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeleasesrevokeprefix"></a>
# **WriteLeasesRevokePrefix**
> void WriteLeasesRevokePrefix (WriteLeasesRevokePrefixRequest writeLeasesRevokePrefixRequest, string prefix, TimeSpan? wrapTTL = null)

Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteLeasesRevokePrefixExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var prefix = "prefix_example";  // string | The path to revoke keys under. Example: \"prod/aws/ops\"
            var writeLeasesRevokePrefixRequest = new WriteLeasesRevokePrefixRequest(); // WriteLeasesRevokePrefixRequest | 

            try
            {
                // Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.
                apiInstance.WriteLeasesRevokePrefix(prefix, writeLeasesRevokePrefixRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteLeasesRevokePrefix: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **prefix** | **string**| The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot; | 
 **writeLeasesRevokePrefixRequest** | [**WriteLeasesRevokePrefixRequest**](WriteLeasesRevokePrefixRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeleasestidy"></a>
# **WriteLeasesTidy**
> void WriteLeasesTidy (TimeSpan? wrapTTL = null)

This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteLeasesTidyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);

            try
            {
                // This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
                apiInstance.WriteLeasesTidy();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteLeasesTidy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writelogger"></a>
# **WriteLogger**
> void WriteLogger (WriteLoggerRequest writeLoggerRequest, string name, TimeSpan? wrapTTL = null)

Modify the log level of a single logger.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteLoggerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the logger to be modified.
            var writeLoggerRequest = new WriteLoggerRequest(); // WriteLoggerRequest | 

            try
            {
                // Modify the log level of a single logger.
                apiInstance.WriteLogger(name, writeLoggerRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteLogger: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the logger to be modified. | 
 **writeLoggerRequest** | [**WriteLoggerRequest**](WriteLoggerRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeloggers"></a>
# **WriteLoggers**
> void WriteLoggers (WriteLoggersRequest writeLoggersRequest, TimeSpan? wrapTTL = null)

Modify the log level for all existing loggers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteLoggersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeLoggersRequest = new WriteLoggersRequest(); // WriteLoggersRequest | 

            try
            {
                // Modify the log level for all existing loggers.
                apiInstance.WriteLoggers(writeLoggersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteLoggers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeLoggersRequest** | [**WriteLoggersRequest**](WriteLoggersRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writemount"></a>
# **WriteMount**
> void WriteMount (WriteMountRequest writeMountRequest, string path, TimeSpan? wrapTTL = null)

Enable a new secrets engine at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteMountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | The path to mount to. Example: \"aws/east\"
            var writeMountRequest = new WriteMountRequest(); // WriteMountRequest | 

            try
            {
                // Enable a new secrets engine at the given path.
                apiInstance.WriteMount(path, writeMountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteMount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to mount to. Example: \&quot;aws/east\&quot; | 
 **writeMountRequest** | [**WriteMountRequest**](WriteMountRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writemountsconfig"></a>
# **WriteMountsConfig**
> void WriteMountsConfig (WriteMountsConfigRequest writeMountsConfigRequest, string path, TimeSpan? wrapTTL = null)

Tune backend configuration parameters for this mount.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteMountsConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | The path to mount to. Example: \"aws/east\"
            var writeMountsConfigRequest = new WriteMountsConfigRequest(); // WriteMountsConfigRequest | 

            try
            {
                // Tune backend configuration parameters for this mount.
                apiInstance.WriteMountsConfig(path, writeMountsConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteMountsConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to mount to. Example: \&quot;aws/east\&quot; | 
 **writeMountsConfigRequest** | [**WriteMountsConfigRequest**](WriteMountsConfigRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writepluginscatalogbytypebyname"></a>
# **WritePluginsCatalogByTypeByName**
> void WritePluginsCatalogByTypeByName (WritePluginsCatalogByTypeByNameRequest writePluginsCatalogByTypeByNameRequest, string name, string type, TimeSpan? wrapTTL = null)

Register a new plugin, or updates an existing one with the supplied name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WritePluginsCatalogByTypeByNameExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the plugin
            var type = "type_example";  // string | The type of the plugin, may be auth, secret, or database
            var writePluginsCatalogByTypeByNameRequest = new WritePluginsCatalogByTypeByNameRequest(); // WritePluginsCatalogByTypeByNameRequest | 

            try
            {
                // Register a new plugin, or updates an existing one with the supplied name.
                apiInstance.WritePluginsCatalogByTypeByName(name, type, writePluginsCatalogByTypeByNameRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WritePluginsCatalogByTypeByName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the plugin | 
 **type** | **string**| The type of the plugin, may be auth, secret, or database | 
 **writePluginsCatalogByTypeByNameRequest** | [**WritePluginsCatalogByTypeByNameRequest**](WritePluginsCatalogByTypeByNameRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writepluginsreloadbackend"></a>
# **WritePluginsReloadBackend**
> void WritePluginsReloadBackend (WritePluginsReloadBackendRequest writePluginsReloadBackendRequest, TimeSpan? wrapTTL = null)

Reload mounted plugin backends.

Either the plugin name (`plugin`) or the desired plugin backend mounts (`mounts`) must be provided, but not both. In the case that the plugin name is provided, all mounted paths that use that plugin backend will be reloaded.  If (`scope`) is provided and is (`global`), the plugin(s) are reloaded globally.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WritePluginsReloadBackendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writePluginsReloadBackendRequest = new WritePluginsReloadBackendRequest(); // WritePluginsReloadBackendRequest | 

            try
            {
                // Reload mounted plugin backends.
                apiInstance.WritePluginsReloadBackend(writePluginsReloadBackendRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WritePluginsReloadBackend: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writePluginsReloadBackendRequest** | [**WritePluginsReloadBackendRequest**](WritePluginsReloadBackendRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writepoliciesacl"></a>
# **WritePoliciesACL**
> void WritePoliciesACL (WritePoliciesACLRequest writePoliciesACLRequest, string name, TimeSpan? wrapTTL = null)

Add a new or update an existing ACL policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WritePoliciesACLExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the policy. Example: \"ops\"
            var writePoliciesACLRequest = new WritePoliciesACLRequest(); // WritePoliciesACLRequest | 

            try
            {
                // Add a new or update an existing ACL policy.
                apiInstance.WritePoliciesACL(name, writePoliciesACLRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WritePoliciesACL: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the policy. Example: \&quot;ops\&quot; | 
 **writePoliciesACLRequest** | [**WritePoliciesACLRequest**](WritePoliciesACLRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writepoliciespassword"></a>
# **WritePoliciesPassword**
> void WritePoliciesPassword (WritePoliciesPasswordRequest writePoliciesPasswordRequest, string name, TimeSpan? wrapTTL = null)

Add a new or update an existing password policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WritePoliciesPasswordExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the password policy.
            var writePoliciesPasswordRequest = new WritePoliciesPasswordRequest(); // WritePoliciesPasswordRequest | 

            try
            {
                // Add a new or update an existing password policy.
                apiInstance.WritePoliciesPassword(name, writePoliciesPasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WritePoliciesPassword: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the password policy. | 
 **writePoliciesPasswordRequest** | [**WritePoliciesPasswordRequest**](WritePoliciesPasswordRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writepolicy"></a>
# **WritePolicy**
> void WritePolicy (WritePolicyRequest writePolicyRequest, string name, TimeSpan? wrapTTL = null)

Add a new or update an existing policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WritePolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | The name of the policy. Example: \"ops\"
            var writePolicyRequest = new WritePolicyRequest(); // WritePolicyRequest | 

            try
            {
                // Add a new or update an existing policy.
                apiInstance.WritePolicy(name, writePolicyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WritePolicy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the policy. Example: \&quot;ops\&quot; | 
 **writePolicyRequest** | [**WritePolicyRequest**](WritePolicyRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writequotasconfig"></a>
# **WriteQuotasConfig**
> void WriteQuotasConfig (WriteQuotasConfigRequest writeQuotasConfigRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteQuotasConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeQuotasConfigRequest = new WriteQuotasConfigRequest(); // WriteQuotasConfigRequest | 

            try
            {
                apiInstance.WriteQuotasConfig(writeQuotasConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteQuotasConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeQuotasConfigRequest** | [**WriteQuotasConfigRequest**](WriteQuotasConfigRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writequotasratelimit"></a>
# **WriteQuotasRateLimit**
> void WriteQuotasRateLimit (WriteQuotasRateLimitRequest writeQuotasRateLimitRequest, string name, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteQuotasRateLimitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var name = "name_example";  // string | Name of the quota rule.
            var writeQuotasRateLimitRequest = new WriteQuotasRateLimitRequest(); // WriteQuotasRateLimitRequest | 

            try
            {
                apiInstance.WriteQuotasRateLimit(name, writeQuotasRateLimitRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteQuotasRateLimit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the quota rule. | 
 **writeQuotasRateLimitRequest** | [**WriteQuotasRateLimitRequest**](WriteQuotasRateLimitRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writeraw"></a>
# **WriteRaw**
> void WriteRaw (WriteRawRequest writeRawRequest, TimeSpan? wrapTTL = null)

Update the value of the key at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteRawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeRawRequest = new WriteRawRequest(); // WriteRawRequest | 

            try
            {
                // Update the value of the key at the given path.
                apiInstance.WriteRaw(writeRawRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteRaw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeRawRequest** | [**WriteRawRequest**](WriteRawRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writerawpath"></a>
# **WriteRawPath**
> void WriteRawPath (WriteRawPathRequest writeRawPathRequest, string path, TimeSpan? wrapTTL = null)

Update the value of the key at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteRawPathExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var path = "path_example";  // string | 
            var writeRawPathRequest = new WriteRawPathRequest(); // WriteRawPathRequest | 

            try
            {
                // Update the value of the key at the given path.
                apiInstance.WriteRawPath(path, writeRawPathRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteRawPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **writeRawPathRequest** | [**WriteRawPathRequest**](WriteRawPathRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writerekeyinit"></a>
# **WriteRekeyInit**
> void WriteRekeyInit (WriteRekeyInitRequest writeRekeyInitRequest, TimeSpan? wrapTTL = null)

Initializes a new rekey attempt.

Only a single rekey attempt can take place at a time, and changing the parameters of a rekey requires canceling and starting a new rekey, which will also provide a new nonce.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteRekeyInitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeRekeyInitRequest = new WriteRekeyInitRequest(); // WriteRekeyInitRequest | 

            try
            {
                // Initializes a new rekey attempt.
                apiInstance.WriteRekeyInit(writeRekeyInitRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteRekeyInit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeRekeyInitRequest** | [**WriteRekeyInitRequest**](WriteRekeyInitRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writerekeyupdate"></a>
# **WriteRekeyUpdate**
> void WriteRekeyUpdate (WriteRekeyUpdateRequest writeRekeyUpdateRequest, TimeSpan? wrapTTL = null)

Enter a single unseal key share to progress the rekey of the Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteRekeyUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeRekeyUpdateRequest = new WriteRekeyUpdateRequest(); // WriteRekeyUpdateRequest | 

            try
            {
                // Enter a single unseal key share to progress the rekey of the Vault.
                apiInstance.WriteRekeyUpdate(writeRekeyUpdateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteRekeyUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeRekeyUpdateRequest** | [**WriteRekeyUpdateRequest**](WriteRekeyUpdateRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writerekeyverify"></a>
# **WriteRekeyVerify**
> void WriteRekeyVerify (WriteRekeyVerifyRequest writeRekeyVerifyRequest, TimeSpan? wrapTTL = null)

Enter a single new key share to progress the rekey verification operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteRekeyVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeRekeyVerifyRequest = new WriteRekeyVerifyRequest(); // WriteRekeyVerifyRequest | 

            try
            {
                // Enter a single new key share to progress the rekey verification operation.
                apiInstance.WriteRekeyVerify(writeRekeyVerifyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteRekeyVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeRekeyVerifyRequest** | [**WriteRekeyVerifyRequest**](WriteRekeyVerifyRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="writerotateconfig"></a>
# **WriteRotateConfig**
> void WriteRotateConfig (WriteRotateConfigRequest writeRotateConfigRequest, TimeSpan? wrapTTL = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class WriteRotateConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var writeRotateConfigRequest = new WriteRotateConfigRequest(); // WriteRotateConfigRequest | 

            try
            {
                apiInstance.WriteRotateConfig(writeRotateConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.WriteRotateConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **writeRotateConfigRequest** | [**WriteRotateConfigRequest**](WriteRotateConfigRequest.md)|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

