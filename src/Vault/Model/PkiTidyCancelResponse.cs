// Copyright (c) HashiCorp, Inc.
// SPDX-License-Identifier: MPL-2.0
//
// Code generated with OpenAPI Generator (https://openapi-generator.tech); DO NOT EDIT.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

using System.ComponentModel.DataAnnotations;
using FileParameter = Vault.Client.FileParameter;


namespace Vault.Model
{
    /// <summary>
    /// PkiTidyCancelResponse
    /// </summary>
    [DataContract(Name = "PkiTidyCancelResponse")]
    public partial class PkiTidyCancelResponse : IEquatable<PkiTidyCancelResponse>, IValidatableObject
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="PkiTidyCancelResponse" /> class.
        /// </summary>

        /// <param name="AcmeAccountDeletedCount">The number of revoked acme accounts removed.</param>

        /// <param name="AcmeAccountRevokedCount">The number of unused acme accounts revoked.</param>

        /// <param name="AcmeAccountSafetyBuffer">Safety buffer after creation after which accounts lacking orders are revoked.</param>

        /// <param name="AcmeOrdersDeletedCount">The number of expired, unused acme orders removed.</param>

        /// <param name="CertStoreDeletedCount">The number of certificate storage entries deleted.</param>

        /// <param name="CrossRevokedCertDeletedCount">CrossRevokedCertDeletedCount.</param>

        /// <param name="CurrentCertStoreCount">The number of revoked certificate entries deleted.</param>

        /// <param name="CurrentRevokedCertCount">The number of revoked certificate entries deleted.</param>

        /// <param name="Error">The error message.</param>

        /// <param name="InternalBackendUuid">InternalBackendUuid.</param>

        /// <param name="IssuerSafetyBuffer">Issuer safety buffer.</param>

        /// <param name="LastAutoTidyFinished">Time the last auto-tidy operation finished.</param>

        /// <param name="Message">Message of the operation.</param>

        /// <param name="MissingIssuerCertCount">MissingIssuerCertCount.</param>

        /// <param name="PauseDuration">Duration to pause between tidying certificates.</param>

        /// <param name="RevocationQueueDeletedCount">RevocationQueueDeletedCount.</param>

        /// <param name="RevocationQueueSafetyBuffer">Revocation queue safety buffer.</param>

        /// <param name="RevokedCertDeletedCount">The number of revoked certificate entries deleted.</param>

        /// <param name="SafetyBuffer">Safety buffer time duration.</param>

        /// <param name="State">One of Inactive, Running, Finished, or Error.</param>

        /// <param name="TidyAcme">Tidy Unused Acme Accounts, and Orders.</param>

        /// <param name="TidyCertStore">Tidy certificate store.</param>

        /// <param name="TidyCrossClusterRevokedCerts">Tidy the cross-cluster revoked certificate store.</param>

        /// <param name="TidyExpiredIssuers">Tidy expired issuers.</param>

        /// <param name="TidyMoveLegacyCaBundle">TidyMoveLegacyCaBundle.</param>

        /// <param name="TidyRevocationQueue">TidyRevocationQueue.</param>

        /// <param name="TidyRevokedCertIssuerAssociations">Tidy revoked certificate issuer associations.</param>

        /// <param name="TidyRevokedCerts">Tidy revoked certificates.</param>

        /// <param name="TimeFinished">Time the operation finished.</param>

        /// <param name="TimeStarted">Time the operation started.</param>

        /// <param name="TotalAcmeAccountCount">Total number of acme accounts iterated over.</param>


