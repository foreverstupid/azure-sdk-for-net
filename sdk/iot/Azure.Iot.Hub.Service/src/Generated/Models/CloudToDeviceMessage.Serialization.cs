// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Iot.Hub.Service.Models
{
    public partial class CloudToDeviceMessage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (MessageId != null)
            {
                writer.WritePropertyName("messageId");
                writer.WriteStringValue(MessageId);
            }
            if (Destination != null)
            {
                writer.WritePropertyName("destination");
                writer.WriteStringValue(Destination);
            }
            if (MessagePayload != null)
            {
                writer.WritePropertyName("messagePayload");
                writer.WriteObjectValue(MessagePayload);
            }
            if (MessageSchema != null)
            {
                writer.WritePropertyName("messageSchema");
                writer.WriteStringValue(MessageSchema);
            }
            if (ContentType != null)
            {
                writer.WritePropertyName("contentType");
                writer.WriteStringValue(ContentType);
            }
            if (ContentEncoding != null)
            {
                writer.WritePropertyName("contentEncoding");
                writer.WriteStringValue(ContentEncoding);
            }
            if (CreationTimeUtc != null)
            {
                writer.WritePropertyName("creationTimeUtc");
                writer.WriteStringValue(CreationTimeUtc.Value, "O");
            }
            if (ExpirationTimeUtc != null)
            {
                writer.WritePropertyName("expirationTimeUtc");
                writer.WriteStringValue(ExpirationTimeUtc.Value, "O");
            }
            if (CorrelationId != null)
            {
                writer.WritePropertyName("correlationId");
                writer.WriteStringValue(CorrelationId);
            }
            if (Acknowledgment != null)
            {
                writer.WritePropertyName("acknowledgment");
                writer.WriteStringValue(Acknowledgment.Value.ToString());
            }
            if (ApplicationProperties != null)
            {
                writer.WritePropertyName("applicationProperties");
                writer.WriteStartObject();
                foreach (var item in ApplicationProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }
    }
}
