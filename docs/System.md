# Vault.Api.System

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSystemAuditPath**](System.md#deletesystemauditpath) | **DELETE** /sys/audit/{path} | Disable the audit device at the given path.
[**DeleteSystemAuthPath**](System.md#deletesystemauthpath) | **DELETE** /sys/auth/{path} | Disable the auth method at the given auth path
[**DeleteSystemConfigAuditingRequestHeadersHeader**](System.md#deletesystemconfigauditingrequestheadersheader) | **DELETE** /sys/config/auditing/request-headers/{header} | Disable auditing of the given request header.
[**DeleteSystemConfigCors**](System.md#deletesystemconfigcors) | **DELETE** /sys/config/cors | Remove any CORS settings.
[**DeleteSystemConfigUiHeadersHeader**](System.md#deletesystemconfiguiheadersheader) | **DELETE** /sys/config/ui/headers/{header} | Remove a UI header.
[**DeleteSystemGenerateRoot**](System.md#deletesystemgenerateroot) | **DELETE** /sys/generate-root | Cancels any in-progress root generation attempt.
[**DeleteSystemGenerateRootAttempt**](System.md#deletesystemgeneraterootattempt) | **DELETE** /sys/generate-root/attempt | Cancels any in-progress root generation attempt.
[**DeleteSystemLoggers**](System.md#deletesystemloggers) | **DELETE** /sys/loggers | Revert the all loggers to use log level provided in config.
[**DeleteSystemLoggersName**](System.md#deletesystemloggersname) | **DELETE** /sys/loggers/{name} | Revert a single logger to use log level provided in config.
[**DeleteSystemMountsPath**](System.md#deletesystemmountspath) | **DELETE** /sys/mounts/{path} | Disable the mount point specified at the given path.
[**DeleteSystemPluginsCatalogName**](System.md#deletesystempluginscatalogname) | **DELETE** /sys/plugins/catalog/{name} | Remove the plugin with the given name.
[**DeleteSystemPluginsCatalogTypeName**](System.md#deletesystempluginscatalogtypename) | **DELETE** /sys/plugins/catalog/{type}/{name} | Remove the plugin with the given name.
[**DeleteSystemPoliciesAclName**](System.md#deletesystempoliciesaclname) | **DELETE** /sys/policies/acl/{name} | Delete the ACL policy with the given name.
[**DeleteSystemPoliciesPasswordName**](System.md#deletesystempoliciespasswordname) | **DELETE** /sys/policies/password/{name} | Delete a password policy.
[**DeleteSystemPolicyName**](System.md#deletesystempolicyname) | **DELETE** /sys/policy/{name} | Delete the policy with the given name.
[**DeleteSystemQuotasRateLimitName**](System.md#deletesystemquotasratelimitname) | **DELETE** /sys/quotas/rate-limit/{name} | 
[**DeleteSystemRaw**](System.md#deletesystemraw) | **DELETE** /sys/raw | Delete the key with given path.
[**DeleteSystemRawPath**](System.md#deletesystemrawpath) | **DELETE** /sys/raw/{path} | Delete the key with given path.
[**DeleteSystemRekeyBackup**](System.md#deletesystemrekeybackup) | **DELETE** /sys/rekey/backup | Delete the backup copy of PGP-encrypted unseal keys.
[**DeleteSystemRekeyInit**](System.md#deletesystemrekeyinit) | **DELETE** /sys/rekey/init | Cancels any in-progress rekey.
[**DeleteSystemRekeyRecoveryKeyBackup**](System.md#deletesystemrekeyrecoverykeybackup) | **DELETE** /sys/rekey/recovery-key-backup | Allows fetching or deleting the backup of the rotated unseal keys.
[**DeleteSystemRekeyVerify**](System.md#deletesystemrekeyverify) | **DELETE** /sys/rekey/verify | Cancel any in-progress rekey verification operation.
[**ListSystemConfigUiHeaders**](System.md#listsystemconfiguiheaders) | **GET** /sys/config/ui/headers/ | Return a list of configured UI headers.
[**ListSystemLeasesLookup**](System.md#listsystemleaseslookup) | **GET** /sys/leases/lookup/ | Returns a list of lease ids.
[**ListSystemLeasesLookupPrefix**](System.md#listsystemleaseslookupprefix) | **GET** /sys/leases/lookup/{prefix} | Returns a list of lease ids.
[**ListSystemPluginsCatalogType**](System.md#listsystempluginscatalogtype) | **GET** /sys/plugins/catalog/{type} | List the plugins in the catalog.
[**ListSystemPoliciesAcl**](System.md#listsystempoliciesacl) | **GET** /sys/policies/acl | List the configured access control policies.
[**ListSystemPoliciesPassword**](System.md#listsystempoliciespassword) | **GET** /sys/policies/password | List the existing password policies.
[**ListSystemQuotasRateLimit**](System.md#listsystemquotasratelimit) | **GET** /sys/quotas/rate-limit | 
[**ListSystemVersionHistory**](System.md#listsystemversionhistory) | **GET** /sys/version-history/ | Returns map of historical version change entries
[**ReadSystemAudit**](System.md#readsystemaudit) | **GET** /sys/audit | List the enabled audit devices.
[**ReadSystemAuth**](System.md#readsystemauth) | **GET** /sys/auth | List the currently enabled credential backends.
[**ReadSystemAuthPath**](System.md#readsystemauthpath) | **GET** /sys/auth/{path} | Read the configuration of the auth engine at the given path.
[**ReadSystemAuthPathTune**](System.md#readsystemauthpathtune) | **GET** /sys/auth/{path}/tune | Reads the given auth path&#39;s configuration.
[**ReadSystemConfigAuditingRequestHeaders**](System.md#readsystemconfigauditingrequestheaders) | **GET** /sys/config/auditing/request-headers | List the request headers that are configured to be audited.
[**ReadSystemConfigAuditingRequestHeadersHeader**](System.md#readsystemconfigauditingrequestheadersheader) | **GET** /sys/config/auditing/request-headers/{header} | List the information for the given request header.
[**ReadSystemConfigCors**](System.md#readsystemconfigcors) | **GET** /sys/config/cors | Return the current CORS settings.
[**ReadSystemConfigStateSanitized**](System.md#readsystemconfigstatesanitized) | **GET** /sys/config/state/sanitized | Return a sanitized version of the Vault server configuration.
[**ReadSystemConfigUiHeadersHeader**](System.md#readsystemconfiguiheadersheader) | **GET** /sys/config/ui/headers/{header} | Return the given UI header&#39;s configuration
[**ReadSystemGenerateRoot**](System.md#readsystemgenerateroot) | **GET** /sys/generate-root | Read the configuration and progress of the current root generation attempt.
[**ReadSystemGenerateRootAttempt**](System.md#readsystemgeneraterootattempt) | **GET** /sys/generate-root/attempt | Read the configuration and progress of the current root generation attempt.
[**ReadSystemHaStatus**](System.md#readsystemhastatus) | **GET** /sys/ha-status | Check the HA status of a Vault cluster
[**ReadSystemHealth**](System.md#readsystemhealth) | **GET** /sys/health | Returns the health status of Vault.
[**ReadSystemHostInfo**](System.md#readsystemhostinfo) | **GET** /sys/host-info | Information about the host instance that this Vault server is running on.
[**ReadSystemInFlightReq**](System.md#readsysteminflightreq) | **GET** /sys/in-flight-req | reports in-flight requests
[**ReadSystemInit**](System.md#readsysteminit) | **GET** /sys/init | Returns the initialization status of Vault.
[**ReadSystemInternalCountersActivity**](System.md#readsysteminternalcountersactivity) | **GET** /sys/internal/counters/activity | Report the client count metrics, for this namespace and all child namespaces.
[**ReadSystemInternalCountersActivityExport**](System.md#readsysteminternalcountersactivityexport) | **GET** /sys/internal/counters/activity/export | Report the client count metrics, for this namespace and all child namespaces.
[**ReadSystemInternalCountersActivityMonthly**](System.md#readsysteminternalcountersactivitymonthly) | **GET** /sys/internal/counters/activity/monthly | Report the number of clients for this month, for this namespace and all child namespaces.
[**ReadSystemInternalCountersConfig**](System.md#readsysteminternalcountersconfig) | **GET** /sys/internal/counters/config | Read the client count tracking configuration.
[**ReadSystemInternalCountersEntities**](System.md#readsysteminternalcountersentities) | **GET** /sys/internal/counters/entities | Backwards compatibility is not guaranteed for this API
[**ReadSystemInternalCountersRequests**](System.md#readsysteminternalcountersrequests) | **GET** /sys/internal/counters/requests | Backwards compatibility is not guaranteed for this API
[**ReadSystemInternalCountersTokens**](System.md#readsysteminternalcounterstokens) | **GET** /sys/internal/counters/tokens | Backwards compatibility is not guaranteed for this API
[**ReadSystemInternalInspectRouterTag**](System.md#readsysteminternalinspectroutertag) | **GET** /sys/internal/inspect/router/{tag} | Expose the route entry and mount entry tables present in the router
[**ReadSystemInternalSpecsOpenapi**](System.md#readsysteminternalspecsopenapi) | **GET** /sys/internal/specs/openapi | Generate an OpenAPI 3 document of all mounted paths.
[**ReadSystemInternalUiFeatureFlags**](System.md#readsysteminternaluifeatureflags) | **GET** /sys/internal/ui/feature-flags | Lists enabled feature flags.
[**ReadSystemInternalUiMounts**](System.md#readsysteminternaluimounts) | **GET** /sys/internal/ui/mounts | Lists all enabled and visible auth and secrets mounts.
[**ReadSystemInternalUiMountsPath**](System.md#readsysteminternaluimountspath) | **GET** /sys/internal/ui/mounts/{path} | Return information about the given mount.
[**ReadSystemInternalUiNamespaces**](System.md#readsysteminternaluinamespaces) | **GET** /sys/internal/ui/namespaces | Backwards compatibility is not guaranteed for this API
[**ReadSystemInternalUiResultantAcl**](System.md#readsysteminternaluiresultantacl) | **GET** /sys/internal/ui/resultant-acl | Backwards compatibility is not guaranteed for this API
[**ReadSystemKeyStatus**](System.md#readsystemkeystatus) | **GET** /sys/key-status | Provides information about the backend encryption key.
[**ReadSystemLeader**](System.md#readsystemleader) | **GET** /sys/leader | Returns the high availability status and current leader instance of Vault.
[**ReadSystemLeases**](System.md#readsystemleases) | **GET** /sys/leases | List leases associated with this Vault cluster
[**ReadSystemLeasesCount**](System.md#readsystemleasescount) | **GET** /sys/leases/count | Count of leases associated with this Vault cluster
[**ReadSystemMetrics**](System.md#readsystemmetrics) | **GET** /sys/metrics | Export the metrics aggregated for telemetry purpose.
[**ReadSystemMonitor**](System.md#readsystemmonitor) | **GET** /sys/monitor | 
[**ReadSystemMounts**](System.md#readsystemmounts) | **GET** /sys/mounts | List the currently mounted backends.
[**ReadSystemMountsPath**](System.md#readsystemmountspath) | **GET** /sys/mounts/{path} | Read the configuration of the secret engine at the given path.
[**ReadSystemMountsPathTune**](System.md#readsystemmountspathtune) | **GET** /sys/mounts/{path}/tune | Tune backend configuration parameters for this mount.
[**ReadSystemPluginsCatalog**](System.md#readsystempluginscatalog) | **GET** /sys/plugins/catalog | Lists all the plugins known to Vault
[**ReadSystemPluginsCatalogName**](System.md#readsystempluginscatalogname) | **GET** /sys/plugins/catalog/{name} | Return the configuration data for the plugin with the given name.
[**ReadSystemPluginsCatalogTypeName**](System.md#readsystempluginscatalogtypename) | **GET** /sys/plugins/catalog/{type}/{name} | Return the configuration data for the plugin with the given name.
[**ReadSystemPoliciesAclName**](System.md#readsystempoliciesaclname) | **GET** /sys/policies/acl/{name} | Retrieve information about the named ACL policy.
[**ReadSystemPoliciesPasswordName**](System.md#readsystempoliciespasswordname) | **GET** /sys/policies/password/{name} | Retrieve an existing password policy.
[**ReadSystemPoliciesPasswordNameGenerate**](System.md#readsystempoliciespasswordnamegenerate) | **GET** /sys/policies/password/{name}/generate | Generate a password from an existing password policy.
[**ReadSystemPolicy**](System.md#readsystempolicy) | **GET** /sys/policy | List the configured access control policies.
[**ReadSystemPolicyName**](System.md#readsystempolicyname) | **GET** /sys/policy/{name} | Retrieve the policy body for the named policy.
[**ReadSystemPprof**](System.md#readsystempprof) | **GET** /sys/pprof/ | Returns an HTML page listing the available profiles.
[**ReadSystemPprofAllocs**](System.md#readsystempprofallocs) | **GET** /sys/pprof/allocs | Returns a sampling of all past memory allocations.
[**ReadSystemPprofBlock**](System.md#readsystempprofblock) | **GET** /sys/pprof/block | Returns stack traces that led to blocking on synchronization primitives
[**ReadSystemPprofCmdline**](System.md#readsystempprofcmdline) | **GET** /sys/pprof/cmdline | Returns the running program&#39;s command line.
[**ReadSystemPprofGoroutine**](System.md#readsystempprofgoroutine) | **GET** /sys/pprof/goroutine | Returns stack traces of all current goroutines.
[**ReadSystemPprofHeap**](System.md#readsystempprofheap) | **GET** /sys/pprof/heap | Returns a sampling of memory allocations of live object.
[**ReadSystemPprofMutex**](System.md#readsystempprofmutex) | **GET** /sys/pprof/mutex | Returns stack traces of holders of contended mutexes
[**ReadSystemPprofProfile**](System.md#readsystempprofprofile) | **GET** /sys/pprof/profile | Returns a pprof-formatted cpu profile payload.
[**ReadSystemPprofSymbol**](System.md#readsystempprofsymbol) | **GET** /sys/pprof/symbol | Returns the program counters listed in the request.
[**ReadSystemPprofThreadcreate**](System.md#readsystempprofthreadcreate) | **GET** /sys/pprof/threadcreate | Returns stack traces that led to the creation of new OS threads
[**ReadSystemPprofTrace**](System.md#readsystempproftrace) | **GET** /sys/pprof/trace | Returns the execution trace in binary form.
[**ReadSystemQuotasConfig**](System.md#readsystemquotasconfig) | **GET** /sys/quotas/config | 
[**ReadSystemQuotasRateLimitName**](System.md#readsystemquotasratelimitname) | **GET** /sys/quotas/rate-limit/{name} | 
[**ReadSystemRaw**](System.md#readsystemraw) | **GET** /sys/raw | Read the value of the key at the given path.
[**ReadSystemRawPath**](System.md#readsystemrawpath) | **GET** /sys/raw/{path} | Read the value of the key at the given path.
[**ReadSystemRekeyBackup**](System.md#readsystemrekeybackup) | **GET** /sys/rekey/backup | Return the backup copy of PGP-encrypted unseal keys.
[**ReadSystemRekeyInit**](System.md#readsystemrekeyinit) | **GET** /sys/rekey/init | Reads the configuration and progress of the current rekey attempt.
[**ReadSystemRekeyRecoveryKeyBackup**](System.md#readsystemrekeyrecoverykeybackup) | **GET** /sys/rekey/recovery-key-backup | Allows fetching or deleting the backup of the rotated unseal keys.
[**ReadSystemRekeyVerify**](System.md#readsystemrekeyverify) | **GET** /sys/rekey/verify | Read the configuration and progress of the current rekey verification attempt.
[**ReadSystemRemountStatusMigrationId**](System.md#readsystemremountstatusmigrationid) | **GET** /sys/remount/status/{migration_id} | Check status of a mount migration
[**ReadSystemReplicationStatus**](System.md#readsystemreplicationstatus) | **GET** /sys/replication/status | 
[**ReadSystemRotateConfig**](System.md#readsystemrotateconfig) | **GET** /sys/rotate/config | 
[**ReadSystemSealStatus**](System.md#readsystemsealstatus) | **GET** /sys/seal-status | Check the seal status of a Vault.
[**ReadSystemWrappingLookup**](System.md#readsystemwrappinglookup) | **GET** /sys/wrapping/lookup | Look up wrapping properties for the requester&#39;s token.
[**UpdateSystemAuditHashPath**](System.md#updatesystemaudithashpath) | **POST** /sys/audit-hash/{path} | The hash of the given string via the given audit backend
[**UpdateSystemAuditPath**](System.md#updatesystemauditpath) | **POST** /sys/audit/{path} | Enable a new audit device at the supplied path.
[**UpdateSystemAuthPath**](System.md#updatesystemauthpath) | **POST** /sys/auth/{path} | Enables a new auth method.
[**UpdateSystemAuthPathTune**](System.md#updatesystemauthpathtune) | **POST** /sys/auth/{path}/tune | Tune configuration parameters for a given auth path.
[**UpdateSystemCapabilities**](System.md#updatesystemcapabilities) | **POST** /sys/capabilities | Fetches the capabilities of the given token on the given path.
[**UpdateSystemCapabilitiesAccessor**](System.md#updatesystemcapabilitiesaccessor) | **POST** /sys/capabilities-accessor | Fetches the capabilities of the token associated with the given token, on the given path.
[**UpdateSystemCapabilitiesSelf**](System.md#updatesystemcapabilitiesself) | **POST** /sys/capabilities-self | Fetches the capabilities of the given token on the given path.
[**UpdateSystemConfigAuditingRequestHeadersHeader**](System.md#updatesystemconfigauditingrequestheadersheader) | **POST** /sys/config/auditing/request-headers/{header} | Enable auditing of a header.
[**UpdateSystemConfigCors**](System.md#updatesystemconfigcors) | **POST** /sys/config/cors | Configure the CORS settings.
[**UpdateSystemConfigReloadSubsystem**](System.md#updatesystemconfigreloadsubsystem) | **POST** /sys/config/reload/{subsystem} | Reload the given subsystem
[**UpdateSystemConfigUiHeadersHeader**](System.md#updatesystemconfiguiheadersheader) | **POST** /sys/config/ui/headers/{header} | Configure the values to be returned for the UI header.
[**UpdateSystemGenerateRoot**](System.md#updatesystemgenerateroot) | **POST** /sys/generate-root | Initializes a new root generation attempt.
[**UpdateSystemGenerateRootAttempt**](System.md#updatesystemgeneraterootattempt) | **POST** /sys/generate-root/attempt | Initializes a new root generation attempt.
[**UpdateSystemGenerateRootUpdate**](System.md#updatesystemgeneraterootupdate) | **POST** /sys/generate-root/update | Enter a single unseal key share to progress the root generation attempt.
[**UpdateSystemInit**](System.md#updatesysteminit) | **POST** /sys/init | Initialize a new Vault.
[**UpdateSystemInternalCountersConfig**](System.md#updatesysteminternalcountersconfig) | **POST** /sys/internal/counters/config | Enable or disable collection of client count, set retention period, or set default reporting period.
[**UpdateSystemLeasesLookup**](System.md#updatesystemleaseslookup) | **POST** /sys/leases/lookup | Retrieve lease metadata.
[**UpdateSystemLeasesRenew**](System.md#updatesystemleasesrenew) | **POST** /sys/leases/renew | Renews a lease, requesting to extend the lease.
[**UpdateSystemLeasesRenewUrlLeaseId**](System.md#updatesystemleasesrenewurlleaseid) | **POST** /sys/leases/renew/{url_lease_id} | Renews a lease, requesting to extend the lease.
[**UpdateSystemLeasesRevoke**](System.md#updatesystemleasesrevoke) | **POST** /sys/leases/revoke | Revokes a lease immediately.
[**UpdateSystemLeasesRevokeForcePrefix**](System.md#updatesystemleasesrevokeforceprefix) | **POST** /sys/leases/revoke-force/{prefix} | Revokes all secrets or tokens generated under a given prefix immediately
[**UpdateSystemLeasesRevokePrefixPrefix**](System.md#updatesystemleasesrevokeprefixprefix) | **POST** /sys/leases/revoke-prefix/{prefix} | Revokes all secrets (via a lease ID prefix) or tokens (via the tokens&#39; path property) generated under a given prefix immediately.
[**UpdateSystemLeasesRevokeUrlLeaseId**](System.md#updatesystemleasesrevokeurlleaseid) | **POST** /sys/leases/revoke/{url_lease_id} | Revokes a lease immediately.
[**UpdateSystemLeasesTidy**](System.md#updatesystemleasestidy) | **POST** /sys/leases/tidy | This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
[**UpdateSystemLoggers**](System.md#updatesystemloggers) | **POST** /sys/loggers | Modify the log level for all existing loggers.
[**UpdateSystemLoggersName**](System.md#updatesystemloggersname) | **POST** /sys/loggers/{name} | Modify the log level of a single logger.
[**UpdateSystemMfaValidate**](System.md#updatesystemmfavalidate) | **POST** /sys/mfa/validate | Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token
[**UpdateSystemMountsPath**](System.md#updatesystemmountspath) | **POST** /sys/mounts/{path} | Enable a new secrets engine at the given path.
[**UpdateSystemMountsPathTune**](System.md#updatesystemmountspathtune) | **POST** /sys/mounts/{path}/tune | Tune backend configuration parameters for this mount.
[**UpdateSystemPluginsCatalogName**](System.md#updatesystempluginscatalogname) | **POST** /sys/plugins/catalog/{name} | Register a new plugin, or updates an existing one with the supplied name.
[**UpdateSystemPluginsCatalogTypeName**](System.md#updatesystempluginscatalogtypename) | **POST** /sys/plugins/catalog/{type}/{name} | Register a new plugin, or updates an existing one with the supplied name.
[**UpdateSystemPluginsReloadBackend**](System.md#updatesystempluginsreloadbackend) | **POST** /sys/plugins/reload/backend | Reload mounted plugin backends.
[**UpdateSystemPoliciesAclName**](System.md#updatesystempoliciesaclname) | **POST** /sys/policies/acl/{name} | Add a new or update an existing ACL policy.
[**UpdateSystemPoliciesPasswordName**](System.md#updatesystempoliciespasswordname) | **POST** /sys/policies/password/{name} | Add a new or update an existing password policy.
[**UpdateSystemPolicyName**](System.md#updatesystempolicyname) | **POST** /sys/policy/{name} | Add a new or update an existing policy.
[**UpdateSystemQuotasConfig**](System.md#updatesystemquotasconfig) | **POST** /sys/quotas/config | 
[**UpdateSystemQuotasRateLimitName**](System.md#updatesystemquotasratelimitname) | **POST** /sys/quotas/rate-limit/{name} | 
[**UpdateSystemRaw**](System.md#updatesystemraw) | **POST** /sys/raw | Update the value of the key at the given path.
[**UpdateSystemRawPath**](System.md#updatesystemrawpath) | **POST** /sys/raw/{path} | Update the value of the key at the given path.
[**UpdateSystemRekeyInit**](System.md#updatesystemrekeyinit) | **POST** /sys/rekey/init | Initializes a new rekey attempt.
[**UpdateSystemRekeyUpdate**](System.md#updatesystemrekeyupdate) | **POST** /sys/rekey/update | Enter a single unseal key share to progress the rekey of the Vault.
[**UpdateSystemRekeyVerify**](System.md#updatesystemrekeyverify) | **POST** /sys/rekey/verify | Enter a single new key share to progress the rekey verification operation.
[**UpdateSystemRemount**](System.md#updatesystemremount) | **POST** /sys/remount | Initiate a mount migration
[**UpdateSystemRenew**](System.md#updatesystemrenew) | **POST** /sys/renew | Renews a lease, requesting to extend the lease.
[**UpdateSystemRenewUrlLeaseId**](System.md#updatesystemrenewurlleaseid) | **POST** /sys/renew/{url_lease_id} | Renews a lease, requesting to extend the lease.
[**UpdateSystemRevoke**](System.md#updatesystemrevoke) | **POST** /sys/revoke | Revokes a lease immediately.
[**UpdateSystemRevokeForcePrefix**](System.md#updatesystemrevokeforceprefix) | **POST** /sys/revoke-force/{prefix} | Revokes all secrets or tokens generated under a given prefix immediately
[**UpdateSystemRevokePrefixPrefix**](System.md#updatesystemrevokeprefixprefix) | **POST** /sys/revoke-prefix/{prefix} | Revokes all secrets (via a lease ID prefix) or tokens (via the tokens&#39; path property) generated under a given prefix immediately.
[**UpdateSystemRevokeUrlLeaseId**](System.md#updatesystemrevokeurlleaseid) | **POST** /sys/revoke/{url_lease_id} | Revokes a lease immediately.
[**UpdateSystemRotate**](System.md#updatesystemrotate) | **POST** /sys/rotate | Rotates the backend encryption key used to persist data.
[**UpdateSystemRotateConfig**](System.md#updatesystemrotateconfig) | **POST** /sys/rotate/config | 
[**UpdateSystemSeal**](System.md#updatesystemseal) | **POST** /sys/seal | Seal the Vault.
[**UpdateSystemStepDown**](System.md#updatesystemstepdown) | **POST** /sys/step-down | Cause the node to give up active status.
[**UpdateSystemToolsHash**](System.md#updatesystemtoolshash) | **POST** /sys/tools/hash | Generate a hash sum for input data
[**UpdateSystemToolsHashUrlalgorithm**](System.md#updatesystemtoolshashurlalgorithm) | **POST** /sys/tools/hash/{urlalgorithm} | Generate a hash sum for input data
[**UpdateSystemToolsRandom**](System.md#updatesystemtoolsrandom) | **POST** /sys/tools/random | Generate random bytes
[**UpdateSystemToolsRandomSource**](System.md#updatesystemtoolsrandomsource) | **POST** /sys/tools/random/{source} | Generate random bytes
[**UpdateSystemToolsRandomSourceUrlbytes**](System.md#updatesystemtoolsrandomsourceurlbytes) | **POST** /sys/tools/random/{source}/{urlbytes} | Generate random bytes
[**UpdateSystemToolsRandomUrlbytes**](System.md#updatesystemtoolsrandomurlbytes) | **POST** /sys/tools/random/{urlbytes} | Generate random bytes
[**UpdateSystemUnseal**](System.md#updatesystemunseal) | **POST** /sys/unseal | Unseal the Vault.
[**UpdateSystemWrappingLookup**](System.md#updatesystemwrappinglookup) | **POST** /sys/wrapping/lookup | Look up wrapping properties for the given token.
[**UpdateSystemWrappingRewrap**](System.md#updatesystemwrappingrewrap) | **POST** /sys/wrapping/rewrap | Rotates a response-wrapped token.
[**UpdateSystemWrappingUnwrap**](System.md#updatesystemwrappingunwrap) | **POST** /sys/wrapping/unwrap | Unwraps a response-wrapped token.
[**UpdateSystemWrappingWrap**](System.md#updatesystemwrappingwrap) | **POST** /sys/wrapping/wrap | Response-wraps an arbitrary JSON object.


<a name="deletesystemauditpath"></a>
# **DeleteSystemAuditPath**
> void DeleteSystemAuditPath (string path)

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
    public class DeleteSystemAuditPathExample
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
                apiInstance.DeleteSystemAuditPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemAuditPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemauthpath"></a>
# **DeleteSystemAuthPath**
> void DeleteSystemAuthPath (string path)

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
    public class DeleteSystemAuthPathExample
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
                apiInstance.DeleteSystemAuthPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemAuthPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemconfigauditingrequestheadersheader"></a>
# **DeleteSystemConfigAuditingRequestHeadersHeader**
> void DeleteSystemConfigAuditingRequestHeadersHeader (string header)

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
    public class DeleteSystemConfigAuditingRequestHeadersHeaderExample
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
                apiInstance.DeleteSystemConfigAuditingRequestHeadersHeader(header);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemConfigAuditingRequestHeadersHeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemconfigcors"></a>
# **DeleteSystemConfigCors**
> void DeleteSystemConfigCors ()

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
    public class DeleteSystemConfigCorsExample
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
                apiInstance.DeleteSystemConfigCors();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemConfigCors: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemconfiguiheadersheader"></a>
# **DeleteSystemConfigUiHeadersHeader**
> void DeleteSystemConfigUiHeadersHeader (string header)

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
    public class DeleteSystemConfigUiHeadersHeaderExample
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
                apiInstance.DeleteSystemConfigUiHeadersHeader(header);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemConfigUiHeadersHeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemgenerateroot"></a>
# **DeleteSystemGenerateRoot**
> void DeleteSystemGenerateRoot ()

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
    public class DeleteSystemGenerateRootExample
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
                apiInstance.DeleteSystemGenerateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemGenerateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemgeneraterootattempt"></a>
# **DeleteSystemGenerateRootAttempt**
> void DeleteSystemGenerateRootAttempt ()

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
    public class DeleteSystemGenerateRootAttemptExample
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
                apiInstance.DeleteSystemGenerateRootAttempt();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemGenerateRootAttempt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemloggers"></a>
# **DeleteSystemLoggers**
> void DeleteSystemLoggers ()

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
    public class DeleteSystemLoggersExample
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
                apiInstance.DeleteSystemLoggers();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemLoggers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemloggersname"></a>
# **DeleteSystemLoggersName**
> void DeleteSystemLoggersName (string name)

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
    public class DeleteSystemLoggersNameExample
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
                apiInstance.DeleteSystemLoggersName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemLoggersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemmountspath"></a>
# **DeleteSystemMountsPath**
> void DeleteSystemMountsPath (string path)

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
    public class DeleteSystemMountsPathExample
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
                apiInstance.DeleteSystemMountsPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemMountsPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystempluginscatalogname"></a>
# **DeleteSystemPluginsCatalogName**
> void DeleteSystemPluginsCatalogName (string name)

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
    public class DeleteSystemPluginsCatalogNameExample
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
                apiInstance.DeleteSystemPluginsCatalogName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemPluginsCatalogName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystempluginscatalogtypename"></a>
# **DeleteSystemPluginsCatalogTypeName**
> void DeleteSystemPluginsCatalogTypeName (string name, string type)

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
    public class DeleteSystemPluginsCatalogTypeNameExample
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
                apiInstance.DeleteSystemPluginsCatalogTypeName(name, type);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemPluginsCatalogTypeName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystempoliciesaclname"></a>
# **DeleteSystemPoliciesAclName**
> void DeleteSystemPoliciesAclName (string name)

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
    public class DeleteSystemPoliciesAclNameExample
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
                apiInstance.DeleteSystemPoliciesAclName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemPoliciesAclName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystempoliciespasswordname"></a>
# **DeleteSystemPoliciesPasswordName**
> void DeleteSystemPoliciesPasswordName (string name)

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
    public class DeleteSystemPoliciesPasswordNameExample
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
                apiInstance.DeleteSystemPoliciesPasswordName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemPoliciesPasswordName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystempolicyname"></a>
# **DeleteSystemPolicyName**
> void DeleteSystemPolicyName (string name)

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
    public class DeleteSystemPolicyNameExample
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
                apiInstance.DeleteSystemPolicyName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemPolicyName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemquotasratelimitname"></a>
# **DeleteSystemQuotasRateLimitName**
> void DeleteSystemQuotasRateLimitName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class DeleteSystemQuotasRateLimitNameExample
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
                apiInstance.DeleteSystemQuotasRateLimitName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemQuotasRateLimitName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemraw"></a>
# **DeleteSystemRaw**
> void DeleteSystemRaw ()

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
    public class DeleteSystemRawExample
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
                apiInstance.DeleteSystemRaw();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemRaw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemrawpath"></a>
# **DeleteSystemRawPath**
> void DeleteSystemRawPath (string path)

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
    public class DeleteSystemRawPathExample
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
                apiInstance.DeleteSystemRawPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemRawPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemrekeybackup"></a>
# **DeleteSystemRekeyBackup**
> void DeleteSystemRekeyBackup ()

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
    public class DeleteSystemRekeyBackupExample
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
                apiInstance.DeleteSystemRekeyBackup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemRekeyBackup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemrekeyinit"></a>
# **DeleteSystemRekeyInit**
> void DeleteSystemRekeyInit ()

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
    public class DeleteSystemRekeyInitExample
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
                apiInstance.DeleteSystemRekeyInit();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemRekeyInit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemrekeyrecoverykeybackup"></a>
# **DeleteSystemRekeyRecoveryKeyBackup**
> void DeleteSystemRekeyRecoveryKeyBackup ()

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
    public class DeleteSystemRekeyRecoveryKeyBackupExample
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
                apiInstance.DeleteSystemRekeyRecoveryKeyBackup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemRekeyRecoveryKeyBackup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="deletesystemrekeyverify"></a>
# **DeleteSystemRekeyVerify**
> void DeleteSystemRekeyVerify ()

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
    public class DeleteSystemRekeyVerifyExample
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
                apiInstance.DeleteSystemRekeyVerify();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSystemRekeyVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="listsystemconfiguiheaders"></a>
# **ListSystemConfigUiHeaders**
> void ListSystemConfigUiHeaders (string list)

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
    public class ListSystemConfigUiHeadersExample
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
                apiInstance.ListSystemConfigUiHeaders(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListSystemConfigUiHeaders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="listsystemleaseslookup"></a>
# **ListSystemLeasesLookup**
> void ListSystemLeasesLookup (string list)

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
    public class ListSystemLeasesLookupExample
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
                apiInstance.ListSystemLeasesLookup(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListSystemLeasesLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="listsystemleaseslookupprefix"></a>
# **ListSystemLeasesLookupPrefix**
> void ListSystemLeasesLookupPrefix (string prefix, string list)

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
    public class ListSystemLeasesLookupPrefixExample
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
                apiInstance.ListSystemLeasesLookupPrefix(prefix, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListSystemLeasesLookupPrefix: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="listsystempluginscatalogtype"></a>
# **ListSystemPluginsCatalogType**
> void ListSystemPluginsCatalogType (string type, string list)

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
    public class ListSystemPluginsCatalogTypeExample
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
                apiInstance.ListSystemPluginsCatalogType(type, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListSystemPluginsCatalogType: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="listsystempoliciesacl"></a>
# **ListSystemPoliciesAcl**
> void ListSystemPoliciesAcl (string list)

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
    public class ListSystemPoliciesAclExample
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
                apiInstance.ListSystemPoliciesAcl(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListSystemPoliciesAcl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="listsystempoliciespassword"></a>
# **ListSystemPoliciesPassword**
> void ListSystemPoliciesPassword (string list)

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
    public class ListSystemPoliciesPasswordExample
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
                apiInstance.ListSystemPoliciesPassword(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListSystemPoliciesPassword: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="listsystemquotasratelimit"></a>
# **ListSystemQuotasRateLimit**
> void ListSystemQuotasRateLimit (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ListSystemQuotasRateLimitExample
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
                apiInstance.ListSystemQuotasRateLimit(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListSystemQuotasRateLimit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="listsystemversionhistory"></a>
# **ListSystemVersionHistory**
> void ListSystemVersionHistory (string list)

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
    public class ListSystemVersionHistoryExample
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
                apiInstance.ListSystemVersionHistory(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ListSystemVersionHistory: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemaudit"></a>
# **ReadSystemAudit**
> void ReadSystemAudit ()

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
    public class ReadSystemAuditExample
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
                apiInstance.ReadSystemAudit();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemAudit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemauth"></a>
# **ReadSystemAuth**
> void ReadSystemAuth ()

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
    public class ReadSystemAuthExample
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
                apiInstance.ReadSystemAuth();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemAuth: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemauthpath"></a>
# **ReadSystemAuthPath**
> void ReadSystemAuthPath (string path)

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
    public class ReadSystemAuthPathExample
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
                apiInstance.ReadSystemAuthPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemAuthPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemauthpathtune"></a>
# **ReadSystemAuthPathTune**
> void ReadSystemAuthPathTune (string path)

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
    public class ReadSystemAuthPathTuneExample
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
                apiInstance.ReadSystemAuthPathTune(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemAuthPathTune: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemconfigauditingrequestheaders"></a>
# **ReadSystemConfigAuditingRequestHeaders**
> void ReadSystemConfigAuditingRequestHeaders ()

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
    public class ReadSystemConfigAuditingRequestHeadersExample
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
                apiInstance.ReadSystemConfigAuditingRequestHeaders();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemConfigAuditingRequestHeaders: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemconfigauditingrequestheadersheader"></a>
# **ReadSystemConfigAuditingRequestHeadersHeader**
> void ReadSystemConfigAuditingRequestHeadersHeader (string header)

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
    public class ReadSystemConfigAuditingRequestHeadersHeaderExample
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
                apiInstance.ReadSystemConfigAuditingRequestHeadersHeader(header);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemConfigAuditingRequestHeadersHeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemconfigcors"></a>
# **ReadSystemConfigCors**
> void ReadSystemConfigCors ()

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
    public class ReadSystemConfigCorsExample
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
                apiInstance.ReadSystemConfigCors();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemConfigCors: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemconfigstatesanitized"></a>
# **ReadSystemConfigStateSanitized**
> void ReadSystemConfigStateSanitized ()

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
    public class ReadSystemConfigStateSanitizedExample
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
                apiInstance.ReadSystemConfigStateSanitized();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemConfigStateSanitized: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemconfiguiheadersheader"></a>
# **ReadSystemConfigUiHeadersHeader**
> void ReadSystemConfigUiHeadersHeader (string header)

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
    public class ReadSystemConfigUiHeadersHeaderExample
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
                apiInstance.ReadSystemConfigUiHeadersHeader(header);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemConfigUiHeadersHeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemgenerateroot"></a>
# **ReadSystemGenerateRoot**
> void ReadSystemGenerateRoot ()

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
    public class ReadSystemGenerateRootExample
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
                apiInstance.ReadSystemGenerateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemGenerateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemgeneraterootattempt"></a>
# **ReadSystemGenerateRootAttempt**
> void ReadSystemGenerateRootAttempt ()

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
    public class ReadSystemGenerateRootAttemptExample
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
                apiInstance.ReadSystemGenerateRootAttempt();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemGenerateRootAttempt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemhastatus"></a>
# **ReadSystemHaStatus**
> void ReadSystemHaStatus ()

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
    public class ReadSystemHaStatusExample
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
                apiInstance.ReadSystemHaStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemHaStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemhealth"></a>
# **ReadSystemHealth**
> void ReadSystemHealth ()

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
    public class ReadSystemHealthExample
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
                apiInstance.ReadSystemHealth();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemHealth: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemhostinfo"></a>
# **ReadSystemHostInfo**
> void ReadSystemHostInfo ()

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
    public class ReadSystemHostInfoExample
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
                apiInstance.ReadSystemHostInfo();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemHostInfo: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminflightreq"></a>
# **ReadSystemInFlightReq**
> void ReadSystemInFlightReq ()

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
    public class ReadSystemInFlightReqExample
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
                apiInstance.ReadSystemInFlightReq();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInFlightReq: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminit"></a>
# **ReadSystemInit**
> void ReadSystemInit ()

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
    public class ReadSystemInitExample
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
                apiInstance.ReadSystemInit();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternalcountersactivity"></a>
# **ReadSystemInternalCountersActivity**
> void ReadSystemInternalCountersActivity ()

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
    public class ReadSystemInternalCountersActivityExample
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
                apiInstance.ReadSystemInternalCountersActivity();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalCountersActivity: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternalcountersactivityexport"></a>
# **ReadSystemInternalCountersActivityExport**
> void ReadSystemInternalCountersActivityExport ()

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
    public class ReadSystemInternalCountersActivityExportExample
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
                apiInstance.ReadSystemInternalCountersActivityExport();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalCountersActivityExport: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternalcountersactivitymonthly"></a>
# **ReadSystemInternalCountersActivityMonthly**
> void ReadSystemInternalCountersActivityMonthly ()

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
    public class ReadSystemInternalCountersActivityMonthlyExample
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
                apiInstance.ReadSystemInternalCountersActivityMonthly();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalCountersActivityMonthly: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternalcountersconfig"></a>
# **ReadSystemInternalCountersConfig**
> void ReadSystemInternalCountersConfig ()

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
    public class ReadSystemInternalCountersConfigExample
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
                apiInstance.ReadSystemInternalCountersConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalCountersConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternalcountersentities"></a>
# **ReadSystemInternalCountersEntities**
> void ReadSystemInternalCountersEntities ()

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
    public class ReadSystemInternalCountersEntitiesExample
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
                apiInstance.ReadSystemInternalCountersEntities();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalCountersEntities: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternalcountersrequests"></a>
# **ReadSystemInternalCountersRequests**
> void ReadSystemInternalCountersRequests ()

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
    public class ReadSystemInternalCountersRequestsExample
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
                apiInstance.ReadSystemInternalCountersRequests();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalCountersRequests: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternalcounterstokens"></a>
# **ReadSystemInternalCountersTokens**
> void ReadSystemInternalCountersTokens ()

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
    public class ReadSystemInternalCountersTokensExample
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
                apiInstance.ReadSystemInternalCountersTokens();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalCountersTokens: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternalinspectroutertag"></a>
# **ReadSystemInternalInspectRouterTag**
> void ReadSystemInternalInspectRouterTag (string tag)

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
    public class ReadSystemInternalInspectRouterTagExample
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
                apiInstance.ReadSystemInternalInspectRouterTag(tag);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalInspectRouterTag: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternalspecsopenapi"></a>
# **ReadSystemInternalSpecsOpenapi**
> void ReadSystemInternalSpecsOpenapi ()

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
    public class ReadSystemInternalSpecsOpenapiExample
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
                apiInstance.ReadSystemInternalSpecsOpenapi();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalSpecsOpenapi: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternaluifeatureflags"></a>
# **ReadSystemInternalUiFeatureFlags**
> void ReadSystemInternalUiFeatureFlags ()

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
    public class ReadSystemInternalUiFeatureFlagsExample
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
                apiInstance.ReadSystemInternalUiFeatureFlags();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalUiFeatureFlags: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternaluimounts"></a>
# **ReadSystemInternalUiMounts**
> void ReadSystemInternalUiMounts ()

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
    public class ReadSystemInternalUiMountsExample
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
                apiInstance.ReadSystemInternalUiMounts();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalUiMounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternaluimountspath"></a>
# **ReadSystemInternalUiMountsPath**
> void ReadSystemInternalUiMountsPath (string path)

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
    public class ReadSystemInternalUiMountsPathExample
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
                apiInstance.ReadSystemInternalUiMountsPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalUiMountsPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternaluinamespaces"></a>
# **ReadSystemInternalUiNamespaces**
> void ReadSystemInternalUiNamespaces ()

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
    public class ReadSystemInternalUiNamespacesExample
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
                apiInstance.ReadSystemInternalUiNamespaces();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalUiNamespaces: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsysteminternaluiresultantacl"></a>
# **ReadSystemInternalUiResultantAcl**
> void ReadSystemInternalUiResultantAcl ()

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
    public class ReadSystemInternalUiResultantAclExample
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
                apiInstance.ReadSystemInternalUiResultantAcl();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemInternalUiResultantAcl: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemkeystatus"></a>
# **ReadSystemKeyStatus**
> void ReadSystemKeyStatus ()

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
    public class ReadSystemKeyStatusExample
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
                apiInstance.ReadSystemKeyStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemKeyStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemleader"></a>
# **ReadSystemLeader**
> void ReadSystemLeader ()

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
    public class ReadSystemLeaderExample
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
                apiInstance.ReadSystemLeader();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemLeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemleases"></a>
# **ReadSystemLeases**
> void ReadSystemLeases ()

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
    public class ReadSystemLeasesExample
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
                apiInstance.ReadSystemLeases();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemLeases: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemleasescount"></a>
# **ReadSystemLeasesCount**
> void ReadSystemLeasesCount ()

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
    public class ReadSystemLeasesCountExample
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
                apiInstance.ReadSystemLeasesCount();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemLeasesCount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemmetrics"></a>
# **ReadSystemMetrics**
> void ReadSystemMetrics (string format = null)

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
    public class ReadSystemMetricsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var format = "\"\"";  // string | Format to export metrics into. Currently accepts only \"prometheus\". (optional)  (default to "")

            try
            {
                // Export the metrics aggregated for telemetry purpose.
                apiInstance.ReadSystemMetrics(format);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemMetrics: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **format** | **string**| Format to export metrics into. Currently accepts only \&quot;prometheus\&quot;. | [optional] [default to &quot;&quot;]

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

<a name="readsystemmonitor"></a>
# **ReadSystemMonitor**
> void ReadSystemMonitor (string logFormat = null, string logLevel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadSystemMonitorExample
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
            var logLevel = "\"info\"";  // string | Log level to view system logs at. Currently supported values are \"trace\", \"debug\", \"info\", \"warn\", \"error\". (optional)  (default to "info")

            try
            {
                apiInstance.ReadSystemMonitor(logFormat, logLevel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemMonitor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **logFormat** | **string**| Output format of logs. Supported values are \&quot;standard\&quot; and \&quot;json\&quot;. The default is \&quot;standard\&quot;. | [optional] [default to &quot;standard&quot;]
 **logLevel** | **string**| Log level to view system logs at. Currently supported values are \&quot;trace\&quot;, \&quot;debug\&quot;, \&quot;info\&quot;, \&quot;warn\&quot;, \&quot;error\&quot;. | [optional] [default to &quot;info&quot;]

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

<a name="readsystemmounts"></a>
# **ReadSystemMounts**
> void ReadSystemMounts ()

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
    public class ReadSystemMountsExample
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
                apiInstance.ReadSystemMounts();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemMounts: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemmountspath"></a>
# **ReadSystemMountsPath**
> void ReadSystemMountsPath (string path)

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
    public class ReadSystemMountsPathExample
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
                apiInstance.ReadSystemMountsPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemMountsPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemmountspathtune"></a>
# **ReadSystemMountsPathTune**
> void ReadSystemMountsPathTune (string path)

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
    public class ReadSystemMountsPathTuneExample
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
                apiInstance.ReadSystemMountsPathTune(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemMountsPathTune: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempluginscatalog"></a>
# **ReadSystemPluginsCatalog**
> void ReadSystemPluginsCatalog ()

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
    public class ReadSystemPluginsCatalogExample
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
                apiInstance.ReadSystemPluginsCatalog();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPluginsCatalog: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempluginscatalogname"></a>
# **ReadSystemPluginsCatalogName**
> void ReadSystemPluginsCatalogName (string name)

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
    public class ReadSystemPluginsCatalogNameExample
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
                apiInstance.ReadSystemPluginsCatalogName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPluginsCatalogName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempluginscatalogtypename"></a>
# **ReadSystemPluginsCatalogTypeName**
> void ReadSystemPluginsCatalogTypeName (string name, string type)

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
    public class ReadSystemPluginsCatalogTypeNameExample
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
                apiInstance.ReadSystemPluginsCatalogTypeName(name, type);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPluginsCatalogTypeName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempoliciesaclname"></a>
# **ReadSystemPoliciesAclName**
> void ReadSystemPoliciesAclName (string name)

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
    public class ReadSystemPoliciesAclNameExample
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
                apiInstance.ReadSystemPoliciesAclName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPoliciesAclName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempoliciespasswordname"></a>
# **ReadSystemPoliciesPasswordName**
> void ReadSystemPoliciesPasswordName (string name)

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
    public class ReadSystemPoliciesPasswordNameExample
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
                apiInstance.ReadSystemPoliciesPasswordName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPoliciesPasswordName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempoliciespasswordnamegenerate"></a>
# **ReadSystemPoliciesPasswordNameGenerate**
> void ReadSystemPoliciesPasswordNameGenerate (string name)

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
    public class ReadSystemPoliciesPasswordNameGenerateExample
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
                apiInstance.ReadSystemPoliciesPasswordNameGenerate(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPoliciesPasswordNameGenerate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempolicy"></a>
# **ReadSystemPolicy**
> void ReadSystemPolicy (string list = null)

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
    public class ReadSystemPolicyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var list = "\"false\"";  // string | Return a list if `true` (optional)  (default to "false")

            try
            {
                // List the configured access control policies.
                apiInstance.ReadSystemPolicy(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPolicy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Return a list if &#x60;true&#x60; | [optional] [default to &quot;false&quot;]

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

<a name="readsystempolicyname"></a>
# **ReadSystemPolicyName**
> void ReadSystemPolicyName (string name)

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
    public class ReadSystemPolicyNameExample
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
                apiInstance.ReadSystemPolicyName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPolicyName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempprof"></a>
# **ReadSystemPprof**
> void ReadSystemPprof ()

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
    public class ReadSystemPprofExample
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
                apiInstance.ReadSystemPprof();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPprof: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempprofallocs"></a>
# **ReadSystemPprofAllocs**
> void ReadSystemPprofAllocs ()

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
    public class ReadSystemPprofAllocsExample
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
                apiInstance.ReadSystemPprofAllocs();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPprofAllocs: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempprofblock"></a>
# **ReadSystemPprofBlock**
> void ReadSystemPprofBlock ()

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
    public class ReadSystemPprofBlockExample
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
                apiInstance.ReadSystemPprofBlock();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPprofBlock: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempprofcmdline"></a>
# **ReadSystemPprofCmdline**
> void ReadSystemPprofCmdline ()

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
    public class ReadSystemPprofCmdlineExample
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
                apiInstance.ReadSystemPprofCmdline();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPprofCmdline: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempprofgoroutine"></a>
# **ReadSystemPprofGoroutine**
> void ReadSystemPprofGoroutine ()

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
    public class ReadSystemPprofGoroutineExample
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
                apiInstance.ReadSystemPprofGoroutine();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPprofGoroutine: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempprofheap"></a>
# **ReadSystemPprofHeap**
> void ReadSystemPprofHeap ()

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
    public class ReadSystemPprofHeapExample
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
                apiInstance.ReadSystemPprofHeap();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPprofHeap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempprofmutex"></a>
# **ReadSystemPprofMutex**
> void ReadSystemPprofMutex ()

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
    public class ReadSystemPprofMutexExample
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
                apiInstance.ReadSystemPprofMutex();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPprofMutex: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempprofprofile"></a>
# **ReadSystemPprofProfile**
> void ReadSystemPprofProfile ()

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
    public class ReadSystemPprofProfileExample
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
                apiInstance.ReadSystemPprofProfile();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPprofProfile: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempprofsymbol"></a>
# **ReadSystemPprofSymbol**
> void ReadSystemPprofSymbol ()

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
    public class ReadSystemPprofSymbolExample
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
                apiInstance.ReadSystemPprofSymbol();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPprofSymbol: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempprofthreadcreate"></a>
# **ReadSystemPprofThreadcreate**
> void ReadSystemPprofThreadcreate ()

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
    public class ReadSystemPprofThreadcreateExample
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
                apiInstance.ReadSystemPprofThreadcreate();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPprofThreadcreate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystempproftrace"></a>
# **ReadSystemPprofTrace**
> void ReadSystemPprofTrace ()

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
    public class ReadSystemPprofTraceExample
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
                apiInstance.ReadSystemPprofTrace();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemPprofTrace: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemquotasconfig"></a>
# **ReadSystemQuotasConfig**
> void ReadSystemQuotasConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadSystemQuotasConfigExample
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
                apiInstance.ReadSystemQuotasConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemQuotasConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemquotasratelimitname"></a>
# **ReadSystemQuotasRateLimitName**
> void ReadSystemQuotasRateLimitName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadSystemQuotasRateLimitNameExample
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
                apiInstance.ReadSystemQuotasRateLimitName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemQuotasRateLimitName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemraw"></a>
# **ReadSystemRaw**
> void ReadSystemRaw (string list = null)

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
    public class ReadSystemRawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var list = "\"false\"";  // string | Return a list if `true` (optional)  (default to "false")

            try
            {
                // Read the value of the key at the given path.
                apiInstance.ReadSystemRaw(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemRaw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| Return a list if &#x60;true&#x60; | [optional] [default to &quot;false&quot;]

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

<a name="readsystemrawpath"></a>
# **ReadSystemRawPath**
> void ReadSystemRawPath (string path, string list = null)

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
    public class ReadSystemRawPathExample
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
            var list = "\"false\"";  // string | Return a list if `true` (optional)  (default to "false")

            try
            {
                // Read the value of the key at the given path.
                apiInstance.ReadSystemRawPath(path, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemRawPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **list** | **string**| Return a list if &#x60;true&#x60; | [optional] [default to &quot;false&quot;]

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

<a name="readsystemrekeybackup"></a>
# **ReadSystemRekeyBackup**
> void ReadSystemRekeyBackup ()

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
    public class ReadSystemRekeyBackupExample
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
                apiInstance.ReadSystemRekeyBackup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemRekeyBackup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemrekeyinit"></a>
# **ReadSystemRekeyInit**
> void ReadSystemRekeyInit ()

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
    public class ReadSystemRekeyInitExample
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
                apiInstance.ReadSystemRekeyInit();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemRekeyInit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemrekeyrecoverykeybackup"></a>
# **ReadSystemRekeyRecoveryKeyBackup**
> void ReadSystemRekeyRecoveryKeyBackup ()

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
    public class ReadSystemRekeyRecoveryKeyBackupExample
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
                apiInstance.ReadSystemRekeyRecoveryKeyBackup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemRekeyRecoveryKeyBackup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemrekeyverify"></a>
# **ReadSystemRekeyVerify**
> void ReadSystemRekeyVerify ()

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
    public class ReadSystemRekeyVerifyExample
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
                apiInstance.ReadSystemRekeyVerify();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemRekeyVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemremountstatusmigrationid"></a>
# **ReadSystemRemountStatusMigrationId**
> void ReadSystemRemountStatusMigrationId (string migrationId)

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
    public class ReadSystemRemountStatusMigrationIdExample
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
                apiInstance.ReadSystemRemountStatusMigrationId(migrationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemRemountStatusMigrationId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemreplicationstatus"></a>
# **ReadSystemReplicationStatus**
> void ReadSystemReplicationStatus ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadSystemReplicationStatusExample
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
                apiInstance.ReadSystemReplicationStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemReplicationStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemrotateconfig"></a>
# **ReadSystemRotateConfig**
> void ReadSystemRotateConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class ReadSystemRotateConfigExample
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
                apiInstance.ReadSystemRotateConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemRotateConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemsealstatus"></a>
# **ReadSystemSealStatus**
> void ReadSystemSealStatus ()

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
    public class ReadSystemSealStatusExample
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
                apiInstance.ReadSystemSealStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemSealStatus: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="readsystemwrappinglookup"></a>
# **ReadSystemWrappingLookup**
> void ReadSystemWrappingLookup ()

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
    public class ReadSystemWrappingLookupExample
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
                apiInstance.ReadSystemWrappingLookup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.ReadSystemWrappingLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="updatesystemaudithashpath"></a>
# **UpdateSystemAuditHashPath**
> void UpdateSystemAuditHashPath (string path, SystemAuditHashRequest systemAuditHashRequest)

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
    public class UpdateSystemAuditHashPathExample
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
            var systemAuditHashRequest = new SystemAuditHashRequest(); // SystemAuditHashRequest | 

            try
            {
                // The hash of the given string via the given audit backend
                apiInstance.UpdateSystemAuditHashPath(path, systemAuditHashRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemAuditHashPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot; | 
 **systemAuditHashRequest** | [**SystemAuditHashRequest**](SystemAuditHashRequest.md)|  | 

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

<a name="updatesystemauditpath"></a>
# **UpdateSystemAuditPath**
> void UpdateSystemAuditPath (string path, SystemAuditRequest systemAuditRequest)

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
    public class UpdateSystemAuditPathExample
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
            var systemAuditRequest = new SystemAuditRequest(); // SystemAuditRequest | 

            try
            {
                // Enable a new audit device at the supplied path.
                apiInstance.UpdateSystemAuditPath(path, systemAuditRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemAuditPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot; | 
 **systemAuditRequest** | [**SystemAuditRequest**](SystemAuditRequest.md)|  | 

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

<a name="updatesystemauthpath"></a>
# **UpdateSystemAuthPath**
> void UpdateSystemAuthPath (string path, SystemAuthRequest systemAuthRequest)

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
    public class UpdateSystemAuthPathExample
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
            var systemAuthRequest = new SystemAuthRequest(); // SystemAuthRequest | 

            try
            {
                // Enables a new auth method.
                apiInstance.UpdateSystemAuthPath(path, systemAuthRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemAuthPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to mount to. Cannot be delimited. Example: \&quot;user\&quot; | 
 **systemAuthRequest** | [**SystemAuthRequest**](SystemAuthRequest.md)|  | 

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

<a name="updatesystemauthpathtune"></a>
# **UpdateSystemAuthPathTune**
> void UpdateSystemAuthPathTune (string path, SystemAuthTuneRequest systemAuthTuneRequest)

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
    public class UpdateSystemAuthPathTuneExample
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
            var systemAuthTuneRequest = new SystemAuthTuneRequest(); // SystemAuthTuneRequest | 

            try
            {
                // Tune configuration parameters for a given auth path.
                apiInstance.UpdateSystemAuthPathTune(path, systemAuthTuneRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemAuthPathTune: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Tune the configuration parameters for an auth path. | 
 **systemAuthTuneRequest** | [**SystemAuthTuneRequest**](SystemAuthTuneRequest.md)|  | 

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

<a name="updatesystemcapabilities"></a>
# **UpdateSystemCapabilities**
> void UpdateSystemCapabilities (SystemCapabilitiesRequest systemCapabilitiesRequest)

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
    public class UpdateSystemCapabilitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemCapabilitiesRequest = new SystemCapabilitiesRequest(); // SystemCapabilitiesRequest | 

            try
            {
                // Fetches the capabilities of the given token on the given path.
                apiInstance.UpdateSystemCapabilities(systemCapabilitiesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemCapabilities: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemCapabilitiesRequest** | [**SystemCapabilitiesRequest**](SystemCapabilitiesRequest.md)|  | 

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

<a name="updatesystemcapabilitiesaccessor"></a>
# **UpdateSystemCapabilitiesAccessor**
> void UpdateSystemCapabilitiesAccessor (SystemCapabilitiesAccessorRequest systemCapabilitiesAccessorRequest)

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
    public class UpdateSystemCapabilitiesAccessorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemCapabilitiesAccessorRequest = new SystemCapabilitiesAccessorRequest(); // SystemCapabilitiesAccessorRequest | 

            try
            {
                // Fetches the capabilities of the token associated with the given token, on the given path.
                apiInstance.UpdateSystemCapabilitiesAccessor(systemCapabilitiesAccessorRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemCapabilitiesAccessor: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemCapabilitiesAccessorRequest** | [**SystemCapabilitiesAccessorRequest**](SystemCapabilitiesAccessorRequest.md)|  | 

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

<a name="updatesystemcapabilitiesself"></a>
# **UpdateSystemCapabilitiesSelf**
> void UpdateSystemCapabilitiesSelf (SystemCapabilitiesSelfRequest systemCapabilitiesSelfRequest)

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
    public class UpdateSystemCapabilitiesSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemCapabilitiesSelfRequest = new SystemCapabilitiesSelfRequest(); // SystemCapabilitiesSelfRequest | 

            try
            {
                // Fetches the capabilities of the given token on the given path.
                apiInstance.UpdateSystemCapabilitiesSelf(systemCapabilitiesSelfRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemCapabilitiesSelf: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemCapabilitiesSelfRequest** | [**SystemCapabilitiesSelfRequest**](SystemCapabilitiesSelfRequest.md)|  | 

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

<a name="updatesystemconfigauditingrequestheadersheader"></a>
# **UpdateSystemConfigAuditingRequestHeadersHeader**
> void UpdateSystemConfigAuditingRequestHeadersHeader (string header, SystemConfigAuditingRequestHeadersRequest systemConfigAuditingRequestHeadersRequest)

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
    public class UpdateSystemConfigAuditingRequestHeadersHeaderExample
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
            var systemConfigAuditingRequestHeadersRequest = new SystemConfigAuditingRequestHeadersRequest(); // SystemConfigAuditingRequestHeadersRequest | 

            try
            {
                // Enable auditing of a header.
                apiInstance.UpdateSystemConfigAuditingRequestHeadersHeader(header, systemConfigAuditingRequestHeadersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemConfigAuditingRequestHeadersHeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header** | **string**|  | 
 **systemConfigAuditingRequestHeadersRequest** | [**SystemConfigAuditingRequestHeadersRequest**](SystemConfigAuditingRequestHeadersRequest.md)|  | 

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

<a name="updatesystemconfigcors"></a>
# **UpdateSystemConfigCors**
> void UpdateSystemConfigCors (SystemConfigCorsRequest systemConfigCorsRequest)

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
    public class UpdateSystemConfigCorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemConfigCorsRequest = new SystemConfigCorsRequest(); // SystemConfigCorsRequest | 

            try
            {
                // Configure the CORS settings.
                apiInstance.UpdateSystemConfigCors(systemConfigCorsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemConfigCors: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemConfigCorsRequest** | [**SystemConfigCorsRequest**](SystemConfigCorsRequest.md)|  | 

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

<a name="updatesystemconfigreloadsubsystem"></a>
# **UpdateSystemConfigReloadSubsystem**
> void UpdateSystemConfigReloadSubsystem (string subsystem)

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
    public class UpdateSystemConfigReloadSubsystemExample
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
                apiInstance.UpdateSystemConfigReloadSubsystem(subsystem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemConfigReloadSubsystem: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="updatesystemconfiguiheadersheader"></a>
# **UpdateSystemConfigUiHeadersHeader**
> void UpdateSystemConfigUiHeadersHeader (string header, SystemConfigUiHeadersRequest systemConfigUiHeadersRequest)

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
    public class UpdateSystemConfigUiHeadersHeaderExample
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
            var systemConfigUiHeadersRequest = new SystemConfigUiHeadersRequest(); // SystemConfigUiHeadersRequest | 

            try
            {
                // Configure the values to be returned for the UI header.
                apiInstance.UpdateSystemConfigUiHeadersHeader(header, systemConfigUiHeadersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemConfigUiHeadersHeader: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **header** | **string**| The name of the header. | 
 **systemConfigUiHeadersRequest** | [**SystemConfigUiHeadersRequest**](SystemConfigUiHeadersRequest.md)|  | 

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

<a name="updatesystemgenerateroot"></a>
# **UpdateSystemGenerateRoot**
> void UpdateSystemGenerateRoot (SystemGenerateRootRequest systemGenerateRootRequest)

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
    public class UpdateSystemGenerateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemGenerateRootRequest = new SystemGenerateRootRequest(); // SystemGenerateRootRequest | 

            try
            {
                // Initializes a new root generation attempt.
                apiInstance.UpdateSystemGenerateRoot(systemGenerateRootRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemGenerateRoot: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemGenerateRootRequest** | [**SystemGenerateRootRequest**](SystemGenerateRootRequest.md)|  | 

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

<a name="updatesystemgeneraterootattempt"></a>
# **UpdateSystemGenerateRootAttempt**
> void UpdateSystemGenerateRootAttempt (SystemGenerateRootAttemptRequest systemGenerateRootAttemptRequest)

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
    public class UpdateSystemGenerateRootAttemptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemGenerateRootAttemptRequest = new SystemGenerateRootAttemptRequest(); // SystemGenerateRootAttemptRequest | 

            try
            {
                // Initializes a new root generation attempt.
                apiInstance.UpdateSystemGenerateRootAttempt(systemGenerateRootAttemptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemGenerateRootAttempt: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemGenerateRootAttemptRequest** | [**SystemGenerateRootAttemptRequest**](SystemGenerateRootAttemptRequest.md)|  | 

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

<a name="updatesystemgeneraterootupdate"></a>
# **UpdateSystemGenerateRootUpdate**
> void UpdateSystemGenerateRootUpdate (SystemGenerateRootUpdateRequest systemGenerateRootUpdateRequest)

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
    public class UpdateSystemGenerateRootUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemGenerateRootUpdateRequest = new SystemGenerateRootUpdateRequest(); // SystemGenerateRootUpdateRequest | 

            try
            {
                // Enter a single unseal key share to progress the root generation attempt.
                apiInstance.UpdateSystemGenerateRootUpdate(systemGenerateRootUpdateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemGenerateRootUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemGenerateRootUpdateRequest** | [**SystemGenerateRootUpdateRequest**](SystemGenerateRootUpdateRequest.md)|  | 

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

<a name="updatesysteminit"></a>
# **UpdateSystemInit**
> void UpdateSystemInit (SystemInitRequest systemInitRequest)

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
    public class UpdateSystemInitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemInitRequest = new SystemInitRequest(); // SystemInitRequest | 

            try
            {
                // Initialize a new Vault.
                apiInstance.UpdateSystemInit(systemInitRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemInit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemInitRequest** | [**SystemInitRequest**](SystemInitRequest.md)|  | 

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

<a name="updatesysteminternalcountersconfig"></a>
# **UpdateSystemInternalCountersConfig**
> void UpdateSystemInternalCountersConfig (SystemInternalCountersConfigRequest systemInternalCountersConfigRequest)

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
    public class UpdateSystemInternalCountersConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemInternalCountersConfigRequest = new SystemInternalCountersConfigRequest(); // SystemInternalCountersConfigRequest | 

            try
            {
                // Enable or disable collection of client count, set retention period, or set default reporting period.
                apiInstance.UpdateSystemInternalCountersConfig(systemInternalCountersConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemInternalCountersConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemInternalCountersConfigRequest** | [**SystemInternalCountersConfigRequest**](SystemInternalCountersConfigRequest.md)|  | 

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

<a name="updatesystemleaseslookup"></a>
# **UpdateSystemLeasesLookup**
> void UpdateSystemLeasesLookup (SystemLeasesLookupRequest systemLeasesLookupRequest)

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
    public class UpdateSystemLeasesLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemLeasesLookupRequest = new SystemLeasesLookupRequest(); // SystemLeasesLookupRequest | 

            try
            {
                // Retrieve lease metadata.
                apiInstance.UpdateSystemLeasesLookup(systemLeasesLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemLeasesLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemLeasesLookupRequest** | [**SystemLeasesLookupRequest**](SystemLeasesLookupRequest.md)|  | 

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

<a name="updatesystemleasesrenew"></a>
# **UpdateSystemLeasesRenew**
> void UpdateSystemLeasesRenew (SystemLeasesRenewRequest systemLeasesRenewRequest)

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
    public class UpdateSystemLeasesRenewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemLeasesRenewRequest = new SystemLeasesRenewRequest(); // SystemLeasesRenewRequest | 

            try
            {
                // Renews a lease, requesting to extend the lease.
                apiInstance.UpdateSystemLeasesRenew(systemLeasesRenewRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemLeasesRenew: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemLeasesRenewRequest** | [**SystemLeasesRenewRequest**](SystemLeasesRenewRequest.md)|  | 

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

<a name="updatesystemleasesrenewurlleaseid"></a>
# **UpdateSystemLeasesRenewUrlLeaseId**
> void UpdateSystemLeasesRenewUrlLeaseId (string urlLeaseId, SystemLeasesRenewLeaseRequest systemLeasesRenewLeaseRequest)

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
    public class UpdateSystemLeasesRenewUrlLeaseIdExample
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
            var systemLeasesRenewLeaseRequest = new SystemLeasesRenewLeaseRequest(); // SystemLeasesRenewLeaseRequest | 

            try
            {
                // Renews a lease, requesting to extend the lease.
                apiInstance.UpdateSystemLeasesRenewUrlLeaseId(urlLeaseId, systemLeasesRenewLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemLeasesRenewUrlLeaseId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlLeaseId** | **string**| The lease identifier to renew. This is included with a lease. | 
 **systemLeasesRenewLeaseRequest** | [**SystemLeasesRenewLeaseRequest**](SystemLeasesRenewLeaseRequest.md)|  | 

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

<a name="updatesystemleasesrevoke"></a>
# **UpdateSystemLeasesRevoke**
> void UpdateSystemLeasesRevoke (SystemLeasesRevokeRequest systemLeasesRevokeRequest)

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
    public class UpdateSystemLeasesRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemLeasesRevokeRequest = new SystemLeasesRevokeRequest(); // SystemLeasesRevokeRequest | 

            try
            {
                // Revokes a lease immediately.
                apiInstance.UpdateSystemLeasesRevoke(systemLeasesRevokeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemLeasesRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemLeasesRevokeRequest** | [**SystemLeasesRevokeRequest**](SystemLeasesRevokeRequest.md)|  | 

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

<a name="updatesystemleasesrevokeforceprefix"></a>
# **UpdateSystemLeasesRevokeForcePrefix**
> void UpdateSystemLeasesRevokeForcePrefix (string prefix)

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
    public class UpdateSystemLeasesRevokeForcePrefixExample
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
                apiInstance.UpdateSystemLeasesRevokeForcePrefix(prefix);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemLeasesRevokeForcePrefix: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="updatesystemleasesrevokeprefixprefix"></a>
# **UpdateSystemLeasesRevokePrefixPrefix**
> void UpdateSystemLeasesRevokePrefixPrefix (string prefix, SystemLeasesRevokePrefixRequest systemLeasesRevokePrefixRequest)

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
    public class UpdateSystemLeasesRevokePrefixPrefixExample
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
            var systemLeasesRevokePrefixRequest = new SystemLeasesRevokePrefixRequest(); // SystemLeasesRevokePrefixRequest | 

            try
            {
                // Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.
                apiInstance.UpdateSystemLeasesRevokePrefixPrefix(prefix, systemLeasesRevokePrefixRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemLeasesRevokePrefixPrefix: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **prefix** | **string**| The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot; | 
 **systemLeasesRevokePrefixRequest** | [**SystemLeasesRevokePrefixRequest**](SystemLeasesRevokePrefixRequest.md)|  | 

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

<a name="updatesystemleasesrevokeurlleaseid"></a>
# **UpdateSystemLeasesRevokeUrlLeaseId**
> void UpdateSystemLeasesRevokeUrlLeaseId (string urlLeaseId, SystemLeasesRevokeLeaseRequest systemLeasesRevokeLeaseRequest)

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
    public class UpdateSystemLeasesRevokeUrlLeaseIdExample
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
            var systemLeasesRevokeLeaseRequest = new SystemLeasesRevokeLeaseRequest(); // SystemLeasesRevokeLeaseRequest | 

            try
            {
                // Revokes a lease immediately.
                apiInstance.UpdateSystemLeasesRevokeUrlLeaseId(urlLeaseId, systemLeasesRevokeLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemLeasesRevokeUrlLeaseId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlLeaseId** | **string**| The lease identifier to renew. This is included with a lease. | 
 **systemLeasesRevokeLeaseRequest** | [**SystemLeasesRevokeLeaseRequest**](SystemLeasesRevokeLeaseRequest.md)|  | 

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

<a name="updatesystemleasestidy"></a>
# **UpdateSystemLeasesTidy**
> void UpdateSystemLeasesTidy ()

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
    public class UpdateSystemLeasesTidyExample
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
                apiInstance.UpdateSystemLeasesTidy();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemLeasesTidy: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="updatesystemloggers"></a>
# **UpdateSystemLoggers**
> void UpdateSystemLoggers (SystemLoggersRequest systemLoggersRequest)

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
    public class UpdateSystemLoggersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemLoggersRequest = new SystemLoggersRequest(); // SystemLoggersRequest | 

            try
            {
                // Modify the log level for all existing loggers.
                apiInstance.UpdateSystemLoggers(systemLoggersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemLoggers: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemLoggersRequest** | [**SystemLoggersRequest**](SystemLoggersRequest.md)|  | 

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

<a name="updatesystemloggersname"></a>
# **UpdateSystemLoggersName**
> void UpdateSystemLoggersName (string name, SystemLoggersRequest systemLoggersRequest)

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
    public class UpdateSystemLoggersNameExample
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
            var systemLoggersRequest = new SystemLoggersRequest(); // SystemLoggersRequest | 

            try
            {
                // Modify the log level of a single logger.
                apiInstance.UpdateSystemLoggersName(name, systemLoggersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemLoggersName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the logger to be modified. | 
 **systemLoggersRequest** | [**SystemLoggersRequest**](SystemLoggersRequest.md)|  | 

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

<a name="updatesystemmfavalidate"></a>
# **UpdateSystemMfaValidate**
> void UpdateSystemMfaValidate (SystemMfaValidateRequest systemMfaValidateRequest)

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
    public class UpdateSystemMfaValidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemMfaValidateRequest = new SystemMfaValidateRequest(); // SystemMfaValidateRequest | 

            try
            {
                // Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token
                apiInstance.UpdateSystemMfaValidate(systemMfaValidateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemMfaValidate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemMfaValidateRequest** | [**SystemMfaValidateRequest**](SystemMfaValidateRequest.md)|  | 

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

<a name="updatesystemmountspath"></a>
# **UpdateSystemMountsPath**
> void UpdateSystemMountsPath (string path, SystemMountsRequest systemMountsRequest)

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
    public class UpdateSystemMountsPathExample
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
            var systemMountsRequest = new SystemMountsRequest(); // SystemMountsRequest | 

            try
            {
                // Enable a new secrets engine at the given path.
                apiInstance.UpdateSystemMountsPath(path, systemMountsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemMountsPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to mount to. Example: \&quot;aws/east\&quot; | 
 **systemMountsRequest** | [**SystemMountsRequest**](SystemMountsRequest.md)|  | 

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

<a name="updatesystemmountspathtune"></a>
# **UpdateSystemMountsPathTune**
> void UpdateSystemMountsPathTune (string path, SystemMountsTuneRequest systemMountsTuneRequest)

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
    public class UpdateSystemMountsPathTuneExample
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
            var systemMountsTuneRequest = new SystemMountsTuneRequest(); // SystemMountsTuneRequest | 

            try
            {
                // Tune backend configuration parameters for this mount.
                apiInstance.UpdateSystemMountsPathTune(path, systemMountsTuneRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemMountsPathTune: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| The path to mount to. Example: \&quot;aws/east\&quot; | 
 **systemMountsTuneRequest** | [**SystemMountsTuneRequest**](SystemMountsTuneRequest.md)|  | 

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

<a name="updatesystempluginscatalogname"></a>
# **UpdateSystemPluginsCatalogName**
> void UpdateSystemPluginsCatalogName (string name, SystemPluginsCatalogRequest systemPluginsCatalogRequest)

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
    public class UpdateSystemPluginsCatalogNameExample
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
            var systemPluginsCatalogRequest = new SystemPluginsCatalogRequest(); // SystemPluginsCatalogRequest | 

            try
            {
                // Register a new plugin, or updates an existing one with the supplied name.
                apiInstance.UpdateSystemPluginsCatalogName(name, systemPluginsCatalogRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemPluginsCatalogName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the plugin | 
 **systemPluginsCatalogRequest** | [**SystemPluginsCatalogRequest**](SystemPluginsCatalogRequest.md)|  | 

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

<a name="updatesystempluginscatalogtypename"></a>
# **UpdateSystemPluginsCatalogTypeName**
> void UpdateSystemPluginsCatalogTypeName (string name, string type, SystemPluginsCatalogRequest systemPluginsCatalogRequest)

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
    public class UpdateSystemPluginsCatalogTypeNameExample
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
            var systemPluginsCatalogRequest = new SystemPluginsCatalogRequest(); // SystemPluginsCatalogRequest | 

            try
            {
                // Register a new plugin, or updates an existing one with the supplied name.
                apiInstance.UpdateSystemPluginsCatalogTypeName(name, type, systemPluginsCatalogRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemPluginsCatalogTypeName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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
 **systemPluginsCatalogRequest** | [**SystemPluginsCatalogRequest**](SystemPluginsCatalogRequest.md)|  | 

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

<a name="updatesystempluginsreloadbackend"></a>
# **UpdateSystemPluginsReloadBackend**
> void UpdateSystemPluginsReloadBackend (SystemPluginsReloadBackendRequest systemPluginsReloadBackendRequest)

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
    public class UpdateSystemPluginsReloadBackendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemPluginsReloadBackendRequest = new SystemPluginsReloadBackendRequest(); // SystemPluginsReloadBackendRequest | 

            try
            {
                // Reload mounted plugin backends.
                apiInstance.UpdateSystemPluginsReloadBackend(systemPluginsReloadBackendRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemPluginsReloadBackend: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemPluginsReloadBackendRequest** | [**SystemPluginsReloadBackendRequest**](SystemPluginsReloadBackendRequest.md)|  | 

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

<a name="updatesystempoliciesaclname"></a>
# **UpdateSystemPoliciesAclName**
> void UpdateSystemPoliciesAclName (string name, SystemPoliciesAclRequest systemPoliciesAclRequest)

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
    public class UpdateSystemPoliciesAclNameExample
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
            var systemPoliciesAclRequest = new SystemPoliciesAclRequest(); // SystemPoliciesAclRequest | 

            try
            {
                // Add a new or update an existing ACL policy.
                apiInstance.UpdateSystemPoliciesAclName(name, systemPoliciesAclRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemPoliciesAclName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the policy. Example: \&quot;ops\&quot; | 
 **systemPoliciesAclRequest** | [**SystemPoliciesAclRequest**](SystemPoliciesAclRequest.md)|  | 

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

<a name="updatesystempoliciespasswordname"></a>
# **UpdateSystemPoliciesPasswordName**
> void UpdateSystemPoliciesPasswordName (string name, SystemPoliciesPasswordRequest systemPoliciesPasswordRequest)

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
    public class UpdateSystemPoliciesPasswordNameExample
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
            var systemPoliciesPasswordRequest = new SystemPoliciesPasswordRequest(); // SystemPoliciesPasswordRequest | 

            try
            {
                // Add a new or update an existing password policy.
                apiInstance.UpdateSystemPoliciesPasswordName(name, systemPoliciesPasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemPoliciesPasswordName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the password policy. | 
 **systemPoliciesPasswordRequest** | [**SystemPoliciesPasswordRequest**](SystemPoliciesPasswordRequest.md)|  | 

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

<a name="updatesystempolicyname"></a>
# **UpdateSystemPolicyName**
> void UpdateSystemPolicyName (string name, SystemPolicyRequest systemPolicyRequest)

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
    public class UpdateSystemPolicyNameExample
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
            var systemPolicyRequest = new SystemPolicyRequest(); // SystemPolicyRequest | 

            try
            {
                // Add a new or update an existing policy.
                apiInstance.UpdateSystemPolicyName(name, systemPolicyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemPolicyName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The name of the policy. Example: \&quot;ops\&quot; | 
 **systemPolicyRequest** | [**SystemPolicyRequest**](SystemPolicyRequest.md)|  | 

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

<a name="updatesystemquotasconfig"></a>
# **UpdateSystemQuotasConfig**
> void UpdateSystemQuotasConfig (SystemQuotasConfigRequest systemQuotasConfigRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateSystemQuotasConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemQuotasConfigRequest = new SystemQuotasConfigRequest(); // SystemQuotasConfigRequest | 

            try
            {
                apiInstance.UpdateSystemQuotasConfig(systemQuotasConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemQuotasConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemQuotasConfigRequest** | [**SystemQuotasConfigRequest**](SystemQuotasConfigRequest.md)|  | 

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

<a name="updatesystemquotasratelimitname"></a>
# **UpdateSystemQuotasRateLimitName**
> void UpdateSystemQuotasRateLimitName (string name, SystemQuotasRateLimitRequest systemQuotasRateLimitRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateSystemQuotasRateLimitNameExample
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
            var systemQuotasRateLimitRequest = new SystemQuotasRateLimitRequest(); // SystemQuotasRateLimitRequest | 

            try
            {
                apiInstance.UpdateSystemQuotasRateLimitName(name, systemQuotasRateLimitRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemQuotasRateLimitName: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Name of the quota rule. | 
 **systemQuotasRateLimitRequest** | [**SystemQuotasRateLimitRequest**](SystemQuotasRateLimitRequest.md)|  | 

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

<a name="updatesystemraw"></a>
# **UpdateSystemRaw**
> void UpdateSystemRaw (SystemRawRequest systemRawRequest)

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
    public class UpdateSystemRawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRawRequest = new SystemRawRequest(); // SystemRawRequest | 

            try
            {
                // Update the value of the key at the given path.
                apiInstance.UpdateSystemRaw(systemRawRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRaw: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemRawRequest** | [**SystemRawRequest**](SystemRawRequest.md)|  | 

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

<a name="updatesystemrawpath"></a>
# **UpdateSystemRawPath**
> void UpdateSystemRawPath (string path, SystemRawRequest systemRawRequest)

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
    public class UpdateSystemRawPathExample
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
            var systemRawRequest = new SystemRawRequest(); // SystemRawRequest | 

            try
            {
                // Update the value of the key at the given path.
                apiInstance.UpdateSystemRawPath(path, systemRawRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRawPath: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**|  | 
 **systemRawRequest** | [**SystemRawRequest**](SystemRawRequest.md)|  | 

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

<a name="updatesystemrekeyinit"></a>
# **UpdateSystemRekeyInit**
> void UpdateSystemRekeyInit (SystemRekeyInitRequest systemRekeyInitRequest)

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
    public class UpdateSystemRekeyInitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRekeyInitRequest = new SystemRekeyInitRequest(); // SystemRekeyInitRequest | 

            try
            {
                // Initializes a new rekey attempt.
                apiInstance.UpdateSystemRekeyInit(systemRekeyInitRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRekeyInit: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemRekeyInitRequest** | [**SystemRekeyInitRequest**](SystemRekeyInitRequest.md)|  | 

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

<a name="updatesystemrekeyupdate"></a>
# **UpdateSystemRekeyUpdate**
> void UpdateSystemRekeyUpdate (SystemRekeyUpdateRequest systemRekeyUpdateRequest)

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
    public class UpdateSystemRekeyUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRekeyUpdateRequest = new SystemRekeyUpdateRequest(); // SystemRekeyUpdateRequest | 

            try
            {
                // Enter a single unseal key share to progress the rekey of the Vault.
                apiInstance.UpdateSystemRekeyUpdate(systemRekeyUpdateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRekeyUpdate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemRekeyUpdateRequest** | [**SystemRekeyUpdateRequest**](SystemRekeyUpdateRequest.md)|  | 

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

<a name="updatesystemrekeyverify"></a>
# **UpdateSystemRekeyVerify**
> void UpdateSystemRekeyVerify (SystemRekeyVerifyRequest systemRekeyVerifyRequest)

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
    public class UpdateSystemRekeyVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRekeyVerifyRequest = new SystemRekeyVerifyRequest(); // SystemRekeyVerifyRequest | 

            try
            {
                // Enter a single new key share to progress the rekey verification operation.
                apiInstance.UpdateSystemRekeyVerify(systemRekeyVerifyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRekeyVerify: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemRekeyVerifyRequest** | [**SystemRekeyVerifyRequest**](SystemRekeyVerifyRequest.md)|  | 

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

<a name="updatesystemremount"></a>
# **UpdateSystemRemount**
> void UpdateSystemRemount (SystemRemountRequest systemRemountRequest)

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
    public class UpdateSystemRemountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRemountRequest = new SystemRemountRequest(); // SystemRemountRequest | 

            try
            {
                // Initiate a mount migration
                apiInstance.UpdateSystemRemount(systemRemountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRemount: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemRemountRequest** | [**SystemRemountRequest**](SystemRemountRequest.md)|  | 

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

<a name="updatesystemrenew"></a>
# **UpdateSystemRenew**
> void UpdateSystemRenew (SystemRenewRequest systemRenewRequest)

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
    public class UpdateSystemRenewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRenewRequest = new SystemRenewRequest(); // SystemRenewRequest | 

            try
            {
                // Renews a lease, requesting to extend the lease.
                apiInstance.UpdateSystemRenew(systemRenewRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRenew: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemRenewRequest** | [**SystemRenewRequest**](SystemRenewRequest.md)|  | 

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

<a name="updatesystemrenewurlleaseid"></a>
# **UpdateSystemRenewUrlLeaseId**
> void UpdateSystemRenewUrlLeaseId (string urlLeaseId, SystemRenewLeaseRequest systemRenewLeaseRequest)

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
    public class UpdateSystemRenewUrlLeaseIdExample
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
            var systemRenewLeaseRequest = new SystemRenewLeaseRequest(); // SystemRenewLeaseRequest | 

            try
            {
                // Renews a lease, requesting to extend the lease.
                apiInstance.UpdateSystemRenewUrlLeaseId(urlLeaseId, systemRenewLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRenewUrlLeaseId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlLeaseId** | **string**| The lease identifier to renew. This is included with a lease. | 
 **systemRenewLeaseRequest** | [**SystemRenewLeaseRequest**](SystemRenewLeaseRequest.md)|  | 

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

<a name="updatesystemrevoke"></a>
# **UpdateSystemRevoke**
> void UpdateSystemRevoke (SystemRevokeRequest systemRevokeRequest)

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
    public class UpdateSystemRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRevokeRequest = new SystemRevokeRequest(); // SystemRevokeRequest | 

            try
            {
                // Revokes a lease immediately.
                apiInstance.UpdateSystemRevoke(systemRevokeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRevoke: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemRevokeRequest** | [**SystemRevokeRequest**](SystemRevokeRequest.md)|  | 

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

<a name="updatesystemrevokeforceprefix"></a>
# **UpdateSystemRevokeForcePrefix**
> void UpdateSystemRevokeForcePrefix (string prefix)

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
    public class UpdateSystemRevokeForcePrefixExample
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
                apiInstance.UpdateSystemRevokeForcePrefix(prefix);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRevokeForcePrefix: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="updatesystemrevokeprefixprefix"></a>
# **UpdateSystemRevokePrefixPrefix**
> void UpdateSystemRevokePrefixPrefix (string prefix, SystemRevokePrefixRequest systemRevokePrefixRequest)

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
    public class UpdateSystemRevokePrefixPrefixExample
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
            var systemRevokePrefixRequest = new SystemRevokePrefixRequest(); // SystemRevokePrefixRequest | 

            try
            {
                // Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.
                apiInstance.UpdateSystemRevokePrefixPrefix(prefix, systemRevokePrefixRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRevokePrefixPrefix: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **prefix** | **string**| The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot; | 
 **systemRevokePrefixRequest** | [**SystemRevokePrefixRequest**](SystemRevokePrefixRequest.md)|  | 

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

<a name="updatesystemrevokeurlleaseid"></a>
# **UpdateSystemRevokeUrlLeaseId**
> void UpdateSystemRevokeUrlLeaseId (string urlLeaseId, SystemRevokeLeaseRequest systemRevokeLeaseRequest)

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
    public class UpdateSystemRevokeUrlLeaseIdExample
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
            var systemRevokeLeaseRequest = new SystemRevokeLeaseRequest(); // SystemRevokeLeaseRequest | 

            try
            {
                // Revokes a lease immediately.
                apiInstance.UpdateSystemRevokeUrlLeaseId(urlLeaseId, systemRevokeLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRevokeUrlLeaseId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlLeaseId** | **string**| The lease identifier to renew. This is included with a lease. | 
 **systemRevokeLeaseRequest** | [**SystemRevokeLeaseRequest**](SystemRevokeLeaseRequest.md)|  | 

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

<a name="updatesystemrotate"></a>
# **UpdateSystemRotate**
> void UpdateSystemRotate ()

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
    public class UpdateSystemRotateExample
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
                apiInstance.UpdateSystemRotate();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRotate: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="updatesystemrotateconfig"></a>
# **UpdateSystemRotateConfig**
> void UpdateSystemRotateConfig (SystemRotateConfigRequest systemRotateConfigRequest)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Vault.Api;
using Vault.Client;
using Vault.Model;

namespace Example
{
    public class UpdateSystemRotateConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRotateConfigRequest = new SystemRotateConfigRequest(); // SystemRotateConfigRequest | 

            try
            {
                apiInstance.UpdateSystemRotateConfig(systemRotateConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemRotateConfig: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemRotateConfigRequest** | [**SystemRotateConfigRequest**](SystemRotateConfigRequest.md)|  | 

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

<a name="updatesystemseal"></a>
# **UpdateSystemSeal**
> void UpdateSystemSeal ()

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
    public class UpdateSystemSealExample
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
                apiInstance.UpdateSystemSeal();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemSeal: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="updatesystemstepdown"></a>
# **UpdateSystemStepDown**
> void UpdateSystemStepDown ()

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
    public class UpdateSystemStepDownExample
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
                apiInstance.UpdateSystemStepDown();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemStepDown: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

<a name="updatesystemtoolshash"></a>
# **UpdateSystemToolsHash**
> void UpdateSystemToolsHash (SystemToolsHashRequest systemToolsHashRequest)

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
    public class UpdateSystemToolsHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemToolsHashRequest = new SystemToolsHashRequest(); // SystemToolsHashRequest | 

            try
            {
                // Generate a hash sum for input data
                apiInstance.UpdateSystemToolsHash(systemToolsHashRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemToolsHash: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemToolsHashRequest** | [**SystemToolsHashRequest**](SystemToolsHashRequest.md)|  | 

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

<a name="updatesystemtoolshashurlalgorithm"></a>
# **UpdateSystemToolsHashUrlalgorithm**
> void UpdateSystemToolsHashUrlalgorithm (string urlalgorithm, SystemToolsHashRequest systemToolsHashRequest)

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
    public class UpdateSystemToolsHashUrlalgorithmExample
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
            var systemToolsHashRequest = new SystemToolsHashRequest(); // SystemToolsHashRequest | 

            try
            {
                // Generate a hash sum for input data
                apiInstance.UpdateSystemToolsHashUrlalgorithm(urlalgorithm, systemToolsHashRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemToolsHashUrlalgorithm: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlalgorithm** | **string**| Algorithm to use (POST URL parameter) | 
 **systemToolsHashRequest** | [**SystemToolsHashRequest**](SystemToolsHashRequest.md)|  | 

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

<a name="updatesystemtoolsrandom"></a>
# **UpdateSystemToolsRandom**
> void UpdateSystemToolsRandom (SystemToolsRandomRequest systemToolsRandomRequest)

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
    public class UpdateSystemToolsRandomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemToolsRandomRequest = new SystemToolsRandomRequest(); // SystemToolsRandomRequest | 

            try
            {
                // Generate random bytes
                apiInstance.UpdateSystemToolsRandom(systemToolsRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemToolsRandom: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemToolsRandomRequest** | [**SystemToolsRandomRequest**](SystemToolsRandomRequest.md)|  | 

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

<a name="updatesystemtoolsrandomsource"></a>
# **UpdateSystemToolsRandomSource**
> void UpdateSystemToolsRandomSource (string source, SystemToolsRandomRequest systemToolsRandomRequest)

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
    public class UpdateSystemToolsRandomSourceExample
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
            var systemToolsRandomRequest = new SystemToolsRandomRequest(); // SystemToolsRandomRequest | 

            try
            {
                // Generate random bytes
                apiInstance.UpdateSystemToolsRandomSource(source, systemToolsRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemToolsRandomSource: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **source** | **string**| Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;. | [default to &quot;platform&quot;]
 **systemToolsRandomRequest** | [**SystemToolsRandomRequest**](SystemToolsRandomRequest.md)|  | 

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

<a name="updatesystemtoolsrandomsourceurlbytes"></a>
# **UpdateSystemToolsRandomSourceUrlbytes**
> void UpdateSystemToolsRandomSourceUrlbytes (string source, string urlbytes, SystemToolsRandomRequest systemToolsRandomRequest)

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
    public class UpdateSystemToolsRandomSourceUrlbytesExample
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
            var systemToolsRandomRequest = new SystemToolsRandomRequest(); // SystemToolsRandomRequest | 

            try
            {
                // Generate random bytes
                apiInstance.UpdateSystemToolsRandomSourceUrlbytes(source, urlbytes, systemToolsRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemToolsRandomSourceUrlbytes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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
 **systemToolsRandomRequest** | [**SystemToolsRandomRequest**](SystemToolsRandomRequest.md)|  | 

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

<a name="updatesystemtoolsrandomurlbytes"></a>
# **UpdateSystemToolsRandomUrlbytes**
> void UpdateSystemToolsRandomUrlbytes (string urlbytes, SystemToolsRandomRequest systemToolsRandomRequest)

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
    public class UpdateSystemToolsRandomUrlbytesExample
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
            var systemToolsRandomRequest = new SystemToolsRandomRequest(); // SystemToolsRandomRequest | 

            try
            {
                // Generate random bytes
                apiInstance.UpdateSystemToolsRandomUrlbytes(urlbytes, systemToolsRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemToolsRandomUrlbytes: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **urlbytes** | **string**| The number of bytes to generate (POST URL parameter) | 
 **systemToolsRandomRequest** | [**SystemToolsRandomRequest**](SystemToolsRandomRequest.md)|  | 

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

<a name="updatesystemunseal"></a>
# **UpdateSystemUnseal**
> void UpdateSystemUnseal (SystemUnsealRequest systemUnsealRequest)

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
    public class UpdateSystemUnsealExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemUnsealRequest = new SystemUnsealRequest(); // SystemUnsealRequest | 

            try
            {
                // Unseal the Vault.
                apiInstance.UpdateSystemUnseal(systemUnsealRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemUnseal: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemUnsealRequest** | [**SystemUnsealRequest**](SystemUnsealRequest.md)|  | 

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

<a name="updatesystemwrappinglookup"></a>
# **UpdateSystemWrappingLookup**
> void UpdateSystemWrappingLookup (SystemWrappingLookupRequest systemWrappingLookupRequest)

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
    public class UpdateSystemWrappingLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemWrappingLookupRequest = new SystemWrappingLookupRequest(); // SystemWrappingLookupRequest | 

            try
            {
                // Look up wrapping properties for the given token.
                apiInstance.UpdateSystemWrappingLookup(systemWrappingLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemWrappingLookup: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemWrappingLookupRequest** | [**SystemWrappingLookupRequest**](SystemWrappingLookupRequest.md)|  | 

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

<a name="updatesystemwrappingrewrap"></a>
# **UpdateSystemWrappingRewrap**
> void UpdateSystemWrappingRewrap (SystemWrappingRewrapRequest systemWrappingRewrapRequest)

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
    public class UpdateSystemWrappingRewrapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemWrappingRewrapRequest = new SystemWrappingRewrapRequest(); // SystemWrappingRewrapRequest | 

            try
            {
                // Rotates a response-wrapped token.
                apiInstance.UpdateSystemWrappingRewrap(systemWrappingRewrapRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemWrappingRewrap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemWrappingRewrapRequest** | [**SystemWrappingRewrapRequest**](SystemWrappingRewrapRequest.md)|  | 

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

<a name="updatesystemwrappingunwrap"></a>
# **UpdateSystemWrappingUnwrap**
> void UpdateSystemWrappingUnwrap (SystemWrappingUnwrapRequest systemWrappingUnwrapRequest)

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
    public class UpdateSystemWrappingUnwrapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemWrappingUnwrapRequest = new SystemWrappingUnwrapRequest(); // SystemWrappingUnwrapRequest | 

            try
            {
                // Unwraps a response-wrapped token.
                apiInstance.UpdateSystemWrappingUnwrap(systemWrappingUnwrapRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemWrappingUnwrap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **systemWrappingUnwrapRequest** | [**SystemWrappingUnwrapRequest**](SystemWrappingUnwrapRequest.md)|  | 

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

<a name="updatesystemwrappingwrap"></a>
# **UpdateSystemWrappingWrap**
> void UpdateSystemWrappingWrap ()

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
    public class UpdateSystemWrappingWrapExample
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
                apiInstance.UpdateSystemWrappingWrap();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.UpdateSystemWrappingWrap: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
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

