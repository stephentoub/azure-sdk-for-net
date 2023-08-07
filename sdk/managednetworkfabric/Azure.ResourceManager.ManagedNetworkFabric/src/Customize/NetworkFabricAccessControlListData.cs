// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Azure.Core;
using Azure.ResourceManager.ManagedNetworkFabric.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ManagedNetworkFabric
{
    /// <summary>
    /// A class representing the NetworkFabricAccessControlList data model.
    /// The Access Control List resource definition.
    /// </summary>
    public partial class NetworkFabricAccessControlListData : TrackedResourceData
    {
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal NetworkFabricAccessControlListData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string annotation, NetworkFabricConfigurationType? configurationType, Uri aclsUri, IList<AccessControlListMatchConfiguration> matchConfigurations, IList<CommonDynamicMatchConfiguration> dynamicMatchConfigurations, DateTimeOffset? lastSyncedOn, NetworkFabricConfigurationState? configurationState, NetworkFabricProvisioningState? provisioningState, NetworkFabricAdministrativeState? administrativeState) : base(id, name, resourceType, systemData, tags, location)
        {
            Annotation = annotation;
            ConfigurationType = configurationType;
            AclsUri = aclsUri;
            MatchConfigurations = matchConfigurations;
            DynamicMatchConfigurations = dynamicMatchConfigurations;
            LastSyncedOn = lastSyncedOn;
            ConfigurationState = configurationState;
            ProvisioningState = provisioningState;
            AdministrativeState = administrativeState;
        }
    }
}
