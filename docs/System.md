# VaultClient.Api.System

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSysAuditPath**](System.md#deletesysauditpath) | **DELETE** /sys/audit/{path} | Disable the audit device at the given path.
[**DeleteSysAuthPath**](System.md#deletesysauthpath) | **DELETE** /sys/auth/{path} | Disable the auth method at the given auth path
[**DeleteSysConfigAuditingRequestHeadersHeader**](System.md#deletesysconfigauditingrequestheadersheader) | **DELETE** /sys/config/auditing/request-headers/{header} | Disable auditing of the given request header.
[**DeleteSysConfigCors**](System.md#deletesysconfigcors) | **DELETE** /sys/config/cors | Remove any CORS settings.
[**DeleteSysConfigUiHeadersHeader**](System.md#deletesysconfiguiheadersheader) | **DELETE** /sys/config/ui/headers/{header} | Remove a UI header.
[**DeleteSysGenerateRoot**](System.md#deletesysgenerateroot) | **DELETE** /sys/generate-root | Cancels any in-progress root generation attempt.
[**DeleteSysGenerateRootAttempt**](System.md#deletesysgeneraterootattempt) | **DELETE** /sys/generate-root/attempt | Cancels any in-progress root generation attempt.
[**DeleteSysMountsPath**](System.md#deletesysmountspath) | **DELETE** /sys/mounts/{path} | Disable the mount point specified at the given path.
[**DeleteSysPluginsCatalogName**](System.md#deletesyspluginscatalogname) | **DELETE** /sys/plugins/catalog/{name} | Remove the plugin with the given name.
[**DeleteSysPluginsCatalogTypeName**](System.md#deletesyspluginscatalogtypename) | **DELETE** /sys/plugins/catalog/{type}/{name} | Remove the plugin with the given name.
[**DeleteSysPoliciesAclName**](System.md#deletesyspoliciesaclname) | **DELETE** /sys/policies/acl/{name} | Delete the ACL policy with the given name.
[**DeleteSysPoliciesPasswordName**](System.md#deletesyspoliciespasswordname) | **DELETE** /sys/policies/password/{name} | Delete a password policy.
[**DeleteSysPolicyName**](System.md#deletesyspolicyname) | **DELETE** /sys/policy/{name} | Delete the policy with the given name.
[**DeleteSysQuotasRateLimitName**](System.md#deletesysquotasratelimitname) | **DELETE** /sys/quotas/rate-limit/{name} | 
[**DeleteSysRaw**](System.md#deletesysraw) | **DELETE** /sys/raw | Delete the key with given path.
[**DeleteSysRawPath**](System.md#deletesysrawpath) | **DELETE** /sys/raw/{path} | Delete the key with given path.
[**DeleteSysRekeyBackup**](System.md#deletesysrekeybackup) | **DELETE** /sys/rekey/backup | Delete the backup copy of PGP-encrypted unseal keys.
[**DeleteSysRekeyInit**](System.md#deletesysrekeyinit) | **DELETE** /sys/rekey/init | Cancels any in-progress rekey.
[**DeleteSysRekeyRecoveryKeyBackup**](System.md#deletesysrekeyrecoverykeybackup) | **DELETE** /sys/rekey/recovery-key-backup | Allows fetching or deleting the backup of the rotated unseal keys.
[**DeleteSysRekeyVerify**](System.md#deletesysrekeyverify) | **DELETE** /sys/rekey/verify | Cancel any in-progress rekey verification operation.
[**GetSysAudit**](System.md#getsysaudit) | **GET** /sys/audit | List the enabled audit devices.
[**GetSysAuth**](System.md#getsysauth) | **GET** /sys/auth | List the currently enabled credential backends.
[**GetSysAuthPath**](System.md#getsysauthpath) | **GET** /sys/auth/{path} | Read the configuration of the auth engine at the given path.
[**GetSysAuthPathTune**](System.md#getsysauthpathtune) | **GET** /sys/auth/{path}/tune | Reads the given auth path&#39;s configuration.
[**GetSysConfigAuditingRequestHeaders**](System.md#getsysconfigauditingrequestheaders) | **GET** /sys/config/auditing/request-headers | List the request headers that are configured to be audited.
[**GetSysConfigAuditingRequestHeadersHeader**](System.md#getsysconfigauditingrequestheadersheader) | **GET** /sys/config/auditing/request-headers/{header} | List the information for the given request header.
[**GetSysConfigCors**](System.md#getsysconfigcors) | **GET** /sys/config/cors | Return the current CORS settings.
[**GetSysConfigStateSanitized**](System.md#getsysconfigstatesanitized) | **GET** /sys/config/state/sanitized | Return a sanitized version of the Vault server configuration.
[**GetSysConfigUiHeaders**](System.md#getsysconfiguiheaders) | **GET** /sys/config/ui/headers/ | Return a list of configured UI headers.
[**GetSysConfigUiHeadersHeader**](System.md#getsysconfiguiheadersheader) | **GET** /sys/config/ui/headers/{header} | Return the given UI header&#39;s configuration
[**GetSysGenerateRoot**](System.md#getsysgenerateroot) | **GET** /sys/generate-root | Read the configuration and progress of the current root generation attempt.
[**GetSysGenerateRootAttempt**](System.md#getsysgeneraterootattempt) | **GET** /sys/generate-root/attempt | Read the configuration and progress of the current root generation attempt.
[**GetSysHaStatus**](System.md#getsyshastatus) | **GET** /sys/ha-status | Check the HA status of a Vault cluster
[**GetSysHealth**](System.md#getsyshealth) | **GET** /sys/health | Returns the health status of Vault.
[**GetSysHostInfo**](System.md#getsyshostinfo) | **GET** /sys/host-info | Information about the host instance that this Vault server is running on.
[**GetSysInFlightReq**](System.md#getsysinflightreq) | **GET** /sys/in-flight-req | reports in-flight requests
[**GetSysInit**](System.md#getsysinit) | **GET** /sys/init | Returns the initialization status of Vault.
[**GetSysInternalCountersActivity**](System.md#getsysinternalcountersactivity) | **GET** /sys/internal/counters/activity | Report the client count metrics, for this namespace and all child namespaces.
[**GetSysInternalCountersActivityExport**](System.md#getsysinternalcountersactivityexport) | **GET** /sys/internal/counters/activity/export | Report the client count metrics, for this namespace and all child namespaces.
[**GetSysInternalCountersActivityMonthly**](System.md#getsysinternalcountersactivitymonthly) | **GET** /sys/internal/counters/activity/monthly | Report the number of clients for this month, for this namespace and all child namespaces.
[**GetSysInternalCountersConfig**](System.md#getsysinternalcountersconfig) | **GET** /sys/internal/counters/config | Read the client count tracking configuration.
[**GetSysInternalCountersEntities**](System.md#getsysinternalcountersentities) | **GET** /sys/internal/counters/entities | Backwards compatibility is not guaranteed for this API
[**GetSysInternalCountersRequests**](System.md#getsysinternalcountersrequests) | **GET** /sys/internal/counters/requests | Backwards compatibility is not guaranteed for this API
[**GetSysInternalCountersTokens**](System.md#getsysinternalcounterstokens) | **GET** /sys/internal/counters/tokens | Backwards compatibility is not guaranteed for this API
[**GetSysInternalSpecsOpenapi**](System.md#getsysinternalspecsopenapi) | **GET** /sys/internal/specs/openapi | Generate an OpenAPI 3 document of all mounted paths.
[**GetSysInternalUiFeatureFlags**](System.md#getsysinternaluifeatureflags) | **GET** /sys/internal/ui/feature-flags | Lists enabled feature flags.
[**GetSysInternalUiMounts**](System.md#getsysinternaluimounts) | **GET** /sys/internal/ui/mounts | Lists all enabled and visible auth and secrets mounts.
[**GetSysInternalUiMountsPath**](System.md#getsysinternaluimountspath) | **GET** /sys/internal/ui/mounts/{path} | Return information about the given mount.
[**GetSysInternalUiNamespaces**](System.md#getsysinternaluinamespaces) | **GET** /sys/internal/ui/namespaces | Backwards compatibility is not guaranteed for this API
[**GetSysInternalUiResultantAcl**](System.md#getsysinternaluiresultantacl) | **GET** /sys/internal/ui/resultant-acl | Backwards compatibility is not guaranteed for this API
[**GetSysKeyStatus**](System.md#getsyskeystatus) | **GET** /sys/key-status | Provides information about the backend encryption key.
[**GetSysLeader**](System.md#getsysleader) | **GET** /sys/leader | Returns the high availability status and current leader instance of Vault.
[**GetSysLeases**](System.md#getsysleases) | **GET** /sys/leases | List leases associated with this Vault cluster
[**GetSysLeasesCount**](System.md#getsysleasescount) | **GET** /sys/leases/count | Count of leases associated with this Vault cluster
[**GetSysLeasesLookup**](System.md#getsysleaseslookup) | **GET** /sys/leases/lookup/ | Returns a list of lease ids.
[**GetSysLeasesLookupPrefix**](System.md#getsysleaseslookupprefix) | **GET** /sys/leases/lookup/{prefix} | Returns a list of lease ids.
[**GetSysMetrics**](System.md#getsysmetrics) | **GET** /sys/metrics | Export the metrics aggregated for telemetry purpose.
[**GetSysMonitor**](System.md#getsysmonitor) | **GET** /sys/monitor | 
[**GetSysMounts**](System.md#getsysmounts) | **GET** /sys/mounts | List the currently mounted backends.
[**GetSysMountsPath**](System.md#getsysmountspath) | **GET** /sys/mounts/{path} | Read the configuration of the secret engine at the given path.
[**GetSysMountsPathTune**](System.md#getsysmountspathtune) | **GET** /sys/mounts/{path}/tune | Tune backend configuration parameters for this mount.
[**GetSysPluginsCatalog**](System.md#getsyspluginscatalog) | **GET** /sys/plugins/catalog | Lists all the plugins known to Vault
[**GetSysPluginsCatalogName**](System.md#getsyspluginscatalogname) | **GET** /sys/plugins/catalog/{name} | Return the configuration data for the plugin with the given name.
[**GetSysPluginsCatalogType**](System.md#getsyspluginscatalogtype) | **GET** /sys/plugins/catalog/{type} | List the plugins in the catalog.
[**GetSysPluginsCatalogTypeName**](System.md#getsyspluginscatalogtypename) | **GET** /sys/plugins/catalog/{type}/{name} | Return the configuration data for the plugin with the given name.
[**GetSysPoliciesAcl**](System.md#getsyspoliciesacl) | **GET** /sys/policies/acl | List the configured access control policies.
[**GetSysPoliciesAclName**](System.md#getsyspoliciesaclname) | **GET** /sys/policies/acl/{name} | Retrieve information about the named ACL policy.
[**GetSysPoliciesPassword**](System.md#getsyspoliciespassword) | **GET** /sys/policies/password | List the existing password policies.
[**GetSysPoliciesPasswordName**](System.md#getsyspoliciespasswordname) | **GET** /sys/policies/password/{name} | Retrieve an existing password policy.
[**GetSysPoliciesPasswordNameGenerate**](System.md#getsyspoliciespasswordnamegenerate) | **GET** /sys/policies/password/{name}/generate | Generate a password from an existing password policy.
[**GetSysPolicy**](System.md#getsyspolicy) | **GET** /sys/policy | List the configured access control policies.
[**GetSysPolicyName**](System.md#getsyspolicyname) | **GET** /sys/policy/{name} | Retrieve the policy body for the named policy.
[**GetSysPprof**](System.md#getsyspprof) | **GET** /sys/pprof/ | Returns an HTML page listing the available profiles.
[**GetSysPprofAllocs**](System.md#getsyspprofallocs) | **GET** /sys/pprof/allocs | Returns a sampling of all past memory allocations.
[**GetSysPprofBlock**](System.md#getsyspprofblock) | **GET** /sys/pprof/block | Returns stack traces that led to blocking on synchronization primitives
[**GetSysPprofCmdline**](System.md#getsyspprofcmdline) | **GET** /sys/pprof/cmdline | Returns the running program&#39;s command line.
[**GetSysPprofGoroutine**](System.md#getsyspprofgoroutine) | **GET** /sys/pprof/goroutine | Returns stack traces of all current goroutines.
[**GetSysPprofHeap**](System.md#getsyspprofheap) | **GET** /sys/pprof/heap | Returns a sampling of memory allocations of live object.
[**GetSysPprofMutex**](System.md#getsyspprofmutex) | **GET** /sys/pprof/mutex | Returns stack traces of holders of contended mutexes
[**GetSysPprofProfile**](System.md#getsyspprofprofile) | **GET** /sys/pprof/profile | Returns a pprof-formatted cpu profile payload.
[**GetSysPprofSymbol**](System.md#getsyspprofsymbol) | **GET** /sys/pprof/symbol | Returns the program counters listed in the request.
[**GetSysPprofThreadcreate**](System.md#getsyspprofthreadcreate) | **GET** /sys/pprof/threadcreate | Returns stack traces that led to the creation of new OS threads
[**GetSysPprofTrace**](System.md#getsyspproftrace) | **GET** /sys/pprof/trace | Returns the execution trace in binary form.
[**GetSysQuotasConfig**](System.md#getsysquotasconfig) | **GET** /sys/quotas/config | 
[**GetSysQuotasRateLimit**](System.md#getsysquotasratelimit) | **GET** /sys/quotas/rate-limit | 
[**GetSysQuotasRateLimitName**](System.md#getsysquotasratelimitname) | **GET** /sys/quotas/rate-limit/{name} | 
[**GetSysRaw**](System.md#getsysraw) | **GET** /sys/raw | Read the value of the key at the given path.
[**GetSysRawPath**](System.md#getsysrawpath) | **GET** /sys/raw/{path} | Read the value of the key at the given path.
[**GetSysRekeyBackup**](System.md#getsysrekeybackup) | **GET** /sys/rekey/backup | Return the backup copy of PGP-encrypted unseal keys.
[**GetSysRekeyInit**](System.md#getsysrekeyinit) | **GET** /sys/rekey/init | Reads the configuration and progress of the current rekey attempt.
[**GetSysRekeyRecoveryKeyBackup**](System.md#getsysrekeyrecoverykeybackup) | **GET** /sys/rekey/recovery-key-backup | Allows fetching or deleting the backup of the rotated unseal keys.
[**GetSysRekeyVerify**](System.md#getsysrekeyverify) | **GET** /sys/rekey/verify | Read the configuration and progress of the current rekey verification attempt.
[**GetSysRemountStatusMigrationId**](System.md#getsysremountstatusmigrationid) | **GET** /sys/remount/status/{migration_id} | Check status of a mount migration
[**GetSysReplicationStatus**](System.md#getsysreplicationstatus) | **GET** /sys/replication/status | 
[**GetSysRotateConfig**](System.md#getsysrotateconfig) | **GET** /sys/rotate/config | 
[**GetSysSealStatus**](System.md#getsyssealstatus) | **GET** /sys/seal-status | Check the seal status of a Vault.
[**GetSysVersionHistory**](System.md#getsysversionhistory) | **GET** /sys/version-history/ | Returns map of historical version change entries
[**GetSysWrappingLookup**](System.md#getsyswrappinglookup) | **GET** /sys/wrapping/lookup | Look up wrapping properties for the requester&#39;s token.
[**PostSysAuditHashPath**](System.md#postsysaudithashpath) | **POST** /sys/audit-hash/{path} | The hash of the given string via the given audit backend
[**PostSysAuditPath**](System.md#postsysauditpath) | **POST** /sys/audit/{path} | Enable a new audit device at the supplied path.
[**PostSysAuthPath**](System.md#postsysauthpath) | **POST** /sys/auth/{path} | Enables a new auth method.
[**PostSysAuthPathTune**](System.md#postsysauthpathtune) | **POST** /sys/auth/{path}/tune | Tune configuration parameters for a given auth path.
[**PostSysCapabilities**](System.md#postsyscapabilities) | **POST** /sys/capabilities | Fetches the capabilities of the given token on the given path.
[**PostSysCapabilitiesAccessor**](System.md#postsyscapabilitiesaccessor) | **POST** /sys/capabilities-accessor | Fetches the capabilities of the token associated with the given token, on the given path.
[**PostSysCapabilitiesSelf**](System.md#postsyscapabilitiesself) | **POST** /sys/capabilities-self | Fetches the capabilities of the given token on the given path.
[**PostSysConfigAuditingRequestHeadersHeader**](System.md#postsysconfigauditingrequestheadersheader) | **POST** /sys/config/auditing/request-headers/{header} | Enable auditing of a header.
[**PostSysConfigCors**](System.md#postsysconfigcors) | **POST** /sys/config/cors | Configure the CORS settings.
[**PostSysConfigReloadSubsystem**](System.md#postsysconfigreloadsubsystem) | **POST** /sys/config/reload/{subsystem} | Reload the given subsystem
[**PostSysConfigUiHeadersHeader**](System.md#postsysconfiguiheadersheader) | **POST** /sys/config/ui/headers/{header} | Configure the values to be returned for the UI header.
[**PostSysGenerateRoot**](System.md#postsysgenerateroot) | **POST** /sys/generate-root | Initializes a new root generation attempt.
[**PostSysGenerateRootAttempt**](System.md#postsysgeneraterootattempt) | **POST** /sys/generate-root/attempt | Initializes a new root generation attempt.
[**PostSysGenerateRootUpdate**](System.md#postsysgeneraterootupdate) | **POST** /sys/generate-root/update | Enter a single unseal key share to progress the root generation attempt.
[**PostSysInit**](System.md#postsysinit) | **POST** /sys/init | Initialize a new Vault.
[**PostSysInternalCountersConfig**](System.md#postsysinternalcountersconfig) | **POST** /sys/internal/counters/config | Enable or disable collection of client count, set retention period, or set default reporting period.
[**PostSysLeasesLookup**](System.md#postsysleaseslookup) | **POST** /sys/leases/lookup | Retrieve lease metadata.
[**PostSysLeasesRenew**](System.md#postsysleasesrenew) | **POST** /sys/leases/renew | Renews a lease, requesting to extend the lease.
[**PostSysLeasesRenewUrlLeaseId**](System.md#postsysleasesrenewurlleaseid) | **POST** /sys/leases/renew/{url_lease_id} | Renews a lease, requesting to extend the lease.
[**PostSysLeasesRevoke**](System.md#postsysleasesrevoke) | **POST** /sys/leases/revoke | Revokes a lease immediately.
[**PostSysLeasesRevokeForcePrefix**](System.md#postsysleasesrevokeforceprefix) | **POST** /sys/leases/revoke-force/{prefix} | Revokes all secrets or tokens generated under a given prefix immediately
[**PostSysLeasesRevokePrefixPrefix**](System.md#postsysleasesrevokeprefixprefix) | **POST** /sys/leases/revoke-prefix/{prefix} | Revokes all secrets (via a lease ID prefix) or tokens (via the tokens&#39; path property) generated under a given prefix immediately.
[**PostSysLeasesRevokeUrlLeaseId**](System.md#postsysleasesrevokeurlleaseid) | **POST** /sys/leases/revoke/{url_lease_id} | Revokes a lease immediately.
[**PostSysLeasesTidy**](System.md#postsysleasestidy) | **POST** /sys/leases/tidy | This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.
[**PostSysMfaValidate**](System.md#postsysmfavalidate) | **POST** /sys/mfa/validate | Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token
[**PostSysMountsPath**](System.md#postsysmountspath) | **POST** /sys/mounts/{path} | Enable a new secrets engine at the given path.
[**PostSysMountsPathTune**](System.md#postsysmountspathtune) | **POST** /sys/mounts/{path}/tune | Tune backend configuration parameters for this mount.
[**PostSysPluginsCatalogName**](System.md#postsyspluginscatalogname) | **POST** /sys/plugins/catalog/{name} | Register a new plugin, or updates an existing one with the supplied name.
[**PostSysPluginsCatalogTypeName**](System.md#postsyspluginscatalogtypename) | **POST** /sys/plugins/catalog/{type}/{name} | Register a new plugin, or updates an existing one with the supplied name.
[**PostSysPluginsReloadBackend**](System.md#postsyspluginsreloadbackend) | **POST** /sys/plugins/reload/backend | Reload mounted plugin backends.
[**PostSysPoliciesAclName**](System.md#postsyspoliciesaclname) | **POST** /sys/policies/acl/{name} | Add a new or update an existing ACL policy.
[**PostSysPoliciesPasswordName**](System.md#postsyspoliciespasswordname) | **POST** /sys/policies/password/{name} | Add a new or update an existing password policy.
[**PostSysPolicyName**](System.md#postsyspolicyname) | **POST** /sys/policy/{name} | Add a new or update an existing policy.
[**PostSysQuotasConfig**](System.md#postsysquotasconfig) | **POST** /sys/quotas/config | 
[**PostSysQuotasRateLimitName**](System.md#postsysquotasratelimitname) | **POST** /sys/quotas/rate-limit/{name} | 
[**PostSysRaw**](System.md#postsysraw) | **POST** /sys/raw | Update the value of the key at the given path.
[**PostSysRawPath**](System.md#postsysrawpath) | **POST** /sys/raw/{path} | Update the value of the key at the given path.
[**PostSysRekeyInit**](System.md#postsysrekeyinit) | **POST** /sys/rekey/init | Initializes a new rekey attempt.
[**PostSysRekeyUpdate**](System.md#postsysrekeyupdate) | **POST** /sys/rekey/update | Enter a single unseal key share to progress the rekey of the Vault.
[**PostSysRekeyVerify**](System.md#postsysrekeyverify) | **POST** /sys/rekey/verify | Enter a single new key share to progress the rekey verification operation.
[**PostSysRemount**](System.md#postsysremount) | **POST** /sys/remount | Initiate a mount migration
[**PostSysRenew**](System.md#postsysrenew) | **POST** /sys/renew | Renews a lease, requesting to extend the lease.
[**PostSysRenewUrlLeaseId**](System.md#postsysrenewurlleaseid) | **POST** /sys/renew/{url_lease_id} | Renews a lease, requesting to extend the lease.
[**PostSysRevoke**](System.md#postsysrevoke) | **POST** /sys/revoke | Revokes a lease immediately.
[**PostSysRevokeForcePrefix**](System.md#postsysrevokeforceprefix) | **POST** /sys/revoke-force/{prefix} | Revokes all secrets or tokens generated under a given prefix immediately
[**PostSysRevokePrefixPrefix**](System.md#postsysrevokeprefixprefix) | **POST** /sys/revoke-prefix/{prefix} | Revokes all secrets (via a lease ID prefix) or tokens (via the tokens&#39; path property) generated under a given prefix immediately.
[**PostSysRevokeUrlLeaseId**](System.md#postsysrevokeurlleaseid) | **POST** /sys/revoke/{url_lease_id} | Revokes a lease immediately.
[**PostSysRotate**](System.md#postsysrotate) | **POST** /sys/rotate | Rotates the backend encryption key used to persist data.
[**PostSysRotateConfig**](System.md#postsysrotateconfig) | **POST** /sys/rotate/config | 
[**PostSysSeal**](System.md#postsysseal) | **POST** /sys/seal | Seal the Vault.
[**PostSysStepDown**](System.md#postsysstepdown) | **POST** /sys/step-down | Cause the node to give up active status.
[**PostSysToolsHash**](System.md#postsystoolshash) | **POST** /sys/tools/hash | Generate a hash sum for input data
[**PostSysToolsHashUrlalgorithm**](System.md#postsystoolshashurlalgorithm) | **POST** /sys/tools/hash/{urlalgorithm} | Generate a hash sum for input data
[**PostSysToolsRandom**](System.md#postsystoolsrandom) | **POST** /sys/tools/random | Generate random bytes
[**PostSysToolsRandomSource**](System.md#postsystoolsrandomsource) | **POST** /sys/tools/random/{source} | Generate random bytes
[**PostSysToolsRandomSourceUrlbytes**](System.md#postsystoolsrandomsourceurlbytes) | **POST** /sys/tools/random/{source}/{urlbytes} | Generate random bytes
[**PostSysToolsRandomUrlbytes**](System.md#postsystoolsrandomurlbytes) | **POST** /sys/tools/random/{urlbytes} | Generate random bytes
[**PostSysUnseal**](System.md#postsysunseal) | **POST** /sys/unseal | Unseal the Vault.
[**PostSysWrappingLookup**](System.md#postsyswrappinglookup) | **POST** /sys/wrapping/lookup | Look up wrapping properties for the given token.
[**PostSysWrappingRewrap**](System.md#postsyswrappingrewrap) | **POST** /sys/wrapping/rewrap | Rotates a response-wrapped token.
[**PostSysWrappingUnwrap**](System.md#postsyswrappingunwrap) | **POST** /sys/wrapping/unwrap | Unwraps a response-wrapped token.
[**PostSysWrappingWrap**](System.md#postsyswrappingwrap) | **POST** /sys/wrapping/wrap | Response-wraps an arbitrary JSON object.


<a name="deletesysauditpath"></a>
# **DeleteSysAuditPath**
> void DeleteSysAuditPath (string path)

Disable the audit device at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysAuditPathExample
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
                apiInstance.DeleteSysAuditPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysAuditPath: " + e.Message );
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

<a name="deletesysauthpath"></a>
# **DeleteSysAuthPath**
> void DeleteSysAuthPath (string path)

Disable the auth method at the given auth path

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysAuthPathExample
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
                apiInstance.DeleteSysAuthPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysAuthPath: " + e.Message );
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

<a name="deletesysconfigauditingrequestheadersheader"></a>
# **DeleteSysConfigAuditingRequestHeadersHeader**
> void DeleteSysConfigAuditingRequestHeadersHeader (string header)

Disable auditing of the given request header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysConfigAuditingRequestHeadersHeaderExample
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
                apiInstance.DeleteSysConfigAuditingRequestHeadersHeader(header);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysConfigAuditingRequestHeadersHeader: " + e.Message );
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

<a name="deletesysconfigcors"></a>
# **DeleteSysConfigCors**
> void DeleteSysConfigCors ()

Remove any CORS settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysConfigCorsExample
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
                apiInstance.DeleteSysConfigCors();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysConfigCors: " + e.Message );
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

<a name="deletesysconfiguiheadersheader"></a>
# **DeleteSysConfigUiHeadersHeader**
> void DeleteSysConfigUiHeadersHeader (string header)

Remove a UI header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysConfigUiHeadersHeaderExample
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
                apiInstance.DeleteSysConfigUiHeadersHeader(header);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysConfigUiHeadersHeader: " + e.Message );
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

<a name="deletesysgenerateroot"></a>
# **DeleteSysGenerateRoot**
> void DeleteSysGenerateRoot ()

Cancels any in-progress root generation attempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysGenerateRootExample
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
                apiInstance.DeleteSysGenerateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysGenerateRoot: " + e.Message );
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

<a name="deletesysgeneraterootattempt"></a>
# **DeleteSysGenerateRootAttempt**
> void DeleteSysGenerateRootAttempt ()

Cancels any in-progress root generation attempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysGenerateRootAttemptExample
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
                apiInstance.DeleteSysGenerateRootAttempt();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysGenerateRootAttempt: " + e.Message );
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

<a name="deletesysmountspath"></a>
# **DeleteSysMountsPath**
> void DeleteSysMountsPath (string path)

Disable the mount point specified at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysMountsPathExample
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
                apiInstance.DeleteSysMountsPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysMountsPath: " + e.Message );
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

<a name="deletesyspluginscatalogname"></a>
# **DeleteSysPluginsCatalogName**
> void DeleteSysPluginsCatalogName (string name)

Remove the plugin with the given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysPluginsCatalogNameExample
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
                apiInstance.DeleteSysPluginsCatalogName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysPluginsCatalogName: " + e.Message );
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

<a name="deletesyspluginscatalogtypename"></a>
# **DeleteSysPluginsCatalogTypeName**
> void DeleteSysPluginsCatalogTypeName (string name, string type)

Remove the plugin with the given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysPluginsCatalogTypeNameExample
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
                apiInstance.DeleteSysPluginsCatalogTypeName(name, type);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysPluginsCatalogTypeName: " + e.Message );
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

<a name="deletesyspoliciesaclname"></a>
# **DeleteSysPoliciesAclName**
> void DeleteSysPoliciesAclName (string name)

Delete the ACL policy with the given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysPoliciesAclNameExample
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
                apiInstance.DeleteSysPoliciesAclName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysPoliciesAclName: " + e.Message );
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

<a name="deletesyspoliciespasswordname"></a>
# **DeleteSysPoliciesPasswordName**
> void DeleteSysPoliciesPasswordName (string name)

Delete a password policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysPoliciesPasswordNameExample
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
                apiInstance.DeleteSysPoliciesPasswordName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysPoliciesPasswordName: " + e.Message );
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

<a name="deletesyspolicyname"></a>
# **DeleteSysPolicyName**
> void DeleteSysPolicyName (string name)

Delete the policy with the given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysPolicyNameExample
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
                apiInstance.DeleteSysPolicyName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysPolicyName: " + e.Message );
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

<a name="deletesysquotasratelimitname"></a>
# **DeleteSysQuotasRateLimitName**
> void DeleteSysQuotasRateLimitName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysQuotasRateLimitNameExample
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
                apiInstance.DeleteSysQuotasRateLimitName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysQuotasRateLimitName: " + e.Message );
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

<a name="deletesysraw"></a>
# **DeleteSysRaw**
> void DeleteSysRaw ()

Delete the key with given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysRawExample
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
                apiInstance.DeleteSysRaw();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysRaw: " + e.Message );
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

<a name="deletesysrawpath"></a>
# **DeleteSysRawPath**
> void DeleteSysRawPath (string path)

Delete the key with given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysRawPathExample
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
                apiInstance.DeleteSysRawPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysRawPath: " + e.Message );
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

<a name="deletesysrekeybackup"></a>
# **DeleteSysRekeyBackup**
> void DeleteSysRekeyBackup ()

Delete the backup copy of PGP-encrypted unseal keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysRekeyBackupExample
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
                apiInstance.DeleteSysRekeyBackup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysRekeyBackup: " + e.Message );
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

<a name="deletesysrekeyinit"></a>
# **DeleteSysRekeyInit**
> void DeleteSysRekeyInit ()

Cancels any in-progress rekey.

This clears the rekey settings as well as any progress made. This must be called to change the parameters of the rekey. Note: verification is still a part of a rekey. If rekeying is canceled during the verification flow, the current unseal keys remain valid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysRekeyInitExample
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
                apiInstance.DeleteSysRekeyInit();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysRekeyInit: " + e.Message );
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

<a name="deletesysrekeyrecoverykeybackup"></a>
# **DeleteSysRekeyRecoveryKeyBackup**
> void DeleteSysRekeyRecoveryKeyBackup ()

Allows fetching or deleting the backup of the rotated unseal keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysRekeyRecoveryKeyBackupExample
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
                apiInstance.DeleteSysRekeyRecoveryKeyBackup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysRekeyRecoveryKeyBackup: " + e.Message );
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

<a name="deletesysrekeyverify"></a>
# **DeleteSysRekeyVerify**
> void DeleteSysRekeyVerify ()

Cancel any in-progress rekey verification operation.

This clears any progress made and resets the nonce. Unlike a `DELETE` against `sys/rekey/init`, this only resets the current verification operation, not the entire rekey atttempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class DeleteSysRekeyVerifyExample
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
                apiInstance.DeleteSysRekeyVerify();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.DeleteSysRekeyVerify: " + e.Message );
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

<a name="getsysaudit"></a>
# **GetSysAudit**
> void GetSysAudit ()

List the enabled audit devices.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysAuditExample
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
                apiInstance.GetSysAudit();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysAudit: " + e.Message );
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

<a name="getsysauth"></a>
# **GetSysAuth**
> void GetSysAuth ()

List the currently enabled credential backends.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysAuthExample
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
                apiInstance.GetSysAuth();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysAuth: " + e.Message );
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

<a name="getsysauthpath"></a>
# **GetSysAuthPath**
> void GetSysAuthPath (string path)

Read the configuration of the auth engine at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysAuthPathExample
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
                apiInstance.GetSysAuthPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysAuthPath: " + e.Message );
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

<a name="getsysauthpathtune"></a>
# **GetSysAuthPathTune**
> void GetSysAuthPathTune (string path)

Reads the given auth path's configuration.

This endpoint requires sudo capability on the final path, but the same functionality can be achieved without sudo via `sys/mounts/auth/[auth-path]/tune`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysAuthPathTuneExample
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
                apiInstance.GetSysAuthPathTune(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysAuthPathTune: " + e.Message );
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

<a name="getsysconfigauditingrequestheaders"></a>
# **GetSysConfigAuditingRequestHeaders**
> void GetSysConfigAuditingRequestHeaders ()

List the request headers that are configured to be audited.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysConfigAuditingRequestHeadersExample
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
                apiInstance.GetSysConfigAuditingRequestHeaders();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysConfigAuditingRequestHeaders: " + e.Message );
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

<a name="getsysconfigauditingrequestheadersheader"></a>
# **GetSysConfigAuditingRequestHeadersHeader**
> void GetSysConfigAuditingRequestHeadersHeader (string header)

List the information for the given request header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysConfigAuditingRequestHeadersHeaderExample
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
                apiInstance.GetSysConfigAuditingRequestHeadersHeader(header);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysConfigAuditingRequestHeadersHeader: " + e.Message );
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

<a name="getsysconfigcors"></a>
# **GetSysConfigCors**
> void GetSysConfigCors ()

Return the current CORS settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysConfigCorsExample
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
                apiInstance.GetSysConfigCors();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysConfigCors: " + e.Message );
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

<a name="getsysconfigstatesanitized"></a>
# **GetSysConfigStateSanitized**
> void GetSysConfigStateSanitized ()

Return a sanitized version of the Vault server configuration.

The sanitized output strips configuration values in the storage, HA storage, and seals stanzas, which may contain sensitive values such as API tokens. It also removes any token or secret fields in other stanzas, such as the circonus_api_token from telemetry.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysConfigStateSanitizedExample
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
                apiInstance.GetSysConfigStateSanitized();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysConfigStateSanitized: " + e.Message );
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

<a name="getsysconfiguiheaders"></a>
# **GetSysConfigUiHeaders**
> void GetSysConfigUiHeaders (string list)

Return a list of configured UI headers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysConfigUiHeadersExample
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
                apiInstance.GetSysConfigUiHeaders(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysConfigUiHeaders: " + e.Message );
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

<a name="getsysconfiguiheadersheader"></a>
# **GetSysConfigUiHeadersHeader**
> void GetSysConfigUiHeadersHeader (string header)

Return the given UI header's configuration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysConfigUiHeadersHeaderExample
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
                apiInstance.GetSysConfigUiHeadersHeader(header);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysConfigUiHeadersHeader: " + e.Message );
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

<a name="getsysgenerateroot"></a>
# **GetSysGenerateRoot**
> void GetSysGenerateRoot ()

Read the configuration and progress of the current root generation attempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysGenerateRootExample
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
                apiInstance.GetSysGenerateRoot();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysGenerateRoot: " + e.Message );
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

<a name="getsysgeneraterootattempt"></a>
# **GetSysGenerateRootAttempt**
> void GetSysGenerateRootAttempt ()

Read the configuration and progress of the current root generation attempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysGenerateRootAttemptExample
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
                apiInstance.GetSysGenerateRootAttempt();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysGenerateRootAttempt: " + e.Message );
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

<a name="getsyshastatus"></a>
# **GetSysHaStatus**
> void GetSysHaStatus ()

Check the HA status of a Vault cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysHaStatusExample
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
                apiInstance.GetSysHaStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysHaStatus: " + e.Message );
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

<a name="getsyshealth"></a>
# **GetSysHealth**
> void GetSysHealth ()

Returns the health status of Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysHealthExample
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
                apiInstance.GetSysHealth();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysHealth: " + e.Message );
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

<a name="getsyshostinfo"></a>
# **GetSysHostInfo**
> void GetSysHostInfo ()

Information about the host instance that this Vault server is running on.

Information about the host instance that this Vault server is running on.   The information that gets collected includes host hardware information, and CPU,   disk, and memory utilization

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysHostInfoExample
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
                apiInstance.GetSysHostInfo();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysHostInfo: " + e.Message );
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

<a name="getsysinflightreq"></a>
# **GetSysInFlightReq**
> void GetSysInFlightReq ()

reports in-flight requests

This path responds to the following HTTP methods.   GET /    Returns a map of in-flight requests.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInFlightReqExample
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
                apiInstance.GetSysInFlightReq();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInFlightReq: " + e.Message );
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

<a name="getsysinit"></a>
# **GetSysInit**
> void GetSysInit ()

Returns the initialization status of Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInitExample
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
                apiInstance.GetSysInit();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInit: " + e.Message );
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

<a name="getsysinternalcountersactivity"></a>
# **GetSysInternalCountersActivity**
> void GetSysInternalCountersActivity ()

Report the client count metrics, for this namespace and all child namespaces.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalCountersActivityExample
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
                apiInstance.GetSysInternalCountersActivity();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalCountersActivity: " + e.Message );
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

<a name="getsysinternalcountersactivityexport"></a>
# **GetSysInternalCountersActivityExport**
> void GetSysInternalCountersActivityExport ()

Report the client count metrics, for this namespace and all child namespaces.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalCountersActivityExportExample
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
                apiInstance.GetSysInternalCountersActivityExport();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalCountersActivityExport: " + e.Message );
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

<a name="getsysinternalcountersactivitymonthly"></a>
# **GetSysInternalCountersActivityMonthly**
> void GetSysInternalCountersActivityMonthly ()

Report the number of clients for this month, for this namespace and all child namespaces.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalCountersActivityMonthlyExample
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
                apiInstance.GetSysInternalCountersActivityMonthly();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalCountersActivityMonthly: " + e.Message );
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

<a name="getsysinternalcountersconfig"></a>
# **GetSysInternalCountersConfig**
> void GetSysInternalCountersConfig ()

Read the client count tracking configuration.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalCountersConfigExample
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
                apiInstance.GetSysInternalCountersConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalCountersConfig: " + e.Message );
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

<a name="getsysinternalcountersentities"></a>
# **GetSysInternalCountersEntities**
> void GetSysInternalCountersEntities ()

Backwards compatibility is not guaranteed for this API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalCountersEntitiesExample
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
                apiInstance.GetSysInternalCountersEntities();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalCountersEntities: " + e.Message );
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

<a name="getsysinternalcountersrequests"></a>
# **GetSysInternalCountersRequests**
> void GetSysInternalCountersRequests ()

Backwards compatibility is not guaranteed for this API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalCountersRequestsExample
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
                apiInstance.GetSysInternalCountersRequests();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalCountersRequests: " + e.Message );
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

<a name="getsysinternalcounterstokens"></a>
# **GetSysInternalCountersTokens**
> void GetSysInternalCountersTokens ()

Backwards compatibility is not guaranteed for this API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalCountersTokensExample
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
                apiInstance.GetSysInternalCountersTokens();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalCountersTokens: " + e.Message );
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

<a name="getsysinternalspecsopenapi"></a>
# **GetSysInternalSpecsOpenapi**
> void GetSysInternalSpecsOpenapi ()

Generate an OpenAPI 3 document of all mounted paths.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalSpecsOpenapiExample
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
                apiInstance.GetSysInternalSpecsOpenapi();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalSpecsOpenapi: " + e.Message );
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

<a name="getsysinternaluifeatureflags"></a>
# **GetSysInternalUiFeatureFlags**
> void GetSysInternalUiFeatureFlags ()

Lists enabled feature flags.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalUiFeatureFlagsExample
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
                apiInstance.GetSysInternalUiFeatureFlags();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalUiFeatureFlags: " + e.Message );
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

<a name="getsysinternaluimounts"></a>
# **GetSysInternalUiMounts**
> void GetSysInternalUiMounts ()

Lists all enabled and visible auth and secrets mounts.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalUiMountsExample
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
                apiInstance.GetSysInternalUiMounts();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalUiMounts: " + e.Message );
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

<a name="getsysinternaluimountspath"></a>
# **GetSysInternalUiMountsPath**
> void GetSysInternalUiMountsPath (string path)

Return information about the given mount.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalUiMountsPathExample
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
                apiInstance.GetSysInternalUiMountsPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalUiMountsPath: " + e.Message );
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

<a name="getsysinternaluinamespaces"></a>
# **GetSysInternalUiNamespaces**
> void GetSysInternalUiNamespaces ()

Backwards compatibility is not guaranteed for this API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalUiNamespacesExample
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
                apiInstance.GetSysInternalUiNamespaces();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalUiNamespaces: " + e.Message );
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

<a name="getsysinternaluiresultantacl"></a>
# **GetSysInternalUiResultantAcl**
> void GetSysInternalUiResultantAcl ()

Backwards compatibility is not guaranteed for this API

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysInternalUiResultantAclExample
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
                apiInstance.GetSysInternalUiResultantAcl();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysInternalUiResultantAcl: " + e.Message );
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

<a name="getsyskeystatus"></a>
# **GetSysKeyStatus**
> void GetSysKeyStatus ()

Provides information about the backend encryption key.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysKeyStatusExample
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
                apiInstance.GetSysKeyStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysKeyStatus: " + e.Message );
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

<a name="getsysleader"></a>
# **GetSysLeader**
> void GetSysLeader ()

Returns the high availability status and current leader instance of Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysLeaderExample
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
                apiInstance.GetSysLeader();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysLeader: " + e.Message );
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

<a name="getsysleases"></a>
# **GetSysLeases**
> void GetSysLeases ()

List leases associated with this Vault cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysLeasesExample
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
                apiInstance.GetSysLeases();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysLeases: " + e.Message );
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

<a name="getsysleasescount"></a>
# **GetSysLeasesCount**
> void GetSysLeasesCount ()

Count of leases associated with this Vault cluster

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysLeasesCountExample
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
                apiInstance.GetSysLeasesCount();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysLeasesCount: " + e.Message );
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

<a name="getsysleaseslookup"></a>
# **GetSysLeasesLookup**
> void GetSysLeasesLookup (string list)

Returns a list of lease ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysLeasesLookupExample
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
                apiInstance.GetSysLeasesLookup(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysLeasesLookup: " + e.Message );
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

<a name="getsysleaseslookupprefix"></a>
# **GetSysLeasesLookupPrefix**
> void GetSysLeasesLookupPrefix (string prefix, string list)

Returns a list of lease ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysLeasesLookupPrefixExample
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
                apiInstance.GetSysLeasesLookupPrefix(prefix, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysLeasesLookupPrefix: " + e.Message );
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

<a name="getsysmetrics"></a>
# **GetSysMetrics**
> void GetSysMetrics (string format = null)

Export the metrics aggregated for telemetry purpose.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysMetricsExample
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
                apiInstance.GetSysMetrics(format);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysMetrics: " + e.Message );
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

<a name="getsysmonitor"></a>
# **GetSysMonitor**
> void GetSysMonitor (string logFormat = null, string logLevel = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysMonitorExample
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
                apiInstance.GetSysMonitor(logFormat, logLevel);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysMonitor: " + e.Message );
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

<a name="getsysmounts"></a>
# **GetSysMounts**
> void GetSysMounts ()

List the currently mounted backends.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysMountsExample
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
                apiInstance.GetSysMounts();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysMounts: " + e.Message );
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

<a name="getsysmountspath"></a>
# **GetSysMountsPath**
> void GetSysMountsPath (string path)

Read the configuration of the secret engine at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysMountsPathExample
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
                apiInstance.GetSysMountsPath(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysMountsPath: " + e.Message );
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

<a name="getsysmountspathtune"></a>
# **GetSysMountsPathTune**
> void GetSysMountsPathTune (string path)

Tune backend configuration parameters for this mount.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysMountsPathTuneExample
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
                apiInstance.GetSysMountsPathTune(path);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysMountsPathTune: " + e.Message );
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

<a name="getsyspluginscatalog"></a>
# **GetSysPluginsCatalog**
> void GetSysPluginsCatalog ()

Lists all the plugins known to Vault

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPluginsCatalogExample
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
                apiInstance.GetSysPluginsCatalog();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPluginsCatalog: " + e.Message );
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

<a name="getsyspluginscatalogname"></a>
# **GetSysPluginsCatalogName**
> void GetSysPluginsCatalogName (string name)

Return the configuration data for the plugin with the given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPluginsCatalogNameExample
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
                apiInstance.GetSysPluginsCatalogName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPluginsCatalogName: " + e.Message );
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

<a name="getsyspluginscatalogtype"></a>
# **GetSysPluginsCatalogType**
> void GetSysPluginsCatalogType (string type, string list)

List the plugins in the catalog.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPluginsCatalogTypeExample
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
                apiInstance.GetSysPluginsCatalogType(type, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPluginsCatalogType: " + e.Message );
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

<a name="getsyspluginscatalogtypename"></a>
# **GetSysPluginsCatalogTypeName**
> void GetSysPluginsCatalogTypeName (string name, string type)

Return the configuration data for the plugin with the given name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPluginsCatalogTypeNameExample
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
                apiInstance.GetSysPluginsCatalogTypeName(name, type);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPluginsCatalogTypeName: " + e.Message );
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

<a name="getsyspoliciesacl"></a>
# **GetSysPoliciesAcl**
> void GetSysPoliciesAcl (string list)

List the configured access control policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPoliciesAclExample
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
                apiInstance.GetSysPoliciesAcl(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPoliciesAcl: " + e.Message );
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

<a name="getsyspoliciesaclname"></a>
# **GetSysPoliciesAclName**
> void GetSysPoliciesAclName (string name)

Retrieve information about the named ACL policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPoliciesAclNameExample
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
                apiInstance.GetSysPoliciesAclName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPoliciesAclName: " + e.Message );
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

<a name="getsyspoliciespassword"></a>
# **GetSysPoliciesPassword**
> void GetSysPoliciesPassword (string list)

List the existing password policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPoliciesPasswordExample
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
                apiInstance.GetSysPoliciesPassword(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPoliciesPassword: " + e.Message );
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

<a name="getsyspoliciespasswordname"></a>
# **GetSysPoliciesPasswordName**
> void GetSysPoliciesPasswordName (string name)

Retrieve an existing password policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPoliciesPasswordNameExample
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
                apiInstance.GetSysPoliciesPasswordName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPoliciesPasswordName: " + e.Message );
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

<a name="getsyspoliciespasswordnamegenerate"></a>
# **GetSysPoliciesPasswordNameGenerate**
> void GetSysPoliciesPasswordNameGenerate (string name)

Generate a password from an existing password policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPoliciesPasswordNameGenerateExample
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
                apiInstance.GetSysPoliciesPasswordNameGenerate(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPoliciesPasswordNameGenerate: " + e.Message );
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

<a name="getsyspolicy"></a>
# **GetSysPolicy**
> void GetSysPolicy (string list = null)

List the configured access control policies.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPolicyExample
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
                apiInstance.GetSysPolicy(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPolicy: " + e.Message );
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

<a name="getsyspolicyname"></a>
# **GetSysPolicyName**
> void GetSysPolicyName (string name)

Retrieve the policy body for the named policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPolicyNameExample
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
                apiInstance.GetSysPolicyName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPolicyName: " + e.Message );
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

<a name="getsyspprof"></a>
# **GetSysPprof**
> void GetSysPprof ()

Returns an HTML page listing the available profiles.

Returns an HTML page listing the available  profiles. This should be mainly accessed via browsers or applications that can  render pages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPprofExample
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
                apiInstance.GetSysPprof();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPprof: " + e.Message );
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

<a name="getsyspprofallocs"></a>
# **GetSysPprofAllocs**
> void GetSysPprofAllocs ()

Returns a sampling of all past memory allocations.

Returns a sampling of all past memory allocations.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPprofAllocsExample
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
                apiInstance.GetSysPprofAllocs();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPprofAllocs: " + e.Message );
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

<a name="getsyspprofblock"></a>
# **GetSysPprofBlock**
> void GetSysPprofBlock ()

Returns stack traces that led to blocking on synchronization primitives

Returns stack traces that led to blocking on synchronization primitives

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPprofBlockExample
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
                apiInstance.GetSysPprofBlock();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPprofBlock: " + e.Message );
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

<a name="getsyspprofcmdline"></a>
# **GetSysPprofCmdline**
> void GetSysPprofCmdline ()

Returns the running program's command line.

Returns the running program's command line, with arguments separated by NUL bytes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPprofCmdlineExample
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
                apiInstance.GetSysPprofCmdline();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPprofCmdline: " + e.Message );
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

<a name="getsyspprofgoroutine"></a>
# **GetSysPprofGoroutine**
> void GetSysPprofGoroutine ()

Returns stack traces of all current goroutines.

Returns stack traces of all current goroutines.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPprofGoroutineExample
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
                apiInstance.GetSysPprofGoroutine();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPprofGoroutine: " + e.Message );
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

<a name="getsyspprofheap"></a>
# **GetSysPprofHeap**
> void GetSysPprofHeap ()

Returns a sampling of memory allocations of live object.

Returns a sampling of memory allocations of live object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPprofHeapExample
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
                apiInstance.GetSysPprofHeap();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPprofHeap: " + e.Message );
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

<a name="getsyspprofmutex"></a>
# **GetSysPprofMutex**
> void GetSysPprofMutex ()

Returns stack traces of holders of contended mutexes

Returns stack traces of holders of contended mutexes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPprofMutexExample
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
                apiInstance.GetSysPprofMutex();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPprofMutex: " + e.Message );
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

<a name="getsyspprofprofile"></a>
# **GetSysPprofProfile**
> void GetSysPprofProfile ()

Returns a pprof-formatted cpu profile payload.

Returns a pprof-formatted cpu profile payload. Profiling lasts for duration specified in seconds GET parameter, or for 30 seconds if not specified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPprofProfileExample
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
                apiInstance.GetSysPprofProfile();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPprofProfile: " + e.Message );
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

<a name="getsyspprofsymbol"></a>
# **GetSysPprofSymbol**
> void GetSysPprofSymbol ()

Returns the program counters listed in the request.

Returns the program counters listed in the request.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPprofSymbolExample
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
                apiInstance.GetSysPprofSymbol();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPprofSymbol: " + e.Message );
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

<a name="getsyspprofthreadcreate"></a>
# **GetSysPprofThreadcreate**
> void GetSysPprofThreadcreate ()

Returns stack traces that led to the creation of new OS threads

Returns stack traces that led to the creation of new OS threads

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPprofThreadcreateExample
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
                apiInstance.GetSysPprofThreadcreate();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPprofThreadcreate: " + e.Message );
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

<a name="getsyspproftrace"></a>
# **GetSysPprofTrace**
> void GetSysPprofTrace ()

Returns the execution trace in binary form.

Returns  the execution trace in binary form. Tracing lasts for duration specified in seconds GET parameter, or for 1 second if not specified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysPprofTraceExample
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
                apiInstance.GetSysPprofTrace();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysPprofTrace: " + e.Message );
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

<a name="getsysquotasconfig"></a>
# **GetSysQuotasConfig**
> void GetSysQuotasConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysQuotasConfigExample
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
                apiInstance.GetSysQuotasConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysQuotasConfig: " + e.Message );
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

<a name="getsysquotasratelimit"></a>
# **GetSysQuotasRateLimit**
> void GetSysQuotasRateLimit (string list)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysQuotasRateLimitExample
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
                apiInstance.GetSysQuotasRateLimit(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysQuotasRateLimit: " + e.Message );
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

<a name="getsysquotasratelimitname"></a>
# **GetSysQuotasRateLimitName**
> void GetSysQuotasRateLimitName (string name)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysQuotasRateLimitNameExample
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
                apiInstance.GetSysQuotasRateLimitName(name);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysQuotasRateLimitName: " + e.Message );
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

<a name="getsysraw"></a>
# **GetSysRaw**
> void GetSysRaw (string list = null)

Read the value of the key at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysRawExample
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
                apiInstance.GetSysRaw(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysRaw: " + e.Message );
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

<a name="getsysrawpath"></a>
# **GetSysRawPath**
> void GetSysRawPath (string path, string list = null)

Read the value of the key at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysRawPathExample
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
                apiInstance.GetSysRawPath(path, list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysRawPath: " + e.Message );
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

<a name="getsysrekeybackup"></a>
# **GetSysRekeyBackup**
> void GetSysRekeyBackup ()

Return the backup copy of PGP-encrypted unseal keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysRekeyBackupExample
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
                apiInstance.GetSysRekeyBackup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysRekeyBackup: " + e.Message );
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

<a name="getsysrekeyinit"></a>
# **GetSysRekeyInit**
> void GetSysRekeyInit ()

Reads the configuration and progress of the current rekey attempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysRekeyInitExample
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
                apiInstance.GetSysRekeyInit();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysRekeyInit: " + e.Message );
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

<a name="getsysrekeyrecoverykeybackup"></a>
# **GetSysRekeyRecoveryKeyBackup**
> void GetSysRekeyRecoveryKeyBackup ()

Allows fetching or deleting the backup of the rotated unseal keys.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysRekeyRecoveryKeyBackupExample
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
                apiInstance.GetSysRekeyRecoveryKeyBackup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysRekeyRecoveryKeyBackup: " + e.Message );
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

<a name="getsysrekeyverify"></a>
# **GetSysRekeyVerify**
> void GetSysRekeyVerify ()

Read the configuration and progress of the current rekey verification attempt.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysRekeyVerifyExample
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
                apiInstance.GetSysRekeyVerify();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysRekeyVerify: " + e.Message );
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

<a name="getsysremountstatusmigrationid"></a>
# **GetSysRemountStatusMigrationId**
> void GetSysRemountStatusMigrationId (string migrationId)

Check status of a mount migration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysRemountStatusMigrationIdExample
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
                apiInstance.GetSysRemountStatusMigrationId(migrationId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysRemountStatusMigrationId: " + e.Message );
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

<a name="getsysreplicationstatus"></a>
# **GetSysReplicationStatus**
> void GetSysReplicationStatus ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysReplicationStatusExample
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
                apiInstance.GetSysReplicationStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysReplicationStatus: " + e.Message );
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

<a name="getsysrotateconfig"></a>
# **GetSysRotateConfig**
> void GetSysRotateConfig ()



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysRotateConfigExample
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
                apiInstance.GetSysRotateConfig();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysRotateConfig: " + e.Message );
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

<a name="getsyssealstatus"></a>
# **GetSysSealStatus**
> void GetSysSealStatus ()

Check the seal status of a Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysSealStatusExample
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
                apiInstance.GetSysSealStatus();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysSealStatus: " + e.Message );
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

<a name="getsysversionhistory"></a>
# **GetSysVersionHistory**
> void GetSysVersionHistory (string list)

Returns map of historical version change entries

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysVersionHistoryExample
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
                apiInstance.GetSysVersionHistory(list);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysVersionHistory: " + e.Message );
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

<a name="getsyswrappinglookup"></a>
# **GetSysWrappingLookup**
> void GetSysWrappingLookup ()

Look up wrapping properties for the requester's token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class GetSysWrappingLookupExample
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
                apiInstance.GetSysWrappingLookup();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.GetSysWrappingLookup: " + e.Message );
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

<a name="postsysaudithashpath"></a>
# **PostSysAuditHashPath**
> void PostSysAuditHashPath (string path, SystemAuditHashRequest systemAuditHashRequest = null)

The hash of the given string via the given audit backend

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysAuditHashPathExample
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
            var systemAuditHashRequest = new SystemAuditHashRequest(); // SystemAuditHashRequest |  (optional) 

            try
            {
                // The hash of the given string via the given audit backend
                apiInstance.PostSysAuditHashPath(path, systemAuditHashRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysAuditHashPath: " + e.Message );
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
 **systemAuditHashRequest** | [**SystemAuditHashRequest**](SystemAuditHashRequest.md)|  | [optional] 

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

<a name="postsysauditpath"></a>
# **PostSysAuditPath**
> void PostSysAuditPath (string path, SystemAuditRequest systemAuditRequest = null)

Enable a new audit device at the supplied path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysAuditPathExample
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
            var systemAuditRequest = new SystemAuditRequest(); // SystemAuditRequest |  (optional) 

            try
            {
                // Enable a new audit device at the supplied path.
                apiInstance.PostSysAuditPath(path, systemAuditRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysAuditPath: " + e.Message );
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
 **systemAuditRequest** | [**SystemAuditRequest**](SystemAuditRequest.md)|  | [optional] 

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

<a name="postsysauthpath"></a>
# **PostSysAuthPath**
> void PostSysAuthPath (string path, SystemAuthRequest systemAuthRequest = null)

Enables a new auth method.

After enabling, the auth method can be accessed and configured via the auth path specified as part of the URL. This auth path will be nested under the auth prefix.  For example, enable the \"foo\" auth method will make it accessible at /auth/foo.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysAuthPathExample
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
            var systemAuthRequest = new SystemAuthRequest(); // SystemAuthRequest |  (optional) 

            try
            {
                // Enables a new auth method.
                apiInstance.PostSysAuthPath(path, systemAuthRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysAuthPath: " + e.Message );
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
 **systemAuthRequest** | [**SystemAuthRequest**](SystemAuthRequest.md)|  | [optional] 

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

<a name="postsysauthpathtune"></a>
# **PostSysAuthPathTune**
> void PostSysAuthPathTune (string path, SystemAuthTuneRequest systemAuthTuneRequest = null)

Tune configuration parameters for a given auth path.

This endpoint requires sudo capability on the final path, but the same functionality can be achieved without sudo via `sys/mounts/auth/[auth-path]/tune`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysAuthPathTuneExample
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
            var systemAuthTuneRequest = new SystemAuthTuneRequest(); // SystemAuthTuneRequest |  (optional) 

            try
            {
                // Tune configuration parameters for a given auth path.
                apiInstance.PostSysAuthPathTune(path, systemAuthTuneRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysAuthPathTune: " + e.Message );
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
 **systemAuthTuneRequest** | [**SystemAuthTuneRequest**](SystemAuthTuneRequest.md)|  | [optional] 

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

<a name="postsyscapabilities"></a>
# **PostSysCapabilities**
> void PostSysCapabilities (SystemCapabilitiesRequest systemCapabilitiesRequest = null)

Fetches the capabilities of the given token on the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysCapabilitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemCapabilitiesRequest = new SystemCapabilitiesRequest(); // SystemCapabilitiesRequest |  (optional) 

            try
            {
                // Fetches the capabilities of the given token on the given path.
                apiInstance.PostSysCapabilities(systemCapabilitiesRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysCapabilities: " + e.Message );
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
 **systemCapabilitiesRequest** | [**SystemCapabilitiesRequest**](SystemCapabilitiesRequest.md)|  | [optional] 

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

<a name="postsyscapabilitiesaccessor"></a>
# **PostSysCapabilitiesAccessor**
> void PostSysCapabilitiesAccessor (SystemCapabilitiesAccessorRequest systemCapabilitiesAccessorRequest = null)

Fetches the capabilities of the token associated with the given token, on the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysCapabilitiesAccessorExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemCapabilitiesAccessorRequest = new SystemCapabilitiesAccessorRequest(); // SystemCapabilitiesAccessorRequest |  (optional) 

            try
            {
                // Fetches the capabilities of the token associated with the given token, on the given path.
                apiInstance.PostSysCapabilitiesAccessor(systemCapabilitiesAccessorRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysCapabilitiesAccessor: " + e.Message );
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
 **systemCapabilitiesAccessorRequest** | [**SystemCapabilitiesAccessorRequest**](SystemCapabilitiesAccessorRequest.md)|  | [optional] 

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

<a name="postsyscapabilitiesself"></a>
# **PostSysCapabilitiesSelf**
> void PostSysCapabilitiesSelf (SystemCapabilitiesSelfRequest systemCapabilitiesSelfRequest = null)

Fetches the capabilities of the given token on the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysCapabilitiesSelfExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemCapabilitiesSelfRequest = new SystemCapabilitiesSelfRequest(); // SystemCapabilitiesSelfRequest |  (optional) 

            try
            {
                // Fetches the capabilities of the given token on the given path.
                apiInstance.PostSysCapabilitiesSelf(systemCapabilitiesSelfRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysCapabilitiesSelf: " + e.Message );
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
 **systemCapabilitiesSelfRequest** | [**SystemCapabilitiesSelfRequest**](SystemCapabilitiesSelfRequest.md)|  | [optional] 

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

<a name="postsysconfigauditingrequestheadersheader"></a>
# **PostSysConfigAuditingRequestHeadersHeader**
> void PostSysConfigAuditingRequestHeadersHeader (string header, SystemConfigAuditingRequestHeadersRequest systemConfigAuditingRequestHeadersRequest = null)

Enable auditing of a header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysConfigAuditingRequestHeadersHeaderExample
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
            var systemConfigAuditingRequestHeadersRequest = new SystemConfigAuditingRequestHeadersRequest(); // SystemConfigAuditingRequestHeadersRequest |  (optional) 

            try
            {
                // Enable auditing of a header.
                apiInstance.PostSysConfigAuditingRequestHeadersHeader(header, systemConfigAuditingRequestHeadersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysConfigAuditingRequestHeadersHeader: " + e.Message );
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
 **systemConfigAuditingRequestHeadersRequest** | [**SystemConfigAuditingRequestHeadersRequest**](SystemConfigAuditingRequestHeadersRequest.md)|  | [optional] 

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

<a name="postsysconfigcors"></a>
# **PostSysConfigCors**
> void PostSysConfigCors (SystemConfigCorsRequest systemConfigCorsRequest = null)

Configure the CORS settings.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysConfigCorsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemConfigCorsRequest = new SystemConfigCorsRequest(); // SystemConfigCorsRequest |  (optional) 

            try
            {
                // Configure the CORS settings.
                apiInstance.PostSysConfigCors(systemConfigCorsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysConfigCors: " + e.Message );
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
 **systemConfigCorsRequest** | [**SystemConfigCorsRequest**](SystemConfigCorsRequest.md)|  | [optional] 

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

<a name="postsysconfigreloadsubsystem"></a>
# **PostSysConfigReloadSubsystem**
> void PostSysConfigReloadSubsystem (string subsystem)

Reload the given subsystem

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysConfigReloadSubsystemExample
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
                apiInstance.PostSysConfigReloadSubsystem(subsystem);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysConfigReloadSubsystem: " + e.Message );
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

<a name="postsysconfiguiheadersheader"></a>
# **PostSysConfigUiHeadersHeader**
> void PostSysConfigUiHeadersHeader (string header, SystemConfigUiHeadersRequest systemConfigUiHeadersRequest = null)

Configure the values to be returned for the UI header.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysConfigUiHeadersHeaderExample
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
            var systemConfigUiHeadersRequest = new SystemConfigUiHeadersRequest(); // SystemConfigUiHeadersRequest |  (optional) 

            try
            {
                // Configure the values to be returned for the UI header.
                apiInstance.PostSysConfigUiHeadersHeader(header, systemConfigUiHeadersRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysConfigUiHeadersHeader: " + e.Message );
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
 **systemConfigUiHeadersRequest** | [**SystemConfigUiHeadersRequest**](SystemConfigUiHeadersRequest.md)|  | [optional] 

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

<a name="postsysgenerateroot"></a>
# **PostSysGenerateRoot**
> void PostSysGenerateRoot (SystemGenerateRootRequest systemGenerateRootRequest = null)

Initializes a new root generation attempt.

Only a single root generation attempt can take place at a time. One (and only one) of otp or pgp_key are required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysGenerateRootExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemGenerateRootRequest = new SystemGenerateRootRequest(); // SystemGenerateRootRequest |  (optional) 

            try
            {
                // Initializes a new root generation attempt.
                apiInstance.PostSysGenerateRoot(systemGenerateRootRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysGenerateRoot: " + e.Message );
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
 **systemGenerateRootRequest** | [**SystemGenerateRootRequest**](SystemGenerateRootRequest.md)|  | [optional] 

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

<a name="postsysgeneraterootattempt"></a>
# **PostSysGenerateRootAttempt**
> void PostSysGenerateRootAttempt (SystemGenerateRootAttemptRequest systemGenerateRootAttemptRequest = null)

Initializes a new root generation attempt.

Only a single root generation attempt can take place at a time. One (and only one) of otp or pgp_key are required.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysGenerateRootAttemptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemGenerateRootAttemptRequest = new SystemGenerateRootAttemptRequest(); // SystemGenerateRootAttemptRequest |  (optional) 

            try
            {
                // Initializes a new root generation attempt.
                apiInstance.PostSysGenerateRootAttempt(systemGenerateRootAttemptRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysGenerateRootAttempt: " + e.Message );
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
 **systemGenerateRootAttemptRequest** | [**SystemGenerateRootAttemptRequest**](SystemGenerateRootAttemptRequest.md)|  | [optional] 

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

<a name="postsysgeneraterootupdate"></a>
# **PostSysGenerateRootUpdate**
> void PostSysGenerateRootUpdate (SystemGenerateRootUpdateRequest systemGenerateRootUpdateRequest = null)

Enter a single unseal key share to progress the root generation attempt.

If the threshold number of unseal key shares is reached, Vault will complete the root generation and issue the new token. Otherwise, this API must be called multiple times until that threshold is met. The attempt nonce must be provided with each call.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysGenerateRootUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemGenerateRootUpdateRequest = new SystemGenerateRootUpdateRequest(); // SystemGenerateRootUpdateRequest |  (optional) 

            try
            {
                // Enter a single unseal key share to progress the root generation attempt.
                apiInstance.PostSysGenerateRootUpdate(systemGenerateRootUpdateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysGenerateRootUpdate: " + e.Message );
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
 **systemGenerateRootUpdateRequest** | [**SystemGenerateRootUpdateRequest**](SystemGenerateRootUpdateRequest.md)|  | [optional] 

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

<a name="postsysinit"></a>
# **PostSysInit**
> void PostSysInit (SystemInitRequest systemInitRequest = null)

Initialize a new Vault.

The Vault must not have been previously initialized. The recovery options, as well as the stored shares option, are only available when using Vault HSM.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysInitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemInitRequest = new SystemInitRequest(); // SystemInitRequest |  (optional) 

            try
            {
                // Initialize a new Vault.
                apiInstance.PostSysInit(systemInitRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysInit: " + e.Message );
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
 **systemInitRequest** | [**SystemInitRequest**](SystemInitRequest.md)|  | [optional] 

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

<a name="postsysinternalcountersconfig"></a>
# **PostSysInternalCountersConfig**
> void PostSysInternalCountersConfig (SystemInternalCountersConfigRequest systemInternalCountersConfigRequest = null)

Enable or disable collection of client count, set retention period, or set default reporting period.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysInternalCountersConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemInternalCountersConfigRequest = new SystemInternalCountersConfigRequest(); // SystemInternalCountersConfigRequest |  (optional) 

            try
            {
                // Enable or disable collection of client count, set retention period, or set default reporting period.
                apiInstance.PostSysInternalCountersConfig(systemInternalCountersConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysInternalCountersConfig: " + e.Message );
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
 **systemInternalCountersConfigRequest** | [**SystemInternalCountersConfigRequest**](SystemInternalCountersConfigRequest.md)|  | [optional] 

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

<a name="postsysleaseslookup"></a>
# **PostSysLeasesLookup**
> void PostSysLeasesLookup (SystemLeasesLookupRequest systemLeasesLookupRequest = null)

Retrieve lease metadata.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysLeasesLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemLeasesLookupRequest = new SystemLeasesLookupRequest(); // SystemLeasesLookupRequest |  (optional) 

            try
            {
                // Retrieve lease metadata.
                apiInstance.PostSysLeasesLookup(systemLeasesLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysLeasesLookup: " + e.Message );
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
 **systemLeasesLookupRequest** | [**SystemLeasesLookupRequest**](SystemLeasesLookupRequest.md)|  | [optional] 

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

<a name="postsysleasesrenew"></a>
# **PostSysLeasesRenew**
> void PostSysLeasesRenew (SystemLeasesRenewRequest systemLeasesRenewRequest = null)

Renews a lease, requesting to extend the lease.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysLeasesRenewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemLeasesRenewRequest = new SystemLeasesRenewRequest(); // SystemLeasesRenewRequest |  (optional) 

            try
            {
                // Renews a lease, requesting to extend the lease.
                apiInstance.PostSysLeasesRenew(systemLeasesRenewRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysLeasesRenew: " + e.Message );
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
 **systemLeasesRenewRequest** | [**SystemLeasesRenewRequest**](SystemLeasesRenewRequest.md)|  | [optional] 

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

<a name="postsysleasesrenewurlleaseid"></a>
# **PostSysLeasesRenewUrlLeaseId**
> void PostSysLeasesRenewUrlLeaseId (string urlLeaseId, SystemLeasesRenewLeaseRequest systemLeasesRenewLeaseRequest = null)

Renews a lease, requesting to extend the lease.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysLeasesRenewUrlLeaseIdExample
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
            var systemLeasesRenewLeaseRequest = new SystemLeasesRenewLeaseRequest(); // SystemLeasesRenewLeaseRequest |  (optional) 

            try
            {
                // Renews a lease, requesting to extend the lease.
                apiInstance.PostSysLeasesRenewUrlLeaseId(urlLeaseId, systemLeasesRenewLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysLeasesRenewUrlLeaseId: " + e.Message );
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
 **systemLeasesRenewLeaseRequest** | [**SystemLeasesRenewLeaseRequest**](SystemLeasesRenewLeaseRequest.md)|  | [optional] 

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

<a name="postsysleasesrevoke"></a>
# **PostSysLeasesRevoke**
> void PostSysLeasesRevoke (SystemLeasesRevokeRequest systemLeasesRevokeRequest = null)

Revokes a lease immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysLeasesRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemLeasesRevokeRequest = new SystemLeasesRevokeRequest(); // SystemLeasesRevokeRequest |  (optional) 

            try
            {
                // Revokes a lease immediately.
                apiInstance.PostSysLeasesRevoke(systemLeasesRevokeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysLeasesRevoke: " + e.Message );
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
 **systemLeasesRevokeRequest** | [**SystemLeasesRevokeRequest**](SystemLeasesRevokeRequest.md)|  | [optional] 

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

<a name="postsysleasesrevokeforceprefix"></a>
# **PostSysLeasesRevokeForcePrefix**
> void PostSysLeasesRevokeForcePrefix (string prefix)

Revokes all secrets or tokens generated under a given prefix immediately

Unlike `/sys/leases/revoke-prefix`, this path ignores backend errors encountered during revocation. This is potentially very dangerous and should only be used in specific emergency situations where errors in the backend or the connected backend service prevent normal revocation.  By ignoring these errors, Vault abdicates responsibility for ensuring that the issued credentials or secrets are properly revoked and/or cleaned up. Access to this endpoint should be tightly controlled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysLeasesRevokeForcePrefixExample
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
                apiInstance.PostSysLeasesRevokeForcePrefix(prefix);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysLeasesRevokeForcePrefix: " + e.Message );
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

<a name="postsysleasesrevokeprefixprefix"></a>
# **PostSysLeasesRevokePrefixPrefix**
> void PostSysLeasesRevokePrefixPrefix (string prefix, SystemLeasesRevokePrefixRequest systemLeasesRevokePrefixRequest = null)

Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysLeasesRevokePrefixPrefixExample
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
            var systemLeasesRevokePrefixRequest = new SystemLeasesRevokePrefixRequest(); // SystemLeasesRevokePrefixRequest |  (optional) 

            try
            {
                // Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.
                apiInstance.PostSysLeasesRevokePrefixPrefix(prefix, systemLeasesRevokePrefixRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysLeasesRevokePrefixPrefix: " + e.Message );
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
 **systemLeasesRevokePrefixRequest** | [**SystemLeasesRevokePrefixRequest**](SystemLeasesRevokePrefixRequest.md)|  | [optional] 

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

<a name="postsysleasesrevokeurlleaseid"></a>
# **PostSysLeasesRevokeUrlLeaseId**
> void PostSysLeasesRevokeUrlLeaseId (string urlLeaseId, SystemLeasesRevokeLeaseRequest systemLeasesRevokeLeaseRequest = null)

Revokes a lease immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysLeasesRevokeUrlLeaseIdExample
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
            var systemLeasesRevokeLeaseRequest = new SystemLeasesRevokeLeaseRequest(); // SystemLeasesRevokeLeaseRequest |  (optional) 

            try
            {
                // Revokes a lease immediately.
                apiInstance.PostSysLeasesRevokeUrlLeaseId(urlLeaseId, systemLeasesRevokeLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysLeasesRevokeUrlLeaseId: " + e.Message );
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
 **systemLeasesRevokeLeaseRequest** | [**SystemLeasesRevokeLeaseRequest**](SystemLeasesRevokeLeaseRequest.md)|  | [optional] 

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

<a name="postsysleasestidy"></a>
# **PostSysLeasesTidy**
> void PostSysLeasesTidy ()

This endpoint performs cleanup tasks that can be run if certain error conditions have occurred.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysLeasesTidyExample
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
                apiInstance.PostSysLeasesTidy();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysLeasesTidy: " + e.Message );
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

<a name="postsysmfavalidate"></a>
# **PostSysMfaValidate**
> void PostSysMfaValidate (SystemMfaValidateRequest systemMfaValidateRequest = null)

Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysMfaValidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemMfaValidateRequest = new SystemMfaValidateRequest(); // SystemMfaValidateRequest |  (optional) 

            try
            {
                // Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token
                apiInstance.PostSysMfaValidate(systemMfaValidateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysMfaValidate: " + e.Message );
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
 **systemMfaValidateRequest** | [**SystemMfaValidateRequest**](SystemMfaValidateRequest.md)|  | [optional] 

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

<a name="postsysmountspath"></a>
# **PostSysMountsPath**
> void PostSysMountsPath (string path, SystemMountsRequest systemMountsRequest = null)

Enable a new secrets engine at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysMountsPathExample
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
            var systemMountsRequest = new SystemMountsRequest(); // SystemMountsRequest |  (optional) 

            try
            {
                // Enable a new secrets engine at the given path.
                apiInstance.PostSysMountsPath(path, systemMountsRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysMountsPath: " + e.Message );
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
 **systemMountsRequest** | [**SystemMountsRequest**](SystemMountsRequest.md)|  | [optional] 

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

<a name="postsysmountspathtune"></a>
# **PostSysMountsPathTune**
> void PostSysMountsPathTune (string path, SystemMountsTuneRequest systemMountsTuneRequest = null)

Tune backend configuration parameters for this mount.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysMountsPathTuneExample
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
            var systemMountsTuneRequest = new SystemMountsTuneRequest(); // SystemMountsTuneRequest |  (optional) 

            try
            {
                // Tune backend configuration parameters for this mount.
                apiInstance.PostSysMountsPathTune(path, systemMountsTuneRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysMountsPathTune: " + e.Message );
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
 **systemMountsTuneRequest** | [**SystemMountsTuneRequest**](SystemMountsTuneRequest.md)|  | [optional] 

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

<a name="postsyspluginscatalogname"></a>
# **PostSysPluginsCatalogName**
> void PostSysPluginsCatalogName (string name, SystemPluginsCatalogRequest systemPluginsCatalogRequest = null)

Register a new plugin, or updates an existing one with the supplied name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysPluginsCatalogNameExample
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
            var systemPluginsCatalogRequest = new SystemPluginsCatalogRequest(); // SystemPluginsCatalogRequest |  (optional) 

            try
            {
                // Register a new plugin, or updates an existing one with the supplied name.
                apiInstance.PostSysPluginsCatalogName(name, systemPluginsCatalogRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysPluginsCatalogName: " + e.Message );
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
 **systemPluginsCatalogRequest** | [**SystemPluginsCatalogRequest**](SystemPluginsCatalogRequest.md)|  | [optional] 

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

<a name="postsyspluginscatalogtypename"></a>
# **PostSysPluginsCatalogTypeName**
> void PostSysPluginsCatalogTypeName (string name, string type, SystemPluginsCatalogRequest systemPluginsCatalogRequest = null)

Register a new plugin, or updates an existing one with the supplied name.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysPluginsCatalogTypeNameExample
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
            var systemPluginsCatalogRequest = new SystemPluginsCatalogRequest(); // SystemPluginsCatalogRequest |  (optional) 

            try
            {
                // Register a new plugin, or updates an existing one with the supplied name.
                apiInstance.PostSysPluginsCatalogTypeName(name, type, systemPluginsCatalogRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysPluginsCatalogTypeName: " + e.Message );
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
 **systemPluginsCatalogRequest** | [**SystemPluginsCatalogRequest**](SystemPluginsCatalogRequest.md)|  | [optional] 

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

<a name="postsyspluginsreloadbackend"></a>
# **PostSysPluginsReloadBackend**
> void PostSysPluginsReloadBackend (SystemPluginsReloadBackendRequest systemPluginsReloadBackendRequest = null)

Reload mounted plugin backends.

Either the plugin name (`plugin`) or the desired plugin backend mounts (`mounts`) must be provided, but not both. In the case that the plugin name is provided, all mounted paths that use that plugin backend will be reloaded.  If (`scope`) is provided and is (`global`), the plugin(s) are reloaded globally.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysPluginsReloadBackendExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemPluginsReloadBackendRequest = new SystemPluginsReloadBackendRequest(); // SystemPluginsReloadBackendRequest |  (optional) 

            try
            {
                // Reload mounted plugin backends.
                apiInstance.PostSysPluginsReloadBackend(systemPluginsReloadBackendRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysPluginsReloadBackend: " + e.Message );
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
 **systemPluginsReloadBackendRequest** | [**SystemPluginsReloadBackendRequest**](SystemPluginsReloadBackendRequest.md)|  | [optional] 

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

<a name="postsyspoliciesaclname"></a>
# **PostSysPoliciesAclName**
> void PostSysPoliciesAclName (string name, SystemPoliciesAclRequest systemPoliciesAclRequest = null)

Add a new or update an existing ACL policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysPoliciesAclNameExample
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
            var systemPoliciesAclRequest = new SystemPoliciesAclRequest(); // SystemPoliciesAclRequest |  (optional) 

            try
            {
                // Add a new or update an existing ACL policy.
                apiInstance.PostSysPoliciesAclName(name, systemPoliciesAclRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysPoliciesAclName: " + e.Message );
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
 **systemPoliciesAclRequest** | [**SystemPoliciesAclRequest**](SystemPoliciesAclRequest.md)|  | [optional] 

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

<a name="postsyspoliciespasswordname"></a>
# **PostSysPoliciesPasswordName**
> void PostSysPoliciesPasswordName (string name, SystemPoliciesPasswordRequest systemPoliciesPasswordRequest = null)

Add a new or update an existing password policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysPoliciesPasswordNameExample
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
            var systemPoliciesPasswordRequest = new SystemPoliciesPasswordRequest(); // SystemPoliciesPasswordRequest |  (optional) 

            try
            {
                // Add a new or update an existing password policy.
                apiInstance.PostSysPoliciesPasswordName(name, systemPoliciesPasswordRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysPoliciesPasswordName: " + e.Message );
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
 **systemPoliciesPasswordRequest** | [**SystemPoliciesPasswordRequest**](SystemPoliciesPasswordRequest.md)|  | [optional] 

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

<a name="postsyspolicyname"></a>
# **PostSysPolicyName**
> void PostSysPolicyName (string name, SystemPolicyRequest systemPolicyRequest = null)

Add a new or update an existing policy.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysPolicyNameExample
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
            var systemPolicyRequest = new SystemPolicyRequest(); // SystemPolicyRequest |  (optional) 

            try
            {
                // Add a new or update an existing policy.
                apiInstance.PostSysPolicyName(name, systemPolicyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysPolicyName: " + e.Message );
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
 **systemPolicyRequest** | [**SystemPolicyRequest**](SystemPolicyRequest.md)|  | [optional] 

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

<a name="postsysquotasconfig"></a>
# **PostSysQuotasConfig**
> void PostSysQuotasConfig (SystemQuotasConfigRequest systemQuotasConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysQuotasConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemQuotasConfigRequest = new SystemQuotasConfigRequest(); // SystemQuotasConfigRequest |  (optional) 

            try
            {
                apiInstance.PostSysQuotasConfig(systemQuotasConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysQuotasConfig: " + e.Message );
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
 **systemQuotasConfigRequest** | [**SystemQuotasConfigRequest**](SystemQuotasConfigRequest.md)|  | [optional] 

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

<a name="postsysquotasratelimitname"></a>
# **PostSysQuotasRateLimitName**
> void PostSysQuotasRateLimitName (string name, SystemQuotasRateLimitRequest systemQuotasRateLimitRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysQuotasRateLimitNameExample
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
            var systemQuotasRateLimitRequest = new SystemQuotasRateLimitRequest(); // SystemQuotasRateLimitRequest |  (optional) 

            try
            {
                apiInstance.PostSysQuotasRateLimitName(name, systemQuotasRateLimitRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysQuotasRateLimitName: " + e.Message );
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
 **systemQuotasRateLimitRequest** | [**SystemQuotasRateLimitRequest**](SystemQuotasRateLimitRequest.md)|  | [optional] 

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

<a name="postsysraw"></a>
# **PostSysRaw**
> void PostSysRaw (SystemRawRequest systemRawRequest = null)

Update the value of the key at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRawExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRawRequest = new SystemRawRequest(); // SystemRawRequest |  (optional) 

            try
            {
                // Update the value of the key at the given path.
                apiInstance.PostSysRaw(systemRawRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRaw: " + e.Message );
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
 **systemRawRequest** | [**SystemRawRequest**](SystemRawRequest.md)|  | [optional] 

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

<a name="postsysrawpath"></a>
# **PostSysRawPath**
> void PostSysRawPath (string path, SystemRawRequest systemRawRequest = null)

Update the value of the key at the given path.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRawPathExample
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
            var systemRawRequest = new SystemRawRequest(); // SystemRawRequest |  (optional) 

            try
            {
                // Update the value of the key at the given path.
                apiInstance.PostSysRawPath(path, systemRawRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRawPath: " + e.Message );
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
 **systemRawRequest** | [**SystemRawRequest**](SystemRawRequest.md)|  | [optional] 

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

<a name="postsysrekeyinit"></a>
# **PostSysRekeyInit**
> void PostSysRekeyInit (SystemRekeyInitRequest systemRekeyInitRequest = null)

Initializes a new rekey attempt.

Only a single rekey attempt can take place at a time, and changing the parameters of a rekey requires canceling and starting a new rekey, which will also provide a new nonce.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRekeyInitExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRekeyInitRequest = new SystemRekeyInitRequest(); // SystemRekeyInitRequest |  (optional) 

            try
            {
                // Initializes a new rekey attempt.
                apiInstance.PostSysRekeyInit(systemRekeyInitRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRekeyInit: " + e.Message );
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
 **systemRekeyInitRequest** | [**SystemRekeyInitRequest**](SystemRekeyInitRequest.md)|  | [optional] 

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

<a name="postsysrekeyupdate"></a>
# **PostSysRekeyUpdate**
> void PostSysRekeyUpdate (SystemRekeyUpdateRequest systemRekeyUpdateRequest = null)

Enter a single unseal key share to progress the rekey of the Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRekeyUpdateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRekeyUpdateRequest = new SystemRekeyUpdateRequest(); // SystemRekeyUpdateRequest |  (optional) 

            try
            {
                // Enter a single unseal key share to progress the rekey of the Vault.
                apiInstance.PostSysRekeyUpdate(systemRekeyUpdateRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRekeyUpdate: " + e.Message );
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
 **systemRekeyUpdateRequest** | [**SystemRekeyUpdateRequest**](SystemRekeyUpdateRequest.md)|  | [optional] 

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

<a name="postsysrekeyverify"></a>
# **PostSysRekeyVerify**
> void PostSysRekeyVerify (SystemRekeyVerifyRequest systemRekeyVerifyRequest = null)

Enter a single new key share to progress the rekey verification operation.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRekeyVerifyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRekeyVerifyRequest = new SystemRekeyVerifyRequest(); // SystemRekeyVerifyRequest |  (optional) 

            try
            {
                // Enter a single new key share to progress the rekey verification operation.
                apiInstance.PostSysRekeyVerify(systemRekeyVerifyRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRekeyVerify: " + e.Message );
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
 **systemRekeyVerifyRequest** | [**SystemRekeyVerifyRequest**](SystemRekeyVerifyRequest.md)|  | [optional] 

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

<a name="postsysremount"></a>
# **PostSysRemount**
> void PostSysRemount (SystemRemountRequest systemRemountRequest = null)

Initiate a mount migration

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRemountExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRemountRequest = new SystemRemountRequest(); // SystemRemountRequest |  (optional) 

            try
            {
                // Initiate a mount migration
                apiInstance.PostSysRemount(systemRemountRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRemount: " + e.Message );
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
 **systemRemountRequest** | [**SystemRemountRequest**](SystemRemountRequest.md)|  | [optional] 

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

<a name="postsysrenew"></a>
# **PostSysRenew**
> void PostSysRenew (SystemRenewRequest systemRenewRequest = null)

Renews a lease, requesting to extend the lease.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRenewExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRenewRequest = new SystemRenewRequest(); // SystemRenewRequest |  (optional) 

            try
            {
                // Renews a lease, requesting to extend the lease.
                apiInstance.PostSysRenew(systemRenewRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRenew: " + e.Message );
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
 **systemRenewRequest** | [**SystemRenewRequest**](SystemRenewRequest.md)|  | [optional] 

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

<a name="postsysrenewurlleaseid"></a>
# **PostSysRenewUrlLeaseId**
> void PostSysRenewUrlLeaseId (string urlLeaseId, SystemRenewLeaseRequest systemRenewLeaseRequest = null)

Renews a lease, requesting to extend the lease.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRenewUrlLeaseIdExample
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
            var systemRenewLeaseRequest = new SystemRenewLeaseRequest(); // SystemRenewLeaseRequest |  (optional) 

            try
            {
                // Renews a lease, requesting to extend the lease.
                apiInstance.PostSysRenewUrlLeaseId(urlLeaseId, systemRenewLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRenewUrlLeaseId: " + e.Message );
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
 **systemRenewLeaseRequest** | [**SystemRenewLeaseRequest**](SystemRenewLeaseRequest.md)|  | [optional] 

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

<a name="postsysrevoke"></a>
# **PostSysRevoke**
> void PostSysRevoke (SystemRevokeRequest systemRevokeRequest = null)

Revokes a lease immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRevokeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRevokeRequest = new SystemRevokeRequest(); // SystemRevokeRequest |  (optional) 

            try
            {
                // Revokes a lease immediately.
                apiInstance.PostSysRevoke(systemRevokeRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRevoke: " + e.Message );
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
 **systemRevokeRequest** | [**SystemRevokeRequest**](SystemRevokeRequest.md)|  | [optional] 

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

<a name="postsysrevokeforceprefix"></a>
# **PostSysRevokeForcePrefix**
> void PostSysRevokeForcePrefix (string prefix)

Revokes all secrets or tokens generated under a given prefix immediately

Unlike `/sys/leases/revoke-prefix`, this path ignores backend errors encountered during revocation. This is potentially very dangerous and should only be used in specific emergency situations where errors in the backend or the connected backend service prevent normal revocation.  By ignoring these errors, Vault abdicates responsibility for ensuring that the issued credentials or secrets are properly revoked and/or cleaned up. Access to this endpoint should be tightly controlled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRevokeForcePrefixExample
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
                apiInstance.PostSysRevokeForcePrefix(prefix);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRevokeForcePrefix: " + e.Message );
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

<a name="postsysrevokeprefixprefix"></a>
# **PostSysRevokePrefixPrefix**
> void PostSysRevokePrefixPrefix (string prefix, SystemRevokePrefixRequest systemRevokePrefixRequest = null)

Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRevokePrefixPrefixExample
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
            var systemRevokePrefixRequest = new SystemRevokePrefixRequest(); // SystemRevokePrefixRequest |  (optional) 

            try
            {
                // Revokes all secrets (via a lease ID prefix) or tokens (via the tokens' path property) generated under a given prefix immediately.
                apiInstance.PostSysRevokePrefixPrefix(prefix, systemRevokePrefixRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRevokePrefixPrefix: " + e.Message );
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
 **systemRevokePrefixRequest** | [**SystemRevokePrefixRequest**](SystemRevokePrefixRequest.md)|  | [optional] 

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

<a name="postsysrevokeurlleaseid"></a>
# **PostSysRevokeUrlLeaseId**
> void PostSysRevokeUrlLeaseId (string urlLeaseId, SystemRevokeLeaseRequest systemRevokeLeaseRequest = null)

Revokes a lease immediately.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRevokeUrlLeaseIdExample
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
            var systemRevokeLeaseRequest = new SystemRevokeLeaseRequest(); // SystemRevokeLeaseRequest |  (optional) 

            try
            {
                // Revokes a lease immediately.
                apiInstance.PostSysRevokeUrlLeaseId(urlLeaseId, systemRevokeLeaseRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRevokeUrlLeaseId: " + e.Message );
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
 **systemRevokeLeaseRequest** | [**SystemRevokeLeaseRequest**](SystemRevokeLeaseRequest.md)|  | [optional] 

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

<a name="postsysrotate"></a>
# **PostSysRotate**
> void PostSysRotate ()

Rotates the backend encryption key used to persist data.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRotateExample
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
                apiInstance.PostSysRotate();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRotate: " + e.Message );
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

<a name="postsysrotateconfig"></a>
# **PostSysRotateConfig**
> void PostSysRotateConfig (SystemRotateConfigRequest systemRotateConfigRequest = null)



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysRotateConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemRotateConfigRequest = new SystemRotateConfigRequest(); // SystemRotateConfigRequest |  (optional) 

            try
            {
                apiInstance.PostSysRotateConfig(systemRotateConfigRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysRotateConfig: " + e.Message );
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
 **systemRotateConfigRequest** | [**SystemRotateConfigRequest**](SystemRotateConfigRequest.md)|  | [optional] 

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

<a name="postsysseal"></a>
# **PostSysSeal**
> void PostSysSeal ()

Seal the Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysSealExample
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
                apiInstance.PostSysSeal();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysSeal: " + e.Message );
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

<a name="postsysstepdown"></a>
# **PostSysStepDown**
> void PostSysStepDown ()

Cause the node to give up active status.

This endpoint forces the node to give up active status. If the node does not have active status, this endpoint does nothing. Note that the node will sleep for ten seconds before attempting to grab the active lock again, but if no standby nodes grab the active lock in the interim, the same node may become the active node again.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysStepDownExample
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
                apiInstance.PostSysStepDown();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysStepDown: " + e.Message );
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

<a name="postsystoolshash"></a>
# **PostSysToolsHash**
> void PostSysToolsHash (SystemToolsHashRequest systemToolsHashRequest = null)

Generate a hash sum for input data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysToolsHashExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemToolsHashRequest = new SystemToolsHashRequest(); // SystemToolsHashRequest |  (optional) 

            try
            {
                // Generate a hash sum for input data
                apiInstance.PostSysToolsHash(systemToolsHashRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysToolsHash: " + e.Message );
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
 **systemToolsHashRequest** | [**SystemToolsHashRequest**](SystemToolsHashRequest.md)|  | [optional] 

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

<a name="postsystoolshashurlalgorithm"></a>
# **PostSysToolsHashUrlalgorithm**
> void PostSysToolsHashUrlalgorithm (string urlalgorithm, SystemToolsHashRequest systemToolsHashRequest = null)

Generate a hash sum for input data

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysToolsHashUrlalgorithmExample
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
            var systemToolsHashRequest = new SystemToolsHashRequest(); // SystemToolsHashRequest |  (optional) 

            try
            {
                // Generate a hash sum for input data
                apiInstance.PostSysToolsHashUrlalgorithm(urlalgorithm, systemToolsHashRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysToolsHashUrlalgorithm: " + e.Message );
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
 **systemToolsHashRequest** | [**SystemToolsHashRequest**](SystemToolsHashRequest.md)|  | [optional] 

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

<a name="postsystoolsrandom"></a>
# **PostSysToolsRandom**
> void PostSysToolsRandom (SystemToolsRandomRequest systemToolsRandomRequest = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysToolsRandomExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemToolsRandomRequest = new SystemToolsRandomRequest(); // SystemToolsRandomRequest |  (optional) 

            try
            {
                // Generate random bytes
                apiInstance.PostSysToolsRandom(systemToolsRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysToolsRandom: " + e.Message );
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
 **systemToolsRandomRequest** | [**SystemToolsRandomRequest**](SystemToolsRandomRequest.md)|  | [optional] 

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

<a name="postsystoolsrandomsource"></a>
# **PostSysToolsRandomSource**
> void PostSysToolsRandomSource (string source, SystemToolsRandomRequest systemToolsRandomRequest = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysToolsRandomSourceExample
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
            var systemToolsRandomRequest = new SystemToolsRandomRequest(); // SystemToolsRandomRequest |  (optional) 

            try
            {
                // Generate random bytes
                apiInstance.PostSysToolsRandomSource(source, systemToolsRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysToolsRandomSource: " + e.Message );
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
 **systemToolsRandomRequest** | [**SystemToolsRandomRequest**](SystemToolsRandomRequest.md)|  | [optional] 

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

<a name="postsystoolsrandomsourceurlbytes"></a>
# **PostSysToolsRandomSourceUrlbytes**
> void PostSysToolsRandomSourceUrlbytes (string source, string urlbytes, SystemToolsRandomRequest systemToolsRandomRequest = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysToolsRandomSourceUrlbytesExample
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
            var systemToolsRandomRequest = new SystemToolsRandomRequest(); // SystemToolsRandomRequest |  (optional) 

            try
            {
                // Generate random bytes
                apiInstance.PostSysToolsRandomSourceUrlbytes(source, urlbytes, systemToolsRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysToolsRandomSourceUrlbytes: " + e.Message );
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
 **systemToolsRandomRequest** | [**SystemToolsRandomRequest**](SystemToolsRandomRequest.md)|  | [optional] 

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

<a name="postsystoolsrandomurlbytes"></a>
# **PostSysToolsRandomUrlbytes**
> void PostSysToolsRandomUrlbytes (string urlbytes, SystemToolsRandomRequest systemToolsRandomRequest = null)

Generate random bytes

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysToolsRandomUrlbytesExample
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
            var systemToolsRandomRequest = new SystemToolsRandomRequest(); // SystemToolsRandomRequest |  (optional) 

            try
            {
                // Generate random bytes
                apiInstance.PostSysToolsRandomUrlbytes(urlbytes, systemToolsRandomRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysToolsRandomUrlbytes: " + e.Message );
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
 **systemToolsRandomRequest** | [**SystemToolsRandomRequest**](SystemToolsRandomRequest.md)|  | [optional] 

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

<a name="postsysunseal"></a>
# **PostSysUnseal**
> void PostSysUnseal (SystemUnsealRequest systemUnsealRequest = null)

Unseal the Vault.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysUnsealExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemUnsealRequest = new SystemUnsealRequest(); // SystemUnsealRequest |  (optional) 

            try
            {
                // Unseal the Vault.
                apiInstance.PostSysUnseal(systemUnsealRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysUnseal: " + e.Message );
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
 **systemUnsealRequest** | [**SystemUnsealRequest**](SystemUnsealRequest.md)|  | [optional] 

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

<a name="postsyswrappinglookup"></a>
# **PostSysWrappingLookup**
> void PostSysWrappingLookup (SystemWrappingLookupRequest systemWrappingLookupRequest = null)

Look up wrapping properties for the given token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysWrappingLookupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemWrappingLookupRequest = new SystemWrappingLookupRequest(); // SystemWrappingLookupRequest |  (optional) 

            try
            {
                // Look up wrapping properties for the given token.
                apiInstance.PostSysWrappingLookup(systemWrappingLookupRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysWrappingLookup: " + e.Message );
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
 **systemWrappingLookupRequest** | [**SystemWrappingLookupRequest**](SystemWrappingLookupRequest.md)|  | [optional] 

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

<a name="postsyswrappingrewrap"></a>
# **PostSysWrappingRewrap**
> void PostSysWrappingRewrap (SystemWrappingRewrapRequest systemWrappingRewrapRequest = null)

Rotates a response-wrapped token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysWrappingRewrapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemWrappingRewrapRequest = new SystemWrappingRewrapRequest(); // SystemWrappingRewrapRequest |  (optional) 

            try
            {
                // Rotates a response-wrapped token.
                apiInstance.PostSysWrappingRewrap(systemWrappingRewrapRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysWrappingRewrap: " + e.Message );
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
 **systemWrappingRewrapRequest** | [**SystemWrappingRewrapRequest**](SystemWrappingRewrapRequest.md)|  | [optional] 

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

<a name="postsyswrappingunwrap"></a>
# **PostSysWrappingUnwrap**
> void PostSysWrappingUnwrap (SystemWrappingUnwrapRequest systemWrappingUnwrapRequest = null)

Unwraps a response-wrapped token.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysWrappingUnwrapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://localhost";
            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new System(httpClient, config, httpClientHandler);
            var systemWrappingUnwrapRequest = new SystemWrappingUnwrapRequest(); // SystemWrappingUnwrapRequest |  (optional) 

            try
            {
                // Unwraps a response-wrapped token.
                apiInstance.PostSysWrappingUnwrap(systemWrappingUnwrapRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysWrappingUnwrap: " + e.Message );
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
 **systemWrappingUnwrapRequest** | [**SystemWrappingUnwrapRequest**](SystemWrappingUnwrapRequest.md)|  | [optional] 

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

<a name="postsyswrappingwrap"></a>
# **PostSysWrappingWrap**
> void PostSysWrappingWrap ()

Response-wraps an arbitrary JSON object.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using VaultClient.Api;
using VaultClient.Client;
using VaultClient.Model;

namespace Example
{
    public class PostSysWrappingWrapExample
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
                apiInstance.PostSysWrappingWrap();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling System.PostSysWrappingWrap: " + e.Message );
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

