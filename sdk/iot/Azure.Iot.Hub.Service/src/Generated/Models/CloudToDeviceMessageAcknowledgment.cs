// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Indicates whether consumption or expiration of the message should post data to the feedback queue. For explanation on possible values, see https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-messages-c2d#message-feedback. </summary>
    public readonly partial struct CloudToDeviceMessageAcknowledgment : IEquatable<CloudToDeviceMessageAcknowledgment>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="CloudToDeviceMessageAcknowledgment"/> values are the same. </summary>
        public CloudToDeviceMessageAcknowledgment(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoneValue = "none";
        private const string PositiveValue = "positive";
        private const string NegativeValue = "negative";
        private const string FullValue = "full";

        /// <summary> none. </summary>
        public static CloudToDeviceMessageAcknowledgment None { get; } = new CloudToDeviceMessageAcknowledgment(NoneValue);
        /// <summary> positive. </summary>
        public static CloudToDeviceMessageAcknowledgment Positive { get; } = new CloudToDeviceMessageAcknowledgment(PositiveValue);
        /// <summary> negative. </summary>
        public static CloudToDeviceMessageAcknowledgment Negative { get; } = new CloudToDeviceMessageAcknowledgment(NegativeValue);
        /// <summary> full. </summary>
        public static CloudToDeviceMessageAcknowledgment Full { get; } = new CloudToDeviceMessageAcknowledgment(FullValue);
        /// <summary> Determines if two <see cref="CloudToDeviceMessageAcknowledgment"/> values are the same. </summary>
        public static bool operator ==(CloudToDeviceMessageAcknowledgment left, CloudToDeviceMessageAcknowledgment right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CloudToDeviceMessageAcknowledgment"/> values are not the same. </summary>
        public static bool operator !=(CloudToDeviceMessageAcknowledgment left, CloudToDeviceMessageAcknowledgment right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CloudToDeviceMessageAcknowledgment"/>. </summary>
        public static implicit operator CloudToDeviceMessageAcknowledgment(string value) => new CloudToDeviceMessageAcknowledgment(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CloudToDeviceMessageAcknowledgment other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CloudToDeviceMessageAcknowledgment other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
