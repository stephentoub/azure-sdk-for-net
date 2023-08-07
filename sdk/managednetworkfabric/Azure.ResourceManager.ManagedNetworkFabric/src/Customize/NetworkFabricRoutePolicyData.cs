// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;
using System.ComponentModel;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricRoutePolicy data model.
    /// The RoutePolicy resource definition.
    /// </summary>
    public partial class NetworkFabricRoutePolicyData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of NetworkFabricRoutePolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="annotation"> Switch configuration description. </param>
        /// <param name="statements"> Route Policy statements. </param>
        /// <param name="networkFabricId"> Arm Resource ID of Network Fabric. </param>
        /// <param name="addressFamilyType"> AddressFamilyType. This parameter decides whether the given ipv4 or ipv6 route policy. </param>
        /// <param name="configurationState"> Configuration state of the resource. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="administrativeState"> Administrative state of the resource. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal NetworkFabricRoutePolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, IList<RoutePolicyStatementProperties> statements, ResourceIdentifier networkFabricId, AddressFamilyType? addressFamilyType, NetworkFabricConfigurationState? configurationState, NetworkFabricProvisioningState? provisioningState, NetworkFabricAdministrativeState? administrativeState) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            Statements = statements;
            NetworkFabricId = networkFabricId;
            AddressFamilyType = addressFamilyType;
            ConfigurationState = configurationState;
            ProvisioningState = provisioningState;
            AdministrativeState = administrativeState;
        }
    }
}