        public PkiTidyCancelResponse(int AcmeAccountDeletedCount = default(int), int AcmeAccountRevokedCount = default(int), int AcmeAccountSafetyBuffer = default(int), int AcmeOrdersDeletedCount = default(int), int CertStoreDeletedCount = default(int), int CrossRevokedCertDeletedCount = default(int), int CurrentCertStoreCount = default(int), int CurrentRevokedCertCount = default(int), string Error = default(string), string InternalBackendUuid = default(string), int IssuerSafetyBuffer = default(int), string LastAutoTidyFinished = default(string), string Message = default(string), int MissingIssuerCertCount = default(int), string PauseDuration = default(string), int RevocationQueueDeletedCount = default(int), int RevocationQueueSafetyBuffer = default(int), int RevokedCertDeletedCount = default(int), int SafetyBuffer = default(int), string State = default(string), bool TidyAcme = default(bool), bool TidyCertStore = default(bool), bool TidyCrossClusterRevokedCerts = default(bool), bool TidyExpiredIssuers = default(bool), bool TidyMoveLegacyCaBundle = default(bool), bool TidyRevocationQueue = default(bool), bool TidyRevokedCertIssuerAssociations = default(bool), bool TidyRevokedCerts = default(bool), string TimeFinished = default(string), string TimeStarted = default(string), int TotalAcmeAccountCount = default(int))
        {

            this.AcmeAccountDeletedCount = AcmeAccountDeletedCount;

            this.AcmeAccountRevokedCount = AcmeAccountRevokedCount;

            this.AcmeAccountSafetyBuffer = AcmeAccountSafetyBuffer;

            this.AcmeOrdersDeletedCount = AcmeOrdersDeletedCount;

            this.CertStoreDeletedCount = CertStoreDeletedCount;

            this.CrossRevokedCertDeletedCount = CrossRevokedCertDeletedCount;

            this.CurrentCertStoreCount = CurrentCertStoreCount;

            this.CurrentRevokedCertCount = CurrentRevokedCertCount;

            this.Error = Error;

            this.InternalBackendUuid = InternalBackendUuid;

            this.IssuerSafetyBuffer = IssuerSafetyBuffer;

            this.LastAutoTidyFinished = LastAutoTidyFinished;

            this.Message = Message;

            this.MissingIssuerCertCount = MissingIssuerCertCount;

            this.PauseDuration = PauseDuration;

            this.RevocationQueueDeletedCount = RevocationQueueDeletedCount;

            this.RevocationQueueSafetyBuffer = RevocationQueueSafetyBuffer;

            this.RevokedCertDeletedCount = RevokedCertDeletedCount;

            this.SafetyBuffer = SafetyBuffer;

            this.State = State;

            this.TidyAcme = TidyAcme;

            this.TidyCertStore = TidyCertStore;

            this.TidyCrossClusterRevokedCerts = TidyCrossClusterRevokedCerts;

            this.TidyExpiredIssuers = TidyExpiredIssuers;

            this.TidyMoveLegacyCaBundle = TidyMoveLegacyCaBundle;

            this.TidyRevocationQueue = TidyRevocationQueue;

            this.TidyRevokedCertIssuerAssociations = TidyRevokedCertIssuerAssociations;

            this.TidyRevokedCerts = TidyRevokedCerts;

            this.TimeFinished = TimeFinished;

            this.TimeStarted = TimeStarted;

            this.TotalAcmeAccountCount = TotalAcmeAccountCount;

        }

        /// <summary>
        /// The number of revoked acme accounts removed
        /// </summary>
        /// <value>The number of revoked acme accounts removed</value>
        [DataMember(Name = "acme_account_deleted_count", EmitDefaultValue = false)]

        public int AcmeAccountDeletedCount { get; set; }


        /// <summary>
        /// The number of unused acme accounts revoked
        /// </summary>
        /// <value>The number of unused acme accounts revoked</value>
        [DataMember(Name = "acme_account_revoked_count", EmitDefaultValue = false)]

        public int AcmeAccountRevokedCount { get; set; }


        /// <summary>
        /// Safety buffer after creation after which accounts lacking orders are revoked
        /// </summary>
        /// <value>Safety buffer after creation after which accounts lacking orders are revoked</value>
        [DataMember(Name = "acme_account_safety_buffer", EmitDefaultValue = false)]

        public int AcmeAccountSafetyBuffer { get; set; }


        /// <summary>
        /// The number of expired, unused acme orders removed
        /// </summary>
        /// <value>The number of expired, unused acme orders removed</value>
        [DataMember(Name = "acme_orders_deleted_count", EmitDefaultValue = false)]

        public int AcmeOrdersDeletedCount { get; set; }


        /// <summary>
        /// The number of certificate storage entries deleted
        /// </summary>
        /// <value>The number of certificate storage entries deleted</value>
        [DataMember(Name = "cert_store_deleted_count", EmitDefaultValue = false)]

        public int CertStoreDeletedCount { get; set; }


        /// <summary>
        /// Gets or Sets CrossRevokedCertDeletedCount
        /// </summary>
        [DataMember(Name = "cross_revoked_cert_deleted_count", EmitDefaultValue = false)]

        public int CrossRevokedCertDeletedCount { get; set; }


        /// <summary>
        /// The number of revoked certificate entries deleted
        /// </summary>
        /// <value>The number of revoked certificate entries deleted</value>
        [DataMember(Name = "current_cert_store_count", EmitDefaultValue = false)]

