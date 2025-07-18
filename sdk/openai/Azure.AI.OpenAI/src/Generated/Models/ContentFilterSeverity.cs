// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.OpenAI
{
    /// <summary></summary>
    public readonly partial struct ContentFilterSeverity : IEquatable<ContentFilterSeverity>
    {
        private readonly string _value;
        private const string SafeValue = "safe";
        private const string LowValue = "low";
        private const string MediumValue = "medium";
        private const string HighValue = "high";

        /// <summary> Initializes a new instance of <see cref="ContentFilterSeverity"/>. </summary>
        /// <param name="value"> The value. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ContentFilterSeverity(string value)
        {
            Argument.AssertNotNull(value, nameof(value));

            _value = value;
        }

        /// <summary> Gets the Safe. </summary>
        public static ContentFilterSeverity Safe { get; } = new ContentFilterSeverity(SafeValue);

        /// <summary> Gets the Low. </summary>
        public static ContentFilterSeverity Low { get; } = new ContentFilterSeverity(LowValue);

        /// <summary> Gets the Medium. </summary>
        public static ContentFilterSeverity Medium { get; } = new ContentFilterSeverity(MediumValue);

        /// <summary> Gets the High. </summary>
        public static ContentFilterSeverity High { get; } = new ContentFilterSeverity(HighValue);

        /// <summary> Determines if two <see cref="ContentFilterSeverity"/> values are the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator ==(ContentFilterSeverity left, ContentFilterSeverity right) => left.Equals(right);

        /// <summary> Determines if two <see cref="ContentFilterSeverity"/> values are not the same. </summary>
        /// <param name="left"> The left value to compare. </param>
        /// <param name="right"> The right value to compare. </param>
        public static bool operator !=(ContentFilterSeverity left, ContentFilterSeverity right) => !left.Equals(right);

        /// <summary> Converts a string to a <see cref="ContentFilterSeverity"/>. </summary>
        /// <param name="value"> The value. </param>
        public static implicit operator ContentFilterSeverity(string value) => new ContentFilterSeverity(value);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ContentFilterSeverity other && Equals(other);

        /// <inheritdoc/>
        public bool Equals(ContentFilterSeverity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc/>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;

        /// <inheritdoc/>
        public override string ToString() => _value;
    }
}
