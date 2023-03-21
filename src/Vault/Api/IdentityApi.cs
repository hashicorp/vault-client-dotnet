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
        /// Update, read or delete an alias ID.
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
        VaultResponse<Object> AliasDeleteByID(string id, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> AliasListByID(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update, read or delete an alias ID.
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
        VaultResponse<Object> AliasReadByID(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Create a new alias.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasWriteRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AliasWrite(AliasWriteRequest aliasWriteRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update, read or delete an alias ID.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasWriteByIDRequest"></param>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> AliasWriteByID(string id, AliasWriteByIDRequest aliasWriteByIDRequest, TimeSpan? wrapTTL = null);

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
        /// Update, read or delete an alias ID.
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
        VaultResponse<Object> EntityDeleteAliasByID(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update, read or delete an entity using entity ID
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
        VaultResponse<Object> EntityDeleteByID(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update, read or delete an entity using entity name
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
        VaultResponse<Object> EntityListAliasesByID(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> EntityListByID(TimeSpan? wrapTTL = null);

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
        /// <param name="entityLookupRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityLookup(EntityLookupRequest entityLookupRequest, TimeSpan? wrapTTL = null);

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
        /// Update, read or delete an alias ID.
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
        VaultResponse<Object> EntityReadAliasByID(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update, read or delete an entity using entity ID
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
        VaultResponse<Object> EntityReadByID(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update, read or delete an entity using entity name
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
        /// Create a new entity
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityWrite(EntityWriteRequest entityWriteRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Create a new alias.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteAliasRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityWriteAlias(EntityWriteAliasRequest entityWriteAliasRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update, read or delete an alias ID.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteAliasByIDRequest"></param>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityWriteAliasByID(string id, EntityWriteAliasByIDRequest entityWriteAliasByIDRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update, read or delete an entity using entity ID
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteByIDRequest"></param>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityWriteByID(string id, EntityWriteByIDRequest entityWriteByIDRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update, read or delete an entity using entity name
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteByNameRequest"></param>
        /// <param name="name">Name of the entity</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> EntityWriteByName(string name, EntityWriteByNameRequest entityWriteByNameRequest, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> GroupDeleteAliasByID(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update or delete an existing group using its ID.
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
        VaultResponse<Object> GroupDeleteByID(string id, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> GroupListAliasesByID(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> GroupListByID(TimeSpan? wrapTTL = null);

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
        /// <param name="groupLookupRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupLookup(GroupLookupRequest groupLookupRequest, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> GroupReadAliasByID(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update or delete an existing group using its ID.
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
        VaultResponse<Object> GroupReadByID(string id, TimeSpan? wrapTTL = null);

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
        /// Create a new group.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupWrite(GroupWriteRequest groupWriteRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Creates a new group alias, or updates an existing one.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteAliasRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupWriteAlias(GroupWriteAliasRequest groupWriteAliasRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteAliasByIDRequest"></param>
        /// <param name="id">ID of the group alias.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupWriteAliasByID(string id, GroupWriteAliasByIDRequest groupWriteAliasByIDRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update or delete an existing group using its ID.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteByIDRequest"></param>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupWriteByID(string id, GroupWriteByIDRequest groupWriteByIDRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteByNameRequest"></param>
        /// <param name="name">Name of the group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> GroupWriteByName(string name, GroupWriteByNameRequest groupWriteByNameRequest, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFADeleteLoginEnforcement(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFAListLoginEnforcements(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Destroys a TOTP secret for the given MFA method ID on the given entity
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodAdminDestroyTOTPRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MFAMethodAdminDestroyTOTP(MFAMethodAdminDestroyTOTPRequest mFAMethodAdminDestroyTOTPRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodAdminGenerateTOTPRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MFAMethodAdminGenerateTOTP(MFAMethodAdminGenerateTOTPRequest mFAMethodAdminGenerateTOTPRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete a configuration for the given MFA method
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
        VaultResponse<Object> MFAMethodDeleteDuo(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete a configuration for the given MFA method
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
        VaultResponse<Object> MFAMethodDeleteOkta(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete a configuration for the given MFA method
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
        VaultResponse<Object> MFAMethodDeletePingID(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Delete a configuration for the given MFA method
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
        VaultResponse<Object> MFAMethodDeleteTOTP(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodGenerateTOTPRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MFAMethodGenerateTOTP(MFAMethodGenerateTOTPRequest mFAMethodGenerateTOTPRequest, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFAMethodList(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFAMethodListDuo(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFAMethodListOkta(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFAMethodListPingID(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFAMethodListTOTP(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFAMethodRead(string methodId, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFAMethodReadDuo(string methodId, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFAMethodReadOkta(string methodId, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFAMethodReadPingID(string methodId, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFAMethodReadTOTP(string methodId, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update or create a configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWriteDuoRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MFAMethodWriteDuo(string methodId, MFAMethodWriteDuoRequest mFAMethodWriteDuoRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update or create a configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWriteOktaRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MFAMethodWriteOkta(string methodId, MFAMethodWriteOktaRequest mFAMethodWriteOktaRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update or create a configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWritePingIDRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MFAMethodWritePingID(string methodId, MFAMethodWritePingIDRequest mFAMethodWritePingIDRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update or create a configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWriteTOTPRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MFAMethodWriteTOTP(string methodId, MFAMethodWriteTOTPRequest mFAMethodWriteTOTPRequest, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> MFAReadLoginEnforcement(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Create or update a login enforcement
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAWriteLoginEnforcementRequest"></param>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> MFAWriteLoginEnforcement(string name, MFAWriteLoginEnforcementRequest mFAWriteLoginEnforcementRequest, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCDeleteAssignment(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCDeleteClient(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCDeleteKey(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCDeleteProvider(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCDeleteRole(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCDeleteScope(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Verify the authenticity of an OIDC token
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCIntrospectRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OIDCIntrospect(OIDCIntrospectRequest oIDCIntrospectRequest, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCListAssignments(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCListClients(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCListKeys(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCListProviders(string allowedClientId = default(string), TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCListRoles(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCListScopes(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadAssignment(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadClient(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// OIDC configuration
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
        VaultResponse<Object> OIDCReadConfig(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadKey(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadProvider(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadProviderAuthorize(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadProviderUserInfo(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadProviderWellKnownKeys(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadProviderWellKnownOpenIDConfiguration(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadRole(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadScope(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadToken(string name, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadWellKnownKeys(TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCReadWellKnownOpenIDConfiguration(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Rotate a named OIDC key.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCRotateKeyRequest"></param>
        /// <param name="name">Name of the key</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OIDCRotateKey(string name, OIDCRotateKeyRequest oIDCRotateKeyRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteAssignmentRequest"></param>
        /// <param name="name">Name of the assignment</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OIDCWriteAssignment(string name, OIDCWriteAssignmentRequest oIDCWriteAssignmentRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteClientRequest"></param>
        /// <param name="name">Name of the client.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OIDCWriteClient(string name, OIDCWriteClientRequest oIDCWriteClientRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// OIDC configuration
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteConfigRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OIDCWriteConfig(OIDCWriteConfigRequest oIDCWriteConfigRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// CRUD operations for OIDC keys.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteKeyRequest"></param>
        /// <param name="name">Name of the key</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OIDCWriteKey(string name, OIDCWriteKeyRequest oIDCWriteKeyRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteProviderRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OIDCWriteProvider(string name, OIDCWriteProviderRequest oIDCWriteProviderRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteProviderAuthorizeRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OIDCWriteProviderAuthorize(string name, OIDCWriteProviderAuthorizeRequest oIDCWriteProviderAuthorizeRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteProviderTokenRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OIDCWriteProviderToken(string name, OIDCWriteProviderTokenRequest oIDCWriteProviderTokenRequest, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> OIDCWriteProviderUserInfo(string name, TimeSpan? wrapTTL = null);

        /// <summary>
        /// CRUD operations on OIDC Roles
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteRoleRequest"></param>
        /// <param name="name">Name of the role</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OIDCWriteRole(string name, OIDCWriteRoleRequest oIDCWriteRoleRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteScopeRequest"></param>
        /// <param name="name">Name of the scope</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> OIDCWriteScope(string name, OIDCWriteScopeRequest oIDCWriteScopeRequest, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update, read or delete an alias ID.
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
        VaultResponse<Object> PersonaIDDeleteByID(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update, read or delete an alias ID.
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
        VaultResponse<Object> PersonaIDReadByID(string id, TimeSpan? wrapTTL = null);

        /// <summary>
        /// Update, read or delete an alias ID.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaIDWriteByIDRequest"></param>
        /// <param name="id">ID of the persona</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PersonaIDWriteByID(string id, PersonaIDWriteByIDRequest personaIDWriteByIDRequest, TimeSpan? wrapTTL = null);

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
        VaultResponse<Object> PersonaListByID(TimeSpan? wrapTTL = null);

        /// <summary>
        /// Create a new alias.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaWriteRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        VaultResponse<Object> PersonaWrite(PersonaWriteRequest personaWriteRequest, TimeSpan? wrapTTL = null);

        #endregion Synchronous Operations
    }


    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IIdentityAsync : IApiAccessor
    {
        #region Asynchronous Operations

        /// <summary>
        /// Update, read or delete an alias ID.
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
        Task<VaultResponse<Object>> AliasDeleteByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> AliasListByIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update, read or delete an alias ID.
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
        Task<VaultResponse<Object>> AliasReadByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a new alias.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasWriteRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> AliasWriteAsync(AliasWriteRequest aliasWriteRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update, read or delete an alias ID.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasWriteByIDRequest"></param>
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
        Task<VaultResponse<Object>> AliasWriteByIDAsync(string id, AliasWriteByIDRequest aliasWriteByIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Update, read or delete an alias ID.
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
        Task<VaultResponse<Object>> EntityDeleteAliasByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update, read or delete an entity using entity ID
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
        Task<VaultResponse<Object>> EntityDeleteByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update, read or delete an entity using entity name
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
        Task<VaultResponse<Object>> EntityListAliasesByIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> EntityListByIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="entityLookupRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityLookupAsync(EntityLookupRequest entityLookupRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Update, read or delete an alias ID.
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
        Task<VaultResponse<Object>> EntityReadAliasByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update, read or delete an entity using entity ID
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
        Task<VaultResponse<Object>> EntityReadByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update, read or delete an entity using entity name
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
        /// Create a new entity
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityWriteAsync(EntityWriteRequest entityWriteRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a new alias.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteAliasRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> EntityWriteAliasAsync(EntityWriteAliasRequest entityWriteAliasRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update, read or delete an alias ID.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteAliasByIDRequest"></param>
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
        Task<VaultResponse<Object>> EntityWriteAliasByIDAsync(string id, EntityWriteAliasByIDRequest entityWriteAliasByIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update, read or delete an entity using entity ID
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteByIDRequest"></param>
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
        Task<VaultResponse<Object>> EntityWriteByIDAsync(string id, EntityWriteByIDRequest entityWriteByIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update, read or delete an entity using entity name
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteByNameRequest"></param>
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
        Task<VaultResponse<Object>> EntityWriteByNameAsync(string name, EntityWriteByNameRequest entityWriteByNameRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> GroupDeleteAliasByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update or delete an existing group using its ID.
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
        Task<VaultResponse<Object>> GroupDeleteByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> GroupListAliasesByIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> GroupListByIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <param name="groupLookupRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupLookupAsync(GroupLookupRequest groupLookupRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> GroupReadAliasByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update or delete an existing group using its ID.
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
        Task<VaultResponse<Object>> GroupReadByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Create a new group.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupWriteAsync(GroupWriteRequest groupWriteRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Creates a new group alias, or updates an existing one.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteAliasRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> GroupWriteAliasAsync(GroupWriteAliasRequest groupWriteAliasRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteAliasByIDRequest"></param>
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
        Task<VaultResponse<Object>> GroupWriteAliasByIDAsync(string id, GroupWriteAliasByIDRequest groupWriteAliasByIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update or delete an existing group using its ID.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteByIDRequest"></param>
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
        Task<VaultResponse<Object>> GroupWriteByIDAsync(string id, GroupWriteByIDRequest groupWriteByIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteByNameRequest"></param>
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
        Task<VaultResponse<Object>> GroupWriteByNameAsync(string name, GroupWriteByNameRequest groupWriteByNameRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFADeleteLoginEnforcementAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFAListLoginEnforcementsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Destroys a TOTP secret for the given MFA method ID on the given entity
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodAdminDestroyTOTPRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MFAMethodAdminDestroyTOTPAsync(MFAMethodAdminDestroyTOTPRequest mFAMethodAdminDestroyTOTPRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodAdminGenerateTOTPRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MFAMethodAdminGenerateTOTPAsync(MFAMethodAdminGenerateTOTPRequest mFAMethodAdminGenerateTOTPRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete a configuration for the given MFA method
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
        Task<VaultResponse<Object>> MFAMethodDeleteDuoAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete a configuration for the given MFA method
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
        Task<VaultResponse<Object>> MFAMethodDeleteOktaAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete a configuration for the given MFA method
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
        Task<VaultResponse<Object>> MFAMethodDeletePingIDAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Delete a configuration for the given MFA method
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
        Task<VaultResponse<Object>> MFAMethodDeleteTOTPAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodGenerateTOTPRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> MFAMethodGenerateTOTPAsync(MFAMethodGenerateTOTPRequest mFAMethodGenerateTOTPRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFAMethodListAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFAMethodListDuoAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFAMethodListOktaAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFAMethodListPingIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFAMethodListTOTPAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFAMethodReadAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFAMethodReadDuoAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFAMethodReadOktaAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFAMethodReadPingIDAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFAMethodReadTOTPAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update or create a configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWriteDuoRequest"></param>
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
        Task<VaultResponse<Object>> MFAMethodWriteDuoAsync(string methodId, MFAMethodWriteDuoRequest mFAMethodWriteDuoRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update or create a configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWriteOktaRequest"></param>
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
        Task<VaultResponse<Object>> MFAMethodWriteOktaAsync(string methodId, MFAMethodWriteOktaRequest mFAMethodWriteOktaRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update or create a configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWritePingIDRequest"></param>
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
        Task<VaultResponse<Object>> MFAMethodWritePingIDAsync(string methodId, MFAMethodWritePingIDRequest mFAMethodWritePingIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update or create a configuration for the given MFA method
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWriteTOTPRequest"></param>
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
        Task<VaultResponse<Object>> MFAMethodWriteTOTPAsync(string methodId, MFAMethodWriteTOTPRequest mFAMethodWriteTOTPRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> MFAReadLoginEnforcementAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create or update a login enforcement
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAWriteLoginEnforcementRequest"></param>
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
        Task<VaultResponse<Object>> MFAWriteLoginEnforcementAsync(string name, MFAWriteLoginEnforcementRequest mFAWriteLoginEnforcementRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCDeleteAssignmentAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCDeleteClientAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCDeleteKeyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCDeleteProviderAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCDeleteRoleAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCDeleteScopeAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Verify the authenticity of an OIDC token
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCIntrospectRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OIDCIntrospectAsync(OIDCIntrospectRequest oIDCIntrospectRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCListAssignmentsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCListClientsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCListKeysAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCListProvidersAsync(string allowedClientId = default(string), TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCListRolesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCListScopesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadAssignmentAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadClientAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// OIDC configuration
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
        Task<VaultResponse<Object>> OIDCReadConfigAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadKeyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadProviderAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadProviderAuthorizeAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadProviderUserInfoAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadProviderWellKnownKeysAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadProviderWellKnownOpenIDConfigurationAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadRoleAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadScopeAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadTokenAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadWellKnownKeysAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCReadWellKnownOpenIDConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Rotate a named OIDC key.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCRotateKeyRequest"></param>
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
        Task<VaultResponse<Object>> OIDCRotateKeyAsync(string name, OIDCRotateKeyRequest oIDCRotateKeyRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteAssignmentRequest"></param>
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
        Task<VaultResponse<Object>> OIDCWriteAssignmentAsync(string name, OIDCWriteAssignmentRequest oIDCWriteAssignmentRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteClientRequest"></param>
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
        Task<VaultResponse<Object>> OIDCWriteClientAsync(string name, OIDCWriteClientRequest oIDCWriteClientRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// OIDC configuration
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteConfigRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> OIDCWriteConfigAsync(OIDCWriteConfigRequest oIDCWriteConfigRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// CRUD operations for OIDC keys.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteKeyRequest"></param>
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
        Task<VaultResponse<Object>> OIDCWriteKeyAsync(string name, OIDCWriteKeyRequest oIDCWriteKeyRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteProviderRequest"></param>
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
        Task<VaultResponse<Object>> OIDCWriteProviderAsync(string name, OIDCWriteProviderRequest oIDCWriteProviderRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteProviderAuthorizeRequest"></param>
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
        Task<VaultResponse<Object>> OIDCWriteProviderAuthorizeAsync(string name, OIDCWriteProviderAuthorizeRequest oIDCWriteProviderAuthorizeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteProviderTokenRequest"></param>
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
        Task<VaultResponse<Object>> OIDCWriteProviderTokenAsync(string name, OIDCWriteProviderTokenRequest oIDCWriteProviderTokenRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> OIDCWriteProviderUserInfoAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// CRUD operations on OIDC Roles
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteRoleRequest"></param>
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
        Task<VaultResponse<Object>> OIDCWriteRoleAsync(string name, OIDCWriteRoleRequest oIDCWriteRoleRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteScopeRequest"></param>
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
        Task<VaultResponse<Object>> OIDCWriteScopeAsync(string name, OIDCWriteScopeRequest oIDCWriteScopeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update, read or delete an alias ID.
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
        Task<VaultResponse<Object>> PersonaIDDeleteByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update, read or delete an alias ID.
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
        Task<VaultResponse<Object>> PersonaIDReadByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Update, read or delete an alias ID.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaIDWriteByIDRequest"></param>
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
        Task<VaultResponse<Object>> PersonaIDWriteByIDAsync(string id, PersonaIDWriteByIDRequest personaIDWriteByIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        Task<VaultResponse<Object>> PersonaListByIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// Create a new alias.
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaWriteRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        Task<VaultResponse<Object>> PersonaWriteAsync(PersonaWriteRequest personaWriteRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Update, read or delete an alias ID. 
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
        public VaultResponse<Object> AliasDeleteByID(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->AliasDeleteByID");


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
                Exception exception = this.ExceptionFactory("AliasDeleteByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an alias ID. 
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
        public async Task<VaultResponse<Object>> AliasDeleteByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->AliasDeleteByID");



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
                Exception exception = this.ExceptionFactory("AliasDeleteByID", response);
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
        public VaultResponse<Object> AliasListByID(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("AliasListByID", response);
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
        public async Task<VaultResponse<Object>> AliasListByIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("AliasListByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update, read or delete an alias ID. 
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
        public VaultResponse<Object> AliasReadByID(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->AliasReadByID");


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
                Exception exception = this.ExceptionFactory("AliasReadByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an alias ID. 
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
        public async Task<VaultResponse<Object>> AliasReadByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->AliasReadByID");



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
                Exception exception = this.ExceptionFactory("AliasReadByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Create a new alias. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasWriteRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AliasWrite(AliasWriteRequest aliasWriteRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'aliasWriteRequest' is set
            if (aliasWriteRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'aliasWriteRequest' when calling Identity->AliasWrite");

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





            requestOptions.Data = aliasWriteRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/alias", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasWrite", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create a new alias. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasWriteRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> AliasWriteAsync(AliasWriteRequest aliasWriteRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'aliasWriteRequest' is set
            if (aliasWriteRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'aliasWriteRequest' when calling Identity->AliasWrite");


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



            requestOptions.Data = aliasWriteRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/alias", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasWrite", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update, read or delete an alias ID. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasWriteByIDRequest"></param>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> AliasWriteByID(string id, AliasWriteByIDRequest aliasWriteByIDRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->AliasWriteByID");


            // verify the required parameter 'aliasWriteByIDRequest' is set
            if (aliasWriteByIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'aliasWriteByIDRequest' when calling Identity->AliasWriteByID");

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





            requestOptions.Data = aliasWriteByIDRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/alias/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasWriteByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an alias ID. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="aliasWriteByIDRequest"></param>
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
        public async Task<VaultResponse<Object>> AliasWriteByIDAsync(string id, AliasWriteByIDRequest aliasWriteByIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->AliasWriteByID");


            // verify the required parameter 'aliasWriteByIDRequest' is set
            if (aliasWriteByIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'aliasWriteByIDRequest' when calling Identity->AliasWriteByID");


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



            requestOptions.Data = aliasWriteByIDRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/alias/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("AliasWriteByID", response);
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
        /// Update, read or delete an alias ID. 
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
        public VaultResponse<Object> EntityDeleteAliasByID(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityDeleteAliasByID");


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
                Exception exception = this.ExceptionFactory("EntityDeleteAliasByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an alias ID. 
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
        public async Task<VaultResponse<Object>> EntityDeleteAliasByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityDeleteAliasByID");



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
                Exception exception = this.ExceptionFactory("EntityDeleteAliasByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update, read or delete an entity using entity ID 
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
        public VaultResponse<Object> EntityDeleteByID(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityDeleteByID");


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
                Exception exception = this.ExceptionFactory("EntityDeleteByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an entity using entity ID 
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
        public async Task<VaultResponse<Object>> EntityDeleteByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityDeleteByID");



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
                Exception exception = this.ExceptionFactory("EntityDeleteByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update, read or delete an entity using entity name 
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
        /// Update, read or delete an entity using entity name 
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
        public VaultResponse<Object> EntityListAliasesByID(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("EntityListAliasesByID", response);
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
        public async Task<VaultResponse<Object>> EntityListAliasesByIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("EntityListAliasesByID", response);
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
        public VaultResponse<Object> EntityListByID(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("EntityListByID", response);
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
        public async Task<VaultResponse<Object>> EntityListByIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("EntityListByID", response);
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
        /// <param name="entityLookupRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityLookup(EntityLookupRequest entityLookupRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'entityLookupRequest' is set
            if (entityLookupRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityLookupRequest' when calling Identity->EntityLookup");

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





            requestOptions.Data = entityLookupRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/lookup/entity", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityLookup", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Query entities based on various properties. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityLookupRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityLookupAsync(EntityLookupRequest entityLookupRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'entityLookupRequest' is set
            if (entityLookupRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityLookupRequest' when calling Identity->EntityLookup");


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



            requestOptions.Data = entityLookupRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/lookup/entity", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityLookup", response);
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
        /// Update, read or delete an alias ID. 
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
        public VaultResponse<Object> EntityReadAliasByID(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityReadAliasByID");


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
                Exception exception = this.ExceptionFactory("EntityReadAliasByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an alias ID. 
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
        public async Task<VaultResponse<Object>> EntityReadAliasByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityReadAliasByID");



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
                Exception exception = this.ExceptionFactory("EntityReadAliasByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update, read or delete an entity using entity ID 
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
        public VaultResponse<Object> EntityReadByID(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityReadByID");


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
                Exception exception = this.ExceptionFactory("EntityReadByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an entity using entity ID 
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
        public async Task<VaultResponse<Object>> EntityReadByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityReadByID");



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
                Exception exception = this.ExceptionFactory("EntityReadByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update, read or delete an entity using entity name 
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
        /// Update, read or delete an entity using entity name 
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
        /// Create a new entity 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityWrite(EntityWriteRequest entityWriteRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'entityWriteRequest' is set
            if (entityWriteRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityWriteRequest' when calling Identity->EntityWrite");

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





            requestOptions.Data = entityWriteRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/entity", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityWrite", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create a new entity 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityWriteAsync(EntityWriteRequest entityWriteRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'entityWriteRequest' is set
            if (entityWriteRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityWriteRequest' when calling Identity->EntityWrite");


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



            requestOptions.Data = entityWriteRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/entity", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityWrite", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Create a new alias. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteAliasRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityWriteAlias(EntityWriteAliasRequest entityWriteAliasRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'entityWriteAliasRequest' is set
            if (entityWriteAliasRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityWriteAliasRequest' when calling Identity->EntityWriteAlias");

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





            requestOptions.Data = entityWriteAliasRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/entity-alias", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityWriteAlias", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create a new alias. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteAliasRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> EntityWriteAliasAsync(EntityWriteAliasRequest entityWriteAliasRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'entityWriteAliasRequest' is set
            if (entityWriteAliasRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityWriteAliasRequest' when calling Identity->EntityWriteAlias");


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



            requestOptions.Data = entityWriteAliasRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/entity-alias", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityWriteAlias", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update, read or delete an alias ID. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteAliasByIDRequest"></param>
        /// <param name="id">ID of the alias</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityWriteAliasByID(string id, EntityWriteAliasByIDRequest entityWriteAliasByIDRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityWriteAliasByID");


            // verify the required parameter 'entityWriteAliasByIDRequest' is set
            if (entityWriteAliasByIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityWriteAliasByIDRequest' when calling Identity->EntityWriteAliasByID");

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





            requestOptions.Data = entityWriteAliasByIDRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/entity-alias/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityWriteAliasByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an alias ID. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteAliasByIDRequest"></param>
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
        public async Task<VaultResponse<Object>> EntityWriteAliasByIDAsync(string id, EntityWriteAliasByIDRequest entityWriteAliasByIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityWriteAliasByID");


            // verify the required parameter 'entityWriteAliasByIDRequest' is set
            if (entityWriteAliasByIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityWriteAliasByIDRequest' when calling Identity->EntityWriteAliasByID");


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



            requestOptions.Data = entityWriteAliasByIDRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/entity-alias/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityWriteAliasByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update, read or delete an entity using entity ID 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteByIDRequest"></param>
        /// <param name="id">ID of the entity. If set, updates the corresponding existing entity.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityWriteByID(string id, EntityWriteByIDRequest entityWriteByIDRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityWriteByID");


            // verify the required parameter 'entityWriteByIDRequest' is set
            if (entityWriteByIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityWriteByIDRequest' when calling Identity->EntityWriteByID");

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





            requestOptions.Data = entityWriteByIDRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/entity/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityWriteByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an entity using entity ID 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteByIDRequest"></param>
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
        public async Task<VaultResponse<Object>> EntityWriteByIDAsync(string id, EntityWriteByIDRequest entityWriteByIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->EntityWriteByID");


            // verify the required parameter 'entityWriteByIDRequest' is set
            if (entityWriteByIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityWriteByIDRequest' when calling Identity->EntityWriteByID");


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



            requestOptions.Data = entityWriteByIDRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/entity/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityWriteByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update, read or delete an entity using entity name 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteByNameRequest"></param>
        /// <param name="name">Name of the entity</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> EntityWriteByName(string name, EntityWriteByNameRequest entityWriteByNameRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->EntityWriteByName");


            // verify the required parameter 'entityWriteByNameRequest' is set
            if (entityWriteByNameRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityWriteByNameRequest' when calling Identity->EntityWriteByName");

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





            requestOptions.Data = entityWriteByNameRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/entity/name/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityWriteByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an entity using entity name 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="entityWriteByNameRequest"></param>
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
        public async Task<VaultResponse<Object>> EntityWriteByNameAsync(string name, EntityWriteByNameRequest entityWriteByNameRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->EntityWriteByName");


            // verify the required parameter 'entityWriteByNameRequest' is set
            if (entityWriteByNameRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'entityWriteByNameRequest' when calling Identity->EntityWriteByName");


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



            requestOptions.Data = entityWriteByNameRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/entity/name/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("EntityWriteByName", response);
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
        public VaultResponse<Object> GroupDeleteAliasByID(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupDeleteAliasByID");


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
                Exception exception = this.ExceptionFactory("GroupDeleteAliasByID", response);
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
        public async Task<VaultResponse<Object>> GroupDeleteAliasByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupDeleteAliasByID");



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
                Exception exception = this.ExceptionFactory("GroupDeleteAliasByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update or delete an existing group using its ID. 
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
        public VaultResponse<Object> GroupDeleteByID(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupDeleteByID");


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
                Exception exception = this.ExceptionFactory("GroupDeleteByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update or delete an existing group using its ID. 
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
        public async Task<VaultResponse<Object>> GroupDeleteByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupDeleteByID");



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
                Exception exception = this.ExceptionFactory("GroupDeleteByID", response);
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
        public VaultResponse<Object> GroupListAliasesByID(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("GroupListAliasesByID", response);
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
        public async Task<VaultResponse<Object>> GroupListAliasesByIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("GroupListAliasesByID", response);
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
        public VaultResponse<Object> GroupListByID(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("GroupListByID", response);
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
        public async Task<VaultResponse<Object>> GroupListByIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("GroupListByID", response);
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
        /// <param name="groupLookupRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupLookup(GroupLookupRequest groupLookupRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'groupLookupRequest' is set
            if (groupLookupRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupLookupRequest' when calling Identity->GroupLookup");

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





            requestOptions.Data = groupLookupRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/lookup/group", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupLookup", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Query groups based on various properties. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupLookupRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupLookupAsync(GroupLookupRequest groupLookupRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'groupLookupRequest' is set
            if (groupLookupRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupLookupRequest' when calling Identity->GroupLookup");


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



            requestOptions.Data = groupLookupRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/lookup/group", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupLookup", response);
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
        public VaultResponse<Object> GroupReadAliasByID(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupReadAliasByID");


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
                Exception exception = this.ExceptionFactory("GroupReadAliasByID", response);
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
        public async Task<VaultResponse<Object>> GroupReadAliasByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupReadAliasByID");



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
                Exception exception = this.ExceptionFactory("GroupReadAliasByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update or delete an existing group using its ID. 
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
        public VaultResponse<Object> GroupReadByID(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupReadByID");


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
                Exception exception = this.ExceptionFactory("GroupReadByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update or delete an existing group using its ID. 
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
        public async Task<VaultResponse<Object>> GroupReadByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupReadByID");



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
                Exception exception = this.ExceptionFactory("GroupReadByID", response);
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
        /// Create a new group. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupWrite(GroupWriteRequest groupWriteRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'groupWriteRequest' is set
            if (groupWriteRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupWriteRequest' when calling Identity->GroupWrite");

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





            requestOptions.Data = groupWriteRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/group", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupWrite", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create a new group. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupWriteAsync(GroupWriteRequest groupWriteRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'groupWriteRequest' is set
            if (groupWriteRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupWriteRequest' when calling Identity->GroupWrite");


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



            requestOptions.Data = groupWriteRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/group", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupWrite", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Creates a new group alias, or updates an existing one. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteAliasRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupWriteAlias(GroupWriteAliasRequest groupWriteAliasRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'groupWriteAliasRequest' is set
            if (groupWriteAliasRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupWriteAliasRequest' when calling Identity->GroupWriteAlias");

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





            requestOptions.Data = groupWriteAliasRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/group-alias", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupWriteAlias", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Creates a new group alias, or updates an existing one. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteAliasRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> GroupWriteAliasAsync(GroupWriteAliasRequest groupWriteAliasRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'groupWriteAliasRequest' is set
            if (groupWriteAliasRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupWriteAliasRequest' when calling Identity->GroupWriteAlias");


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



            requestOptions.Data = groupWriteAliasRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/group-alias", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupWriteAlias", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteAliasByIDRequest"></param>
        /// <param name="id">ID of the group alias.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupWriteAliasByID(string id, GroupWriteAliasByIDRequest groupWriteAliasByIDRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupWriteAliasByID");


            // verify the required parameter 'groupWriteAliasByIDRequest' is set
            if (groupWriteAliasByIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupWriteAliasByIDRequest' when calling Identity->GroupWriteAliasByID");

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





            requestOptions.Data = groupWriteAliasByIDRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/group-alias/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupWriteAliasByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteAliasByIDRequest"></param>
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
        public async Task<VaultResponse<Object>> GroupWriteAliasByIDAsync(string id, GroupWriteAliasByIDRequest groupWriteAliasByIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupWriteAliasByID");


            // verify the required parameter 'groupWriteAliasByIDRequest' is set
            if (groupWriteAliasByIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupWriteAliasByIDRequest' when calling Identity->GroupWriteAliasByID");


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



            requestOptions.Data = groupWriteAliasByIDRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/group-alias/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupWriteAliasByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update or delete an existing group using its ID. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteByIDRequest"></param>
        /// <param name="id">ID of the group. If set, updates the corresponding existing group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupWriteByID(string id, GroupWriteByIDRequest groupWriteByIDRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupWriteByID");


            // verify the required parameter 'groupWriteByIDRequest' is set
            if (groupWriteByIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupWriteByIDRequest' when calling Identity->GroupWriteByID");

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





            requestOptions.Data = groupWriteByIDRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/group/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupWriteByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update or delete an existing group using its ID. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteByIDRequest"></param>
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
        public async Task<VaultResponse<Object>> GroupWriteByIDAsync(string id, GroupWriteByIDRequest groupWriteByIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->GroupWriteByID");


            // verify the required parameter 'groupWriteByIDRequest' is set
            if (groupWriteByIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupWriteByIDRequest' when calling Identity->GroupWriteByID");


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



            requestOptions.Data = groupWriteByIDRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/group/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupWriteByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteByNameRequest"></param>
        /// <param name="name">Name of the group.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> GroupWriteByName(string name, GroupWriteByNameRequest groupWriteByNameRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->GroupWriteByName");


            // verify the required parameter 'groupWriteByNameRequest' is set
            if (groupWriteByNameRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupWriteByNameRequest' when calling Identity->GroupWriteByName");

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





            requestOptions.Data = groupWriteByNameRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/group/name/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupWriteByName", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="groupWriteByNameRequest"></param>
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
        public async Task<VaultResponse<Object>> GroupWriteByNameAsync(string name, GroupWriteByNameRequest groupWriteByNameRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->GroupWriteByName");


            // verify the required parameter 'groupWriteByNameRequest' is set
            if (groupWriteByNameRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'groupWriteByNameRequest' when calling Identity->GroupWriteByName");


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



            requestOptions.Data = groupWriteByNameRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/group/name/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("GroupWriteByName", response);
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
        public VaultResponse<Object> MFADeleteLoginEnforcement(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->MFADeleteLoginEnforcement");


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
                Exception exception = this.ExceptionFactory("MFADeleteLoginEnforcement", response);
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
        public async Task<VaultResponse<Object>> MFADeleteLoginEnforcementAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->MFADeleteLoginEnforcement");



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
                Exception exception = this.ExceptionFactory("MFADeleteLoginEnforcement", response);
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
        public VaultResponse<Object> MFAListLoginEnforcements(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("MFAListLoginEnforcements", response);
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
        public async Task<VaultResponse<Object>> MFAListLoginEnforcementsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("MFAListLoginEnforcements", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Destroys a TOTP secret for the given MFA method ID on the given entity 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodAdminDestroyTOTPRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MFAMethodAdminDestroyTOTP(MFAMethodAdminDestroyTOTPRequest mFAMethodAdminDestroyTOTPRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'mFAMethodAdminDestroyTOTPRequest' is set
            if (mFAMethodAdminDestroyTOTPRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodAdminDestroyTOTPRequest' when calling Identity->MFAMethodAdminDestroyTOTP");

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





            requestOptions.Data = mFAMethodAdminDestroyTOTPRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/totp/admin-destroy", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodAdminDestroyTOTP", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Destroys a TOTP secret for the given MFA method ID on the given entity 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodAdminDestroyTOTPRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MFAMethodAdminDestroyTOTPAsync(MFAMethodAdminDestroyTOTPRequest mFAMethodAdminDestroyTOTPRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'mFAMethodAdminDestroyTOTPRequest' is set
            if (mFAMethodAdminDestroyTOTPRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodAdminDestroyTOTPRequest' when calling Identity->MFAMethodAdminDestroyTOTP");


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



            requestOptions.Data = mFAMethodAdminDestroyTOTPRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/totp/admin-destroy", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodAdminDestroyTOTP", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodAdminGenerateTOTPRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MFAMethodAdminGenerateTOTP(MFAMethodAdminGenerateTOTPRequest mFAMethodAdminGenerateTOTPRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'mFAMethodAdminGenerateTOTPRequest' is set
            if (mFAMethodAdminGenerateTOTPRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodAdminGenerateTOTPRequest' when calling Identity->MFAMethodAdminGenerateTOTP");

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





            requestOptions.Data = mFAMethodAdminGenerateTOTPRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/totp/admin-generate", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodAdminGenerateTOTP", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodAdminGenerateTOTPRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MFAMethodAdminGenerateTOTPAsync(MFAMethodAdminGenerateTOTPRequest mFAMethodAdminGenerateTOTPRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'mFAMethodAdminGenerateTOTPRequest' is set
            if (mFAMethodAdminGenerateTOTPRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodAdminGenerateTOTPRequest' when calling Identity->MFAMethodAdminGenerateTOTP");


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



            requestOptions.Data = mFAMethodAdminGenerateTOTPRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/totp/admin-generate", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodAdminGenerateTOTP", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Delete a configuration for the given MFA method 
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
        public VaultResponse<Object> MFAMethodDeleteDuo(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodDeleteDuo");


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
                Exception exception = this.ExceptionFactory("MFAMethodDeleteDuo", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete a configuration for the given MFA method 
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
        public async Task<VaultResponse<Object>> MFAMethodDeleteDuoAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodDeleteDuo");



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
                Exception exception = this.ExceptionFactory("MFAMethodDeleteDuo", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Delete a configuration for the given MFA method 
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
        public VaultResponse<Object> MFAMethodDeleteOkta(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodDeleteOkta");


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
                Exception exception = this.ExceptionFactory("MFAMethodDeleteOkta", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete a configuration for the given MFA method 
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
        public async Task<VaultResponse<Object>> MFAMethodDeleteOktaAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodDeleteOkta");



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
                Exception exception = this.ExceptionFactory("MFAMethodDeleteOkta", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Delete a configuration for the given MFA method 
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
        public VaultResponse<Object> MFAMethodDeletePingID(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodDeletePingID");


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
                Exception exception = this.ExceptionFactory("MFAMethodDeletePingID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete a configuration for the given MFA method 
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
        public async Task<VaultResponse<Object>> MFAMethodDeletePingIDAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodDeletePingID");



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
                Exception exception = this.ExceptionFactory("MFAMethodDeletePingID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Delete a configuration for the given MFA method 
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
        public VaultResponse<Object> MFAMethodDeleteTOTP(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodDeleteTOTP");


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
                Exception exception = this.ExceptionFactory("MFAMethodDeleteTOTP", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Delete a configuration for the given MFA method 
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
        public async Task<VaultResponse<Object>> MFAMethodDeleteTOTPAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodDeleteTOTP");



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
                Exception exception = this.ExceptionFactory("MFAMethodDeleteTOTP", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodGenerateTOTPRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MFAMethodGenerateTOTP(MFAMethodGenerateTOTPRequest mFAMethodGenerateTOTPRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'mFAMethodGenerateTOTPRequest' is set
            if (mFAMethodGenerateTOTPRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodGenerateTOTPRequest' when calling Identity->MFAMethodGenerateTOTP");

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





            requestOptions.Data = mFAMethodGenerateTOTPRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/totp/generate", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodGenerateTOTP", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update or create TOTP secret for the given method ID on the given entity. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodGenerateTOTPRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> MFAMethodGenerateTOTPAsync(MFAMethodGenerateTOTPRequest mFAMethodGenerateTOTPRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'mFAMethodGenerateTOTPRequest' is set
            if (mFAMethodGenerateTOTPRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodGenerateTOTPRequest' when calling Identity->MFAMethodGenerateTOTP");


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



            requestOptions.Data = mFAMethodGenerateTOTPRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/totp/generate", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodGenerateTOTP", response);
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
        public VaultResponse<Object> MFAMethodList(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("MFAMethodList", response);
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
        public async Task<VaultResponse<Object>> MFAMethodListAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("MFAMethodList", response);
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
        public VaultResponse<Object> MFAMethodListDuo(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("MFAMethodListDuo", response);
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
        public async Task<VaultResponse<Object>> MFAMethodListDuoAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("MFAMethodListDuo", response);
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
        public VaultResponse<Object> MFAMethodListOkta(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("MFAMethodListOkta", response);
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
        public async Task<VaultResponse<Object>> MFAMethodListOktaAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("MFAMethodListOkta", response);
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
        public VaultResponse<Object> MFAMethodListPingID(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("MFAMethodListPingID", response);
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
        public async Task<VaultResponse<Object>> MFAMethodListPingIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("MFAMethodListPingID", response);
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
        public VaultResponse<Object> MFAMethodListTOTP(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("MFAMethodListTOTP", response);
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
        public async Task<VaultResponse<Object>> MFAMethodListTOTPAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("MFAMethodListTOTP", response);
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
        public VaultResponse<Object> MFAMethodRead(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodRead");


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
                Exception exception = this.ExceptionFactory("MFAMethodRead", response);
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
        public async Task<VaultResponse<Object>> MFAMethodReadAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodRead");



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
                Exception exception = this.ExceptionFactory("MFAMethodRead", response);
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
        public VaultResponse<Object> MFAMethodReadDuo(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodReadDuo");


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
                Exception exception = this.ExceptionFactory("MFAMethodReadDuo", response);
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
        public async Task<VaultResponse<Object>> MFAMethodReadDuoAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodReadDuo");



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
                Exception exception = this.ExceptionFactory("MFAMethodReadDuo", response);
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
        public VaultResponse<Object> MFAMethodReadOkta(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodReadOkta");


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
                Exception exception = this.ExceptionFactory("MFAMethodReadOkta", response);
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
        public async Task<VaultResponse<Object>> MFAMethodReadOktaAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodReadOkta");



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
                Exception exception = this.ExceptionFactory("MFAMethodReadOkta", response);
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
        public VaultResponse<Object> MFAMethodReadPingID(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodReadPingID");


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
                Exception exception = this.ExceptionFactory("MFAMethodReadPingID", response);
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
        public async Task<VaultResponse<Object>> MFAMethodReadPingIDAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodReadPingID");



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
                Exception exception = this.ExceptionFactory("MFAMethodReadPingID", response);
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
        public VaultResponse<Object> MFAMethodReadTOTP(string methodId, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodReadTOTP");


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
                Exception exception = this.ExceptionFactory("MFAMethodReadTOTP", response);
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
        public async Task<VaultResponse<Object>> MFAMethodReadTOTPAsync(string methodId, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodReadTOTP");



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
                Exception exception = this.ExceptionFactory("MFAMethodReadTOTP", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update or create a configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWriteDuoRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MFAMethodWriteDuo(string methodId, MFAMethodWriteDuoRequest mFAMethodWriteDuoRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodWriteDuo");


            // verify the required parameter 'mFAMethodWriteDuoRequest' is set
            if (mFAMethodWriteDuoRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodWriteDuoRequest' when calling Identity->MFAMethodWriteDuo");

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





            requestOptions.Data = mFAMethodWriteDuoRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/duo/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodWriteDuo", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update or create a configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWriteDuoRequest"></param>
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
        public async Task<VaultResponse<Object>> MFAMethodWriteDuoAsync(string methodId, MFAMethodWriteDuoRequest mFAMethodWriteDuoRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodWriteDuo");


            // verify the required parameter 'mFAMethodWriteDuoRequest' is set
            if (mFAMethodWriteDuoRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodWriteDuoRequest' when calling Identity->MFAMethodWriteDuo");


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



            requestOptions.Data = mFAMethodWriteDuoRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/duo/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodWriteDuo", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update or create a configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWriteOktaRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MFAMethodWriteOkta(string methodId, MFAMethodWriteOktaRequest mFAMethodWriteOktaRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodWriteOkta");


            // verify the required parameter 'mFAMethodWriteOktaRequest' is set
            if (mFAMethodWriteOktaRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodWriteOktaRequest' when calling Identity->MFAMethodWriteOkta");

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





            requestOptions.Data = mFAMethodWriteOktaRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/okta/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodWriteOkta", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update or create a configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWriteOktaRequest"></param>
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
        public async Task<VaultResponse<Object>> MFAMethodWriteOktaAsync(string methodId, MFAMethodWriteOktaRequest mFAMethodWriteOktaRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodWriteOkta");


            // verify the required parameter 'mFAMethodWriteOktaRequest' is set
            if (mFAMethodWriteOktaRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodWriteOktaRequest' when calling Identity->MFAMethodWriteOkta");


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



            requestOptions.Data = mFAMethodWriteOktaRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/okta/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodWriteOkta", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update or create a configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWritePingIDRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MFAMethodWritePingID(string methodId, MFAMethodWritePingIDRequest mFAMethodWritePingIDRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodWritePingID");


            // verify the required parameter 'mFAMethodWritePingIDRequest' is set
            if (mFAMethodWritePingIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodWritePingIDRequest' when calling Identity->MFAMethodWritePingID");

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





            requestOptions.Data = mFAMethodWritePingIDRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/pingid/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodWritePingID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update or create a configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWritePingIDRequest"></param>
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
        public async Task<VaultResponse<Object>> MFAMethodWritePingIDAsync(string methodId, MFAMethodWritePingIDRequest mFAMethodWritePingIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodWritePingID");


            // verify the required parameter 'mFAMethodWritePingIDRequest' is set
            if (mFAMethodWritePingIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodWritePingIDRequest' when calling Identity->MFAMethodWritePingID");


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



            requestOptions.Data = mFAMethodWritePingIDRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/pingid/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodWritePingID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update or create a configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWriteTOTPRequest"></param>
        /// <param name="methodId">The unique identifier for this MFA method.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MFAMethodWriteTOTP(string methodId, MFAMethodWriteTOTPRequest mFAMethodWriteTOTPRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodWriteTOTP");


            // verify the required parameter 'mFAMethodWriteTOTPRequest' is set
            if (mFAMethodWriteTOTPRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodWriteTOTPRequest' when calling Identity->MFAMethodWriteTOTP");

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





            requestOptions.Data = mFAMethodWriteTOTPRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/method/totp/{method_id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodWriteTOTP", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update or create a configuration for the given MFA method 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAMethodWriteTOTPRequest"></param>
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
        public async Task<VaultResponse<Object>> MFAMethodWriteTOTPAsync(string methodId, MFAMethodWriteTOTPRequest mFAMethodWriteTOTPRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'methodId' is set
            if (methodId == null)
                throw new VaultApiException(400, "Missing required parameter 'methodId' when calling Identity->MFAMethodWriteTOTP");


            // verify the required parameter 'mFAMethodWriteTOTPRequest' is set
            if (mFAMethodWriteTOTPRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAMethodWriteTOTPRequest' when calling Identity->MFAMethodWriteTOTP");


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



            requestOptions.Data = mFAMethodWriteTOTPRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/method/totp/{method_id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAMethodWriteTOTP", response);
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
        public VaultResponse<Object> MFAReadLoginEnforcement(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->MFAReadLoginEnforcement");


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
                Exception exception = this.ExceptionFactory("MFAReadLoginEnforcement", response);
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
        public async Task<VaultResponse<Object>> MFAReadLoginEnforcementAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->MFAReadLoginEnforcement");



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
                Exception exception = this.ExceptionFactory("MFAReadLoginEnforcement", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Create or update a login enforcement 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAWriteLoginEnforcementRequest"></param>
        /// <param name="name">Name for this login enforcement configuration</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> MFAWriteLoginEnforcement(string name, MFAWriteLoginEnforcementRequest mFAWriteLoginEnforcementRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->MFAWriteLoginEnforcement");


            // verify the required parameter 'mFAWriteLoginEnforcementRequest' is set
            if (mFAWriteLoginEnforcementRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAWriteLoginEnforcementRequest' when calling Identity->MFAWriteLoginEnforcement");

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





            requestOptions.Data = mFAWriteLoginEnforcementRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/mfa/login-enforcement/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAWriteLoginEnforcement", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create or update a login enforcement 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="mFAWriteLoginEnforcementRequest"></param>
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
        public async Task<VaultResponse<Object>> MFAWriteLoginEnforcementAsync(string name, MFAWriteLoginEnforcementRequest mFAWriteLoginEnforcementRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->MFAWriteLoginEnforcement");


            // verify the required parameter 'mFAWriteLoginEnforcementRequest' is set
            if (mFAWriteLoginEnforcementRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'mFAWriteLoginEnforcementRequest' when calling Identity->MFAWriteLoginEnforcement");


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



            requestOptions.Data = mFAWriteLoginEnforcementRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/mfa/login-enforcement/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("MFAWriteLoginEnforcement", response);
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
        public VaultResponse<Object> OIDCDeleteAssignment(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCDeleteAssignment");


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
                Exception exception = this.ExceptionFactory("OIDCDeleteAssignment", response);
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
        public async Task<VaultResponse<Object>> OIDCDeleteAssignmentAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCDeleteAssignment");



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
                Exception exception = this.ExceptionFactory("OIDCDeleteAssignment", response);
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
        public VaultResponse<Object> OIDCDeleteClient(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCDeleteClient");


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
                Exception exception = this.ExceptionFactory("OIDCDeleteClient", response);
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
        public async Task<VaultResponse<Object>> OIDCDeleteClientAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCDeleteClient");



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
                Exception exception = this.ExceptionFactory("OIDCDeleteClient", response);
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
        public VaultResponse<Object> OIDCDeleteKey(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCDeleteKey");


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
                Exception exception = this.ExceptionFactory("OIDCDeleteKey", response);
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
        public async Task<VaultResponse<Object>> OIDCDeleteKeyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCDeleteKey");



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
                Exception exception = this.ExceptionFactory("OIDCDeleteKey", response);
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
        public VaultResponse<Object> OIDCDeleteProvider(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCDeleteProvider");


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
                Exception exception = this.ExceptionFactory("OIDCDeleteProvider", response);
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
        public async Task<VaultResponse<Object>> OIDCDeleteProviderAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCDeleteProvider");



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
                Exception exception = this.ExceptionFactory("OIDCDeleteProvider", response);
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
        public VaultResponse<Object> OIDCDeleteRole(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCDeleteRole");


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
                Exception exception = this.ExceptionFactory("OIDCDeleteRole", response);
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
        public async Task<VaultResponse<Object>> OIDCDeleteRoleAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCDeleteRole");



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
                Exception exception = this.ExceptionFactory("OIDCDeleteRole", response);
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
        public VaultResponse<Object> OIDCDeleteScope(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCDeleteScope");


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
                Exception exception = this.ExceptionFactory("OIDCDeleteScope", response);
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
        public async Task<VaultResponse<Object>> OIDCDeleteScopeAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCDeleteScope");



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
                Exception exception = this.ExceptionFactory("OIDCDeleteScope", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Verify the authenticity of an OIDC token 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCIntrospectRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OIDCIntrospect(OIDCIntrospectRequest oIDCIntrospectRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'oIDCIntrospectRequest' is set
            if (oIDCIntrospectRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCIntrospectRequest' when calling Identity->OIDCIntrospect");

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





            requestOptions.Data = oIDCIntrospectRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/introspect", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCIntrospect", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Verify the authenticity of an OIDC token 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCIntrospectRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OIDCIntrospectAsync(OIDCIntrospectRequest oIDCIntrospectRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'oIDCIntrospectRequest' is set
            if (oIDCIntrospectRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCIntrospectRequest' when calling Identity->OIDCIntrospect");


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



            requestOptions.Data = oIDCIntrospectRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/introspect", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCIntrospect", response);
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
        public VaultResponse<Object> OIDCListAssignments(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("OIDCListAssignments", response);
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
        public async Task<VaultResponse<Object>> OIDCListAssignmentsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("OIDCListAssignments", response);
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
        public VaultResponse<Object> OIDCListClients(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("OIDCListClients", response);
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
        public async Task<VaultResponse<Object>> OIDCListClientsAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("OIDCListClients", response);
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
        public VaultResponse<Object> OIDCListKeys(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("OIDCListKeys", response);
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
        public async Task<VaultResponse<Object>> OIDCListKeysAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("OIDCListKeys", response);
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
        public VaultResponse<Object> OIDCListProviders(string allowedClientId = default(string), TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("OIDCListProviders", response);
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
        public async Task<VaultResponse<Object>> OIDCListProvidersAsync(string allowedClientId = default(string), TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("OIDCListProviders", response);
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
        public VaultResponse<Object> OIDCListRoles(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("OIDCListRoles", response);
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
        public async Task<VaultResponse<Object>> OIDCListRolesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("OIDCListRoles", response);
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
        public VaultResponse<Object> OIDCListScopes(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("OIDCListScopes", response);
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
        public async Task<VaultResponse<Object>> OIDCListScopesAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("OIDCListScopes", response);
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
        public VaultResponse<Object> OIDCReadAssignment(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadAssignment");


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
                Exception exception = this.ExceptionFactory("OIDCReadAssignment", response);
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
        public async Task<VaultResponse<Object>> OIDCReadAssignmentAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadAssignment");



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
                Exception exception = this.ExceptionFactory("OIDCReadAssignment", response);
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
        public VaultResponse<Object> OIDCReadClient(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadClient");


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
                Exception exception = this.ExceptionFactory("OIDCReadClient", response);
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
        public async Task<VaultResponse<Object>> OIDCReadClientAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadClient");



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
                Exception exception = this.ExceptionFactory("OIDCReadClient", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// OIDC configuration 
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
        public VaultResponse<Object> OIDCReadConfig(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("OIDCReadConfig", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// OIDC configuration 
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
        public async Task<VaultResponse<Object>> OIDCReadConfigAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("OIDCReadConfig", response);
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
        public VaultResponse<Object> OIDCReadKey(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadKey");


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
                Exception exception = this.ExceptionFactory("OIDCReadKey", response);
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
        public async Task<VaultResponse<Object>> OIDCReadKeyAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadKey");



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
                Exception exception = this.ExceptionFactory("OIDCReadKey", response);
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
        public VaultResponse<Object> OIDCReadProvider(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadProvider");


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
                Exception exception = this.ExceptionFactory("OIDCReadProvider", response);
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
        public async Task<VaultResponse<Object>> OIDCReadProviderAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadProvider");



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
                Exception exception = this.ExceptionFactory("OIDCReadProvider", response);
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
        public VaultResponse<Object> OIDCReadProviderAuthorize(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadProviderAuthorize");


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
                Exception exception = this.ExceptionFactory("OIDCReadProviderAuthorize", response);
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
        public async Task<VaultResponse<Object>> OIDCReadProviderAuthorizeAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadProviderAuthorize");



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
                Exception exception = this.ExceptionFactory("OIDCReadProviderAuthorize", response);
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
        public VaultResponse<Object> OIDCReadProviderUserInfo(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadProviderUserInfo");


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
                Exception exception = this.ExceptionFactory("OIDCReadProviderUserInfo", response);
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
        public async Task<VaultResponse<Object>> OIDCReadProviderUserInfoAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadProviderUserInfo");



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
                Exception exception = this.ExceptionFactory("OIDCReadProviderUserInfo", response);
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
        public VaultResponse<Object> OIDCReadProviderWellKnownKeys(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadProviderWellKnownKeys");


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
                Exception exception = this.ExceptionFactory("OIDCReadProviderWellKnownKeys", response);
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
        public async Task<VaultResponse<Object>> OIDCReadProviderWellKnownKeysAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadProviderWellKnownKeys");



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
                Exception exception = this.ExceptionFactory("OIDCReadProviderWellKnownKeys", response);
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
        public VaultResponse<Object> OIDCReadProviderWellKnownOpenIDConfiguration(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadProviderWellKnownOpenIDConfiguration");


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
                Exception exception = this.ExceptionFactory("OIDCReadProviderWellKnownOpenIDConfiguration", response);
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
        public async Task<VaultResponse<Object>> OIDCReadProviderWellKnownOpenIDConfigurationAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadProviderWellKnownOpenIDConfiguration");



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
                Exception exception = this.ExceptionFactory("OIDCReadProviderWellKnownOpenIDConfiguration", response);
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
        public VaultResponse<Object> OIDCReadRole(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadRole");


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
                Exception exception = this.ExceptionFactory("OIDCReadRole", response);
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
        public async Task<VaultResponse<Object>> OIDCReadRoleAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadRole");



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
                Exception exception = this.ExceptionFactory("OIDCReadRole", response);
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
        public VaultResponse<Object> OIDCReadScope(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadScope");


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
                Exception exception = this.ExceptionFactory("OIDCReadScope", response);
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
        public async Task<VaultResponse<Object>> OIDCReadScopeAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadScope");



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
                Exception exception = this.ExceptionFactory("OIDCReadScope", response);
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
        public VaultResponse<Object> OIDCReadToken(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadToken");


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
                Exception exception = this.ExceptionFactory("OIDCReadToken", response);
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
        public async Task<VaultResponse<Object>> OIDCReadTokenAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCReadToken");



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
                Exception exception = this.ExceptionFactory("OIDCReadToken", response);
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
        public VaultResponse<Object> OIDCReadWellKnownKeys(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("OIDCReadWellKnownKeys", response);
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
        public async Task<VaultResponse<Object>> OIDCReadWellKnownKeysAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("OIDCReadWellKnownKeys", response);
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
        public VaultResponse<Object> OIDCReadWellKnownOpenIDConfiguration(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("OIDCReadWellKnownOpenIDConfiguration", response);
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
        public async Task<VaultResponse<Object>> OIDCReadWellKnownOpenIDConfigurationAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("OIDCReadWellKnownOpenIDConfiguration", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Rotate a named OIDC key. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCRotateKeyRequest"></param>
        /// <param name="name">Name of the key</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OIDCRotateKey(string name, OIDCRotateKeyRequest oIDCRotateKeyRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCRotateKey");


            // verify the required parameter 'oIDCRotateKeyRequest' is set
            if (oIDCRotateKeyRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCRotateKeyRequest' when calling Identity->OIDCRotateKey");

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





            requestOptions.Data = oIDCRotateKeyRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/key/{name}/rotate", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCRotateKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Rotate a named OIDC key. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCRotateKeyRequest"></param>
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
        public async Task<VaultResponse<Object>> OIDCRotateKeyAsync(string name, OIDCRotateKeyRequest oIDCRotateKeyRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCRotateKey");


            // verify the required parameter 'oIDCRotateKeyRequest' is set
            if (oIDCRotateKeyRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCRotateKeyRequest' when calling Identity->OIDCRotateKey");


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



            requestOptions.Data = oIDCRotateKeyRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/key/{name}/rotate", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCRotateKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteAssignmentRequest"></param>
        /// <param name="name">Name of the assignment</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OIDCWriteAssignment(string name, OIDCWriteAssignmentRequest oIDCWriteAssignmentRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteAssignment");


            // verify the required parameter 'oIDCWriteAssignmentRequest' is set
            if (oIDCWriteAssignmentRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteAssignmentRequest' when calling Identity->OIDCWriteAssignment");

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





            requestOptions.Data = oIDCWriteAssignmentRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/assignment/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteAssignment", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteAssignmentRequest"></param>
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
        public async Task<VaultResponse<Object>> OIDCWriteAssignmentAsync(string name, OIDCWriteAssignmentRequest oIDCWriteAssignmentRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteAssignment");


            // verify the required parameter 'oIDCWriteAssignmentRequest' is set
            if (oIDCWriteAssignmentRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteAssignmentRequest' when calling Identity->OIDCWriteAssignment");


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



            requestOptions.Data = oIDCWriteAssignmentRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/assignment/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteAssignment", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteClientRequest"></param>
        /// <param name="name">Name of the client.</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OIDCWriteClient(string name, OIDCWriteClientRequest oIDCWriteClientRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteClient");


            // verify the required parameter 'oIDCWriteClientRequest' is set
            if (oIDCWriteClientRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteClientRequest' when calling Identity->OIDCWriteClient");

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





            requestOptions.Data = oIDCWriteClientRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/client/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteClient", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteClientRequest"></param>
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
        public async Task<VaultResponse<Object>> OIDCWriteClientAsync(string name, OIDCWriteClientRequest oIDCWriteClientRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteClient");


            // verify the required parameter 'oIDCWriteClientRequest' is set
            if (oIDCWriteClientRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteClientRequest' when calling Identity->OIDCWriteClient");


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



            requestOptions.Data = oIDCWriteClientRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/client/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteClient", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// OIDC configuration 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteConfigRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OIDCWriteConfig(OIDCWriteConfigRequest oIDCWriteConfigRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'oIDCWriteConfigRequest' is set
            if (oIDCWriteConfigRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteConfigRequest' when calling Identity->OIDCWriteConfig");

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





            requestOptions.Data = oIDCWriteConfigRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/config", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteConfig", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// OIDC configuration 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteConfigRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> OIDCWriteConfigAsync(OIDCWriteConfigRequest oIDCWriteConfigRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'oIDCWriteConfigRequest' is set
            if (oIDCWriteConfigRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteConfigRequest' when calling Identity->OIDCWriteConfig");


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



            requestOptions.Data = oIDCWriteConfigRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/config", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteConfig", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// CRUD operations for OIDC keys. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteKeyRequest"></param>
        /// <param name="name">Name of the key</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OIDCWriteKey(string name, OIDCWriteKeyRequest oIDCWriteKeyRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteKey");


            // verify the required parameter 'oIDCWriteKeyRequest' is set
            if (oIDCWriteKeyRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteKeyRequest' when calling Identity->OIDCWriteKey");

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





            requestOptions.Data = oIDCWriteKeyRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/key/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// CRUD operations for OIDC keys. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteKeyRequest"></param>
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
        public async Task<VaultResponse<Object>> OIDCWriteKeyAsync(string name, OIDCWriteKeyRequest oIDCWriteKeyRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteKey");


            // verify the required parameter 'oIDCWriteKeyRequest' is set
            if (oIDCWriteKeyRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteKeyRequest' when calling Identity->OIDCWriteKey");


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



            requestOptions.Data = oIDCWriteKeyRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/key/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteKey", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteProviderRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OIDCWriteProvider(string name, OIDCWriteProviderRequest oIDCWriteProviderRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteProvider");


            // verify the required parameter 'oIDCWriteProviderRequest' is set
            if (oIDCWriteProviderRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteProviderRequest' when calling Identity->OIDCWriteProvider");

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





            requestOptions.Data = oIDCWriteProviderRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/provider/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteProvider", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteProviderRequest"></param>
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
        public async Task<VaultResponse<Object>> OIDCWriteProviderAsync(string name, OIDCWriteProviderRequest oIDCWriteProviderRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteProvider");


            // verify the required parameter 'oIDCWriteProviderRequest' is set
            if (oIDCWriteProviderRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteProviderRequest' when calling Identity->OIDCWriteProvider");


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



            requestOptions.Data = oIDCWriteProviderRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/provider/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteProvider", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteProviderAuthorizeRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OIDCWriteProviderAuthorize(string name, OIDCWriteProviderAuthorizeRequest oIDCWriteProviderAuthorizeRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteProviderAuthorize");


            // verify the required parameter 'oIDCWriteProviderAuthorizeRequest' is set
            if (oIDCWriteProviderAuthorizeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteProviderAuthorizeRequest' when calling Identity->OIDCWriteProviderAuthorize");

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





            requestOptions.Data = oIDCWriteProviderAuthorizeRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/provider/{name}/authorize", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteProviderAuthorize", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteProviderAuthorizeRequest"></param>
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
        public async Task<VaultResponse<Object>> OIDCWriteProviderAuthorizeAsync(string name, OIDCWriteProviderAuthorizeRequest oIDCWriteProviderAuthorizeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteProviderAuthorize");


            // verify the required parameter 'oIDCWriteProviderAuthorizeRequest' is set
            if (oIDCWriteProviderAuthorizeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteProviderAuthorizeRequest' when calling Identity->OIDCWriteProviderAuthorize");


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



            requestOptions.Data = oIDCWriteProviderAuthorizeRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/provider/{name}/authorize", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteProviderAuthorize", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteProviderTokenRequest"></param>
        /// <param name="name">Name of the provider</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OIDCWriteProviderToken(string name, OIDCWriteProviderTokenRequest oIDCWriteProviderTokenRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteProviderToken");


            // verify the required parameter 'oIDCWriteProviderTokenRequest' is set
            if (oIDCWriteProviderTokenRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteProviderTokenRequest' when calling Identity->OIDCWriteProviderToken");

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





            requestOptions.Data = oIDCWriteProviderTokenRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/provider/{name}/token", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteProviderToken", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteProviderTokenRequest"></param>
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
        public async Task<VaultResponse<Object>> OIDCWriteProviderTokenAsync(string name, OIDCWriteProviderTokenRequest oIDCWriteProviderTokenRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteProviderToken");


            // verify the required parameter 'oIDCWriteProviderTokenRequest' is set
            if (oIDCWriteProviderTokenRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteProviderTokenRequest' when calling Identity->OIDCWriteProviderToken");


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



            requestOptions.Data = oIDCWriteProviderTokenRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/provider/{name}/token", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteProviderToken", response);
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
        public VaultResponse<Object> OIDCWriteProviderUserInfo(string name, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteProviderUserInfo");


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
            var response = this.Client.Post<Object>("/identity/oidc/provider/{name}/userinfo", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteProviderUserInfo", response);
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
        public async Task<VaultResponse<Object>> OIDCWriteProviderUserInfoAsync(string name, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteProviderUserInfo");



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
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/provider/{name}/userinfo", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteProviderUserInfo", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// CRUD operations on OIDC Roles 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteRoleRequest"></param>
        /// <param name="name">Name of the role</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OIDCWriteRole(string name, OIDCWriteRoleRequest oIDCWriteRoleRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteRole");


            // verify the required parameter 'oIDCWriteRoleRequest' is set
            if (oIDCWriteRoleRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteRoleRequest' when calling Identity->OIDCWriteRole");

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





            requestOptions.Data = oIDCWriteRoleRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/role/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteRole", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// CRUD operations on OIDC Roles 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteRoleRequest"></param>
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
        public async Task<VaultResponse<Object>> OIDCWriteRoleAsync(string name, OIDCWriteRoleRequest oIDCWriteRoleRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteRole");


            // verify the required parameter 'oIDCWriteRoleRequest' is set
            if (oIDCWriteRoleRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteRoleRequest' when calling Identity->OIDCWriteRole");


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



            requestOptions.Data = oIDCWriteRoleRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/role/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteRole", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteScopeRequest"></param>
        /// <param name="name">Name of the scope</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> OIDCWriteScope(string name, OIDCWriteScopeRequest oIDCWriteScopeRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteScope");


            // verify the required parameter 'oIDCWriteScopeRequest' is set
            if (oIDCWriteScopeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteScopeRequest' when calling Identity->OIDCWriteScope");

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





            requestOptions.Data = oIDCWriteScopeRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/oidc/scope/{name}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteScope", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="oIDCWriteScopeRequest"></param>
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
        public async Task<VaultResponse<Object>> OIDCWriteScopeAsync(string name, OIDCWriteScopeRequest oIDCWriteScopeRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'name' is set
            if (name == null)
                throw new VaultApiException(400, "Missing required parameter 'name' when calling Identity->OIDCWriteScope");


            // verify the required parameter 'oIDCWriteScopeRequest' is set
            if (oIDCWriteScopeRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'oIDCWriteScopeRequest' when calling Identity->OIDCWriteScope");


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



            requestOptions.Data = oIDCWriteScopeRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/oidc/scope/{name}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("OIDCWriteScope", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update, read or delete an alias ID. 
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
        public VaultResponse<Object> PersonaIDDeleteByID(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->PersonaIDDeleteByID");


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
                Exception exception = this.ExceptionFactory("PersonaIDDeleteByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an alias ID. 
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
        public async Task<VaultResponse<Object>> PersonaIDDeleteByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->PersonaIDDeleteByID");



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
                Exception exception = this.ExceptionFactory("PersonaIDDeleteByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update, read or delete an alias ID. 
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
        public VaultResponse<Object> PersonaIDReadByID(string id, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->PersonaIDReadByID");


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
                Exception exception = this.ExceptionFactory("PersonaIDReadByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an alias ID. 
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
        public async Task<VaultResponse<Object>> PersonaIDReadByIDAsync(string id, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->PersonaIDReadByID");



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
                Exception exception = this.ExceptionFactory("PersonaIDReadByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Update, read or delete an alias ID. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaIDWriteByIDRequest"></param>
        /// <param name="id">ID of the persona</param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PersonaIDWriteByID(string id, PersonaIDWriteByIDRequest personaIDWriteByIDRequest, TimeSpan? wrapTTL = null)
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->PersonaIDWriteByID");


            // verify the required parameter 'personaIDWriteByIDRequest' is set
            if (personaIDWriteByIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'personaIDWriteByIDRequest' when calling Identity->PersonaIDWriteByID");

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





            requestOptions.Data = personaIDWriteByIDRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/persona/id/{id}", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaIDWriteByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Update, read or delete an alias ID. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaIDWriteByIDRequest"></param>
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
        public async Task<VaultResponse<Object>> PersonaIDWriteByIDAsync(string id, PersonaIDWriteByIDRequest personaIDWriteByIDRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {

            // verify the required parameter 'id' is set
            if (id == null)
                throw new VaultApiException(400, "Missing required parameter 'id' when calling Identity->PersonaIDWriteByID");


            // verify the required parameter 'personaIDWriteByIDRequest' is set
            if (personaIDWriteByIDRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'personaIDWriteByIDRequest' when calling Identity->PersonaIDWriteByID");


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



            requestOptions.Data = personaIDWriteByIDRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/persona/id/{id}", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaIDWriteByID", response);
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
        public VaultResponse<Object> PersonaListByID(TimeSpan? wrapTTL = null)
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
                Exception exception = this.ExceptionFactory("PersonaListByID", response);
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
        public async Task<VaultResponse<Object>> PersonaListByIDAsync(TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
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
                Exception exception = this.ExceptionFactory("PersonaListByID", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
        /// <summary>
        /// Create a new alias. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaWriteRequest"></param>
        /// <returns>VaultResponse of Object(void)</returns>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        public VaultResponse<Object> PersonaWrite(PersonaWriteRequest personaWriteRequest, TimeSpan? wrapTTL = null)
        {


            // verify the required parameter 'personaWriteRequest' is set
            if (personaWriteRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'personaWriteRequest' when calling Identity->PersonaWrite");

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





            requestOptions.Data = personaWriteRequest;


            // make the HTTP request
            var response = this.Client.Post<Object>("/identity/persona", requestOptions);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaWrite", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }


        /// <summary>
        /// Create a new alias. 
        /// </summary>
        /// <exception cref="VaultApiException">Thrown when fails to make API call</exception>
        /// <param name="personaWriteRequest"></param>
        /// <param name="wrapTTL">
        /// Sets the X-Vault-Wrap-TTL Header
        /// <remarks>
        /// This will take precedence over client level wrapTTL value
        /// </remarks>
        /// <see href="See https://www.vaultproject.io/docs/concepts/response-wrapping">Vault Response Wrapping</see>
        /// </param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of VaultResponse</returns>
        public async Task<VaultResponse<Object>> PersonaWriteAsync(PersonaWriteRequest personaWriteRequest, TimeSpan? wrapTTL = null, CancellationToken cancellationToken = default(CancellationToken))
        {


            // verify the required parameter 'personaWriteRequest' is set
            if (personaWriteRequest == null)
                throw new VaultApiException(400, "Missing required parameter 'personaWriteRequest' when calling Identity->PersonaWrite");


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



            requestOptions.Data = personaWriteRequest;
            // make the HTTP request
            var response = await this.AsynchronousClient.PostAsync<Object>("/identity/persona", requestOptions, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception exception = this.ExceptionFactory("PersonaWrite", response);
                if (exception != null) throw exception;
            }

            return ClientUtils.ToVaultResponse<Object>(response.RawContent);
        }
    }
}