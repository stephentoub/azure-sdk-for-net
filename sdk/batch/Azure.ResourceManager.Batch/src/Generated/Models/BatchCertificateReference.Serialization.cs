// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchCertificateReference : IUtf8JsonSerializable, IJsonModel<BatchCertificateReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchCertificateReference>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchCertificateReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchCertificateReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchCertificateReference)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(StoreLocation))
            {
                writer.WritePropertyName("storeLocation"u8);
                writer.WriteStringValue(StoreLocation.Value.ToSerialString());
            }
            if (Optional.IsDefined(StoreName))
            {
                writer.WritePropertyName("storeName"u8);
                writer.WriteStringValue(StoreName);
            }
            if (Optional.IsCollectionDefined(Visibility))
            {
                writer.WritePropertyName("visibility"u8);
                writer.WriteStartArray();
                foreach (var item in Visibility)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        BatchCertificateReference IJsonModel<BatchCertificateReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchCertificateReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchCertificateReference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchCertificateReference(document.RootElement, options);
        }

        internal static BatchCertificateReference DeserializeBatchCertificateReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            BatchCertificateStoreLocation? storeLocation = default;
            string storeName = default;
            IList<BatchCertificateVisibility> visibility = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storeLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storeLocation = property.Value.GetString().ToBatchCertificateStoreLocation();
                    continue;
                }
                if (property.NameEquals("storeName"u8))
                {
                    storeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("visibility"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchCertificateVisibility> array = new List<BatchCertificateVisibility>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToBatchCertificateVisibility());
                    }
                    visibility = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchCertificateReference(id, storeLocation, storeName, visibility ?? new ChangeTrackingList<BatchCertificateVisibility>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchCertificateReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchCertificateReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchCertificateReference)} does not support writing '{options.Format}' format.");
            }
        }

        BatchCertificateReference IPersistableModel<BatchCertificateReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchCertificateReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchCertificateReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchCertificateReference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchCertificateReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
