// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> The NoneAuthTypeConnectionProperties. </summary>
    public partial class NoneAuthTypeConnectionProperties : CognitiveServicesConnectionProperties
    {
        /// <summary> Initializes a new instance of <see cref="NoneAuthTypeConnectionProperties"/>. </summary>
        public NoneAuthTypeConnectionProperties()
        {
            AuthType = ConnectionAuthType.None;
        }

        /// <summary> Initializes a new instance of <see cref="NoneAuthTypeConnectionProperties"/>. </summary>
        /// <param name="authType"> Authentication type of the connection target. </param>
        /// <param name="category"> Category of the connection. </param>
        /// <param name="createdByWorkspaceArmId"></param>
        /// <param name="error"> Provides the error message if the connection fails. </param>
        /// <param name="expiryOn"></param>
        /// <param name="group"> Group based on connection category. </param>
        /// <param name="isSharedToAll"></param>
        /// <param name="metadata"> Store user metadata for this connection. </param>
        /// <param name="peRequirement"> Specifies how private endpoints are used with this connection: 'Required', 'NotRequired', or 'NotApplicable'. </param>
        /// <param name="peStatus"> Specifies the status of private endpoints for this connection: 'Inactive', 'Active', or 'NotApplicable'. </param>
        /// <param name="sharedUserList"></param>
        /// <param name="target"> The connection URL to be used. </param>
        /// <param name="useWorkspaceManagedIdentity"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NoneAuthTypeConnectionProperties(ConnectionAuthType authType, CognitiveServicesConnectionCategory? category, ResourceIdentifier createdByWorkspaceArmId, string error, DateTimeOffset? expiryOn, CognitiveServicesConnectionGroup? group, bool? isSharedToAll, IDictionary<string, string> metadata, ManagedPERequirement? peRequirement, ManagedPEStatus? peStatus, IList<string> sharedUserList, string target, bool? useWorkspaceManagedIdentity, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(authType, category, createdByWorkspaceArmId, error, expiryOn, group, isSharedToAll, metadata, peRequirement, peStatus, sharedUserList, target, useWorkspaceManagedIdentity, serializedAdditionalRawData)
        {
            AuthType = authType;
        }
    }
}
