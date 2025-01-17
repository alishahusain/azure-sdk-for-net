// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The user impact of the assessment. </summary>
    public readonly partial struct UserImpact : IEquatable<UserImpact>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="UserImpact"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public UserImpact(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LowValue = "Low";
        private const string ModerateValue = "Moderate";
        private const string HighValue = "High";

        /// <summary> Low. </summary>
        public static UserImpact Low { get; } = new UserImpact(LowValue);
        /// <summary> Moderate. </summary>
        public static UserImpact Moderate { get; } = new UserImpact(ModerateValue);
        /// <summary> High. </summary>
        public static UserImpact High { get; } = new UserImpact(HighValue);
        /// <summary> Determines if two <see cref="UserImpact"/> values are the same. </summary>
        public static bool operator ==(UserImpact left, UserImpact right) => left.Equals(right);
        /// <summary> Determines if two <see cref="UserImpact"/> values are not the same. </summary>
        public static bool operator !=(UserImpact left, UserImpact right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="UserImpact"/>. </summary>
        public static implicit operator UserImpact(string value) => new UserImpact(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is UserImpact other && Equals(other);
        /// <inheritdoc />
        public bool Equals(UserImpact other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