        public int CurrentCertStoreCount { get; set; }


        /// <summary>
        /// The number of revoked certificate entries deleted
        /// </summary>
        /// <value>The number of revoked certificate entries deleted</value>
        [DataMember(Name = "current_revoked_cert_count", EmitDefaultValue = false)]

        public int CurrentRevokedCertCount { get; set; }


        /// <summary>
        /// The error message
        /// </summary>
        /// <value>The error message</value>
        [DataMember(Name = "error", EmitDefaultValue = false)]

        public string Error { get; set; }


        /// <summary>
        /// Gets or Sets InternalBackendUuid
        /// </summary>
        [DataMember(Name = "internal_backend_uuid", EmitDefaultValue = false)]

        public string InternalBackendUuid { get; set; }


        /// <summary>
        /// Issuer safety buffer
        /// </summary>
        /// <value>Issuer safety buffer</value>
        [DataMember(Name = "issuer_safety_buffer", EmitDefaultValue = false)]

        public int IssuerSafetyBuffer { get; set; }


        /// <summary>
        /// Time the last auto-tidy operation finished
        /// </summary>
        /// <value>Time the last auto-tidy operation finished</value>
        [DataMember(Name = "last_auto_tidy_finished", EmitDefaultValue = false)]

        public string LastAutoTidyFinished { get; set; }


        /// <summary>
        /// Message of the operation
        /// </summary>
        /// <value>Message of the operation</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]

        public string Message { get; set; }


        /// <summary>
        /// Gets or Sets MissingIssuerCertCount
        /// </summary>
        [DataMember(Name = "missing_issuer_cert_count", EmitDefaultValue = false)]

        public int MissingIssuerCertCount { get; set; }


        /// <summary>
        /// Duration to pause between tidying certificates
        /// </summary>
        /// <value>Duration to pause between tidying certificates</value>
        [DataMember(Name = "pause_duration", EmitDefaultValue = false)]

        public string PauseDuration { get; set; }


        /// <summary>
        /// Gets or Sets RevocationQueueDeletedCount
        /// </summary>
        [DataMember(Name = "revocation_queue_deleted_count", EmitDefaultValue = false)]

        public int RevocationQueueDeletedCount { get; set; }


        /// <summary>
        /// Revocation queue safety buffer
        /// </summary>
        /// <value>Revocation queue safety buffer</value>
        [DataMember(Name = "revocation_queue_safety_buffer", EmitDefaultValue = false)]

        public int RevocationQueueSafetyBuffer { get; set; }


        /// <summary>
        /// The number of revoked certificate entries deleted
        /// </summary>
        /// <value>The number of revoked certificate entries deleted</value>
        [DataMember(Name = "revoked_cert_deleted_count", EmitDefaultValue = false)]

        public int RevokedCertDeletedCount { get; set; }


        /// <summary>
        /// Safety buffer time duration
        /// </summary>
        /// <value>Safety buffer time duration</value>
        [DataMember(Name = "safety_buffer", EmitDefaultValue = false)]

        public int SafetyBuffer { get; set; }


        /// <summary>
        /// One of Inactive, Running, Finished, or Error
        /// </summary>
        /// <value>One of Inactive, Running, Finished, or Error</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]

        public string State { get; set; }


        /// <summary>
        /// Tidy Unused Acme Accounts, and Orders
        /// </summary>
        /// <value>Tidy Unused Acme Accounts, and Orders</value>
        [DataMember(Name = "tidy_acme", EmitDefaultValue = true)]

        public bool TidyAcme { get; set; }


        /// <summary>
        /// Tidy certificate store
        /// </summary>
        /// <value>Tidy certificate store</value>
        [DataMember(Name = "tidy_cert_store", EmitDefaultValue = true)]

        public bool TidyCertStore { get; set; }


        /// <summary>
        /// Tidy the cross-cluster revoked certificate store
        /// </summary>
        /// <value>Tidy the cross-cluster revoked certificate store</value>
        [DataMember(Name = "tidy_cross_cluster_revoked_certs", EmitDefaultValue = true)]

        public bool TidyCrossClusterRevokedCerts { get; set; }


        /// <summary>
        /// Tidy expired issuers
        /// </summary>
        /// <value>Tidy expired issuers</value>
        [DataMember(Name = "tidy_expired_issuers", EmitDefaultValue = true)]

