namespace System
{
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public static partial class ThrowHelper
    {
        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfZero(int value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value is 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} must be non-zero.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfZero(long value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value is 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} must be non-zero.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfZero(nint value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value is 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} must be non-zero.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfZero(float value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value == 0.0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} must be non-zero.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfZero(double value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value == 0.0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} must be non-zero.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfZero(uint value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value is 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} must be non-zero.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfZero(ulong value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value is 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} must be non-zero.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfZero(nuint value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value is 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} must be non-zero.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is negative.
        /// </summary>
        /// <param name="value">The argument to validate as non-negative.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNegative</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNegative(int value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value is < 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be a non-negative value.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is negative.
        /// </summary>
        /// <param name="value">The argument to validate as non-negative.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNegative</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNegative(long value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value is < 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be a non-negative value.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is negative.
        /// </summary>
        /// <param name="value">The argument to validate as non-negative.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNegative</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNegative(nint value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value is < 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be a non-negative value.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is negative.
        /// </summary>
        /// <param name="value">The argument to validate as non-negative.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNegative</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNegative(float value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < 0.0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be a non-negative value.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is negative.
        /// </summary>
        /// <param name="value">The argument to validate as non-negative.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNegative</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNegative(double value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < 0.0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be a non-negative value.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is negative or zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero or non-negative.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNegativeOrZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNegativeOrZero(int value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value is <= 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be a positive value.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is negative or zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero or non-negative.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNegativeOrZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNegativeOrZero(long value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value is <= 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be a positive value.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is negative or zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero or non-negative.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNegativeOrZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNegativeOrZero(nint value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value is <= 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be a positive value.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is negative or zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero or non-negative.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNegativeOrZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNegativeOrZero(float value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value <= 0.0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be a positive value.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is negative or zero.
        /// </summary>
        /// <param name="value">The argument to validate as non-zero or non-negative.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNegativeOrZero</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNegativeOrZero(double value,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value <= 0.0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be a positive value.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as not equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfEqual<T>(T value, T other,
            [CallerArgumentExpression(nameof(value))] string paramName = null) where T : IEquatable<T>
        {
            if (EqualityComparer<T>.Default.Equals(value, other))
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as not equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfEqual(int value, int other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value == other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as not equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfEqual(long value, long other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value == other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as not equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfEqual(nint value, nint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value == other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as not equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfEqual(float value, float other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value == other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as not equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfEqual(double value, double other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value == other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as not equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfEqual(uint value, uint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value == other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as not equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfEqual(ulong value, ulong other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value == other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as not equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfEqual(nuint value, nuint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value == other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is not equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNotEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNotEqual<T>(T value, T other,
            [CallerArgumentExpression(nameof(value))] string paramName = null) where T : IEquatable<T>
        {
            if (!EqualityComparer<T>.Default.Equals(value, other))
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is not equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNotEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNotEqual(int value, int other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value != other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is not equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNotEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNotEqual(long value, long other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value != other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is not equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNotEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNotEqual(nint value, nint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value != other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is not equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNotEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNotEqual(float value, float other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value != other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is not equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNotEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNotEqual(double value, double other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value != other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is not equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNotEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfNotEqual(uint value, uint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value != other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is not equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNotEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfNotEqual(ulong value, ulong other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value != other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is not equal to
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfNotEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfNotEqual(nuint value, nuint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value != other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfGreaterThan<T>(T value, T other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
            where T : IComparable<T>
        {
            if (Comparer<T>.Default.Compare(value, other) > 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfGreaterThan(int value, int other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value > other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfGreaterThan(long value, long other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value > other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfGreaterThan(nint value, nint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value > other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfGreaterThan(float value, float other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value > other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfGreaterThan(double value, double other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value > other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfGreaterThan(uint value, uint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value > other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfGreaterThan(ulong value, ulong other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value > other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfGreaterThan(nuint value, nuint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value > other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfGreaterThanOrEqual<T>(T value, T other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
            where T : IComparable<T>
        {
            if (Comparer<T>.Default.Compare(value, other) >= 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfGreaterThanOrEqual(int value, int other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfGreaterThanOrEqual(long value, long other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfGreaterThanOrEqual(nint value, nint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfGreaterThanOrEqual(float value, float other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfGreaterThanOrEqual(double value, double other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfGreaterThanOrEqual(uint value, uint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfGreaterThanOrEqual(ulong value, ulong other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is greater than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as less than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfGreaterThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfGreaterThanOrEqual(nuint value, nuint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be less than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfLessThan<T>(T value, T other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
            where T : IComparable<T>
        {
            if (Comparer<T>.Default.Compare(value, other) < 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfLessThan(int value, int other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfLessThan(long value, long other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfLessThan(nint value, nint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfLessThan(float value, float other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfLessThan(double value, double other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfLessThan(uint value, uint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfLessThan(ulong value, ulong other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than or equal to <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThan</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfLessThan(nuint value, nuint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than or equal to '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfLessThanOrEqual<T>(T value, T other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
            where T : IComparable<T>
        {
            if (Comparer<T>.Default.Compare(value, other) <= 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfLessThanOrEqual(int value, int other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value <= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfLessThanOrEqual(long value, long other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value <= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfLessThanOrEqual(nint value, nint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value <= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfLessThanOrEqual(float value, float other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value <= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfLessThanOrEqual(double value, double other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value <= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfLessThanOrEqual(uint value, uint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value <= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfLessThanOrEqual(ulong value, ulong other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value <= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is less than or equal
        /// <paramref name="other"/>.
        /// </summary>
        /// <param name="value">The argument to validate as greater than <paramref name="other"/>.</param>
        /// <param name="other">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
        /// <remarks>
        /// Is used to implement CA1512.
        /// <para>
        /// If using with .NET Core 8.0 or later without considering source compatibility to older versions, then use
        /// <c>ArgumentOutOfRangeException.ThrowIfLessThanOrEqual</c> instead.
        /// </para>
        /// </remarks>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfLessThanOrEqual(nuint value, nuint other,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value <= other)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be greater than '{other}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfBetween<T>(T value, T lower, T upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
            where T : IComparable<T>
        {
            if (Comparer<T>.Default.Compare(value, lower) >= 0 &&
                Comparer<T>.Default.Compare(value, upper) <= 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfBetween(int value, int lower, int upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= lower && value <= upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfBetween(long value, long lower, long upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= lower && value <= upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfBetween(nint value, nint lower, nint upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= lower && value <= upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfBetween(float value, float lower, float upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= lower && value <= upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfBetween(double value, double lower, double upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= lower && value <= upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfBetween(uint value, uint lower, uint upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= lower && value <= upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfBetween(ulong value, ulong lower, ulong upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= lower && value <= upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfBetween(nuint value, nuint lower, nuint upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value >= lower && value <= upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must not be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNotBetween<T>(T value, T lower, T upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
            where T : IComparable<T>
        {
            if (Comparer<T>.Default.Compare(value, lower) < 0 ||
                Comparer<T>.Default.Compare(value, upper) > 0)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNotBetween(int value, int lower, int upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < lower || value > upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNotBetween(long value, long lower, long upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < lower || value > upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNotBetween(nint value, nint lower, nint upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < lower || value > upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNotBetween(float value, float lower, float upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < lower || value > upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        public static void ThrowIfNotBetween(double value, double lower, double upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < lower || value > upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfNotBetween(uint value, uint lower, uint upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < lower || value > upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfNotBetween(ulong value, ulong lower, ulong upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < lower || value > upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be between '{lower}' and '{upper}'.");
        }

        /// <summary>
        /// Throws an <see cref="ArgumentOutOfRangeException"/> if <paramref name="value"/> is between
        /// <paramref name="lower"/> and <paramref name="upper"/>.
        /// </summary>
        /// <param name="value">
        /// The argument to validate as note between <paramref name="lower"/> and <paramref name="upper"/>.
        /// </param>
        /// <param name="lower">The value to compare with <paramref name="value"/>.</param>
        /// <param name="upper">The value to compare with <paramref name="value"/>.</param>
        /// <param name="paramName">The name of the parameter with which <paramref name="value"/> corresponds.</param>
#if NET6_0_OR_GREATER || NET462_OR_GREATER
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
#endif
        [CLSCompliant(false)]
        public static void ThrowIfNotBetween(nuint value, nuint lower, nuint upper,
            [CallerArgumentExpression(nameof(value))] string paramName = null)
        {
            if (value < lower || value > upper)
                throw new ArgumentOutOfRangeException(paramName, value, $"{paramName} ('{value}') must be between '{lower}' and '{upper}'.");
        }
    }
}
