/*
* The version of the OpenAPI document: 1.13.0
* Generated by: https://github.com/openapitools/openapi-generator.git
*/


using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Vault.Client
{
    /// <summary>
    /// 
    /// </summary>    
    /// <typeparam name="TData">The type of the data contained in the secret.</typeparam>
    public class VaultResponse<TData>
    {
        ///<summary>
        ///</summary>
        [JsonProperty("request_id")]
        public string RequestID;

        ///<summary>
        ///</summary>
        [JsonProperty("lease_id")]
        public string LeaseID;

        ///<summary>
        ///</summary>
        [JsonProperty("lease_duration")]
        public int LeaseDuration;

        ///<summary>
        ///</summary>
        [JsonProperty("renewable")]
        public bool Renewable;

        ///<summary>
        ///</summary>
        [JsonProperty("warnings")]
        public List<string> Warnings;

        ///<summary>
        ///</summary>
        [JsonProperty("data")]
        public TData Data;

        ///<summary>
        ///</summary>
        [JsonProperty("auth")]
        public ResponseAuth ResponseAuth;

        ///<summary>
        ///</summary>
        [JsonProperty("wrap_info")]
        public ResponseWrapInfo ResponseWrapInfo;
    }

    /// <summary>
    ///
    /// </summary>
    public class ResponseAuth
    {
        ///<summary>
        ///</summary>
        [JsonProperty("client_token")]
        public string ClientToken;

        ///<summary>
        ///</summary>
        [JsonProperty("accessor")]
        public string Accessor;

        ///<summary>
        ///</summary>
        [JsonProperty("policies")]
        public List<string> Policies;

        ///<summary>
        ///</summary>
        [JsonProperty("token_policies")]
        public List<string> TokenPolicies;

        ///<summary>
        ///</summary>
        [JsonProperty("identity_policies")]
        public List<string> IdentityPolicies;

        ///<summary>
        ///</summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata;

        ///<summary>
        ///</summary>
        [JsonProperty("orphan")]
        public bool orphan;

        ///<summary>
        ///</summary>
        [JsonProperty("entity_id")]
        public string EntityID;

        ///<summary>
        ///</summary>
        [JsonProperty("lease_duration")]
        public int LeaseDuration;

        ///<summary>
        ///</summary>
        [JsonProperty("renewable")]
        public bool Renewable;

        ///<summary>
        ///</summary>
        [JsonProperty("mfa_requirement")]
        public MFARequirement MFARequirement;
    }

    /// <summary>
    /// 
    /// </summary>    
    public class ResponseWrapInfo
    {
        ///<summary>
        ///</summary>
        [JsonProperty("token")]
        public string Token;

        ///<summary>
        ///</summary>
        [JsonProperty("accessor")]
        public string Accessor;

        ///<summary>
        ///</summary>
        [JsonProperty("ttl")]
        public int TTL;

        ///<summary>
        ///</summary>
        [JsonProperty("creation_time")]
        public DateTime CreationTime;

        ///<summary>
        ///</summary>
        [JsonProperty("creation_path")]
        public string CreationPath;

        ///<summary>
        ///</summary>
        [JsonProperty("wrappedAccessor")]
        public string WrappedAccessor;
    }

    /// <summary>
    /// 
    /// </summary>    
    public class MFARequirement
    {
        ///<summary>
        ///</summary>
        [JsonProperty("mfa_request_id")]
        public string MFARequestId;

        ///<summary>
        ///</summary>
        [JsonProperty("mfa_constraints")]
        public Dictionary<string, MFAConstraint> MFAConstraints;
    }

    ///<summary>
    ///</summary>
    public class MFAConstraint
    {
        ///<summary>
        ///</summary>
        [JsonProperty("any")]
        public List<MFAMethodID> Any;
    }

    ///<summary>
    ///</summary>
    public class MFAMethodID
    {
        ///<summary>
        ///</summary>
        [JsonProperty("type")]
        public string Type;

        ///<summary>
        ///</summary>
        [JsonProperty("id")]
        public string ID;

        ///<summary>
        ///</summary>
        [JsonProperty("uses_passcode")]
        public bool UsesPasscode;
    }
}