        public bool TidyExpiredIssuers { get; set; }


        /// <summary>
        /// Gets or Sets TidyMoveLegacyCaBundle
        /// </summary>
        [DataMember(Name = "tidy_move_legacy_ca_bundle", EmitDefaultValue = true)]

        public bool TidyMoveLegacyCaBundle { get; set; }


        /// <summary>
        /// Gets or Sets TidyRevocationQueue
        /// </summary>
        [DataMember(Name = "tidy_revocation_queue", EmitDefaultValue = true)]

        public bool TidyRevocationQueue { get; set; }


        /// <summary>
        /// Tidy revoked certificate issuer associations
        /// </summary>
        /// <value>Tidy revoked certificate issuer associations</value>
        [DataMember(Name = "tidy_revoked_cert_issuer_associations", EmitDefaultValue = true)]

        public bool TidyRevokedCertIssuerAssociations { get; set; }


        /// <summary>
        /// Tidy revoked certificates
        /// </summary>
        /// <value>Tidy revoked certificates</value>
        [DataMember(Name = "tidy_revoked_certs", EmitDefaultValue = true)]

        public bool TidyRevokedCerts { get; set; }


        /// <summary>
        /// Time the operation finished
        /// </summary>
        /// <value>Time the operation finished</value>
        [DataMember(Name = "time_finished", EmitDefaultValue = false)]

        public string TimeFinished { get; set; }


        /// <summary>
        /// Time the operation started
        /// </summary>
        /// <value>Time the operation started</value>
        [DataMember(Name = "time_started", EmitDefaultValue = false)]

        public string TimeStarted { get; set; }


        /// <summary>
        /// Total number of acme accounts iterated over
        /// </summary>
        /// <value>Total number of acme accounts iterated over</value>
        [DataMember(Name = "total_acme_account_count", EmitDefaultValue = false)]

        public int TotalAcmeAccountCount { get; set; }




        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PkiTidyCancelResponse {\n");
            sb.Append("  AcmeAccountDeletedCount: ").Append(AcmeAccountDeletedCount).Append("\n");
            sb.Append("  AcmeAccountRevokedCount: ").Append(AcmeAccountRevokedCount).Append("\n");
            sb.Append("  AcmeAccountSafetyBuffer: ").Append(AcmeAccountSafetyBuffer).Append("\n");
            sb.Append("  AcmeOrdersDeletedCount: ").Append(AcmeOrdersDeletedCount).Append("\n");
            sb.Append("  CertStoreDeletedCount: ").Append(CertStoreDeletedCount).Append("\n");
            sb.Append("  CrossRevokedCertDeletedCount: ").Append(CrossRevokedCertDeletedCount).Append("\n");
            sb.Append("  CurrentCertStoreCount: ").Append(CurrentCertStoreCount).Append("\n");
            sb.Append("  CurrentRevokedCertCount: ").Append(CurrentRevokedCertCount).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  InternalBackendUuid: ").Append(InternalBackendUuid).Append("\n");
            sb.Append("  IssuerSafetyBuffer: ").Append(IssuerSafetyBuffer).Append("\n");
            sb.Append("  LastAutoTidyFinished: ").Append(LastAutoTidyFinished).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MissingIssuerCertCount: ").Append(MissingIssuerCertCount).Append("\n");
            sb.Append("  PauseDuration: ").Append(PauseDuration).Append("\n");
            sb.Append("  RevocationQueueDeletedCount: ").Append(RevocationQueueDeletedCount).Append("\n");
            sb.Append("  RevocationQueueSafetyBuffer: ").Append(RevocationQueueSafetyBuffer).Append("\n");
            sb.Append("  RevokedCertDeletedCount: ").Append(RevokedCertDeletedCount).Append("\n");
            sb.Append("  SafetyBuffer: ").Append(SafetyBuffer).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TidyAcme: ").Append(TidyAcme).Append("\n");
            sb.Append("  TidyCertStore: ").Append(TidyCertStore).Append("\n");
            sb.Append("  TidyCrossClusterRevokedCerts: ").Append(TidyCrossClusterRevokedCerts).Append("\n");
            sb.Append("  TidyExpiredIssuers: ").Append(TidyExpiredIssuers).Append("\n");
            sb.Append("  TidyMoveLegacyCaBundle: ").Append(TidyMoveLegacyCaBundle).Append("\n");
            sb.Append("  TidyRevocationQueue: ").Append(TidyRevocationQueue).Append("\n");
            sb.Append("  TidyRevokedCertIssuerAssociations: ").Append(TidyRevokedCertIssuerAssociations).Append("\n");
            sb.Append("  TidyRevokedCerts: ").Append(TidyRevokedCerts).Append("\n");
            sb.Append("  TimeFinished: ").Append(TimeFinished).Append("\n");
            sb.Append("  TimeStarted: ").Append(TimeStarted).Append("\n");
            sb.Append("  TotalAcmeAccountCount: ").Append(TotalAcmeAccountCount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PkiTidyCancelResponse);
        }

