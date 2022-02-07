// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Monitor.Models;

namespace Azure.ResourceManager.Monitor
{
    public partial class LogProfileData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("tags");
            writer.WriteStartObject();
            foreach (var item in Tags)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteStringValue(item.Value);
            }
            writer.WriteEndObject();
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(StorageAccountId))
            {
                writer.WritePropertyName("storageAccountId");
                writer.WriteStringValue(StorageAccountId);
            }
            if (Optional.IsDefined(ServiceBusRuleId))
            {
                writer.WritePropertyName("serviceBusRuleId");
                writer.WriteStringValue(ServiceBusRuleId);
            }
            writer.WritePropertyName("locations");
            writer.WriteStartArray();
            foreach (var item in Locations)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("categories");
            writer.WriteStartArray();
            foreach (var item in Categories)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("retentionPolicy");
            writer.WriteObjectValue(RetentionPolicy);
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
