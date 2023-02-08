// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0
//
// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.


using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vault.Client
{
    /// <summary>
    /// Response is the structure returned by the majority of the requests to Vault
    /// </summary>    
    /// <typeparam name="TData">The type of the data contained in the secret.</typeparam>
    public class VaultResponse<TData>
    {
        /// <summary>
        /// Request ID that generated this response
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestID;

        /// <summary>
        /// Lease ID associated with response
        /// </summary>
        [JsonProperty("lease_id")]
        public string LeaseID;

        /// <summary>
        /// Lease Duration is the TTL for the lease in seconds
        /// </summary>
        [JsonProperty("lease_duration")]
        public int LeaseDuration;

        /// <summary>
        /// Renewable indicates whether a lease is renewable
        /// </summary>
        [JsonProperty("renewable")]
        public bool Renewable;

        /// <summary>
        /// Any warnings related to the operation.
        /// <remarks>
        /// These are not issues that caused
        /// the command to fail, but thigns the client
        /// should be aware of. 
        /// </remarks>
        /// </summary>
        [JsonProperty("warnings")]
        public List<string> Warnings;

        /// <summary>
        /// Data is the actual contents of the response
        /// <remarks>
        /// The format of the data is up to the secret 
        /// backend that handles the request
        /// </remarks>
        /// </summary>
        [JsonProperty("data")]
        public TData Data;

        /// <summary>
        /// Auth specifies authentication information 
        /// attached to this response
        /// </summary>
        [JsonProperty("auth")]
        public ResponseAuth ResponseAuth;

        /// <summary>
        /// Relevant wrap information
        /// <remarks> 
        /// if not null means the initial response was
        /// wrapped in the cubbyhole of the given token,
        /// which has a TTL of the given  number of seconds
        /// </remarks>
        /// </summary>
        [JsonProperty("wrap_info")]
        public ResponseWrapInfo ResponseWrapInfo;
    }

    /// <summary>
    /// ResponseAuth contains authentication information if available
    /// </summary>
    public class ResponseAuth
    {
        /// <summary>
        /// Client Token
        /// </summary>
        [JsonProperty("client_token")]
        public string ClientToken;

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("accessor")]
        public string Accessor;

        /// <summary>
        /// List of associated policies 
        /// </summary>
        [JsonProperty("policies")]
        public List<string> Policies;

        /// <summary>
        /// List of token policies
        /// </summary>
        [JsonProperty("token_policies")]
        public List<string> TokenPolicies;

        /// <summary>
        /// List of identity policies
        /// </summary>
        [JsonProperty("identity_policies")]
        public List<string> IdentityPolicies;

        /// <summary>
        /// Associated Metadata
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata;

        /// <summary>
        /// Indicates whether the token is orphaned
        /// </summary>
        [JsonProperty("orphan")]
        public bool Orphan;

        /// <summary>
        /// Entity ID
        /// </summary>
        [JsonProperty("entity_id")]
        public string EntityID;

        /// <summary>
        /// Lease TTL in seconds
        /// </summary>
        [JsonProperty("lease_duration")]
        public int LeaseDuration;

        /// <summary>
        /// Renewable indicates whether the lease is renewable
        /// </summary>
        [JsonProperty("renewable")]
        public bool Renewable;

        /// <summary>
        /// MFA Requirement if it is specified
        /// </summary>
        [JsonProperty("mfa_requirement")]
        public MFARequirement MFARequirement;
    }

    /// <summary>
    /// ResponseWrapInfo contains wrapping information if available
    /// <remarks>
    /// If what is contained is an authentication token, the accessor
    /// for the token will be available in WrappedAccessor
    /// </remarks>
    /// </summary>    
    public class ResponseWrapInfo
    {
        /// <summary>
        /// Associated Token
        /// </summary>
        [JsonProperty("token")]
        public string Token;

        /// <summary>
        /// Accessor
        /// </summary>
        [JsonProperty("accessor")]
        public string Accessor;

        ///<summary>
        ///</summary>
        [JsonProperty("ttl")]
        public int TTL;

        /// <summary>
        /// Time the response was created
        /// </summary>
        [JsonProperty("creation_time")]
        public DateTime CreationTime;

        /// <summary>
        /// Creation Path
        /// </summary>
        [JsonProperty("creation_path")]
        public string CreationPath;

        /// <summary>
        /// Wrapped Accessor
        /// </summary>
        [JsonProperty("wrapped_accessor")]
        public string WrappedAccessor;
    }

    /// <summary>
    /// MFARequirement contains MFAConstraints that
    /// determine which MFA types should be used to 
    /// validate the request
    /// </summary>    
    public class MFARequirement
    {
        /// <summary>
        /// MFA Request ID
        /// </summary>
        [JsonProperty("mfa_request_id")]
        public string MFARequestId;

        /// <summary>
        /// MFAConstraints maps method ID to MFA constraints
        /// </summary>
        [JsonProperty("mfa_constraints")]
        public Dictionary<string, MFAConstraint> MFAConstraints;
    }

    /// <summary>
    /// MFA Constraint is a list of MFAMethodIDs
    /// </summary>
    public class MFAConstraint
    {
        /// <summary>
        /// Any is a list of MFAMethodIDs
        /// </summary>
        [JsonProperty("any")]
        public List<MFAMethodID> Any;
    }

    /// <summary>
    /// MFAMethodID defines information of an MFA Type
    /// </summary>
    public class MFAMethodID
    {
        /// <summary>
        /// MFA Type
        /// <remarks>
        /// Totp, Okta, Duo or PingID
        /// </remarks>
        /// </summary>
        [JsonProperty("type")]
        public string Type;

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public string ID;

        /// <summary>
        /// UsesPasscode indicates whether the MFA
        /// type uses a passcode or not
        /// </summary>
        [JsonProperty("uses_passcode")]
        public bool UsesPasscode;
    }
}
