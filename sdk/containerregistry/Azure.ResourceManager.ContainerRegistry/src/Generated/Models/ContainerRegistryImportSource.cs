// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.ContainerRegistry.Models
{
    /// <summary> The ContainerRegistryImportSource. </summary>
    public partial class ContainerRegistryImportSource
    {
        /// <summary> Initializes a new instance of ContainerRegistryImportSource. </summary>
        /// <param name="sourceImage">
        /// Repository name of the source image.
        /// Specify an image by repository (&apos;hello-world&apos;). This will use the &apos;latest&apos; tag.
        /// Specify an image by tag (&apos;hello-world:latest&apos;).
        /// Specify an image by sha256-based manifest digest (&apos;hello-world@sha256:abc123&apos;).
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceImage"/> is null. </exception>
        public ContainerRegistryImportSource(string sourceImage)
        {
            if (sourceImage == null)
            {
                throw new ArgumentNullException(nameof(sourceImage));
            }

            SourceImage = sourceImage;
        }

        /// <summary> The resource identifier of the source Azure Container Registry. </summary>
        public ResourceIdentifier ResourceId { get; set; }
        /// <summary> The address of the source registry (e.g. &apos;mcr.microsoft.com&apos;). </summary>
        public string RegistryAddress { get; set; }
        /// <summary> Credentials used when importing from a registry uri. </summary>
        public ContainerRegistryImportSourceCredentials Credentials { get; set; }
        /// <summary>
        /// Repository name of the source image.
        /// Specify an image by repository (&apos;hello-world&apos;). This will use the &apos;latest&apos; tag.
        /// Specify an image by tag (&apos;hello-world:latest&apos;).
        /// Specify an image by sha256-based manifest digest (&apos;hello-world@sha256:abc123&apos;).
        /// </summary>
        public string SourceImage { get; }
    }
}
