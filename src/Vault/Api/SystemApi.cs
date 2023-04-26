// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0
//
// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

using System;
using System.Threading;
using System.Threading.Tasks;
using Vault.Client;
using Vault.Model;

namespace Vault.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemSync : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="auditingCalculateHashRequest"></param>
        /// <param name="path">The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot;</param>
        /// <returns>VaultResponse of AuditingCalculateHashResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<AuditingCalculateHashResponse> AuditingCalculateHash(string path, AuditingCalculateHashRequest auditingCalculateHashRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Disable the audit device at the given path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AuditingDisableDevice(string path, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Disable auditing of the given request header.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AuditingDisableRequestHeader(string header, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Enable a new audit device at the supplied path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="auditingEnableDeviceRequest"></param>
        /// <param name="path">The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AuditingEnableDevice(string path, AuditingEnableDeviceRequest auditingEnableDeviceRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Enable auditing of a header.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="auditingEnableRequestHeaderRequest"></param>
        /// <param name="header"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AuditingEnableRequestHeader(string header, AuditingEnableRequestHeaderRequest auditingEnableRequestHeaderRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// List the enabled audit devices.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AuditingListEnabledDevices(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List the request headers that are configured to be audited.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of AuditingListRequestHeadersResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<AuditingListRequestHeadersResponse> AuditingListRequestHeaders(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List the information for the given request header.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AuditingReadRequestHeaderInformation(string header, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Disable the auth method at the given auth path
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Cannot be delimited. Example: \&quot;user\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AuthDisableMethod(string path, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Enables a new auth method.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="authEnableMethodRequest"></param>
        /// <param name="path">The path to mount to. Cannot be delimited. Example: \&quot;user\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AuthEnableMethod(string path, AuthEnableMethodRequest authEnableMethodRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AuthListEnabledMethods(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the configuration of the auth engine at the given path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Cannot be delimited. Example: \&quot;user\&quot;</param>
        /// <returns>VaultResponse of AuthReadConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<AuthReadConfigurationResponse> AuthReadConfiguration(string path, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Reads the given auth path&#x27;s configuration.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Tune the configuration parameters for an auth path.</param>
        /// <returns>VaultResponse of AuthReadTuningInformationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<AuthReadTuningInformationResponse> AuthReadTuningInformation(string path, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Tune configuration parameters for a given auth path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="authTuneConfigurationParametersRequest"></param>
        /// <param name="path">Tune the configuration parameters for an auth path.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AuthTuneConfigurationParameters(string path, AuthTuneConfigurationParametersRequest authTuneConfigurationParametersRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Information about the host instance that this Vault server is running on.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of CollectHostInformationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<CollectHostInformationResponse> CollectHostInformation(TimeSpan? wrapTTL = null);

        /// <summary>
        /// reports in-flight requests
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> CollectInFlightRequestInformation(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Configure the CORS settings.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="corsConfigureRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> CorsConfigure(CorsConfigureRequest corsConfigureRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Remove any CORS settings.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> CorsDeleteConfiguration(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Return the current CORS settings.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of CorsReadConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<CorsReadConfigurationResponse> CorsReadConfiguration(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyConfigureRotationRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EncryptionKeyConfigureRotation(EncryptionKeyConfigureRotationRequest encryptionKeyConfigureRotationRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of EncryptionKeyReadRotationConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<EncryptionKeyReadRotationConfigurationResponse> EncryptionKeyReadRotationConfiguration(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EncryptionKeyRotate(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Provides information about the backend encryption key.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EncryptionKeyStatus(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateHashRequest"></param>
        /// <returns>VaultResponse of GenerateHashResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<GenerateHashResponse> GenerateHash(GenerateHashRequest generateHashRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateHashWithAlgorithmRequest"></param>
        /// <param name="urlalgorithm">Algorithm to use (POST URL parameter)</param>
        /// <returns>VaultResponse of GenerateHashWithAlgorithmResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<GenerateHashWithAlgorithmResponse> GenerateHashWithAlgorithm(string urlalgorithm, GenerateHashWithAlgorithmRequest generateHashWithAlgorithmRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomRequest"></param>
        /// <returns>VaultResponse of GenerateRandomResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<GenerateRandomResponse> GenerateRandom(GenerateRandomRequest generateRandomRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomWithBytesRequest"></param>
        /// <param name="urlbytes">The number of bytes to generate (POST URL parameter)</param>
        /// <returns>VaultResponse of GenerateRandomWithBytesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<GenerateRandomWithBytesResponse> GenerateRandomWithBytes(string urlbytes, GenerateRandomWithBytesRequest generateRandomWithBytesRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomWithSourceRequest"></param>
        /// <param name="source">Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;.</param>
        /// <returns>VaultResponse of GenerateRandomWithSourceResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<GenerateRandomWithSourceResponse> GenerateRandomWithSource(string source, GenerateRandomWithSourceRequest generateRandomWithSourceRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomWithSourceAndBytesRequest"></param>
        /// <param name="source">Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;.</param>
        /// <param name="urlbytes">The number of bytes to generate (POST URL parameter)</param>
        /// <returns>VaultResponse of GenerateRandomWithSourceAndBytesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<GenerateRandomWithSourceAndBytesResponse> GenerateRandomWithSourceAndBytes(string source, string urlbytes, GenerateRandomWithSourceAndBytesRequest generateRandomWithSourceAndBytesRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Check the HA status of a Vault cluster
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of HaStatusResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<HaStatusResponse> HaStatus(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Initialize a new Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="initializeRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> Initialize(InitializeRequest initializeRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Enable or disable collection of client count, set retention period, or set default reporting period.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="internalClientActivityConfigureRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> InternalClientActivityConfigure(InternalClientActivityConfigureRequest internalClientActivityConfigureRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Report the client count metrics, for this namespace and all child namespaces.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> InternalClientActivityExport(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the client count tracking configuration.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> InternalClientActivityReadConfiguration(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Report the client count metrics, for this namespace and all child namespaces.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> InternalClientActivityReportCounts(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Report the number of clients for this month, for this namespace and all child namespaces.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> InternalClientActivityReportCountsThisMonth(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Backwards compatibility is not guaranteed for this API
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of InternalCountEntitiesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<InternalCountEntitiesResponse> InternalCountEntities(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Backwards compatibility is not guaranteed for this API
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>

        [Obsolete]
        VaultResponse<Object> InternalCountRequests(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Backwards compatibility is not guaranteed for this API
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of InternalCountTokensResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<InternalCountTokensResponse> InternalCountTokens(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="genericMountPaths">Use generic mount paths (optional, default to false)</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> InternalGenerateOpenApiDocument(bool? genericMountPaths = default(bool?), TimeSpan? wrapTTL = null);

        /// <summary>
        /// Expose the route entry and mount entry tables present in the router
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Name of subtree being observed</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> InternalInspectRouter(string tag, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Lists enabled feature flags.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of InternalUiListEnabledFeatureFlagsResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<InternalUiListEnabledFeatureFlagsResponse> InternalUiListEnabledFeatureFlags(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Lists all enabled and visible auth and secrets mounts.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of InternalUiListEnabledVisibleMountsResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<InternalUiListEnabledVisibleMountsResponse> InternalUiListEnabledVisibleMounts(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Backwards compatibility is not guaranteed for this API
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of InternalUiListNamespacesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<InternalUiListNamespacesResponse> InternalUiListNamespaces(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Return information about the given mount.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path of the mount.</param>
        /// <returns>VaultResponse of InternalUiReadMountInformationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<InternalUiReadMountInformationResponse> InternalUiReadMountInformation(string path, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Backwards compatibility is not guaranteed for this API
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of InternalUiReadResultantAclResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<InternalUiReadResultantAclResponse> InternalUiReadResultantAcl(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns the high availability status and current leader instance of Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of LeaderStatusResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<LeaderStatusResponse> LeaderStatus(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of LeasesCountResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<LeasesCountResponse> LeasesCount(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Revokes all secrets or tokens generated under a given prefix immediately
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="prefix">The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LeasesForceRevokeLeaseWithPrefix(string prefix, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of LeasesListResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<LeasesListResponse> LeasesList(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of LeasesLookUpResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<LeasesLookUpResponse> LeasesLookUp(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="prefix">The path to list leases under. Example: \&quot;aws/creds/deploy\&quot;</param>
        /// <returns>VaultResponse of LeasesLookUpWithPrefixResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<LeasesLookUpWithPrefixResponse> LeasesLookUpWithPrefix(string prefix, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesReadLeaseRequest"></param>
        /// <returns>VaultResponse of LeasesReadLeaseResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<LeasesReadLeaseResponse> LeasesReadLease(LeasesReadLeaseRequest leasesReadLeaseRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Renews a lease, requesting to extend the lease.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRenewLeaseRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LeasesRenewLease(LeasesRenewLeaseRequest leasesRenewLeaseRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Renews a lease, requesting to extend the lease.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRenewLeaseWithIdRequest"></param>
        /// <param name="urlLeaseId">The lease identifier to renew. This is included with a lease.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LeasesRenewLeaseWithId(string urlLeaseId, LeasesRenewLeaseWithIdRequest leasesRenewLeaseWithIdRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Revokes a lease immediately.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRevokeLeaseRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LeasesRevokeLease(LeasesRevokeLeaseRequest leasesRevokeLeaseRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Revokes a lease immediately.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRevokeLeaseWithIdRequest"></param>
        /// <param name="urlLeaseId">The lease identifier to renew. This is included with a lease.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LeasesRevokeLeaseWithId(string urlLeaseId, LeasesRevokeLeaseWithIdRequest leasesRevokeLeaseWithIdRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Revokes all secrets (via a lease ID prefix) or tokens (via the tokens&#x27; path property) generated under a given prefix immediately.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRevokeLeaseWithPrefixRequest"></param>
        /// <param name="prefix">The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LeasesRevokeLeaseWithPrefix(string prefix, LeasesRevokeLeaseWithPrefixRequest leasesRevokeLeaseWithPrefixRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LeasesTidy(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns the available and enabled experiments
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> ListExperimentalFeatures(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Report the locked user count metrics, for this namespace and all child namespaces.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LockedUsersList(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Unlocks the user with given mount_accessor and alias_identifier
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasIdentifier">It is the name of the alias (user). For example, if the alias belongs to userpass backend, the name should be a valid username within userpass auth method. If the alias belongs to an approle auth method, the name should be a valid RoleID</param>
        /// <param name="mountAccessor">MountAccessor is the identifier of the mount entry to which the user belongs</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LockedUsersUnlock(string aliasIdentifier, string mountAccessor, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the log level for all existing loggers.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LoggersReadVerbosityLevel(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the log level for a single logger.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the logger to be modified.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LoggersReadVerbosityLevelFor(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Revert the all loggers to use log level provided in config.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LoggersRevertVerbosityLevel(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Revert a single logger to use log level provided in config.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the logger to be modified.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LoggersRevertVerbosityLevelFor(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Modify the log level for all existing loggers.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="loggersUpdateVerbosityLevelRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LoggersUpdateVerbosityLevel(LoggersUpdateVerbosityLevelRequest loggersUpdateVerbosityLevelRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Modify the log level of a single logger.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="loggersUpdateVerbosityLevelForRequest"></param>
        /// <param name="name">The name of the logger to be modified.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> LoggersUpdateVerbosityLevelFor(string name, LoggersUpdateVerbosityLevelForRequest loggersUpdateVerbosityLevelForRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="format">Format to export metrics into. Currently accepts only \&quot;prometheus\&quot;. (optional)</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> Metrics(string format = default(string), TimeSpan? wrapTTL = null);

        /// <summary>
        /// Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaValidateRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaValidate(MfaValidateRequest mfaValidateRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="logFormat">Output format of logs. Supported values are \&quot;standard\&quot; and \&quot;json\&quot;. The default is \&quot;standard\&quot;. (optional, default to &quot;standard&quot;)</param>

        /// <param name="logLevel">Log level to view system logs at. Currently supported values are \&quot;trace\&quot;, \&quot;debug\&quot;, \&quot;info\&quot;, \&quot;warn\&quot;, \&quot;error\&quot;. (optional)</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> Monitor(string logFormat = default(string), string logLevel = default(string), TimeSpan? wrapTTL = null);

        /// <summary>
        /// Disable the mount point specified at the given path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MountsDisableSecretsEngine(string path, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Enable a new secrets engine at the given path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mountsEnableSecretsEngineRequest"></param>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MountsEnableSecretsEngine(string path, MountsEnableSecretsEngineRequest mountsEnableSecretsEngineRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MountsListSecretsEngines(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the configuration of the secret engine at the given path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <returns>VaultResponse of MountsReadConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<MountsReadConfigurationResponse> MountsReadConfiguration(string path, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <returns>VaultResponse of MountsReadTuningInformationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<MountsReadTuningInformationResponse> MountsReadTuningInformation(string path, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mountsTuneConfigurationParametersRequest"></param>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MountsTuneConfigurationParameters(string path, MountsTuneConfigurationParametersRequest mountsTuneConfigurationParametersRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of PluginsCatalogListPluginsResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<PluginsCatalogListPluginsResponse> PluginsCatalogListPlugins(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List the plugins in the catalog.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <returns>VaultResponse of PluginsCatalogListPluginsWithTypeResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<PluginsCatalogListPluginsWithTypeResponse> PluginsCatalogListPluginsWithType(string type, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Return the configuration data for the plugin with the given name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <returns>VaultResponse of PluginsCatalogReadPluginConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<PluginsCatalogReadPluginConfigurationResponse> PluginsCatalogReadPluginConfiguration(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Return the configuration data for the plugin with the given name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <returns>VaultResponse of PluginsCatalogReadPluginConfigurationWithTypeResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<PluginsCatalogReadPluginConfigurationWithTypeResponse> PluginsCatalogReadPluginConfigurationWithType(string name, string type, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Register a new plugin, or updates an existing one with the supplied name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginsCatalogRegisterPluginRequest"></param>
        /// <param name="name">The name of the plugin</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PluginsCatalogRegisterPlugin(string name, PluginsCatalogRegisterPluginRequest pluginsCatalogRegisterPluginRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Register a new plugin, or updates an existing one with the supplied name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginsCatalogRegisterPluginWithTypeRequest"></param>
        /// <param name="name">The name of the plugin</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PluginsCatalogRegisterPluginWithType(string name, string type, PluginsCatalogRegisterPluginWithTypeRequest pluginsCatalogRegisterPluginWithTypeRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Remove the plugin with the given name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PluginsCatalogRemovePlugin(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Remove the plugin with the given name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PluginsCatalogRemovePluginWithType(string name, string type, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Reload mounted plugin backends.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginsReloadBackendsRequest"></param>
        /// <returns>VaultResponse of PluginsReloadBackendsResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<PluginsReloadBackendsResponse> PluginsReloadBackends(PluginsReloadBackendsRequest pluginsReloadBackendsRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete the ACL policy with the given name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the policy. Example: \&quot;ops\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PoliciesDeleteAclPolicy(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete a password policy.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the password policy.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PoliciesDeletePasswordPolicy(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Generate a password from an existing password policy.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the password policy.</param>
        /// <returns>VaultResponse of PoliciesGeneratePasswordFromPasswordPolicyResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<PoliciesGeneratePasswordFromPasswordPolicyResponse> PoliciesGeneratePasswordFromPasswordPolicy(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="list">Return a list if &#x60;true&#x60; (optional)</param>
        /// <returns>VaultResponse of PoliciesListResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<PoliciesListResponse> PoliciesList(string list = default(string), TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of PoliciesListAclPoliciesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<PoliciesListAclPoliciesResponse> PoliciesListAclPolicies(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List the existing password policies.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of PoliciesListPasswordPoliciesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<PoliciesListPasswordPoliciesResponse> PoliciesListPasswordPolicies(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Retrieve information about the named ACL policy.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the policy. Example: \&quot;ops\&quot;</param>
        /// <returns>VaultResponse of PoliciesReadAclPolicyResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<PoliciesReadAclPolicyResponse> PoliciesReadAclPolicy(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Retrieve an existing password policy.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the password policy.</param>
        /// <returns>VaultResponse of PoliciesReadPasswordPolicyResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<PoliciesReadPasswordPolicyResponse> PoliciesReadPasswordPolicy(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Add a new or update an existing ACL policy.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="policiesWriteAclPolicyRequest"></param>
        /// <param name="name">The name of the policy. Example: \&quot;ops\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PoliciesWriteAclPolicy(string name, PoliciesWriteAclPolicyRequest policiesWriteAclPolicyRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Add a new or update an existing password policy.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="policiesWritePasswordPolicyRequest"></param>
        /// <param name="name">The name of the password policy.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PoliciesWritePasswordPolicy(string name, PoliciesWritePasswordPolicyRequest policiesWritePasswordPolicyRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns stack traces that led to blocking on synchronization primitives
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PprofBlocking(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns the running program&#x27;s command line.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PprofCommandLine(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns a pprof-formatted cpu profile payload.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PprofCpuProfile(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns the execution trace in binary form.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PprofExecutionTrace(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns stack traces of all current goroutines.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PprofGoroutines(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns an HTML page listing the available profiles.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PprofIndex(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns a sampling of all past memory allocations.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PprofMemoryAllocations(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns a sampling of memory allocations of live object.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PprofMemoryAllocationsLive(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns stack traces of holders of contended mutexes
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PprofMutexes(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns the program counters listed in the request.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PprofSymbols(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns stack traces that led to the creation of new OS threads
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PprofThreadCreations(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="queryTokenAccessorCapabilitiesRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> QueryTokenAccessorCapabilities(QueryTokenAccessorCapabilitiesRequest queryTokenAccessorCapabilitiesRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="queryTokenCapabilitiesRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> QueryTokenCapabilities(QueryTokenCapabilitiesRequest queryTokenCapabilitiesRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="queryTokenSelfCapabilitiesRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> QueryTokenSelfCapabilities(QueryTokenSelfCapabilitiesRequest queryTokenSelfCapabilitiesRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rateLimitQuotasConfigureRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> RateLimitQuotasConfigure(RateLimitQuotasConfigureRequest rateLimitQuotasConfigureRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the quota rule.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> RateLimitQuotasDelete(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RateLimitQuotasListResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RateLimitQuotasListResponse> RateLimitQuotasList(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the quota rule.</param>
        /// <returns>VaultResponse of RateLimitQuotasReadResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RateLimitQuotasReadResponse> RateLimitQuotasRead(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RateLimitQuotasReadConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RateLimitQuotasReadConfigurationResponse> RateLimitQuotasReadConfiguration(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rateLimitQuotasWriteRequest"></param>
        /// <param name="name">Name of the quota rule.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> RateLimitQuotasWrite(string name, RateLimitQuotasWriteRequest rateLimitQuotasWriteRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns the health status of Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> ReadHealthStatus(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns the initialization status of Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> ReadInitializationStatus(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Return a sanitized version of the Vault server configuration.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> ReadSanitizedConfigurationState(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Look up wrapping properties for the given token.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="readWrappingPropertiesRequest"></param>
        /// <returns>VaultResponse of ReadWrappingPropertiesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<ReadWrappingPropertiesResponse> ReadWrappingProperties(ReadWrappingPropertiesRequest readWrappingPropertiesRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Cancels any in-progress rekey.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> RekeyAttemptCancel(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Initializes a new rekey attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rekeyAttemptInitializeRequest"></param>
        /// <returns>VaultResponse of RekeyAttemptInitializeResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RekeyAttemptInitializeResponse> RekeyAttemptInitialize(RekeyAttemptInitializeRequest rekeyAttemptInitializeRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Reads the configuration and progress of the current rekey attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RekeyAttemptReadProgressResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RekeyAttemptReadProgressResponse> RekeyAttemptReadProgress(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Enter a single unseal key share to progress the rekey of the Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rekeyAttemptUpdateRequest"></param>
        /// <returns>VaultResponse of RekeyAttemptUpdateResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RekeyAttemptUpdateResponse> RekeyAttemptUpdate(RekeyAttemptUpdateRequest rekeyAttemptUpdateRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete the backup copy of PGP-encrypted unseal keys.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> RekeyDeleteBackupKey(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> RekeyDeleteBackupRecoveryKey(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Return the backup copy of PGP-encrypted unseal keys.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RekeyReadBackupKeyResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RekeyReadBackupKeyResponse> RekeyReadBackupKey(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RekeyReadBackupRecoveryKeyResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RekeyReadBackupRecoveryKeyResponse> RekeyReadBackupRecoveryKey(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Cancel any in-progress rekey verification operation.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RekeyVerificationCancelResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RekeyVerificationCancelResponse> RekeyVerificationCancel(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the configuration and progress of the current rekey verification attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RekeyVerificationReadProgressResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RekeyVerificationReadProgressResponse> RekeyVerificationReadProgress(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Enter a single new key share to progress the rekey verification operation.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rekeyVerificationUpdateRequest"></param>
        /// <returns>VaultResponse of RekeyVerificationUpdateResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RekeyVerificationUpdateResponse> RekeyVerificationUpdate(RekeyVerificationUpdateRequest rekeyVerificationUpdateRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Reload the given subsystem
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="subsystem"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> ReloadSubsystem(string subsystem, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Initiate a mount migration
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="remountRequest"></param>
        /// <returns>VaultResponse of RemountResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RemountResponse> Remount(RemountRequest remountRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Check status of a mount migration
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="migrationId">The ID of the migration operation</param>
        /// <returns>VaultResponse of RemountStatusResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RemountStatusResponse> RemountStatus(string migrationId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> ReplicationStatus(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rewrapRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> Rewrap(RewrapRequest rewrapRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Cancels any in-progress root generation attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> RootTokenGenerationCancel(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Initializes a new root generation attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rootTokenGenerationInitializeRequest"></param>
        /// <returns>VaultResponse of RootTokenGenerationInitializeResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RootTokenGenerationInitializeResponse> RootTokenGenerationInitialize(RootTokenGenerationInitializeRequest rootTokenGenerationInitializeRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the configuration and progress of the current root generation attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RootTokenGenerationReadProgressResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RootTokenGenerationReadProgressResponse> RootTokenGenerationReadProgress(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Enter a single unseal key share to progress the root generation attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rootTokenGenerationUpdateRequest"></param>
        /// <returns>VaultResponse of RootTokenGenerationUpdateResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<RootTokenGenerationUpdateResponse> RootTokenGenerationUpdate(RootTokenGenerationUpdateRequest rootTokenGenerationUpdateRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Seal the Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> Seal(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Check the seal status of a Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of SealStatusResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<SealStatusResponse> SealStatus(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Cause the node to give up active status.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> StepDownLeader(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Configure the values to be returned for the UI header.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="uiHeadersConfigureRequest"></param>
        /// <param name="header">The name of the header.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> UiHeadersConfigure(string header, UiHeadersConfigureRequest uiHeadersConfigureRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Remove a UI header.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header">The name of the header.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> UiHeadersDeleteConfiguration(string header, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Return a list of configured UI headers.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of UiHeadersListResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<UiHeadersListResponse> UiHeadersList(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Return the given UI header&#x27;s configuration
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header">The name of the header.</param>
        /// <returns>VaultResponse of UiHeadersReadConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<UiHeadersReadConfigurationResponse> UiHeadersReadConfiguration(string header, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Unseal the Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="unsealRequest"></param>
        /// <returns>VaultResponse of UnsealResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<UnsealResponse> Unseal(UnsealRequest unsealRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="unwrapRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> Unwrap(UnwrapRequest unwrapRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Returns map of historical version change entries
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of VersionHistoryResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<VersionHistoryResponse> VersionHistory(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> Wrap(TimeSpan? wrapTTL = null);

        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystemAsync : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="auditingCalculateHashRequest"></param>
        /// <param name="path">The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (AuditingCalculateHashResponse)</returns>
        Task<VaultResponse<AuditingCalculateHashResponse>> AuditingCalculateHashAsync(string path, AuditingCalculateHashRequest auditingCalculateHashRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Disable the audit device at the given path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AuditingDisableDeviceAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Disable auditing of the given request header.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AuditingDisableRequestHeaderAsync(string header, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Enable a new audit device at the supplied path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="auditingEnableDeviceRequest"></param>
        /// <param name="path">The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AuditingEnableDeviceAsync(string path, AuditingEnableDeviceRequest auditingEnableDeviceRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Enable auditing of a header.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="auditingEnableRequestHeaderRequest"></param>
        /// <param name="header"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AuditingEnableRequestHeaderAsync(string header, AuditingEnableRequestHeaderRequest auditingEnableRequestHeaderRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List the enabled audit devices.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AuditingListEnabledDevicesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List the request headers that are configured to be audited.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (AuditingListRequestHeadersResponse)</returns>
        Task<VaultResponse<AuditingListRequestHeadersResponse>> AuditingListRequestHeadersAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List the information for the given request header.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AuditingReadRequestHeaderInformationAsync(string header, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Disable the auth method at the given auth path
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Cannot be delimited. Example: \&quot;user\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AuthDisableMethodAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Enables a new auth method.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="authEnableMethodRequest"></param>
        /// <param name="path">The path to mount to. Cannot be delimited. Example: \&quot;user\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AuthEnableMethodAsync(string path, AuthEnableMethodRequest authEnableMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AuthListEnabledMethodsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the configuration of the auth engine at the given path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Cannot be delimited. Example: \&quot;user\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (AuthReadConfigurationResponse)</returns>
        Task<VaultResponse<AuthReadConfigurationResponse>> AuthReadConfigurationAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Reads the given auth path&#x27;s configuration.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Tune the configuration parameters for an auth path.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (AuthReadTuningInformationResponse)</returns>
        Task<VaultResponse<AuthReadTuningInformationResponse>> AuthReadTuningInformationAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Tune configuration parameters for a given auth path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="authTuneConfigurationParametersRequest"></param>
        /// <param name="path">Tune the configuration parameters for an auth path.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AuthTuneConfigurationParametersAsync(string path, AuthTuneConfigurationParametersRequest authTuneConfigurationParametersRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Information about the host instance that this Vault server is running on.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (CollectHostInformationResponse)</returns>
        Task<VaultResponse<CollectHostInformationResponse>> CollectHostInformationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// reports in-flight requests
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> CollectInFlightRequestInformationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Configure the CORS settings.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="corsConfigureRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> CorsConfigureAsync(CorsConfigureRequest corsConfigureRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove any CORS settings.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> CorsDeleteConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Return the current CORS settings.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (CorsReadConfigurationResponse)</returns>
        Task<VaultResponse<CorsReadConfigurationResponse>> CorsReadConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyConfigureRotationRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EncryptionKeyConfigureRotationAsync(EncryptionKeyConfigureRotationRequest encryptionKeyConfigureRotationRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (EncryptionKeyReadRotationConfigurationResponse)</returns>
        Task<VaultResponse<EncryptionKeyReadRotationConfigurationResponse>> EncryptionKeyReadRotationConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EncryptionKeyRotateAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Provides information about the backend encryption key.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EncryptionKeyStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateHashRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (GenerateHashResponse)</returns>
        Task<VaultResponse<GenerateHashResponse>> GenerateHashAsync(GenerateHashRequest generateHashRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateHashWithAlgorithmRequest"></param>
        /// <param name="urlalgorithm">Algorithm to use (POST URL parameter)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (GenerateHashWithAlgorithmResponse)</returns>
        Task<VaultResponse<GenerateHashWithAlgorithmResponse>> GenerateHashWithAlgorithmAsync(string urlalgorithm, GenerateHashWithAlgorithmRequest generateHashWithAlgorithmRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (GenerateRandomResponse)</returns>
        Task<VaultResponse<GenerateRandomResponse>> GenerateRandomAsync(GenerateRandomRequest generateRandomRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomWithBytesRequest"></param>
        /// <param name="urlbytes">The number of bytes to generate (POST URL parameter)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (GenerateRandomWithBytesResponse)</returns>
        Task<VaultResponse<GenerateRandomWithBytesResponse>> GenerateRandomWithBytesAsync(string urlbytes, GenerateRandomWithBytesRequest generateRandomWithBytesRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomWithSourceRequest"></param>
        /// <param name="source">Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (GenerateRandomWithSourceResponse)</returns>
        Task<VaultResponse<GenerateRandomWithSourceResponse>> GenerateRandomWithSourceAsync(string source, GenerateRandomWithSourceRequest generateRandomWithSourceRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomWithSourceAndBytesRequest"></param>
        /// <param name="source">Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;.</param>
        /// <param name="urlbytes">The number of bytes to generate (POST URL parameter)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (GenerateRandomWithSourceAndBytesResponse)</returns>
        Task<VaultResponse<GenerateRandomWithSourceAndBytesResponse>> GenerateRandomWithSourceAndBytesAsync(string source, string urlbytes, GenerateRandomWithSourceAndBytesRequest generateRandomWithSourceAndBytesRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Check the HA status of a Vault cluster
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (HaStatusResponse)</returns>
        Task<VaultResponse<HaStatusResponse>> HaStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initialize a new Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="initializeRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> InitializeAsync(InitializeRequest initializeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Enable or disable collection of client count, set retention period, or set default reporting period.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="internalClientActivityConfigureRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> InternalClientActivityConfigureAsync(InternalClientActivityConfigureRequest internalClientActivityConfigureRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Report the client count metrics, for this namespace and all child namespaces.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> InternalClientActivityExportAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the client count tracking configuration.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> InternalClientActivityReadConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Report the client count metrics, for this namespace and all child namespaces.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> InternalClientActivityReportCountsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Report the number of clients for this month, for this namespace and all child namespaces.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> InternalClientActivityReportCountsThisMonthAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Backwards compatibility is not guaranteed for this API
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalCountEntitiesResponse)</returns>
        Task<VaultResponse<InternalCountEntitiesResponse>> InternalCountEntitiesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Backwards compatibility is not guaranteed for this API
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>

        [Obsolete]
        Task<VaultResponse<Object>> InternalCountRequestsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Backwards compatibility is not guaranteed for this API
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalCountTokensResponse)</returns>
        Task<VaultResponse<InternalCountTokensResponse>> InternalCountTokensAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="genericMountPaths">Use generic mount paths (optional, default to false)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> InternalGenerateOpenApiDocumentAsync(bool? genericMountPaths = default(bool?), TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Expose the route entry and mount entry tables present in the router
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Name of subtree being observed</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> InternalInspectRouterAsync(string tag, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Lists enabled feature flags.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalUiListEnabledFeatureFlagsResponse)</returns>
        Task<VaultResponse<InternalUiListEnabledFeatureFlagsResponse>> InternalUiListEnabledFeatureFlagsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Lists all enabled and visible auth and secrets mounts.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalUiListEnabledVisibleMountsResponse)</returns>
        Task<VaultResponse<InternalUiListEnabledVisibleMountsResponse>> InternalUiListEnabledVisibleMountsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Backwards compatibility is not guaranteed for this API
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalUiListNamespacesResponse)</returns>
        Task<VaultResponse<InternalUiListNamespacesResponse>> InternalUiListNamespacesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Return information about the given mount.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path of the mount.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalUiReadMountInformationResponse)</returns>
        Task<VaultResponse<InternalUiReadMountInformationResponse>> InternalUiReadMountInformationAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Backwards compatibility is not guaranteed for this API
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalUiReadResultantAclResponse)</returns>
        Task<VaultResponse<InternalUiReadResultantAclResponse>> InternalUiReadResultantAclAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the high availability status and current leader instance of Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (LeaderStatusResponse)</returns>
        Task<VaultResponse<LeaderStatusResponse>> LeaderStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (LeasesCountResponse)</returns>
        Task<VaultResponse<LeasesCountResponse>> LeasesCountAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Revokes all secrets or tokens generated under a given prefix immediately
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="prefix">The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LeasesForceRevokeLeaseWithPrefixAsync(string prefix, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (LeasesListResponse)</returns>
        Task<VaultResponse<LeasesListResponse>> LeasesListAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (LeasesLookUpResponse)</returns>
        Task<VaultResponse<LeasesLookUpResponse>> LeasesLookUpAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="prefix">The path to list leases under. Example: \&quot;aws/creds/deploy\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (LeasesLookUpWithPrefixResponse)</returns>
        Task<VaultResponse<LeasesLookUpWithPrefixResponse>> LeasesLookUpWithPrefixAsync(string prefix, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesReadLeaseRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (LeasesReadLeaseResponse)</returns>
        Task<VaultResponse<LeasesReadLeaseResponse>> LeasesReadLeaseAsync(LeasesReadLeaseRequest leasesReadLeaseRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Renews a lease, requesting to extend the lease.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRenewLeaseRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LeasesRenewLeaseAsync(LeasesRenewLeaseRequest leasesRenewLeaseRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Renews a lease, requesting to extend the lease.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRenewLeaseWithIdRequest"></param>
        /// <param name="urlLeaseId">The lease identifier to renew. This is included with a lease.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LeasesRenewLeaseWithIdAsync(string urlLeaseId, LeasesRenewLeaseWithIdRequest leasesRenewLeaseWithIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Revokes a lease immediately.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRevokeLeaseRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LeasesRevokeLeaseAsync(LeasesRevokeLeaseRequest leasesRevokeLeaseRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Revokes a lease immediately.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRevokeLeaseWithIdRequest"></param>
        /// <param name="urlLeaseId">The lease identifier to renew. This is included with a lease.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LeasesRevokeLeaseWithIdAsync(string urlLeaseId, LeasesRevokeLeaseWithIdRequest leasesRevokeLeaseWithIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Revokes all secrets (via a lease ID prefix) or tokens (via the tokens&#x27; path property) generated under a given prefix immediately.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRevokeLeaseWithPrefixRequest"></param>
        /// <param name="prefix">The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LeasesRevokeLeaseWithPrefixAsync(string prefix, LeasesRevokeLeaseWithPrefixRequest leasesRevokeLeaseWithPrefixRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LeasesTidyAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the available and enabled experiments
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> ListExperimentalFeaturesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Report the locked user count metrics, for this namespace and all child namespaces.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LockedUsersListAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Unlocks the user with given mount_accessor and alias_identifier
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasIdentifier">It is the name of the alias (user). For example, if the alias belongs to userpass backend, the name should be a valid username within userpass auth method. If the alias belongs to an approle auth method, the name should be a valid RoleID</param>
        /// <param name="mountAccessor">MountAccessor is the identifier of the mount entry to which the user belongs</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LockedUsersUnlockAsync(string aliasIdentifier, string mountAccessor, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the log level for all existing loggers.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LoggersReadVerbosityLevelAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the log level for a single logger.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the logger to be modified.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LoggersReadVerbosityLevelForAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Revert the all loggers to use log level provided in config.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LoggersRevertVerbosityLevelAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Revert a single logger to use log level provided in config.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the logger to be modified.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LoggersRevertVerbosityLevelForAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Modify the log level for all existing loggers.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="loggersUpdateVerbosityLevelRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LoggersUpdateVerbosityLevelAsync(LoggersUpdateVerbosityLevelRequest loggersUpdateVerbosityLevelRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Modify the log level of a single logger.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="loggersUpdateVerbosityLevelForRequest"></param>
        /// <param name="name">The name of the logger to be modified.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> LoggersUpdateVerbosityLevelForAsync(string name, LoggersUpdateVerbosityLevelForRequest loggersUpdateVerbosityLevelForRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="format">Format to export metrics into. Currently accepts only \&quot;prometheus\&quot;. (optional)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MetricsAsync(string format = default(string), TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaValidateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaValidateAsync(MfaValidateRequest mfaValidateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="logFormat">Output format of logs. Supported values are \&quot;standard\&quot; and \&quot;json\&quot;. The default is \&quot;standard\&quot;. (optional, default to &quot;standard&quot;)</param>

        /// <param name="logLevel">Log level to view system logs at. Currently supported values are \&quot;trace\&quot;, \&quot;debug\&quot;, \&quot;info\&quot;, \&quot;warn\&quot;, \&quot;error\&quot;. (optional)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MonitorAsync(string logFormat = default(string), string logLevel = default(string), TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Disable the mount point specified at the given path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MountsDisableSecretsEngineAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Enable a new secrets engine at the given path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mountsEnableSecretsEngineRequest"></param>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MountsEnableSecretsEngineAsync(string path, MountsEnableSecretsEngineRequest mountsEnableSecretsEngineRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MountsListSecretsEnginesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the configuration of the secret engine at the given path.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (MountsReadConfigurationResponse)</returns>
        Task<VaultResponse<MountsReadConfigurationResponse>> MountsReadConfigurationAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (MountsReadTuningInformationResponse)</returns>
        Task<VaultResponse<MountsReadTuningInformationResponse>> MountsReadTuningInformationAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mountsTuneConfigurationParametersRequest"></param>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MountsTuneConfigurationParametersAsync(string path, MountsTuneConfigurationParametersRequest mountsTuneConfigurationParametersRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PluginsCatalogListPluginsResponse)</returns>
        Task<VaultResponse<PluginsCatalogListPluginsResponse>> PluginsCatalogListPluginsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List the plugins in the catalog.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PluginsCatalogListPluginsWithTypeResponse)</returns>
        Task<VaultResponse<PluginsCatalogListPluginsWithTypeResponse>> PluginsCatalogListPluginsWithTypeAsync(string type, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Return the configuration data for the plugin with the given name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PluginsCatalogReadPluginConfigurationResponse)</returns>
        Task<VaultResponse<PluginsCatalogReadPluginConfigurationResponse>> PluginsCatalogReadPluginConfigurationAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Return the configuration data for the plugin with the given name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PluginsCatalogReadPluginConfigurationWithTypeResponse)</returns>
        Task<VaultResponse<PluginsCatalogReadPluginConfigurationWithTypeResponse>> PluginsCatalogReadPluginConfigurationWithTypeAsync(string name, string type, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Register a new plugin, or updates an existing one with the supplied name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginsCatalogRegisterPluginRequest"></param>
        /// <param name="name">The name of the plugin</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PluginsCatalogRegisterPluginAsync(string name, PluginsCatalogRegisterPluginRequest pluginsCatalogRegisterPluginRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Register a new plugin, or updates an existing one with the supplied name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginsCatalogRegisterPluginWithTypeRequest"></param>
        /// <param name="name">The name of the plugin</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PluginsCatalogRegisterPluginWithTypeAsync(string name, string type, PluginsCatalogRegisterPluginWithTypeRequest pluginsCatalogRegisterPluginWithTypeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove the plugin with the given name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PluginsCatalogRemovePluginAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove the plugin with the given name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PluginsCatalogRemovePluginWithTypeAsync(string name, string type, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Reload mounted plugin backends.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginsReloadBackendsRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PluginsReloadBackendsResponse)</returns>
        Task<VaultResponse<PluginsReloadBackendsResponse>> PluginsReloadBackendsAsync(PluginsReloadBackendsRequest pluginsReloadBackendsRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete the ACL policy with the given name.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the policy. Example: \&quot;ops\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PoliciesDeleteAclPolicyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete a password policy.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the password policy.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PoliciesDeletePasswordPolicyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate a password from an existing password policy.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the password policy.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PoliciesGeneratePasswordFromPasswordPolicyResponse)</returns>
        Task<VaultResponse<PoliciesGeneratePasswordFromPasswordPolicyResponse>> PoliciesGeneratePasswordFromPasswordPolicyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="list">Return a list if &#x60;true&#x60; (optional)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PoliciesListResponse)</returns>
        Task<VaultResponse<PoliciesListResponse>> PoliciesListAsync(string list = default(string), TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PoliciesListAclPoliciesResponse)</returns>
        Task<VaultResponse<PoliciesListAclPoliciesResponse>> PoliciesListAclPoliciesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List the existing password policies.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PoliciesListPasswordPoliciesResponse)</returns>
        Task<VaultResponse<PoliciesListPasswordPoliciesResponse>> PoliciesListPasswordPoliciesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve information about the named ACL policy.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the policy. Example: \&quot;ops\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PoliciesReadAclPolicyResponse)</returns>
        Task<VaultResponse<PoliciesReadAclPolicyResponse>> PoliciesReadAclPolicyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve an existing password policy.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the password policy.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PoliciesReadPasswordPolicyResponse)</returns>
        Task<VaultResponse<PoliciesReadPasswordPolicyResponse>> PoliciesReadPasswordPolicyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Add a new or update an existing ACL policy.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="policiesWriteAclPolicyRequest"></param>
        /// <param name="name">The name of the policy. Example: \&quot;ops\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PoliciesWriteAclPolicyAsync(string name, PoliciesWriteAclPolicyRequest policiesWriteAclPolicyRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Add a new or update an existing password policy.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="policiesWritePasswordPolicyRequest"></param>
        /// <param name="name">The name of the password policy.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PoliciesWritePasswordPolicyAsync(string name, PoliciesWritePasswordPolicyRequest policiesWritePasswordPolicyRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns stack traces that led to blocking on synchronization primitives
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PprofBlockingAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the running program&#x27;s command line.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PprofCommandLineAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns a pprof-formatted cpu profile payload.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PprofCpuProfileAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the execution trace in binary form.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PprofExecutionTraceAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns stack traces of all current goroutines.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PprofGoroutinesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns an HTML page listing the available profiles.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PprofIndexAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns a sampling of all past memory allocations.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PprofMemoryAllocationsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns a sampling of memory allocations of live object.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PprofMemoryAllocationsLiveAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns stack traces of holders of contended mutexes
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PprofMutexesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the program counters listed in the request.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PprofSymbolsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns stack traces that led to the creation of new OS threads
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PprofThreadCreationsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="queryTokenAccessorCapabilitiesRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> QueryTokenAccessorCapabilitiesAsync(QueryTokenAccessorCapabilitiesRequest queryTokenAccessorCapabilitiesRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="queryTokenCapabilitiesRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> QueryTokenCapabilitiesAsync(QueryTokenCapabilitiesRequest queryTokenCapabilitiesRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="queryTokenSelfCapabilitiesRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> QueryTokenSelfCapabilitiesAsync(QueryTokenSelfCapabilitiesRequest queryTokenSelfCapabilitiesRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rateLimitQuotasConfigureRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> RateLimitQuotasConfigureAsync(RateLimitQuotasConfigureRequest rateLimitQuotasConfigureRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the quota rule.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> RateLimitQuotasDeleteAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RateLimitQuotasListResponse)</returns>
        Task<VaultResponse<RateLimitQuotasListResponse>> RateLimitQuotasListAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the quota rule.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RateLimitQuotasReadResponse)</returns>
        Task<VaultResponse<RateLimitQuotasReadResponse>> RateLimitQuotasReadAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RateLimitQuotasReadConfigurationResponse)</returns>
        Task<VaultResponse<RateLimitQuotasReadConfigurationResponse>> RateLimitQuotasReadConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rateLimitQuotasWriteRequest"></param>
        /// <param name="name">Name of the quota rule.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> RateLimitQuotasWriteAsync(string name, RateLimitQuotasWriteRequest rateLimitQuotasWriteRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the health status of Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> ReadHealthStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns the initialization status of Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> ReadInitializationStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Return a sanitized version of the Vault server configuration.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> ReadSanitizedConfigurationStateAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Look up wrapping properties for the given token.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="readWrappingPropertiesRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (ReadWrappingPropertiesResponse)</returns>
        Task<VaultResponse<ReadWrappingPropertiesResponse>> ReadWrappingPropertiesAsync(ReadWrappingPropertiesRequest readWrappingPropertiesRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Cancels any in-progress rekey.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> RekeyAttemptCancelAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initializes a new rekey attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rekeyAttemptInitializeRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyAttemptInitializeResponse)</returns>
        Task<VaultResponse<RekeyAttemptInitializeResponse>> RekeyAttemptInitializeAsync(RekeyAttemptInitializeRequest rekeyAttemptInitializeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Reads the configuration and progress of the current rekey attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyAttemptReadProgressResponse)</returns>
        Task<VaultResponse<RekeyAttemptReadProgressResponse>> RekeyAttemptReadProgressAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Enter a single unseal key share to progress the rekey of the Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rekeyAttemptUpdateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyAttemptUpdateResponse)</returns>
        Task<VaultResponse<RekeyAttemptUpdateResponse>> RekeyAttemptUpdateAsync(RekeyAttemptUpdateRequest rekeyAttemptUpdateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete the backup copy of PGP-encrypted unseal keys.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> RekeyDeleteBackupKeyAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> RekeyDeleteBackupRecoveryKeyAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Return the backup copy of PGP-encrypted unseal keys.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyReadBackupKeyResponse)</returns>
        Task<VaultResponse<RekeyReadBackupKeyResponse>> RekeyReadBackupKeyAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyReadBackupRecoveryKeyResponse)</returns>
        Task<VaultResponse<RekeyReadBackupRecoveryKeyResponse>> RekeyReadBackupRecoveryKeyAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Cancel any in-progress rekey verification operation.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyVerificationCancelResponse)</returns>
        Task<VaultResponse<RekeyVerificationCancelResponse>> RekeyVerificationCancelAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the configuration and progress of the current rekey verification attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyVerificationReadProgressResponse)</returns>
        Task<VaultResponse<RekeyVerificationReadProgressResponse>> RekeyVerificationReadProgressAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Enter a single new key share to progress the rekey verification operation.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rekeyVerificationUpdateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyVerificationUpdateResponse)</returns>
        Task<VaultResponse<RekeyVerificationUpdateResponse>> RekeyVerificationUpdateAsync(RekeyVerificationUpdateRequest rekeyVerificationUpdateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Reload the given subsystem
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="subsystem"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> ReloadSubsystemAsync(string subsystem, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initiate a mount migration
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="remountRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RemountResponse)</returns>
        Task<VaultResponse<RemountResponse>> RemountAsync(RemountRequest remountRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Check status of a mount migration
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="migrationId">The ID of the migration operation</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RemountStatusResponse)</returns>
        Task<VaultResponse<RemountStatusResponse>> RemountStatusAsync(string migrationId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> ReplicationStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rewrapRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> RewrapAsync(RewrapRequest rewrapRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Cancels any in-progress root generation attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> RootTokenGenerationCancelAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Initializes a new root generation attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rootTokenGenerationInitializeRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RootTokenGenerationInitializeResponse)</returns>
        Task<VaultResponse<RootTokenGenerationInitializeResponse>> RootTokenGenerationInitializeAsync(RootTokenGenerationInitializeRequest rootTokenGenerationInitializeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the configuration and progress of the current root generation attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RootTokenGenerationReadProgressResponse)</returns>
        Task<VaultResponse<RootTokenGenerationReadProgressResponse>> RootTokenGenerationReadProgressAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Enter a single unseal key share to progress the root generation attempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rootTokenGenerationUpdateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RootTokenGenerationUpdateResponse)</returns>
        Task<VaultResponse<RootTokenGenerationUpdateResponse>> RootTokenGenerationUpdateAsync(RootTokenGenerationUpdateRequest rootTokenGenerationUpdateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Seal the Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> SealAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Check the seal status of a Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (SealStatusResponse)</returns>
        Task<VaultResponse<SealStatusResponse>> SealStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Cause the node to give up active status.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> StepDownLeaderAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Configure the values to be returned for the UI header.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="uiHeadersConfigureRequest"></param>
        /// <param name="header">The name of the header.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> UiHeadersConfigureAsync(string header, UiHeadersConfigureRequest uiHeadersConfigureRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Remove a UI header.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header">The name of the header.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> UiHeadersDeleteConfigurationAsync(string header, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Return a list of configured UI headers.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (UiHeadersListResponse)</returns>
        Task<VaultResponse<UiHeadersListResponse>> UiHeadersListAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Return the given UI header&#x27;s configuration
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header">The name of the header.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (UiHeadersReadConfigurationResponse)</returns>
        Task<VaultResponse<UiHeadersReadConfigurationResponse>> UiHeadersReadConfigurationAsync(string header, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Unseal the Vault.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="unsealRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (UnsealResponse)</returns>
        Task<VaultResponse<UnsealResponse>> UnsealAsync(UnsealRequest unsealRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="unwrapRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> UnwrapAsync(UnwrapRequest unwrapRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Returns map of historical version change entries
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (VersionHistoryResponse)</returns>
        Task<VaultResponse<VersionHistoryResponse>> VersionHistoryAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> WrapAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        #endregion Asynchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISystem : ISystemSync, ISystemAsync { }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class System : ISystem
    {
        private Vault.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Constructor for System
        /// </summary>
        public System(ApiClient apiClient)
        {
            if (apiClient == null) throw new ArgumentNullException("ApiClient");

            this.Configuration = apiClient.Configuration;
            this.Client = apiClient;
            this.AsynchronousClient = apiClient;
            this.ExceptionFactory = VaultConfiguration.DefaultExceptionFactory;
        }


        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Vault.Client.IAsynchronousClient AsynchronousClient { get; set; }


        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Vault.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public VaultConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Vault.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="auditingCalculateHashRequest"></param>
        /// <param name="path">The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot;</param>
        /// <returns>VaultResponse of AuditingCalculateHashResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<AuditingCalculateHashResponse> AuditingCalculateHash(string path, AuditingCalculateHashRequest auditingCalculateHashRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuditingCalculateHash");


            // verify the required parameter 'auditingCalculateHashRequest' is set
            if (auditingCalculateHashRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'auditingCalculateHashRequest' when calling System->AuditingCalculateHash");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter





            requestOptions.Data = auditingCalculateHashRequest;


            // make the HTTP request
            var response = this.Client.Post<AuditingCalculateHashResponse>("/sys/audit-hash/{path}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingCalculateHash", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<AuditingCalculateHashResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="auditingCalculateHashRequest"></param>
        /// <param name="path">The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (AuditingCalculateHashResponse)</returns>
        public async Task<VaultResponse<AuditingCalculateHashResponse>> AuditingCalculateHashAsync(string path, AuditingCalculateHashRequest auditingCalculateHashRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuditingCalculateHash");


            // verify the required parameter 'auditingCalculateHashRequest' is set
            if (auditingCalculateHashRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'auditingCalculateHashRequest' when calling System->AuditingCalculateHash");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            requestOptions.Data = auditingCalculateHashRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<AuditingCalculateHashResponse>("/sys/audit-hash/{path}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingCalculateHash", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<AuditingCalculateHashResponse>(response.RawContent);
        }
        /// <summary>
        /// Disable the audit device at the given path. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AuditingDisableDevice(string path, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuditingDisableDevice");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/audit/{path}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingDisableDevice", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Disable the audit device at the given path. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AuditingDisableDeviceAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuditingDisableDevice");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/audit/{path}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingDisableDevice", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Disable auditing of the given request header. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AuditingDisableRequestHeader(string header, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'header' is set
            if (header == null)
                throw new VaultApiException(400, "Missing required parameter 'header' when calling System->AuditingDisableRequestHeader");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("header", ClientUtils.ParameterToString(header)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/config/auditing/request-headers/{header}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingDisableRequestHeader", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Disable auditing of the given request header. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AuditingDisableRequestHeaderAsync(string header, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'header' is set
            if (header == null)
                throw new VaultApiException(400, "Missing required parameter 'header' when calling System->AuditingDisableRequestHeader");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("header", ClientUtils.ParameterToString(header)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/config/auditing/request-headers/{header}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingDisableRequestHeader", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Enable a new audit device at the supplied path. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="auditingEnableDeviceRequest"></param>
        /// <param name="path">The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AuditingEnableDevice(string path, AuditingEnableDeviceRequest auditingEnableDeviceRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuditingEnableDevice");


            // verify the required parameter 'auditingEnableDeviceRequest' is set
            if (auditingEnableDeviceRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'auditingEnableDeviceRequest' when calling System->AuditingEnableDevice");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter





            requestOptions.Data = auditingEnableDeviceRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/audit/{path}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingEnableDevice", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Enable a new audit device at the supplied path. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="auditingEnableDeviceRequest"></param>
        /// <param name="path">The name of the backend. Cannot be delimited. Example: \&quot;mysql\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AuditingEnableDeviceAsync(string path, AuditingEnableDeviceRequest auditingEnableDeviceRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuditingEnableDevice");


            // verify the required parameter 'auditingEnableDeviceRequest' is set
            if (auditingEnableDeviceRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'auditingEnableDeviceRequest' when calling System->AuditingEnableDevice");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            requestOptions.Data = auditingEnableDeviceRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/audit/{path}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingEnableDevice", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Enable auditing of a header. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="auditingEnableRequestHeaderRequest"></param>
        /// <param name="header"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AuditingEnableRequestHeader(string header, AuditingEnableRequestHeaderRequest auditingEnableRequestHeaderRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'header' is set
            if (header == null)
                throw new VaultApiException(400, "Missing required parameter 'header' when calling System->AuditingEnableRequestHeader");


            // verify the required parameter 'auditingEnableRequestHeaderRequest' is set
            if (auditingEnableRequestHeaderRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'auditingEnableRequestHeaderRequest' when calling System->AuditingEnableRequestHeader");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("header", ClientUtils.ParameterToString(header)); // path parameter





            requestOptions.Data = auditingEnableRequestHeaderRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/config/auditing/request-headers/{header}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingEnableRequestHeader", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Enable auditing of a header. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="auditingEnableRequestHeaderRequest"></param>
        /// <param name="header"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AuditingEnableRequestHeaderAsync(string header, AuditingEnableRequestHeaderRequest auditingEnableRequestHeaderRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'header' is set
            if (header == null)
                throw new VaultApiException(400, "Missing required parameter 'header' when calling System->AuditingEnableRequestHeader");


            // verify the required parameter 'auditingEnableRequestHeaderRequest' is set
            if (auditingEnableRequestHeaderRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'auditingEnableRequestHeaderRequest' when calling System->AuditingEnableRequestHeader");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("header", ClientUtils.ParameterToString(header)); // path parameter



            requestOptions.Data = auditingEnableRequestHeaderRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/config/auditing/request-headers/{header}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingEnableRequestHeader", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List the enabled audit devices. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AuditingListEnabledDevices(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/audit", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingListEnabledDevices", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List the enabled audit devices. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AuditingListEnabledDevicesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/audit", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingListEnabledDevices", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List the request headers that are configured to be audited. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of AuditingListRequestHeadersResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<AuditingListRequestHeadersResponse> AuditingListRequestHeaders(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<AuditingListRequestHeadersResponse>("/sys/config/auditing/request-headers", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingListRequestHeaders", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<AuditingListRequestHeadersResponse>(response.RawContent);
        }


        /// <summary>
        /// List the request headers that are configured to be audited. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (AuditingListRequestHeadersResponse)</returns>
        public async Task<VaultResponse<AuditingListRequestHeadersResponse>> AuditingListRequestHeadersAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<AuditingListRequestHeadersResponse>("/sys/config/auditing/request-headers", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingListRequestHeaders", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<AuditingListRequestHeadersResponse>(response.RawContent);
        }
        /// <summary>
        /// List the information for the given request header. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AuditingReadRequestHeaderInformation(string header, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'header' is set
            if (header == null)
                throw new VaultApiException(400, "Missing required parameter 'header' when calling System->AuditingReadRequestHeaderInformation");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("header", ClientUtils.ParameterToString(header)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/config/auditing/request-headers/{header}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingReadRequestHeaderInformation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List the information for the given request header. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AuditingReadRequestHeaderInformationAsync(string header, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'header' is set
            if (header == null)
                throw new VaultApiException(400, "Missing required parameter 'header' when calling System->AuditingReadRequestHeaderInformation");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("header", ClientUtils.ParameterToString(header)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/config/auditing/request-headers/{header}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuditingReadRequestHeaderInformation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Disable the auth method at the given auth path 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Cannot be delimited. Example: \&quot;user\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AuthDisableMethod(string path, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuthDisableMethod");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/auth/{path}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthDisableMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Disable the auth method at the given auth path 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Cannot be delimited. Example: \&quot;user\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AuthDisableMethodAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuthDisableMethod");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/auth/{path}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthDisableMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Enables a new auth method. After enabling, the auth method can be accessed and configured via the auth path specified as part of the URL. This auth path will be nested under the auth prefix.  For example, enable the \&quot;foo\&quot; auth method will make it accessible at /auth/foo.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="authEnableMethodRequest"></param>
        /// <param name="path">The path to mount to. Cannot be delimited. Example: \&quot;user\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AuthEnableMethod(string path, AuthEnableMethodRequest authEnableMethodRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuthEnableMethod");


            // verify the required parameter 'authEnableMethodRequest' is set
            if (authEnableMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'authEnableMethodRequest' when calling System->AuthEnableMethod");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter





            requestOptions.Data = authEnableMethodRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/auth/{path}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthEnableMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Enables a new auth method. After enabling, the auth method can be accessed and configured via the auth path specified as part of the URL. This auth path will be nested under the auth prefix.  For example, enable the \&quot;foo\&quot; auth method will make it accessible at /auth/foo.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="authEnableMethodRequest"></param>
        /// <param name="path">The path to mount to. Cannot be delimited. Example: \&quot;user\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AuthEnableMethodAsync(string path, AuthEnableMethodRequest authEnableMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuthEnableMethod");


            // verify the required parameter 'authEnableMethodRequest' is set
            if (authEnableMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'authEnableMethodRequest' when calling System->AuthEnableMethod");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            requestOptions.Data = authEnableMethodRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/auth/{path}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthEnableMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AuthListEnabledMethods(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/auth", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthListEnabledMethods", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AuthListEnabledMethodsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/auth", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthListEnabledMethods", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Read the configuration of the auth engine at the given path. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Cannot be delimited. Example: \&quot;user\&quot;</param>
        /// <returns>VaultResponse of AuthReadConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<AuthReadConfigurationResponse> AuthReadConfiguration(string path, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuthReadConfiguration");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<AuthReadConfigurationResponse>("/sys/auth/{path}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<AuthReadConfigurationResponse>(response.RawContent);
        }


        /// <summary>
        /// Read the configuration of the auth engine at the given path. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Cannot be delimited. Example: \&quot;user\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (AuthReadConfigurationResponse)</returns>
        public async Task<VaultResponse<AuthReadConfigurationResponse>> AuthReadConfigurationAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuthReadConfiguration");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<AuthReadConfigurationResponse>("/sys/auth/{path}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<AuthReadConfigurationResponse>(response.RawContent);
        }
        /// <summary>
        /// Reads the given auth path&#x27;s configuration. This endpoint requires sudo capability on the final path, but the same functionality can be achieved without sudo via &#x60;sys/mounts/auth/[auth-path]/tune&#x60;.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Tune the configuration parameters for an auth path.</param>
        /// <returns>VaultResponse of AuthReadTuningInformationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<AuthReadTuningInformationResponse> AuthReadTuningInformation(string path, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuthReadTuningInformation");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<AuthReadTuningInformationResponse>("/sys/auth/{path}/tune", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthReadTuningInformation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<AuthReadTuningInformationResponse>(response.RawContent);
        }


        /// <summary>
        /// Reads the given auth path&#x27;s configuration. This endpoint requires sudo capability on the final path, but the same functionality can be achieved without sudo via &#x60;sys/mounts/auth/[auth-path]/tune&#x60;.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">Tune the configuration parameters for an auth path.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (AuthReadTuningInformationResponse)</returns>
        public async Task<VaultResponse<AuthReadTuningInformationResponse>> AuthReadTuningInformationAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuthReadTuningInformation");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<AuthReadTuningInformationResponse>("/sys/auth/{path}/tune", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthReadTuningInformation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<AuthReadTuningInformationResponse>(response.RawContent);
        }
        /// <summary>
        /// Tune configuration parameters for a given auth path. This endpoint requires sudo capability on the final path, but the same functionality can be achieved without sudo via &#x60;sys/mounts/auth/[auth-path]/tune&#x60;.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="authTuneConfigurationParametersRequest"></param>
        /// <param name="path">Tune the configuration parameters for an auth path.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AuthTuneConfigurationParameters(string path, AuthTuneConfigurationParametersRequest authTuneConfigurationParametersRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuthTuneConfigurationParameters");


            // verify the required parameter 'authTuneConfigurationParametersRequest' is set
            if (authTuneConfigurationParametersRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'authTuneConfigurationParametersRequest' when calling System->AuthTuneConfigurationParameters");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter





            requestOptions.Data = authTuneConfigurationParametersRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/auth/{path}/tune", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthTuneConfigurationParameters", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Tune configuration parameters for a given auth path. This endpoint requires sudo capability on the final path, but the same functionality can be achieved without sudo via &#x60;sys/mounts/auth/[auth-path]/tune&#x60;.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="authTuneConfigurationParametersRequest"></param>
        /// <param name="path">Tune the configuration parameters for an auth path.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AuthTuneConfigurationParametersAsync(string path, AuthTuneConfigurationParametersRequest authTuneConfigurationParametersRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->AuthTuneConfigurationParameters");


            // verify the required parameter 'authTuneConfigurationParametersRequest' is set
            if (authTuneConfigurationParametersRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'authTuneConfigurationParametersRequest' when calling System->AuthTuneConfigurationParameters");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            requestOptions.Data = authTuneConfigurationParametersRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/auth/{path}/tune", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AuthTuneConfigurationParameters", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Information about the host instance that this Vault server is running on. Information about the host instance that this Vault server is running on.   The information that gets collected includes host hardware information, and CPU,   disk, and memory utilization
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of CollectHostInformationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<CollectHostInformationResponse> CollectHostInformation(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<CollectHostInformationResponse>("/sys/host-info", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("CollectHostInformation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<CollectHostInformationResponse>(response.RawContent);
        }


        /// <summary>
        /// Information about the host instance that this Vault server is running on. Information about the host instance that this Vault server is running on.   The information that gets collected includes host hardware information, and CPU,   disk, and memory utilization
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (CollectHostInformationResponse)</returns>
        public async Task<VaultResponse<CollectHostInformationResponse>> CollectHostInformationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<CollectHostInformationResponse>("/sys/host-info", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("CollectHostInformation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<CollectHostInformationResponse>(response.RawContent);
        }
        /// <summary>
        /// reports in-flight requests This path responds to the following HTTP methods.   GET /    Returns a map of in-flight requests.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> CollectInFlightRequestInformation(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/in-flight-req", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("CollectInFlightRequestInformation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// reports in-flight requests This path responds to the following HTTP methods.   GET /    Returns a map of in-flight requests.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> CollectInFlightRequestInformationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/in-flight-req", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("CollectInFlightRequestInformation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Configure the CORS settings. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="corsConfigureRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> CorsConfigure(CorsConfigureRequest corsConfigureRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'corsConfigureRequest' is set
            if (corsConfigureRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'corsConfigureRequest' when calling System->CorsConfigure");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = corsConfigureRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/config/cors", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("CorsConfigure", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Configure the CORS settings. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="corsConfigureRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> CorsConfigureAsync(CorsConfigureRequest corsConfigureRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'corsConfigureRequest' is set
            if (corsConfigureRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'corsConfigureRequest' when calling System->CorsConfigure");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = corsConfigureRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/config/cors", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("CorsConfigure", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Remove any CORS settings. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> CorsDeleteConfiguration(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/config/cors", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("CorsDeleteConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Remove any CORS settings. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> CorsDeleteConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/config/cors", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("CorsDeleteConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Return the current CORS settings. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of CorsReadConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<CorsReadConfigurationResponse> CorsReadConfiguration(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<CorsReadConfigurationResponse>("/sys/config/cors", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("CorsReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<CorsReadConfigurationResponse>(response.RawContent);
        }


        /// <summary>
        /// Return the current CORS settings. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (CorsReadConfigurationResponse)</returns>
        public async Task<VaultResponse<CorsReadConfigurationResponse>> CorsReadConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<CorsReadConfigurationResponse>("/sys/config/cors", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("CorsReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<CorsReadConfigurationResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyConfigureRotationRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EncryptionKeyConfigureRotation(EncryptionKeyConfigureRotationRequest encryptionKeyConfigureRotationRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'encryptionKeyConfigureRotationRequest' is set
            if (encryptionKeyConfigureRotationRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'encryptionKeyConfigureRotationRequest' when calling System->EncryptionKeyConfigureRotation");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = encryptionKeyConfigureRotationRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/rotate/config", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EncryptionKeyConfigureRotation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="encryptionKeyConfigureRotationRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EncryptionKeyConfigureRotationAsync(EncryptionKeyConfigureRotationRequest encryptionKeyConfigureRotationRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'encryptionKeyConfigureRotationRequest' is set
            if (encryptionKeyConfigureRotationRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'encryptionKeyConfigureRotationRequest' when calling System->EncryptionKeyConfigureRotation");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = encryptionKeyConfigureRotationRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/rotate/config", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EncryptionKeyConfigureRotation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of EncryptionKeyReadRotationConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<EncryptionKeyReadRotationConfigurationResponse> EncryptionKeyReadRotationConfiguration(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<EncryptionKeyReadRotationConfigurationResponse>("/sys/rotate/config", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EncryptionKeyReadRotationConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<EncryptionKeyReadRotationConfigurationResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (EncryptionKeyReadRotationConfigurationResponse)</returns>
        public async Task<VaultResponse<EncryptionKeyReadRotationConfigurationResponse>> EncryptionKeyReadRotationConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<EncryptionKeyReadRotationConfigurationResponse>("/sys/rotate/config", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EncryptionKeyReadRotationConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<EncryptionKeyReadRotationConfigurationResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EncryptionKeyRotate(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/rotate", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EncryptionKeyRotate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EncryptionKeyRotateAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/rotate", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EncryptionKeyRotate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Provides information about the backend encryption key. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EncryptionKeyStatus(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/key-status", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EncryptionKeyStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Provides information about the backend encryption key. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EncryptionKeyStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/key-status", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EncryptionKeyStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateHashRequest"></param>
        /// <returns>VaultResponse of GenerateHashResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<GenerateHashResponse> GenerateHash(GenerateHashRequest generateHashRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'generateHashRequest' is set
            if (generateHashRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'generateHashRequest' when calling System->GenerateHash");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = generateHashRequest;


            // make the HTTP request
            var response = this.Client.Post<GenerateHashResponse>("/sys/tools/hash", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GenerateHash", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<GenerateHashResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateHashRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (GenerateHashResponse)</returns>
        public async Task<VaultResponse<GenerateHashResponse>> GenerateHashAsync(GenerateHashRequest generateHashRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'generateHashRequest' is set
            if (generateHashRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'generateHashRequest' when calling System->GenerateHash");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = generateHashRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<GenerateHashResponse>("/sys/tools/hash", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GenerateHash", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<GenerateHashResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateHashWithAlgorithmRequest"></param>
        /// <param name="urlalgorithm">Algorithm to use (POST URL parameter)</param>
        /// <returns>VaultResponse of GenerateHashWithAlgorithmResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<GenerateHashWithAlgorithmResponse> GenerateHashWithAlgorithm(string urlalgorithm, GenerateHashWithAlgorithmRequest generateHashWithAlgorithmRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'urlalgorithm' is set
            if (urlalgorithm == null)
                throw new VaultApiException(400, "Missing required parameter 'urlalgorithm' when calling System->GenerateHashWithAlgorithm");


            // verify the required parameter 'generateHashWithAlgorithmRequest' is set
            if (generateHashWithAlgorithmRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'generateHashWithAlgorithmRequest' when calling System->GenerateHashWithAlgorithm");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("urlalgorithm", ClientUtils.ParameterToString(urlalgorithm)); // path parameter





            requestOptions.Data = generateHashWithAlgorithmRequest;


            // make the HTTP request
            var response = this.Client.Post<GenerateHashWithAlgorithmResponse>("/sys/tools/hash/{urlalgorithm}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GenerateHashWithAlgorithm", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<GenerateHashWithAlgorithmResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateHashWithAlgorithmRequest"></param>
        /// <param name="urlalgorithm">Algorithm to use (POST URL parameter)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (GenerateHashWithAlgorithmResponse)</returns>
        public async Task<VaultResponse<GenerateHashWithAlgorithmResponse>> GenerateHashWithAlgorithmAsync(string urlalgorithm, GenerateHashWithAlgorithmRequest generateHashWithAlgorithmRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'urlalgorithm' is set
            if (urlalgorithm == null)
                throw new VaultApiException(400, "Missing required parameter 'urlalgorithm' when calling System->GenerateHashWithAlgorithm");


            // verify the required parameter 'generateHashWithAlgorithmRequest' is set
            if (generateHashWithAlgorithmRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'generateHashWithAlgorithmRequest' when calling System->GenerateHashWithAlgorithm");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("urlalgorithm", ClientUtils.ParameterToString(urlalgorithm)); // path parameter



            requestOptions.Data = generateHashWithAlgorithmRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<GenerateHashWithAlgorithmResponse>("/sys/tools/hash/{urlalgorithm}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GenerateHashWithAlgorithm", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<GenerateHashWithAlgorithmResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomRequest"></param>
        /// <returns>VaultResponse of GenerateRandomResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<GenerateRandomResponse> GenerateRandom(GenerateRandomRequest generateRandomRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'generateRandomRequest' is set
            if (generateRandomRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'generateRandomRequest' when calling System->GenerateRandom");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = generateRandomRequest;


            // make the HTTP request
            var response = this.Client.Post<GenerateRandomResponse>("/sys/tools/random", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GenerateRandom", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<GenerateRandomResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (GenerateRandomResponse)</returns>
        public async Task<VaultResponse<GenerateRandomResponse>> GenerateRandomAsync(GenerateRandomRequest generateRandomRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'generateRandomRequest' is set
            if (generateRandomRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'generateRandomRequest' when calling System->GenerateRandom");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = generateRandomRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<GenerateRandomResponse>("/sys/tools/random", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GenerateRandom", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<GenerateRandomResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomWithBytesRequest"></param>
        /// <param name="urlbytes">The number of bytes to generate (POST URL parameter)</param>
        /// <returns>VaultResponse of GenerateRandomWithBytesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<GenerateRandomWithBytesResponse> GenerateRandomWithBytes(string urlbytes, GenerateRandomWithBytesRequest generateRandomWithBytesRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'urlbytes' is set
            if (urlbytes == null)
                throw new VaultApiException(400, "Missing required parameter 'urlbytes' when calling System->GenerateRandomWithBytes");


            // verify the required parameter 'generateRandomWithBytesRequest' is set
            if (generateRandomWithBytesRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'generateRandomWithBytesRequest' when calling System->GenerateRandomWithBytes");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("urlbytes", ClientUtils.ParameterToString(urlbytes)); // path parameter





            requestOptions.Data = generateRandomWithBytesRequest;


            // make the HTTP request
            var response = this.Client.Post<GenerateRandomWithBytesResponse>("/sys/tools/random/{urlbytes}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GenerateRandomWithBytes", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<GenerateRandomWithBytesResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomWithBytesRequest"></param>
        /// <param name="urlbytes">The number of bytes to generate (POST URL parameter)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (GenerateRandomWithBytesResponse)</returns>
        public async Task<VaultResponse<GenerateRandomWithBytesResponse>> GenerateRandomWithBytesAsync(string urlbytes, GenerateRandomWithBytesRequest generateRandomWithBytesRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'urlbytes' is set
            if (urlbytes == null)
                throw new VaultApiException(400, "Missing required parameter 'urlbytes' when calling System->GenerateRandomWithBytes");


            // verify the required parameter 'generateRandomWithBytesRequest' is set
            if (generateRandomWithBytesRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'generateRandomWithBytesRequest' when calling System->GenerateRandomWithBytes");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("urlbytes", ClientUtils.ParameterToString(urlbytes)); // path parameter



            requestOptions.Data = generateRandomWithBytesRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<GenerateRandomWithBytesResponse>("/sys/tools/random/{urlbytes}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GenerateRandomWithBytes", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<GenerateRandomWithBytesResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomWithSourceRequest"></param>
        /// <param name="source">Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;.</param>
        /// <returns>VaultResponse of GenerateRandomWithSourceResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<GenerateRandomWithSourceResponse> GenerateRandomWithSource(string source, GenerateRandomWithSourceRequest generateRandomWithSourceRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'source' is set
            if (source == null)
                throw new VaultApiException(400, "Missing required parameter 'source' when calling System->GenerateRandomWithSource");


            // verify the required parameter 'generateRandomWithSourceRequest' is set
            if (generateRandomWithSourceRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'generateRandomWithSourceRequest' when calling System->GenerateRandomWithSource");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("source", ClientUtils.ParameterToString(source)); // path parameter





            requestOptions.Data = generateRandomWithSourceRequest;


            // make the HTTP request
            var response = this.Client.Post<GenerateRandomWithSourceResponse>("/sys/tools/random/{source}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GenerateRandomWithSource", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<GenerateRandomWithSourceResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomWithSourceRequest"></param>
        /// <param name="source">Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (GenerateRandomWithSourceResponse)</returns>
        public async Task<VaultResponse<GenerateRandomWithSourceResponse>> GenerateRandomWithSourceAsync(string source, GenerateRandomWithSourceRequest generateRandomWithSourceRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'source' is set
            if (source == null)
                throw new VaultApiException(400, "Missing required parameter 'source' when calling System->GenerateRandomWithSource");


            // verify the required parameter 'generateRandomWithSourceRequest' is set
            if (generateRandomWithSourceRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'generateRandomWithSourceRequest' when calling System->GenerateRandomWithSource");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("source", ClientUtils.ParameterToString(source)); // path parameter



            requestOptions.Data = generateRandomWithSourceRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<GenerateRandomWithSourceResponse>("/sys/tools/random/{source}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GenerateRandomWithSource", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<GenerateRandomWithSourceResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomWithSourceAndBytesRequest"></param>
        /// <param name="source">Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;.</param>
        /// <param name="urlbytes">The number of bytes to generate (POST URL parameter)</param>
        /// <returns>VaultResponse of GenerateRandomWithSourceAndBytesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<GenerateRandomWithSourceAndBytesResponse> GenerateRandomWithSourceAndBytes(string source, string urlbytes, GenerateRandomWithSourceAndBytesRequest generateRandomWithSourceAndBytesRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'source' is set
            if (source == null)
                throw new VaultApiException(400, "Missing required parameter 'source' when calling System->GenerateRandomWithSourceAndBytes");

            // verify the required parameter 'urlbytes' is set
            if (urlbytes == null)
                throw new VaultApiException(400, "Missing required parameter 'urlbytes' when calling System->GenerateRandomWithSourceAndBytes");


            // verify the required parameter 'generateRandomWithSourceAndBytesRequest' is set
            if (generateRandomWithSourceAndBytesRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'generateRandomWithSourceAndBytesRequest' when calling System->GenerateRandomWithSourceAndBytes");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("source", ClientUtils.ParameterToString(source)); // path parameter


            requestOptions.PathParameters.Add("urlbytes", ClientUtils.ParameterToString(urlbytes)); // path parameter





            requestOptions.Data = generateRandomWithSourceAndBytesRequest;


            // make the HTTP request
            var response = this.Client.Post<GenerateRandomWithSourceAndBytesResponse>("/sys/tools/random/{source}/{urlbytes}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GenerateRandomWithSourceAndBytes", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<GenerateRandomWithSourceAndBytesResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="generateRandomWithSourceAndBytesRequest"></param>
        /// <param name="source">Which system to source random data from, ether \&quot;platform\&quot;, \&quot;seal\&quot;, or \&quot;all\&quot;.</param>
        /// <param name="urlbytes">The number of bytes to generate (POST URL parameter)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (GenerateRandomWithSourceAndBytesResponse)</returns>
        public async Task<VaultResponse<GenerateRandomWithSourceAndBytesResponse>> GenerateRandomWithSourceAndBytesAsync(string source, string urlbytes, GenerateRandomWithSourceAndBytesRequest generateRandomWithSourceAndBytesRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'source' is set
            if (source == null)
                throw new VaultApiException(400, "Missing required parameter 'source' when calling System->GenerateRandomWithSourceAndBytes");

            // verify the required parameter 'urlbytes' is set
            if (urlbytes == null)
                throw new VaultApiException(400, "Missing required parameter 'urlbytes' when calling System->GenerateRandomWithSourceAndBytes");


            // verify the required parameter 'generateRandomWithSourceAndBytesRequest' is set
            if (generateRandomWithSourceAndBytesRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'generateRandomWithSourceAndBytesRequest' when calling System->GenerateRandomWithSourceAndBytes");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("source", ClientUtils.ParameterToString(source)); // path parameter


            requestOptions.PathParameters.Add("urlbytes", ClientUtils.ParameterToString(urlbytes)); // path parameter



            requestOptions.Data = generateRandomWithSourceAndBytesRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<GenerateRandomWithSourceAndBytesResponse>("/sys/tools/random/{source}/{urlbytes}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GenerateRandomWithSourceAndBytes", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<GenerateRandomWithSourceAndBytesResponse>(response.RawContent);
        }
        /// <summary>
        /// Check the HA status of a Vault cluster 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of HaStatusResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<HaStatusResponse> HaStatus(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<HaStatusResponse>("/sys/ha-status", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("HaStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<HaStatusResponse>(response.RawContent);
        }


        /// <summary>
        /// Check the HA status of a Vault cluster 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (HaStatusResponse)</returns>
        public async Task<VaultResponse<HaStatusResponse>> HaStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<HaStatusResponse>("/sys/ha-status", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("HaStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<HaStatusResponse>(response.RawContent);
        }
        /// <summary>
        /// Initialize a new Vault. The Vault must not have been previously initialized. The recovery options, as well as the stored shares option, are only available when using Vault HSM.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="initializeRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> Initialize(InitializeRequest initializeRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'initializeRequest' is set
            if (initializeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'initializeRequest' when calling System->Initialize");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = initializeRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/init", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Initialize", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Initialize a new Vault. The Vault must not have been previously initialized. The recovery options, as well as the stored shares option, are only available when using Vault HSM.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="initializeRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> InitializeAsync(InitializeRequest initializeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'initializeRequest' is set
            if (initializeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'initializeRequest' when calling System->Initialize");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = initializeRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/init", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Initialize", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Enable or disable collection of client count, set retention period, or set default reporting period. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="internalClientActivityConfigureRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> InternalClientActivityConfigure(InternalClientActivityConfigureRequest internalClientActivityConfigureRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'internalClientActivityConfigureRequest' is set
            if (internalClientActivityConfigureRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'internalClientActivityConfigureRequest' when calling System->InternalClientActivityConfigure");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = internalClientActivityConfigureRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/internal/counters/config", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalClientActivityConfigure", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Enable or disable collection of client count, set retention period, or set default reporting period. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="internalClientActivityConfigureRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> InternalClientActivityConfigureAsync(InternalClientActivityConfigureRequest internalClientActivityConfigureRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'internalClientActivityConfigureRequest' is set
            if (internalClientActivityConfigureRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'internalClientActivityConfigureRequest' when calling System->InternalClientActivityConfigure");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = internalClientActivityConfigureRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/internal/counters/config", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalClientActivityConfigure", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Report the client count metrics, for this namespace and all child namespaces. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> InternalClientActivityExport(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/internal/counters/activity/export", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalClientActivityExport", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Report the client count metrics, for this namespace and all child namespaces. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> InternalClientActivityExportAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/internal/counters/activity/export", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalClientActivityExport", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Read the client count tracking configuration. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> InternalClientActivityReadConfiguration(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/internal/counters/config", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalClientActivityReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Read the client count tracking configuration. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> InternalClientActivityReadConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/internal/counters/config", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalClientActivityReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Report the client count metrics, for this namespace and all child namespaces. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> InternalClientActivityReportCounts(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/internal/counters/activity", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalClientActivityReportCounts", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Report the client count metrics, for this namespace and all child namespaces. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> InternalClientActivityReportCountsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/internal/counters/activity", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalClientActivityReportCounts", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Report the number of clients for this month, for this namespace and all child namespaces. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> InternalClientActivityReportCountsThisMonth(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/internal/counters/activity/monthly", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalClientActivityReportCountsThisMonth", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Report the number of clients for this month, for this namespace and all child namespaces. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> InternalClientActivityReportCountsThisMonthAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/internal/counters/activity/monthly", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalClientActivityReportCountsThisMonth", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Backwards compatibility is not guaranteed for this API 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of InternalCountEntitiesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<InternalCountEntitiesResponse> InternalCountEntities(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<InternalCountEntitiesResponse>("/sys/internal/counters/entities", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalCountEntities", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalCountEntitiesResponse>(response.RawContent);
        }


        /// <summary>
        /// Backwards compatibility is not guaranteed for this API 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalCountEntitiesResponse)</returns>
        public async Task<VaultResponse<InternalCountEntitiesResponse>> InternalCountEntitiesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<InternalCountEntitiesResponse>("/sys/internal/counters/entities", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalCountEntities", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalCountEntitiesResponse>(response.RawContent);
        }
        /// <summary>
        /// Backwards compatibility is not guaranteed for this API 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>

        [Obsolete]
        public VaultResponse<Object> InternalCountRequests(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/internal/counters/requests", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalCountRequests", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Backwards compatibility is not guaranteed for this API 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>

        [Obsolete]
        public async Task<VaultResponse<Object>> InternalCountRequestsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/internal/counters/requests", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalCountRequests", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Backwards compatibility is not guaranteed for this API 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of InternalCountTokensResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<InternalCountTokensResponse> InternalCountTokens(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<InternalCountTokensResponse>("/sys/internal/counters/tokens", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalCountTokens", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalCountTokensResponse>(response.RawContent);
        }


        /// <summary>
        /// Backwards compatibility is not guaranteed for this API 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalCountTokensResponse)</returns>
        public async Task<VaultResponse<InternalCountTokensResponse>> InternalCountTokensAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<InternalCountTokensResponse>("/sys/internal/counters/tokens", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalCountTokens", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalCountTokensResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="genericMountPaths">Use generic mount paths (optional, default to false)</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> InternalGenerateOpenApiDocument(bool? genericMountPaths = default(bool?), TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);




            if (genericMountPaths != null)
            {


                requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "generic_mount_paths", genericMountPaths));

            }



            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/internal/specs/openapi", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalGenerateOpenApiDocument", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="genericMountPaths">Use generic mount paths (optional, default to false)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> InternalGenerateOpenApiDocumentAsync(bool? genericMountPaths = default(bool?), TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);




            if (genericMountPaths != null)
            {
                requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "generic_mount_paths", genericMountPaths));
            }
            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/internal/specs/openapi", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalGenerateOpenApiDocument", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Expose the route entry and mount entry tables present in the router 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Name of subtree being observed</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> InternalInspectRouter(string tag, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new VaultApiException(400, "Missing required parameter 'tag' when calling System->InternalInspectRouter");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("tag", ClientUtils.ParameterToString(tag)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/internal/inspect/router/{tag}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalInspectRouter", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Expose the route entry and mount entry tables present in the router 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="tag">Name of subtree being observed</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> InternalInspectRouterAsync(string tag, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'tag' is set
            if (tag == null)
                throw new VaultApiException(400, "Missing required parameter 'tag' when calling System->InternalInspectRouter");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("tag", ClientUtils.ParameterToString(tag)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/internal/inspect/router/{tag}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalInspectRouter", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Lists enabled feature flags. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of InternalUiListEnabledFeatureFlagsResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<InternalUiListEnabledFeatureFlagsResponse> InternalUiListEnabledFeatureFlags(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<InternalUiListEnabledFeatureFlagsResponse>("/sys/internal/ui/feature-flags", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalUiListEnabledFeatureFlags", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalUiListEnabledFeatureFlagsResponse>(response.RawContent);
        }


        /// <summary>
        /// Lists enabled feature flags. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalUiListEnabledFeatureFlagsResponse)</returns>
        public async Task<VaultResponse<InternalUiListEnabledFeatureFlagsResponse>> InternalUiListEnabledFeatureFlagsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<InternalUiListEnabledFeatureFlagsResponse>("/sys/internal/ui/feature-flags", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalUiListEnabledFeatureFlags", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalUiListEnabledFeatureFlagsResponse>(response.RawContent);
        }
        /// <summary>
        /// Lists all enabled and visible auth and secrets mounts. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of InternalUiListEnabledVisibleMountsResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<InternalUiListEnabledVisibleMountsResponse> InternalUiListEnabledVisibleMounts(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<InternalUiListEnabledVisibleMountsResponse>("/sys/internal/ui/mounts", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalUiListEnabledVisibleMounts", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalUiListEnabledVisibleMountsResponse>(response.RawContent);
        }


        /// <summary>
        /// Lists all enabled and visible auth and secrets mounts. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalUiListEnabledVisibleMountsResponse)</returns>
        public async Task<VaultResponse<InternalUiListEnabledVisibleMountsResponse>> InternalUiListEnabledVisibleMountsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<InternalUiListEnabledVisibleMountsResponse>("/sys/internal/ui/mounts", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalUiListEnabledVisibleMounts", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalUiListEnabledVisibleMountsResponse>(response.RawContent);
        }
        /// <summary>
        /// Backwards compatibility is not guaranteed for this API 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of InternalUiListNamespacesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<InternalUiListNamespacesResponse> InternalUiListNamespaces(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<InternalUiListNamespacesResponse>("/sys/internal/ui/namespaces", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalUiListNamespaces", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalUiListNamespacesResponse>(response.RawContent);
        }


        /// <summary>
        /// Backwards compatibility is not guaranteed for this API 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalUiListNamespacesResponse)</returns>
        public async Task<VaultResponse<InternalUiListNamespacesResponse>> InternalUiListNamespacesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<InternalUiListNamespacesResponse>("/sys/internal/ui/namespaces", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalUiListNamespaces", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalUiListNamespacesResponse>(response.RawContent);
        }
        /// <summary>
        /// Return information about the given mount. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path of the mount.</param>
        /// <returns>VaultResponse of InternalUiReadMountInformationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<InternalUiReadMountInformationResponse> InternalUiReadMountInformation(string path, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->InternalUiReadMountInformation");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<InternalUiReadMountInformationResponse>("/sys/internal/ui/mounts/{path}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalUiReadMountInformation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalUiReadMountInformationResponse>(response.RawContent);
        }


        /// <summary>
        /// Return information about the given mount. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path of the mount.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalUiReadMountInformationResponse)</returns>
        public async Task<VaultResponse<InternalUiReadMountInformationResponse>> InternalUiReadMountInformationAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->InternalUiReadMountInformation");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<InternalUiReadMountInformationResponse>("/sys/internal/ui/mounts/{path}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalUiReadMountInformation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalUiReadMountInformationResponse>(response.RawContent);
        }
        /// <summary>
        /// Backwards compatibility is not guaranteed for this API 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of InternalUiReadResultantAclResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<InternalUiReadResultantAclResponse> InternalUiReadResultantAcl(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<InternalUiReadResultantAclResponse>("/sys/internal/ui/resultant-acl", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalUiReadResultantAcl", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalUiReadResultantAclResponse>(response.RawContent);
        }


        /// <summary>
        /// Backwards compatibility is not guaranteed for this API 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (InternalUiReadResultantAclResponse)</returns>
        public async Task<VaultResponse<InternalUiReadResultantAclResponse>> InternalUiReadResultantAclAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<InternalUiReadResultantAclResponse>("/sys/internal/ui/resultant-acl", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("InternalUiReadResultantAcl", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<InternalUiReadResultantAclResponse>(response.RawContent);
        }
        /// <summary>
        /// Returns the high availability status and current leader instance of Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of LeaderStatusResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<LeaderStatusResponse> LeaderStatus(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<LeaderStatusResponse>("/sys/leader", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeaderStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<LeaderStatusResponse>(response.RawContent);
        }


        /// <summary>
        /// Returns the high availability status and current leader instance of Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (LeaderStatusResponse)</returns>
        public async Task<VaultResponse<LeaderStatusResponse>> LeaderStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<LeaderStatusResponse>("/sys/leader", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeaderStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<LeaderStatusResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of LeasesCountResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<LeasesCountResponse> LeasesCount(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<LeasesCountResponse>("/sys/leases/count", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesCount", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<LeasesCountResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (LeasesCountResponse)</returns>
        public async Task<VaultResponse<LeasesCountResponse>> LeasesCountAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<LeasesCountResponse>("/sys/leases/count", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesCount", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<LeasesCountResponse>(response.RawContent);
        }
        /// <summary>
        /// Revokes all secrets or tokens generated under a given prefix immediately Unlike &#x60;/sys/leases/revoke-prefix&#x60;, this path ignores backend errors encountered during revocation. This is potentially very dangerous and should only be used in specific emergency situations where errors in the backend or the connected backend service prevent normal revocation.  By ignoring these errors, Vault abdicates responsibility for ensuring that the issued credentials or secrets are properly revoked and/or cleaned up. Access to this endpoint should be tightly controlled.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="prefix">The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LeasesForceRevokeLeaseWithPrefix(string prefix, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'prefix' is set
            if (prefix == null)
                throw new VaultApiException(400, "Missing required parameter 'prefix' when calling System->LeasesForceRevokeLeaseWithPrefix");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("prefix", ClientUtils.ParameterToString(prefix)); // path parameter






            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/leases/revoke-force/{prefix}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesForceRevokeLeaseWithPrefix", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Revokes all secrets or tokens generated under a given prefix immediately Unlike &#x60;/sys/leases/revoke-prefix&#x60;, this path ignores backend errors encountered during revocation. This is potentially very dangerous and should only be used in specific emergency situations where errors in the backend or the connected backend service prevent normal revocation.  By ignoring these errors, Vault abdicates responsibility for ensuring that the issued credentials or secrets are properly revoked and/or cleaned up. Access to this endpoint should be tightly controlled.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="prefix">The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LeasesForceRevokeLeaseWithPrefixAsync(string prefix, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'prefix' is set
            if (prefix == null)
                throw new VaultApiException(400, "Missing required parameter 'prefix' when calling System->LeasesForceRevokeLeaseWithPrefix");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("prefix", ClientUtils.ParameterToString(prefix)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/leases/revoke-force/{prefix}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesForceRevokeLeaseWithPrefix", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of LeasesListResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<LeasesListResponse> LeasesList(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<LeasesListResponse>("/sys/leases", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesList", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<LeasesListResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (LeasesListResponse)</returns>
        public async Task<VaultResponse<LeasesListResponse>> LeasesListAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<LeasesListResponse>("/sys/leases", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesList", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<LeasesListResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of LeasesLookUpResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<LeasesLookUpResponse> LeasesLookUp(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<LeasesLookUpResponse>("/sys/leases/lookup/", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesLookUp", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<LeasesLookUpResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (LeasesLookUpResponse)</returns>
        public async Task<VaultResponse<LeasesLookUpResponse>> LeasesLookUpAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<LeasesLookUpResponse>("/sys/leases/lookup/", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesLookUp", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<LeasesLookUpResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="prefix">The path to list leases under. Example: \&quot;aws/creds/deploy\&quot;</param>
        /// <returns>VaultResponse of LeasesLookUpWithPrefixResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<LeasesLookUpWithPrefixResponse> LeasesLookUpWithPrefix(string prefix, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'prefix' is set
            if (prefix == null)
                throw new VaultApiException(400, "Missing required parameter 'prefix' when calling System->LeasesLookUpWithPrefix");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("prefix", ClientUtils.ParameterToString(prefix)); // path parameter



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<LeasesLookUpWithPrefixResponse>("/sys/leases/lookup/{prefix}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesLookUpWithPrefix", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<LeasesLookUpWithPrefixResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="prefix">The path to list leases under. Example: \&quot;aws/creds/deploy\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (LeasesLookUpWithPrefixResponse)</returns>
        public async Task<VaultResponse<LeasesLookUpWithPrefixResponse>> LeasesLookUpWithPrefixAsync(string prefix, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'prefix' is set
            if (prefix == null)
                throw new VaultApiException(400, "Missing required parameter 'prefix' when calling System->LeasesLookUpWithPrefix");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("prefix", ClientUtils.ParameterToString(prefix)); // path parameter



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<LeasesLookUpWithPrefixResponse>("/sys/leases/lookup/{prefix}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesLookUpWithPrefix", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<LeasesLookUpWithPrefixResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesReadLeaseRequest"></param>
        /// <returns>VaultResponse of LeasesReadLeaseResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<LeasesReadLeaseResponse> LeasesReadLease(LeasesReadLeaseRequest leasesReadLeaseRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'leasesReadLeaseRequest' is set
            if (leasesReadLeaseRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'leasesReadLeaseRequest' when calling System->LeasesReadLease");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = leasesReadLeaseRequest;


            // make the HTTP request
            var response = this.Client.Post<LeasesReadLeaseResponse>("/sys/leases/lookup", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesReadLease", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<LeasesReadLeaseResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesReadLeaseRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (LeasesReadLeaseResponse)</returns>
        public async Task<VaultResponse<LeasesReadLeaseResponse>> LeasesReadLeaseAsync(LeasesReadLeaseRequest leasesReadLeaseRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'leasesReadLeaseRequest' is set
            if (leasesReadLeaseRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'leasesReadLeaseRequest' when calling System->LeasesReadLease");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = leasesReadLeaseRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<LeasesReadLeaseResponse>("/sys/leases/lookup", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesReadLease", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<LeasesReadLeaseResponse>(response.RawContent);
        }
        /// <summary>
        /// Renews a lease, requesting to extend the lease. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRenewLeaseRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LeasesRenewLease(LeasesRenewLeaseRequest leasesRenewLeaseRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'leasesRenewLeaseRequest' is set
            if (leasesRenewLeaseRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'leasesRenewLeaseRequest' when calling System->LeasesRenewLease");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = leasesRenewLeaseRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/leases/renew", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesRenewLease", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Renews a lease, requesting to extend the lease. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRenewLeaseRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LeasesRenewLeaseAsync(LeasesRenewLeaseRequest leasesRenewLeaseRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'leasesRenewLeaseRequest' is set
            if (leasesRenewLeaseRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'leasesRenewLeaseRequest' when calling System->LeasesRenewLease");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = leasesRenewLeaseRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/leases/renew", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesRenewLease", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Renews a lease, requesting to extend the lease. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRenewLeaseWithIdRequest"></param>
        /// <param name="urlLeaseId">The lease identifier to renew. This is included with a lease.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LeasesRenewLeaseWithId(string urlLeaseId, LeasesRenewLeaseWithIdRequest leasesRenewLeaseWithIdRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'urlLeaseId' is set
            if (urlLeaseId == null)
                throw new VaultApiException(400, "Missing required parameter 'urlLeaseId' when calling System->LeasesRenewLeaseWithId");


            // verify the required parameter 'leasesRenewLeaseWithIdRequest' is set
            if (leasesRenewLeaseWithIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'leasesRenewLeaseWithIdRequest' when calling System->LeasesRenewLeaseWithId");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("url_lease_id", ClientUtils.ParameterToString(urlLeaseId)); // path parameter





            requestOptions.Data = leasesRenewLeaseWithIdRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/leases/renew/{url_lease_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesRenewLeaseWithId", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Renews a lease, requesting to extend the lease. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRenewLeaseWithIdRequest"></param>
        /// <param name="urlLeaseId">The lease identifier to renew. This is included with a lease.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LeasesRenewLeaseWithIdAsync(string urlLeaseId, LeasesRenewLeaseWithIdRequest leasesRenewLeaseWithIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'urlLeaseId' is set
            if (urlLeaseId == null)
                throw new VaultApiException(400, "Missing required parameter 'urlLeaseId' when calling System->LeasesRenewLeaseWithId");


            // verify the required parameter 'leasesRenewLeaseWithIdRequest' is set
            if (leasesRenewLeaseWithIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'leasesRenewLeaseWithIdRequest' when calling System->LeasesRenewLeaseWithId");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("url_lease_id", ClientUtils.ParameterToString(urlLeaseId)); // path parameter



            requestOptions.Data = leasesRenewLeaseWithIdRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/leases/renew/{url_lease_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesRenewLeaseWithId", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Revokes a lease immediately. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRevokeLeaseRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LeasesRevokeLease(LeasesRevokeLeaseRequest leasesRevokeLeaseRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'leasesRevokeLeaseRequest' is set
            if (leasesRevokeLeaseRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'leasesRevokeLeaseRequest' when calling System->LeasesRevokeLease");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = leasesRevokeLeaseRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/leases/revoke", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesRevokeLease", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Revokes a lease immediately. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRevokeLeaseRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LeasesRevokeLeaseAsync(LeasesRevokeLeaseRequest leasesRevokeLeaseRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'leasesRevokeLeaseRequest' is set
            if (leasesRevokeLeaseRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'leasesRevokeLeaseRequest' when calling System->LeasesRevokeLease");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = leasesRevokeLeaseRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/leases/revoke", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesRevokeLease", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Revokes a lease immediately. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRevokeLeaseWithIdRequest"></param>
        /// <param name="urlLeaseId">The lease identifier to renew. This is included with a lease.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LeasesRevokeLeaseWithId(string urlLeaseId, LeasesRevokeLeaseWithIdRequest leasesRevokeLeaseWithIdRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'urlLeaseId' is set
            if (urlLeaseId == null)
                throw new VaultApiException(400, "Missing required parameter 'urlLeaseId' when calling System->LeasesRevokeLeaseWithId");


            // verify the required parameter 'leasesRevokeLeaseWithIdRequest' is set
            if (leasesRevokeLeaseWithIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'leasesRevokeLeaseWithIdRequest' when calling System->LeasesRevokeLeaseWithId");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("url_lease_id", ClientUtils.ParameterToString(urlLeaseId)); // path parameter





            requestOptions.Data = leasesRevokeLeaseWithIdRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/leases/revoke/{url_lease_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesRevokeLeaseWithId", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Revokes a lease immediately. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRevokeLeaseWithIdRequest"></param>
        /// <param name="urlLeaseId">The lease identifier to renew. This is included with a lease.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LeasesRevokeLeaseWithIdAsync(string urlLeaseId, LeasesRevokeLeaseWithIdRequest leasesRevokeLeaseWithIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'urlLeaseId' is set
            if (urlLeaseId == null)
                throw new VaultApiException(400, "Missing required parameter 'urlLeaseId' when calling System->LeasesRevokeLeaseWithId");


            // verify the required parameter 'leasesRevokeLeaseWithIdRequest' is set
            if (leasesRevokeLeaseWithIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'leasesRevokeLeaseWithIdRequest' when calling System->LeasesRevokeLeaseWithId");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("url_lease_id", ClientUtils.ParameterToString(urlLeaseId)); // path parameter



            requestOptions.Data = leasesRevokeLeaseWithIdRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/leases/revoke/{url_lease_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesRevokeLeaseWithId", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Revokes all secrets (via a lease ID prefix) or tokens (via the tokens&#x27; path property) generated under a given prefix immediately. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRevokeLeaseWithPrefixRequest"></param>
        /// <param name="prefix">The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LeasesRevokeLeaseWithPrefix(string prefix, LeasesRevokeLeaseWithPrefixRequest leasesRevokeLeaseWithPrefixRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'prefix' is set
            if (prefix == null)
                throw new VaultApiException(400, "Missing required parameter 'prefix' when calling System->LeasesRevokeLeaseWithPrefix");


            // verify the required parameter 'leasesRevokeLeaseWithPrefixRequest' is set
            if (leasesRevokeLeaseWithPrefixRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'leasesRevokeLeaseWithPrefixRequest' when calling System->LeasesRevokeLeaseWithPrefix");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("prefix", ClientUtils.ParameterToString(prefix)); // path parameter





            requestOptions.Data = leasesRevokeLeaseWithPrefixRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/leases/revoke-prefix/{prefix}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesRevokeLeaseWithPrefix", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Revokes all secrets (via a lease ID prefix) or tokens (via the tokens&#x27; path property) generated under a given prefix immediately. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="leasesRevokeLeaseWithPrefixRequest"></param>
        /// <param name="prefix">The path to revoke keys under. Example: \&quot;prod/aws/ops\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LeasesRevokeLeaseWithPrefixAsync(string prefix, LeasesRevokeLeaseWithPrefixRequest leasesRevokeLeaseWithPrefixRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'prefix' is set
            if (prefix == null)
                throw new VaultApiException(400, "Missing required parameter 'prefix' when calling System->LeasesRevokeLeaseWithPrefix");


            // verify the required parameter 'leasesRevokeLeaseWithPrefixRequest' is set
            if (leasesRevokeLeaseWithPrefixRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'leasesRevokeLeaseWithPrefixRequest' when calling System->LeasesRevokeLeaseWithPrefix");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("prefix", ClientUtils.ParameterToString(prefix)); // path parameter



            requestOptions.Data = leasesRevokeLeaseWithPrefixRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/leases/revoke-prefix/{prefix}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesRevokeLeaseWithPrefix", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LeasesTidy(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/leases/tidy", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesTidy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LeasesTidyAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/leases/tidy", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LeasesTidy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns the available and enabled experiments 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> ListExperimentalFeatures(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/experiments", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ListExperimentalFeatures", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns the available and enabled experiments 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> ListExperimentalFeaturesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/experiments", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ListExperimentalFeatures", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Report the locked user count metrics, for this namespace and all child namespaces. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LockedUsersList(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/locked-users", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LockedUsersList", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Report the locked user count metrics, for this namespace and all child namespaces. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LockedUsersListAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/locked-users", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LockedUsersList", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Unlocks the user with given mount_accessor and alias_identifier 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasIdentifier">It is the name of the alias (user). For example, if the alias belongs to userpass backend, the name should be a valid username within userpass auth method. If the alias belongs to an approle auth method, the name should be a valid RoleID</param>
        /// <param name="mountAccessor">MountAccessor is the identifier of the mount entry to which the user belongs</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LockedUsersUnlock(string aliasIdentifier, string mountAccessor, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'aliasIdentifier' is set
            if (aliasIdentifier == null)
                throw new VaultApiException(400, "Missing required parameter 'aliasIdentifier' when calling System->LockedUsersUnlock");

            // verify the required parameter 'mountAccessor' is set
            if (mountAccessor == null)
                throw new VaultApiException(400, "Missing required parameter 'mountAccessor' when calling System->LockedUsersUnlock");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("alias_identifier", ClientUtils.ParameterToString(aliasIdentifier)); // path parameter


            requestOptions.PathParameters.Add("mount_accessor", ClientUtils.ParameterToString(mountAccessor)); // path parameter






            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/locked-users/{mount_accessor}/unlock/{alias_identifier}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LockedUsersUnlock", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Unlocks the user with given mount_accessor and alias_identifier 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasIdentifier">It is the name of the alias (user). For example, if the alias belongs to userpass backend, the name should be a valid username within userpass auth method. If the alias belongs to an approle auth method, the name should be a valid RoleID</param>
        /// <param name="mountAccessor">MountAccessor is the identifier of the mount entry to which the user belongs</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LockedUsersUnlockAsync(string aliasIdentifier, string mountAccessor, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'aliasIdentifier' is set
            if (aliasIdentifier == null)
                throw new VaultApiException(400, "Missing required parameter 'aliasIdentifier' when calling System->LockedUsersUnlock");

            // verify the required parameter 'mountAccessor' is set
            if (mountAccessor == null)
                throw new VaultApiException(400, "Missing required parameter 'mountAccessor' when calling System->LockedUsersUnlock");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("alias_identifier", ClientUtils.ParameterToString(aliasIdentifier)); // path parameter


            requestOptions.PathParameters.Add("mount_accessor", ClientUtils.ParameterToString(mountAccessor)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/locked-users/{mount_accessor}/unlock/{alias_identifier}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LockedUsersUnlock", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Read the log level for all existing loggers. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LoggersReadVerbosityLevel(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/loggers", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LoggersReadVerbosityLevel", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Read the log level for all existing loggers. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LoggersReadVerbosityLevelAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/loggers", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LoggersReadVerbosityLevel", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Read the log level for a single logger. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the logger to be modified.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LoggersReadVerbosityLevelFor(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->LoggersReadVerbosityLevelFor");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/loggers/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LoggersReadVerbosityLevelFor", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Read the log level for a single logger. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the logger to be modified.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LoggersReadVerbosityLevelForAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->LoggersReadVerbosityLevelFor");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/loggers/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LoggersReadVerbosityLevelFor", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Revert the all loggers to use log level provided in config. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LoggersRevertVerbosityLevel(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/loggers", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LoggersRevertVerbosityLevel", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Revert the all loggers to use log level provided in config. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LoggersRevertVerbosityLevelAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/loggers", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LoggersRevertVerbosityLevel", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Revert a single logger to use log level provided in config. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the logger to be modified.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LoggersRevertVerbosityLevelFor(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->LoggersRevertVerbosityLevelFor");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/loggers/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LoggersRevertVerbosityLevelFor", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Revert a single logger to use log level provided in config. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the logger to be modified.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LoggersRevertVerbosityLevelForAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->LoggersRevertVerbosityLevelFor");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/loggers/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LoggersRevertVerbosityLevelFor", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Modify the log level for all existing loggers. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="loggersUpdateVerbosityLevelRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LoggersUpdateVerbosityLevel(LoggersUpdateVerbosityLevelRequest loggersUpdateVerbosityLevelRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'loggersUpdateVerbosityLevelRequest' is set
            if (loggersUpdateVerbosityLevelRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'loggersUpdateVerbosityLevelRequest' when calling System->LoggersUpdateVerbosityLevel");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = loggersUpdateVerbosityLevelRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/loggers", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LoggersUpdateVerbosityLevel", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Modify the log level for all existing loggers. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="loggersUpdateVerbosityLevelRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LoggersUpdateVerbosityLevelAsync(LoggersUpdateVerbosityLevelRequest loggersUpdateVerbosityLevelRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'loggersUpdateVerbosityLevelRequest' is set
            if (loggersUpdateVerbosityLevelRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'loggersUpdateVerbosityLevelRequest' when calling System->LoggersUpdateVerbosityLevel");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = loggersUpdateVerbosityLevelRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/loggers", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LoggersUpdateVerbosityLevel", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Modify the log level of a single logger. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="loggersUpdateVerbosityLevelForRequest"></param>
        /// <param name="name">The name of the logger to be modified.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> LoggersUpdateVerbosityLevelFor(string name, LoggersUpdateVerbosityLevelForRequest loggersUpdateVerbosityLevelForRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->LoggersUpdateVerbosityLevelFor");


            // verify the required parameter 'loggersUpdateVerbosityLevelForRequest' is set
            if (loggersUpdateVerbosityLevelForRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'loggersUpdateVerbosityLevelForRequest' when calling System->LoggersUpdateVerbosityLevelFor");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter





            requestOptions.Data = loggersUpdateVerbosityLevelForRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/loggers/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LoggersUpdateVerbosityLevelFor", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Modify the log level of a single logger. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="loggersUpdateVerbosityLevelForRequest"></param>
        /// <param name="name">The name of the logger to be modified.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> LoggersUpdateVerbosityLevelForAsync(string name, LoggersUpdateVerbosityLevelForRequest loggersUpdateVerbosityLevelForRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->LoggersUpdateVerbosityLevelFor");


            // verify the required parameter 'loggersUpdateVerbosityLevelForRequest' is set
            if (loggersUpdateVerbosityLevelForRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'loggersUpdateVerbosityLevelForRequest' when calling System->LoggersUpdateVerbosityLevelFor");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            requestOptions.Data = loggersUpdateVerbosityLevelForRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/loggers/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("LoggersUpdateVerbosityLevelFor", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="format">Format to export metrics into. Currently accepts only \&quot;prometheus\&quot;. (optional)</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> Metrics(string format = default(string), TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);




            if (format != null)
            {


                requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "format", format));

            }



            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/metrics", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Metrics", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="format">Format to export metrics into. Currently accepts only \&quot;prometheus\&quot;. (optional)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MetricsAsync(string format = default(string), TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);




            if (format != null)
            {
                requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "format", format));
            }
            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/metrics", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Metrics", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaValidateRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaValidate(MfaValidateRequest mfaValidateRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'mfaValidateRequest' is set
            if (mfaValidateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaValidateRequest' when calling System->MfaValidate");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = mfaValidateRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/mfa/validate", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaValidate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Validates the login for the given MFA methods. Upon successful validation, it returns an auth response containing the client token 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaValidateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaValidateAsync(MfaValidateRequest mfaValidateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'mfaValidateRequest' is set
            if (mfaValidateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaValidateRequest' when calling System->MfaValidate");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = mfaValidateRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/mfa/validate", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaValidate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="logFormat">Output format of logs. Supported values are \&quot;standard\&quot; and \&quot;json\&quot;. The default is \&quot;standard\&quot;. (optional, default to &quot;standard&quot;)</param>

        /// <param name="logLevel">Log level to view system logs at. Currently supported values are \&quot;trace\&quot;, \&quot;debug\&quot;, \&quot;info\&quot;, \&quot;warn\&quot;, \&quot;error\&quot;. (optional)</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> Monitor(string logFormat = default(string), string logLevel = default(string), TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);




            if (logFormat != null)
            {


                requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "log_format", logFormat));

            }

            if (logLevel != null)
            {


                requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "log_level", logLevel));

            }



            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/monitor", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Monitor", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="logFormat">Output format of logs. Supported values are \&quot;standard\&quot; and \&quot;json\&quot;. The default is \&quot;standard\&quot;. (optional, default to &quot;standard&quot;)</param>

        /// <param name="logLevel">Log level to view system logs at. Currently supported values are \&quot;trace\&quot;, \&quot;debug\&quot;, \&quot;info\&quot;, \&quot;warn\&quot;, \&quot;error\&quot;. (optional)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MonitorAsync(string logFormat = default(string), string logLevel = default(string), TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);




            if (logFormat != null)
            {
                requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "log_format", logFormat));
            }

            if (logLevel != null)
            {
                requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "log_level", logLevel));
            }
            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/monitor", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Monitor", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Disable the mount point specified at the given path. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MountsDisableSecretsEngine(string path, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->MountsDisableSecretsEngine");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/mounts/{path}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MountsDisableSecretsEngine", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Disable the mount point specified at the given path. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MountsDisableSecretsEngineAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->MountsDisableSecretsEngine");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/mounts/{path}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MountsDisableSecretsEngine", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Enable a new secrets engine at the given path. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mountsEnableSecretsEngineRequest"></param>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MountsEnableSecretsEngine(string path, MountsEnableSecretsEngineRequest mountsEnableSecretsEngineRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->MountsEnableSecretsEngine");


            // verify the required parameter 'mountsEnableSecretsEngineRequest' is set
            if (mountsEnableSecretsEngineRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mountsEnableSecretsEngineRequest' when calling System->MountsEnableSecretsEngine");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter





            requestOptions.Data = mountsEnableSecretsEngineRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/mounts/{path}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MountsEnableSecretsEngine", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Enable a new secrets engine at the given path. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mountsEnableSecretsEngineRequest"></param>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MountsEnableSecretsEngineAsync(string path, MountsEnableSecretsEngineRequest mountsEnableSecretsEngineRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->MountsEnableSecretsEngine");


            // verify the required parameter 'mountsEnableSecretsEngineRequest' is set
            if (mountsEnableSecretsEngineRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mountsEnableSecretsEngineRequest' when calling System->MountsEnableSecretsEngine");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            requestOptions.Data = mountsEnableSecretsEngineRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/mounts/{path}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MountsEnableSecretsEngine", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MountsListSecretsEngines(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/mounts", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MountsListSecretsEngines", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MountsListSecretsEnginesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/mounts", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MountsListSecretsEngines", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Read the configuration of the secret engine at the given path. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <returns>VaultResponse of MountsReadConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<MountsReadConfigurationResponse> MountsReadConfiguration(string path, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->MountsReadConfiguration");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<MountsReadConfigurationResponse>("/sys/mounts/{path}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MountsReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<MountsReadConfigurationResponse>(response.RawContent);
        }


        /// <summary>
        /// Read the configuration of the secret engine at the given path. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (MountsReadConfigurationResponse)</returns>
        public async Task<VaultResponse<MountsReadConfigurationResponse>> MountsReadConfigurationAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->MountsReadConfiguration");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<MountsReadConfigurationResponse>("/sys/mounts/{path}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MountsReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<MountsReadConfigurationResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <returns>VaultResponse of MountsReadTuningInformationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<MountsReadTuningInformationResponse> MountsReadTuningInformation(string path, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->MountsReadTuningInformation");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<MountsReadTuningInformationResponse>("/sys/mounts/{path}/tune", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MountsReadTuningInformation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<MountsReadTuningInformationResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (MountsReadTuningInformationResponse)</returns>
        public async Task<VaultResponse<MountsReadTuningInformationResponse>> MountsReadTuningInformationAsync(string path, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->MountsReadTuningInformation");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<MountsReadTuningInformationResponse>("/sys/mounts/{path}/tune", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MountsReadTuningInformation", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<MountsReadTuningInformationResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mountsTuneConfigurationParametersRequest"></param>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MountsTuneConfigurationParameters(string path, MountsTuneConfigurationParametersRequest mountsTuneConfigurationParametersRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->MountsTuneConfigurationParameters");


            // verify the required parameter 'mountsTuneConfigurationParametersRequest' is set
            if (mountsTuneConfigurationParametersRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mountsTuneConfigurationParametersRequest' when calling System->MountsTuneConfigurationParameters");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter





            requestOptions.Data = mountsTuneConfigurationParametersRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/mounts/{path}/tune", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MountsTuneConfigurationParameters", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mountsTuneConfigurationParametersRequest"></param>
        /// <param name="path">The path to mount to. Example: \&quot;aws/east\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MountsTuneConfigurationParametersAsync(string path, MountsTuneConfigurationParametersRequest mountsTuneConfigurationParametersRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'path' is set
            if (path == null)
                throw new VaultApiException(400, "Missing required parameter 'path' when calling System->MountsTuneConfigurationParameters");


            // verify the required parameter 'mountsTuneConfigurationParametersRequest' is set
            if (mountsTuneConfigurationParametersRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mountsTuneConfigurationParametersRequest' when calling System->MountsTuneConfigurationParameters");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("path", ClientUtils.ParameterToString(path)); // path parameter



            requestOptions.Data = mountsTuneConfigurationParametersRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/mounts/{path}/tune", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MountsTuneConfigurationParameters", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of PluginsCatalogListPluginsResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<PluginsCatalogListPluginsResponse> PluginsCatalogListPlugins(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<PluginsCatalogListPluginsResponse>("/sys/plugins/catalog", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogListPlugins", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PluginsCatalogListPluginsResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PluginsCatalogListPluginsResponse)</returns>
        public async Task<VaultResponse<PluginsCatalogListPluginsResponse>> PluginsCatalogListPluginsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<PluginsCatalogListPluginsResponse>("/sys/plugins/catalog", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogListPlugins", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PluginsCatalogListPluginsResponse>(response.RawContent);
        }
        /// <summary>
        /// List the plugins in the catalog. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <returns>VaultResponse of PluginsCatalogListPluginsWithTypeResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<PluginsCatalogListPluginsWithTypeResponse> PluginsCatalogListPluginsWithType(string type, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'type' is set
            if (type == null)
                throw new VaultApiException(400, "Missing required parameter 'type' when calling System->PluginsCatalogListPluginsWithType");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<PluginsCatalogListPluginsWithTypeResponse>("/sys/plugins/catalog/{type}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogListPluginsWithType", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PluginsCatalogListPluginsWithTypeResponse>(response.RawContent);
        }


        /// <summary>
        /// List the plugins in the catalog. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PluginsCatalogListPluginsWithTypeResponse)</returns>
        public async Task<VaultResponse<PluginsCatalogListPluginsWithTypeResponse>> PluginsCatalogListPluginsWithTypeAsync(string type, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'type' is set
            if (type == null)
                throw new VaultApiException(400, "Missing required parameter 'type' when calling System->PluginsCatalogListPluginsWithType");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<PluginsCatalogListPluginsWithTypeResponse>("/sys/plugins/catalog/{type}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogListPluginsWithType", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PluginsCatalogListPluginsWithTypeResponse>(response.RawContent);
        }
        /// <summary>
        /// Return the configuration data for the plugin with the given name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <returns>VaultResponse of PluginsCatalogReadPluginConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<PluginsCatalogReadPluginConfigurationResponse> PluginsCatalogReadPluginConfiguration(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PluginsCatalogReadPluginConfiguration");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<PluginsCatalogReadPluginConfigurationResponse>("/sys/plugins/catalog/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogReadPluginConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PluginsCatalogReadPluginConfigurationResponse>(response.RawContent);
        }


        /// <summary>
        /// Return the configuration data for the plugin with the given name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PluginsCatalogReadPluginConfigurationResponse)</returns>
        public async Task<VaultResponse<PluginsCatalogReadPluginConfigurationResponse>> PluginsCatalogReadPluginConfigurationAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PluginsCatalogReadPluginConfiguration");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<PluginsCatalogReadPluginConfigurationResponse>("/sys/plugins/catalog/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogReadPluginConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PluginsCatalogReadPluginConfigurationResponse>(response.RawContent);
        }
        /// <summary>
        /// Return the configuration data for the plugin with the given name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <returns>VaultResponse of PluginsCatalogReadPluginConfigurationWithTypeResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<PluginsCatalogReadPluginConfigurationWithTypeResponse> PluginsCatalogReadPluginConfigurationWithType(string name, string type, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PluginsCatalogReadPluginConfigurationWithType");

            // verify the required parameter 'type' is set
            if (type == null)
                throw new VaultApiException(400, "Missing required parameter 'type' when calling System->PluginsCatalogReadPluginConfigurationWithType");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter


            requestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<PluginsCatalogReadPluginConfigurationWithTypeResponse>("/sys/plugins/catalog/{type}/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogReadPluginConfigurationWithType", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PluginsCatalogReadPluginConfigurationWithTypeResponse>(response.RawContent);
        }


        /// <summary>
        /// Return the configuration data for the plugin with the given name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PluginsCatalogReadPluginConfigurationWithTypeResponse)</returns>
        public async Task<VaultResponse<PluginsCatalogReadPluginConfigurationWithTypeResponse>> PluginsCatalogReadPluginConfigurationWithTypeAsync(string name, string type, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PluginsCatalogReadPluginConfigurationWithType");

            // verify the required parameter 'type' is set
            if (type == null)
                throw new VaultApiException(400, "Missing required parameter 'type' when calling System->PluginsCatalogReadPluginConfigurationWithType");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter


            requestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<PluginsCatalogReadPluginConfigurationWithTypeResponse>("/sys/plugins/catalog/{type}/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogReadPluginConfigurationWithType", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PluginsCatalogReadPluginConfigurationWithTypeResponse>(response.RawContent);
        }
        /// <summary>
        /// Register a new plugin, or updates an existing one with the supplied name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginsCatalogRegisterPluginRequest"></param>
        /// <param name="name">The name of the plugin</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PluginsCatalogRegisterPlugin(string name, PluginsCatalogRegisterPluginRequest pluginsCatalogRegisterPluginRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PluginsCatalogRegisterPlugin");


            // verify the required parameter 'pluginsCatalogRegisterPluginRequest' is set
            if (pluginsCatalogRegisterPluginRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'pluginsCatalogRegisterPluginRequest' when calling System->PluginsCatalogRegisterPlugin");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter





            requestOptions.Data = pluginsCatalogRegisterPluginRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/plugins/catalog/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogRegisterPlugin", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Register a new plugin, or updates an existing one with the supplied name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginsCatalogRegisterPluginRequest"></param>
        /// <param name="name">The name of the plugin</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PluginsCatalogRegisterPluginAsync(string name, PluginsCatalogRegisterPluginRequest pluginsCatalogRegisterPluginRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PluginsCatalogRegisterPlugin");


            // verify the required parameter 'pluginsCatalogRegisterPluginRequest' is set
            if (pluginsCatalogRegisterPluginRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'pluginsCatalogRegisterPluginRequest' when calling System->PluginsCatalogRegisterPlugin");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            requestOptions.Data = pluginsCatalogRegisterPluginRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/plugins/catalog/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogRegisterPlugin", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Register a new plugin, or updates an existing one with the supplied name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginsCatalogRegisterPluginWithTypeRequest"></param>
        /// <param name="name">The name of the plugin</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PluginsCatalogRegisterPluginWithType(string name, string type, PluginsCatalogRegisterPluginWithTypeRequest pluginsCatalogRegisterPluginWithTypeRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PluginsCatalogRegisterPluginWithType");

            // verify the required parameter 'type' is set
            if (type == null)
                throw new VaultApiException(400, "Missing required parameter 'type' when calling System->PluginsCatalogRegisterPluginWithType");


            // verify the required parameter 'pluginsCatalogRegisterPluginWithTypeRequest' is set
            if (pluginsCatalogRegisterPluginWithTypeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'pluginsCatalogRegisterPluginWithTypeRequest' when calling System->PluginsCatalogRegisterPluginWithType");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter


            requestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter





            requestOptions.Data = pluginsCatalogRegisterPluginWithTypeRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/plugins/catalog/{type}/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogRegisterPluginWithType", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Register a new plugin, or updates an existing one with the supplied name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginsCatalogRegisterPluginWithTypeRequest"></param>
        /// <param name="name">The name of the plugin</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PluginsCatalogRegisterPluginWithTypeAsync(string name, string type, PluginsCatalogRegisterPluginWithTypeRequest pluginsCatalogRegisterPluginWithTypeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PluginsCatalogRegisterPluginWithType");

            // verify the required parameter 'type' is set
            if (type == null)
                throw new VaultApiException(400, "Missing required parameter 'type' when calling System->PluginsCatalogRegisterPluginWithType");


            // verify the required parameter 'pluginsCatalogRegisterPluginWithTypeRequest' is set
            if (pluginsCatalogRegisterPluginWithTypeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'pluginsCatalogRegisterPluginWithTypeRequest' when calling System->PluginsCatalogRegisterPluginWithType");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter


            requestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter



            requestOptions.Data = pluginsCatalogRegisterPluginWithTypeRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/plugins/catalog/{type}/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogRegisterPluginWithType", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Remove the plugin with the given name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PluginsCatalogRemovePlugin(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PluginsCatalogRemovePlugin");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/plugins/catalog/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogRemovePlugin", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Remove the plugin with the given name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PluginsCatalogRemovePluginAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PluginsCatalogRemovePlugin");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/plugins/catalog/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogRemovePlugin", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Remove the plugin with the given name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PluginsCatalogRemovePluginWithType(string name, string type, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PluginsCatalogRemovePluginWithType");

            // verify the required parameter 'type' is set
            if (type == null)
                throw new VaultApiException(400, "Missing required parameter 'type' when calling System->PluginsCatalogRemovePluginWithType");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter


            requestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/plugins/catalog/{type}/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogRemovePluginWithType", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Remove the plugin with the given name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the plugin</param>
        /// <param name="type">The type of the plugin, may be auth, secret, or database</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PluginsCatalogRemovePluginWithTypeAsync(string name, string type, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PluginsCatalogRemovePluginWithType");

            // verify the required parameter 'type' is set
            if (type == null)
                throw new VaultApiException(400, "Missing required parameter 'type' when calling System->PluginsCatalogRemovePluginWithType");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter


            requestOptions.PathParameters.Add("type", ClientUtils.ParameterToString(type)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/plugins/catalog/{type}/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsCatalogRemovePluginWithType", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Reload mounted plugin backends. Either the plugin name (&#x60;plugin&#x60;) or the desired plugin backend mounts (&#x60;mounts&#x60;) must be provided, but not both. In the case that the plugin name is provided, all mounted paths that use that plugin backend will be reloaded.  If (&#x60;scope&#x60;) is provided and is (&#x60;global&#x60;), the plugin(s) are reloaded globally.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginsReloadBackendsRequest"></param>
        /// <returns>VaultResponse of PluginsReloadBackendsResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<PluginsReloadBackendsResponse> PluginsReloadBackends(PluginsReloadBackendsRequest pluginsReloadBackendsRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'pluginsReloadBackendsRequest' is set
            if (pluginsReloadBackendsRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'pluginsReloadBackendsRequest' when calling System->PluginsReloadBackends");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = pluginsReloadBackendsRequest;


            // make the HTTP request
            var response = this.Client.Post<PluginsReloadBackendsResponse>("/sys/plugins/reload/backend", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsReloadBackends", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PluginsReloadBackendsResponse>(response.RawContent);
        }


        /// <summary>
        /// Reload mounted plugin backends. Either the plugin name (&#x60;plugin&#x60;) or the desired plugin backend mounts (&#x60;mounts&#x60;) must be provided, but not both. In the case that the plugin name is provided, all mounted paths that use that plugin backend will be reloaded.  If (&#x60;scope&#x60;) is provided and is (&#x60;global&#x60;), the plugin(s) are reloaded globally.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="pluginsReloadBackendsRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PluginsReloadBackendsResponse)</returns>
        public async Task<VaultResponse<PluginsReloadBackendsResponse>> PluginsReloadBackendsAsync(PluginsReloadBackendsRequest pluginsReloadBackendsRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'pluginsReloadBackendsRequest' is set
            if (pluginsReloadBackendsRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'pluginsReloadBackendsRequest' when calling System->PluginsReloadBackends");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = pluginsReloadBackendsRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<PluginsReloadBackendsResponse>("/sys/plugins/reload/backend", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PluginsReloadBackends", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PluginsReloadBackendsResponse>(response.RawContent);
        }
        /// <summary>
        /// Delete the ACL policy with the given name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the policy. Example: \&quot;ops\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PoliciesDeleteAclPolicy(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesDeleteAclPolicy");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/policies/acl/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesDeleteAclPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete the ACL policy with the given name. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the policy. Example: \&quot;ops\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PoliciesDeleteAclPolicyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesDeleteAclPolicy");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/policies/acl/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesDeleteAclPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Delete a password policy. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the password policy.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PoliciesDeletePasswordPolicy(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesDeletePasswordPolicy");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/policies/password/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesDeletePasswordPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete a password policy. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the password policy.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PoliciesDeletePasswordPolicyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesDeletePasswordPolicy");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/policies/password/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesDeletePasswordPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Generate a password from an existing password policy. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the password policy.</param>
        /// <returns>VaultResponse of PoliciesGeneratePasswordFromPasswordPolicyResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<PoliciesGeneratePasswordFromPasswordPolicyResponse> PoliciesGeneratePasswordFromPasswordPolicy(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesGeneratePasswordFromPasswordPolicy");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<PoliciesGeneratePasswordFromPasswordPolicyResponse>("/sys/policies/password/{name}/generate", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesGeneratePasswordFromPasswordPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PoliciesGeneratePasswordFromPasswordPolicyResponse>(response.RawContent);
        }


        /// <summary>
        /// Generate a password from an existing password policy. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the password policy.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PoliciesGeneratePasswordFromPasswordPolicyResponse)</returns>
        public async Task<VaultResponse<PoliciesGeneratePasswordFromPasswordPolicyResponse>> PoliciesGeneratePasswordFromPasswordPolicyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesGeneratePasswordFromPasswordPolicy");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<PoliciesGeneratePasswordFromPasswordPolicyResponse>("/sys/policies/password/{name}/generate", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesGeneratePasswordFromPasswordPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PoliciesGeneratePasswordFromPasswordPolicyResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="list">Return a list if &#x60;true&#x60; (optional)</param>
        /// <returns>VaultResponse of PoliciesListResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<PoliciesListResponse> PoliciesList(string list = default(string), TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);




            if (list != null)
            {


                requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", list));

            }



            // make the HTTP request
            var response = this.Client.Get<PoliciesListResponse>("/sys/policy", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesList", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PoliciesListResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="list">Return a list if &#x60;true&#x60; (optional)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PoliciesListResponse)</returns>
        public async Task<VaultResponse<PoliciesListResponse>> PoliciesListAsync(string list = default(string), TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);




            if (list != null)
            {
                requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", list));
            }
            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<PoliciesListResponse>("/sys/policy", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesList", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PoliciesListResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of PoliciesListAclPoliciesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<PoliciesListAclPoliciesResponse> PoliciesListAclPolicies(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<PoliciesListAclPoliciesResponse>("/sys/policies/acl", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesListAclPolicies", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PoliciesListAclPoliciesResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PoliciesListAclPoliciesResponse)</returns>
        public async Task<VaultResponse<PoliciesListAclPoliciesResponse>> PoliciesListAclPoliciesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<PoliciesListAclPoliciesResponse>("/sys/policies/acl", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesListAclPolicies", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PoliciesListAclPoliciesResponse>(response.RawContent);
        }
        /// <summary>
        /// List the existing password policies. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of PoliciesListPasswordPoliciesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<PoliciesListPasswordPoliciesResponse> PoliciesListPasswordPolicies(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<PoliciesListPasswordPoliciesResponse>("/sys/policies/password", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesListPasswordPolicies", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PoliciesListPasswordPoliciesResponse>(response.RawContent);
        }


        /// <summary>
        /// List the existing password policies. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PoliciesListPasswordPoliciesResponse)</returns>
        public async Task<VaultResponse<PoliciesListPasswordPoliciesResponse>> PoliciesListPasswordPoliciesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<PoliciesListPasswordPoliciesResponse>("/sys/policies/password", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesListPasswordPolicies", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PoliciesListPasswordPoliciesResponse>(response.RawContent);
        }
        /// <summary>
        /// Retrieve information about the named ACL policy. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the policy. Example: \&quot;ops\&quot;</param>
        /// <returns>VaultResponse of PoliciesReadAclPolicyResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<PoliciesReadAclPolicyResponse> PoliciesReadAclPolicy(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesReadAclPolicy");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<PoliciesReadAclPolicyResponse>("/sys/policies/acl/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesReadAclPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PoliciesReadAclPolicyResponse>(response.RawContent);
        }


        /// <summary>
        /// Retrieve information about the named ACL policy. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the policy. Example: \&quot;ops\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PoliciesReadAclPolicyResponse)</returns>
        public async Task<VaultResponse<PoliciesReadAclPolicyResponse>> PoliciesReadAclPolicyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesReadAclPolicy");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<PoliciesReadAclPolicyResponse>("/sys/policies/acl/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesReadAclPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PoliciesReadAclPolicyResponse>(response.RawContent);
        }
        /// <summary>
        /// Retrieve an existing password policy. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the password policy.</param>
        /// <returns>VaultResponse of PoliciesReadPasswordPolicyResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<PoliciesReadPasswordPolicyResponse> PoliciesReadPasswordPolicy(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesReadPasswordPolicy");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<PoliciesReadPasswordPolicyResponse>("/sys/policies/password/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesReadPasswordPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PoliciesReadPasswordPolicyResponse>(response.RawContent);
        }


        /// <summary>
        /// Retrieve an existing password policy. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">The name of the password policy.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (PoliciesReadPasswordPolicyResponse)</returns>
        public async Task<VaultResponse<PoliciesReadPasswordPolicyResponse>> PoliciesReadPasswordPolicyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesReadPasswordPolicy");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<PoliciesReadPasswordPolicyResponse>("/sys/policies/password/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesReadPasswordPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<PoliciesReadPasswordPolicyResponse>(response.RawContent);
        }
        /// <summary>
        /// Add a new or update an existing ACL policy. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="policiesWriteAclPolicyRequest"></param>
        /// <param name="name">The name of the policy. Example: \&quot;ops\&quot;</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PoliciesWriteAclPolicy(string name, PoliciesWriteAclPolicyRequest policiesWriteAclPolicyRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesWriteAclPolicy");


            // verify the required parameter 'policiesWriteAclPolicyRequest' is set
            if (policiesWriteAclPolicyRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'policiesWriteAclPolicyRequest' when calling System->PoliciesWriteAclPolicy");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter





            requestOptions.Data = policiesWriteAclPolicyRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/policies/acl/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesWriteAclPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Add a new or update an existing ACL policy. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="policiesWriteAclPolicyRequest"></param>
        /// <param name="name">The name of the policy. Example: \&quot;ops\&quot;</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PoliciesWriteAclPolicyAsync(string name, PoliciesWriteAclPolicyRequest policiesWriteAclPolicyRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesWriteAclPolicy");


            // verify the required parameter 'policiesWriteAclPolicyRequest' is set
            if (policiesWriteAclPolicyRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'policiesWriteAclPolicyRequest' when calling System->PoliciesWriteAclPolicy");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            requestOptions.Data = policiesWriteAclPolicyRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/policies/acl/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesWriteAclPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Add a new or update an existing password policy. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="policiesWritePasswordPolicyRequest"></param>
        /// <param name="name">The name of the password policy.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PoliciesWritePasswordPolicy(string name, PoliciesWritePasswordPolicyRequest policiesWritePasswordPolicyRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesWritePasswordPolicy");


            // verify the required parameter 'policiesWritePasswordPolicyRequest' is set
            if (policiesWritePasswordPolicyRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'policiesWritePasswordPolicyRequest' when calling System->PoliciesWritePasswordPolicy");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter





            requestOptions.Data = policiesWritePasswordPolicyRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/policies/password/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesWritePasswordPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Add a new or update an existing password policy. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="policiesWritePasswordPolicyRequest"></param>
        /// <param name="name">The name of the password policy.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PoliciesWritePasswordPolicyAsync(string name, PoliciesWritePasswordPolicyRequest policiesWritePasswordPolicyRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->PoliciesWritePasswordPolicy");


            // verify the required parameter 'policiesWritePasswordPolicyRequest' is set
            if (policiesWritePasswordPolicyRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'policiesWritePasswordPolicyRequest' when calling System->PoliciesWritePasswordPolicy");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            requestOptions.Data = policiesWritePasswordPolicyRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/policies/password/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PoliciesWritePasswordPolicy", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns stack traces that led to blocking on synchronization primitives Returns stack traces that led to blocking on synchronization primitives
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PprofBlocking(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/pprof/block", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofBlocking", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns stack traces that led to blocking on synchronization primitives Returns stack traces that led to blocking on synchronization primitives
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PprofBlockingAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/pprof/block", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofBlocking", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns the running program&#x27;s command line. Returns the running program&#x27;s command line, with arguments separated by NUL bytes.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PprofCommandLine(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/pprof/cmdline", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofCommandLine", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns the running program&#x27;s command line. Returns the running program&#x27;s command line, with arguments separated by NUL bytes.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PprofCommandLineAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/pprof/cmdline", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofCommandLine", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns a pprof-formatted cpu profile payload. Returns a pprof-formatted cpu profile payload. Profiling lasts for duration specified in seconds GET parameter, or for 30 seconds if not specified.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PprofCpuProfile(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/pprof/profile", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofCpuProfile", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns a pprof-formatted cpu profile payload. Returns a pprof-formatted cpu profile payload. Profiling lasts for duration specified in seconds GET parameter, or for 30 seconds if not specified.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PprofCpuProfileAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/pprof/profile", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofCpuProfile", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns the execution trace in binary form. Returns  the execution trace in binary form. Tracing lasts for duration specified in seconds GET parameter, or for 1 second if not specified.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PprofExecutionTrace(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/pprof/trace", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofExecutionTrace", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns the execution trace in binary form. Returns  the execution trace in binary form. Tracing lasts for duration specified in seconds GET parameter, or for 1 second if not specified.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PprofExecutionTraceAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/pprof/trace", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofExecutionTrace", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns stack traces of all current goroutines. Returns stack traces of all current goroutines.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PprofGoroutines(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/pprof/goroutine", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofGoroutines", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns stack traces of all current goroutines. Returns stack traces of all current goroutines.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PprofGoroutinesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/pprof/goroutine", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofGoroutines", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns an HTML page listing the available profiles. Returns an HTML page listing the available  profiles. This should be mainly accessed via browsers or applications that can  render pages.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PprofIndex(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/pprof/", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofIndex", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns an HTML page listing the available profiles. Returns an HTML page listing the available  profiles. This should be mainly accessed via browsers or applications that can  render pages.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PprofIndexAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/pprof/", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofIndex", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns a sampling of all past memory allocations. Returns a sampling of all past memory allocations.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PprofMemoryAllocations(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/pprof/allocs", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofMemoryAllocations", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns a sampling of all past memory allocations. Returns a sampling of all past memory allocations.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PprofMemoryAllocationsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/pprof/allocs", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofMemoryAllocations", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns a sampling of memory allocations of live object. Returns a sampling of memory allocations of live object.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PprofMemoryAllocationsLive(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/pprof/heap", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofMemoryAllocationsLive", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns a sampling of memory allocations of live object. Returns a sampling of memory allocations of live object.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PprofMemoryAllocationsLiveAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/pprof/heap", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofMemoryAllocationsLive", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns stack traces of holders of contended mutexes Returns stack traces of holders of contended mutexes
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PprofMutexes(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/pprof/mutex", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofMutexes", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns stack traces of holders of contended mutexes Returns stack traces of holders of contended mutexes
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PprofMutexesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/pprof/mutex", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofMutexes", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns the program counters listed in the request. Returns the program counters listed in the request.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PprofSymbols(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/pprof/symbol", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofSymbols", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns the program counters listed in the request. Returns the program counters listed in the request.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PprofSymbolsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/pprof/symbol", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofSymbols", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns stack traces that led to the creation of new OS threads Returns stack traces that led to the creation of new OS threads
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PprofThreadCreations(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/pprof/threadcreate", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofThreadCreations", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns stack traces that led to the creation of new OS threads Returns stack traces that led to the creation of new OS threads
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PprofThreadCreationsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/pprof/threadcreate", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PprofThreadCreations", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="queryTokenAccessorCapabilitiesRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> QueryTokenAccessorCapabilities(QueryTokenAccessorCapabilitiesRequest queryTokenAccessorCapabilitiesRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'queryTokenAccessorCapabilitiesRequest' is set
            if (queryTokenAccessorCapabilitiesRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'queryTokenAccessorCapabilitiesRequest' when calling System->QueryTokenAccessorCapabilities");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = queryTokenAccessorCapabilitiesRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/capabilities-accessor", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("QueryTokenAccessorCapabilities", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="queryTokenAccessorCapabilitiesRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> QueryTokenAccessorCapabilitiesAsync(QueryTokenAccessorCapabilitiesRequest queryTokenAccessorCapabilitiesRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'queryTokenAccessorCapabilitiesRequest' is set
            if (queryTokenAccessorCapabilitiesRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'queryTokenAccessorCapabilitiesRequest' when calling System->QueryTokenAccessorCapabilities");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = queryTokenAccessorCapabilitiesRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/capabilities-accessor", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("QueryTokenAccessorCapabilities", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="queryTokenCapabilitiesRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> QueryTokenCapabilities(QueryTokenCapabilitiesRequest queryTokenCapabilitiesRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'queryTokenCapabilitiesRequest' is set
            if (queryTokenCapabilitiesRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'queryTokenCapabilitiesRequest' when calling System->QueryTokenCapabilities");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = queryTokenCapabilitiesRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/capabilities", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("QueryTokenCapabilities", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="queryTokenCapabilitiesRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> QueryTokenCapabilitiesAsync(QueryTokenCapabilitiesRequest queryTokenCapabilitiesRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'queryTokenCapabilitiesRequest' is set
            if (queryTokenCapabilitiesRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'queryTokenCapabilitiesRequest' when calling System->QueryTokenCapabilities");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = queryTokenCapabilitiesRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/capabilities", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("QueryTokenCapabilities", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="queryTokenSelfCapabilitiesRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> QueryTokenSelfCapabilities(QueryTokenSelfCapabilitiesRequest queryTokenSelfCapabilitiesRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'queryTokenSelfCapabilitiesRequest' is set
            if (queryTokenSelfCapabilitiesRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'queryTokenSelfCapabilitiesRequest' when calling System->QueryTokenSelfCapabilities");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = queryTokenSelfCapabilitiesRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/capabilities-self", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("QueryTokenSelfCapabilities", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="queryTokenSelfCapabilitiesRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> QueryTokenSelfCapabilitiesAsync(QueryTokenSelfCapabilitiesRequest queryTokenSelfCapabilitiesRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'queryTokenSelfCapabilitiesRequest' is set
            if (queryTokenSelfCapabilitiesRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'queryTokenSelfCapabilitiesRequest' when calling System->QueryTokenSelfCapabilities");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = queryTokenSelfCapabilitiesRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/capabilities-self", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("QueryTokenSelfCapabilities", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rateLimitQuotasConfigureRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> RateLimitQuotasConfigure(RateLimitQuotasConfigureRequest rateLimitQuotasConfigureRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'rateLimitQuotasConfigureRequest' is set
            if (rateLimitQuotasConfigureRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rateLimitQuotasConfigureRequest' when calling System->RateLimitQuotasConfigure");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = rateLimitQuotasConfigureRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/quotas/config", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RateLimitQuotasConfigure", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rateLimitQuotasConfigureRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> RateLimitQuotasConfigureAsync(RateLimitQuotasConfigureRequest rateLimitQuotasConfigureRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'rateLimitQuotasConfigureRequest' is set
            if (rateLimitQuotasConfigureRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rateLimitQuotasConfigureRequest' when calling System->RateLimitQuotasConfigure");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = rateLimitQuotasConfigureRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/quotas/config", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RateLimitQuotasConfigure", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the quota rule.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> RateLimitQuotasDelete(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->RateLimitQuotasDelete");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/quotas/rate-limit/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RateLimitQuotasDelete", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the quota rule.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> RateLimitQuotasDeleteAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->RateLimitQuotasDelete");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/quotas/rate-limit/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RateLimitQuotasDelete", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RateLimitQuotasListResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RateLimitQuotasListResponse> RateLimitQuotasList(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<RateLimitQuotasListResponse>("/sys/quotas/rate-limit", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RateLimitQuotasList", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RateLimitQuotasListResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RateLimitQuotasListResponse)</returns>
        public async Task<VaultResponse<RateLimitQuotasListResponse>> RateLimitQuotasListAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<RateLimitQuotasListResponse>("/sys/quotas/rate-limit", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RateLimitQuotasList", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RateLimitQuotasListResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the quota rule.</param>
        /// <returns>VaultResponse of RateLimitQuotasReadResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RateLimitQuotasReadResponse> RateLimitQuotasRead(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->RateLimitQuotasRead");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<RateLimitQuotasReadResponse>("/sys/quotas/rate-limit/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RateLimitQuotasRead", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RateLimitQuotasReadResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the quota rule.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RateLimitQuotasReadResponse)</returns>
        public async Task<VaultResponse<RateLimitQuotasReadResponse>> RateLimitQuotasReadAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->RateLimitQuotasRead");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<RateLimitQuotasReadResponse>("/sys/quotas/rate-limit/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RateLimitQuotasRead", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RateLimitQuotasReadResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RateLimitQuotasReadConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RateLimitQuotasReadConfigurationResponse> RateLimitQuotasReadConfiguration(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<RateLimitQuotasReadConfigurationResponse>("/sys/quotas/config", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RateLimitQuotasReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RateLimitQuotasReadConfigurationResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RateLimitQuotasReadConfigurationResponse)</returns>
        public async Task<VaultResponse<RateLimitQuotasReadConfigurationResponse>> RateLimitQuotasReadConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<RateLimitQuotasReadConfigurationResponse>("/sys/quotas/config", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RateLimitQuotasReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RateLimitQuotasReadConfigurationResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rateLimitQuotasWriteRequest"></param>
        /// <param name="name">Name of the quota rule.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> RateLimitQuotasWrite(string name, RateLimitQuotasWriteRequest rateLimitQuotasWriteRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->RateLimitQuotasWrite");


            // verify the required parameter 'rateLimitQuotasWriteRequest' is set
            if (rateLimitQuotasWriteRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rateLimitQuotasWriteRequest' when calling System->RateLimitQuotasWrite");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter





            requestOptions.Data = rateLimitQuotasWriteRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/quotas/rate-limit/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RateLimitQuotasWrite", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rateLimitQuotasWriteRequest"></param>
        /// <param name="name">Name of the quota rule.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> RateLimitQuotasWriteAsync(string name, RateLimitQuotasWriteRequest rateLimitQuotasWriteRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling System->RateLimitQuotasWrite");


            // verify the required parameter 'rateLimitQuotasWriteRequest' is set
            if (rateLimitQuotasWriteRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rateLimitQuotasWriteRequest' when calling System->RateLimitQuotasWrite");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("name", ClientUtils.ParameterToString(name)); // path parameter



            requestOptions.Data = rateLimitQuotasWriteRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/quotas/rate-limit/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RateLimitQuotasWrite", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns the health status of Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> ReadHealthStatus(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/health", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ReadHealthStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns the health status of Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> ReadHealthStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/health", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ReadHealthStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns the initialization status of Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> ReadInitializationStatus(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/init", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ReadInitializationStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Returns the initialization status of Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> ReadInitializationStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/init", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ReadInitializationStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Return a sanitized version of the Vault server configuration. The sanitized output strips configuration values in the storage, HA storage, and seals stanzas, which may contain sensitive values such as API tokens. It also removes any token or secret fields in other stanzas, such as the circonus_api_token from telemetry.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> ReadSanitizedConfigurationState(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/config/state/sanitized", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ReadSanitizedConfigurationState", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Return a sanitized version of the Vault server configuration. The sanitized output strips configuration values in the storage, HA storage, and seals stanzas, which may contain sensitive values such as API tokens. It also removes any token or secret fields in other stanzas, such as the circonus_api_token from telemetry.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> ReadSanitizedConfigurationStateAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/config/state/sanitized", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ReadSanitizedConfigurationState", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Look up wrapping properties for the given token. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="readWrappingPropertiesRequest"></param>
        /// <returns>VaultResponse of ReadWrappingPropertiesResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<ReadWrappingPropertiesResponse> ReadWrappingProperties(ReadWrappingPropertiesRequest readWrappingPropertiesRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'readWrappingPropertiesRequest' is set
            if (readWrappingPropertiesRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'readWrappingPropertiesRequest' when calling System->ReadWrappingProperties");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = readWrappingPropertiesRequest;


            // make the HTTP request
            var response = this.Client.Post<ReadWrappingPropertiesResponse>("/sys/wrapping/lookup", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ReadWrappingProperties", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<ReadWrappingPropertiesResponse>(response.RawContent);
        }


        /// <summary>
        /// Look up wrapping properties for the given token. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="readWrappingPropertiesRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (ReadWrappingPropertiesResponse)</returns>
        public async Task<VaultResponse<ReadWrappingPropertiesResponse>> ReadWrappingPropertiesAsync(ReadWrappingPropertiesRequest readWrappingPropertiesRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'readWrappingPropertiesRequest' is set
            if (readWrappingPropertiesRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'readWrappingPropertiesRequest' when calling System->ReadWrappingProperties");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = readWrappingPropertiesRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<ReadWrappingPropertiesResponse>("/sys/wrapping/lookup", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ReadWrappingProperties", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<ReadWrappingPropertiesResponse>(response.RawContent);
        }
        /// <summary>
        /// Cancels any in-progress rekey. This clears the rekey settings as well as any progress made. This must be called to change the parameters of the rekey. Note: verification is still a part of a rekey. If rekeying is canceled during the verification flow, the current unseal keys remain valid.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> RekeyAttemptCancel(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/rekey/init", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyAttemptCancel", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Cancels any in-progress rekey. This clears the rekey settings as well as any progress made. This must be called to change the parameters of the rekey. Note: verification is still a part of a rekey. If rekeying is canceled during the verification flow, the current unseal keys remain valid.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> RekeyAttemptCancelAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/rekey/init", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyAttemptCancel", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Initializes a new rekey attempt. Only a single rekey attempt can take place at a time, and changing the parameters of a rekey requires canceling and starting a new rekey, which will also provide a new nonce.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rekeyAttemptInitializeRequest"></param>
        /// <returns>VaultResponse of RekeyAttemptInitializeResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RekeyAttemptInitializeResponse> RekeyAttemptInitialize(RekeyAttemptInitializeRequest rekeyAttemptInitializeRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'rekeyAttemptInitializeRequest' is set
            if (rekeyAttemptInitializeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rekeyAttemptInitializeRequest' when calling System->RekeyAttemptInitialize");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = rekeyAttemptInitializeRequest;


            // make the HTTP request
            var response = this.Client.Post<RekeyAttemptInitializeResponse>("/sys/rekey/init", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyAttemptInitialize", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyAttemptInitializeResponse>(response.RawContent);
        }


        /// <summary>
        /// Initializes a new rekey attempt. Only a single rekey attempt can take place at a time, and changing the parameters of a rekey requires canceling and starting a new rekey, which will also provide a new nonce.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rekeyAttemptInitializeRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyAttemptInitializeResponse)</returns>
        public async Task<VaultResponse<RekeyAttemptInitializeResponse>> RekeyAttemptInitializeAsync(RekeyAttemptInitializeRequest rekeyAttemptInitializeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'rekeyAttemptInitializeRequest' is set
            if (rekeyAttemptInitializeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rekeyAttemptInitializeRequest' when calling System->RekeyAttemptInitialize");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = rekeyAttemptInitializeRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<RekeyAttemptInitializeResponse>("/sys/rekey/init", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyAttemptInitialize", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyAttemptInitializeResponse>(response.RawContent);
        }
        /// <summary>
        /// Reads the configuration and progress of the current rekey attempt. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RekeyAttemptReadProgressResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RekeyAttemptReadProgressResponse> RekeyAttemptReadProgress(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<RekeyAttemptReadProgressResponse>("/sys/rekey/init", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyAttemptReadProgress", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyAttemptReadProgressResponse>(response.RawContent);
        }


        /// <summary>
        /// Reads the configuration and progress of the current rekey attempt. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyAttemptReadProgressResponse)</returns>
        public async Task<VaultResponse<RekeyAttemptReadProgressResponse>> RekeyAttemptReadProgressAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<RekeyAttemptReadProgressResponse>("/sys/rekey/init", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyAttemptReadProgress", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyAttemptReadProgressResponse>(response.RawContent);
        }
        /// <summary>
        /// Enter a single unseal key share to progress the rekey of the Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rekeyAttemptUpdateRequest"></param>
        /// <returns>VaultResponse of RekeyAttemptUpdateResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RekeyAttemptUpdateResponse> RekeyAttemptUpdate(RekeyAttemptUpdateRequest rekeyAttemptUpdateRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'rekeyAttemptUpdateRequest' is set
            if (rekeyAttemptUpdateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rekeyAttemptUpdateRequest' when calling System->RekeyAttemptUpdate");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = rekeyAttemptUpdateRequest;


            // make the HTTP request
            var response = this.Client.Post<RekeyAttemptUpdateResponse>("/sys/rekey/update", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyAttemptUpdate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyAttemptUpdateResponse>(response.RawContent);
        }


        /// <summary>
        /// Enter a single unseal key share to progress the rekey of the Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rekeyAttemptUpdateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyAttemptUpdateResponse)</returns>
        public async Task<VaultResponse<RekeyAttemptUpdateResponse>> RekeyAttemptUpdateAsync(RekeyAttemptUpdateRequest rekeyAttemptUpdateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'rekeyAttemptUpdateRequest' is set
            if (rekeyAttemptUpdateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rekeyAttemptUpdateRequest' when calling System->RekeyAttemptUpdate");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = rekeyAttemptUpdateRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<RekeyAttemptUpdateResponse>("/sys/rekey/update", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyAttemptUpdate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyAttemptUpdateResponse>(response.RawContent);
        }
        /// <summary>
        /// Delete the backup copy of PGP-encrypted unseal keys. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> RekeyDeleteBackupKey(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/rekey/backup", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyDeleteBackupKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete the backup copy of PGP-encrypted unseal keys. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> RekeyDeleteBackupKeyAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/rekey/backup", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyDeleteBackupKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> RekeyDeleteBackupRecoveryKey(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/rekey/recovery-key-backup", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyDeleteBackupRecoveryKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> RekeyDeleteBackupRecoveryKeyAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/rekey/recovery-key-backup", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyDeleteBackupRecoveryKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Return the backup copy of PGP-encrypted unseal keys. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RekeyReadBackupKeyResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RekeyReadBackupKeyResponse> RekeyReadBackupKey(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<RekeyReadBackupKeyResponse>("/sys/rekey/backup", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyReadBackupKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyReadBackupKeyResponse>(response.RawContent);
        }


        /// <summary>
        /// Return the backup copy of PGP-encrypted unseal keys. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyReadBackupKeyResponse)</returns>
        public async Task<VaultResponse<RekeyReadBackupKeyResponse>> RekeyReadBackupKeyAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<RekeyReadBackupKeyResponse>("/sys/rekey/backup", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyReadBackupKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyReadBackupKeyResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RekeyReadBackupRecoveryKeyResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RekeyReadBackupRecoveryKeyResponse> RekeyReadBackupRecoveryKey(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<RekeyReadBackupRecoveryKeyResponse>("/sys/rekey/recovery-key-backup", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyReadBackupRecoveryKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyReadBackupRecoveryKeyResponse>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyReadBackupRecoveryKeyResponse)</returns>
        public async Task<VaultResponse<RekeyReadBackupRecoveryKeyResponse>> RekeyReadBackupRecoveryKeyAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<RekeyReadBackupRecoveryKeyResponse>("/sys/rekey/recovery-key-backup", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyReadBackupRecoveryKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyReadBackupRecoveryKeyResponse>(response.RawContent);
        }
        /// <summary>
        /// Cancel any in-progress rekey verification operation. This clears any progress made and resets the nonce. Unlike a &#x60;DELETE&#x60; against &#x60;sys/rekey/init&#x60;, this only resets the current verification operation, not the entire rekey atttempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RekeyVerificationCancelResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RekeyVerificationCancelResponse> RekeyVerificationCancel(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Delete<RekeyVerificationCancelResponse>("/sys/rekey/verify", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyVerificationCancel", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyVerificationCancelResponse>(response.RawContent);
        }


        /// <summary>
        /// Cancel any in-progress rekey verification operation. This clears any progress made and resets the nonce. Unlike a &#x60;DELETE&#x60; against &#x60;sys/rekey/init&#x60;, this only resets the current verification operation, not the entire rekey atttempt.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyVerificationCancelResponse)</returns>
        public async Task<VaultResponse<RekeyVerificationCancelResponse>> RekeyVerificationCancelAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<RekeyVerificationCancelResponse>("/sys/rekey/verify", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyVerificationCancel", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyVerificationCancelResponse>(response.RawContent);
        }
        /// <summary>
        /// Read the configuration and progress of the current rekey verification attempt. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RekeyVerificationReadProgressResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RekeyVerificationReadProgressResponse> RekeyVerificationReadProgress(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<RekeyVerificationReadProgressResponse>("/sys/rekey/verify", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyVerificationReadProgress", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyVerificationReadProgressResponse>(response.RawContent);
        }


        /// <summary>
        /// Read the configuration and progress of the current rekey verification attempt. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyVerificationReadProgressResponse)</returns>
        public async Task<VaultResponse<RekeyVerificationReadProgressResponse>> RekeyVerificationReadProgressAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<RekeyVerificationReadProgressResponse>("/sys/rekey/verify", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyVerificationReadProgress", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyVerificationReadProgressResponse>(response.RawContent);
        }
        /// <summary>
        /// Enter a single new key share to progress the rekey verification operation. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rekeyVerificationUpdateRequest"></param>
        /// <returns>VaultResponse of RekeyVerificationUpdateResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RekeyVerificationUpdateResponse> RekeyVerificationUpdate(RekeyVerificationUpdateRequest rekeyVerificationUpdateRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'rekeyVerificationUpdateRequest' is set
            if (rekeyVerificationUpdateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rekeyVerificationUpdateRequest' when calling System->RekeyVerificationUpdate");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = rekeyVerificationUpdateRequest;


            // make the HTTP request
            var response = this.Client.Post<RekeyVerificationUpdateResponse>("/sys/rekey/verify", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyVerificationUpdate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyVerificationUpdateResponse>(response.RawContent);
        }


        /// <summary>
        /// Enter a single new key share to progress the rekey verification operation. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rekeyVerificationUpdateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RekeyVerificationUpdateResponse)</returns>
        public async Task<VaultResponse<RekeyVerificationUpdateResponse>> RekeyVerificationUpdateAsync(RekeyVerificationUpdateRequest rekeyVerificationUpdateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'rekeyVerificationUpdateRequest' is set
            if (rekeyVerificationUpdateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rekeyVerificationUpdateRequest' when calling System->RekeyVerificationUpdate");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = rekeyVerificationUpdateRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<RekeyVerificationUpdateResponse>("/sys/rekey/verify", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RekeyVerificationUpdate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RekeyVerificationUpdateResponse>(response.RawContent);
        }
        /// <summary>
        /// Reload the given subsystem 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="subsystem"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> ReloadSubsystem(string subsystem, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'subsystem' is set
            if (subsystem == null)
                throw new VaultApiException(400, "Missing required parameter 'subsystem' when calling System->ReloadSubsystem");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("subsystem", ClientUtils.ParameterToString(subsystem)); // path parameter






            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/config/reload/{subsystem}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ReloadSubsystem", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Reload the given subsystem 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="subsystem"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> ReloadSubsystemAsync(string subsystem, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'subsystem' is set
            if (subsystem == null)
                throw new VaultApiException(400, "Missing required parameter 'subsystem' when calling System->ReloadSubsystem");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("subsystem", ClientUtils.ParameterToString(subsystem)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/config/reload/{subsystem}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ReloadSubsystem", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Initiate a mount migration 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="remountRequest"></param>
        /// <returns>VaultResponse of RemountResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RemountResponse> Remount(RemountRequest remountRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'remountRequest' is set
            if (remountRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'remountRequest' when calling System->Remount");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = remountRequest;


            // make the HTTP request
            var response = this.Client.Post<RemountResponse>("/sys/remount", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Remount", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RemountResponse>(response.RawContent);
        }


        /// <summary>
        /// Initiate a mount migration 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="remountRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RemountResponse)</returns>
        public async Task<VaultResponse<RemountResponse>> RemountAsync(RemountRequest remountRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'remountRequest' is set
            if (remountRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'remountRequest' when calling System->Remount");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = remountRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<RemountResponse>("/sys/remount", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Remount", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RemountResponse>(response.RawContent);
        }
        /// <summary>
        /// Check status of a mount migration 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="migrationId">The ID of the migration operation</param>
        /// <returns>VaultResponse of RemountStatusResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RemountStatusResponse> RemountStatus(string migrationId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'migrationId' is set
            if (migrationId == null)
                throw new VaultApiException(400, "Missing required parameter 'migrationId' when calling System->RemountStatus");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("migration_id", ClientUtils.ParameterToString(migrationId)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<RemountStatusResponse>("/sys/remount/status/{migration_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RemountStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RemountStatusResponse>(response.RawContent);
        }


        /// <summary>
        /// Check status of a mount migration 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="migrationId">The ID of the migration operation</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RemountStatusResponse)</returns>
        public async Task<VaultResponse<RemountStatusResponse>> RemountStatusAsync(string migrationId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'migrationId' is set
            if (migrationId == null)
                throw new VaultApiException(400, "Missing required parameter 'migrationId' when calling System->RemountStatus");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("migration_id", ClientUtils.ParameterToString(migrationId)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<RemountStatusResponse>("/sys/remount/status/{migration_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RemountStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RemountStatusResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> ReplicationStatus(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<Object>("/sys/replication/status", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ReplicationStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> ReplicationStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/sys/replication/status", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("ReplicationStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rewrapRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> Rewrap(RewrapRequest rewrapRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'rewrapRequest' is set
            if (rewrapRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rewrapRequest' when calling System->Rewrap");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = rewrapRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/wrapping/rewrap", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Rewrap", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rewrapRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> RewrapAsync(RewrapRequest rewrapRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'rewrapRequest' is set
            if (rewrapRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rewrapRequest' when calling System->Rewrap");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = rewrapRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/wrapping/rewrap", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Rewrap", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Cancels any in-progress root generation attempt. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> RootTokenGenerationCancel(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/generate-root/attempt", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RootTokenGenerationCancel", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Cancels any in-progress root generation attempt. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> RootTokenGenerationCancelAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/generate-root/attempt", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RootTokenGenerationCancel", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Initializes a new root generation attempt. Only a single root generation attempt can take place at a time. One (and only one) of otp or pgp_key are required.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rootTokenGenerationInitializeRequest"></param>
        /// <returns>VaultResponse of RootTokenGenerationInitializeResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RootTokenGenerationInitializeResponse> RootTokenGenerationInitialize(RootTokenGenerationInitializeRequest rootTokenGenerationInitializeRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'rootTokenGenerationInitializeRequest' is set
            if (rootTokenGenerationInitializeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rootTokenGenerationInitializeRequest' when calling System->RootTokenGenerationInitialize");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = rootTokenGenerationInitializeRequest;


            // make the HTTP request
            var response = this.Client.Post<RootTokenGenerationInitializeResponse>("/sys/generate-root/attempt", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RootTokenGenerationInitialize", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RootTokenGenerationInitializeResponse>(response.RawContent);
        }


        /// <summary>
        /// Initializes a new root generation attempt. Only a single root generation attempt can take place at a time. One (and only one) of otp or pgp_key are required.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rootTokenGenerationInitializeRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RootTokenGenerationInitializeResponse)</returns>
        public async Task<VaultResponse<RootTokenGenerationInitializeResponse>> RootTokenGenerationInitializeAsync(RootTokenGenerationInitializeRequest rootTokenGenerationInitializeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'rootTokenGenerationInitializeRequest' is set
            if (rootTokenGenerationInitializeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rootTokenGenerationInitializeRequest' when calling System->RootTokenGenerationInitialize");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = rootTokenGenerationInitializeRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<RootTokenGenerationInitializeResponse>("/sys/generate-root/attempt", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RootTokenGenerationInitialize", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RootTokenGenerationInitializeResponse>(response.RawContent);
        }
        /// <summary>
        /// Read the configuration and progress of the current root generation attempt. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of RootTokenGenerationReadProgressResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RootTokenGenerationReadProgressResponse> RootTokenGenerationReadProgress(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<RootTokenGenerationReadProgressResponse>("/sys/generate-root/attempt", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RootTokenGenerationReadProgress", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RootTokenGenerationReadProgressResponse>(response.RawContent);
        }


        /// <summary>
        /// Read the configuration and progress of the current root generation attempt. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RootTokenGenerationReadProgressResponse)</returns>
        public async Task<VaultResponse<RootTokenGenerationReadProgressResponse>> RootTokenGenerationReadProgressAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<RootTokenGenerationReadProgressResponse>("/sys/generate-root/attempt", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RootTokenGenerationReadProgress", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RootTokenGenerationReadProgressResponse>(response.RawContent);
        }
        /// <summary>
        /// Enter a single unseal key share to progress the root generation attempt. If the threshold number of unseal key shares is reached, Vault will complete the root generation and issue the new token. Otherwise, this API must be called multiple times until that threshold is met. The attempt nonce must be provided with each call.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rootTokenGenerationUpdateRequest"></param>
        /// <returns>VaultResponse of RootTokenGenerationUpdateResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<RootTokenGenerationUpdateResponse> RootTokenGenerationUpdate(RootTokenGenerationUpdateRequest rootTokenGenerationUpdateRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'rootTokenGenerationUpdateRequest' is set
            if (rootTokenGenerationUpdateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rootTokenGenerationUpdateRequest' when calling System->RootTokenGenerationUpdate");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = rootTokenGenerationUpdateRequest;


            // make the HTTP request
            var response = this.Client.Post<RootTokenGenerationUpdateResponse>("/sys/generate-root/update", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RootTokenGenerationUpdate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RootTokenGenerationUpdateResponse>(response.RawContent);
        }


        /// <summary>
        /// Enter a single unseal key share to progress the root generation attempt. If the threshold number of unseal key shares is reached, Vault will complete the root generation and issue the new token. Otherwise, this API must be called multiple times until that threshold is met. The attempt nonce must be provided with each call.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="rootTokenGenerationUpdateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (RootTokenGenerationUpdateResponse)</returns>
        public async Task<VaultResponse<RootTokenGenerationUpdateResponse>> RootTokenGenerationUpdateAsync(RootTokenGenerationUpdateRequest rootTokenGenerationUpdateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'rootTokenGenerationUpdateRequest' is set
            if (rootTokenGenerationUpdateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'rootTokenGenerationUpdateRequest' when calling System->RootTokenGenerationUpdate");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = rootTokenGenerationUpdateRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<RootTokenGenerationUpdateResponse>("/sys/generate-root/update", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("RootTokenGenerationUpdate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<RootTokenGenerationUpdateResponse>(response.RawContent);
        }
        /// <summary>
        /// Seal the Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> Seal(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/seal", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Seal", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Seal the Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> SealAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/seal", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Seal", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Check the seal status of a Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of SealStatusResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<SealStatusResponse> SealStatus(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Get<SealStatusResponse>("/sys/seal-status", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("SealStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<SealStatusResponse>(response.RawContent);
        }


        /// <summary>
        /// Check the seal status of a Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (SealStatusResponse)</returns>
        public async Task<VaultResponse<SealStatusResponse>> SealStatusAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<SealStatusResponse>("/sys/seal-status", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("SealStatus", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<SealStatusResponse>(response.RawContent);
        }
        /// <summary>
        /// Cause the node to give up active status. This endpoint forces the node to give up active status. If the node does not have active status, this endpoint does nothing. Note that the node will sleep for ten seconds before attempting to grab the active lock again, but if no standby nodes grab the active lock in the interim, the same node may become the active node again.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> StepDownLeader(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/step-down", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("StepDownLeader", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Cause the node to give up active status. This endpoint forces the node to give up active status. If the node does not have active status, this endpoint does nothing. Note that the node will sleep for ten seconds before attempting to grab the active lock again, but if no standby nodes grab the active lock in the interim, the same node may become the active node again.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> StepDownLeaderAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/step-down", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("StepDownLeader", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Configure the values to be returned for the UI header. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="uiHeadersConfigureRequest"></param>
        /// <param name="header">The name of the header.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> UiHeadersConfigure(string header, UiHeadersConfigureRequest uiHeadersConfigureRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'header' is set
            if (header == null)
                throw new VaultApiException(400, "Missing required parameter 'header' when calling System->UiHeadersConfigure");


            // verify the required parameter 'uiHeadersConfigureRequest' is set
            if (uiHeadersConfigureRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'uiHeadersConfigureRequest' when calling System->UiHeadersConfigure");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("header", ClientUtils.ParameterToString(header)); // path parameter





            requestOptions.Data = uiHeadersConfigureRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/config/ui/headers/{header}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("UiHeadersConfigure", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Configure the values to be returned for the UI header. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="uiHeadersConfigureRequest"></param>
        /// <param name="header">The name of the header.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> UiHeadersConfigureAsync(string header, UiHeadersConfigureRequest uiHeadersConfigureRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'header' is set
            if (header == null)
                throw new VaultApiException(400, "Missing required parameter 'header' when calling System->UiHeadersConfigure");


            // verify the required parameter 'uiHeadersConfigureRequest' is set
            if (uiHeadersConfigureRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'uiHeadersConfigureRequest' when calling System->UiHeadersConfigure");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("header", ClientUtils.ParameterToString(header)); // path parameter



            requestOptions.Data = uiHeadersConfigureRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/config/ui/headers/{header}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("UiHeadersConfigure", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Remove a UI header. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header">The name of the header.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> UiHeadersDeleteConfiguration(string header, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'header' is set
            if (header == null)
                throw new VaultApiException(400, "Missing required parameter 'header' when calling System->UiHeadersDeleteConfiguration");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("header", ClientUtils.ParameterToString(header)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/sys/config/ui/headers/{header}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("UiHeadersDeleteConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Remove a UI header. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header">The name of the header.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> UiHeadersDeleteConfigurationAsync(string header, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'header' is set
            if (header == null)
                throw new VaultApiException(400, "Missing required parameter 'header' when calling System->UiHeadersDeleteConfiguration");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("header", ClientUtils.ParameterToString(header)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/sys/config/ui/headers/{header}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("UiHeadersDeleteConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Return a list of configured UI headers. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of UiHeadersListResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<UiHeadersListResponse> UiHeadersList(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<UiHeadersListResponse>("/sys/config/ui/headers/", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("UiHeadersList", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<UiHeadersListResponse>(response.RawContent);
        }


        /// <summary>
        /// Return a list of configured UI headers. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (UiHeadersListResponse)</returns>
        public async Task<VaultResponse<UiHeadersListResponse>> UiHeadersListAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<UiHeadersListResponse>("/sys/config/ui/headers/", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("UiHeadersList", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<UiHeadersListResponse>(response.RawContent);
        }
        /// <summary>
        /// Return the given UI header&#x27;s configuration 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header">The name of the header.</param>
        /// <returns>VaultResponse of UiHeadersReadConfigurationResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<UiHeadersReadConfigurationResponse> UiHeadersReadConfiguration(string header, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'header' is set
            if (header == null)
                throw new VaultApiException(400, "Missing required parameter 'header' when calling System->UiHeadersReadConfiguration");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("header", ClientUtils.ParameterToString(header)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<UiHeadersReadConfigurationResponse>("/sys/config/ui/headers/{header}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("UiHeadersReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<UiHeadersReadConfigurationResponse>(response.RawContent);
        }


        /// <summary>
        /// Return the given UI header&#x27;s configuration 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="header">The name of the header.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (UiHeadersReadConfigurationResponse)</returns>
        public async Task<VaultResponse<UiHeadersReadConfigurationResponse>> UiHeadersReadConfigurationAsync(string header, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'header' is set
            if (header == null)
                throw new VaultApiException(400, "Missing required parameter 'header' when calling System->UiHeadersReadConfiguration");



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("header", ClientUtils.ParameterToString(header)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<UiHeadersReadConfigurationResponse>("/sys/config/ui/headers/{header}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("UiHeadersReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<UiHeadersReadConfigurationResponse>(response.RawContent);
        }
        /// <summary>
        /// Unseal the Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="unsealRequest"></param>
        /// <returns>VaultResponse of UnsealResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<UnsealResponse> Unseal(UnsealRequest unsealRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'unsealRequest' is set
            if (unsealRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'unsealRequest' when calling System->Unseal");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = unsealRequest;


            // make the HTTP request
            var response = this.Client.Post<UnsealResponse>("/sys/unseal", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Unseal", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<UnsealResponse>(response.RawContent);
        }


        /// <summary>
        /// Unseal the Vault. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="unsealRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (UnsealResponse)</returns>
        public async Task<VaultResponse<UnsealResponse>> UnsealAsync(UnsealRequest unsealRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'unsealRequest' is set
            if (unsealRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'unsealRequest' when calling System->Unseal");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = unsealRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<UnsealResponse>("/sys/unseal", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Unseal", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<UnsealResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="unwrapRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> Unwrap(UnwrapRequest unwrapRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'unwrapRequest' is set
            if (unwrapRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'unwrapRequest' when calling System->Unwrap");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);





            requestOptions.Data = unwrapRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/wrapping/unwrap", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Unwrap", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="unwrapRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> UnwrapAsync(UnwrapRequest unwrapRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'unwrapRequest' is set
            if (unwrapRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'unwrapRequest' when calling System->Unwrap");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                "",
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.Data = unwrapRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/wrapping/unwrap", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Unwrap", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Returns map of historical version change entries 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of VersionHistoryResponse</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<VersionHistoryResponse> VersionHistory(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<VersionHistoryResponse>("/sys/version-history/", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("VersionHistory", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<VersionHistoryResponse>(response.RawContent);
        }


        /// <summary>
        /// Returns map of historical version change entries 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse (VersionHistoryResponse)</returns>
        public async Task<VaultResponse<VersionHistoryResponse>> VersionHistoryAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<VersionHistoryResponse>("/sys/version-history/", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("VersionHistory", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<VersionHistoryResponse>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> Wrap(TimeSpan? wrapTTL = null)
        {


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);






            // make the HTTP request
            var response = this.Client.Post<Object>("/sys/wrapping/wrap", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Wrap", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> WrapAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {



            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {

            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);



            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/sys/wrapping/wrap", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("Wrap", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
    }
}
