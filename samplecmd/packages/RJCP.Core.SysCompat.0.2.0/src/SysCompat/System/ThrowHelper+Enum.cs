namespace System
{
    using System.Runtime.CompilerServices;

    public static partial class ThrowHelper
    {
        /// <summary>
        /// Throws an exception if the enumeration value is not defined.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="Enum"/></typeparam>
        /// <param name="value">The value to validate if it is defined within the enumeration.</param>
        /// <param name="paramName">Name of the <paramref name="value"/> parameter.</param>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="paramName"/> of enum is undefined.</exception>
        /// <remarks>
        /// Raises an exception if the value is not defined in the enumeration. For enumerations that have flags, the
        /// exception will be raised if the value doesn't match to a single entry in the enumeration.
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfEnumUndefined<T>(T value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
            where T : Enum
        {
            if (!Enum.IsDefined(typeof(T), value))
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} of enum {typeof(T).Name} is undefined");
        }

        /// <summary>
        /// Throws an exception if the enumeration value is missing a flag.
        /// </summary>
        /// <typeparam name="T">The type of the <see cref="Enum"/></typeparam>
        /// <param name="value">The value to validate if it is defined within the enumeration.</param>
        /// <param name="flag">The flag to test against.</param>
        /// <param name="paramName">Name of the <paramref name="value"/> parameter.</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="paramName"/> of enum is missing flag <paramref name="flag"/>.
        /// </exception>
        /// <remarks>
        /// Raises an exception if the value is not defined in the enumeration. For enumerations that have flags, the
        /// exception will be raised if the value doesn't match to a single entry in the enumeration.
        /// </remarks>
        public static void ThrowIfEnumHasNoFlag<T>(T value, T flag,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
            where T : Enum
        {
            if (!value.HasFlag(flag))
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} of enum {typeof(T).Name} is missing flag {flag}");
        }
    }
}
