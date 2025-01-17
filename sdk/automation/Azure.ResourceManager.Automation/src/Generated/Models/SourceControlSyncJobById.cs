// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Definition of the source control sync job. </summary>
    public partial class SourceControlSyncJobById
    {
        /// <summary> Initializes a new instance of SourceControlSyncJobById. </summary>
        internal SourceControlSyncJobById()
        {
        }

        /// <summary> Initializes a new instance of SourceControlSyncJobById. </summary>
        /// <param name="id"> The id of the job. </param>
        /// <param name="sourceControlSyncJobId"> The source control sync job id. </param>
        /// <param name="createdOn"> The creation time of the job. </param>
        /// <param name="provisioningState"> The provisioning state of the job. </param>
        /// <param name="startOn"> The start time of the job. </param>
        /// <param name="endOn"> The end time of the job. </param>
        /// <param name="syncType"> The sync type. </param>
        /// <param name="exception"> The exceptions that occurred while running the sync job. </param>
        internal SourceControlSyncJobById(string id, string sourceControlSyncJobId, DateTimeOffset? createdOn, ProvisioningState? provisioningState, DateTimeOffset? startOn, DateTimeOffset? endOn, SyncType? syncType, string exception)
        {
            Id = id;
            SourceControlSyncJobId = sourceControlSyncJobId;
            CreatedOn = createdOn;
            ProvisioningState = provisioningState;
            StartOn = startOn;
            EndOn = endOn;
            SyncType = syncType;
            Exception = exception;
        }

        /// <summary> The id of the job. </summary>
        public string Id { get; }
        /// <summary> The source control sync job id. </summary>
        public string SourceControlSyncJobId { get; }
        /// <summary> The creation time of the job. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> The provisioning state of the job. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The start time of the job. </summary>
        public DateTimeOffset? StartOn { get; }
        /// <summary> The end time of the job. </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> The sync type. </summary>
        public SyncType? SyncType { get; }
        /// <summary> The exceptions that occurred while running the sync job. </summary>
        public string Exception { get; }
    }
}
