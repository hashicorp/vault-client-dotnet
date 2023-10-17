# Vault.Api.System

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AuditingCalculateHash**](SystemApi.md#auditingcalculatehash) | **POST** /sys/audit-hash/{path} | 
[**AuditingDisableDevice**](SystemApi.md#auditingdisabledevice) | **DELETE** /sys/audit/{path} | Disable the audit device at the given path.
[**AuditingDisableRequestHeader**](SystemApi.md#auditingdisablerequestheader) | **DELETE** /sys/config/auditing/request-headers/{header} | Disable auditing of the given request header.
[**AuditingEnableDevice**](SystemApi.md#auditingenabledevice) | **POST** /sys/audit/{path} | Enable a new audit device at the supplied path.
[**AuditingEnableRequestHeader**](SystemApi.md#auditingenablerequestheader) | **POST** /sys/config/auditing/request-headers/{header} | Enable auditing of a header.
[**AuditingListEnabledDevices**](SystemApi.md#auditinglistenableddevices) | **GET** /sys/audit | List the enabled audit devices.
[**AuditingListRequestHeaders**](SystemApi.md#auditinglistrequestheaders) | **GET** /sys/config/auditing/request-headers | List the request headers that are configured to be audited.
[**AuditingReadRequestHeaderInformation**](SystemApi.md#auditingreadrequestheaderinformation) | **GET** /sys/config/auditing/request-headers/{header} | List the information for the given request header.
[**AuthDisableMethod**](SystemApi.md#authdisablemethod) | **DELETE** /sys/auth/{path} | Disable the auth method at the given auth path
[**AuthEnableMethod**](SystemApi.md#authenablemethod) | **POST** /sys/auth/{path} | Enables a new auth method.
[**AuthListEnabledMethods**](SystemApi.md#authlistenabledmethods) | **GET** /sys/auth | 
[**AuthReadConfiguration**](SystemApi.md#authreadconfiguration) | **GET** /sys/auth/{path} | Read the configuration of the auth engine at the given path.
[**AuthReadTuningInformation**](SystemApi.md#authreadtuninginformation) | **GET** /sys/auth/{path}/tune | Reads the given auth path&#x27;s configuration.
[**AuthTuneConfigurationParameters**](SystemApi.md#authtuneconfigurationparameters) | **POST** /sys/auth/{path}/tune | Tune configuration parameters for a given auth path.
[**CollectHostInformation**](SystemApi.md#collecthostinformation) | **GET** /sys/host-info | Information about the host instance that this Vault server is running on.
[**CollectInFlightRequestInformation**](SystemApi.md#collectinflightrequestinformation) | **GET** /sys/in-flight-req | reports in-flight requests
[**CorsConfigure**](SystemApi.md#corsconfigure) | **POST** /sys/config/cors | Configure the CORS settings.
[**CorsDeleteConfiguration**](SystemApi.md#corsdeleteconfiguration) | **DELETE** /sys/config/cors | Remove any CORS settings.
[**CorsReadConfiguration**](SystemApi.md#corsreadconfiguration) | **GET** /sys/config/cors | Return the current CORS settings.
[**Decode**](SystemApi.md#decode) | **POST** /sys/decode-token | Decodes the encoded token with the otp.
[**EncryptionKeyConfigureRotation**](SystemApi.md#encryptionkeyconfigurerotation) | **POST** /sys/rotate/config | 
[**EncryptionKeyReadRotationConfiguration**](SystemApi.md#encryptionkeyreadrotationconfiguration) | **GET** /sys/rotate/config | 
[**EncryptionKeyRotate**](SystemApi.md#encryptionkeyrotate) | **POST** /sys/rotate | 
[**EncryptionKeyStatus**](SystemApi.md#encryptionkeystatus) | **GET** /sys/key-status | Provides information about the backend encryption key.
[**GenerateHash**](SystemApi.md#generatehash) | **POST** /sys/tools/hash | 
[**GenerateHashWithAlgorithm**](SystemApi.md#generatehashwithalgorithm) | **POST** /sys/tools/hash/{urlalgorithm} | 
[**GenerateRandom**](SystemApi.md#generaterandom) | **POST** /sys/tools/random | 
[**GenerateRandomWithBytes**](SystemApi.md#generaterandomwithbytes) | **POST** /sys/tools/random/{urlbytes} | 
[**GenerateRandomWithSource**](SystemApi.md#generaterandomwithsource) | **POST** /sys/tools/random/{source} | 
[**GenerateRandomWithSourceAndBytes**](SystemApi.md#generaterandomwithsourceandbytes) | **POST** /sys/tools/random/{source}/{urlbytes} | 
[**HaStatus**](SystemApi.md#hastatus) | **GET** /sys/ha-status | Check the HA status of a Vault cluster
[**Initialize**](SystemApi.md#initialize) | **POST** /sys/init | Initialize a new Vault.
[**InternalClientActivityConfigure**](SystemApi.md#internalclientactivityconfigure) | **POST** /sys/internal/counters/config | Enable or disable collection of client count, set retention period, or set default reporting period.
[**InternalClientActivityExport**](SystemApi.md#internalclientactivityexport) | **GET** /sys/internal/counters/activity/export | Report the client count metrics, for this namespace and all child namespaces.
[**InternalClientActivityReadConfiguration**](SystemApi.md#internalclientactivityreadconfiguration) | **GET** /sys/internal/counters/config | Read the client count tracking configuration.
[**InternalClientActivityReportCounts**](SystemApi.md#internalclientactivityreportcounts) | **GET** /sys/internal/counters/activity | Report the client count metrics, for this namespace and all child namespaces.
[**InternalClientActivityReportCountsThisMonth**](SystemApi.md#internalclientactivityreportcountsthismonth) | **GET** /sys/internal/counters/activity/monthly | Report the number of clients for this month, for this namespace and all child namespaces.
[**InternalCountEntities**](SystemApi.md#internalcountentities) | **GET** /sys/internal/counters/entities | Backwards compatibility is not guaranteed for this API
[**InternalCountRequests**](SystemApi.md#internalcountrequests) | **GET** /sys/internal/counters/requests | Backwards compatibility is not guaranteed for this API
[**InternalCountTokens**](SystemApi.md#internalcounttokens) | **GET** /sys/internal/counters/tokens | Backwards compatibility is not guaranteed for this API
[**InternalGenerateOpenApiDocument**](SystemApi.md#internalgenerateopenapidocument) | **GET** /sys/internal/specs/openapi | 
[**InternalGenerateOpenApiDocumentWithParameters**](SystemApi.md#internalgenerateopenapidocumentwithparameters) | **POST** /sys/internal/specs/openapi | 
[**InternalInspectRouter**](SystemApi.md#internalinspectrouter) | **GET** /sys/internal/inspect/router/{tag} | Expose the route entry and mount entry tables present in the router
[**InternalUiListEnabledFeatureFlags**](SystemApi.md#internaluilistenabledfeatureflags) | **GET** /sys/internal/ui/feature-flags | Lists enabled feature flags.
[**InternalUiListEnabledVisibleMounts**](SystemApi.md#internaluilistenabledvisiblemounts) | **GET** /sys/internal/ui/mounts | Lists all enabled and visible auth and secrets mounts.
[**InternalUiListNamespaces**](SystemApi.md#internaluilistnamespaces) | **GET** /sys/internal/ui/namespaces | Backwards compatibility is not guaranteed for this API
[**InternalUiReadMountInformation**](SystemApi.md#internaluireadmountinformation) | **GET** /sys/internal/ui/mounts/{path} | Return information about the given mount.
[**InternalUiReadResultantAcl**](SystemApi.md#internaluireadresultantacl) | **GET** /sys/internal/ui/resultant-acl | Backwards compatibility is not guaranteed for this API
[**LeaderStatus**](SystemApi.md#leaderstatus) | **GET** /sys/leader | Returns the high availability status and current leader instance of Vault.
[**LeasesCount**](SystemApi.md#leasescount) | **GET** /sys/leases/count | 
[**LeasesForceRevokeLeaseWithPrefix**](SystemApi.md#leasesforcerevokeleasewithprefix) | **POST** /sys/leases/revoke-force/{prefix} | Revokes all secrets or tokens generated under a given prefix immediately
[**LeasesList**](SystemApi.md#leaseslist) | **GET** /sys/leases | 
[**LeasesLookUp**](SystemApi.md#leaseslookup) | **GET** /sys/leases/lookup/{prefix}/ | 
[**LeasesReadLease**](SystemApi.md#leasesreadlease) | **POST** /sys/leases/lookup | 
[**LeasesRenewLease**](SystemApi.md#leasesrenewlease) | **POST** /sys/leases/renew | Renews a lease, requesting to extend the lease.
[**LeasesRenewLeaseWithId**](SystemApi.md#leasesrenewleasewithid) | **POST** /sys/leases/renew/{url_lease_id} | Renews a lease, requesting to extend the lease.
[**LeasesRevokeLease**](SystemApi.md#leasesrevokelease) | **POST** /sys/leases/revoke | Revokes a lease immediately.
[**LeasesRevokeLeaseWithId**](SystemApi.md#leasesrevokeleasewithid) | **POST** /sys/leases/revoke/{url_lease_id} | Revokes a lease immediately.
[**LeasesRevokeLeaseWithPrefix**](SystemApi.md#leasesrevokeleasewithprefix) | **POST** /sys/leases/revoke-prefix/{prefix} | Revokes all secrets (via a lease ID prefix) or tokens (via the tokens&#x27; path property) generated under a given prefix immediately.
[**LeasesTidy**](SystemApi.md#leasestidy) | **POST** /sys/leases/tidy | 
[**ListExperimentalFeatures**](SystemApi.md#listexperimentalfeatures) | **GET** /sys/experiments | Returns the available and enabled experiments
[**LockedUsersList**](SystemApi.md#lockeduserslist) | **GET** /sys/locked-users | Report the locked user count metrics, for this namespace and all child namespaces.
[**LockedUsersUnlock**](SystemApi.md#lockedusersunlock) | **POST** /sys/locked-users/{mount_accessor}/unlock/{alias_identifier} | Unlocks the user with given mount_accessor and alias_identifier
[**LoggersReadVerbosityLevel**](SystemApi.md#loggersreadverbositylevel) | **GET** /sys/loggers | Read the log level for all existing loggers.
[**LoggersReadVerbosityLevelFor**](SystemApi.md#loggersreadverbositylevelfor) | **GET** /sys/loggers/{name} | Read the log level for a single logger.
[**LoggersRevertVerbosityLevel**](SystemApi.md#loggersrevertverbositylevel) | **DELETE** /sys/loggers | Revert the all loggers to use log level provided in config.
[**LoggersRevertVerbosityLevelFor**](SystemApi.md#loggersrevertverbositylevelfor) | **DELETE** /sys/loggers/{name} | Revert a single logger to use log level provided in config.
[**LoggersUpdateVerbosityLevel**](SystemApi.md#loggersupdateverbositylevel) | **POST** /sys/loggers | Modify the log level for all existing loggers.
[**LoggersUpdateVerbosityLevelFor**](SystemApi.md#loggersupdateverbositylevelfor) | **POST** /sys/loggers/{name} | Modify the log level of a single logger.
[**Metrics**](SystemApi.md#metrics) | **GET** /sys/metrics | 
[**MfaValidate**](SystemApi.md#mfavalidate) | **POST** /sys/mfa/validate | Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token
[**Monitor**](SystemApi.md#monitor) | **GET** /sys/monitor | 
[**MountsDisableSecretsEngine**](SystemApi.md#mountsdisablesecretsengine) | **DELETE** /sys/mounts/{path} | Disable the mount point specified at the given path.
[**MountsEnableSecretsEngine**](SystemApi.md#mountsenablesecretsengine) | **POST** /sys/mounts/{path} | Enable a new secrets engine at the given path.
[**MountsListSecretsEngines**](SystemApi.md#mountslistsecretsengines) | **GET** /sys/mounts | 
[**MountsReadConfiguration**](SystemApi.md#mountsreadconfiguration) | **GET** /sys/mounts/{path} | Read the configuration of the secret engine at the given path.
[**MountsReadTuningInformation**](SystemApi.md#mountsreadtuninginformation) | **GET** /sys/mounts/{path}/tune | 
[**MountsTuneConfigurationParameters**](SystemApi.md#mountstuneconfigurationparameters) | **POST** /sys/mounts/{path}/tune | 
[**PluginsCatalogListPlugins**](SystemApi.md#pluginscataloglistplugins) | **GET** /sys/plugins/catalog | 
[**PluginsCatalogListPluginsWithType**](SystemApi.md#pluginscataloglistpluginswithtype) | **GET** /sys/plugins/catalog/{type}/ | List the plugins in the catalog.
[**PluginsCatalogReadPluginConfiguration**](SystemApi.md#pluginscatalogreadpluginconfiguration) | **GET** /sys/plugins/catalog/{name} | Return the configuration data for the plugin with the given name.
[**PluginsCatalogReadPluginConfigurationWithType**](SystemApi.md#pluginscatalogreadpluginconfigurationwithtype) | **GET** /sys/plugins/catalog/{type}/{name} | Return the configuration data for the plugin with the given name.
[**PluginsCatalogRegisterPlugin**](SystemApi.md#pluginscatalogregisterplugin) | **POST** /sys/plugins/catalog/{name} | Register a new plugin, or updates an existing one with the supplied name.
[**PluginsCatalogRegisterPluginWithType**](SystemApi.md#pluginscatalogregisterpluginwithtype) | **POST** /sys/plugins/catalog/{type}/{name} | Register a new plugin, or updates an existing one with the supplied name.
[**PluginsCatalogRemovePlugin**](SystemApi.md#pluginscatalogremoveplugin) | **DELETE** /sys/plugins/catalog/{name} | Remove the plugin with the given name.
[**PluginsCatalogRemovePluginWithType**](SystemApi.md#pluginscatalogremovepluginwithtype) | **DELETE** /sys/plugins/catalog/{type}/{name} | Remove the plugin with the given name.
[**PluginsReloadBackends**](SystemApi.md#pluginsreloadbackends) | **POST** /sys/plugins/reload/backend | Reload mounted plugin backends.
[**PluginsRuntimesCatalogListPluginsRuntimes**](SystemApi.md#pluginsruntimescataloglistpluginsruntimes) | **GET** /sys/plugins/runtimes/catalog/ | 
[**PluginsRuntimesCatalogReadPluginRuntimeConfiguration**](SystemApi.md#pluginsruntimescatalogreadpluginruntimeconfiguration) | **GET** /sys/plugins/runtimes/catalog/{type}/{name} | Return the configuration data for the plugin runtime with the given name.
[**PluginsRuntimesCatalogRegisterPluginRuntime**](SystemApi.md#pluginsruntimescatalogregisterpluginruntime) | **POST** /sys/plugins/runtimes/catalog/{type}/{name} | Register a new plugin runtime, or updates an existing one with the supplied name.
[**PluginsRuntimesCatalogRemovePluginRuntime**](SystemApi.md#pluginsruntimescatalogremovepluginruntime) | **DELETE** /sys/plugins/runtimes/catalog/{type}/{name} | Remove the plugin runtime with the given name.
[**PoliciesDeleteAclPolicy**](SystemApi.md#policiesdeleteaclpolicy) | **DELETE** /sys/policies/acl/{name} | Delete the ACL policy with the given name.
[**PoliciesDeletePasswordPolicy**](SystemApi.md#policiesdeletepasswordpolicy) | **DELETE** /sys/policies/password/{name} | Delete a password policy.
[**PoliciesGeneratePasswordFromPasswordPolicy**](SystemApi.md#policiesgeneratepasswordfrompasswordpolicy) | **GET** /sys/policies/password/{name}/generate | Generate a password from an existing password policy.
[**PoliciesListAclPolicies**](SystemApi.md#policieslistaclpolicies) | **GET** /sys/policies/acl/ | 
[**PoliciesListPasswordPolicies**](SystemApi.md#policieslistpasswordpolicies) | **GET** /sys/policies/password/ | List the existing password policies.
[**PoliciesReadAclPolicy**](SystemApi.md#policiesreadaclpolicy) | **GET** /sys/policies/acl/{name} | Retrieve information about the named ACL policy.
[**PoliciesReadPasswordPolicy**](SystemApi.md#policiesreadpasswordpolicy) | **GET** /sys/policies/password/{name} | Retrieve an existing password policy.
[**PoliciesWriteAclPolicy**](SystemApi.md#policieswriteaclpolicy) | **POST** /sys/policies/acl/{name} | Add a new or update an existing ACL policy.
[**PoliciesWritePasswordPolicy**](SystemApi.md#policieswritepasswordpolicy) | **POST** /sys/policies/password/{name} | Add a new or update an existing password policy.
[**PprofBlocking**](SystemApi.md#pprofblocking) | **GET** /sys/pprof/block | Returns stack traces that led to blocking on synchronization primitives
[**PprofCommandLine**](SystemApi.md#pprofcommandline) | **GET** /sys/pprof/cmdline | Returns the running program&#x27;s command line.
[**PprofCpuProfile**](SystemApi.md#pprofcpuprofile) | **GET** /sys/pprof/profile | Returns a pprof-formatted cpu profile payload.
[**PprofExecutionTrace**](SystemApi.md#pprofexecutiontrace) | **GET** /sys/pprof/trace | Returns the execution trace in binary form.
[**PprofGoroutines**](SystemApi.md#pprofgoroutines) | **GET** /sys/pprof/goroutine | Returns stack traces of all current goroutines.
[**PprofIndex**](SystemApi.md#pprofindex) | **GET** /sys/pprof | Returns an HTML page listing the available profiles.
[**PprofMemoryAllocations**](SystemApi.md#pprofmemoryallocations) | **GET** /sys/pprof/allocs | Returns a sampling of all past memory allocations.
[**PprofMemoryAllocationsLive**](SystemApi.md#pprofmemoryallocationslive) | **GET** /sys/pprof/heap | Returns a sampling of memory allocations of live object.
[**PprofMutexes**](SystemApi.md#pprofmutexes) | **GET** /sys/pprof/mutex | Returns stack traces of holders of contended mutexes
[**PprofSymbols**](SystemApi.md#pprofsymbols) | **GET** /sys/pprof/symbol | Returns the program counters listed in the request.
[**PprofThreadCreations**](SystemApi.md#pprofthreadcreations) | **GET** /sys/pprof/threadcreate | Returns stack traces that led to the creation of new OS threads
[**QueryTokenAccessorCapabilities**](SystemApi.md#querytokenaccessorcapabilities) | **POST** /sys/capabilities-accessor | 
[**QueryTokenCapabilities**](SystemApi.md#querytokencapabilities) | **POST** /sys/capabilities | 
[**QueryTokenSelfCapabilities**](SystemApi.md#querytokenselfcapabilities) | **POST** /sys/capabilities-self | 
[**RateLimitQuotasConfigure**](SystemApi.md#ratelimitquotasconfigure) | **POST** /sys/quotas/config | 
[**RateLimitQuotasDelete**](SystemApi.md#ratelimitquotasdelete) | **DELETE** /sys/quotas/rate-limit/{name} | 
[**RateLimitQuotasList**](SystemApi.md#ratelimitquotaslist) | **GET** /sys/quotas/rate-limit/ | 
[**RateLimitQuotasRead**](SystemApi.md#ratelimitquotasread) | **GET** /sys/quotas/rate-limit/{name} | 
[**RateLimitQuotasReadConfiguration**](SystemApi.md#ratelimitquotasreadconfiguration) | **GET** /sys/quotas/config | 
[**RateLimitQuotasWrite**](SystemApi.md#ratelimitquotaswrite) | **POST** /sys/quotas/rate-limit/{name} | 
[**RawDelete**](SystemApi.md#rawdelete) | **DELETE** /sys/raw/{path} | Delete the key with given path.
[**RawList**](SystemApi.md#rawlist) | **GET** /sys/raw/{path}/ | Return a list keys for a given path prefix.
[**RawRead**](SystemApi.md#rawread) | **GET** /sys/raw/{path} | Read the value of the key at the given path.
[**RawWrite**](SystemApi.md#rawwrite) | **POST** /sys/raw/{path} | Update the value of the key at the given path.
[**ReadHealthStatus**](SystemApi.md#readhealthstatus) | **GET** /sys/health | Returns the health status of Vault.
[**ReadInitializationStatus**](SystemApi.md#readinitializationstatus) | **GET** /sys/init | Returns the initialization status of Vault.
[**ReadReplicationStatus**](SystemApi.md#readreplicationstatus) | **GET** /sys/replication/status | 
[**ReadSanitizedConfigurationState**](SystemApi.md#readsanitizedconfigurationstate) | **GET** /sys/config/state/sanitized | Return a sanitized version of the Vault server configuration.
[**ReadWrappingProperties**](SystemApi.md#readwrappingproperties) | **POST** /sys/wrapping/lookup | Look up wrapping properties for the given token.
[**RekeyAttemptCancel**](SystemApi.md#rekeyattemptcancel) | **DELETE** /sys/rekey/init | Cancels any in-progress rekey.
[**RekeyAttemptInitialize**](SystemApi.md#rekeyattemptinitialize) | **POST** /sys/rekey/init | Initializes a new rekey attempt.
[**RekeyAttemptReadProgress**](SystemApi.md#rekeyattemptreadprogress) | **GET** /sys/rekey/init | Reads the configuration and progress of the current rekey attempt.
[**RekeyAttemptUpdate**](SystemApi.md#rekeyattemptupdate) | **POST** /sys/rekey/update | Enter a single unseal key share to progress the rekey of the Vault.
[**RekeyDeleteBackupKey**](SystemApi.md#rekeydeletebackupkey) | **DELETE** /sys/rekey/backup | Delete the backup copy of PGP-encrypted unseal keys.
[**RekeyDeleteBackupRecoveryKey**](SystemApi.md#rekeydeletebackuprecoverykey) | **DELETE** /sys/rekey/recovery-key-backup | 
[**RekeyReadBackupKey**](SystemApi.md#rekeyreadbackupkey) | **GET** /sys/rekey/backup | Return the backup copy of PGP-encrypted unseal keys.
[**RekeyReadBackupRecoveryKey**](SystemApi.md#rekeyreadbackuprecoverykey) | **GET** /sys/rekey/recovery-key-backup | 
[**RekeyVerificationCancel**](SystemApi.md#rekeyverificationcancel) | **DELETE** /sys/rekey/verify | Cancel any in-progress rekey verification operation.
[**RekeyVerificationReadProgress**](SystemApi.md#rekeyverificationreadprogress) | **GET** /sys/rekey/verify | Read the configuration and progress of the current rekey verification attempt.
[**RekeyVerificationUpdate**](SystemApi.md#rekeyverificationupdate) | **POST** /sys/rekey/verify | Enter a single new key share to progress the rekey verification operation.
[**ReloadSubsystem**](SystemApi.md#reloadsubsystem) | **POST** /sys/config/reload/{subsystem} | Reload the given subsystem
[**Remount**](SystemApi.md#remount) | **POST** /sys/remount | Initiate a mount migration
[**RemountStatus**](SystemApi.md#remountstatus) | **GET** /sys/remount/status/{migration_id} | Check status of a mount migration
[**Rewrap**](SystemApi.md#rewrap) | **POST** /sys/wrapping/rewrap | 
[**RootTokenGenerationCancel**](SystemApi.md#roottokengenerationcancel) | **DELETE** /sys/generate-root/attempt | Cancels any in-progress root generation attempt.
[**RootTokenGenerationInitialize**](SystemApi.md#roottokengenerationinitialize) | **POST** /sys/generate-root/attempt | Initializes a new root generation attempt.
[**RootTokenGenerationReadProgress**](SystemApi.md#roottokengenerationreadprogress) | **GET** /sys/generate-root/attempt | Read the configuration and progress of the current root generation attempt.
[**RootTokenGenerationUpdate**](SystemApi.md#roottokengenerationupdate) | **POST** /sys/generate-root/update | Enter a single unseal key share to progress the root generation attempt.
[**Seal**](SystemApi.md#seal) | **POST** /sys/seal | Seal the Vault.
[**SealStatus**](SystemApi.md#sealstatus) | **GET** /sys/seal-status | Check the seal status of a Vault.
[**StepDownLeader**](SystemApi.md#stepdownleader) | **POST** /sys/step-down | Cause the node to give up active status.
[**UiHeadersConfigure**](SystemApi.md#uiheadersconfigure) | **POST** /sys/config/ui/headers/{header} | Configure the values to be returned for the UI header.
[**UiHeadersDeleteConfiguration**](SystemApi.md#uiheadersdeleteconfiguration) | **DELETE** /sys/config/ui/headers/{header} | Remove a UI header.
[**UiHeadersList**](SystemApi.md#uiheaderslist) | **GET** /sys/config/ui/headers/ | Return a list of configured UI headers.
[**UiHeadersReadConfiguration**](SystemApi.md#uiheadersreadconfiguration) | **GET** /sys/config/ui/headers/{header} | Return the given UI header&#x27;s configuration
[**Unseal**](SystemApi.md#unseal) | **POST** /sys/unseal | Unseal the Vault.
[**Unwrap**](SystemApi.md#unwrap) | **POST** /sys/wrapping/unwrap | 
[**VersionHistory**](SystemApi.md#versionhistory) | **GET** /sys/version-history/ | Returns map of historical version change entries
[**Wrap**](SystemApi.md#wrap) | **POST** /sys/wrapping/wrap | 

<a name="auditingcalculatehash"></a>
# **AuditingCalculateHash**

> AuditingCalculateHashResponse AuditingCalculateHash (string path, AuditingCalculateHashRequest auditingCalculateHashRequest, TimeSpan? wrapTTL = null)



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
    public class AuditingCalculateHashExample
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
            
            
            
            
            
            var auditingCalculateHashRequest = new AuditingCalculateHashRequest(); // AuditingCalculateHashRequest | 
            
            

            try
            {
                

                AuditingCalculateHashResponse result = apiInstance.AuditingCalculateHash(string path, AuditingCalculateHashRequest auditingCalculateHashRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuditingCalculateHash: " + e.Message );
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
 **auditingCalculateHashRequest** | [**AuditingCalculateHashRequest**](AuditingCalculateHashRequest.md)|  | 


### Return type

[**AuditingCalculateHashResponse**](AuditingCalculateHashResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="auditingdisabledevice"></a>
# **AuditingDisableDevice**

> void AuditingDisableDevice (string path, TimeSpan? wrapTTL = null)

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
    public class AuditingDisableDeviceExample
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
                

                apiInstance.AuditingDisableDevice(string path, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuditingDisableDevice: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="auditingdisablerequestheader"></a>
# **AuditingDisableRequestHeader**

> void AuditingDisableRequestHeader (string header, TimeSpan? wrapTTL = null)

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
    public class AuditingDisableRequestHeaderExample
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
                

                apiInstance.AuditingDisableRequestHeader(string header, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuditingDisableRequestHeader: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="auditingenabledevice"></a>
# **AuditingEnableDevice**

> void AuditingEnableDevice (string path, AuditingEnableDeviceRequest auditingEnableDeviceRequest, TimeSpan? wrapTTL = null)

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
    public class AuditingEnableDeviceExample
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
            
            
            
            
            
            var auditingEnableDeviceRequest = new AuditingEnableDeviceRequest(); // AuditingEnableDeviceRequest | 
            
            

            try
            {
                
                // Enable a new audit device at the supplied path.
                

                apiInstance.AuditingEnableDevice(string path, AuditingEnableDeviceRequest auditingEnableDeviceRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuditingEnableDevice: " + e.Message );
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
 **auditingEnableDeviceRequest** | [**AuditingEnableDeviceRequest**](AuditingEnableDeviceRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="auditingenablerequestheader"></a>
# **AuditingEnableRequestHeader**

> void AuditingEnableRequestHeader (string header, AuditingEnableRequestHeaderRequest auditingEnableRequestHeaderRequest, TimeSpan? wrapTTL = null)

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
    public class AuditingEnableRequestHeaderExample
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
            
            
            
            
            
            var auditingEnableRequestHeaderRequest = new AuditingEnableRequestHeaderRequest(); // AuditingEnableRequestHeaderRequest | 
            
            

            try
            {
                
                // Enable auditing of a header.
                

                apiInstance.AuditingEnableRequestHeader(string header, AuditingEnableRequestHeaderRequest auditingEnableRequestHeaderRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuditingEnableRequestHeader: " + e.Message );
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
 **auditingEnableRequestHeaderRequest** | [**AuditingEnableRequestHeaderRequest**](AuditingEnableRequestHeaderRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="auditinglistenableddevices"></a>
# **AuditingListEnabledDevices**

> void AuditingListEnabledDevices (TimeSpan? wrapTTL = null)

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
    public class AuditingListEnabledDevicesExample
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
                

                apiInstance.AuditingListEnabledDevices(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuditingListEnabledDevices: " + e.Message );
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

<a name="auditinglistrequestheaders"></a>
# **AuditingListRequestHeaders**

> AuditingListRequestHeadersResponse AuditingListRequestHeaders (TimeSpan? wrapTTL = null)

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
    public class AuditingListRequestHeadersExample
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
                

                AuditingListRequestHeadersResponse result = apiInstance.AuditingListRequestHeaders(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuditingListRequestHeaders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**AuditingListRequestHeadersResponse**](AuditingListRequestHeadersResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="auditingreadrequestheaderinformation"></a>
# **AuditingReadRequestHeaderInformation**

> void AuditingReadRequestHeaderInformation (string header, TimeSpan? wrapTTL = null)

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
    public class AuditingReadRequestHeaderInformationExample
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
                

                apiInstance.AuditingReadRequestHeaderInformation(string header, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuditingReadRequestHeaderInformation: " + e.Message );
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

<a name="authdisablemethod"></a>
# **AuthDisableMethod**

> void AuthDisableMethod (string path, TimeSpan? wrapTTL = null)

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
    public class AuthDisableMethodExample
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
                

                apiInstance.AuthDisableMethod(string path, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuthDisableMethod: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authenablemethod"></a>
# **AuthEnableMethod**

> void AuthEnableMethod (string path, AuthEnableMethodRequest authEnableMethodRequest, TimeSpan? wrapTTL = null)

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
    public class AuthEnableMethodExample
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
            
            
            
            
            
            var authEnableMethodRequest = new AuthEnableMethodRequest(); // AuthEnableMethodRequest | 
            
            

            try
            {
                
                // Enables a new auth method.
                

                apiInstance.AuthEnableMethod(string path, AuthEnableMethodRequest authEnableMethodRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuthEnableMethod: " + e.Message );
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
 **authEnableMethodRequest** | [**AuthEnableMethodRequest**](AuthEnableMethodRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authlistenabledmethods"></a>
# **AuthListEnabledMethods**

> void AuthListEnabledMethods (TimeSpan? wrapTTL = null)



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
    public class AuthListEnabledMethodsExample
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
                

                apiInstance.AuthListEnabledMethods(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuthListEnabledMethods: " + e.Message );
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

<a name="authreadconfiguration"></a>
# **AuthReadConfiguration**

> AuthReadConfigurationResponse AuthReadConfiguration (string path, TimeSpan? wrapTTL = null)

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
    public class AuthReadConfigurationExample
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
                

                AuthReadConfigurationResponse result = apiInstance.AuthReadConfiguration(string path, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuthReadConfiguration: " + e.Message );
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

[**AuthReadConfigurationResponse**](AuthReadConfigurationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authreadtuninginformation"></a>
# **AuthReadTuningInformation**

> AuthReadTuningInformationResponse AuthReadTuningInformation (string path, TimeSpan? wrapTTL = null)

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
    public class AuthReadTuningInformationExample
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
                

                AuthReadTuningInformationResponse result = apiInstance.AuthReadTuningInformation(string path, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuthReadTuningInformation: " + e.Message );
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

[**AuthReadTuningInformationResponse**](AuthReadTuningInformationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="authtuneconfigurationparameters"></a>
# **AuthTuneConfigurationParameters**

> void AuthTuneConfigurationParameters (string path, AuthTuneConfigurationParametersRequest authTuneConfigurationParametersRequest, TimeSpan? wrapTTL = null)

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
    public class AuthTuneConfigurationParametersExample
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
            
            
            
            
            
            var authTuneConfigurationParametersRequest = new AuthTuneConfigurationParametersRequest(); // AuthTuneConfigurationParametersRequest | 
            
            

            try
            {
                
                // Tune configuration parameters for a given auth path.
                

                apiInstance.AuthTuneConfigurationParameters(string path, AuthTuneConfigurationParametersRequest authTuneConfigurationParametersRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.AuthTuneConfigurationParameters: " + e.Message );
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
 **authTuneConfigurationParametersRequest** | [**AuthTuneConfigurationParametersRequest**](AuthTuneConfigurationParametersRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collecthostinformation"></a>
# **CollectHostInformation**

> CollectHostInformationResponse CollectHostInformation (TimeSpan? wrapTTL = null)

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
    public class CollectHostInformationExample
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
                

                CollectHostInformationResponse result = apiInstance.CollectHostInformation(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.CollectHostInformation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**CollectHostInformationResponse**](CollectHostInformationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="collectinflightrequestinformation"></a>
# **CollectInFlightRequestInformation**

> void CollectInFlightRequestInformation (TimeSpan? wrapTTL = null)

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
    public class CollectInFlightRequestInformationExample
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
                

                apiInstance.CollectInFlightRequestInformation(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.CollectInFlightRequestInformation: " + e.Message );
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

<a name="corsconfigure"></a>
# **CorsConfigure**

> void CorsConfigure (CorsConfigureRequest corsConfigureRequest, TimeSpan? wrapTTL = null)

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
    public class CorsConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var corsConfigureRequest = new CorsConfigureRequest(); // CorsConfigureRequest | 
            
            

            try
            {
                
                // Configure the CORS settings.
                

                apiInstance.CorsConfigure(CorsConfigureRequest corsConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.CorsConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **corsConfigureRequest** | [**CorsConfigureRequest**](CorsConfigureRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corsdeleteconfiguration"></a>
# **CorsDeleteConfiguration**

> void CorsDeleteConfiguration (TimeSpan? wrapTTL = null)

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
    public class CorsDeleteConfigurationExample
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
                

                apiInstance.CorsDeleteConfiguration(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.CorsDeleteConfiguration: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="corsreadconfiguration"></a>
# **CorsReadConfiguration**

> CorsReadConfigurationResponse CorsReadConfiguration (TimeSpan? wrapTTL = null)

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
    public class CorsReadConfigurationExample
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
                

                CorsReadConfigurationResponse result = apiInstance.CorsReadConfiguration(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.CorsReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**CorsReadConfigurationResponse**](CorsReadConfigurationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="decode"></a>
# **Decode**

> void Decode (DecodeRequest decodeRequest, TimeSpan? wrapTTL = null)

Decodes the encoded token with the otp.

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
    public class DecodeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var decodeRequest = new DecodeRequest(); // DecodeRequest | 
            
            

            try
            {
                
                // Decodes the encoded token with the otp.
                

                apiInstance.Decode(DecodeRequest decodeRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Decode: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **decodeRequest** | [**DecodeRequest**](DecodeRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="encryptionkeyconfigurerotation"></a>
# **EncryptionKeyConfigureRotation**

> void EncryptionKeyConfigureRotation (EncryptionKeyConfigureRotationRequest encryptionKeyConfigureRotationRequest, TimeSpan? wrapTTL = null)



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
    public class EncryptionKeyConfigureRotationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var encryptionKeyConfigureRotationRequest = new EncryptionKeyConfigureRotationRequest(); // EncryptionKeyConfigureRotationRequest | 
            
            

            try
            {
                

                apiInstance.EncryptionKeyConfigureRotation(EncryptionKeyConfigureRotationRequest encryptionKeyConfigureRotationRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.EncryptionKeyConfigureRotation: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **encryptionKeyConfigureRotationRequest** | [**EncryptionKeyConfigureRotationRequest**](EncryptionKeyConfigureRotationRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="encryptionkeyreadrotationconfiguration"></a>
# **EncryptionKeyReadRotationConfiguration**

> EncryptionKeyReadRotationConfigurationResponse EncryptionKeyReadRotationConfiguration (TimeSpan? wrapTTL = null)



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
    public class EncryptionKeyReadRotationConfigurationExample
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
                

                EncryptionKeyReadRotationConfigurationResponse result = apiInstance.EncryptionKeyReadRotationConfiguration(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.EncryptionKeyReadRotationConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**EncryptionKeyReadRotationConfigurationResponse**](EncryptionKeyReadRotationConfigurationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="encryptionkeyrotate"></a>
# **EncryptionKeyRotate**

> void EncryptionKeyRotate (TimeSpan? wrapTTL = null)



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
    public class EncryptionKeyRotateExample
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
                

                apiInstance.EncryptionKeyRotate(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.EncryptionKeyRotate: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="encryptionkeystatus"></a>
# **EncryptionKeyStatus**

> void EncryptionKeyStatus (TimeSpan? wrapTTL = null)

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
    public class EncryptionKeyStatusExample
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
                

                apiInstance.EncryptionKeyStatus(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.EncryptionKeyStatus: " + e.Message );
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

<a name="generatehash"></a>
# **GenerateHash**

> GenerateHashResponse GenerateHash (GenerateHashRequest generateHashRequest, TimeSpan? wrapTTL = null)



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
    public class GenerateHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var generateHashRequest = new GenerateHashRequest(); // GenerateHashRequest | 
            
            

            try
            {
                

                GenerateHashResponse result = apiInstance.GenerateHash(GenerateHashRequest generateHashRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GenerateHash: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateHashRequest** | [**GenerateHashRequest**](GenerateHashRequest.md)|  | 


### Return type

[**GenerateHashResponse**](GenerateHashResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generatehashwithalgorithm"></a>
# **GenerateHashWithAlgorithm**

> GenerateHashWithAlgorithmResponse GenerateHashWithAlgorithm (string urlalgorithm, GenerateHashWithAlgorithmRequest generateHashWithAlgorithmRequest, TimeSpan? wrapTTL = null)



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
    public class GenerateHashWithAlgorithmExample
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
            
            
            
            
            
            var generateHashWithAlgorithmRequest = new GenerateHashWithAlgorithmRequest(); // GenerateHashWithAlgorithmRequest | 
            
            

            try
            {
                

                GenerateHashWithAlgorithmResponse result = apiInstance.GenerateHashWithAlgorithm(string urlalgorithm, GenerateHashWithAlgorithmRequest generateHashWithAlgorithmRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GenerateHashWithAlgorithm: " + e.Message );
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
 **generateHashWithAlgorithmRequest** | [**GenerateHashWithAlgorithmRequest**](GenerateHashWithAlgorithmRequest.md)|  | 


### Return type

[**GenerateHashWithAlgorithmResponse**](GenerateHashWithAlgorithmResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generaterandom"></a>
# **GenerateRandom**

> GenerateRandomResponse GenerateRandom (GenerateRandomRequest generateRandomRequest, TimeSpan? wrapTTL = null)



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
    public class GenerateRandomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var generateRandomRequest = new GenerateRandomRequest(); // GenerateRandomRequest | 
            
            

            try
            {
                

                GenerateRandomResponse result = apiInstance.GenerateRandom(GenerateRandomRequest generateRandomRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GenerateRandom: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generateRandomRequest** | [**GenerateRandomRequest**](GenerateRandomRequest.md)|  | 


### Return type

[**GenerateRandomResponse**](GenerateRandomResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generaterandomwithbytes"></a>
# **GenerateRandomWithBytes**

> GenerateRandomWithBytesResponse GenerateRandomWithBytes (string urlbytes, GenerateRandomWithBytesRequest generateRandomWithBytesRequest, TimeSpan? wrapTTL = null)



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
    public class GenerateRandomWithBytesExample
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
            
            
            
            
            
            var generateRandomWithBytesRequest = new GenerateRandomWithBytesRequest(); // GenerateRandomWithBytesRequest | 
            
            

            try
            {
                

                GenerateRandomWithBytesResponse result = apiInstance.GenerateRandomWithBytes(string urlbytes, GenerateRandomWithBytesRequest generateRandomWithBytesRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GenerateRandomWithBytes: " + e.Message );
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
 **generateRandomWithBytesRequest** | [**GenerateRandomWithBytesRequest**](GenerateRandomWithBytesRequest.md)|  | 


### Return type

[**GenerateRandomWithBytesResponse**](GenerateRandomWithBytesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generaterandomwithsource"></a>
# **GenerateRandomWithSource**

> GenerateRandomWithSourceResponse GenerateRandomWithSource (string source, GenerateRandomWithSourceRequest generateRandomWithSourceRequest, TimeSpan? wrapTTL = null)



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
    public class GenerateRandomWithSourceExample
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
            
            
            
            
            
            var generateRandomWithSourceRequest = new GenerateRandomWithSourceRequest(); // GenerateRandomWithSourceRequest | 
            
            

            try
            {
                

                GenerateRandomWithSourceResponse result = apiInstance.GenerateRandomWithSource(string source, GenerateRandomWithSourceRequest generateRandomWithSourceRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GenerateRandomWithSource: " + e.Message );
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
 **generateRandomWithSourceRequest** | [**GenerateRandomWithSourceRequest**](GenerateRandomWithSourceRequest.md)|  | 


### Return type

[**GenerateRandomWithSourceResponse**](GenerateRandomWithSourceResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="generaterandomwithsourceandbytes"></a>
# **GenerateRandomWithSourceAndBytes**

> GenerateRandomWithSourceAndBytesResponse GenerateRandomWithSourceAndBytes (string source, string urlbytes, GenerateRandomWithSourceAndBytesRequest generateRandomWithSourceAndBytesRequest, TimeSpan? wrapTTL = null)



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
    public class GenerateRandomWithSourceAndBytesExample
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
            
            
            
            
            
            var generateRandomWithSourceAndBytesRequest = new GenerateRandomWithSourceAndBytesRequest(); // GenerateRandomWithSourceAndBytesRequest | 
            
            

            try
            {
                

                GenerateRandomWithSourceAndBytesResponse result = apiInstance.GenerateRandomWithSourceAndBytes(string source, string urlbytes, GenerateRandomWithSourceAndBytesRequest generateRandomWithSourceAndBytesRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GenerateRandomWithSourceAndBytes: " + e.Message );
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
 **generateRandomWithSourceAndBytesRequest** | [**GenerateRandomWithSourceAndBytesRequest**](GenerateRandomWithSourceAndBytesRequest.md)|  | 


### Return type

[**GenerateRandomWithSourceAndBytesResponse**](GenerateRandomWithSourceAndBytesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="hastatus"></a>
# **HaStatus**

> HaStatusResponse HaStatus (TimeSpan? wrapTTL = null)

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
    public class HaStatusExample
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
                

                HaStatusResponse result = apiInstance.HaStatus(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.HaStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**HaStatusResponse**](HaStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="initialize"></a>
# **Initialize**

> void Initialize (InitializeRequest initializeRequest, TimeSpan? wrapTTL = null)

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
    public class InitializeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var initializeRequest = new InitializeRequest(); // InitializeRequest | 
            
            

            try
            {
                
                // Initialize a new Vault.
                

                apiInstance.Initialize(InitializeRequest initializeRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Initialize: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **initializeRequest** | [**InitializeRequest**](InitializeRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="internalclientactivityconfigure"></a>
# **InternalClientActivityConfigure**

> void InternalClientActivityConfigure (InternalClientActivityConfigureRequest internalClientActivityConfigureRequest, TimeSpan? wrapTTL = null)

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
    public class InternalClientActivityConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var internalClientActivityConfigureRequest = new InternalClientActivityConfigureRequest(); // InternalClientActivityConfigureRequest | 
            
            

            try
            {
                
                // Enable or disable collection of client count, set retention period, or set default reporting period.
                

                apiInstance.InternalClientActivityConfigure(InternalClientActivityConfigureRequest internalClientActivityConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalClientActivityConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **internalClientActivityConfigureRequest** | [**InternalClientActivityConfigureRequest**](InternalClientActivityConfigureRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="internalclientactivityexport"></a>
# **InternalClientActivityExport**

> void InternalClientActivityExport (TimeSpan? wrapTTL = null)

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
    public class InternalClientActivityExportExample
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
                

                apiInstance.InternalClientActivityExport(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalClientActivityExport: " + e.Message );
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

<a name="internalclientactivityreadconfiguration"></a>
# **InternalClientActivityReadConfiguration**

> void InternalClientActivityReadConfiguration (TimeSpan? wrapTTL = null)

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
    public class InternalClientActivityReadConfigurationExample
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
                

                apiInstance.InternalClientActivityReadConfiguration(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalClientActivityReadConfiguration: " + e.Message );
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

<a name="internalclientactivityreportcounts"></a>
# **InternalClientActivityReportCounts**

> void InternalClientActivityReportCounts (TimeSpan? wrapTTL = null)

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
    public class InternalClientActivityReportCountsExample
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
                

                apiInstance.InternalClientActivityReportCounts(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalClientActivityReportCounts: " + e.Message );
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

<a name="internalclientactivityreportcountsthismonth"></a>
# **InternalClientActivityReportCountsThisMonth**

> void InternalClientActivityReportCountsThisMonth (TimeSpan? wrapTTL = null)

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
    public class InternalClientActivityReportCountsThisMonthExample
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
                

                apiInstance.InternalClientActivityReportCountsThisMonth(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalClientActivityReportCountsThisMonth: " + e.Message );
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

<a name="internalcountentities"></a>
# **InternalCountEntities**

> InternalCountEntitiesResponse InternalCountEntities (TimeSpan? wrapTTL = null)

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
    public class InternalCountEntitiesExample
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
                

                InternalCountEntitiesResponse result = apiInstance.InternalCountEntities(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalCountEntities: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**InternalCountEntitiesResponse**](InternalCountEntitiesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="internalcountrequests"></a>
# **InternalCountRequests**

> void InternalCountRequests (TimeSpan? wrapTTL = null)

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
    public class InternalCountRequestsExample
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
                

                apiInstance.InternalCountRequests(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalCountRequests: " + e.Message );
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

<a name="internalcounttokens"></a>
# **InternalCountTokens**

> InternalCountTokensResponse InternalCountTokens (TimeSpan? wrapTTL = null)

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
    public class InternalCountTokensExample
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
                

                InternalCountTokensResponse result = apiInstance.InternalCountTokens(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalCountTokens: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**InternalCountTokensResponse**](InternalCountTokensResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="internalgenerateopenapidocument"></a>
# **InternalGenerateOpenApiDocument**

> void InternalGenerateOpenApiDocument (string context = default(string), bool? genericMountPaths = default(bool?), TimeSpan? wrapTTL = null)



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
    public class InternalGenerateOpenApiDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            var context = "context_example";  // string | Context string appended to every operationId (optional) 
            
            
            
            
            var genericMountPaths = false;  // bool? | Use generic mount paths (optional)  (default to false)
            
            
            

            try
            {
                

                apiInstance.InternalGenerateOpenApiDocument(string context = default(string), bool? genericMountPaths = default(bool?), TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalGenerateOpenApiDocument: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **context** | **string**| Context string appended to every operationId | [optional] 
 **genericMountPaths** | **bool?**| Use generic mount paths | [optional] [default to false]


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

<a name="internalgenerateopenapidocumentwithparameters"></a>
# **InternalGenerateOpenApiDocumentWithParameters**

> void InternalGenerateOpenApiDocumentWithParameters (InternalGenerateOpenApiDocumentWithParametersRequest internalGenerateOpenApiDocumentWithParametersRequest, TimeSpan? wrapTTL = null)



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
    public class InternalGenerateOpenApiDocumentWithParametersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var internalGenerateOpenApiDocumentWithParametersRequest = new InternalGenerateOpenApiDocumentWithParametersRequest(); // InternalGenerateOpenApiDocumentWithParametersRequest | 
            
            

            try
            {
                

                apiInstance.InternalGenerateOpenApiDocumentWithParameters(InternalGenerateOpenApiDocumentWithParametersRequest internalGenerateOpenApiDocumentWithParametersRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalGenerateOpenApiDocumentWithParameters: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **internalGenerateOpenApiDocumentWithParametersRequest** | [**InternalGenerateOpenApiDocumentWithParametersRequest**](InternalGenerateOpenApiDocumentWithParametersRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="internalinspectrouter"></a>
# **InternalInspectRouter**

> void InternalInspectRouter (string tag, TimeSpan? wrapTTL = null)

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
    public class InternalInspectRouterExample
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
                

                apiInstance.InternalInspectRouter(string tag, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalInspectRouter: " + e.Message );
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

<a name="internaluilistenabledfeatureflags"></a>
# **InternalUiListEnabledFeatureFlags**

> InternalUiListEnabledFeatureFlagsResponse InternalUiListEnabledFeatureFlags (TimeSpan? wrapTTL = null)

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
    public class InternalUiListEnabledFeatureFlagsExample
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
                

                InternalUiListEnabledFeatureFlagsResponse result = apiInstance.InternalUiListEnabledFeatureFlags(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalUiListEnabledFeatureFlags: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**InternalUiListEnabledFeatureFlagsResponse**](InternalUiListEnabledFeatureFlagsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="internaluilistenabledvisiblemounts"></a>
# **InternalUiListEnabledVisibleMounts**

> InternalUiListEnabledVisibleMountsResponse InternalUiListEnabledVisibleMounts (TimeSpan? wrapTTL = null)

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
    public class InternalUiListEnabledVisibleMountsExample
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
                

                InternalUiListEnabledVisibleMountsResponse result = apiInstance.InternalUiListEnabledVisibleMounts(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalUiListEnabledVisibleMounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**InternalUiListEnabledVisibleMountsResponse**](InternalUiListEnabledVisibleMountsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="internaluilistnamespaces"></a>
# **InternalUiListNamespaces**

> InternalUiListNamespacesResponse InternalUiListNamespaces (TimeSpan? wrapTTL = null)

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
    public class InternalUiListNamespacesExample
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
                

                InternalUiListNamespacesResponse result = apiInstance.InternalUiListNamespaces(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalUiListNamespaces: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**InternalUiListNamespacesResponse**](InternalUiListNamespacesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="internaluireadmountinformation"></a>
# **InternalUiReadMountInformation**

> InternalUiReadMountInformationResponse InternalUiReadMountInformation (string path, TimeSpan? wrapTTL = null)

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
    public class InternalUiReadMountInformationExample
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
                

                InternalUiReadMountInformationResponse result = apiInstance.InternalUiReadMountInformation(string path, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalUiReadMountInformation: " + e.Message );
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

[**InternalUiReadMountInformationResponse**](InternalUiReadMountInformationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="internaluireadresultantacl"></a>
# **InternalUiReadResultantAcl**

> InternalUiReadResultantAclResponse InternalUiReadResultantAcl (TimeSpan? wrapTTL = null)

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
    public class InternalUiReadResultantAclExample
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
                

                InternalUiReadResultantAclResponse result = apiInstance.InternalUiReadResultantAcl(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.InternalUiReadResultantAcl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**InternalUiReadResultantAclResponse**](InternalUiReadResultantAclResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |

| **204** | empty response returned if no client token |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leaderstatus"></a>
# **LeaderStatus**

> LeaderStatusResponse LeaderStatus (TimeSpan? wrapTTL = null)

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
    public class LeaderStatusExample
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
                

                LeaderStatusResponse result = apiInstance.LeaderStatus(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LeaderStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**LeaderStatusResponse**](LeaderStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leasescount"></a>
# **LeasesCount**

> LeasesCountResponse LeasesCount (TimeSpan? wrapTTL = null)



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
    public class LeasesCountExample
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
                

                LeasesCountResponse result = apiInstance.LeasesCount(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LeasesCount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**LeasesCountResponse**](LeasesCountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leasesforcerevokeleasewithprefix"></a>
# **LeasesForceRevokeLeaseWithPrefix**

> void LeasesForceRevokeLeaseWithPrefix (string prefix, TimeSpan? wrapTTL = null)

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
    public class LeasesForceRevokeLeaseWithPrefixExample
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
                

                apiInstance.LeasesForceRevokeLeaseWithPrefix(string prefix, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LeasesForceRevokeLeaseWithPrefix: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leaseslist"></a>
# **LeasesList**

> LeasesListResponse LeasesList (TimeSpan? wrapTTL = null)



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
    public class LeasesListExample
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
                

                LeasesListResponse result = apiInstance.LeasesList(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LeasesList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**LeasesListResponse**](LeasesListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leaseslookup"></a>
# **LeasesLookUp**

> LeasesLookUpResponse LeasesLookUp (string prefix, TimeSpan? wrapTTL = null)



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
    public class LeasesLookUpExample
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
                

                LeasesLookUpResponse result = apiInstance.LeasesLookUp(string prefix, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LeasesLookUp: " + e.Message );
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

[**LeasesLookUpResponse**](LeasesLookUpResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leasesreadlease"></a>
# **LeasesReadLease**

> LeasesReadLeaseResponse LeasesReadLease (LeasesReadLeaseRequest leasesReadLeaseRequest, TimeSpan? wrapTTL = null)



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
    public class LeasesReadLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var leasesReadLeaseRequest = new LeasesReadLeaseRequest(); // LeasesReadLeaseRequest | 
            
            

            try
            {
                

                LeasesReadLeaseResponse result = apiInstance.LeasesReadLease(LeasesReadLeaseRequest leasesReadLeaseRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LeasesReadLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **leasesReadLeaseRequest** | [**LeasesReadLeaseRequest**](LeasesReadLeaseRequest.md)|  | 


### Return type

[**LeasesReadLeaseResponse**](LeasesReadLeaseResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leasesrenewlease"></a>
# **LeasesRenewLease**

> void LeasesRenewLease (LeasesRenewLeaseRequest leasesRenewLeaseRequest, TimeSpan? wrapTTL = null)

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
    public class LeasesRenewLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var leasesRenewLeaseRequest = new LeasesRenewLeaseRequest(); // LeasesRenewLeaseRequest | 
            
            

            try
            {
                
                // Renews a lease, requesting to extend the lease.
                

                apiInstance.LeasesRenewLease(LeasesRenewLeaseRequest leasesRenewLeaseRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LeasesRenewLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **leasesRenewLeaseRequest** | [**LeasesRenewLeaseRequest**](LeasesRenewLeaseRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leasesrenewleasewithid"></a>
# **LeasesRenewLeaseWithId**

> void LeasesRenewLeaseWithId (string urlLeaseId, LeasesRenewLeaseWithIdRequest leasesRenewLeaseWithIdRequest, TimeSpan? wrapTTL = null)

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
    public class LeasesRenewLeaseWithIdExample
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
            
            
            
            
            
            var leasesRenewLeaseWithIdRequest = new LeasesRenewLeaseWithIdRequest(); // LeasesRenewLeaseWithIdRequest | 
            
            

            try
            {
                
                // Renews a lease, requesting to extend the lease.
                

                apiInstance.LeasesRenewLeaseWithId(string urlLeaseId, LeasesRenewLeaseWithIdRequest leasesRenewLeaseWithIdRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LeasesRenewLeaseWithId: " + e.Message );
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
 **leasesRenewLeaseWithIdRequest** | [**LeasesRenewLeaseWithIdRequest**](LeasesRenewLeaseWithIdRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leasesrevokelease"></a>
# **LeasesRevokeLease**

> void LeasesRevokeLease (LeasesRevokeLeaseRequest leasesRevokeLeaseRequest, TimeSpan? wrapTTL = null)

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
    public class LeasesRevokeLeaseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var leasesRevokeLeaseRequest = new LeasesRevokeLeaseRequest(); // LeasesRevokeLeaseRequest | 
            
            

            try
            {
                
                // Revokes a lease immediately.
                

                apiInstance.LeasesRevokeLease(LeasesRevokeLeaseRequest leasesRevokeLeaseRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LeasesRevokeLease: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **leasesRevokeLeaseRequest** | [**LeasesRevokeLeaseRequest**](LeasesRevokeLeaseRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leasesrevokeleasewithid"></a>
# **LeasesRevokeLeaseWithId**

> void LeasesRevokeLeaseWithId (string urlLeaseId, LeasesRevokeLeaseWithIdRequest leasesRevokeLeaseWithIdRequest, TimeSpan? wrapTTL = null)

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
    public class LeasesRevokeLeaseWithIdExample
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
            
            
            
            
            
            var leasesRevokeLeaseWithIdRequest = new LeasesRevokeLeaseWithIdRequest(); // LeasesRevokeLeaseWithIdRequest | 
            
            

            try
            {
                
                // Revokes a lease immediately.
                

                apiInstance.LeasesRevokeLeaseWithId(string urlLeaseId, LeasesRevokeLeaseWithIdRequest leasesRevokeLeaseWithIdRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LeasesRevokeLeaseWithId: " + e.Message );
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
 **leasesRevokeLeaseWithIdRequest** | [**LeasesRevokeLeaseWithIdRequest**](LeasesRevokeLeaseWithIdRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leasesrevokeleasewithprefix"></a>
# **LeasesRevokeLeaseWithPrefix**

> void LeasesRevokeLeaseWithPrefix (string prefix, LeasesRevokeLeaseWithPrefixRequest leasesRevokeLeaseWithPrefixRequest, TimeSpan? wrapTTL = null)

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
    public class LeasesRevokeLeaseWithPrefixExample
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
            
            
            
            
            
            var leasesRevokeLeaseWithPrefixRequest = new LeasesRevokeLeaseWithPrefixRequest(); // LeasesRevokeLeaseWithPrefixRequest | 
            
            

            try
            {
                
                // Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.
                

                apiInstance.LeasesRevokeLeaseWithPrefix(string prefix, LeasesRevokeLeaseWithPrefixRequest leasesRevokeLeaseWithPrefixRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LeasesRevokeLeaseWithPrefix: " + e.Message );
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
 **leasesRevokeLeaseWithPrefixRequest** | [**LeasesRevokeLeaseWithPrefixRequest**](LeasesRevokeLeaseWithPrefixRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="leasestidy"></a>
# **LeasesTidy**

> void LeasesTidy (TimeSpan? wrapTTL = null)



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
    public class LeasesTidyExample
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
                

                apiInstance.LeasesTidy(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LeasesTidy: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listexperimentalfeatures"></a>
# **ListExperimentalFeatures**

> void ListExperimentalFeatures (TimeSpan? wrapTTL = null)

Returns the available and enabled experiments

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
    public class ListExperimentalFeaturesExample
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
                
                // Returns the available and enabled experiments
                

                apiInstance.ListExperimentalFeatures(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListExperimentalFeatures: " + e.Message );
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

<a name="lockeduserslist"></a>
# **LockedUsersList**

> void LockedUsersList (TimeSpan? wrapTTL = null)

Report the locked user count metrics, for this namespace and all child namespaces.

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
    public class LockedUsersListExample
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
                
                // Report the locked user count metrics, for this namespace and all child namespaces.
                

                apiInstance.LockedUsersList(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LockedUsersList: " + e.Message );
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

<a name="lockedusersunlock"></a>
# **LockedUsersUnlock**

> void LockedUsersUnlock (string aliasIdentifier, string mountAccessor, TimeSpan? wrapTTL = null)

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
    public class LockedUsersUnlockExample
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
                

                apiInstance.LockedUsersUnlock(string aliasIdentifier, string mountAccessor, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LockedUsersUnlock: " + e.Message );
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

<a name="loggersreadverbositylevel"></a>
# **LoggersReadVerbosityLevel**

> void LoggersReadVerbosityLevel (TimeSpan? wrapTTL = null)

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
    public class LoggersReadVerbosityLevelExample
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
                

                apiInstance.LoggersReadVerbosityLevel(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LoggersReadVerbosityLevel: " + e.Message );
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

<a name="loggersreadverbositylevelfor"></a>
# **LoggersReadVerbosityLevelFor**

> void LoggersReadVerbosityLevelFor (string name, TimeSpan? wrapTTL = null)

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
    public class LoggersReadVerbosityLevelForExample
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
                

                apiInstance.LoggersReadVerbosityLevelFor(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LoggersReadVerbosityLevelFor: " + e.Message );
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

<a name="loggersrevertverbositylevel"></a>
# **LoggersRevertVerbosityLevel**

> void LoggersRevertVerbosityLevel (TimeSpan? wrapTTL = null)

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
    public class LoggersRevertVerbosityLevelExample
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
                

                apiInstance.LoggersRevertVerbosityLevel(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LoggersRevertVerbosityLevel: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loggersrevertverbositylevelfor"></a>
# **LoggersRevertVerbosityLevelFor**

> void LoggersRevertVerbosityLevelFor (string name, TimeSpan? wrapTTL = null)

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
    public class LoggersRevertVerbosityLevelForExample
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
                

                apiInstance.LoggersRevertVerbosityLevelFor(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LoggersRevertVerbosityLevelFor: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loggersupdateverbositylevel"></a>
# **LoggersUpdateVerbosityLevel**

> void LoggersUpdateVerbosityLevel (LoggersUpdateVerbosityLevelRequest loggersUpdateVerbosityLevelRequest, TimeSpan? wrapTTL = null)

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
    public class LoggersUpdateVerbosityLevelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var loggersUpdateVerbosityLevelRequest = new LoggersUpdateVerbosityLevelRequest(); // LoggersUpdateVerbosityLevelRequest | 
            
            

            try
            {
                
                // Modify the log level for all existing loggers.
                

                apiInstance.LoggersUpdateVerbosityLevel(LoggersUpdateVerbosityLevelRequest loggersUpdateVerbosityLevelRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LoggersUpdateVerbosityLevel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **loggersUpdateVerbosityLevelRequest** | [**LoggersUpdateVerbosityLevelRequest**](LoggersUpdateVerbosityLevelRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="loggersupdateverbositylevelfor"></a>
# **LoggersUpdateVerbosityLevelFor**

> void LoggersUpdateVerbosityLevelFor (string name, LoggersUpdateVerbosityLevelForRequest loggersUpdateVerbosityLevelForRequest, TimeSpan? wrapTTL = null)

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
    public class LoggersUpdateVerbosityLevelForExample
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
            
            
            
            
            
            var loggersUpdateVerbosityLevelForRequest = new LoggersUpdateVerbosityLevelForRequest(); // LoggersUpdateVerbosityLevelForRequest | 
            
            

            try
            {
                
                // Modify the log level of a single logger.
                

                apiInstance.LoggersUpdateVerbosityLevelFor(string name, LoggersUpdateVerbosityLevelForRequest loggersUpdateVerbosityLevelForRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.LoggersUpdateVerbosityLevelFor: " + e.Message );
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
 **loggersUpdateVerbosityLevelForRequest** | [**LoggersUpdateVerbosityLevelForRequest**](LoggersUpdateVerbosityLevelForRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="metrics"></a>
# **Metrics**

> void Metrics (string format = default(string), TimeSpan? wrapTTL = null)



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
    public class MetricsExample
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
                

                apiInstance.Metrics(string format = default(string), TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Metrics: " + e.Message );
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

<a name="mfavalidate"></a>
# **MfaValidate**

> void MfaValidate (MfaValidateRequest mfaValidateRequest, TimeSpan? wrapTTL = null)

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
    public class MfaValidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var mfaValidateRequest = new MfaValidateRequest(); // MfaValidateRequest | 
            
            

            try
            {
                
                // Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token
                

                apiInstance.MfaValidate(MfaValidateRequest mfaValidateRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.MfaValidate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **mfaValidateRequest** | [**MfaValidateRequest**](MfaValidateRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
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
                

                apiInstance.Monitor(string logFormat = default(string), string logLevel = default(string), TimeSpan? wrapTTL = null);
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

<a name="mountsdisablesecretsengine"></a>
# **MountsDisableSecretsEngine**

> void MountsDisableSecretsEngine (string path, TimeSpan? wrapTTL = null)

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
    public class MountsDisableSecretsEngineExample
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
                

                apiInstance.MountsDisableSecretsEngine(string path, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.MountsDisableSecretsEngine: " + e.Message );
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

<a name="mountsenablesecretsengine"></a>
# **MountsEnableSecretsEngine**

> void MountsEnableSecretsEngine (string path, MountsEnableSecretsEngineRequest mountsEnableSecretsEngineRequest, TimeSpan? wrapTTL = null)

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
    public class MountsEnableSecretsEngineExample
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
            
            
            
            
            
            var mountsEnableSecretsEngineRequest = new MountsEnableSecretsEngineRequest(); // MountsEnableSecretsEngineRequest | 
            
            

            try
            {
                
                // Enable a new secrets engine at the given path.
                

                apiInstance.MountsEnableSecretsEngine(string path, MountsEnableSecretsEngineRequest mountsEnableSecretsEngineRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.MountsEnableSecretsEngine: " + e.Message );
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
 **mountsEnableSecretsEngineRequest** | [**MountsEnableSecretsEngineRequest**](MountsEnableSecretsEngineRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mountslistsecretsengines"></a>
# **MountsListSecretsEngines**

> void MountsListSecretsEngines (TimeSpan? wrapTTL = null)



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
    public class MountsListSecretsEnginesExample
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
                

                apiInstance.MountsListSecretsEngines(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.MountsListSecretsEngines: " + e.Message );
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

<a name="mountsreadconfiguration"></a>
# **MountsReadConfiguration**

> MountsReadConfigurationResponse MountsReadConfiguration (string path, TimeSpan? wrapTTL = null)

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
    public class MountsReadConfigurationExample
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
                

                MountsReadConfigurationResponse result = apiInstance.MountsReadConfiguration(string path, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.MountsReadConfiguration: " + e.Message );
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

[**MountsReadConfigurationResponse**](MountsReadConfigurationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mountsreadtuninginformation"></a>
# **MountsReadTuningInformation**

> MountsReadTuningInformationResponse MountsReadTuningInformation (string path, TimeSpan? wrapTTL = null)



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
    public class MountsReadTuningInformationExample
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
                

                MountsReadTuningInformationResponse result = apiInstance.MountsReadTuningInformation(string path, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.MountsReadTuningInformation: " + e.Message );
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

[**MountsReadTuningInformationResponse**](MountsReadTuningInformationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="mountstuneconfigurationparameters"></a>
# **MountsTuneConfigurationParameters**

> void MountsTuneConfigurationParameters (string path, MountsTuneConfigurationParametersRequest mountsTuneConfigurationParametersRequest, TimeSpan? wrapTTL = null)



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
    public class MountsTuneConfigurationParametersExample
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
            
            
            
            
            
            var mountsTuneConfigurationParametersRequest = new MountsTuneConfigurationParametersRequest(); // MountsTuneConfigurationParametersRequest | 
            
            

            try
            {
                

                apiInstance.MountsTuneConfigurationParameters(string path, MountsTuneConfigurationParametersRequest mountsTuneConfigurationParametersRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.MountsTuneConfigurationParameters: " + e.Message );
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
 **mountsTuneConfigurationParametersRequest** | [**MountsTuneConfigurationParametersRequest**](MountsTuneConfigurationParametersRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginscataloglistplugins"></a>
# **PluginsCatalogListPlugins**

> PluginsCatalogListPluginsResponse PluginsCatalogListPlugins (TimeSpan? wrapTTL = null)



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
    public class PluginsCatalogListPluginsExample
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
                

                PluginsCatalogListPluginsResponse result = apiInstance.PluginsCatalogListPlugins(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsCatalogListPlugins: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**PluginsCatalogListPluginsResponse**](PluginsCatalogListPluginsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginscataloglistpluginswithtype"></a>
# **PluginsCatalogListPluginsWithType**

> PluginsCatalogListPluginsWithTypeResponse PluginsCatalogListPluginsWithType (string type, TimeSpan? wrapTTL = null)

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
    public class PluginsCatalogListPluginsWithTypeExample
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
                

                PluginsCatalogListPluginsWithTypeResponse result = apiInstance.PluginsCatalogListPluginsWithType(string type, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsCatalogListPluginsWithType: " + e.Message );
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

[**PluginsCatalogListPluginsWithTypeResponse**](PluginsCatalogListPluginsWithTypeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginscatalogreadpluginconfiguration"></a>
# **PluginsCatalogReadPluginConfiguration**

> PluginsCatalogReadPluginConfigurationResponse PluginsCatalogReadPluginConfiguration (string name, TimeSpan? wrapTTL = null)

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
    public class PluginsCatalogReadPluginConfigurationExample
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
                

                PluginsCatalogReadPluginConfigurationResponse result = apiInstance.PluginsCatalogReadPluginConfiguration(string name, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsCatalogReadPluginConfiguration: " + e.Message );
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

[**PluginsCatalogReadPluginConfigurationResponse**](PluginsCatalogReadPluginConfigurationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginscatalogreadpluginconfigurationwithtype"></a>
# **PluginsCatalogReadPluginConfigurationWithType**

> PluginsCatalogReadPluginConfigurationWithTypeResponse PluginsCatalogReadPluginConfigurationWithType (string name, string type, TimeSpan? wrapTTL = null)

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
    public class PluginsCatalogReadPluginConfigurationWithTypeExample
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
                

                PluginsCatalogReadPluginConfigurationWithTypeResponse result = apiInstance.PluginsCatalogReadPluginConfigurationWithType(string name, string type, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsCatalogReadPluginConfigurationWithType: " + e.Message );
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

[**PluginsCatalogReadPluginConfigurationWithTypeResponse**](PluginsCatalogReadPluginConfigurationWithTypeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginscatalogregisterplugin"></a>
# **PluginsCatalogRegisterPlugin**

> void PluginsCatalogRegisterPlugin (string name, PluginsCatalogRegisterPluginRequest pluginsCatalogRegisterPluginRequest, TimeSpan? wrapTTL = null)

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
    public class PluginsCatalogRegisterPluginExample
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
            
            
            
            
            
            var pluginsCatalogRegisterPluginRequest = new PluginsCatalogRegisterPluginRequest(); // PluginsCatalogRegisterPluginRequest | 
            
            

            try
            {
                
                // Register a new plugin, or updates an existing one with the supplied name.
                

                apiInstance.PluginsCatalogRegisterPlugin(string name, PluginsCatalogRegisterPluginRequest pluginsCatalogRegisterPluginRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsCatalogRegisterPlugin: " + e.Message );
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
 **pluginsCatalogRegisterPluginRequest** | [**PluginsCatalogRegisterPluginRequest**](PluginsCatalogRegisterPluginRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginscatalogregisterpluginwithtype"></a>
# **PluginsCatalogRegisterPluginWithType**

> void PluginsCatalogRegisterPluginWithType (string name, string type, PluginsCatalogRegisterPluginWithTypeRequest pluginsCatalogRegisterPluginWithTypeRequest, TimeSpan? wrapTTL = null)

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
    public class PluginsCatalogRegisterPluginWithTypeExample
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
            
            
            
            
            
            var pluginsCatalogRegisterPluginWithTypeRequest = new PluginsCatalogRegisterPluginWithTypeRequest(); // PluginsCatalogRegisterPluginWithTypeRequest | 
            
            

            try
            {
                
                // Register a new plugin, or updates an existing one with the supplied name.
                

                apiInstance.PluginsCatalogRegisterPluginWithType(string name, string type, PluginsCatalogRegisterPluginWithTypeRequest pluginsCatalogRegisterPluginWithTypeRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsCatalogRegisterPluginWithType: " + e.Message );
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
 **pluginsCatalogRegisterPluginWithTypeRequest** | [**PluginsCatalogRegisterPluginWithTypeRequest**](PluginsCatalogRegisterPluginWithTypeRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginscatalogremoveplugin"></a>
# **PluginsCatalogRemovePlugin**

> void PluginsCatalogRemovePlugin (string name, TimeSpan? wrapTTL = null)

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
    public class PluginsCatalogRemovePluginExample
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
                

                apiInstance.PluginsCatalogRemovePlugin(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsCatalogRemovePlugin: " + e.Message );
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

<a name="pluginscatalogremovepluginwithtype"></a>
# **PluginsCatalogRemovePluginWithType**

> void PluginsCatalogRemovePluginWithType (string name, string type, TimeSpan? wrapTTL = null)

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
    public class PluginsCatalogRemovePluginWithTypeExample
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
                

                apiInstance.PluginsCatalogRemovePluginWithType(string name, string type, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsCatalogRemovePluginWithType: " + e.Message );
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

<a name="pluginsreloadbackends"></a>
# **PluginsReloadBackends**

> PluginsReloadBackendsResponse PluginsReloadBackends (PluginsReloadBackendsRequest pluginsReloadBackendsRequest, TimeSpan? wrapTTL = null)

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
    public class PluginsReloadBackendsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var pluginsReloadBackendsRequest = new PluginsReloadBackendsRequest(); // PluginsReloadBackendsRequest | 
            
            

            try
            {
                
                // Reload mounted plugin backends.
                

                PluginsReloadBackendsResponse result = apiInstance.PluginsReloadBackends(PluginsReloadBackendsRequest pluginsReloadBackendsRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsReloadBackends: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pluginsReloadBackendsRequest** | [**PluginsReloadBackendsRequest**](PluginsReloadBackendsRequest.md)|  | 


### Return type

[**PluginsReloadBackendsResponse**](PluginsReloadBackendsResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |

| **202** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginsruntimescataloglistpluginsruntimes"></a>
# **PluginsRuntimesCatalogListPluginsRuntimes**

> PluginsRuntimesCatalogListPluginsRuntimesResponse PluginsRuntimesCatalogListPluginsRuntimes (TimeSpan? wrapTTL = null)



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
    public class PluginsRuntimesCatalogListPluginsRuntimesExample
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
                

                PluginsRuntimesCatalogListPluginsRuntimesResponse result = apiInstance.PluginsRuntimesCatalogListPluginsRuntimes(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsRuntimesCatalogListPluginsRuntimes: " + e.Message );
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

[**PluginsRuntimesCatalogListPluginsRuntimesResponse**](PluginsRuntimesCatalogListPluginsRuntimesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginsruntimescatalogreadpluginruntimeconfiguration"></a>
# **PluginsRuntimesCatalogReadPluginRuntimeConfiguration**

> PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse PluginsRuntimesCatalogReadPluginRuntimeConfiguration (string name, string type, TimeSpan? wrapTTL = null)

Return the configuration data for the plugin runtime with the given name.

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
    public class PluginsRuntimesCatalogReadPluginRuntimeConfigurationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The name of the plugin runtime
            
            
            
            
            var type = "type_example";  // string | The type of the plugin runtime
            
            
            

            try
            {
                
                // Return the configuration data for the plugin runtime with the given name.
                

                PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse result = apiInstance.PluginsRuntimesCatalogReadPluginRuntimeConfiguration(string name, string type, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsRuntimesCatalogReadPluginRuntimeConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the plugin runtime | 
 **type** | **string**| The type of the plugin runtime | 


### Return type

[**PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse**](PluginsRuntimesCatalogReadPluginRuntimeConfigurationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginsruntimescatalogregisterpluginruntime"></a>
# **PluginsRuntimesCatalogRegisterPluginRuntime**

> void PluginsRuntimesCatalogRegisterPluginRuntime (string name, string type, PluginsRuntimesCatalogRegisterPluginRuntimeRequest pluginsRuntimesCatalogRegisterPluginRuntimeRequest, TimeSpan? wrapTTL = null)

Register a new plugin runtime, or updates an existing one with the supplied name.

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
    public class PluginsRuntimesCatalogRegisterPluginRuntimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The name of the plugin runtime
            
            
            
            
            var type = "type_example";  // string | The type of the plugin runtime
            
            
            
            
            
            var pluginsRuntimesCatalogRegisterPluginRuntimeRequest = new PluginsRuntimesCatalogRegisterPluginRuntimeRequest(); // PluginsRuntimesCatalogRegisterPluginRuntimeRequest | 
            
            

            try
            {
                
                // Register a new plugin runtime, or updates an existing one with the supplied name.
                

                apiInstance.PluginsRuntimesCatalogRegisterPluginRuntime(string name, string type, PluginsRuntimesCatalogRegisterPluginRuntimeRequest pluginsRuntimesCatalogRegisterPluginRuntimeRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsRuntimesCatalogRegisterPluginRuntime: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the plugin runtime | 
 **type** | **string**| The type of the plugin runtime | 
 **pluginsRuntimesCatalogRegisterPluginRuntimeRequest** | [**PluginsRuntimesCatalogRegisterPluginRuntimeRequest**](PluginsRuntimesCatalogRegisterPluginRuntimeRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pluginsruntimescatalogremovepluginruntime"></a>
# **PluginsRuntimesCatalogRemovePluginRuntime**

> void PluginsRuntimesCatalogRemovePluginRuntime (string name, string type, TimeSpan? wrapTTL = null)

Remove the plugin runtime with the given name.

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
    public class PluginsRuntimesCatalogRemovePluginRuntimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            var name = "name_example";  // string | The name of the plugin runtime
            
            
            
            
            var type = "type_example";  // string | The type of the plugin runtime
            
            
            

            try
            {
                
                // Remove the plugin runtime with the given name.
                

                apiInstance.PluginsRuntimesCatalogRemovePluginRuntime(string name, string type, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PluginsRuntimesCatalogRemovePluginRuntime: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the plugin runtime | 
 **type** | **string**| The type of the plugin runtime | 


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

<a name="policiesdeleteaclpolicy"></a>
# **PoliciesDeleteAclPolicy**

> void PoliciesDeleteAclPolicy (string name, TimeSpan? wrapTTL = null)

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
    public class PoliciesDeleteAclPolicyExample
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
                

                apiInstance.PoliciesDeleteAclPolicy(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PoliciesDeleteAclPolicy: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="policiesdeletepasswordpolicy"></a>
# **PoliciesDeletePasswordPolicy**

> void PoliciesDeletePasswordPolicy (string name, TimeSpan? wrapTTL = null)

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
    public class PoliciesDeletePasswordPolicyExample
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
                

                apiInstance.PoliciesDeletePasswordPolicy(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PoliciesDeletePasswordPolicy: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="policiesgeneratepasswordfrompasswordpolicy"></a>
# **PoliciesGeneratePasswordFromPasswordPolicy**

> PoliciesGeneratePasswordFromPasswordPolicyResponse PoliciesGeneratePasswordFromPasswordPolicy (string name, TimeSpan? wrapTTL = null)

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
    public class PoliciesGeneratePasswordFromPasswordPolicyExample
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
                

                PoliciesGeneratePasswordFromPasswordPolicyResponse result = apiInstance.PoliciesGeneratePasswordFromPasswordPolicy(string name, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PoliciesGeneratePasswordFromPasswordPolicy: " + e.Message );
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

[**PoliciesGeneratePasswordFromPasswordPolicyResponse**](PoliciesGeneratePasswordFromPasswordPolicyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="policieslistaclpolicies"></a>
# **PoliciesListAclPolicies**

> PoliciesListAclPoliciesResponse PoliciesListAclPolicies (TimeSpan? wrapTTL = null)



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
    public class PoliciesListAclPoliciesExample
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
                

                PoliciesListAclPoliciesResponse result = apiInstance.PoliciesListAclPolicies(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PoliciesListAclPolicies: " + e.Message );
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

[**PoliciesListAclPoliciesResponse**](PoliciesListAclPoliciesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="policieslistpasswordpolicies"></a>
# **PoliciesListPasswordPolicies**

> StandardListResponse PoliciesListPasswordPolicies (TimeSpan? wrapTTL = null)

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
    public class PoliciesListPasswordPoliciesExample
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
                

                StandardListResponse result = apiInstance.PoliciesListPasswordPolicies(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PoliciesListPasswordPolicies: " + e.Message );
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

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="policiesreadaclpolicy"></a>
# **PoliciesReadAclPolicy**

> PoliciesReadAclPolicyResponse PoliciesReadAclPolicy (string name, TimeSpan? wrapTTL = null)

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
    public class PoliciesReadAclPolicyExample
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
                

                PoliciesReadAclPolicyResponse result = apiInstance.PoliciesReadAclPolicy(string name, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PoliciesReadAclPolicy: " + e.Message );
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

[**PoliciesReadAclPolicyResponse**](PoliciesReadAclPolicyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="policiesreadpasswordpolicy"></a>
# **PoliciesReadPasswordPolicy**

> PoliciesReadPasswordPolicyResponse PoliciesReadPasswordPolicy (string name, TimeSpan? wrapTTL = null)

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
    public class PoliciesReadPasswordPolicyExample
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
                

                PoliciesReadPasswordPolicyResponse result = apiInstance.PoliciesReadPasswordPolicy(string name, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PoliciesReadPasswordPolicy: " + e.Message );
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

[**PoliciesReadPasswordPolicyResponse**](PoliciesReadPasswordPolicyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="policieswriteaclpolicy"></a>
# **PoliciesWriteAclPolicy**

> void PoliciesWriteAclPolicy (string name, PoliciesWriteAclPolicyRequest policiesWriteAclPolicyRequest, TimeSpan? wrapTTL = null)

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
    public class PoliciesWriteAclPolicyExample
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
            
            
            
            
            
            var policiesWriteAclPolicyRequest = new PoliciesWriteAclPolicyRequest(); // PoliciesWriteAclPolicyRequest | 
            
            

            try
            {
                
                // Add a new or update an existing ACL policy.
                

                apiInstance.PoliciesWriteAclPolicy(string name, PoliciesWriteAclPolicyRequest policiesWriteAclPolicyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PoliciesWriteAclPolicy: " + e.Message );
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
 **policiesWriteAclPolicyRequest** | [**PoliciesWriteAclPolicyRequest**](PoliciesWriteAclPolicyRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="policieswritepasswordpolicy"></a>
# **PoliciesWritePasswordPolicy**

> void PoliciesWritePasswordPolicy (string name, PoliciesWritePasswordPolicyRequest policiesWritePasswordPolicyRequest, TimeSpan? wrapTTL = null)

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
    public class PoliciesWritePasswordPolicyExample
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
            
            
            
            
            
            var policiesWritePasswordPolicyRequest = new PoliciesWritePasswordPolicyRequest(); // PoliciesWritePasswordPolicyRequest | 
            
            

            try
            {
                
                // Add a new or update an existing password policy.
                

                apiInstance.PoliciesWritePasswordPolicy(string name, PoliciesWritePasswordPolicyRequest policiesWritePasswordPolicyRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PoliciesWritePasswordPolicy: " + e.Message );
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
 **policiesWritePasswordPolicyRequest** | [**PoliciesWritePasswordPolicyRequest**](PoliciesWritePasswordPolicyRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="pprofblocking"></a>
# **PprofBlocking**

> void PprofBlocking (TimeSpan? wrapTTL = null)

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
    public class PprofBlockingExample
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
                

                apiInstance.PprofBlocking(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofBlocking: " + e.Message );
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

<a name="pprofcommandline"></a>
# **PprofCommandLine**

> void PprofCommandLine (TimeSpan? wrapTTL = null)

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
    public class PprofCommandLineExample
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
                

                apiInstance.PprofCommandLine(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofCommandLine: " + e.Message );
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

<a name="pprofcpuprofile"></a>
# **PprofCpuProfile**

> void PprofCpuProfile (TimeSpan? wrapTTL = null)

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
    public class PprofCpuProfileExample
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
                

                apiInstance.PprofCpuProfile(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofCpuProfile: " + e.Message );
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

<a name="pprofexecutiontrace"></a>
# **PprofExecutionTrace**

> void PprofExecutionTrace (TimeSpan? wrapTTL = null)

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
    public class PprofExecutionTraceExample
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
                

                apiInstance.PprofExecutionTrace(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofExecutionTrace: " + e.Message );
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

<a name="pprofgoroutines"></a>
# **PprofGoroutines**

> void PprofGoroutines (TimeSpan? wrapTTL = null)

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
    public class PprofGoroutinesExample
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
                

                apiInstance.PprofGoroutines(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofGoroutines: " + e.Message );
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

<a name="pprofindex"></a>
# **PprofIndex**

> void PprofIndex (TimeSpan? wrapTTL = null)

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
    public class PprofIndexExample
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
                

                apiInstance.PprofIndex(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofIndex: " + e.Message );
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

<a name="pprofmemoryallocations"></a>
# **PprofMemoryAllocations**

> void PprofMemoryAllocations (TimeSpan? wrapTTL = null)

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
    public class PprofMemoryAllocationsExample
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
                

                apiInstance.PprofMemoryAllocations(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofMemoryAllocations: " + e.Message );
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

<a name="pprofmemoryallocationslive"></a>
# **PprofMemoryAllocationsLive**

> void PprofMemoryAllocationsLive (TimeSpan? wrapTTL = null)

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
    public class PprofMemoryAllocationsLiveExample
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
                

                apiInstance.PprofMemoryAllocationsLive(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofMemoryAllocationsLive: " + e.Message );
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

<a name="pprofmutexes"></a>
# **PprofMutexes**

> void PprofMutexes (TimeSpan? wrapTTL = null)

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
    public class PprofMutexesExample
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
                

                apiInstance.PprofMutexes(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofMutexes: " + e.Message );
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

<a name="pprofsymbols"></a>
# **PprofSymbols**

> void PprofSymbols (TimeSpan? wrapTTL = null)

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
    public class PprofSymbolsExample
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
                

                apiInstance.PprofSymbols(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofSymbols: " + e.Message );
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

<a name="pprofthreadcreations"></a>
# **PprofThreadCreations**

> void PprofThreadCreations (TimeSpan? wrapTTL = null)

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
    public class PprofThreadCreationsExample
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
                

                apiInstance.PprofThreadCreations(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PprofThreadCreations: " + e.Message );
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

<a name="querytokenaccessorcapabilities"></a>
# **QueryTokenAccessorCapabilities**

> void QueryTokenAccessorCapabilities (QueryTokenAccessorCapabilitiesRequest queryTokenAccessorCapabilitiesRequest, TimeSpan? wrapTTL = null)



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
    public class QueryTokenAccessorCapabilitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var queryTokenAccessorCapabilitiesRequest = new QueryTokenAccessorCapabilitiesRequest(); // QueryTokenAccessorCapabilitiesRequest | 
            
            

            try
            {
                

                apiInstance.QueryTokenAccessorCapabilities(QueryTokenAccessorCapabilitiesRequest queryTokenAccessorCapabilitiesRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.QueryTokenAccessorCapabilities: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryTokenAccessorCapabilitiesRequest** | [**QueryTokenAccessorCapabilitiesRequest**](QueryTokenAccessorCapabilitiesRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querytokencapabilities"></a>
# **QueryTokenCapabilities**

> void QueryTokenCapabilities (QueryTokenCapabilitiesRequest queryTokenCapabilitiesRequest, TimeSpan? wrapTTL = null)



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
    public class QueryTokenCapabilitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var queryTokenCapabilitiesRequest = new QueryTokenCapabilitiesRequest(); // QueryTokenCapabilitiesRequest | 
            
            

            try
            {
                

                apiInstance.QueryTokenCapabilities(QueryTokenCapabilitiesRequest queryTokenCapabilitiesRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.QueryTokenCapabilities: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryTokenCapabilitiesRequest** | [**QueryTokenCapabilitiesRequest**](QueryTokenCapabilitiesRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="querytokenselfcapabilities"></a>
# **QueryTokenSelfCapabilities**

> void QueryTokenSelfCapabilities (QueryTokenSelfCapabilitiesRequest queryTokenSelfCapabilitiesRequest, TimeSpan? wrapTTL = null)



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
    public class QueryTokenSelfCapabilitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var queryTokenSelfCapabilitiesRequest = new QueryTokenSelfCapabilitiesRequest(); // QueryTokenSelfCapabilitiesRequest | 
            
            

            try
            {
                

                apiInstance.QueryTokenSelfCapabilities(QueryTokenSelfCapabilitiesRequest queryTokenSelfCapabilitiesRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.QueryTokenSelfCapabilities: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **queryTokenSelfCapabilitiesRequest** | [**QueryTokenSelfCapabilitiesRequest**](QueryTokenSelfCapabilitiesRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratelimitquotasconfigure"></a>
# **RateLimitQuotasConfigure**

> void RateLimitQuotasConfigure (RateLimitQuotasConfigureRequest rateLimitQuotasConfigureRequest, TimeSpan? wrapTTL = null)



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
    public class RateLimitQuotasConfigureExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var rateLimitQuotasConfigureRequest = new RateLimitQuotasConfigureRequest(); // RateLimitQuotasConfigureRequest | 
            
            

            try
            {
                

                apiInstance.RateLimitQuotasConfigure(RateLimitQuotasConfigureRequest rateLimitQuotasConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RateLimitQuotasConfigure: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rateLimitQuotasConfigureRequest** | [**RateLimitQuotasConfigureRequest**](RateLimitQuotasConfigureRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratelimitquotasdelete"></a>
# **RateLimitQuotasDelete**

> void RateLimitQuotasDelete (string name, TimeSpan? wrapTTL = null)



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
    public class RateLimitQuotasDeleteExample
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
                

                apiInstance.RateLimitQuotasDelete(string name, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RateLimitQuotasDelete: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratelimitquotaslist"></a>
# **RateLimitQuotasList**

> StandardListResponse RateLimitQuotasList (TimeSpan? wrapTTL = null)



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
    public class RateLimitQuotasListExample
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
                

                StandardListResponse result = apiInstance.RateLimitQuotasList(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RateLimitQuotasList: " + e.Message );
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

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratelimitquotasread"></a>
# **RateLimitQuotasRead**

> RateLimitQuotasReadResponse RateLimitQuotasRead (string name, TimeSpan? wrapTTL = null)



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
    public class RateLimitQuotasReadExample
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
                

                RateLimitQuotasReadResponse result = apiInstance.RateLimitQuotasRead(string name, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RateLimitQuotasRead: " + e.Message );
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

[**RateLimitQuotasReadResponse**](RateLimitQuotasReadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratelimitquotasreadconfiguration"></a>
# **RateLimitQuotasReadConfiguration**

> RateLimitQuotasReadConfigurationResponse RateLimitQuotasReadConfiguration (TimeSpan? wrapTTL = null)



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
    public class RateLimitQuotasReadConfigurationExample
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
                

                RateLimitQuotasReadConfigurationResponse result = apiInstance.RateLimitQuotasReadConfiguration(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RateLimitQuotasReadConfiguration: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**RateLimitQuotasReadConfigurationResponse**](RateLimitQuotasReadConfigurationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="ratelimitquotaswrite"></a>
# **RateLimitQuotasWrite**

> void RateLimitQuotasWrite (string name, RateLimitQuotasWriteRequest rateLimitQuotasWriteRequest, TimeSpan? wrapTTL = null)



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
    public class RateLimitQuotasWriteExample
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
            
            
            
            
            
            var rateLimitQuotasWriteRequest = new RateLimitQuotasWriteRequest(); // RateLimitQuotasWriteRequest | 
            
            

            try
            {
                

                apiInstance.RateLimitQuotasWrite(string name, RateLimitQuotasWriteRequest rateLimitQuotasWriteRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RateLimitQuotasWrite: " + e.Message );
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
 **rateLimitQuotasWriteRequest** | [**RateLimitQuotasWriteRequest**](RateLimitQuotasWriteRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **204** | No Content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rawdelete"></a>
# **RawDelete**

> void RawDelete (string path, TimeSpan? wrapTTL = null)

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
    public class RawDeleteExample
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
                

                apiInstance.RawDelete(string path, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RawDelete: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rawlist"></a>
# **RawList**

> StandardListResponse RawList (string path, TimeSpan? wrapTTL = null)

Return a list keys for a given path prefix.

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
    public class RawListExample
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
            
            
            
            
            var list = "true";  // string | Must be set to `true`
            
            
            

            try
            {
                
                // Return a list keys for a given path prefix.
                

                StandardListResponse result = apiInstance.RawList(string path, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RawList: " + e.Message );
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
 **list** | **string**| Must be set to &#x60;true&#x60; | 


### Return type

[**StandardListResponse**](StandardListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rawread"></a>
# **RawRead**

> RawReadResponse RawRead (string path, TimeSpan? wrapTTL = null)

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
    public class RawReadExample
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
                
                // Read the value of the key at the given path.
                

                RawReadResponse result = apiInstance.RawRead(string path, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RawRead: " + e.Message );
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

[**RawReadResponse**](RawReadResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rawwrite"></a>
# **RawWrite**

> void RawWrite (string path, RawWriteRequest rawWriteRequest, TimeSpan? wrapTTL = null)

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
    public class RawWriteExample
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
            
            
            
            
            
            var rawWriteRequest = new RawWriteRequest(); // RawWriteRequest | 
            
            

            try
            {
                
                // Update the value of the key at the given path.
                

                apiInstance.RawWrite(string path, RawWriteRequest rawWriteRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RawWrite: " + e.Message );
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
 **rawWriteRequest** | [**RawWriteRequest**](RawWriteRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="readhealthstatus"></a>
# **ReadHealthStatus**

> void ReadHealthStatus (TimeSpan? wrapTTL = null)

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
    public class ReadHealthStatusExample
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
                

                apiInstance.ReadHealthStatus(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadHealthStatus: " + e.Message );
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

<a name="readinitializationstatus"></a>
# **ReadInitializationStatus**

> void ReadInitializationStatus (TimeSpan? wrapTTL = null)

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
    public class ReadInitializationStatusExample
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
                

                apiInstance.ReadInitializationStatus(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadInitializationStatus: " + e.Message );
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
                

                apiInstance.ReadReplicationStatus(TimeSpan? wrapTTL = null);
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

<a name="readsanitizedconfigurationstate"></a>
# **ReadSanitizedConfigurationState**

> void ReadSanitizedConfigurationState (TimeSpan? wrapTTL = null)

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
    public class ReadSanitizedConfigurationStateExample
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
                

                apiInstance.ReadSanitizedConfigurationState(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSanitizedConfigurationState: " + e.Message );
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

<a name="readwrappingproperties"></a>
# **ReadWrappingProperties**

> ReadWrappingPropertiesResponse ReadWrappingProperties (ReadWrappingPropertiesRequest readWrappingPropertiesRequest, TimeSpan? wrapTTL = null)

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
    public class ReadWrappingPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var readWrappingPropertiesRequest = new ReadWrappingPropertiesRequest(); // ReadWrappingPropertiesRequest | 
            
            

            try
            {
                
                // Look up wrapping properties for the given token.
                

                ReadWrappingPropertiesResponse result = apiInstance.ReadWrappingProperties(ReadWrappingPropertiesRequest readWrappingPropertiesRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadWrappingProperties: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **readWrappingPropertiesRequest** | [**ReadWrappingPropertiesRequest**](ReadWrappingPropertiesRequest.md)|  | 


### Return type

[**ReadWrappingPropertiesResponse**](ReadWrappingPropertiesResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rekeyattemptcancel"></a>
# **RekeyAttemptCancel**

> void RekeyAttemptCancel (TimeSpan? wrapTTL = null)

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
    public class RekeyAttemptCancelExample
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
                

                apiInstance.RekeyAttemptCancel(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RekeyAttemptCancel: " + e.Message );
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

<a name="rekeyattemptinitialize"></a>
# **RekeyAttemptInitialize**

> RekeyAttemptInitializeResponse RekeyAttemptInitialize (RekeyAttemptInitializeRequest rekeyAttemptInitializeRequest, TimeSpan? wrapTTL = null)

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
    public class RekeyAttemptInitializeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var rekeyAttemptInitializeRequest = new RekeyAttemptInitializeRequest(); // RekeyAttemptInitializeRequest | 
            
            

            try
            {
                
                // Initializes a new rekey attempt.
                

                RekeyAttemptInitializeResponse result = apiInstance.RekeyAttemptInitialize(RekeyAttemptInitializeRequest rekeyAttemptInitializeRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RekeyAttemptInitialize: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rekeyAttemptInitializeRequest** | [**RekeyAttemptInitializeRequest**](RekeyAttemptInitializeRequest.md)|  | 


### Return type

[**RekeyAttemptInitializeResponse**](RekeyAttemptInitializeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rekeyattemptreadprogress"></a>
# **RekeyAttemptReadProgress**

> RekeyAttemptReadProgressResponse RekeyAttemptReadProgress (TimeSpan? wrapTTL = null)

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
    public class RekeyAttemptReadProgressExample
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
                

                RekeyAttemptReadProgressResponse result = apiInstance.RekeyAttemptReadProgress(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RekeyAttemptReadProgress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**RekeyAttemptReadProgressResponse**](RekeyAttemptReadProgressResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rekeyattemptupdate"></a>
# **RekeyAttemptUpdate**

> RekeyAttemptUpdateResponse RekeyAttemptUpdate (RekeyAttemptUpdateRequest rekeyAttemptUpdateRequest, TimeSpan? wrapTTL = null)

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
    public class RekeyAttemptUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var rekeyAttemptUpdateRequest = new RekeyAttemptUpdateRequest(); // RekeyAttemptUpdateRequest | 
            
            

            try
            {
                
                // Enter a single unseal key share to progress the rekey of the Vault.
                

                RekeyAttemptUpdateResponse result = apiInstance.RekeyAttemptUpdate(RekeyAttemptUpdateRequest rekeyAttemptUpdateRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RekeyAttemptUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rekeyAttemptUpdateRequest** | [**RekeyAttemptUpdateRequest**](RekeyAttemptUpdateRequest.md)|  | 


### Return type

[**RekeyAttemptUpdateResponse**](RekeyAttemptUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rekeydeletebackupkey"></a>
# **RekeyDeleteBackupKey**

> void RekeyDeleteBackupKey (TimeSpan? wrapTTL = null)

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
    public class RekeyDeleteBackupKeyExample
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
                

                apiInstance.RekeyDeleteBackupKey(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RekeyDeleteBackupKey: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rekeydeletebackuprecoverykey"></a>
# **RekeyDeleteBackupRecoveryKey**

> void RekeyDeleteBackupRecoveryKey (TimeSpan? wrapTTL = null)



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
    public class RekeyDeleteBackupRecoveryKeyExample
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
                

                apiInstance.RekeyDeleteBackupRecoveryKey(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RekeyDeleteBackupRecoveryKey: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rekeyreadbackupkey"></a>
# **RekeyReadBackupKey**

> RekeyReadBackupKeyResponse RekeyReadBackupKey (TimeSpan? wrapTTL = null)

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
    public class RekeyReadBackupKeyExample
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
                

                RekeyReadBackupKeyResponse result = apiInstance.RekeyReadBackupKey(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RekeyReadBackupKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**RekeyReadBackupKeyResponse**](RekeyReadBackupKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rekeyreadbackuprecoverykey"></a>
# **RekeyReadBackupRecoveryKey**

> RekeyReadBackupRecoveryKeyResponse RekeyReadBackupRecoveryKey (TimeSpan? wrapTTL = null)



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
    public class RekeyReadBackupRecoveryKeyExample
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
                

                RekeyReadBackupRecoveryKeyResponse result = apiInstance.RekeyReadBackupRecoveryKey(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RekeyReadBackupRecoveryKey: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**RekeyReadBackupRecoveryKeyResponse**](RekeyReadBackupRecoveryKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rekeyverificationcancel"></a>
# **RekeyVerificationCancel**

> RekeyVerificationCancelResponse RekeyVerificationCancel (TimeSpan? wrapTTL = null)

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
    public class RekeyVerificationCancelExample
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
                

                RekeyVerificationCancelResponse result = apiInstance.RekeyVerificationCancel(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RekeyVerificationCancel: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**RekeyVerificationCancelResponse**](RekeyVerificationCancelResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rekeyverificationreadprogress"></a>
# **RekeyVerificationReadProgress**

> RekeyVerificationReadProgressResponse RekeyVerificationReadProgress (TimeSpan? wrapTTL = null)

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
    public class RekeyVerificationReadProgressExample
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
                

                RekeyVerificationReadProgressResponse result = apiInstance.RekeyVerificationReadProgress(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RekeyVerificationReadProgress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**RekeyVerificationReadProgressResponse**](RekeyVerificationReadProgressResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rekeyverificationupdate"></a>
# **RekeyVerificationUpdate**

> RekeyVerificationUpdateResponse RekeyVerificationUpdate (RekeyVerificationUpdateRequest rekeyVerificationUpdateRequest, TimeSpan? wrapTTL = null)

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
    public class RekeyVerificationUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var rekeyVerificationUpdateRequest = new RekeyVerificationUpdateRequest(); // RekeyVerificationUpdateRequest | 
            
            

            try
            {
                
                // Enter a single new key share to progress the rekey verification operation.
                

                RekeyVerificationUpdateResponse result = apiInstance.RekeyVerificationUpdate(RekeyVerificationUpdateRequest rekeyVerificationUpdateRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RekeyVerificationUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rekeyVerificationUpdateRequest** | [**RekeyVerificationUpdateRequest**](RekeyVerificationUpdateRequest.md)|  | 


### Return type

[**RekeyVerificationUpdateResponse**](RekeyVerificationUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="reloadsubsystem"></a>
# **ReloadSubsystem**

> void ReloadSubsystem (string subsystem, TimeSpan? wrapTTL = null)

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
    public class ReloadSubsystemExample
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
                

                apiInstance.ReloadSubsystem(string subsystem, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReloadSubsystem: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="remount"></a>
# **Remount**

> RemountResponse Remount (RemountRequest remountRequest, TimeSpan? wrapTTL = null)

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
                

                RemountResponse result = apiInstance.Remount(RemountRequest remountRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
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

[**RemountResponse**](RemountResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="remountstatus"></a>
# **RemountStatus**

> RemountStatusResponse RemountStatus (string migrationId, TimeSpan? wrapTTL = null)

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
    public class RemountStatusExample
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
                

                RemountStatusResponse result = apiInstance.RemountStatus(string migrationId, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RemountStatus: " + e.Message );
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

[**RemountStatusResponse**](RemountStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="rewrap"></a>
# **Rewrap**

> void Rewrap (RewrapRequest rewrapRequest, TimeSpan? wrapTTL = null)



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
    public class RewrapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var rewrapRequest = new RewrapRequest(); // RewrapRequest | 
            
            

            try
            {
                

                apiInstance.Rewrap(RewrapRequest rewrapRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Rewrap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rewrapRequest** | [**RewrapRequest**](RewrapRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="roottokengenerationcancel"></a>
# **RootTokenGenerationCancel**

> void RootTokenGenerationCancel (TimeSpan? wrapTTL = null)

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
    public class RootTokenGenerationCancelExample
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
                

                apiInstance.RootTokenGenerationCancel(TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RootTokenGenerationCancel: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="roottokengenerationinitialize"></a>
# **RootTokenGenerationInitialize**

> RootTokenGenerationInitializeResponse RootTokenGenerationInitialize (RootTokenGenerationInitializeRequest rootTokenGenerationInitializeRequest, TimeSpan? wrapTTL = null)

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
    public class RootTokenGenerationInitializeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var rootTokenGenerationInitializeRequest = new RootTokenGenerationInitializeRequest(); // RootTokenGenerationInitializeRequest | 
            
            

            try
            {
                
                // Initializes a new root generation attempt.
                

                RootTokenGenerationInitializeResponse result = apiInstance.RootTokenGenerationInitialize(RootTokenGenerationInitializeRequest rootTokenGenerationInitializeRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RootTokenGenerationInitialize: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rootTokenGenerationInitializeRequest** | [**RootTokenGenerationInitializeRequest**](RootTokenGenerationInitializeRequest.md)|  | 


### Return type

[**RootTokenGenerationInitializeResponse**](RootTokenGenerationInitializeResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="roottokengenerationreadprogress"></a>
# **RootTokenGenerationReadProgress**

> RootTokenGenerationReadProgressResponse RootTokenGenerationReadProgress (TimeSpan? wrapTTL = null)

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
    public class RootTokenGenerationReadProgressExample
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
                

                RootTokenGenerationReadProgressResponse result = apiInstance.RootTokenGenerationReadProgress(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RootTokenGenerationReadProgress: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**RootTokenGenerationReadProgressResponse**](RootTokenGenerationReadProgressResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="roottokengenerationupdate"></a>
# **RootTokenGenerationUpdate**

> RootTokenGenerationUpdateResponse RootTokenGenerationUpdate (RootTokenGenerationUpdateRequest rootTokenGenerationUpdateRequest, TimeSpan? wrapTTL = null)

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
    public class RootTokenGenerationUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var rootTokenGenerationUpdateRequest = new RootTokenGenerationUpdateRequest(); // RootTokenGenerationUpdateRequest | 
            
            

            try
            {
                
                // Enter a single unseal key share to progress the root generation attempt.
                

                RootTokenGenerationUpdateResponse result = apiInstance.RootTokenGenerationUpdate(RootTokenGenerationUpdateRequest rootTokenGenerationUpdateRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.RootTokenGenerationUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rootTokenGenerationUpdateRequest** | [**RootTokenGenerationUpdateRequest**](RootTokenGenerationUpdateRequest.md)|  | 


### Return type

[**RootTokenGenerationUpdateResponse**](RootTokenGenerationUpdateResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



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
                

                apiInstance.Seal(TimeSpan? wrapTTL = null);
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sealstatus"></a>
# **SealStatus**

> SealStatusResponse SealStatus (TimeSpan? wrapTTL = null)

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
    public class SealStatusExample
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
                

                SealStatusResponse result = apiInstance.SealStatus(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.SealStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.


### Return type

[**SealStatusResponse**](SealStatusResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** |  |  -  |



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
                

                apiInstance.StepDownLeader(TimeSpan? wrapTTL = null);
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

<a name="uiheadersconfigure"></a>
# **UiHeadersConfigure**

> void UiHeadersConfigure (string header, UiHeadersConfigureRequest uiHeadersConfigureRequest, TimeSpan? wrapTTL = null)

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
    public class UiHeadersConfigureExample
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
            
            
            
            
            
            var uiHeadersConfigureRequest = new UiHeadersConfigureRequest(); // UiHeadersConfigureRequest | 
            
            

            try
            {
                
                // Configure the values to be returned for the UI header.
                

                apiInstance.UiHeadersConfigure(string header, UiHeadersConfigureRequest uiHeadersConfigureRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UiHeadersConfigure: " + e.Message );
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
 **uiHeadersConfigureRequest** | [**UiHeadersConfigureRequest**](UiHeadersConfigureRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uiheadersdeleteconfiguration"></a>
# **UiHeadersDeleteConfiguration**

> void UiHeadersDeleteConfiguration (string header, TimeSpan? wrapTTL = null)

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
    public class UiHeadersDeleteConfigurationExample
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
                

                apiInstance.UiHeadersDeleteConfiguration(string header, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UiHeadersDeleteConfiguration: " + e.Message );
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

| **204** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uiheaderslist"></a>
# **UiHeadersList**

> UiHeadersListResponse UiHeadersList (TimeSpan? wrapTTL = null)

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
    public class UiHeadersListExample
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
                

                UiHeadersListResponse result = apiInstance.UiHeadersList(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UiHeadersList: " + e.Message );
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

[**UiHeadersListResponse**](UiHeadersListResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** |  |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uiheadersreadconfiguration"></a>
# **UiHeadersReadConfiguration**

> UiHeadersReadConfigurationResponse UiHeadersReadConfiguration (string header, TimeSpan? wrapTTL = null)

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
    public class UiHeadersReadConfigurationExample
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
                

                UiHeadersReadConfigurationResponse result = apiInstance.UiHeadersReadConfiguration(string header, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UiHeadersReadConfiguration: " + e.Message );
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

[**UiHeadersReadConfigurationResponse**](UiHeadersReadConfigurationResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unseal"></a>
# **Unseal**

> UnsealResponse Unseal (UnsealRequest unsealRequest, TimeSpan? wrapTTL = null)

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
                

                UnsealResponse result = apiInstance.Unseal(UnsealRequest unsealRequest, TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
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

[**UnsealResponse**](UnsealResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** |  |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unwrap"></a>
# **Unwrap**

> void Unwrap (UnwrapRequest unwrapRequest, TimeSpan? wrapTTL = null)



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
    public class UnwrapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var unwrapRequest = new UnwrapRequest(); // UnwrapRequest | 
            
            

            try
            {
                

                apiInstance.Unwrap(UnwrapRequest unwrapRequest, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Unwrap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **unwrapRequest** | [**UnwrapRequest**](UnwrapRequest.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: , 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |

| **204** | No content |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="versionhistory"></a>
# **VersionHistory**

> VersionHistoryResponse VersionHistory (TimeSpan? wrapTTL = null)

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
    public class VersionHistoryExample
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
                

                VersionHistoryResponse result = apiInstance.VersionHistory(TimeSpan? wrapTTL = null);

                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.VersionHistory: " + e.Message );
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

[**VersionHistoryResponse**](VersionHistoryResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="wrap"></a>
# **Wrap**

> void Wrap (Dictionary<string, Object> requestBody, TimeSpan? wrapTTL = null)



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
    public class WrapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            
            
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            
            
            
            
            
            var requestBody = new Dictionary<string, Object>(); // Dictionary<string, Object> | 
            
            

            try
            {
                

                apiInstance.Wrap(Dictionary<string, Object> requestBody, TimeSpan? wrapTTL = null);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.Wrap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **requestBody** | [**Dictionary&lt;string, Object&gt;**](Object.md)|  | 


### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: 
 - **Accept**: Not defined



### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|

| **200** | OK |  -  |



[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

