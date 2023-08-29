// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class DiskCreationData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("createOption"u8);
            writer.WriteStringValue(CreateOption.ToString());
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId"u8);
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(ImageReference))
            {
                writer.WritePropertyName("imageReference"u8);
                writer.WriteObjectValue(ImageReference);
            }
            if (Optional.IsDefined(GalleryImageReference))
            {
                writer.WritePropertyName("galleryImageReference"u8);
                writer.WriteObjectValue(GalleryImageReference);
            }
            if (Optional.IsDefined(SourceUri))
            {
                writer.WritePropertyName("sourceUri"u8);
                writer.WriteStringValue(SourceUri.AbsoluteUri);
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsDefined(UploadSizeBytes))
            {
                writer.WritePropertyName("uploadSizeBytes"u8);
                writer.WriteNumberValue(UploadSizeBytes.Value);
            }
            if (Optional.IsDefined(LogicalSectorSize))
            {
                writer.WritePropertyName("logicalSectorSize"u8);
                writer.WriteNumberValue(LogicalSectorSize.Value);
            }
            if (Optional.IsDefined(SecurityDataUri))
            {
                writer.WritePropertyName("securityDataUri"u8);
                writer.WriteStringValue(SecurityDataUri.AbsoluteUri);
            }
            if (Optional.IsDefined(IsPerformancePlusEnabled))
            {
                writer.WritePropertyName("performancePlus"u8);
                writer.WriteBooleanValue(IsPerformancePlusEnabled.Value);
            }
            if (Optional.IsDefined(ElasticSanResourceId))
            {
                writer.WritePropertyName("elasticSanResourceId"u8);
                writer.WriteStringValue(ElasticSanResourceId);
            }
            writer.WriteEndObject();
        }

        internal static DiskCreationData DeserializeDiskCreationData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DiskCreateOption createOption = default;
            Optional<ResourceIdentifier> storageAccountId = default;
            Optional<ImageDiskReference> imageReference = default;
            Optional<ImageDiskReference> galleryImageReference = default;
            Optional<Uri> sourceUri = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<string> sourceUniqueId = default;
            Optional<long> uploadSizeBytes = default;
            Optional<int> logicalSectorSize = default;
            Optional<Uri> securityDataUri = default;
            Optional<bool> performancePlus = default;
            Optional<ResourceIdentifier> elasticSanResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createOption"u8))
                {
                    createOption = new DiskCreateOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("imageReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageReference = ImageDiskReference.DeserializeImageDiskReference(property.Value);
                    continue;
                }
                if (property.NameEquals("galleryImageReference"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    galleryImageReference = ImageDiskReference.DeserializeImageDiskReference(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceUniqueId"u8))
                {
                    sourceUniqueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uploadSizeBytes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uploadSizeBytes = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("logicalSectorSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logicalSectorSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("securityDataUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    securityDataUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("performancePlus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    performancePlus = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("elasticSanResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elasticSanResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
            }
            return new DiskCreationData(createOption, storageAccountId.Value, imageReference.Value, galleryImageReference.Value, sourceUri.Value, sourceResourceId.Value, sourceUniqueId.Value, Optional.ToNullable(uploadSizeBytes), Optional.ToNullable(logicalSectorSize), securityDataUri.Value, Optional.ToNullable(performancePlus), elasticSanResourceId.Value);
        }
    }
}
