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
    public interface IIdentitySync : IApiAccessor
    {
        #region Synchronous Operations

        /// <summary>
        /// Create a new alias.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasCreateRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AliasCreate(AliasCreateRequest aliasCreateRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AliasDeleteById(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// List all the alias IDs.
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
        VaultResponse<Object> AliasListById(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AliasReadById(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasUpdateByIdRequest"></param>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AliasUpdateById(string id, AliasUpdateByIdRequest aliasUpdateByIdRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete all of the entities provided
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityBatchDeleteRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityBatchDelete(EntityBatchDeleteRequest entityBatchDeleteRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Create a new entity
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityCreateRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityCreate(EntityCreateRequest entityCreateRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Create a new alias.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityCreateAliasRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityCreateAlias(EntityCreateAliasRequest entityCreateAliasRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityDeleteAliasById(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityDeleteById(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the entity</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityDeleteByName(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// List all the alias IDs.
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
        VaultResponse<Object> EntityListAliasesById(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List all the entity IDs
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
        VaultResponse<Object> EntityListById(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List all the entity names
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
        VaultResponse<Object> EntityListByName(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Query entities based on various properties.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityLookUpRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityLookUp(EntityLookUpRequest entityLookUpRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Merge two or more entities together
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityMergeRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityMerge(EntityMergeRequest entityMergeRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityReadAliasById(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityReadById(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the entity</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityReadByName(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityUpdateAliasByIdRequest"></param>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityUpdateAliasById(string id, EntityUpdateAliasByIdRequest entityUpdateAliasByIdRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityUpdateByIdRequest"></param>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityUpdateById(string id, EntityUpdateByIdRequest entityUpdateByIdRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityUpdateByNameRequest"></param>
        /// <param name="name">Name of the entity</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityUpdateByName(string name, EntityUpdateByNameRequest entityUpdateByNameRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupCreateRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupCreate(GroupCreateRequest groupCreateRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Creates a new group alias, or updates an existing one.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupCreateAliasRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupCreateAlias(GroupCreateAliasRequest groupCreateAliasRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group alias.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupDeleteAliasById(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupDeleteById(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupDeleteByName(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// List all the group alias IDs.
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
        VaultResponse<Object> GroupListAliasesById(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List all the group IDs.
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
        VaultResponse<Object> GroupListById(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> GroupListByName(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Query groups based on various properties.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupLookUpRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupLookUp(GroupLookUpRequest groupLookUpRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group alias.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupReadAliasById(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupReadById(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupReadByName(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupUpdateAliasByIdRequest"></param>
        /// <param name="id">ID of the group alias.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupUpdateAliasById(string id, GroupUpdateAliasByIdRequest groupUpdateAliasByIdRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupUpdateByIdRequest"></param>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupUpdateById(string id, GroupUpdateByIdRequest groupUpdateByIdRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupUpdateByNameRequest"></param>
        /// <param name="name">Name of the group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupUpdateByName(string name, GroupUpdateByNameRequest groupUpdateByNameRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Destroys a TOTP secret for the given MFA method ID on the given entity
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaAdminDestroyTotpSecretRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaAdminDestroyTotpSecret(MfaAdminDestroyTotpSecretRequest mfaAdminDestroyTotpSecretRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaAdminGenerateTotpSecretRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaAdminGenerateTotpSecret(MfaAdminGenerateTotpSecretRequest mfaAdminGenerateTotpSecretRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Create the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreateDuoMethodRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaCreateDuoMethod(MfaCreateDuoMethodRequest mfaCreateDuoMethodRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Create the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreateOktaMethodRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaCreateOktaMethod(MfaCreateOktaMethodRequest mfaCreateOktaMethodRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Create the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreatePingIdMethodRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaCreatePingIdMethod(MfaCreatePingIdMethodRequest mfaCreatePingIdMethodRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Create the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreateTotpMethodRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaCreateTotpMethod(MfaCreateTotpMethodRequest mfaCreateTotpMethodRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaDeleteDuoMethod(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete a login enforcement
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaDeleteLoginEnforcement(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaDeleteOktaMethod(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaDeletePingIdMethod(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaDeleteTotpMethod(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaGenerateTotpSecretRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaGenerateTotpSecret(MfaGenerateTotpSecretRequest mfaGenerateTotpSecretRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// List MFA method configurations for the given MFA method
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
        VaultResponse<Object> MfaListDuoMethods(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List login enforcements
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
        VaultResponse<Object> MfaListLoginEnforcements(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List MFA method configurations for all MFA methods
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
        VaultResponse<Object> MfaListMethods(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List MFA method configurations for the given MFA method
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
        VaultResponse<Object> MfaListOktaMethods(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List MFA method configurations for the given MFA method
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
        VaultResponse<Object> MfaListPingIdMethods(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List MFA method configurations for the given MFA method
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
        VaultResponse<Object> MfaListTotpMethods(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the current configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaReadDuoMethod(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the current login enforcement
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaReadLoginEnforcement(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the current configuration for the given ID regardless of the MFA method type
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaReadMethod(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the current configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaReadOktaMethod(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the current configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaReadPingIdMethod(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Read the current configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaReadTotpMethod(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update the configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdateDuoMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaUpdateDuoMethod(string methodId, MfaUpdateDuoMethodRequest mfaUpdateDuoMethodRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update the configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdateOktaMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaUpdateOktaMethod(string methodId, MfaUpdateOktaMethodRequest mfaUpdateOktaMethodRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update the configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdatePingIdMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaUpdatePingIdMethod(string methodId, MfaUpdatePingIdMethodRequest mfaUpdatePingIdMethodRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update the configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdateTotpMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaUpdateTotpMethod(string methodId, MfaUpdateTotpMethodRequest mfaUpdateTotpMethodRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Create or update a login enforcement
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaWriteLoginEnforcementRequest"></param>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MfaWriteLoginEnforcement(string name, MfaWriteLoginEnforcementRequest mfaWriteLoginEnforcementRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcConfigureRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcConfigure(OidcConfigureRequest oidcConfigureRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the assignment</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcDeleteAssignment(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the client.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcDeleteClient(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// CRUD operations for OIDC keys.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the key</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcDeleteKey(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcDeleteProvider(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// CRUD operations on OIDC Roles
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the role</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcDeleteRole(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the scope</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcDeleteScope(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Generate an OIDC token
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the role</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcGenerateToken(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Verify the authenticity of an OIDC token
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcIntrospectRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcIntrospect(OidcIntrospectRequest oidcIntrospectRequest, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OidcListAssignments(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OidcListClients(TimeSpan? wrapTTL = null);

        /// <summary>
        /// List OIDC keys
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
        VaultResponse<Object> OidcListKeys(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="allowedClientId">Filters the list of OIDC providers to those that allow the given client ID in their set of allowed_client_ids. (optional, default to &quot;&quot;)</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcListProviders(string allowedClientId = default(string), TimeSpan? wrapTTL = null);

        /// <summary>
        /// List configured OIDC roles
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
        VaultResponse<Object> OidcListRoles(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OidcListScopes(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcProviderAuthorize(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcProviderAuthorizeWithParametersRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcProviderAuthorizeWithParameters(string name, OidcProviderAuthorizeWithParametersRequest oidcProviderAuthorizeWithParametersRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcProviderTokenRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcProviderToken(string name, OidcProviderTokenRequest oidcProviderTokenRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcProviderUserInfo(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the assignment</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcReadAssignment(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the client.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcReadClient(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OidcReadConfiguration(TimeSpan? wrapTTL = null);

        /// <summary>
        /// CRUD operations for OIDC keys.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the key</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcReadKey(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Query OIDC configurations
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
        VaultResponse<Object> OidcReadOpenIdConfiguration(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcReadProvider(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcReadProviderOpenIdConfiguration(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcReadProviderPublicKeys(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Retrieve public keys
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
        VaultResponse<Object> OidcReadPublicKeys(TimeSpan? wrapTTL = null);

        /// <summary>
        /// CRUD operations on OIDC Roles
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the role</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcReadRole(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the scope</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcReadScope(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Rotate a named OIDC key.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcRotateKeyRequest"></param>
        /// <param name="name">Name of the key</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcRotateKey(string name, OidcRotateKeyRequest oidcRotateKeyRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteAssignmentRequest"></param>
        /// <param name="name">Name of the assignment</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcWriteAssignment(string name, OidcWriteAssignmentRequest oidcWriteAssignmentRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteClientRequest"></param>
        /// <param name="name">Name of the client.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcWriteClient(string name, OidcWriteClientRequest oidcWriteClientRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// CRUD operations for OIDC keys.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteKeyRequest"></param>
        /// <param name="name">Name of the key</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcWriteKey(string name, OidcWriteKeyRequest oidcWriteKeyRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteProviderRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcWriteProvider(string name, OidcWriteProviderRequest oidcWriteProviderRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// CRUD operations on OIDC Roles
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteRoleRequest"></param>
        /// <param name="name">Name of the role</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcWriteRole(string name, OidcWriteRoleRequest oidcWriteRoleRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteScopeRequest"></param>
        /// <param name="name">Name of the scope</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OidcWriteScope(string name, OidcWriteScopeRequest oidcWriteScopeRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Create a new alias.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaCreateRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PersonaCreate(PersonaCreateRequest personaCreateRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the persona</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PersonaDeleteById(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// List all the alias IDs.
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
        VaultResponse<Object> PersonaListById(TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the persona</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PersonaReadById(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaUpdateByIdRequest"></param>
        /// <param name="id">ID of the persona</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PersonaUpdateById(string id, PersonaUpdateByIdRequest personaUpdateByIdRequest, TimeSpan? wrapTTL = null);

        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIdentityAsync : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        /// Create a new alias.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasCreateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AliasCreateAsync(AliasCreateRequest aliasCreateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AliasDeleteByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all the alias IDs.
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
        Task<VaultResponse<Object>> AliasListByIdAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AliasReadByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasUpdateByIdRequest"></param>
        /// <param name="id">ID of the alias</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AliasUpdateByIdAsync(string id, AliasUpdateByIdRequest aliasUpdateByIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete all of the entities provided
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityBatchDeleteRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityBatchDeleteAsync(EntityBatchDeleteRequest entityBatchDeleteRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a new entity
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityCreateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityCreateAsync(EntityCreateRequest entityCreateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a new alias.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityCreateAliasRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityCreateAliasAsync(EntityCreateAliasRequest entityCreateAliasRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityDeleteAliasByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityDeleteByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the entity</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityDeleteByNameAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all the alias IDs.
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
        Task<VaultResponse<Object>> EntityListAliasesByIdAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all the entity IDs
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
        Task<VaultResponse<Object>> EntityListByIdAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all the entity names
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
        Task<VaultResponse<Object>> EntityListByNameAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query entities based on various properties.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityLookUpRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityLookUpAsync(EntityLookUpRequest entityLookUpRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Merge two or more entities together
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityMergeRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityMergeAsync(EntityMergeRequest entityMergeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityReadAliasByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityReadByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the entity</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityReadByNameAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityUpdateAliasByIdRequest"></param>
        /// <param name="id">ID of the alias</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityUpdateAliasByIdAsync(string id, EntityUpdateAliasByIdRequest entityUpdateAliasByIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityUpdateByIdRequest"></param>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityUpdateByIdAsync(string id, EntityUpdateByIdRequest entityUpdateByIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityUpdateByNameRequest"></param>
        /// <param name="name">Name of the entity</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityUpdateByNameAsync(string name, EntityUpdateByNameRequest entityUpdateByNameRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupCreateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupCreateAsync(GroupCreateRequest groupCreateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates a new group alias, or updates an existing one.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupCreateAliasRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupCreateAliasAsync(GroupCreateAliasRequest groupCreateAliasRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group alias.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupDeleteAliasByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupDeleteByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the group.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupDeleteByNameAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all the group alias IDs.
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
        Task<VaultResponse<Object>> GroupListAliasesByIdAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all the group IDs.
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
        Task<VaultResponse<Object>> GroupListByIdAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> GroupListByNameAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query groups based on various properties.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupLookUpRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupLookUpAsync(GroupLookUpRequest groupLookUpRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group alias.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupReadAliasByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupReadByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the group.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupReadByNameAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupUpdateAliasByIdRequest"></param>
        /// <param name="id">ID of the group alias.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupUpdateAliasByIdAsync(string id, GroupUpdateAliasByIdRequest groupUpdateAliasByIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupUpdateByIdRequest"></param>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupUpdateByIdAsync(string id, GroupUpdateByIdRequest groupUpdateByIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupUpdateByNameRequest"></param>
        /// <param name="name">Name of the group.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupUpdateByNameAsync(string name, GroupUpdateByNameRequest groupUpdateByNameRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Destroys a TOTP secret for the given MFA method ID on the given entity
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaAdminDestroyTotpSecretRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaAdminDestroyTotpSecretAsync(MfaAdminDestroyTotpSecretRequest mfaAdminDestroyTotpSecretRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaAdminGenerateTotpSecretRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaAdminGenerateTotpSecretAsync(MfaAdminGenerateTotpSecretRequest mfaAdminGenerateTotpSecretRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreateDuoMethodRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaCreateDuoMethodAsync(MfaCreateDuoMethodRequest mfaCreateDuoMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreateOktaMethodRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaCreateOktaMethodAsync(MfaCreateOktaMethodRequest mfaCreateOktaMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreatePingIdMethodRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaCreatePingIdMethodAsync(MfaCreatePingIdMethodRequest mfaCreatePingIdMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreateTotpMethodRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaCreateTotpMethodAsync(MfaCreateTotpMethodRequest mfaCreateTotpMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaDeleteDuoMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete a login enforcement
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaDeleteLoginEnforcementAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaDeleteOktaMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaDeletePingIdMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaDeleteTotpMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaGenerateTotpSecretRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaGenerateTotpSecretAsync(MfaGenerateTotpSecretRequest mfaGenerateTotpSecretRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List MFA method configurations for the given MFA method
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
        Task<VaultResponse<Object>> MfaListDuoMethodsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List login enforcements
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
        Task<VaultResponse<Object>> MfaListLoginEnforcementsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List MFA method configurations for all MFA methods
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
        Task<VaultResponse<Object>> MfaListMethodsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List MFA method configurations for the given MFA method
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
        Task<VaultResponse<Object>> MfaListOktaMethodsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List MFA method configurations for the given MFA method
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
        Task<VaultResponse<Object>> MfaListPingIdMethodsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List MFA method configurations for the given MFA method
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
        Task<VaultResponse<Object>> MfaListTotpMethodsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the current configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaReadDuoMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the current login enforcement
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaReadLoginEnforcementAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the current configuration for the given ID regardless of the MFA method type
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaReadMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the current configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaReadOktaMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the current configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaReadPingIdMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Read the current configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaReadTotpMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update the configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdateDuoMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaUpdateDuoMethodAsync(string methodId, MfaUpdateDuoMethodRequest mfaUpdateDuoMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update the configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdateOktaMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaUpdateOktaMethodAsync(string methodId, MfaUpdateOktaMethodRequest mfaUpdateOktaMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update the configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdatePingIdMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaUpdatePingIdMethodAsync(string methodId, MfaUpdatePingIdMethodRequest mfaUpdatePingIdMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update the configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdateTotpMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaUpdateTotpMethodAsync(string methodId, MfaUpdateTotpMethodRequest mfaUpdateTotpMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create or update a login enforcement
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaWriteLoginEnforcementRequest"></param>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MfaWriteLoginEnforcementAsync(string name, MfaWriteLoginEnforcementRequest mfaWriteLoginEnforcementRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcConfigureRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcConfigureAsync(OidcConfigureRequest oidcConfigureRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the assignment</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcDeleteAssignmentAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the client.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcDeleteClientAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// CRUD operations for OIDC keys.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the key</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcDeleteKeyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcDeleteProviderAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// CRUD operations on OIDC Roles
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the role</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcDeleteRoleAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the scope</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcDeleteScopeAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Generate an OIDC token
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the role</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcGenerateTokenAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Verify the authenticity of an OIDC token
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcIntrospectRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcIntrospectAsync(OidcIntrospectRequest oidcIntrospectRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OidcListAssignmentsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OidcListClientsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List OIDC keys
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
        Task<VaultResponse<Object>> OidcListKeysAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="allowedClientId">Filters the list of OIDC providers to those that allow the given client ID in their set of allowed_client_ids. (optional, default to &quot;&quot;)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcListProvidersAsync(string allowedClientId = default(string), TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List configured OIDC roles
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
        Task<VaultResponse<Object>> OidcListRolesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OidcListScopesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcProviderAuthorizeAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcProviderAuthorizeWithParametersRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcProviderAuthorizeWithParametersAsync(string name, OidcProviderAuthorizeWithParametersRequest oidcProviderAuthorizeWithParametersRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcProviderTokenRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcProviderTokenAsync(string name, OidcProviderTokenRequest oidcProviderTokenRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcProviderUserInfoAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the assignment</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcReadAssignmentAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the client.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcReadClientAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OidcReadConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// CRUD operations for OIDC keys.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the key</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcReadKeyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Query OIDC configurations
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
        Task<VaultResponse<Object>> OidcReadOpenIdConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcReadProviderAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcReadProviderOpenIdConfigurationAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcReadProviderPublicKeysAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Retrieve public keys
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
        Task<VaultResponse<Object>> OidcReadPublicKeysAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// CRUD operations on OIDC Roles
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the role</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcReadRoleAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the scope</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcReadScopeAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Rotate a named OIDC key.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcRotateKeyRequest"></param>
        /// <param name="name">Name of the key</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcRotateKeyAsync(string name, OidcRotateKeyRequest oidcRotateKeyRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteAssignmentRequest"></param>
        /// <param name="name">Name of the assignment</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcWriteAssignmentAsync(string name, OidcWriteAssignmentRequest oidcWriteAssignmentRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteClientRequest"></param>
        /// <param name="name">Name of the client.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcWriteClientAsync(string name, OidcWriteClientRequest oidcWriteClientRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// CRUD operations for OIDC keys.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteKeyRequest"></param>
        /// <param name="name">Name of the key</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcWriteKeyAsync(string name, OidcWriteKeyRequest oidcWriteKeyRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteProviderRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcWriteProviderAsync(string name, OidcWriteProviderRequest oidcWriteProviderRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// CRUD operations on OIDC Roles
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteRoleRequest"></param>
        /// <param name="name">Name of the role</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcWriteRoleAsync(string name, OidcWriteRoleRequest oidcWriteRoleRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteScopeRequest"></param>
        /// <param name="name">Name of the scope</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OidcWriteScopeAsync(string name, OidcWriteScopeRequest oidcWriteScopeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a new alias.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaCreateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PersonaCreateAsync(PersonaCreateRequest personaCreateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the persona</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PersonaDeleteByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// List all the alias IDs.
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
        Task<VaultResponse<Object>> PersonaListByIdAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the persona</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PersonaReadByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaUpdateByIdRequest"></param>
        /// <param name="id">ID of the persona</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PersonaUpdateByIdAsync(string id, PersonaUpdateByIdRequest personaUpdateByIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        #endregion Asynchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIdentity : IIdentitySync, IIdentityAsync { }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class Identity : IIdentity
    {
        private Vault.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Constructor for Identity
        /// </summary>
        public Identity(ApiClient apiClient)
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
        /// Create a new alias. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasCreateRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AliasCreate(AliasCreateRequest aliasCreateRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'aliasCreateRequest' is set
            if (aliasCreateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'aliasCreateRequest' when calling Identity->AliasCreate");

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





            requestOptions.Data = aliasCreateRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/alias", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasCreate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create a new alias. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasCreateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AliasCreateAsync(AliasCreateRequest aliasCreateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'aliasCreateRequest' is set
            if (aliasCreateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'aliasCreateRequest' when calling Identity->AliasCreate");


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



            requestOptions.Data = aliasCreateRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/alias", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasCreate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AliasDeleteById(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->AliasDeleteById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/identity/alias/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasDeleteById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AliasDeleteByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->AliasDeleteById");



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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/alias/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasDeleteById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List all the alias IDs. 
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
        public VaultResponse<Object> AliasListById(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/alias/id", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasListById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List all the alias IDs. 
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
        public async Task<VaultResponse<Object>> AliasListByIdAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/alias/id", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasListById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AliasReadById(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->AliasReadById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/alias/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasReadById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AliasReadByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->AliasReadById");



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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/alias/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasReadById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasUpdateByIdRequest"></param>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AliasUpdateById(string id, AliasUpdateByIdRequest aliasUpdateByIdRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->AliasUpdateById");


            // verify the required parameter 'aliasUpdateByIdRequest' is set
            if (aliasUpdateByIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'aliasUpdateByIdRequest' when calling Identity->AliasUpdateById");

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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter





            requestOptions.Data = aliasUpdateByIdRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/alias/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasUpdateById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasUpdateByIdRequest"></param>
        /// <param name="id">ID of the alias</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AliasUpdateByIdAsync(string id, AliasUpdateByIdRequest aliasUpdateByIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->AliasUpdateById");


            // verify the required parameter 'aliasUpdateByIdRequest' is set
            if (aliasUpdateByIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'aliasUpdateByIdRequest' when calling Identity->AliasUpdateById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            requestOptions.Data = aliasUpdateByIdRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/alias/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasUpdateById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Delete all of the entities provided 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityBatchDeleteRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityBatchDelete(EntityBatchDeleteRequest entityBatchDeleteRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'entityBatchDeleteRequest' is set
            if (entityBatchDeleteRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityBatchDeleteRequest' when calling Identity->EntityBatchDelete");

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





            requestOptions.Data = entityBatchDeleteRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/entity/batch-delete", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityBatchDelete", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete all of the entities provided 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityBatchDeleteRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityBatchDeleteAsync(EntityBatchDeleteRequest entityBatchDeleteRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'entityBatchDeleteRequest' is set
            if (entityBatchDeleteRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityBatchDeleteRequest' when calling Identity->EntityBatchDelete");


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



            requestOptions.Data = entityBatchDeleteRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/entity/batch-delete", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityBatchDelete", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Create a new entity 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityCreateRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityCreate(EntityCreateRequest entityCreateRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'entityCreateRequest' is set
            if (entityCreateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityCreateRequest' when calling Identity->EntityCreate");

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





            requestOptions.Data = entityCreateRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/entity", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityCreate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create a new entity 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityCreateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityCreateAsync(EntityCreateRequest entityCreateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'entityCreateRequest' is set
            if (entityCreateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityCreateRequest' when calling Identity->EntityCreate");


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



            requestOptions.Data = entityCreateRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/entity", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityCreate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Create a new alias. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityCreateAliasRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityCreateAlias(EntityCreateAliasRequest entityCreateAliasRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'entityCreateAliasRequest' is set
            if (entityCreateAliasRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityCreateAliasRequest' when calling Identity->EntityCreateAlias");

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





            requestOptions.Data = entityCreateAliasRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/entity-alias", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityCreateAlias", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create a new alias. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityCreateAliasRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityCreateAliasAsync(EntityCreateAliasRequest entityCreateAliasRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'entityCreateAliasRequest' is set
            if (entityCreateAliasRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityCreateAliasRequest' when calling Identity->EntityCreateAlias");


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



            requestOptions.Data = entityCreateAliasRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/entity-alias", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityCreateAlias", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityDeleteAliasById(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityDeleteAliasById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/identity/entity-alias/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityDeleteAliasById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityDeleteAliasByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityDeleteAliasById");



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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/entity-alias/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityDeleteAliasById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityDeleteById(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityDeleteById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/identity/entity/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityDeleteById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityDeleteByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityDeleteById");



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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/entity/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityDeleteById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the entity</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityDeleteByName(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->EntityDeleteByName");


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
            var response = this.Client.Delete<Object>("/identity/entity/name/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityDeleteByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the entity</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityDeleteByNameAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->EntityDeleteByName");



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
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/entity/name/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityDeleteByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List all the alias IDs. 
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
        public VaultResponse<Object> EntityListAliasesById(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/entity-alias/id", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityListAliasesById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List all the alias IDs. 
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
        public async Task<VaultResponse<Object>> EntityListAliasesByIdAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/entity-alias/id", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityListAliasesById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List all the entity IDs 
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
        public VaultResponse<Object> EntityListById(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/entity/id", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityListById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List all the entity IDs 
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
        public async Task<VaultResponse<Object>> EntityListByIdAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/entity/id", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityListById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List all the entity names 
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
        public VaultResponse<Object> EntityListByName(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/entity/name", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityListByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List all the entity names 
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
        public async Task<VaultResponse<Object>> EntityListByNameAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/entity/name", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityListByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Query entities based on various properties. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityLookUpRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityLookUp(EntityLookUpRequest entityLookUpRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'entityLookUpRequest' is set
            if (entityLookUpRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityLookUpRequest' when calling Identity->EntityLookUp");

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





            requestOptions.Data = entityLookUpRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/lookup/entity", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityLookUp", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Query entities based on various properties. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityLookUpRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityLookUpAsync(EntityLookUpRequest entityLookUpRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'entityLookUpRequest' is set
            if (entityLookUpRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityLookUpRequest' when calling Identity->EntityLookUp");


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



            requestOptions.Data = entityLookUpRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/lookup/entity", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityLookUp", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Merge two or more entities together 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityMergeRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityMerge(EntityMergeRequest entityMergeRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'entityMergeRequest' is set
            if (entityMergeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityMergeRequest' when calling Identity->EntityMerge");

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





            requestOptions.Data = entityMergeRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/entity/merge", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityMerge", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Merge two or more entities together 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityMergeRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityMergeAsync(EntityMergeRequest entityMergeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'entityMergeRequest' is set
            if (entityMergeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityMergeRequest' when calling Identity->EntityMerge");


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



            requestOptions.Data = entityMergeRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/entity/merge", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityMerge", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityReadAliasById(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityReadAliasById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/entity-alias/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityReadAliasById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the alias</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityReadAliasByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityReadAliasById");



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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/entity-alias/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityReadAliasById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityReadById(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityReadById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/entity/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityReadById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityReadByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityReadById");



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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/entity/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityReadById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the entity</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityReadByName(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->EntityReadByName");


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
            var response = this.Client.Get<Object>("/identity/entity/name/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityReadByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the entity</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityReadByNameAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->EntityReadByName");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/entity/name/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityReadByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityUpdateAliasByIdRequest"></param>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityUpdateAliasById(string id, EntityUpdateAliasByIdRequest entityUpdateAliasByIdRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityUpdateAliasById");


            // verify the required parameter 'entityUpdateAliasByIdRequest' is set
            if (entityUpdateAliasByIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityUpdateAliasByIdRequest' when calling Identity->EntityUpdateAliasById");

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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter





            requestOptions.Data = entityUpdateAliasByIdRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/entity-alias/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityUpdateAliasById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityUpdateAliasByIdRequest"></param>
        /// <param name="id">ID of the alias</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityUpdateAliasByIdAsync(string id, EntityUpdateAliasByIdRequest entityUpdateAliasByIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityUpdateAliasById");


            // verify the required parameter 'entityUpdateAliasByIdRequest' is set
            if (entityUpdateAliasByIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityUpdateAliasByIdRequest' when calling Identity->EntityUpdateAliasById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            requestOptions.Data = entityUpdateAliasByIdRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/entity-alias/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityUpdateAliasById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityUpdateByIdRequest"></param>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityUpdateById(string id, EntityUpdateByIdRequest entityUpdateByIdRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityUpdateById");


            // verify the required parameter 'entityUpdateByIdRequest' is set
            if (entityUpdateByIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityUpdateByIdRequest' when calling Identity->EntityUpdateById");

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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter





            requestOptions.Data = entityUpdateByIdRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/entity/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityUpdateById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityUpdateByIdRequest"></param>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityUpdateByIdAsync(string id, EntityUpdateByIdRequest entityUpdateByIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityUpdateById");


            // verify the required parameter 'entityUpdateByIdRequest' is set
            if (entityUpdateByIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityUpdateByIdRequest' when calling Identity->EntityUpdateById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            requestOptions.Data = entityUpdateByIdRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/entity/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityUpdateById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityUpdateByNameRequest"></param>
        /// <param name="name">Name of the entity</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityUpdateByName(string name, EntityUpdateByNameRequest entityUpdateByNameRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->EntityUpdateByName");


            // verify the required parameter 'entityUpdateByNameRequest' is set
            if (entityUpdateByNameRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityUpdateByNameRequest' when calling Identity->EntityUpdateByName");

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





            requestOptions.Data = entityUpdateByNameRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/entity/name/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityUpdateByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityUpdateByNameRequest"></param>
        /// <param name="name">Name of the entity</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityUpdateByNameAsync(string name, EntityUpdateByNameRequest entityUpdateByNameRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->EntityUpdateByName");


            // verify the required parameter 'entityUpdateByNameRequest' is set
            if (entityUpdateByNameRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityUpdateByNameRequest' when calling Identity->EntityUpdateByName");


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



            requestOptions.Data = entityUpdateByNameRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/entity/name/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityUpdateByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupCreateRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupCreate(GroupCreateRequest groupCreateRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'groupCreateRequest' is set
            if (groupCreateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupCreateRequest' when calling Identity->GroupCreate");

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





            requestOptions.Data = groupCreateRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/group", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupCreate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupCreateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupCreateAsync(GroupCreateRequest groupCreateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'groupCreateRequest' is set
            if (groupCreateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupCreateRequest' when calling Identity->GroupCreate");


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



            requestOptions.Data = groupCreateRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/group", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupCreate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Creates a new group alias, or updates an existing one. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupCreateAliasRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupCreateAlias(GroupCreateAliasRequest groupCreateAliasRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'groupCreateAliasRequest' is set
            if (groupCreateAliasRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupCreateAliasRequest' when calling Identity->GroupCreateAlias");

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





            requestOptions.Data = groupCreateAliasRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/group-alias", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupCreateAlias", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Creates a new group alias, or updates an existing one. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupCreateAliasRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupCreateAliasAsync(GroupCreateAliasRequest groupCreateAliasRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'groupCreateAliasRequest' is set
            if (groupCreateAliasRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupCreateAliasRequest' when calling Identity->GroupCreateAlias");


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



            requestOptions.Data = groupCreateAliasRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/group-alias", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupCreateAlias", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group alias.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupDeleteAliasById(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupDeleteAliasById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/identity/group-alias/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupDeleteAliasById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group alias.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupDeleteAliasByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupDeleteAliasById");



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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/group-alias/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupDeleteAliasById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupDeleteById(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupDeleteById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/identity/group/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupDeleteById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupDeleteByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupDeleteById");



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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/group/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupDeleteById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupDeleteByName(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->GroupDeleteByName");


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
            var response = this.Client.Delete<Object>("/identity/group/name/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupDeleteByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the group.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupDeleteByNameAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->GroupDeleteByName");



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
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/group/name/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupDeleteByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List all the group alias IDs. 
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
        public VaultResponse<Object> GroupListAliasesById(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/group-alias/id", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupListAliasesById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List all the group alias IDs. 
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
        public async Task<VaultResponse<Object>> GroupListAliasesByIdAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/group-alias/id", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupListAliasesById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List all the group IDs. 
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
        public VaultResponse<Object> GroupListById(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/group/id", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupListById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List all the group IDs. 
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
        public async Task<VaultResponse<Object>> GroupListByIdAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/group/id", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupListById", response);
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
        public VaultResponse<Object> GroupListByName(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/group/name", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupListByName", response);
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
        public async Task<VaultResponse<Object>> GroupListByNameAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/group/name", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupListByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Query groups based on various properties. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupLookUpRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupLookUp(GroupLookUpRequest groupLookUpRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'groupLookUpRequest' is set
            if (groupLookUpRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupLookUpRequest' when calling Identity->GroupLookUp");

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





            requestOptions.Data = groupLookUpRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/lookup/group", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupLookUp", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Query groups based on various properties. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupLookUpRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupLookUpAsync(GroupLookUpRequest groupLookUpRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'groupLookUpRequest' is set
            if (groupLookUpRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupLookUpRequest' when calling Identity->GroupLookUp");


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



            requestOptions.Data = groupLookUpRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/lookup/group", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupLookUp", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group alias.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupReadAliasById(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupReadAliasById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/group-alias/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupReadAliasById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group alias.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupReadAliasByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupReadAliasById");



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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/group-alias/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupReadAliasById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupReadById(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupReadById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/group/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupReadById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupReadByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupReadById");



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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/group/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupReadById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupReadByName(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->GroupReadByName");


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
            var response = this.Client.Get<Object>("/identity/group/name/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupReadByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the group.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupReadByNameAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->GroupReadByName");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/group/name/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupReadByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupUpdateAliasByIdRequest"></param>
        /// <param name="id">ID of the group alias.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupUpdateAliasById(string id, GroupUpdateAliasByIdRequest groupUpdateAliasByIdRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupUpdateAliasById");


            // verify the required parameter 'groupUpdateAliasByIdRequest' is set
            if (groupUpdateAliasByIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupUpdateAliasByIdRequest' when calling Identity->GroupUpdateAliasById");

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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter





            requestOptions.Data = groupUpdateAliasByIdRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/group-alias/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupUpdateAliasById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupUpdateAliasByIdRequest"></param>
        /// <param name="id">ID of the group alias.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupUpdateAliasByIdAsync(string id, GroupUpdateAliasByIdRequest groupUpdateAliasByIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupUpdateAliasById");


            // verify the required parameter 'groupUpdateAliasByIdRequest' is set
            if (groupUpdateAliasByIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupUpdateAliasByIdRequest' when calling Identity->GroupUpdateAliasById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            requestOptions.Data = groupUpdateAliasByIdRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/group-alias/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupUpdateAliasById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupUpdateByIdRequest"></param>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupUpdateById(string id, GroupUpdateByIdRequest groupUpdateByIdRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupUpdateById");


            // verify the required parameter 'groupUpdateByIdRequest' is set
            if (groupUpdateByIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupUpdateByIdRequest' when calling Identity->GroupUpdateById");

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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter





            requestOptions.Data = groupUpdateByIdRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/group/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupUpdateById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupUpdateByIdRequest"></param>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupUpdateByIdAsync(string id, GroupUpdateByIdRequest groupUpdateByIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupUpdateById");


            // verify the required parameter 'groupUpdateByIdRequest' is set
            if (groupUpdateByIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupUpdateByIdRequest' when calling Identity->GroupUpdateById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            requestOptions.Data = groupUpdateByIdRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/group/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupUpdateById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupUpdateByNameRequest"></param>
        /// <param name="name">Name of the group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupUpdateByName(string name, GroupUpdateByNameRequest groupUpdateByNameRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->GroupUpdateByName");


            // verify the required parameter 'groupUpdateByNameRequest' is set
            if (groupUpdateByNameRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupUpdateByNameRequest' when calling Identity->GroupUpdateByName");

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





            requestOptions.Data = groupUpdateByNameRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/group/name/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupUpdateByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupUpdateByNameRequest"></param>
        /// <param name="name">Name of the group.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupUpdateByNameAsync(string name, GroupUpdateByNameRequest groupUpdateByNameRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->GroupUpdateByName");


            // verify the required parameter 'groupUpdateByNameRequest' is set
            if (groupUpdateByNameRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupUpdateByNameRequest' when calling Identity->GroupUpdateByName");


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



            requestOptions.Data = groupUpdateByNameRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/group/name/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupUpdateByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Destroys a TOTP secret for the given MFA method ID on the given entity 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaAdminDestroyTotpSecretRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaAdminDestroyTotpSecret(MfaAdminDestroyTotpSecretRequest mfaAdminDestroyTotpSecretRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'mfaAdminDestroyTotpSecretRequest' is set
            if (mfaAdminDestroyTotpSecretRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaAdminDestroyTotpSecretRequest' when calling Identity->MfaAdminDestroyTotpSecret");

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





            requestOptions.Data = mfaAdminDestroyTotpSecretRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/totp/admin-destroy", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaAdminDestroyTotpSecret", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Destroys a TOTP secret for the given MFA method ID on the given entity 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaAdminDestroyTotpSecretRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaAdminDestroyTotpSecretAsync(MfaAdminDestroyTotpSecretRequest mfaAdminDestroyTotpSecretRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'mfaAdminDestroyTotpSecretRequest' is set
            if (mfaAdminDestroyTotpSecretRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaAdminDestroyTotpSecretRequest' when calling Identity->MfaAdminDestroyTotpSecret");


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



            requestOptions.Data = mfaAdminDestroyTotpSecretRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/totp/admin-destroy", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaAdminDestroyTotpSecret", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaAdminGenerateTotpSecretRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaAdminGenerateTotpSecret(MfaAdminGenerateTotpSecretRequest mfaAdminGenerateTotpSecretRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'mfaAdminGenerateTotpSecretRequest' is set
            if (mfaAdminGenerateTotpSecretRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaAdminGenerateTotpSecretRequest' when calling Identity->MfaAdminGenerateTotpSecret");

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





            requestOptions.Data = mfaAdminGenerateTotpSecretRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/totp/admin-generate", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaAdminGenerateTotpSecret", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaAdminGenerateTotpSecretRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaAdminGenerateTotpSecretAsync(MfaAdminGenerateTotpSecretRequest mfaAdminGenerateTotpSecretRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'mfaAdminGenerateTotpSecretRequest' is set
            if (mfaAdminGenerateTotpSecretRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaAdminGenerateTotpSecretRequest' when calling Identity->MfaAdminGenerateTotpSecret");


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



            requestOptions.Data = mfaAdminGenerateTotpSecretRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/totp/admin-generate", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaAdminGenerateTotpSecret", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Create the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreateDuoMethodRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaCreateDuoMethod(MfaCreateDuoMethodRequest mfaCreateDuoMethodRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'mfaCreateDuoMethodRequest' is set
            if (mfaCreateDuoMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaCreateDuoMethodRequest' when calling Identity->MfaCreateDuoMethod");

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





            requestOptions.Data = mfaCreateDuoMethodRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/duo", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaCreateDuoMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreateDuoMethodRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaCreateDuoMethodAsync(MfaCreateDuoMethodRequest mfaCreateDuoMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'mfaCreateDuoMethodRequest' is set
            if (mfaCreateDuoMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaCreateDuoMethodRequest' when calling Identity->MfaCreateDuoMethod");


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



            requestOptions.Data = mfaCreateDuoMethodRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/duo", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaCreateDuoMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Create the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreateOktaMethodRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaCreateOktaMethod(MfaCreateOktaMethodRequest mfaCreateOktaMethodRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'mfaCreateOktaMethodRequest' is set
            if (mfaCreateOktaMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaCreateOktaMethodRequest' when calling Identity->MfaCreateOktaMethod");

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





            requestOptions.Data = mfaCreateOktaMethodRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/okta", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaCreateOktaMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreateOktaMethodRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaCreateOktaMethodAsync(MfaCreateOktaMethodRequest mfaCreateOktaMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'mfaCreateOktaMethodRequest' is set
            if (mfaCreateOktaMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaCreateOktaMethodRequest' when calling Identity->MfaCreateOktaMethod");


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



            requestOptions.Data = mfaCreateOktaMethodRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/okta", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaCreateOktaMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Create the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreatePingIdMethodRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaCreatePingIdMethod(MfaCreatePingIdMethodRequest mfaCreatePingIdMethodRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'mfaCreatePingIdMethodRequest' is set
            if (mfaCreatePingIdMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaCreatePingIdMethodRequest' when calling Identity->MfaCreatePingIdMethod");

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





            requestOptions.Data = mfaCreatePingIdMethodRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/pingid", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaCreatePingIdMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreatePingIdMethodRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaCreatePingIdMethodAsync(MfaCreatePingIdMethodRequest mfaCreatePingIdMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'mfaCreatePingIdMethodRequest' is set
            if (mfaCreatePingIdMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaCreatePingIdMethodRequest' when calling Identity->MfaCreatePingIdMethod");


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



            requestOptions.Data = mfaCreatePingIdMethodRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/pingid", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaCreatePingIdMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Create the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreateTotpMethodRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaCreateTotpMethod(MfaCreateTotpMethodRequest mfaCreateTotpMethodRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'mfaCreateTotpMethodRequest' is set
            if (mfaCreateTotpMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaCreateTotpMethodRequest' when calling Identity->MfaCreateTotpMethod");

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





            requestOptions.Data = mfaCreateTotpMethodRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/totp", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaCreateTotpMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaCreateTotpMethodRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaCreateTotpMethodAsync(MfaCreateTotpMethodRequest mfaCreateTotpMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'mfaCreateTotpMethodRequest' is set
            if (mfaCreateTotpMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaCreateTotpMethodRequest' when calling Identity->MfaCreateTotpMethod");


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



            requestOptions.Data = mfaCreateTotpMethodRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/totp", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaCreateTotpMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Delete the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaDeleteDuoMethod(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaDeleteDuoMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/identity/mfa/method/duo/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaDeleteDuoMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaDeleteDuoMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaDeleteDuoMethod");



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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/mfa/method/duo/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaDeleteDuoMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Delete a login enforcement 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaDeleteLoginEnforcement(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->MfaDeleteLoginEnforcement");


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
            var response = this.Client.Delete<Object>("/identity/mfa/login-enforcement/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaDeleteLoginEnforcement", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete a login enforcement 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaDeleteLoginEnforcementAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->MfaDeleteLoginEnforcement");



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
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/mfa/login-enforcement/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaDeleteLoginEnforcement", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Delete the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaDeleteOktaMethod(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaDeleteOktaMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/identity/mfa/method/okta/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaDeleteOktaMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaDeleteOktaMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaDeleteOktaMethod");



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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/mfa/method/okta/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaDeleteOktaMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Delete the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaDeletePingIdMethod(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaDeletePingIdMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/identity/mfa/method/pingid/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaDeletePingIdMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaDeletePingIdMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaDeletePingIdMethod");



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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/mfa/method/pingid/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaDeletePingIdMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Delete the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaDeleteTotpMethod(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaDeleteTotpMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/identity/mfa/method/totp/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaDeleteTotpMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaDeleteTotpMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaDeleteTotpMethod");



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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/mfa/method/totp/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaDeleteTotpMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaGenerateTotpSecretRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaGenerateTotpSecret(MfaGenerateTotpSecretRequest mfaGenerateTotpSecretRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'mfaGenerateTotpSecretRequest' is set
            if (mfaGenerateTotpSecretRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaGenerateTotpSecretRequest' when calling Identity->MfaGenerateTotpSecret");

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





            requestOptions.Data = mfaGenerateTotpSecretRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/totp/generate", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaGenerateTotpSecret", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaGenerateTotpSecretRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaGenerateTotpSecretAsync(MfaGenerateTotpSecretRequest mfaGenerateTotpSecretRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'mfaGenerateTotpSecretRequest' is set
            if (mfaGenerateTotpSecretRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaGenerateTotpSecretRequest' when calling Identity->MfaGenerateTotpSecret");


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



            requestOptions.Data = mfaGenerateTotpSecretRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/totp/generate", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaGenerateTotpSecret", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List MFA method configurations for the given MFA method 
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
        public VaultResponse<Object> MfaListDuoMethods(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/mfa/method/duo", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaListDuoMethods", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List MFA method configurations for the given MFA method 
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
        public async Task<VaultResponse<Object>> MfaListDuoMethodsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/mfa/method/duo", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaListDuoMethods", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List login enforcements 
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
        public VaultResponse<Object> MfaListLoginEnforcements(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/mfa/login-enforcement", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaListLoginEnforcements", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List login enforcements 
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
        public async Task<VaultResponse<Object>> MfaListLoginEnforcementsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/mfa/login-enforcement", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaListLoginEnforcements", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List MFA method configurations for all MFA methods 
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
        public VaultResponse<Object> MfaListMethods(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/mfa/method", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaListMethods", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List MFA method configurations for all MFA methods 
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
        public async Task<VaultResponse<Object>> MfaListMethodsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/mfa/method", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaListMethods", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List MFA method configurations for the given MFA method 
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
        public VaultResponse<Object> MfaListOktaMethods(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/mfa/method/okta", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaListOktaMethods", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List MFA method configurations for the given MFA method 
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
        public async Task<VaultResponse<Object>> MfaListOktaMethodsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/mfa/method/okta", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaListOktaMethods", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List MFA method configurations for the given MFA method 
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
        public VaultResponse<Object> MfaListPingIdMethods(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/mfa/method/pingid", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaListPingIdMethods", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List MFA method configurations for the given MFA method 
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
        public async Task<VaultResponse<Object>> MfaListPingIdMethodsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/mfa/method/pingid", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaListPingIdMethods", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List MFA method configurations for the given MFA method 
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
        public VaultResponse<Object> MfaListTotpMethods(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/mfa/method/totp", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaListTotpMethods", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List MFA method configurations for the given MFA method 
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
        public async Task<VaultResponse<Object>> MfaListTotpMethodsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/mfa/method/totp", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaListTotpMethods", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Read the current configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaReadDuoMethod(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaReadDuoMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/mfa/method/duo/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaReadDuoMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Read the current configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaReadDuoMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaReadDuoMethod");



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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/mfa/method/duo/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaReadDuoMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Read the current login enforcement 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaReadLoginEnforcement(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->MfaReadLoginEnforcement");


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
            var response = this.Client.Get<Object>("/identity/mfa/login-enforcement/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaReadLoginEnforcement", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Read the current login enforcement 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaReadLoginEnforcementAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->MfaReadLoginEnforcement");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/mfa/login-enforcement/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaReadLoginEnforcement", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Read the current configuration for the given ID regardless of the MFA method type 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaReadMethod(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaReadMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/mfa/method/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaReadMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Read the current configuration for the given ID regardless of the MFA method type 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaReadMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaReadMethod");



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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/mfa/method/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaReadMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Read the current configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaReadOktaMethod(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaReadOktaMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/mfa/method/okta/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaReadOktaMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Read the current configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaReadOktaMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaReadOktaMethod");



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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/mfa/method/okta/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaReadOktaMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Read the current configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaReadPingIdMethod(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaReadPingIdMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/mfa/method/pingid/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaReadPingIdMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Read the current configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaReadPingIdMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaReadPingIdMethod");



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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/mfa/method/pingid/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaReadPingIdMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Read the current configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaReadTotpMethod(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaReadTotpMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/mfa/method/totp/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaReadTotpMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Read the current configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaReadTotpMethodAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaReadTotpMethod");



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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/mfa/method/totp/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaReadTotpMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update the configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdateDuoMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaUpdateDuoMethod(string methodId, MfaUpdateDuoMethodRequest mfaUpdateDuoMethodRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaUpdateDuoMethod");


            // verify the required parameter 'mfaUpdateDuoMethodRequest' is set
            if (mfaUpdateDuoMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaUpdateDuoMethodRequest' when calling Identity->MfaUpdateDuoMethod");

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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter





            requestOptions.Data = mfaUpdateDuoMethodRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/duo/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaUpdateDuoMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update the configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdateDuoMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaUpdateDuoMethodAsync(string methodId, MfaUpdateDuoMethodRequest mfaUpdateDuoMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaUpdateDuoMethod");


            // verify the required parameter 'mfaUpdateDuoMethodRequest' is set
            if (mfaUpdateDuoMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaUpdateDuoMethodRequest' when calling Identity->MfaUpdateDuoMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            requestOptions.Data = mfaUpdateDuoMethodRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/duo/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaUpdateDuoMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update the configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdateOktaMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaUpdateOktaMethod(string methodId, MfaUpdateOktaMethodRequest mfaUpdateOktaMethodRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaUpdateOktaMethod");


            // verify the required parameter 'mfaUpdateOktaMethodRequest' is set
            if (mfaUpdateOktaMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaUpdateOktaMethodRequest' when calling Identity->MfaUpdateOktaMethod");

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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter





            requestOptions.Data = mfaUpdateOktaMethodRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/okta/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaUpdateOktaMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update the configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdateOktaMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaUpdateOktaMethodAsync(string methodId, MfaUpdateOktaMethodRequest mfaUpdateOktaMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaUpdateOktaMethod");


            // verify the required parameter 'mfaUpdateOktaMethodRequest' is set
            if (mfaUpdateOktaMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaUpdateOktaMethodRequest' when calling Identity->MfaUpdateOktaMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            requestOptions.Data = mfaUpdateOktaMethodRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/okta/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaUpdateOktaMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update the configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdatePingIdMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaUpdatePingIdMethod(string methodId, MfaUpdatePingIdMethodRequest mfaUpdatePingIdMethodRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaUpdatePingIdMethod");


            // verify the required parameter 'mfaUpdatePingIdMethodRequest' is set
            if (mfaUpdatePingIdMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaUpdatePingIdMethodRequest' when calling Identity->MfaUpdatePingIdMethod");

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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter





            requestOptions.Data = mfaUpdatePingIdMethodRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/pingid/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaUpdatePingIdMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update the configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdatePingIdMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaUpdatePingIdMethodAsync(string methodId, MfaUpdatePingIdMethodRequest mfaUpdatePingIdMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaUpdatePingIdMethod");


            // verify the required parameter 'mfaUpdatePingIdMethodRequest' is set
            if (mfaUpdatePingIdMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaUpdatePingIdMethodRequest' when calling Identity->MfaUpdatePingIdMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            requestOptions.Data = mfaUpdatePingIdMethodRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/pingid/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaUpdatePingIdMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update the configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdateTotpMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaUpdateTotpMethod(string methodId, MfaUpdateTotpMethodRequest mfaUpdateTotpMethodRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaUpdateTotpMethod");


            // verify the required parameter 'mfaUpdateTotpMethodRequest' is set
            if (mfaUpdateTotpMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaUpdateTotpMethodRequest' when calling Identity->MfaUpdateTotpMethod");

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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter





            requestOptions.Data = mfaUpdateTotpMethodRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/totp/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaUpdateTotpMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update the configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaUpdateTotpMethodRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaUpdateTotpMethodAsync(string methodId, MfaUpdateTotpMethodRequest mfaUpdateTotpMethodRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MfaUpdateTotpMethod");


            // verify the required parameter 'mfaUpdateTotpMethodRequest' is set
            if (mfaUpdateTotpMethodRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaUpdateTotpMethodRequest' when calling Identity->MfaUpdateTotpMethod");


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


            requestOptions.PathParameters.Add("method_id", ClientUtils.ParameterToString(methodId)); // path parameter



            requestOptions.Data = mfaUpdateTotpMethodRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/totp/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaUpdateTotpMethod", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Create or update a login enforcement 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaWriteLoginEnforcementRequest"></param>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MfaWriteLoginEnforcement(string name, MfaWriteLoginEnforcementRequest mfaWriteLoginEnforcementRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->MfaWriteLoginEnforcement");


            // verify the required parameter 'mfaWriteLoginEnforcementRequest' is set
            if (mfaWriteLoginEnforcementRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaWriteLoginEnforcementRequest' when calling Identity->MfaWriteLoginEnforcement");

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





            requestOptions.Data = mfaWriteLoginEnforcementRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/login-enforcement/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaWriteLoginEnforcement", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create or update a login enforcement 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mfaWriteLoginEnforcementRequest"></param>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MfaWriteLoginEnforcementAsync(string name, MfaWriteLoginEnforcementRequest mfaWriteLoginEnforcementRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->MfaWriteLoginEnforcement");


            // verify the required parameter 'mfaWriteLoginEnforcementRequest' is set
            if (mfaWriteLoginEnforcementRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mfaWriteLoginEnforcementRequest' when calling Identity->MfaWriteLoginEnforcement");


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



            requestOptions.Data = mfaWriteLoginEnforcementRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/login-enforcement/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MfaWriteLoginEnforcement", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcConfigureRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcConfigure(OidcConfigureRequest oidcConfigureRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'oidcConfigureRequest' is set
            if (oidcConfigureRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcConfigureRequest' when calling Identity->OidcConfigure");

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





            requestOptions.Data = oidcConfigureRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/config", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcConfigure", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcConfigureRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcConfigureAsync(OidcConfigureRequest oidcConfigureRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'oidcConfigureRequest' is set
            if (oidcConfigureRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcConfigureRequest' when calling Identity->OidcConfigure");


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



            requestOptions.Data = oidcConfigureRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/config", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcConfigure", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the assignment</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcDeleteAssignment(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcDeleteAssignment");


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
            var response = this.Client.Delete<Object>("/identity/oidc/assignment/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcDeleteAssignment", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the assignment</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcDeleteAssignmentAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcDeleteAssignment");



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
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/oidc/assignment/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcDeleteAssignment", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the client.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcDeleteClient(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcDeleteClient");


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
            var response = this.Client.Delete<Object>("/identity/oidc/client/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcDeleteClient", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the client.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcDeleteClientAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcDeleteClient");



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
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/oidc/client/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcDeleteClient", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// CRUD operations for OIDC keys. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the key</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcDeleteKey(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcDeleteKey");


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
            var response = this.Client.Delete<Object>("/identity/oidc/key/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcDeleteKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// CRUD operations for OIDC keys. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the key</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcDeleteKeyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcDeleteKey");



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
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/oidc/key/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcDeleteKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcDeleteProvider(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcDeleteProvider");


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
            var response = this.Client.Delete<Object>("/identity/oidc/provider/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcDeleteProvider", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcDeleteProviderAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcDeleteProvider");



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
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/oidc/provider/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcDeleteProvider", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// CRUD operations on OIDC Roles 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the role</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcDeleteRole(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcDeleteRole");


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
            var response = this.Client.Delete<Object>("/identity/oidc/role/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcDeleteRole", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// CRUD operations on OIDC Roles 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the role</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcDeleteRoleAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcDeleteRole");



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
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/oidc/role/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcDeleteRole", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the scope</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcDeleteScope(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcDeleteScope");


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
            var response = this.Client.Delete<Object>("/identity/oidc/scope/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcDeleteScope", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the scope</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcDeleteScopeAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcDeleteScope");



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
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/oidc/scope/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcDeleteScope", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Generate an OIDC token 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the role</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcGenerateToken(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcGenerateToken");


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
            var response = this.Client.Get<Object>("/identity/oidc/token/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcGenerateToken", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Generate an OIDC token 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the role</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcGenerateTokenAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcGenerateToken");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/token/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcGenerateToken", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Verify the authenticity of an OIDC token 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcIntrospectRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcIntrospect(OidcIntrospectRequest oidcIntrospectRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'oidcIntrospectRequest' is set
            if (oidcIntrospectRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcIntrospectRequest' when calling Identity->OidcIntrospect");

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





            requestOptions.Data = oidcIntrospectRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/introspect", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcIntrospect", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Verify the authenticity of an OIDC token 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcIntrospectRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcIntrospectAsync(OidcIntrospectRequest oidcIntrospectRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'oidcIntrospectRequest' is set
            if (oidcIntrospectRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcIntrospectRequest' when calling Identity->OidcIntrospect");


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



            requestOptions.Data = oidcIntrospectRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/introspect", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcIntrospect", response);
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
        public VaultResponse<Object> OidcListAssignments(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/oidc/assignment", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcListAssignments", response);
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
        public async Task<VaultResponse<Object>> OidcListAssignmentsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/assignment", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcListAssignments", response);
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
        public VaultResponse<Object> OidcListClients(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/oidc/client", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcListClients", response);
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
        public async Task<VaultResponse<Object>> OidcListClientsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/client", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcListClients", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List OIDC keys 
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
        public VaultResponse<Object> OidcListKeys(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/oidc/key", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcListKeys", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List OIDC keys 
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
        public async Task<VaultResponse<Object>> OidcListKeysAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/key", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcListKeys", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="allowedClientId">Filters the list of OIDC providers to those that allow the given client ID in their set of allowed_client_ids. (optional, default to &quot;&quot;)</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcListProviders(string allowedClientId = default(string), TimeSpan? wrapTTL = null)
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




            if (allowedClientId != null)
            {


                requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "allowed_client_id", allowedClientId));

            }
            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/oidc/provider", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcListProviders", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>

        /// <param name="allowedClientId">Filters the list of OIDC providers to those that allow the given client ID in their set of allowed_client_ids. (optional, default to &quot;&quot;)</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcListProvidersAsync(string allowedClientId = default(string), TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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




            if (allowedClientId != null)
            {
                requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "allowed_client_id", allowedClientId));
            }
            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/provider", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcListProviders", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List configured OIDC roles 
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
        public VaultResponse<Object> OidcListRoles(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/oidc/role", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcListRoles", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List configured OIDC roles 
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
        public async Task<VaultResponse<Object>> OidcListRolesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/role", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcListRoles", response);
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
        public VaultResponse<Object> OidcListScopes(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/oidc/scope", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcListScopes", response);
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
        public async Task<VaultResponse<Object>> OidcListScopesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/scope", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcListScopes", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcProviderAuthorize(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcProviderAuthorize");


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
            var response = this.Client.Get<Object>("/identity/oidc/provider/{name}/authorize", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcProviderAuthorize", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcProviderAuthorizeAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcProviderAuthorize");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/provider/{name}/authorize", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcProviderAuthorize", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcProviderAuthorizeWithParametersRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcProviderAuthorizeWithParameters(string name, OidcProviderAuthorizeWithParametersRequest oidcProviderAuthorizeWithParametersRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcProviderAuthorizeWithParameters");


            // verify the required parameter 'oidcProviderAuthorizeWithParametersRequest' is set
            if (oidcProviderAuthorizeWithParametersRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcProviderAuthorizeWithParametersRequest' when calling Identity->OidcProviderAuthorizeWithParameters");

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





            requestOptions.Data = oidcProviderAuthorizeWithParametersRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/provider/{name}/authorize", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcProviderAuthorizeWithParameters", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcProviderAuthorizeWithParametersRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcProviderAuthorizeWithParametersAsync(string name, OidcProviderAuthorizeWithParametersRequest oidcProviderAuthorizeWithParametersRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcProviderAuthorizeWithParameters");


            // verify the required parameter 'oidcProviderAuthorizeWithParametersRequest' is set
            if (oidcProviderAuthorizeWithParametersRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcProviderAuthorizeWithParametersRequest' when calling Identity->OidcProviderAuthorizeWithParameters");


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



            requestOptions.Data = oidcProviderAuthorizeWithParametersRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/provider/{name}/authorize", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcProviderAuthorizeWithParameters", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcProviderTokenRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcProviderToken(string name, OidcProviderTokenRequest oidcProviderTokenRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcProviderToken");


            // verify the required parameter 'oidcProviderTokenRequest' is set
            if (oidcProviderTokenRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcProviderTokenRequest' when calling Identity->OidcProviderToken");

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





            requestOptions.Data = oidcProviderTokenRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/provider/{name}/token", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcProviderToken", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcProviderTokenRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcProviderTokenAsync(string name, OidcProviderTokenRequest oidcProviderTokenRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcProviderToken");


            // verify the required parameter 'oidcProviderTokenRequest' is set
            if (oidcProviderTokenRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcProviderTokenRequest' when calling Identity->OidcProviderToken");


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



            requestOptions.Data = oidcProviderTokenRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/provider/{name}/token", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcProviderToken", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcProviderUserInfo(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcProviderUserInfo");


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
            var response = this.Client.Get<Object>("/identity/oidc/provider/{name}/userinfo", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcProviderUserInfo", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcProviderUserInfoAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcProviderUserInfo");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/provider/{name}/userinfo", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcProviderUserInfo", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the assignment</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcReadAssignment(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadAssignment");


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
            var response = this.Client.Get<Object>("/identity/oidc/assignment/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadAssignment", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the assignment</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcReadAssignmentAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadAssignment");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/assignment/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadAssignment", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the client.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcReadClient(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadClient");


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
            var response = this.Client.Get<Object>("/identity/oidc/client/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadClient", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the client.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcReadClientAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadClient");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/client/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadClient", response);
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
        public VaultResponse<Object> OidcReadConfiguration(TimeSpan? wrapTTL = null)
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
            var response = this.Client.Get<Object>("/identity/oidc/config", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadConfiguration", response);
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
        public async Task<VaultResponse<Object>> OidcReadConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/config", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// CRUD operations for OIDC keys. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the key</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcReadKey(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadKey");


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
            var response = this.Client.Get<Object>("/identity/oidc/key/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// CRUD operations for OIDC keys. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the key</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcReadKeyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadKey");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/key/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Query OIDC configurations 
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
        public VaultResponse<Object> OidcReadOpenIdConfiguration(TimeSpan? wrapTTL = null)
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
            var response = this.Client.Get<Object>("/identity/oidc/.well-known/openid-configuration", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadOpenIdConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Query OIDC configurations 
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
        public async Task<VaultResponse<Object>> OidcReadOpenIdConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/.well-known/openid-configuration", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadOpenIdConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcReadProvider(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadProvider");


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
            var response = this.Client.Get<Object>("/identity/oidc/provider/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadProvider", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcReadProviderAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadProvider");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/provider/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadProvider", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcReadProviderOpenIdConfiguration(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadProviderOpenIdConfiguration");


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
            var response = this.Client.Get<Object>("/identity/oidc/provider/{name}/.well-known/openid-configuration", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadProviderOpenIdConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcReadProviderOpenIdConfigurationAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadProviderOpenIdConfiguration");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/provider/{name}/.well-known/openid-configuration", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadProviderOpenIdConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcReadProviderPublicKeys(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadProviderPublicKeys");


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
            var response = this.Client.Get<Object>("/identity/oidc/provider/{name}/.well-known/keys", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadProviderPublicKeys", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcReadProviderPublicKeysAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadProviderPublicKeys");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/provider/{name}/.well-known/keys", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadProviderPublicKeys", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Retrieve public keys 
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
        public VaultResponse<Object> OidcReadPublicKeys(TimeSpan? wrapTTL = null)
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
            var response = this.Client.Get<Object>("/identity/oidc/.well-known/keys", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadPublicKeys", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Retrieve public keys 
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
        public async Task<VaultResponse<Object>> OidcReadPublicKeysAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/.well-known/keys", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadPublicKeys", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// CRUD operations on OIDC Roles 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the role</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcReadRole(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadRole");


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
            var response = this.Client.Get<Object>("/identity/oidc/role/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadRole", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// CRUD operations on OIDC Roles 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the role</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcReadRoleAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadRole");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/role/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadRole", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the scope</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcReadScope(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadScope");


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
            var response = this.Client.Get<Object>("/identity/oidc/scope/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadScope", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="name">Name of the scope</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcReadScopeAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcReadScope");



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
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/oidc/scope/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcReadScope", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Rotate a named OIDC key. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcRotateKeyRequest"></param>
        /// <param name="name">Name of the key</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcRotateKey(string name, OidcRotateKeyRequest oidcRotateKeyRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcRotateKey");


            // verify the required parameter 'oidcRotateKeyRequest' is set
            if (oidcRotateKeyRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcRotateKeyRequest' when calling Identity->OidcRotateKey");

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





            requestOptions.Data = oidcRotateKeyRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/key/{name}/rotate", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcRotateKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Rotate a named OIDC key. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcRotateKeyRequest"></param>
        /// <param name="name">Name of the key</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcRotateKeyAsync(string name, OidcRotateKeyRequest oidcRotateKeyRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcRotateKey");


            // verify the required parameter 'oidcRotateKeyRequest' is set
            if (oidcRotateKeyRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcRotateKeyRequest' when calling Identity->OidcRotateKey");


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



            requestOptions.Data = oidcRotateKeyRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/key/{name}/rotate", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcRotateKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteAssignmentRequest"></param>
        /// <param name="name">Name of the assignment</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcWriteAssignment(string name, OidcWriteAssignmentRequest oidcWriteAssignmentRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcWriteAssignment");


            // verify the required parameter 'oidcWriteAssignmentRequest' is set
            if (oidcWriteAssignmentRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcWriteAssignmentRequest' when calling Identity->OidcWriteAssignment");

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





            requestOptions.Data = oidcWriteAssignmentRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/assignment/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcWriteAssignment", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteAssignmentRequest"></param>
        /// <param name="name">Name of the assignment</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcWriteAssignmentAsync(string name, OidcWriteAssignmentRequest oidcWriteAssignmentRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcWriteAssignment");


            // verify the required parameter 'oidcWriteAssignmentRequest' is set
            if (oidcWriteAssignmentRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcWriteAssignmentRequest' when calling Identity->OidcWriteAssignment");


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



            requestOptions.Data = oidcWriteAssignmentRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/assignment/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcWriteAssignment", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteClientRequest"></param>
        /// <param name="name">Name of the client.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcWriteClient(string name, OidcWriteClientRequest oidcWriteClientRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcWriteClient");


            // verify the required parameter 'oidcWriteClientRequest' is set
            if (oidcWriteClientRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcWriteClientRequest' when calling Identity->OidcWriteClient");

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





            requestOptions.Data = oidcWriteClientRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/client/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcWriteClient", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteClientRequest"></param>
        /// <param name="name">Name of the client.</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcWriteClientAsync(string name, OidcWriteClientRequest oidcWriteClientRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcWriteClient");


            // verify the required parameter 'oidcWriteClientRequest' is set
            if (oidcWriteClientRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcWriteClientRequest' when calling Identity->OidcWriteClient");


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



            requestOptions.Data = oidcWriteClientRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/client/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcWriteClient", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// CRUD operations for OIDC keys. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteKeyRequest"></param>
        /// <param name="name">Name of the key</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcWriteKey(string name, OidcWriteKeyRequest oidcWriteKeyRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcWriteKey");


            // verify the required parameter 'oidcWriteKeyRequest' is set
            if (oidcWriteKeyRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcWriteKeyRequest' when calling Identity->OidcWriteKey");

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





            requestOptions.Data = oidcWriteKeyRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/key/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcWriteKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// CRUD operations for OIDC keys. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteKeyRequest"></param>
        /// <param name="name">Name of the key</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcWriteKeyAsync(string name, OidcWriteKeyRequest oidcWriteKeyRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcWriteKey");


            // verify the required parameter 'oidcWriteKeyRequest' is set
            if (oidcWriteKeyRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcWriteKeyRequest' when calling Identity->OidcWriteKey");


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



            requestOptions.Data = oidcWriteKeyRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/key/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcWriteKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteProviderRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcWriteProvider(string name, OidcWriteProviderRequest oidcWriteProviderRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcWriteProvider");


            // verify the required parameter 'oidcWriteProviderRequest' is set
            if (oidcWriteProviderRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcWriteProviderRequest' when calling Identity->OidcWriteProvider");

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





            requestOptions.Data = oidcWriteProviderRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/provider/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcWriteProvider", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteProviderRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcWriteProviderAsync(string name, OidcWriteProviderRequest oidcWriteProviderRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcWriteProvider");


            // verify the required parameter 'oidcWriteProviderRequest' is set
            if (oidcWriteProviderRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcWriteProviderRequest' when calling Identity->OidcWriteProvider");


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



            requestOptions.Data = oidcWriteProviderRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/provider/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcWriteProvider", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// CRUD operations on OIDC Roles 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteRoleRequest"></param>
        /// <param name="name">Name of the role</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcWriteRole(string name, OidcWriteRoleRequest oidcWriteRoleRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcWriteRole");


            // verify the required parameter 'oidcWriteRoleRequest' is set
            if (oidcWriteRoleRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcWriteRoleRequest' when calling Identity->OidcWriteRole");

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





            requestOptions.Data = oidcWriteRoleRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/role/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcWriteRole", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// CRUD operations on OIDC Roles 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteRoleRequest"></param>
        /// <param name="name">Name of the role</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcWriteRoleAsync(string name, OidcWriteRoleRequest oidcWriteRoleRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcWriteRole");


            // verify the required parameter 'oidcWriteRoleRequest' is set
            if (oidcWriteRoleRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcWriteRoleRequest' when calling Identity->OidcWriteRole");


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



            requestOptions.Data = oidcWriteRoleRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/role/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcWriteRole", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteScopeRequest"></param>
        /// <param name="name">Name of the scope</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OidcWriteScope(string name, OidcWriteScopeRequest oidcWriteScopeRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcWriteScope");


            // verify the required parameter 'oidcWriteScopeRequest' is set
            if (oidcWriteScopeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcWriteScopeRequest' when calling Identity->OidcWriteScope");

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





            requestOptions.Data = oidcWriteScopeRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/scope/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcWriteScope", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oidcWriteScopeRequest"></param>
        /// <param name="name">Name of the scope</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OidcWriteScopeAsync(string name, OidcWriteScopeRequest oidcWriteScopeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OidcWriteScope");


            // verify the required parameter 'oidcWriteScopeRequest' is set
            if (oidcWriteScopeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oidcWriteScopeRequest' when calling Identity->OidcWriteScope");


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



            requestOptions.Data = oidcWriteScopeRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/scope/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OidcWriteScope", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Create a new alias. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaCreateRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PersonaCreate(PersonaCreateRequest personaCreateRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'personaCreateRequest' is set
            if (personaCreateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'personaCreateRequest' when calling Identity->PersonaCreate");

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





            requestOptions.Data = personaCreateRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/persona", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaCreate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create a new alias. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaCreateRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PersonaCreateAsync(PersonaCreateRequest personaCreateRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'personaCreateRequest' is set
            if (personaCreateRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'personaCreateRequest' when calling Identity->PersonaCreate");


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



            requestOptions.Data = personaCreateRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/persona", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaCreate", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the persona</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PersonaDeleteById(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->PersonaDeleteById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter






            // make the HTTP request
            var response = this.Client.Delete<Object>("/identity/persona/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaDeleteById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the persona</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PersonaDeleteByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->PersonaDeleteById");



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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.DeleteAsync<Object>("/identity/persona/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaDeleteById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// List all the alias IDs. 
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
        public VaultResponse<Object> PersonaListById(TimeSpan? wrapTTL = null)
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));





            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/persona/id", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaListById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// List all the alias IDs. 
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
        public async Task<VaultResponse<Object>> PersonaListByIdAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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



            requestOptions.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "list", "true"));


            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/persona/id", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaListById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the persona</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PersonaReadById(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->PersonaReadById");


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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter






            // make the HTTP request
            var response = this.Client.Get<Object>("/identity/persona/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaReadById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="id">ID of the persona</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PersonaReadByIdAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->PersonaReadById");



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


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            // make the HTTP request
            var response = await this.AsynchronousClient.GetAsync<Object>("/identity/persona/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaReadById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaUpdateByIdRequest"></param>
        /// <param name="id">ID of the persona</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PersonaUpdateById(string id, PersonaUpdateByIdRequest personaUpdateByIdRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->PersonaUpdateById");


            // verify the required parameter 'personaUpdateByIdRequest' is set
            if (personaUpdateByIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'personaUpdateByIdRequest' when calling Identity->PersonaUpdateById");

            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                ""
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter





            requestOptions.Data = personaUpdateByIdRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/persona/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaUpdateById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaUpdateByIdRequest"></param>
        /// <param name="id">ID of the persona</param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PersonaUpdateByIdAsync(string id, PersonaUpdateByIdRequest personaUpdateByIdRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->PersonaUpdateById");


            // verify the required parameter 'personaUpdateByIdRequest' is set
            if (personaUpdateByIdRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'personaUpdateByIdRequest' when calling Identity->PersonaUpdateById");


            RequestOptions requestOptions = new RequestOptions();

            if (wrapTTL != null)
            {
                requestOptions.HeaderParameters.Add("X-Vault-Wrap-TTL", wrapTTL.Value.TotalSeconds.ToString());
            }

            string[] _contentTypes = new string[] {
                ""
            };

            // to determine the Accept header
            string[] _accepts = new string[] {

            };

            var contentType = ClientUtils.SelectHeaderContentType(_contentTypes);
            if (contentType != null) requestOptions.HeaderParameters.Add("Content-Type", contentType);

            var accept = ClientUtils.SelectHeaderAccept(_accepts);
            if (accept != null) requestOptions.HeaderParameters.Add("Accept", accept);


            requestOptions.PathParameters.Add("id", ClientUtils.ParameterToString(id)); // path parameter



            requestOptions.Data = personaUpdateByIdRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/persona/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaUpdateById", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
    }
}
