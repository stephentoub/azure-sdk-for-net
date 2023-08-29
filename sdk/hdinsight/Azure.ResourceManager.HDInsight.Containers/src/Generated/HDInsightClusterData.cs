// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HDInsight.Containers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Containers
{
    /// <summary>
    /// A class representing the HDInsightCluster data model.
    /// The cluster.
    /// </summary>
    public partial class HDInsightClusterData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of HDInsightClusterData. </summary>
        /// <param name="location"> The location. </param>
        public HDInsightClusterData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of HDInsightClusterData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="clusterType"> The type of cluster. </param>
        /// <param name="deploymentId"> A unique id generated by the RP to identify the resource. </param>
        /// <param name="computeProfile"> The compute profile. </param>
        /// <param name="clusterProfile"> Cluster profile. </param>
        /// <param name="status"> Business status of the resource. </param>
        internal HDInsightClusterData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, HDInsightProvisioningStatus? provisioningState, string clusterType, string deploymentId, ComputeProfile computeProfile, ClusterProfile clusterProfile, string status) : base(id, name, resourceType, systemData, tags, location)
        {
            ProvisioningState = provisioningState;
            ClusterType = clusterType;
            DeploymentId = deploymentId;
            ComputeProfile = computeProfile;
            ClusterProfile = clusterProfile;
            Status = status;
        }

        /// <summary> Provisioning state of the resource. </summary>
        public HDInsightProvisioningStatus? ProvisioningState { get; }
        /// <summary> The type of cluster. </summary>
        public string ClusterType { get; set; }
        /// <summary> A unique id generated by the RP to identify the resource. </summary>
        public string DeploymentId { get; }
        /// <summary> The compute profile. </summary>
        internal ComputeProfile ComputeProfile { get; set; }
        /// <summary> The nodes definitions. </summary>
        public IList<ClusterComputeNodeProfile> ComputeNodes
        {
            get => ComputeProfile is null ? default : ComputeProfile.Nodes;
            set => ComputeProfile = new ComputeProfile(value);
        }

        /// <summary> Cluster profile. </summary>
        public ClusterProfile ClusterProfile { get; set; }
        /// <summary> Business status of the resource. </summary>
        public string Status { get; }
    }
}