        /// <summary>
        /// Returns true if PkiTidyCancelResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PkiTidyCancelResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PkiTidyCancelResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return
                (
                    this.AcmeAccountDeletedCount == input.AcmeAccountDeletedCount ||

                    this.AcmeAccountDeletedCount.Equals(input.AcmeAccountDeletedCount)
                ) &&
                (
                    this.AcmeAccountRevokedCount == input.AcmeAccountRevokedCount ||

                    this.AcmeAccountRevokedCount.Equals(input.AcmeAccountRevokedCount)
                ) &&
                (
                    this.AcmeAccountSafetyBuffer == input.AcmeAccountSafetyBuffer ||

                    this.AcmeAccountSafetyBuffer.Equals(input.AcmeAccountSafetyBuffer)
                ) &&
                (
                    this.AcmeOrdersDeletedCount == input.AcmeOrdersDeletedCount ||

                    this.AcmeOrdersDeletedCount.Equals(input.AcmeOrdersDeletedCount)
                ) &&
                (
                    this.CertStoreDeletedCount == input.CertStoreDeletedCount ||

                    this.CertStoreDeletedCount.Equals(input.CertStoreDeletedCount)
                ) &&
                (
                    this.CrossRevokedCertDeletedCount == input.CrossRevokedCertDeletedCount ||

                    this.CrossRevokedCertDeletedCount.Equals(input.CrossRevokedCertDeletedCount)
                ) &&
                (
                    this.CurrentCertStoreCount == input.CurrentCertStoreCount ||

                    this.CurrentCertStoreCount.Equals(input.CurrentCertStoreCount)
                ) &&
                (
                    this.CurrentRevokedCertCount == input.CurrentRevokedCertCount ||

                    this.CurrentRevokedCertCount.Equals(input.CurrentRevokedCertCount)
                ) &&
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))

                ) &&
                (
                    this.InternalBackendUuid == input.InternalBackendUuid ||
                    (this.InternalBackendUuid != null &&
                    this.InternalBackendUuid.Equals(input.InternalBackendUuid))

                ) &&
                (
                    this.IssuerSafetyBuffer == input.IssuerSafetyBuffer ||

                    this.IssuerSafetyBuffer.Equals(input.IssuerSafetyBuffer)
                ) &&
                (
                    this.LastAutoTidyFinished == input.LastAutoTidyFinished ||
                    (this.LastAutoTidyFinished != null &&
                    this.LastAutoTidyFinished.Equals(input.LastAutoTidyFinished))

                ) &&
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))

                ) &&
                (
                    this.MissingIssuerCertCount == input.MissingIssuerCertCount ||

                    this.MissingIssuerCertCount.Equals(input.MissingIssuerCertCount)
                ) &&
                (
                    this.PauseDuration == input.PauseDuration ||
                    (this.PauseDuration != null &&
                    this.PauseDuration.Equals(input.PauseDuration))

                ) &&
                (
                    this.RevocationQueueDeletedCount == input.RevocationQueueDeletedCount ||

                    this.RevocationQueueDeletedCount.Equals(input.RevocationQueueDeletedCount)
                ) &&
                (
                    this.RevocationQueueSafetyBuffer == input.RevocationQueueSafetyBuffer ||

                    this.RevocationQueueSafetyBuffer.Equals(input.RevocationQueueSafetyBuffer)
                ) &&
                (
                    this.RevokedCertDeletedCount == input.RevokedCertDeletedCount ||

                    this.RevokedCertDeletedCount.Equals(input.RevokedCertDeletedCount)
                ) &&
                (
                    this.SafetyBuffer == input.SafetyBuffer ||

                    this.SafetyBuffer.Equals(input.SafetyBuffer)
                ) &&
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))

                ) &&
                (
                    this.TidyAcme == input.TidyAcme ||

                    this.TidyAcme.Equals(input.TidyAcme)
                ) &&
                (
                    this.TidyCertStore == input.TidyCertStore ||

                    this.TidyCertStore.Equals(input.TidyCertStore)
                ) &&
                (
                    this.TidyCrossClusterRevokedCerts == input.TidyCrossClusterRevokedCerts ||

                    this.TidyCrossClusterRevokedCerts.Equals(input.TidyCrossClusterRevokedCerts)
                ) &&
                (
                    this.TidyExpiredIssuers == input.TidyExpiredIssuers ||

                    this.TidyExpiredIssuers.Equals(input.TidyExpiredIssuers)
                ) &&
                (
                    this.TidyMoveLegacyCaBundle == input.TidyMoveLegacyCaBundle ||

                    this.TidyMoveLegacyCaBundle.Equals(input.TidyMoveLegacyCaBundle)
                ) &&
                (
                    this.TidyRevocationQueue == input.TidyRevocationQueue ||

                    this.TidyRevocationQueue.Equals(input.TidyRevocationQueue)
                ) &&
                (
                    this.TidyRevokedCertIssuerAssociations == input.TidyRevokedCertIssuerAssociations ||

                    this.TidyRevokedCertIssuerAssociations.Equals(input.TidyRevokedCertIssuerAssociations)
                ) &&
                (
                    this.TidyRevokedCerts == input.TidyRevokedCerts ||

                    this.TidyRevokedCerts.Equals(input.TidyRevokedCerts)
                ) &&
                (
                    this.TimeFinished == input.TimeFinished ||
                    (this.TimeFinished != null &&
                    this.TimeFinished.Equals(input.TimeFinished))

                ) &&
                (
                    this.TimeStarted == input.TimeStarted ||
                    (this.TimeStarted != null &&
                    this.TimeStarted.Equals(input.TimeStarted))

                ) &&
                (
                    this.TotalAcmeAccountCount == input.TotalAcmeAccountCount ||

                    this.TotalAcmeAccountCount.Equals(input.TotalAcmeAccountCount)
                );

        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;


                hashCode = (hashCode * 59) + this.AcmeAccountDeletedCount.GetHashCode();

                hashCode = (hashCode * 59) + this.AcmeAccountRevokedCount.GetHashCode();

                hashCode = (hashCode * 59) + this.AcmeAccountSafetyBuffer.GetHashCode();

                hashCode = (hashCode * 59) + this.AcmeOrdersDeletedCount.GetHashCode();

                hashCode = (hashCode * 59) + this.CertStoreDeletedCount.GetHashCode();

                hashCode = (hashCode * 59) + this.CrossRevokedCertDeletedCount.GetHashCode();

                hashCode = (hashCode * 59) + this.CurrentCertStoreCount.GetHashCode();

                hashCode = (hashCode * 59) + this.CurrentRevokedCertCount.GetHashCode();
                if (this.Error != null)
                {
                    hashCode = (hashCode * 59) + this.Error.GetHashCode();
                }

                if (this.InternalBackendUuid != null)
                {
                    hashCode = (hashCode * 59) + this.InternalBackendUuid.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.IssuerSafetyBuffer.GetHashCode();
                if (this.LastAutoTidyFinished != null)
                {
                    hashCode = (hashCode * 59) + this.LastAutoTidyFinished.GetHashCode();
                }

                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.MissingIssuerCertCount.GetHashCode();
                if (this.PauseDuration != null)
                {
                    hashCode = (hashCode * 59) + this.PauseDuration.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.RevocationQueueDeletedCount.GetHashCode();

                hashCode = (hashCode * 59) + this.RevocationQueueSafetyBuffer.GetHashCode();

                hashCode = (hashCode * 59) + this.RevokedCertDeletedCount.GetHashCode();

                hashCode = (hashCode * 59) + this.SafetyBuffer.GetHashCode();
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.TidyAcme.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyCertStore.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyCrossClusterRevokedCerts.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyExpiredIssuers.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyMoveLegacyCaBundle.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyRevocationQueue.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyRevokedCertIssuerAssociations.GetHashCode();

                hashCode = (hashCode * 59) + this.TidyRevokedCerts.GetHashCode();
                if (this.TimeFinished != null)
                {
                    hashCode = (hashCode * 59) + this.TimeFinished.GetHashCode();
                }

                if (this.TimeStarted != null)
                {
                    hashCode = (hashCode * 59) + this.TimeStarted.GetHashCode();
                }


                hashCode = (hashCode * 59) + this.TotalAcmeAccountCount.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
