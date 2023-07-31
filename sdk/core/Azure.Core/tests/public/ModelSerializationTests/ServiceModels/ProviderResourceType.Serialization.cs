// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Security.AccessControl;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Core.Tests.Public.ResourceManager.Resources.Models
{
    public partial class ProviderResourceType : IUtf8JsonSerializable, IModelJsonSerializable<ProviderResourceType>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ProviderResourceType>)this).Serialize(writer, ModelSerializerOptions.DefaultServiceOptions);

        internal static ProviderResourceType DeserializeProviderResourceType(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultServiceOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceType = default;
            Optional<IReadOnlyList<string>> locations = default;
            Optional<IReadOnlyList<ProviderExtendedLocation>> locationMappings = default;
            Optional<IReadOnlyList<ResourceTypeAlias>> aliases = default;
            Optional<IReadOnlyList<string>> apiVersions = default;
            Optional<string> defaultApiVersion = default;
            Optional<IReadOnlyList<ZoneMapping>> zoneMappings = default;
            Optional<IReadOnlyList<ApiProfile>> apiProfiles = default;
            Optional<string> capabilities = default;
            Optional<IReadOnlyDictionary<string, string>> properties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("locationMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProviderExtendedLocation> array = new List<ProviderExtendedLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ProviderExtendedLocation.DeserializeProviderExtendedLocation(item, options));
                    }
                    locationMappings = array;
                    continue;
                }
                if (property.NameEquals("aliases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ResourceTypeAlias> array = new List<ResourceTypeAlias>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ResourceTypeAlias.DeserializeResourceTypeAlias(item, options));
                    }
                    aliases = array;
                    continue;
                }
                if (property.NameEquals("apiVersions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    apiVersions = array;
                    continue;
                }
                if (property.NameEquals("defaultApiVersion"u8))
                {
                    defaultApiVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zoneMappings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ZoneMapping> array = new List<ZoneMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ZoneMapping.DeserializeZoneMapping(item, options));
                    }
                    zoneMappings = array;
                    continue;
                }
                if (property.NameEquals("apiProfiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiProfile> array = new List<ApiProfile>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiProfile.DeserializeApiProfile(item, options));
                    }
                    apiProfiles = array;
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    capabilities = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
            }
            return new ProviderResourceType(resourceType.Value, Optional.ToList(locations), Optional.ToList(locationMappings), Optional.ToList(aliases), Optional.ToList(apiVersions), defaultApiVersion.Value, Optional.ToList(zoneMappings), Optional.ToList(apiProfiles), capabilities.Value, Optional.ToDictionary(properties));
        }

        void IModelJsonSerializable<ProviderResourceType>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            writer.WriteStartObject();
            if(Optional.IsDefined(ResourceType))
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (Optional.IsCollectionDefined(Locations))
            {
                writer.WritePropertyName("locations"u8);
                writer.WriteStartArray();
                foreach (var item in Locations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApiVersions))
            {
                writer.WritePropertyName("apiVersions"u8);
                writer.WriteStartArray();
                foreach (var item in ApiVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DefaultApiVersion))
            {
                writer.WritePropertyName("defaultApiVersion"u8);
                writer.WriteStringValue(DefaultApiVersion);
            }
            if (Optional.IsCollectionDefined(ApiProfiles))
            {
                writer.WritePropertyName("apiProfiles"u8);
                writer.WriteStartArray();
                foreach (var item in ApiProfiles)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ZoneMappings))
            {
                writer.WritePropertyName("zoneMappings"u8);
                writer.WriteStartArray();
                foreach (var item in ZoneMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LocationMappings))
            {
                writer.WritePropertyName("locationMappings"u8);
                writer.WriteStartArray();
                foreach (var item in LocationMappings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Capabilities))
            {
                writer.WritePropertyName("capabilities"u8);
                writer.WriteStringValue(Capabilities);
            }
            if (Optional.IsCollectionDefined(Aliases))
            {
                writer.WritePropertyName("aliases"u8);
                writer.WriteStartArray();
                foreach (var item in Aliases)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        private struct ProviderResourceTypeProperties
        {
            public Optional<string> ResourceType { get; set; }
            public Optional<IReadOnlyList<string>> Locations { get; set; }
            public Optional<IReadOnlyList<ProviderExtendedLocation>> LocationMappings { get; set; }
            public Optional<IReadOnlyList<ResourceTypeAlias>> Aliases { get; set; }
            public Optional<IReadOnlyList<string>> ApiVersions { get; set; }
            public Optional<string> DefaultApiVersion { get; set; }
            public Optional<IReadOnlyList<ZoneMapping>> ZoneMappings { get; set; }
            public Optional<IReadOnlyList<ApiProfile>> ApiProfiles { get; set; }
            public Optional<string> Capabilities { get; set; }
            public Optional<IReadOnlyDictionary<string, string>> Properties { get; set; }
        }

        ProviderResourceType IModelJsonSerializable<ProviderResourceType>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            if (!reader.TryDeserialize<ProviderResourceTypeProperties>(options, SetProperty, out var properties))
                return null;

            return new ProviderResourceType(
                properties.ResourceType.Value,
                Optional.ToList(properties.Locations),
                Optional.ToList(properties.LocationMappings),
                Optional.ToList(properties.Aliases),
                Optional.ToList(properties.ApiVersions),
                properties.DefaultApiVersion.Value,
                Optional.ToList(properties.ZoneMappings),
                Optional.ToList(properties.ApiProfiles),
                properties.Capabilities.Value,
                Optional.ToDictionary(properties.Properties));
        }

        private static void SetProperty(ReadOnlySpan<byte> propertyName, ref ProviderResourceTypeProperties properties, ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            if (propertyName.SequenceEqual("resourceType"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.ResourceType = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("locations"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Locations = reader.GetList<string>(options);
                return;
            }
            if (propertyName.SequenceEqual("locationMappings"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.LocationMappings = reader.GetList<ProviderExtendedLocation>(options);
                return;
            }
            if (propertyName.SequenceEqual("aliases"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Aliases = reader.GetList<ResourceTypeAlias>(options);
                return;
            }
            if (propertyName.SequenceEqual("apiVersions"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.ApiVersions = reader.GetList<string>(options);
                return;
            }
            if (propertyName.SequenceEqual("defaultApiVersion"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.DefaultApiVersion = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("zoneMappings"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.ZoneMappings = reader.GetList<ZoneMapping>(options);
                return;
            }
            if (propertyName.SequenceEqual("apiProfiles"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.ApiProfiles = reader.GetList<ApiProfile>(options);
                return;
            }
            if (propertyName.SequenceEqual("capabilities"u8))
            {
                reader.Read();
                if (reader.TokenType != JsonTokenType.Null)
                    properties.Capabilities = reader.GetString();
                return;
            }
            if (propertyName.SequenceEqual("properties"u8))
            {
                properties.Properties = reader.GetDictionary<string, string>(options);
                return;
            }
            reader.Skip();
        }

        ProviderResourceType IModelSerializable<ProviderResourceType>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeProviderResourceType(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ProviderResourceType>.Serialize(ModelSerializerOptions options) => this.ToBinaryData(options);
    }
}
